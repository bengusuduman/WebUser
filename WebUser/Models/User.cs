namespace WebUser.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public int KullaniciID { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
    }
}
