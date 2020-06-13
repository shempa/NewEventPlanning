using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EventPlanning.Models
{
    public class Field
    {        
        public int Id { get; set; }
        public int? EventId { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }        
    }
}
