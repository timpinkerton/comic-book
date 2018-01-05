using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comicbook.Models
{
    public class ComicBook
    {
        //this is a property to identify a comic book
        public int Id { get; set; }
        //This property represents the title of the series 
        //that the comic book is a part of
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        //Artists property is an array of Artists
        public Artists[] Artists { get; set; }
        public bool Favorite { get; set; }
    }
}
