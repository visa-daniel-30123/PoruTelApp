using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoruTelApp
{
    public class Produs
    {
        public DtoProperty<int> id { get; set; }
        public DtoProperty<String> denumireProd { get; set; }
        public DtoProperty<int> cantitate { get; set; }
        public DtoProperty<double> pret { get; set; }

        public Produs()
        {
            this.id = new DtoProperty<int>(0);
            this.denumireProd = new DtoProperty<string>("");
            this.cantitate = new DtoProperty<int>(0);
            this.pret = new DtoProperty<double>(0.0);
        }
        public Produs(int x, String y)
        {
            this.id.Value = x;
            this.denumireProd.Value = y;
        }
        public Produs(int id, String denumire, int cantitate, double pret)
        {
            this.id = new DtoProperty<int>(id);
            this.denumireProd = new DtoProperty<string>(denumire);
            this.cantitate = new DtoProperty<int>(cantitate);
            this.pret = new DtoProperty<double>(pret);
        }
        
        public String Afis()
        {
            return $"{this.id.Value}  {this.denumireProd.Value}  {this.pret.Value}  {this.cantitate.Value}";
        }

        public void ZeroStock()
        {
            foreach (Produs p1 in MenuSingleton.Meniu.produse)
            {
                p1.cantitate.Value = 0;
            }
        }


    }
}
