using System;
using System.Collections.Generic;
using System.Text;

namespace peti
{
    interface IVisitor
    {
        double Visit(DVD DVDItem);
        double Visit(VHS VHSItem);
        double Visit(Book BookItem);

    }
}
