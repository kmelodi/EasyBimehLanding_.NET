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
    public class TravelInsurancePolicyFilter : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string zoneIds;
        private string travelRatePlanId;
        private string travelInsurancePolicyExtendAges;
        private string travelDurationParam;
        private string birthDatePersian;
        private string insuranceExtraCoverageIds;
        private string policyTermId;
        private string insuranceCentreSubDomainName;
        private string insuranceCentreId;
        private string insuranceCompanyId;
        private bool isSearchQuery;
        private string giftCode;
        private string customerUserId;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("zoneIds")]
        public string ZoneIds 
        { 
            get 
            {
                return this.zoneIds; 
            } 
            set 
            {
                this.zoneIds = value;
                onPropertyChanged("ZoneIds");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("travelRatePlanId")]
        public string TravelRatePlanId 
        { 
            get 
            {
                return this.travelRatePlanId; 
            } 
            set 
            {
                this.travelRatePlanId = value;
                onPropertyChanged("TravelRatePlanId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("travelInsurancePolicyExtendAges")]
        public string TravelInsurancePolicyExtendAges 
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
        [JsonProperty("travelDurationParam")]
        public string TravelDurationParam 
        { 
            get 
            {
                return this.travelDurationParam; 
            } 
            set 
            {
                this.travelDurationParam = value;
                onPropertyChanged("TravelDurationParam");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("birthDatePersian")]
        public string BirthDatePersian 
        { 
            get 
            {
                return this.birthDatePersian; 
            } 
            set 
            {
                this.birthDatePersian = value;
                onPropertyChanged("BirthDatePersian");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceExtraCoverageIds")]
        public string InsuranceExtraCoverageIds 
        { 
            get 
            {
                return this.insuranceExtraCoverageIds; 
            } 
            set 
            {
                this.insuranceExtraCoverageIds = value;
                onPropertyChanged("InsuranceExtraCoverageIds");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("policyTermId")]
        public string PolicyTermId 
        { 
            get 
            {
                return this.policyTermId; 
            } 
            set 
            {
                this.policyTermId = value;
                onPropertyChanged("PolicyTermId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceCentreSubDomainName")]
        public string InsuranceCentreSubDomainName 
        { 
            get 
            {
                return this.insuranceCentreSubDomainName; 
            } 
            set 
            {
                this.insuranceCentreSubDomainName = value;
                onPropertyChanged("InsuranceCentreSubDomainName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceCentreId")]
        public string InsuranceCentreId 
        { 
            get 
            {
                return this.insuranceCentreId; 
            } 
            set 
            {
                this.insuranceCentreId = value;
                onPropertyChanged("InsuranceCentreId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceCompanyId")]
        public string InsuranceCompanyId 
        { 
            get 
            {
                return this.insuranceCompanyId; 
            } 
            set 
            {
                this.insuranceCompanyId = value;
                onPropertyChanged("InsuranceCompanyId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("isSearchQuery")]
        public bool IsSearchQuery 
        { 
            get 
            {
                return this.isSearchQuery; 
            } 
            set 
            {
                this.isSearchQuery = value;
                onPropertyChanged("IsSearchQuery");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("giftCode")]
        public string GiftCode 
        { 
            get 
            {
                return this.giftCode; 
            } 
            set 
            {
                this.giftCode = value;
                onPropertyChanged("GiftCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("customerUserId")]
        public string CustomerUserId 
        { 
            get 
            {
                return this.customerUserId; 
            } 
            set 
            {
                this.customerUserId = value;
                onPropertyChanged("CustomerUserId");
            }
        }
    }
} 