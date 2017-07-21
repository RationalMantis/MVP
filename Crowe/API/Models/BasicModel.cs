using System.Configuration;

namespace API.Models
{
    class BasicModel : Model
    {
        protected override object RetrieveValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
