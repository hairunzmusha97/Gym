namespace Domain
{
    public class Member
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime  DateofBirth { get; set; }
        public DateTime DateofJoin { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Duration { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool Disability { get; set; }    
        public string EmergencyContact { get; set; }
        public string Height { get; set; }  
        public string Weight { get; set; }
        public string Neck { get; set; }
        public string NIC { get; set; }
        public string Gender { get; set; }
        
    }
}