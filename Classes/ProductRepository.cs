using System;
using System.Collections.Generic;
using CRUD.Produtos.interfaces;

namespace CRUD.Produtos
{
    // Colocando o repositório de métodos no repositório de produtos    
    public class ProductRepository : IRepository<Products> 
    {
        private List<Products> listaProdutos = new List<Products>(); //variável que terá a listaprodutos
        public void Delete(int id)
        {
            listaProdutos[id].delete() ;
        }

        public void Insert(Products entidade)
        {
            listaProdutos.Add(entidade);
        }

        public List<Products> List()
        {
            return listaProdutos;
        }

        public int NextId()
        {
            return listaProdutos.Count;
        }

        public Products ReturnId(int id)
        {
            return listaProdutos[id];
        }

        public void Update(int id, Products entidade)
        {
            listaProdutos[id] = entidade;
        }
    }
}