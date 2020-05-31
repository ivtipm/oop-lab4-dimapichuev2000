using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBase
{
    class CarFile
    {
        ushort ID; // id машины
        string Manuf; //  страна производителя 
        string Model; // марка машины (ford,BMW...),так же указывается полное имя машины (BMW i8)
        ushort Year; // год выпуска машины
        string Body; // кузов машины(купэ,седан...)
        

        public CarFile(ushort ID, string Manuf, string Model, ushort Year, string Body)
        {
            if ((Manuf == "") || (Model == "") || (Body == ""))
                throw new Exception("Все поля должны быть заполнены!");
            this.Manuf = Manuf;
            this.Model = Model;
            this.Body = Body;
            if ((Year < 1890) || (Year > DateTime.Now.Year))
                throw new Exception("Год выпуска машины с 1890,не позднее " + DateTime.Now.Year);
            this.Year = Year;
            this.ID = ID;
        }

        public string ManufCar
        {
            get
            {
                return Manuf;
            }

            set
            {
                Manuf = value;
            }
        }

        public string ModelCar
        {
            get
            {
                return Model;
            }

            set
            {
                Model = value;
            }
        }

        public ushort YearCar
        {
            get
            {
                return Year;
            }

            set
            {
                Year = value;
            }
        }

        public string BodyCar
        {
            get
            {
                return Body;
            }

            set
            {
                Body = value;
            }
        }

        public ushort IDCar
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public override string ToString()
        {
            return ID + "|" + Manuf + "|" + Model + "|" +
                Year + "|" + Body;
        }
    }
}

