using System;
using System.Threading.Tasks;

namespace ImageRepository
{
    public interface IImageRepository
    {
        Task AddImage(Guid productId, String name, byte[] image);

        Task AddImage(ImageModel imageModel);

        Task DeleteImage(Guid ProductId, String name);

        Task<byte[]> GetImage(Guid productId, String name);

        String GetImagePath(Guid productId, String name);

        Task SaveChange();
    }
}