using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Features.Roles;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace NoLightForBaby575
{
    public class Config : IConfig
    {
        [Description("Should the plugin be enabled?")]
        public bool IsEnabled { get; set; } = true;
        
        [Description("Should the plugin be in debug mode?")]
        public bool Debug { get; set; } = false;
        
        [Description("Should the plugin show a startup message?")]
        public bool StartupMessage { get; set; } = true;
        
        [Description("Which roles can cut the lights off?")]
        public List<RoleTypeId> NoLightAllowedRoles { get; set; } = new List<RoleTypeId>
        {
            RoleTypeId.NtfSpecialist,
            RoleTypeId.NtfCaptain
        };
        
        [Description("The time the light is gonna be off?")]
        public float NoLightTime { get; set; } = 30f;
        
        [Description("The cassie played when the light are off?")]
        public string NoLightCassie { get; set; } = "Facility lights have been turned off.";
        
        [Description("The cassie played when the light are off?")]
        public string LightCassie { get; set; } = "Facility lights have been turned on!";
        
    }
}