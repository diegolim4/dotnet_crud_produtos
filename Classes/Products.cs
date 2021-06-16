using System;

namespace CRUD.Produtos
{
    public class Products : EntidadeBase // Essa classe vai herda da class base
    {
        //Atributos
        private string Name { get; set; }
        private string Description { get; set; }
        private float Price { get; set; }

        private bool Deleted {get ; set;}

        // Métodos
        public Products(int id, string name, string description, float price)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Deleted = false;
        }

        // Implementação do to string
        public override string ToString()
        {
            string show = "";
            show += "Nome: " + this.Name + Environment.NewLine;
            show += "Descrição: " + this.Description + Environment.NewLine;
            show += "Preço: " + this.Price + Environment.NewLine;
            return show;
        }

        //métodos de encapsulamento
        public string showName()
        {
            return this.Name;
        }
        public int showId()
        {
            return this.Id;
        }
        
        public void delete(){
            this.Deleted = true; 
        }

    }   

}