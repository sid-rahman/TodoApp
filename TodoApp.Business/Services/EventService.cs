using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Business.DTOs;
using TodoApp.Data.Entities;
using TodoApp.Data.Repositories;

namespace TodoApp.Business.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        public List<Event> GetAllEvents()
        {
            var events = eventRepository.FindAll();
            return events;
        }

        public Event GetEvent(int id)
        {
            var evt = eventRepository.FindById(id);
            return evt;
        }
        public Event CreateEvent(EventDTO dto)
        {
            var evt = new Event
            {

                Title = dto.Title,
                Description = dto.Description,
                Start = dto.Start,
                End = dto.End,
                IsAllDay = dto.IsAllDay,
                CreatedAt = DateTime.Now
            };

            eventRepository.Create(evt);
            return evt;
        }

        public Event UpdateEvent(EventDTO dto, int id)
        {
            var evt = eventRepository.FindById(id);

            if (evt == null) return null;

            evt.Title = dto.Title;
            evt.Description = dto.Description;
            evt.Start = dto.Start;
            evt.End = dto.End;
            evt.IsAllDay = dto.IsAllDay;

            eventRepository.Update(evt);
            return evt;
        }

        public void DeleteEvent(int id)
        {
            var evt = eventRepository.FindById(id);
            if (evt == null) return;

            eventRepository.Delete(evt);
        }
    }
}
