using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.MySqlClient;
using MySql.Data.EntityFramework;

namespace genztrend.Models
{
    public class News
    {
        public int Id { get; set; }
        public int IdZone { get; set; }
        public Int32 IdCategory { get; set; }
        public string Title { get; set; }
        public string Teaser { get; set; }
        public string Avatar { get; set; }
        public int IdUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime PublishDate { get; set; }
        public string Body { get; set; }
        public int Status { get; set; }
        public string UrlLink { get; set; }
        public int HomeFeature { get; set; }
        public int CatFeature { get; set; }
        public int ViewCount { get; set; }
        public string AvatarThumb { get; set; }
        public string AvatarFB { get; set; }
        public bool IsFeature { get; set; }
    }


}
  
