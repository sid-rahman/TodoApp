using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Business.DTOs;
using TodoApp.Data.Entities;

namespace TodoApp.Business.Services
{
    public interface IEventService
    {
        List<Event> GetAllEvents();
        Event GetEvent(int id);
        Event CreateEvent(EventDTO dto);
        Event UpdateEvent(EventDTO dto, int id);
        void DeleteEvent(int id);
    }
}
