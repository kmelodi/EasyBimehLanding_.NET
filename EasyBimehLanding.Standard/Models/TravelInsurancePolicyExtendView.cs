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
    public class TravelInsurancePolicyExtendView : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.TravelInsurancePolicyExtend travelInsurancePolicyExtend;
        private List<string> travelInsurancePolicyExtendAges;
        private List<string> travelInsurancePolicyExtendPassengers;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("travelInsurancePolicyExtend")]
        public Models.TravelInsurancePolicyExtend TravelInsurancePolicyExtend 
        { 
            get 
            {
                return this.travelInsurancePolicyExtend; 
            } 
            set 
            {
                this.travelInsurancePolicyExtend = value;
                onPropertyChanged("TravelInsurancePolicyExtend");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("travelInsurancePolicyExtendAges")]
        public List<string> TravelInsurancePolicyExtendAges 
        { 
            get 
            {
                return this.travelInsurancePolicyExtendAges; 
            } 
            set 
            {
                this.travelInsurancePolicyExtendAges = value;
                onPropertyChanged("TravelInsurancePolicyExtendAges");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("travelInsurancePolicyExtendPassengers")]
        public List<string> TravelInsurancePolicyExtendPassengers 
        { 
            get 
            {
                return this.travelInsurancePolicyExtendPassengers; 
            } 
            set 
            {
                this.travelInsurancePolicyExtendPassengers = value;
                onPropertyChanged("TravelInsurancePolicyExtendPassengers");
            }
        }
    }
} 