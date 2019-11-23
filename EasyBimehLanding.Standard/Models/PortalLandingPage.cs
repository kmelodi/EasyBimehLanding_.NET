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
    public class PortalLandingPage : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool licensed;
        private List<Models.InsuranceGroup> insuranceGroup;
        private List<string> insuranceType;
        private List<Models.SummaryCard> summaryCards;
        private List<Models.SummaryNotic> summaryNotics;
        private List<Models.ImageAlbum> imageAlbums;
        private List<Models.VideoGallery> videoGalleries;
        private Models.InsuranceCentre insuranceCentre;
        private Models.InsuranceCentrePortal insuranceCentrePortal;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("licensed")]
        public bool Licensed 
        { 
            get 
            {
                return this.licensed; 
            } 
            set 
            {
                this.licensed = value;
                onPropertyChanged("Licensed");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceGroup")]
        public List<Models.InsuranceGroup> InsuranceGroup 
        { 
            get 
            {
                return this.insuranceGroup; 
            } 
            set 
            {
                this.insuranceGroup = value;
                onPropertyChanged("InsuranceGroup");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceType")]
        public List<string> InsuranceType 
        { 
            get 
            {
                return this.insuranceType; 
            } 
            set 
            {
                this.insuranceType = value;
                onPropertyChanged("InsuranceType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("summaryCards")]
        public List<Models.SummaryCard> SummaryCards 
        { 
            get 
            {
                return this.summaryCards; 
            } 
            set 
            {
                this.summaryCards = value;
                onPropertyChanged("SummaryCards");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("summaryNotics")]
        public List<Models.SummaryNotic> SummaryNotics 
        { 
            get 
            {
                return this.summaryNotics; 
            } 
            set 
            {
                this.summaryNotics = value;
                onPropertyChanged("SummaryNotics");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("imageAlbums")]
        public List<Models.ImageAlbum> ImageAlbums 
        { 
            get 
            {
                return this.imageAlbums; 
            } 
            set 
            {
                this.imageAlbums = value;
                onPropertyChanged("ImageAlbums");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("videoGalleries")]
        public List<Models.VideoGallery> VideoGalleries 
        { 
            get 
            {
                return this.videoGalleries; 
            } 
            set 
            {
                this.videoGalleries = value;
                onPropertyChanged("VideoGalleries");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceCentre")]
        public Models.InsuranceCentre InsuranceCentre 
        { 
            get 
            {
                return this.insuranceCentre; 
            } 
            set 
            {
                this.insuranceCentre = value;
                onPropertyChanged("InsuranceCentre");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("insuranceCentrePortal")]
        public Models.InsuranceCentrePortal InsuranceCentrePortal 
        { 
            get 
            {
                return this.insuranceCentrePortal; 
            } 
            set 
            {
                this.insuranceCentrePortal = value;
                onPropertyChanged("InsuranceCentrePortal");
            }
        }
    }
} 