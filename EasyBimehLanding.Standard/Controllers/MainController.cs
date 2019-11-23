/*
 * EasyBimehLanding.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using EasyBimehLanding.Standard;
using EasyBimehLanding.Standard.Utilities;
using EasyBimehLanding.Standard.Http.Request;
using EasyBimehLanding.Standard.Http.Response;
using EasyBimehLanding.Standard.Http.Client;
using EasyBimehLanding.Standard.Exceptions;

namespace EasyBimehLanding.Standard.Controllers
{
    public partial class MainController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static MainController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static MainController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new MainController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// در یافت اطلاعات لندینگ مراکز بیمه
        /// </summary>
        /// <param name="id">Required parameter: دامنه یا زیر دامنه ی مرکز بیمه</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelPortalLandingPage response from the API call</return>
        public Models.BaseModelPortalLandingPage GetPortalLandingPage(string id, string xApiKey)
        {
            Task<Models.BaseModelPortalLandingPage> t = GetPortalLandingPageAsync(id, xApiKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// در یافت اطلاعات لندینگ مراکز بیمه
        /// </summary>
        /// <param name="id">Required parameter: دامنه یا زیر دامنه ی مرکز بیمه</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelPortalLandingPage response from the API call</return>
        public async Task<Models.BaseModelPortalLandingPage> GetPortalLandingPageAsync(string id, string xApiKey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/InsuranceCentre/PortalLandingPage");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "x-api-key", xApiKey }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.BaseModelPortalLandingPage>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// دریافت لیست بیمه ی های ارائه شده توسط مرکز بیمه
        /// </summary>
        /// <param name="subDomain">Required parameter: دامنه یا زیر دامنه ی مرکز بیمه</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelInsuranceCentrePolicyTypes response from the API call</return>
        public Models.BaseModelInsuranceCentrePolicyTypes GetInsuranceCentrePolicyTypes(string subDomain, string xApiKey)
        {
            Task<Models.BaseModelInsuranceCentrePolicyTypes> t = GetInsuranceCentrePolicyTypesAsync(subDomain, xApiKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// دریافت لیست بیمه ی های ارائه شده توسط مرکز بیمه
        /// </summary>
        /// <param name="subDomain">Required parameter: دامنه یا زیر دامنه ی مرکز بیمه</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelInsuranceCentrePolicyTypes response from the API call</return>
        public async Task<Models.BaseModelInsuranceCentrePolicyTypes> GetInsuranceCentrePolicyTypesAsync(string subDomain, string xApiKey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/ComboData/InsuranceCentrePolicyTypes");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "subDomain", subDomain }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "x-api-key", xApiKey }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.BaseModelInsuranceCentrePolicyTypes>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 