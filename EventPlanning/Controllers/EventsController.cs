using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventPlanning.Models;



namespace EventPlanning.Controllers
{
    public class EventsController : Controller
    {
        EventsContext db;

        public EventsController( EventsContext context  )
        {
            db = context;
        }      

        public ActionResult AddEvent()
        {
            return View();
        }

        public ActionResult SavEvent(Event events)
        {
            db.Events.Add(events);
            db.SaveChanges();
            return RedirectPermanent("~/Events/GetEvents");
        }

        public ActionResult DelEvent(int id)
        {            
            Event even= db.Events.Find(id);
            db.Events.Remove(even);       
            db.SaveChanges();
            return RedirectPermanent("~/Events/GetEvents");
        }

        public ActionResult GetEvents()
        {
            return View(db.Events);    
        }
        
        [HttpGet]
        public ActionResult AddField(int id)
        {
            Field field = new Field();
            field.EventId = id;            
            return View(field);
        }

        [HttpPost]
        public ActionResult AddField(List<Field> fields)
        {
            db.Fields.AddRange(fields);
            db.SaveChanges();

            return RedirectPermanent("~/Events/GetEvents");
        }

        public ActionResult DelField(int id)
        {
            Field field = db.Fields.Find(id);
            db.Fields.Remove(field);
            db.SaveChanges();

            return RedirectPermanent("~/Events/GetEvents");
        }

        public ActionResult GetFields(int id)
        {
            var fields = db.Fields.Where(f => f.EventId == id);
            return View(fields);
        }
    }
}
