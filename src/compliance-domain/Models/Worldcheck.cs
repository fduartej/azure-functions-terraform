using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Compliance.Domain.Models
{
    // [Table("Worldcheck")]
    public class Worldcheck
    {
        [Key]
        [JsonProperty("uid")]
        [Column("UID")]
        public string UID { get; set; }
        
        [JsonProperty("lastname")]
        [Column("LAST NAME")]
        public string  LastName { get; set; }

        [JsonProperty("firstname")]
        [Column("FIRST NAME")]
        public string  FirstName { get; set; }

        [JsonProperty("aliases")]
        [Column("ALIASES")]
        public string  Aliases { get; set; }
 
        [JsonProperty("alternativespelling")]
         [Column("ALTERNATIVE SPELLING")]
        public string  AlternativeSpelling { get; set; }
        
        [JsonProperty("category")]
         [Column("CATEGORY")]
        public string  Category { get; set; }

        [JsonProperty("title")]
         [Column("TITLE")]
        public string  Title { get; set; }

          [JsonProperty("subcategory")]
         [Column("SUB-CATEGORY")]
        public string  SubCategory { get; set; }

          [JsonProperty("position")]
         [Column("POSITION")]
        public string  Position { get; set; }

          [JsonProperty("age")]
         [Column("AGE")]
        public string  Age { get; set; }

          [JsonProperty("dob")]
         [Column("DOB")]
        public string  Dob { get; set; }

          [JsonProperty("placeofbirth")]
         [Column("PLACE OF BIRTH")]
        public string  PlaceOfBirth { get; set; }

          [JsonProperty("deceased")]
         [Column("DECEASED")]
        public string  Deceased { get; set; }

          [JsonProperty("passports")]
         [Column("PASSPORTS")]
        public string  Passports { get; set; }

          [JsonProperty("ssn")]
         [Column("SSN")]
        public string  Ssn { get; set; }

          [JsonProperty("locations")]
         [Column("LOCATIONS")]
        public string  Locations { get; set; }

          [JsonProperty("countries")]
         [Column("COUNTRIES")]
        public string  Countries { get; set; }

          [JsonProperty("companies")]
         [Column("COMPANIES")]
        public string  Companies { get; set; }

          [JsonProperty("ei")]
         [Column("E I")]
        public string  Ei { get; set; }

          [JsonProperty("linkedto")]
         [Column("LINKED TO")]
        public string  LinkedTo { get; set; }

          [JsonProperty("furtherinformation")]
         [Column("FURTHER INFORMATION")]
        public string  FurtherInformation { get; set; }

         [JsonProperty("keywords")]
         [Column("KEYWORDS")]
        public string  Keywords { get; set; }

         [JsonProperty("externalsources")]
         [Column("EXTERNAL SOURCES")]
        public string ExternalSources { get; set; }

         [JsonProperty("entered")]
         [Column("ENTERED")]
        public string Entered { get; set; }

         [JsonProperty("updated")]
         [Column("UPDATED")]
        public string Updated { get; set; }

         [JsonProperty("editor")]
         [Column("EDITOR")]
        public string Editor { get; set; }

         [JsonProperty("agedate")]
         [Column("AGE DATE (AS OF DATE)")]
        public string AgeDate { get; set; }

         [JsonProperty("audfechacreacion")]
         [Column("aud_FechaCreacion")]
        public DateTime aud_FechaCreacion { get; set; }

         [JsonProperty("audfechamodificacion")]
         [Column("aud_FechaModificacion")]
        public DateTime aud_FechaModificacion { get; set; }
    }
}



	// [UID] [varchar](10) NOT NULL,
	// [LAST NAME] [varchar](500) NULL,
	// [FIRST NAME] [varchar](500) NULL,
	// [ALIASES] [text] NULL,
	// [ALTERNATIVE SPELLING] [varchar](1000) NULL,
	// [CATEGORY] [varchar](50) NULL,
	// [TITLE] [varchar](50) NULL,
	// [SUB-CATEGORY] [varchar](10) NULL,
	// [POSITION] [varchar](500) NULL,
	// [AGE] [varchar](3) NULL,
	// [DOB] [varchar](10) NULL,
	// [PLACE OF BIRTH] [varchar](500) NULL,
	// [DECEASED] [varchar](10) NULL,
	// [PASSPORTS] [varchar](1000) NULL,
	// [SSN] [varchar](100) NULL,
	// [LOCATIONS] [text] NULL,
	// [COUNTRIES] [varchar](50) NULL,
	// [COMPANIES] [text] NULL,
	// [E I] [varchar](1) NULL,
	// [LINKED TO] [text] NULL,
	// [FURTHER INFORMATION] [text] NULL,
	// [KEYWORDS] [varchar](1000) NULL,
	// [EXTERNAL SOURCES] [text] NULL,
	// [ENTERED] [varchar](10) NULL,
	// [UPDATED] [varchar](10) NULL,
	// [EDITOR] [varchar](50) NULL,
	// [AGE DATE (AS OF DATE)] [varchar](10) NULL,
	// [aud_FechaCreacion] [datetime] NULL,
	// [aud_FechaModificacion] [datetime] NULL,
	// [LASTNAME] [varchar](3000) NULL,