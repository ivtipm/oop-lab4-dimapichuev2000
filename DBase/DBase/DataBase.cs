using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.IO;

namespace DBase
{
    class DataBase
    {
        ArrayList carFiles = new ArrayList();

        /// <summary>
        /// Возвращает коллекцию
        /// </summary>
        public ArrayList CarFiles
        {
            get
            {
                return carFiles;
            }
        }

        /// <summary>
        /// Добавление данные в коллекцию
        /// </summary>
        public void AddFile(CarFile carFile)
        {
            carFiles.Add(carFile);
        }

        /// <summary>
        /// Удаление всей коллекции
        /// </summary>
        public void DeleteAll() => carFiles.Clear();

        /// <summary>
        /// Удаление элемента коллекции по индексу
        /// </summary>
        public void DeleteFile(int number) => carFiles.RemoveAt(number);

        /// <summary>
        /// Изменяет страну производителя у заданного элемента
        /// </summary>
        public void ChangeManuf(string manuf, int index)
        {
            CarFile car = (CarFile)carFiles[index];
            car.ManufCar = manuf;
        }

        /// <summary>
        /// Изменяет модель машины у заданного элемента
        /// </summary>
        public void ChangeModel(string model, int index)
        {
            CarFile car = (CarFile)carFiles[index];
            car.ManufCar = model;
        }

        /// <summary>
        /// Изменяет год издания авто у заданного элемента
        /// </summary>
        public void ChangeYearRelease(ushort year, int index)
        {
            CarFile car = (CarFile)carFiles[index];
            if ((year < 1890) || (year > DateTime.Now.Year))
                throw new Exception("Год выпуска машины с 1890,не позднее " + DateTime.Now.Year);
            car.YearCar = year;
        }

        /// <summary>
        /// Изменяет кузов авто у заданного элемента
        /// </summary>
        public void ChangeBody(string body, int index)
        {
            CarFile car = (CarFile)carFiles[index];
            car.BodyCar = body;
        }

        /// <summary>
        /// Сохранение коллекции в файл
        /// </summary>
        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Unicode))
            {
                foreach (CarFile s in carFiles)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }

        /// <summary>
        /// Восстанавливает коллекцию, записанную в файл
        /// </summary>
        public void OpenFile(string filename)
        {
            if (!System.IO.File.Exists(filename))
                throw new Exception("Файл не существует");
            if (carFiles.Count != 0)
                DeleteAll();
            using (StreamReader sw = new StreamReader(filename))
            {
                while (!sw.EndOfStream)
                {
                    string str = sw.ReadLine();
                    String[] dataFromFile = str.Split(new String[] { "|" },
                        StringSplitOptions.RemoveEmptyEntries);
                    ushort ID= (ushort)Convert.ToInt32(dataFromFile[0]);
                    string Manuf = dataFromFile[1];
                    string Model = dataFromFile[2];
                    ushort Year = (ushort)Convert.ToInt32(dataFromFile[3]);
                    string Body = dataFromFile[4];
                    CarFile carFile = new CarFile(ID, Manuf, Model, Year, Body);
                    AddFile(carFile);
                }
            }
        }

        /// <summary>
        /// Поиск, -1 если элем не найден 
        /// </summary>
        public List<int> SearchFile(string search)
        {
            List<int> count = new List<int>();
            ushort numSearch;
            if (ushort.TryParse(search, out numSearch))
            {
                for (int i = 0; i < carFiles.Count; i++)
                {
                    CarFile car = (CarFile)carFiles[i];
                    if (car.IDCar == numSearch)
                    {
                        count.Add(i);
                        break;
                    }
                    else
                    {
                        if (car.YearCar == numSearch)
                            count.Add(i);
                    }
                }
                if (count.Count == 0)
                    count.Add(-1);
                return count;
            }
            search = search.ToLower(); 
            search = search.Replace(" ", "");
            for (int i = 0; i < carFiles.Count; i++)
            {
                CarFile car = (CarFile)carFiles[i];
                if (car.ManufCar.ToLower().Replace(" ", "").Contains(search))
                    count.Add(i);
                else
                    if (car.ModelCar.ToLower().Replace(" ", "").Contains(search))
                    count.Add(i);
                else
                    if (car.BodyCar.ToLower().Replace(" ", "").Contains(search))
                    count.Add(i);
            }
            if (count.Count == 0)
                count.Add(-1);
            return count;
        }

        public void Sort(SortDirection direction)
        {
            carFiles.Sort(new YearComparer(direction));
        }
    }
    public enum SortDirection
    {
        Ascending,  // по возр
        Descending  //по уб
    }
    /// <summary>
    /// Сравнение двух объеков 
    /// </summary>
    public class YearComparer : IComparer
    {
        private SortDirection m_direction = SortDirection.Ascending;

        public YearComparer() : base() { }

        public YearComparer(SortDirection direction)
        {
            this.m_direction = direction;
        }

        int IComparer.Compare(object x, object y)
        {
            CarFile car1 = (CarFile)x;
            CarFile car2 = (CarFile)y;

            return (this.m_direction == SortDirection.Ascending) ?
                car1.YearCar.CompareTo(car2.YearCar) :
                car2.YearCar.CompareTo(car1.YearCar);
        }
    }
}
