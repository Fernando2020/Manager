namespace Manager.Services.DTO
{
    public class UserDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserDTO()
        {

        }

        public UserDTO(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
