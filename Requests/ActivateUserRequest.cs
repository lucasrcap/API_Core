namespace UserMasterAPI.Requests
{
    public class ActivateUserRequest
    {
        public string Userid { get; set; }
        public string? Role { get; set; }
        public bool? IsActive { get; set; }
    }
}
