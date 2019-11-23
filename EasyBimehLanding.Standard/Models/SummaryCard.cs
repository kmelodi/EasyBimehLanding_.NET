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
    public class SummaryCard : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int id;
        private int insuranceCentreId;
        private int articleType;
        private string title;
        private string summary;
        private string articleGroup;
        private int metaMediaFileId;
        private string metaMediaFileUrl;
        private string publishPersianDate;

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
        [JsonProperty("insuranceCentreId")]
        public int InsuranceCentreId 
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
        [JsonProperty("articleType")]
        public int ArticleType 
        { 
            get 
            {
                return this.articleType; 
            } 
            set 
            {
                this.articleType = value;
                onPropertyChanged("ArticleType");
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
        [JsonProperty("summary")]
        public string Summary 
        { 
            get 
            {
                return this.summary; 
            } 
            set 
            {
                this.summary = value;
                onPropertyChanged("Summary");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("articleGroup")]
        public string ArticleGroup 
        { 
            get 
            {
                return this.articleGroup; 
            } 
            set 
            {
                this.articleGroup = value;
                onPropertyChanged("ArticleGroup");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("metaMediaFileId")]
        public int MetaMediaFileId 
        { 
            get 
            {
                return this.metaMediaFileId; 
            } 
            set 
            {
                this.metaMediaFileId = value;
                onPropertyChanged("MetaMediaFileId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("metaMediaFileUrl")]
        public string MetaMediaFileUrl 
        { 
            get 
            {
                return this.metaMediaFileUrl; 
            } 
            set 
            {
                this.metaMediaFileUrl = value;
                onPropertyChanged("MetaMediaFileUrl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("publishPersianDate")]
        public string PublishPersianDate 
        { 
            get 
            {
                return this.publishPersianDate; 
            } 
            set 
            {
                this.publishPersianDate = value;
                onPropertyChanged("PublishPersianDate");
            }
        }
    }
} 