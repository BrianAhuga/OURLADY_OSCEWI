namespace Shared.DTO
{
    public class ServiceResponse
    {
        public bool IsSuccessful { get; set; } = true;
        public string Message { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }
}
