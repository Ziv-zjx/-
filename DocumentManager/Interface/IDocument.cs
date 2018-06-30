using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    public interface IDocument
    {
        string Title { get; set; }

        string Content { get; set; }
    }
}
