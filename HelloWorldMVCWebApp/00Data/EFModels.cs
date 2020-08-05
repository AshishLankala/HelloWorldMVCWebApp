using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVCWebApp._00Data
{
    public class Book
    {

        public int BookId { get; set; }
        [StringLength(50)]
        [Required]

        public string Title { get; set; }

        public string PublisherTitle { get; set; }

        public string Author { get; set; }
        //public Author Author { get; set; }
    }   
}
/* 
 dotnet tool install --global dotnet-ef 

dotnet ef migrations add InitialCreate   -- creates script 

 

dotnet ef database update  -- creates db and runs the migration 

 

dotnet ef migrations remove 

dotnet ef database drop */
