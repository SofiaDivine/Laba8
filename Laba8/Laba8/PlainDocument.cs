using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Laba8
{
    class PlainDocument : Document
    {
        public PlainDocument(string title, DateOnly creationDate, string author)
            : base(title, creationDate, author)
        {
        }

        public override Document AddContent(string content)
        {
            return this;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
