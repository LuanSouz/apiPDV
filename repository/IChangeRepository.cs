using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiPDV.model;
namespace apiPDV.repository
{
   public interface IChangeRepository
    {
        IEnumerable<Change> GetAll();

        void add(Change change);

        Change find(long id);

        void remove(long id);
        void update(Change change);
    }
}
