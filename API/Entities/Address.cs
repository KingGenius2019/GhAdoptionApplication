namespace API.Entities
{
    public class Address
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Organisation {get; set;}
        public string Designation {get; set;}
        public string Region {get; set;}

        public string AppUserId {get; set;}
        public AppUser AppUser {get; set;}
    }
}