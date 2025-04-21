using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Data.Entities;

namespace TodoApp.Data.Repositories
{
    public interface IEventRepository
    {
        List<Event> FindAll();
        Event FindById(int id);
        void Create(Event evt);
        void Update(Event evt);
        void Delete(Event evt);
    }
}
