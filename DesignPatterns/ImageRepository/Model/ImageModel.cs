using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ImageRepository
{
    public class ImageModel
    {
        public String Id { get; private set; }
        public Guid ProductId { get; private set; }
        public String FileName { get; private set; }
        public byte[] Content { get; set; }

        public ImageModel(Guid productId, String fileName)
        {
            this.ProductId = productId;
            this.FileName = fileName;
            this.Id = new StringBuilder().Append(
                MD5.Create().ComputeHash(
                    Encoding.ASCII.GetBytes($"{productId.ToString()}:{FileName.ToLower()}"))
                .Select(b => b.ToString("X2")).ToArray()).ToString();
        }
    }
}