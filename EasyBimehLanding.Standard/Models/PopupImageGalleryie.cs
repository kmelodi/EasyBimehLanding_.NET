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
    public class PopupImageGalleryie : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool cached;
        private string url;
        private string thumbnailUrl;
        private string altText;
        private string title;
        private string extUrl;
        private string extUrlTarget;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("_cached")]
        public bool Cached 
        { 
            get 
            {
                return this.cached; 
            } 
            set 
            {
                this.cached = value;
                onPropertyChanged("Cached");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("url")]
        public string Url 
        { 
            get 
            {
                return this.url; 
            } 
            set 
            {
                this.url = value;
                onPropertyChanged("Url");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl 
        { 
            get 
            {
                return this.thumbnailUrl; 
            } 
            set 
            {
                this.thumbnailUrl = value;
                onPropertyChanged("ThumbnailUrl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("altText")]
        public string AltText 
        { 
            get 
            {
                return this.altText; 
            } 
            set 
            {
                this.altText = value;
                onPropertyChanged("AltText");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("title")]
        public string Title 
        { 
            get 
            {
                return this.title; 
            } 
            set 
            {
                this.title = value;
                onPropertyChanged("Title");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("extUrl")]
        public string ExtUrl 
        { 
            get 
            {
                return this.extUrl; 
            } 
            set 
            {
                this.extUrl = value;
                onPropertyChanged("ExtUrl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("extUrlTarget")]
        public string ExtUrlTarget 
        { 
            get 
            {
                return this.extUrlTarget; 
            } 
            set 
            {
                this.extUrlTarget = value;
                onPropertyChanged("ExtUrlTarget");
            }
        }
    }
} 