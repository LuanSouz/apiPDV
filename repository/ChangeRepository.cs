using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiPDV.database;
using apiPDV.model;
namespace apiPDV.repository
{
    public class ChangeRepository : IChangeRepository
    {
        private readonly ApplicationDBContext _contexto;

        public ChangeRepository(ApplicationDBContext context)
        {
            _contexto = context;
        }
        public void add(Change change)
        {
            _contexto.Changes.Add(change);
        }

        
        public void remove(long id)
        {
            throw new NotImplementedException();
        }

        public void update(Change change)
        {
            _contexto.Changes.Update(change);
            _contexto.SaveChanges();
        }

         Change IChangeRepository.find(long id)
        {
            return _contexto.Changes.FirstOrDefault(cat => cat.Id == id);
        }

        public IEnumerable<Change> GetAll()
        {
            return _contexto.Changes.ToList();
        }

        public Change find(long id)
        {
            throw new NotImplementedException();
        }
    }
}
