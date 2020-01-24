using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Design.Pattern
{

    // //   Kaynak : https://code-maze.com/builder-design-pattern/



    public class ProductStockReport
    {
        public string HeaderPart { get; set; }
        public string BodyPart { get; set; }
        public string FooterPart { get; set; }

        public override string ToString() =>
            new StringBuilder()
            .Append(HeaderPart)
            .Append(BodyPart)
            .Append(FooterPart)
            .ToString();

    }
}
