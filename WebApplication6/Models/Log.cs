using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Log
    {
        [Key]
        public string LogIdentity { get; set; }
        [Required]
        public string ErrorMessage { get; set; }

        //[Required]
        public DateTime CreationTime { get; set; }

        public string ApplicationName { get; set; }

        public Log()
        {
            LogIdentity = Guid.NewGuid().ToString();
        }
    }
}