using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulsenicsAssessment.Models
{
    public class File
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        string connectionString = "server=DESKTOP-5JVB8O4\\SQLEXPRESS; database=EmployeeDB; Integrated Security=True; MultipleActiveResultSets=true; TrustServerCertificate=True;";



    }

}
