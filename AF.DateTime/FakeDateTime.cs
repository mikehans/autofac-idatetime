using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DateTime
{
    public class FakeDateTime : IDateTime
    {
        System.DateTime IDateTime.Now => new System.DateTime(2024,4,1,17,20,30);
    }
}
