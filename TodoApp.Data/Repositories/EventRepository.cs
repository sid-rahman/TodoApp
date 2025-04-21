using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Data.Entities;

namespace TodoApp.Data.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext context;

        public EventRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Event> FindAll()
        {
            return context.Events.OrderByDescending(e => e.Id).ToList();
        }

        public Event FindById(int id)
        {
            return context.Events.Find(id);
        }

        public void Create(Event evt)
        {
            context.Events.Add(evt);
            context.SaveChanges();
        }

        public void Update(Event evt)
        {
            context.Events.Update(evt);
            context.SaveChanges();
            
        }

        public void Delete(Event evt)
        {
            context.Events.Remove(evt);
            context.SaveChanges();
        }
    }
}
