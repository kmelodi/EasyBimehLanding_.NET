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
    public class Status : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private string entityId;
        private int primaryEntityName;
        private string statusCollectionId;
        private string formData;
        private string statusTitle;
        private bool editable;
        private string statusCollectionParentId;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public string Id 
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
        [JsonProperty("entityId")]
        public string EntityId 
        { 
            get 
            {
                return this.entityId; 
            } 
            set 
            {
                this.entityId = value;
                onPropertyChanged("EntityId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("primaryEntityName")]
        public int PrimaryEntityName 
        { 
            get 
            {
                return this.primaryEntityName; 
            } 
            set 
            {
                this.primaryEntityName = value;
                onPropertyChanged("PrimaryEntityName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("statusCollectionId")]
        public string StatusCollectionId 
        { 
            get 
            {
                return this.statusCollectionId; 
            } 
            set 
            {
                this.statusCollectionId = value;
                onPropertyChanged("StatusCollectionId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("formData")]
        public string FormData 
        { 
            get 
            {
                return this.formData; 
            } 
            set 
            {
                this.formData = value;
                onPropertyChanged("FormData");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("statusTitle")]
        public string StatusTitle 
        { 
            get 
            {
                return this.statusTitle; 
            } 
            set 
            {
                this.statusTitle = value;
                onPropertyChanged("StatusTitle");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("editable")]
        public bool Editable 
        { 
            get 
            {
                return this.editable; 
            } 
            set 
            {
                this.editable = value;
                onPropertyChanged("Editable");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("statusCollectionParentId")]
        public string StatusCollectionParentId 
        { 
            get 
            {
                return this.statusCollectionParentId; 
            } 
            set 
            {
                this.statusCollectionParentId = value;
                onPropertyChanged("StatusCollectionParentId");
            }
        }
    }
} 