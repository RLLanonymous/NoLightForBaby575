using System.ComponentModel;
using Exiled.API.Interfaces;

namespace NoLightForBaby575
{
    public class Translations : ITranslation
    {
        [Description("The cassie translation played when the light are off?")]
        public string NoLightTranslation { get; set; } = "Facility lights have been turned <color=red>off</color>.";
        
        [Description("The cassie translation played when the light are off?")]
        public string LightTranslation { get; set; } = "Facility lights have been turned <color=green>on</color>.";
        
        [Description("The message send when they try to send the commands but are not an human!")]
        public string RaptorNotAllowed { get; set; } = "Your not an human!";
        
        [Description("The message send when they try to send the commands but are not in the right role!")]
        public string RoleNotAllowed { get; set; } = "Your not in the right role!";
        
        [Description("The message send when they try to send the commands but doesn't have the radio in their hands!")]
        public string NotItem { get; set; } = "You need a radio in your hands!";
        
        [Description("The message send when they try to send the commands but the lights are already off!")]
        public string AlreadyBlackout { get; set; } = "The lights are already off!";
        
        [Description("The message send when they send the commands!")]
        public string OkZebi { get; set; } = "The lights are now off!";
        
        
    }
}