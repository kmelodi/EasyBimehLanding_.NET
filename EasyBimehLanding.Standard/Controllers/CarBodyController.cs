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
    public partial class CarBodyController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static CarBodyController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static CarBodyController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new CarBodyController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// دریافت برند خودرو
        /// </summary>
        /// <param name="xApiKey">Required parameter: شناسه ی اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.CarBrand response from the API call</return>
        public Models.CarBrand GetCarBrand(string xApiKey)
        {
            Task<Models.CarBrand> t = GetCarBrandAsync(xApiKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// دریافت برند خودرو
        /// </summary>
        /// <param name="xApiKey">Required parameter: شناسه ی اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.CarBrand response from the API call</return>
        public async Task<Models.CarBrand> GetCarBrandAsync(string xApiKey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/ComboData/CarBrands");


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
                return APIHelper.JsonDeserialize<Models.CarBrand>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// دریافت لیست تیپ خودرو
        /// </summary>
        /// <param name="carBrandId">Required parameter: شناسه ی برند خودرو</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.CarBrandTips response from the API call</return>
        public Models.CarBrandTips GetCarBrandTips(int carBrandId, string xApiKey)
        {
            Task<Models.CarBrandTips> t = GetCarBrandTipsAsync(carBrandId, xApiKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// دریافت لیست تیپ خودرو
        /// </summary>
        /// <param name="carBrandId">Required parameter: شناسه ی برند خودرو</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.CarBrandTips response from the API call</return>
        public async Task<Models.CarBrandTips> GetCarBrandTipsAsync(int carBrandId, string xApiKey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/ComboData/CarBrandTips");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "carBrandId", carBrandId }
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
                return APIHelper.JsonDeserialize<Models.CarBrandTips>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// آیا این نوع بیمه نامه، طرح بیمه ای دارد؟
        /// </summary>
        /// <param name="subDomain">Required parameter: دامنه یا زیر دامنه ی مرکز بیمه</param>
        /// <param name="insurancePolicyType">Required parameter: شناسه ی نوع بیمه نامه => بیمه بدنه=2</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.HasPlan response from the API call</return>
        public Models.HasPlan GetHasPlan(string subDomain, int insurancePolicyType, string xApiKey)
        {
            Task<Models.HasPlan> t = GetHasPlanAsync(subDomain, insurancePolicyType, xApiKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// آیا این نوع بیمه نامه، طرح بیمه ای دارد؟
        /// </summary>
        /// <param name="subDomain">Required parameter: دامنه یا زیر دامنه ی مرکز بیمه</param>
        /// <param name="insurancePolicyType">Required parameter: شناسه ی نوع بیمه نامه => بیمه بدنه=2</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.HasPlan response from the API call</return>
        public async Task<Models.HasPlan> GetHasPlanAsync(string subDomain, int insurancePolicyType, string xApiKey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/InsurancePolicyPlan/HasPlan");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "subDomain", subDomain },
                { "insurancePolicyType", insurancePolicyType }
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
                return APIHelper.JsonDeserialize<Models.HasPlan>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 