using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Cipher_Notes.Models
{
    [Table("SecureNotes")]
    public class SecureNotes
    {
        //declaring properties with public setter and getter properties!

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public String title { get; set; }

        public String encrypted_content { get; set; }

        public String salt { get; set; }

        public String i_v { get; set; }

        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }


    }
}
