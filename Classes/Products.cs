namespace CRUD.Produtos
{
    public class Products : EntidadeBase // Essa classe vai herda da class base
    {
        //Atributos
        private  string Name {get; set;}
        private string Description {get; set;}
        private int Price{ get; set;}

        // Métodos
        public Products(int id, string name, string description, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price; 
        }
    }
}