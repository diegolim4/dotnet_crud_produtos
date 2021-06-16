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
            throw new NotImplementedException();
        }

        public void Insert(Products entidade)
        {
            throw new NotImplementedException();
        }

        public List<Products> List()
        {
            throw new NotImplementedException();
        }

        public int NextId()
        {
            throw new NotImplementedException();
        }

        public Products ReturnId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Products entidade)
        {
            throw new NotImplementedException();
        }
    }
}