namespace Models
{
    public class User : Base.Entity
    {
        public User() : base()
        {
        }

        // **********
        public bool IsActive { get; set; }
        // **********

        // **********
        public Enums.UserType Type { get; set; }
        // **********

        // **********
        public string FullName { get; set; }
        // **********

        // **********
        public string Username { get; set; }
        // **********

        // **********
        public string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = Dtx.Security.Hashing.GetSha1(value);
            }
        }
        // **********

        // **********
        public string NationalCode { get; set; }
        // **********

        // **********
        public string EmailAddress { get; set; }
        // **********

        // **********
        public string CellPhoneNumber { get; set; }
        // **********

        // **********
        public string Description { get; set; }
        // **********

        // **********
        public bool IsDeleted { get; set; }
        // **********

        // **********
        public System.Guid? DeletedUserId { get; set; }
        // **********

    }
}
