namespace Shared.DTO
{
    public class Mail
    {
        public string To { get; set; }
        public string From { get; set; } = "no-reply@geomaticstechnics.co.ke";
        public string FromPassword { get; set; } = "Passw0rd@123";
        public string Subject { get; set; }
        public string SenderName { get; set; } = "Geomatics Technics";
        public string? RecipientName { get; set; }
        public string? Message { get; set; }
    }

    public class ContactForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
