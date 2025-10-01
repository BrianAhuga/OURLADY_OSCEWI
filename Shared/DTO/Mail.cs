namespace Shared.DTO
{
    public class Mail
    {
        public string To { get; set; }
        public string From { get; set; } = "no-reply@ourladyps.org";
        public string FromPassword { get; set; } = "Lady@2020?";
        public string Subject { get; set; }
        public string SenderName { get; set; } = "Our Lady Parents' School - Luweero";
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
