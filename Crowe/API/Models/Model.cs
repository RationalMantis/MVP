
namespace API.Models
{
    abstract class Model : IModel
    {
        public object Load()
        {
            return RetrieveValue("default");
        }

        public void Save(object data)
        {
            return;
        }

        protected abstract object RetrieveValue(string key);
    }
}
