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
    public class EverySquareMeterCoverage : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int id;
        private int fiscalYearId;
        private int insuranceCoverageId;
        private int coverageRial;
        private string coverageEuro;
        private string fromPrice;
        private string toPrice;
        private string isDiscount;
        private string coverageValueType;
        private string coverageStringValue;
        private string insuranceTypeIds;
        private string insuranceCompanyIds;
        private bool selected;
        private string isVisible;
        private string insuranceTypeId;
        private string insurancePlansIds;
        private string isActive;
        private string insuranceTypeTitles;
        private string insuranceCompanyTitles;
        private string insurancePlanTitles;
        private string insuranceTypeTitle;
        private string createdBy;
        private string isPlan;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public int Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fiscalYearId")]
        public int FiscalYearId 
        { 
            get 
            {
                return this.fiscalYearId; 
            } 
            set 
            {
                this.fiscalYearId = value;
                onPropertyChanged("FiscalYearId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceCoverageId")]
        public int InsuranceCoverageId 
        { 
            get 
            {
                return this.insuranceCoverageId; 
            } 
            set 
            {
                this.insuranceCoverageId = value;
                onPropertyChanged("InsuranceCoverageId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("coverageRial")]
        public int CoverageRial 
        { 
            get 
            {
                return this.coverageRial; 
            } 
            set 
            {
                this.coverageRial = value;
                onPropertyChanged("CoverageRial");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("coverageEuro")]
        public string CoverageEuro 
        { 
            get 
            {
                return this.coverageEuro; 
            } 
            set 
            {
                this.coverageEuro = value;
                onPropertyChanged("CoverageEuro");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fromPrice")]
        public string FromPrice 
        { 
            get 
            {
                return this.fromPrice; 
            } 
            set 
            {
                this.fromPrice = value;
                onPropertyChanged("FromPrice");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("toPrice")]
        public string ToPrice 
        { 
            get 
            {
                return this.toPrice; 
            } 
            set 
            {
                this.toPrice = value;
                onPropertyChanged("ToPrice");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("isDiscount")]
        public string IsDiscount 
        { 
            get 
            {
                return this.isDiscount; 
            } 
            set 
            {
                this.isDiscount = value;
                onPropertyChanged("IsDiscount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("coverageValueType")]
        public string CoverageValueType 
        { 
            get 
            {
                return this.coverageValueType; 
            } 
            set 
            {
                this.coverageValueType = value;
                onPropertyChanged("CoverageValueType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("coverageStringValue")]
        public string CoverageStringValue 
        { 
            get 
            {
                return this.coverageStringValue; 
            } 
            set 
            {
                this.coverageStringValue = value;
                onPropertyChanged("CoverageStringValue");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceTypeIds")]
        public string InsuranceTypeIds 
        { 
            get 
            {
                return this.insuranceTypeIds; 
            } 
            set 
            {
                this.insuranceTypeIds = value;
                onPropertyChanged("InsuranceTypeIds");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceCompanyIds")]
        public string InsuranceCompanyIds 
        { 
            get 
            {
                return this.insuranceCompanyIds; 
            } 
            set 
            {
                this.insuranceCompanyIds = value;
                onPropertyChanged("InsuranceCompanyIds");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("selected")]
        public bool Selected 
        { 
            get 
            {
                return this.selected; 
            } 
            set 
            {
                this.selected = value;
                onPropertyChanged("Selected");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("isVisible")]
        public string IsVisible 
        { 
            get 
            {
                return this.isVisible; 
            } 
            set 
            {
                this.isVisible = value;
                onPropertyChanged("IsVisible");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceTypeId")]
        public string InsuranceTypeId 
        { 
            get 
            {
                return this.insuranceTypeId; 
            } 
            set 
            {
                this.insuranceTypeId = value;
                onPropertyChanged("InsuranceTypeId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insurancePlansIds")]
        public string InsurancePlansIds 
        { 
            get 
            {
                return this.insurancePlansIds; 
            } 
            set 
            {
                this.insurancePlansIds = value;
                onPropertyChanged("InsurancePlansIds");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("isActive")]
        public string IsActive 
        { 
            get 
            {
                return this.isActive; 
            } 
            set 
            {
                this.isActive = value;
                onPropertyChanged("IsActive");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceTypeTitles")]
        public string InsuranceTypeTitles 
        { 
            get 
            {
                return this.insuranceTypeTitles; 
            } 
            set 
            {
                this.insuranceTypeTitles = value;
                onPropertyChanged("InsuranceTypeTitles");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceCompanyTitles")]
        public string InsuranceCompanyTitles 
        { 
            get 
            {
                return this.insuranceCompanyTitles; 
            } 
            set 
            {
                this.insuranceCompanyTitles = value;
                onPropertyChanged("InsuranceCompanyTitles");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insurancePlanTitles")]
        public string InsurancePlanTitles 
        { 
            get 
            {
                return this.insurancePlanTitles; 
            } 
            set 
            {
                this.insurancePlanTitles = value;
                onPropertyChanged("InsurancePlanTitles");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceTypeTitle")]
        public string InsuranceTypeTitle 
        { 
            get 
            {
                return this.insuranceTypeTitle; 
            } 
            set 
            {
                this.insuranceTypeTitle = value;
                onPropertyChanged("InsuranceTypeTitle");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("createdBy")]
        public string CreatedBy 
        { 
            get 
            {
                return this.createdBy; 
            } 
            set 
            {
                this.createdBy = value;
                onPropertyChanged("CreatedBy");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("isPlan")]
        public string IsPlan 
        { 
            get 
            {
                return this.isPlan; 
            } 
            set 
            {
                this.isPlan = value;
                onPropertyChanged("IsPlan");
            }
        }
    }
} 