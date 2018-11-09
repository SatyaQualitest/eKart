using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKart.Api.Model
{
    public class Product
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Name {get; set; }
    }
}