using System;
using System.Collections.Generic;
using System.Text;

namespace peti
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}
