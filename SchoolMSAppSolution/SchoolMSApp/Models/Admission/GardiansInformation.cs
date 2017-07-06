using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolMSApp.Models.Admission
{
    public class GardiansInformation
    {
        public int Id { get; set; }
        public string FatherName { get; set; }
        public byte[] FatherPicture { get; set; }
        public int FathersOccupationId { get; set; }
        public string FatherPhoneNo { get; set; }
        public string FatherEmail { get; set; }
        public string MotherName { get; set; }
        public byte[] MothersPicture { get; set; }
        public int MothersOccupationId { get; set; }
        public string MotherPhoneNo { get; set; }
        public string MotherEmail { get; set; }
        public string GurdianName { get; set; }
        public byte[] GurdianPIcture { get; set; }
        public int GurdianOccupationId { get; set; }
        public string GurdianPhoneNo { get; set; }
        public string GurdianEmail { get; set; }
        public Relation GurdiansRelation { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
         
    }

    public enum Relation
    {
        Father,
        Mother,
        Uncle,
        Aunt,
        Brother,
        Sister, 
        GrandMother, 
        GrandFather
    }
}