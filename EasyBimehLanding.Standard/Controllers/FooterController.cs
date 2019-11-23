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
    public partial class FooterController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static FooterController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static FooterController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new FooterController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// دریافت اطلاعات درباره ی ما
        /// </summary>
        /// <param name="xApiKey">Required parameter: Example: </param>
        /// <return>Returns the Models.BaseModelPortalLandingContactAbout response from the API call</return>
        public Models.BaseModelPortalLandingContactAbout GetPortalLandingContactAbout(string xApiKey)
        {
            Task<Models.BaseModelPortalLandingContactAbout> t = GetPortalLandingContactAboutAsync(xApiKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// دریافت اطلاعات درباره ی ما
        /// </summary>
        /// <param name="xApiKey">Required parameter: Example: </param>
        /// <return>Returns the Models.BaseModelPortalLandingContactAbout response from the API call</return>
        public async Task<Models.BaseModelPortalLandingContactAbout> GetPortalLandingContactAboutAsync(string xApiKey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/InsuranceCentre/PortalLandingContactAbout/hfz1");


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
                return APIHelper.JsonDeserialize<Models.BaseModelPortalLandingContactAbout>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// دریافت لیست سوالات متداول
        /// </summary>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelFaqInsuranceCentre response from the API call</return>
        public Models.BaseModelFaqInsuranceCentre GetFaqInsuranceCentre(string xApiKey)
        {
            Task<Models.BaseModelFaqInsuranceCentre> t = GetFaqInsuranceCentreAsync(xApiKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// دریافت لیست سوالات متداول
        /// </summary>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelFaqInsuranceCentre response from the API call</return>
        public async Task<Models.BaseModelFaqInsuranceCentre> GetFaqInsuranceCentreAsync(string xApiKey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Faq/InsuranceCentre/hfz1");


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
                return APIHelper.JsonDeserialize<Models.BaseModelFaqInsuranceCentre>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// پیگیری وضعیت بیمه نامه
        /// </summary>
        /// <param name="trackingCode">Required parameter: شماره ی پیگیری بیمه نامه</param>
        /// <param name="nationalCode">Required parameter: کد ملی کاربر</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelInsurancePolicyTracking response from the API call</return>
        public Models.BaseModelInsurancePolicyTracking GetInsurancePolicyTracking(int trackingCode, long nationalCode, string xApiKey)
        {
            Task<Models.BaseModelInsurancePolicyTracking> t = GetInsurancePolicyTrackingAsync(trackingCode, nationalCode, xApiKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// پیگیری وضعیت بیمه نامه
        /// </summary>
        /// <param name="trackingCode">Required parameter: شماره ی پیگیری بیمه نامه</param>
        /// <param name="nationalCode">Required parameter: کد ملی کاربر</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelInsurancePolicyTracking response from the API call</return>
        public async Task<Models.BaseModelInsurancePolicyTracking> GetInsurancePolicyTrackingAsync(int trackingCode, long nationalCode, string xApiKey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/InsurancePolicy/Tracking");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "trackingCode", trackingCode },
                { "nationalCode", nationalCode }
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

            //Error handling using HTTP status codes
            if (_response.StatusCode == 500)
                throw new InternalServerErrorException(@"Internal Server Error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.BaseModelInsurancePolicyTracking>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 