using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ImageRepository.Interface
{
    public class ImageRepository : IImageRepository
    {
        #region Fields

        private int usingResource = 0;

        private readonly IConfiguration configuration;
        private readonly String folderPath;

        private readonly IDictionary<String, ImageModel> addImages;
        private readonly ICollection<ImageModel> removeImages;

        #endregion Fields

        public ImageRepository(IConfiguration configuration)
        {
            this.addImages = new Dictionary<String, ImageModel>();
            this.removeImages = new List<ImageModel>();

            this.configuration = configuration;
            //this.folderPath = configuration.GetValue<String>("Images:Folder");
            if (String.IsNullOrWhiteSpace(this.folderPath))
            {
                throw new Exception("Dizin belirlenmemiş!");
                //Throw exception
            }
            else if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        public async Task AddImage(Guid productId, string name, byte[] image)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            var productImage = new ImageModel(productId, name) { Content = image };
            await AddImage(productImage);
        }

        public async Task AddImage(ImageModel imageModel)
        {
            this.addImages.Remove(imageModel.Id); //Remove old image
            if (this.removeImages.Any(r => r.Id.Equals(imageModel.Id, StringComparison.InvariantCultureIgnoreCase)))
            {
                this.removeImages.Remove(this.removeImages.First(r => r.Id.Equals(imageModel.Id, StringComparison.InvariantCultureIgnoreCase))); //Cancel deletion
            }

            this.addImages.Add(imageModel.Id, imageModel); //Add new image
            await Task.CompletedTask;
        }

        public async Task DeleteImage(Guid productId, string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            var productImage = new ImageModel(productId, name);

            this.addImages.Remove(productImage.Id); //Cancel image add
            if (!this.removeImages.Any(r => r.Id.Equals(productImage.Id)))
            {
                this.removeImages.Add(productImage);
            }
            await Task.CompletedTask;
        }

        public async Task<byte[]> GetImage(Guid productId, String name)
        {
            return await File.ReadAllBytesAsync(GetImagePath(productId, name));
        }

        public string GetImagePath(Guid productId, string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return Path.Combine(folderPath, productId.ToString(), name);
        }

        public async Task SaveChange()
        {
            foreach (var addFile in addImages)
            {
                File.WriteAllBytes(
                   this.GetImagePath(addFile.Value.ProductId, addFile.Value.FileName),
                    addFile.Value.Content);
            }
            foreach (var removeFile in removeImages)
            {
                File.Delete(this.GetImagePath(removeFile.ProductId, removeFile.FileName));
            }
            await Task.CompletedTask;
        }
    }
}