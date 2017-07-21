
namespace API.Models
{
    public interface IModel
    {
        /// <summary>
        /// Retrieve data from source
        /// </summary>
        object Load();

        /// <summary>
        /// Save data to source
        /// </summary>
        void Save(object data);
    }
}
