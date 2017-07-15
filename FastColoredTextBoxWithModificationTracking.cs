using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryExpress
{
    public class FastColoredTextBoxWithModificationTracking : FastColoredTextBox
    {
        public bool Modified { get; set; }

        public FastColoredTextBoxWithModificationTracking(): base()
        {
            TextChangedDelayed += FastColoredTextBoxWithModificationTracking_TextChangedDelayed;
        }

        private void FastColoredTextBoxWithModificationTracking_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            Modified = true;
            SyntaxHighlighter.InitStyleSchema(Language.SQL);
            SyntaxHighlighter.SQLSyntaxHighlight(VisibleRange);
        }
    }
}
