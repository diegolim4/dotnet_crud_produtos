using System;

namespace CRUD.Produtos
{
    public class Products : EntidadeBase // Essa classe vai herda da class base
    {
        //Atributos
        private string Name { get; set; }
        private string Description { get; set; }
        private int Price { get; set; }

        // Métodos
        public Products(int id, string name, string description, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
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
    }
}