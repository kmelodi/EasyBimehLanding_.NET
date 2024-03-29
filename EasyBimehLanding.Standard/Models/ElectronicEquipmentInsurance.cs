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
    public class ElectronicEquipmentInsurance : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool hasPlan;
        private List<Models.Franchisee> franchisees;
        private List<Models.DeviceType> deviceTypes;
        private List<string> deviceBrands;
        private List<string> deviceModels;
        private List<Models.InsuranceCompany> insuranceCompanies;
        private List<string> insuranceExtraCoverage;
        private List<Models.InsurancePolicyTerm> insurancePolicyTerms;
        private List<Models.Province> provinces;
        private List<string> cities;
        private List<string> cityRegions;
        private List<Models.ShippingType> shippingTypes;
        private List<Models.PostType> postTypes;
        private Models.InsurancePolicyCondition insurancePolicyCondition;
        private Models.InsuranceData insuranceData;

        /// <summary>
        /// آیا این نوع بیمه نامه، طرح بیمه ای دارد؟
        /// </summary>
        [JsonProperty("hasPlan")]
        public bool HasPlan 
        { 
            get 
            {
                return this.hasPlan; 
            } 
            set 
            {
                this.hasPlan = value;
                onPropertyChanged("HasPlan");
            }
        }

        /// <summary>
        /// لیست فرانشیز های بیمه ی تجهیزات الکترونیک
        /// </summary>
        [JsonProperty("franchisees")]
        public List<Models.Franchisee> Franchisees 
        { 
            get 
            {
                return this.franchisees; 
            } 
            set 
            {
                this.franchisees = value;
                onPropertyChanged("Franchisees");
            }
        }

        /// <summary>
        /// انواع دستگاه ها
        /// </summary>
        [JsonProperty("deviceTypes")]
        public List<Models.DeviceType> DeviceTypes 
        { 
            get 
            {
                return this.deviceTypes; 
            } 
            set 
            {
                this.deviceTypes = value;
                onPropertyChanged("DeviceTypes");
            }
        }

        /// <summary>
        /// برند های دستگاه ها
        /// </summary>
        [JsonProperty("deviceBrands")]
        public List<string> DeviceBrands 
        { 
            get 
            {
                return this.deviceBrands; 
            } 
            set 
            {
                this.deviceBrands = value;
                onPropertyChanged("DeviceBrands");
            }
        }

        /// <summary>
        /// مدل های دستگاه ها
        /// </summary>
        [JsonProperty("deviceModels")]
        public List<string> DeviceModels 
        { 
            get 
            {
                return this.deviceModels; 
            } 
            set 
            {
                this.deviceModels = value;
                onPropertyChanged("DeviceModels");
            }
        }

        /// <summary>
        /// شرکت های بیمه ی ارائه دهنده ی بیمه ی تجهیزات الکترونیک
        /// </summary>
        [JsonProperty("insuranceCompanies")]
        public List<Models.InsuranceCompany> InsuranceCompanies 
        { 
            get 
            {
                return this.insuranceCompanies; 
            } 
            set 
            {
                this.insuranceCompanies = value;
                onPropertyChanged("InsuranceCompanies");
            }
        }

        /// <summary>
        /// پوشش های اضافه
        /// </summary>
        [JsonProperty("insuranceExtraCoverage")]
        public List<string> InsuranceExtraCoverage 
        { 
            get 
            {
                return this.insuranceExtraCoverage; 
            } 
            set 
            {
                this.insuranceExtraCoverage = value;
                onPropertyChanged("InsuranceExtraCoverage");
            }
        }

        /// <summary>
        /// دوره های بیمه نامه
        /// </summary>
        [JsonProperty("insurancePolicyTerms")]
        public List<Models.InsurancePolicyTerm> InsurancePolicyTerms 
        { 
            get 
            {
                return this.insurancePolicyTerms; 
            } 
            set 
            {
                this.insurancePolicyTerms = value;
                onPropertyChanged("InsurancePolicyTerms");
            }
        }

        /// <summary>
        /// لیست استان ها
        /// </summary>
        [JsonProperty("provinces")]
        public List<Models.Province> Provinces 
        { 
            get 
            {
                return this.provinces; 
            } 
            set 
            {
                this.provinces = value;
                onPropertyChanged("Provinces");
            }
        }

        /// <summary>
        /// لیست شهر ها
        /// </summary>
        [JsonProperty("cities")]
        public List<string> Cities 
        { 
            get 
            {
                return this.cities; 
            } 
            set 
            {
                this.cities = value;
                onPropertyChanged("Cities");
            }
        }

        /// <summary>
        /// لیست محله ها
        /// </summary>
        [JsonProperty("cityRegions")]
        public List<string> CityRegions 
        { 
            get 
            {
                return this.cityRegions; 
            } 
            set 
            {
                this.cityRegions = value;
                onPropertyChanged("CityRegions");
            }
        }

        /// <summary>
        /// روش های دریافت بیمه نامه
        /// </summary>
        [JsonProperty("shippingTypes")]
        public List<Models.ShippingType> ShippingTypes 
        { 
            get 
            {
                return this.shippingTypes; 
            } 
            set 
            {
                this.shippingTypes = value;
                onPropertyChanged("ShippingTypes");
            }
        }

        /// <summary>
        /// روش های ارسال بیمه نامه
        /// </summary>
        [JsonProperty("postTypes")]
        public List<Models.PostType> PostTypes 
        { 
            get 
            {
                return this.postTypes; 
            } 
            set 
            {
                this.postTypes = value;
                onPropertyChanged("PostTypes");
            }
        }

        /// <summary>
        /// شرایط بیمه نامه
        /// </summary>
        [JsonProperty("insurancePolicyCondition")]
        public Models.InsurancePolicyCondition InsurancePolicyCondition 
        { 
            get 
            {
                return this.insurancePolicyCondition; 
            } 
            set 
            {
                this.insurancePolicyCondition = value;
                onPropertyChanged("InsurancePolicyCondition");
            }
        }

        /// <summary>
        /// اطلاعات بیمه نامه
        /// </summary>
        [JsonProperty("insuranceData")]
        public Models.InsuranceData InsuranceData 
        { 
            get 
            {
                return this.insuranceData; 
            } 
            set 
            {
                this.insuranceData = value;
                onPropertyChanged("InsuranceData");
            }
        }
    }
} 