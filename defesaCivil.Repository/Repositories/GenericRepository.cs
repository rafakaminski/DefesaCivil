using defesaCivil.Domain.Entidades;
using defesaCivil.Repository.Context;
using defesaCivil.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defesaCivil.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity 
    {

        private defesaCivilContext _context;


        public GenericRepository(defesaCivilContext context)
        { _context = context; }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>(); 
        }

        public T Salvar(T entity)
        {
            if ((entity as BaseEntity).Id == 0)
                Add(entity);
            else
                Update(entity);

            _context.SaveChanges();
            return entity;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Remover(long Id)
        {
            var entidade = _context.Set<T>().First(c => c.Id == Id);
            _context.Set<T>().Remove(entidade);
            _context.SaveChanges();
        }
    }
}
