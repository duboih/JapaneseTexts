using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JapaneseTexts.Models
{
    public class JapaneseTextsDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<JapaneseTextsContext>
    {
        protected override void Seed(JapaneseTextsContext context)
        {
            context.JapaneseTexts.Add(new JapaneseText() { Title = "Title", JapaneseTextID = 1, Level = "1", Text = "Text" });
            base.Seed(context);

        }
    }
}