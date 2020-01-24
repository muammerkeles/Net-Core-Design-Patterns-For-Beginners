using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Design.Pattern
{

    // //   Kaynak : https://code-maze.com/builder-design-pattern/



    public class ProductStockReportDirector
    {
        private readonly IProductStockReportBuilder _productStockReportBuilder;
        public ProductStockReportDirector(IProductStockReportBuilder p_builder)
        {
            _productStockReportBuilder = p_builder;
        }
        public void BuildStockReport() {
            _productStockReportBuilder.BuildHeader();
            _productStockReportBuilder.BuildBody();
            _productStockReportBuilder.BuilFooter();
        }
    }
}
