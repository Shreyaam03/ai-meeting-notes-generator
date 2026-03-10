namespace MeetingAI.API.Models
{
    public class MeetingResponse
    {
        public string Summary { get; set; }
        public List<string> KeyPoints { get; set; }
        public List<string> ActionItems { get; set; }
    }
}
