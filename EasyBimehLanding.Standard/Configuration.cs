using System.Collections.Generic;
using System.Text;
using EasyBimehLanding.Standard.Utilities;
using EasyBimehLanding.Standard.Models;
namespace EasyBimehLanding.Standard
{
    public partial class Configuration
    {


        public enum Environments
        {
            INSURANCE_SERVER_NOTIFAANO_IR,
        }
        public enum Servers
        {
            SERVER_1,
        }

        //The current environment being used
        public static Environments Environment = Environments.INSURANCE_SERVER_NOTIFAANO_IR;

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.INSURANCE_SERVER_NOTIFAANO_IR,new Dictionary<Servers, string>
                    {
                        { Servers.SERVER_1,"http://server.notifaano.ir/api" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:SERVER 1</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.SERVER_1)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}