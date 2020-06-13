using System;
using System.Collections.Generic;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity;


namespace EventPlanning.Models
{

    public class EventsContext : DbContext
    {

        public EventsContext(DbContextOptions<EventsContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Field> Fields { get; set; }
    }
}






    /*

    
     public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        {  }


        public DbSet<Event> Events { get; set; }
        public DbSet<Table> Headers { get; set; }

*/
