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
using EasyBimehLanding.Standard;
using EasyBimehLanding.Standard.Utilities;


namespace EasyBimehLanding.Standard.Models
{
    public class InsuranceCompanies : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool isSuccess;
        private int status;
        private List<Models.ComboDataModel> message;
        private string extraData;
        private string exception;

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
            set 
            {
                this.isSuccess = value;
                onPropertyChanged("IsSuccess");
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
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("message")]
        public List<Models.ComboDataModel> Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
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
            set 
            {
                this.extraData = value;
                onPropertyChanged("ExtraData");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("exception")]
        public string Exception 
        { 
            get 
            {
                return this.exception; 
            } 
            set 
            {
                this.exception = value;
                onPropertyChanged("Exception");
            }
        }
    }
} 