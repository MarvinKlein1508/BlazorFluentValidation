using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFluentValidation.Core.Models
{
    public class Chapter
    {
        public string Name { get; set; } = String.Empty;
        public int Pages { get; set; }
    }
}
