using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Challenge.Pages
{
    public class IndexModel : PageModel
    {
        // These properties hold the data that will be displayed on the HTML page
        public string HungerMessage { get; set; } = string.Empty;
        public string SoundMessage { get; set; } = string.Empty;
        public string DayMessage { get; set; } = string.Empty;

        // This method runs when the user clicks the 'Submit' button
        public void OnPost()
        {
            // Extracting the values from the form and converting them from strings to integers
            int hungerLevel = int.Parse(Request.Form["hungerLevel"]);
            int dayOfWeek = int.Parse(Request.Form["dayOfWeek"]);

            // if-else statement used for range-based logic
            if (hungerLevel >=8)
            {
                HungerMessage = "Lion: Roar! I need a big meal!";
            }
            else if (hungerLevel>=5)
            {
                HungerMessage = "Monkey: Ooh ooh! I'll take some bananas.";
            }
            else
            {
                HungerMessage = "Tortoise: Slow and steady-I'll have some lettuce.";
            }

            // Ternary Operator: 
            SoundMessage = (hungerLevel >= 8)
                ? "Listen to the lion: Roar!"
                : "Listen to the monkey: Ooh ooh!";

            // Switch statement to set DayMessage with a fun zoo event for each day
            switch (dayOfWeek)
            {
                case 1:
                    DayMessage = "Sunday: Bunny Fun Day.";
                    break;
                case 2:
                    DayMessage = "Monday: Monkey Madness.";
                    break;
                case 3:
                    DayMessage = "Tuesday: Tuna School for thought.";
                    break;
                case 4:
                    DayMessage = "Wednsday: Wings & Things.";
                    break;
                case 5:
                    DayMessage = "Thursday: Snakes & Steaks.";
                    break;
                case 6:
                    DayMessage = "Friday: Fur-day Night Live.";
                    break;
                case 7:
                    DayMessage = "Saturday: Sloth-urday away.";
                    break;
                default:
                    DayMessage = "Please enter a valid day (1-7).";
                    break;
            }
        }
    }
}