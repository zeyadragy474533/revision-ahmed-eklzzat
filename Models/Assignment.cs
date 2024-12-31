using System.ComponentModel.DataAnnotations.Schema;

namespace revision_ahmed_eklzzat.Models
{
    public class Assignment
    {

        public int id { get; set; }

        public string title { get; set; }
        public string description { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }

        [ForeignKey("departmentID")]
        public int departmentID { get; set; }
        public Department department { get; set; }

        [ForeignKey("studentID")]
        public int studentID { get; set; }
        public Student student { get; set; }



    }
}
