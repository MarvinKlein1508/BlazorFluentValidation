using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFluentValidation.Core.Models
{
    public class Book
    {
        public string Title { get; set; } = String.Empty;
        public List<Chapter> Chapters { get; } = new List<Chapter>();

        public int Pages => Chapters.Sum(x => x.Pages);
    }
}
