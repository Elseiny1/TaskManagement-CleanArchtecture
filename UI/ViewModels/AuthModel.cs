namespace UI.ViewModels
{
    public class AuthModel
    {
        public string Massage { get; set; }
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public List<string> Roles { get; set; }
    }
}
