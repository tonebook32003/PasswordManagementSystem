using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG_BMHTTT_PMS.Model
{
     internal class PasswordEntry
     {
          public int EntryId { get; set; }
          public int UserId { get; set; }
          public string WebsiteName { get; set; }
          public string WebsiteUrl { get; set; }
          public string UsernameForSite { get; set; }
          public string EncryptedPassword { get; set; }
          public string Notes { get; set; }
          public string Category { get; set; }
          public DateTime CreatedDate { get; set; }
          public DateTime? LastModified { get; set; }
     }
}
