/*
 * EasyBimehLanding.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using EasyBimehLanding.Standard.Http.Client;

using EasyBimehLanding.Standard.Models;
using EasyBimehLanding.Standard;
using EasyBimehLanding.Standard.Utilities;


namespace EasyBimehLanding.Standard.Exceptions
{
    public class Status400Exception : APIException 
    {
        // These fields hold the values for the public properties.
        private bool isSuccess;
        private int status;
        private string message;
        private string extraData;
        private Models.Exception exception;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("isSuccess")]
        public bool IsSuccess 
        { 
            get 
            {
                return this.isSuccess; 
            } 
            private set 
            {
                this.isSuccess = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status")]
        public int Status 
        { 
            get 
            {
                return this.status; 
            } 
            private set 
            {
                this.status = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            private set 
            {
                this.message = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("extraData")]
        public string ExtraData 
        { 
            get 
            {
                return this.extraData; 
            } 
            private set 
            {
                this.extraData = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("exception")]
        public Models.Exception Exception 
        { 
            get 
            {
                return this.exception; 
            } 
            private set 
            {
                this.exception = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public Status400Exception(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 