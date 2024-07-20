namespace Foody.PresentationLayer.Models
{
    public class Materials
    {
        public static string[] GetTitle(string controller, string action)
        {
            return new string[] { controller, action };
        }
    }
}
