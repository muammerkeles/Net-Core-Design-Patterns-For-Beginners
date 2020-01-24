using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Design.Pattern
{
    // //   Kaynak : https://code-maze.com/builder-design-pattern/
    public interface IProductStockReportBuilder
    {
        void BuildHeader();
        void BuildBody();
        void BuilFooter();
        ProductStockReport GetReport();
    }
    public class ProductStockReportBuilder : IProductStockReportBuilder
    {
        private ProductStockReport _productStockReport;
        private IEnumerable<Product> _products;
        public ProductStockReportBuilder(IEnumerable<Product> products)
        {
            _products = products;
            _productStockReport = new ProductStockReport();
        }
        public void BuildHeader()
        {
            _productStockReport.HeaderPart = $"Stock report for all the products on date : {DateTime.Now}\n";
        }
        public void BuildBody()
        {
            _productStockReport.BodyPart = string.Join(Environment.NewLine, _products.Select(p => $"Product name : {p.Name}, product price :{p.Price}"));
        }
        public void BuilFooter()
        {
            _productStockReport.FooterPart = "\nReport provided by the IT_PRODUCTS company";
        }
        public ProductStockReport GetReport()
        {
            var productStockReport = _productStockReport;
            Clear();
            return productStockReport;
        }
        private void Clear() => _productStockReport = new ProductStockReport();
    }
}
