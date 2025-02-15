using System;
using System.Linq;
using PlayerRoles;
using RemoteAdmin;
using CommandSystem;
using Exiled.API.Features;
using Exiled.API.Features.Toys;
using MEC;
using PluginAPI.Core;
using UnityEngine;
using Cassie = Exiled.API.Features.Cassie;
using Light = UnityEngine.Light;
using Map = Exiled.API.Features.Map;
using Player = Exiled.API.Features.Player;

namespace NoLightForBaby575.CommandsHandlers
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class NoLight : ICommand
    {
        public string Command => "facilitylightsoff";

        public string Description => "Turn off the lights in the facility.";

        public string[] Aliases => "nolights, stoplights".Split(',');

        private bool isBlackout = false;
        
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!(sender is PlayerCommandSender))
            {
                response = NoLightForBaby575.Instance.Translation.RaptorNotAllowed;
                return false;
            }

            Player caller = Player.Get(sender);

            if (!NoLightForBaby575.Instance.Config.NoLightAllowedRoles.Contains(caller.Role.Type))
            {
                response = NoLightForBaby575.Instance.Translation.RoleNotAllowed;
                return false;
            }

            if (caller.CurrentItem == null || caller.CurrentItem.Type != ItemType.Radio)
            {
                response = NoLightForBaby575.Instance.Translation.NotItem;
                return false;
            }
            
            if (isBlackout)
            {
                response = NoLightForBaby575.Instance.Translation.AlreadyBlackout;
                return false;
            }

            isBlackout = true;
            Map.TurnOffAllLights(NoLightForBaby575.Instance.Config.NoLightTime);
            Cassie.MessageTranslated(NoLightForBaby575.Instance.Config.NoLightCassie, NoLightForBaby575.Instance.Translation.NoLightTranslation, false, true, true);

            Timing.CallDelayed(NoLightForBaby575.Instance.Config.NoLightTime, () =>
            {
                isBlackout = false;
                Cassie.MessageTranslated(NoLightForBaby575.Instance.Config.LightCassie, NoLightForBaby575.Instance.Translation.LightTranslation, false, true, true);
            });
                
            response = NoLightForBaby575.Instance.Translation.OkZebi;
            return true;
        }
    }
}