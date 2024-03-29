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
    public class FireInsurancePolicyExtendView : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string buildingTypeParamId;
        private string skeletonTypeBuildingParamId;
        private string buildingUseTypeParamId;
        private string unitCount;
        private int everySquareMeterCoverageRateId;
        private string cityId;
        private string provinceId;
        private string buildingArea;
        private string valueOfAppliancesFurnishing;
        private string insuranceCoverageIds;
        private bool onlyAppliancesFurnishings;
        private string insuranceCoveragePrice;
        private string insurancePolicyCommitmentCeiling;
        private string valuePerSquareMeterRate;
        private string buildYear;
        private string zipCode;
        private string addressPlaceBuilding;
        private int riskLevelDiscount;
        private string basePremium;
        private string allPremium;
        private int insuranceCompanyDiscountRate;
        private int insuranceCompanyDiscount;
        private int insuranceCentreDiscount;
        private int coupenDiscount;
        private int allDiscount;
        private int exchangePremium;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("buildingTypeParamId")]
        public string BuildingTypeParamId 
        { 
            get 
            {
                return this.buildingTypeParamId; 
            } 
            set 
            {
                this.buildingTypeParamId = value;
                onPropertyChanged("BuildingTypeParamId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("skeletonTypeBuildingParamId")]
        public string SkeletonTypeBuildingParamId 
        { 
            get 
            {
                return this.skeletonTypeBuildingParamId; 
            } 
            set 
            {
                this.skeletonTypeBuildingParamId = value;
                onPropertyChanged("SkeletonTypeBuildingParamId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("buildingUseTypeParamId")]
        public string BuildingUseTypeParamId 
        { 
            get 
            {
                return this.buildingUseTypeParamId; 
            } 
            set 
            {
                this.buildingUseTypeParamId = value;
                onPropertyChanged("BuildingUseTypeParamId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("unitCount")]
        public string UnitCount 
        { 
            get 
            {
                return this.unitCount; 
            } 
            set 
            {
                this.unitCount = value;
                onPropertyChanged("UnitCount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("everySquareMeterCoverageRateId")]
        public int EverySquareMeterCoverageRateId 
        { 
            get 
            {
                return this.everySquareMeterCoverageRateId; 
            } 
            set 
            {
                this.everySquareMeterCoverageRateId = value;
                onPropertyChanged("EverySquareMeterCoverageRateId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("cityId")]
        public string CityId 
        { 
            get 
            {
                return this.cityId; 
            } 
            set 
            {
                this.cityId = value;
                onPropertyChanged("CityId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("provinceId")]
        public string ProvinceId 
        { 
            get 
            {
                return this.provinceId; 
            } 
            set 
            {
                this.provinceId = value;
                onPropertyChanged("ProvinceId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("buildingArea")]
        public string BuildingArea 
        { 
            get 
            {
                return this.buildingArea; 
            } 
            set 
            {
                this.buildingArea = value;
                onPropertyChanged("BuildingArea");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("valueOfAppliancesFurnishing")]
        public string ValueOfAppliancesFurnishing 
        { 
            get 
            {
                return this.valueOfAppliancesFurnishing; 
            } 
            set 
            {
                this.valueOfAppliancesFurnishing = value;
                onPropertyChanged("ValueOfAppliancesFurnishing");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("_InsuranceCoverageIds")]
        public string InsuranceCoverageIds 
        { 
            get 
            {
                return this.insuranceCoverageIds; 
            } 
            set 
            {
                this.insuranceCoverageIds = value;
                onPropertyChanged("InsuranceCoverageIds");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("onlyAppliancesFurnishings")]
        public bool OnlyAppliancesFurnishings 
        { 
            get 
            {
                return this.onlyAppliancesFurnishings; 
            } 
            set 
            {
                this.onlyAppliancesFurnishings = value;
                onPropertyChanged("OnlyAppliancesFurnishings");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceCoveragePrice")]
        public string InsuranceCoveragePrice 
        { 
            get 
            {
                return this.insuranceCoveragePrice; 
            } 
            set 
            {
                this.insuranceCoveragePrice = value;
                onPropertyChanged("InsuranceCoveragePrice");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insurancePolicyCommitmentCeiling")]
        public string InsurancePolicyCommitmentCeiling 
        { 
            get 
            {
                return this.insurancePolicyCommitmentCeiling; 
            } 
            set 
            {
                this.insurancePolicyCommitmentCeiling = value;
                onPropertyChanged("InsurancePolicyCommitmentCeiling");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("valuePerSquareMeterRate")]
        public string ValuePerSquareMeterRate 
        { 
            get 
            {
                return this.valuePerSquareMeterRate; 
            } 
            set 
            {
                this.valuePerSquareMeterRate = value;
                onPropertyChanged("ValuePerSquareMeterRate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("buildYear")]
        public string BuildYear 
        { 
            get 
            {
                return this.buildYear; 
            } 
            set 
            {
                this.buildYear = value;
                onPropertyChanged("BuildYear");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("zipCode")]
        public string ZipCode 
        { 
            get 
            {
                return this.zipCode; 
            } 
            set 
            {
                this.zipCode = value;
                onPropertyChanged("ZipCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("addressPlaceBuilding")]
        public string AddressPlaceBuilding 
        { 
            get 
            {
                return this.addressPlaceBuilding; 
            } 
            set 
            {
                this.addressPlaceBuilding = value;
                onPropertyChanged("AddressPlaceBuilding");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("riskLevelDiscount")]
        public int RiskLevelDiscount 
        { 
            get 
            {
                return this.riskLevelDiscount; 
            } 
            set 
            {
                this.riskLevelDiscount = value;
                onPropertyChanged("RiskLevelDiscount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("basePremium")]
        public string BasePremium 
        { 
            get 
            {
                return this.basePremium; 
            } 
            set 
            {
                this.basePremium = value;
                onPropertyChanged("BasePremium");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("allPremium")]
        public string AllPremium 
        { 
            get 
            {
                return this.allPremium; 
            } 
            set 
            {
                this.allPremium = value;
                onPropertyChanged("AllPremium");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceCompanyDiscountRate")]
        public int InsuranceCompanyDiscountRate 
        { 
            get 
            {
                return this.insuranceCompanyDiscountRate; 
            } 
            set 
            {
                this.insuranceCompanyDiscountRate = value;
                onPropertyChanged("InsuranceCompanyDiscountRate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceCompanyDiscount")]
        public int InsuranceCompanyDiscount 
        { 
            get 
            {
                return this.insuranceCompanyDiscount; 
            } 
            set 
            {
                this.insuranceCompanyDiscount = value;
                onPropertyChanged("InsuranceCompanyDiscount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceCentreDiscount")]
        public int InsuranceCentreDiscount 
        { 
            get 
            {
                return this.insuranceCentreDiscount; 
            } 
            set 
            {
                this.insuranceCentreDiscount = value;
                onPropertyChanged("InsuranceCentreDiscount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("coupenDiscount")]
        public int CoupenDiscount 
        { 
            get 
            {
                return this.coupenDiscount; 
            } 
            set 
            {
                this.coupenDiscount = value;
                onPropertyChanged("CoupenDiscount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("allDiscount")]
        public int AllDiscount 
        { 
            get 
            {
                return this.allDiscount; 
            } 
            set 
            {
                this.allDiscount = value;
                onPropertyChanged("AllDiscount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("exchangePremium")]
        public int ExchangePremium 
        { 
            get 
            {
                return this.exchangePremium; 
            } 
            set 
            {
                this.exchangePremium = value;
                onPropertyChanged("ExchangePremium");
            }
        }
    }
} 