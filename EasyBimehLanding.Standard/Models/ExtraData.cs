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
    public class ExtraData : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string aliasName;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("aliasName")]
        public string AliasName 
        { 
            get 
            {
                return this.aliasName; 
            } 
            set 
            {
                this.aliasName = value;
                onPropertyChanged("AliasName");
            }
        }
    }
} 