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
    public partial class ElectronicEquipmentInsuranceController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ElectronicEquipmentInsuranceController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ElectronicEquipmentInsuranceController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ElectronicEquipmentInsuranceController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// دریافت اطلاعات اولیه استعلام بیمه نامه ی تجهیزات الکترونیک
        /// </summary>
        /// <param name="subDomain">Required parameter: دامنه یا زیر دامنه ی مرکز بیمه</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelElectronicEquipmentInsurance response from the API call</return>
        public Models.BaseModelElectronicEquipmentInsurance GetElectronicEquipmentInsurance(string subDomain, string xApiKey)
        {
            Task<Models.BaseModelElectronicEquipmentInsurance> t = GetElectronicEquipmentInsuranceAsync(subDomain, xApiKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// دریافت اطلاعات اولیه استعلام بیمه نامه ی تجهیزات الکترونیک
        /// </summary>
        /// <param name="subDomain">Required parameter: دامنه یا زیر دامنه ی مرکز بیمه</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelElectronicEquipmentInsurance response from the API call</return>
        public async Task<Models.BaseModelElectronicEquipmentInsurance> GetElectronicEquipmentInsuranceAsync(string subDomain, string xApiKey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/ElectronicEquipmentInsurance/Initialize");

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
                return APIHelper.JsonDeserialize<Models.BaseModelElectronicEquipmentInsurance>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// دریافت لیست نوع برند دستگاه
        /// </summary>
        /// <param name="deviceGroup">Required parameter: شناسه ی گروه دستگاه</param>
        /// <param name="deviceTypeId">Required parameter: شناسه ی نوع دستگاه</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelDeviceBrandTypes response from the API call</return>
        public Models.BaseModelDeviceBrandTypes GetDeviceBrandTypes(int deviceGroup, int deviceTypeId, string xApiKey)
        {
            Task<Models.BaseModelDeviceBrandTypes> t = GetDeviceBrandTypesAsync(deviceGroup, deviceTypeId, xApiKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// دریافت لیست نوع برند دستگاه
        /// </summary>
        /// <param name="deviceGroup">Required parameter: شناسه ی گروه دستگاه</param>
        /// <param name="deviceTypeId">Required parameter: شناسه ی نوع دستگاه</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelDeviceBrandTypes response from the API call</return>
        public async Task<Models.BaseModelDeviceBrandTypes> GetDeviceBrandTypesAsync(int deviceGroup, int deviceTypeId, string xApiKey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/ComboData/DeviceBrandTypes");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "deviceGroup", deviceGroup },
                { "deviceTypeId", deviceTypeId }
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
                return APIHelper.JsonDeserialize<Models.BaseModelDeviceBrandTypes>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// دریافت لیست فرانشیر استعلام بیمه نامه ی تجهیزات الکترونیک
        /// </summary>
        /// <param name="deviceModelId">Required parameter: شناسه ی مدل دستگاه</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelDiviceFranchisee response from the API call</return>
        public Models.BaseModelDiviceFranchisee GetDiviceFranchisee(int deviceModelId, string xApiKey)
        {
            Task<Models.BaseModelDiviceFranchisee> t = GetDiviceFranchiseeAsync(deviceModelId, xApiKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// دریافت لیست فرانشیر استعلام بیمه نامه ی تجهیزات الکترونیک
        /// </summary>
        /// <param name="deviceModelId">Required parameter: شناسه ی مدل دستگاه</param>
        /// <param name="xApiKey">Required parameter: کلید اختصاصی ارتباط با سرور</param>
        /// <return>Returns the Models.BaseModelDiviceFranchisee response from the API call</return>
        public async Task<Models.BaseModelDiviceFranchisee> GetDiviceFranchiseeAsync(int deviceModelId, string xApiKey)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/ElectronicEquipmentInsurance/DiviceFranchisee");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "deviceModelId", deviceModelId }
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
                return APIHelper.JsonDeserialize<Models.BaseModelDiviceFranchisee>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 