using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JapaneseTexts.Models
{
    public class JapaneseText
    {
        public int JapaneseTextID { get; set; }

        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        public string Level { get; set; }
    }
}