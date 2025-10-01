using APIServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shared.DTO;

namespace OurLadyPS.Web.Pages
{
    public class ContactModel : PageModel
    {
        private MailService mailservice;

        public ContactModel(MailService _mailService)
        {
            mailservice = _mailService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostSendMessage(ContactForm form)
        {
            try
            {
                // Notify user
                Mail mail = new()
                {
                    RecipientName = form.Name,
                    To = form.Email,
                    Subject = "Message Received",
                    Message = $@"
                        <div style='font-family:Segoe UI, sans-serif; padding:20px; border:1px solid #e0e0e0; border-radius:8px; max-width:600px; margin:auto; background-color:#f9f9f9;'>
                            <h2 style='color:#0c75bc;'>Hello {form.Name},</h2>
                            <p style='font-size:16px; color:#333;'>Thank you for reaching out to <strong>Our Lady Parents' School - Luweero</strong>. We’ve received your message and our team will get back to you as soon as possible.</p>
                            <p style='font-size:16px; color:#333;'>Meanwhile, feel free to explore more on our website or reach us directly using the contact information below.</p>
                            <hr style='margin:20px 0; border:none; border-top:1px solid #ddd;' />
                            <p style='font-size:14px; color:#555;'>With appreciation,</p>
                            <p style='font-size:14px; color:#0c75bc; font-weight:bold;'>Email:  info@ourladyps.org</p>
                            <p style='font-size:14px; color:#0c75bc; font-weight:bold;'>Phone:  +256(0)772 450 346</p>
                        </div>"
                };

                mailservice.SendMail(mail);

                // Notify admin
                mail.To = "info@ourladyps.org";
                mail.RecipientName = "Our Lady Parents' School Day and Boarding School - Luweero";
                mail.Subject = form.Subject;
                mail.Message = $@"
                    <div style='font-family:Segoe UI, sans-serif; padding:20px; border:1px solid #e0e0e0; border-radius:8px; max-width:600px; margin:auto; background-color:#fffbe6;'>
                        <h2 style='color:#0c75bc;'>New Message from Website</h2>
                        <p style='font-size:16px; color:#333;'><strong>Name:</strong> {form.Name}</p>
                        <p style='font-size:16px; color:#333;'><strong>Email:</strong> {form.Email}</p>
                        <p style='font-size:16px; color:#333;'><strong>Subject:</strong> {form.Subject}</p>
                        <div style='margin-top:20px; padding:15px; background-color:#f4f4f4; border-left:4px solid #0c75bc;'>
                            <p style='font-size:15px; color:#444; white-space:pre-line;'>{form.Message}</p>
                        </div>
                        <hr style='margin:20px 0; border:none; border-top:1px solid #ddd;' />
                        <footer style='font-size:12px; color:#999;'>This message was sent from the official <strong>Our Lady Parents' School - Luweero</strong> website contact form.</footer>
                    </div>"
                    ;

                mailservice.SendMail(mail);

                return new JsonResult(new { success = true });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { success = false, message = ex.Message });
            }
        }
    }
}
