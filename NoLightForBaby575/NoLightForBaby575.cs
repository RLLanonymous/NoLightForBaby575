using Exiled.API.Features;
using System;

namespace NoLightForBaby575
{
    public class NoLightForBaby575 : Plugin<Config, Translations>
    {
        
        public override string Name { get; } = "NoLightForBaby575";
        public override string Author { get; } = "Sexy Lanonymous";
        public override string Prefix { get; } = "NoLightForBaby575";
        public override Version Version { get; } = new Version(1, 0, 0);
        
        public static NoLightForBaby575 Instance { get; private set; }
        
        public override void OnEnabled()
        {
            Instance = this;
            if (Instance.Config.StartupMessage)
            {
                Log.Info(@"
  _   _       _      _       _     _   ______         ____        _           _____ ______ _____ 
 | \ | |     | |    (_)     | |   | | |  ____|       |  _ \      | |         | ____|____  | ____|
 |  \| | ___ | |     _  __ _| |__ | |_| |__ ___  _ __| |_) | __ _| |__  _   _| |__     / /| |__  
 | . ` |/ _ \| |    | |/ _` | '_ \| __|  __/ _ \| '__|  _ < / _` | '_ \| | | |___ \   / / |___ \ 
 | |\  | (_) | |____| | (_| | | | | |_| | | (_) | |  | |_) | (_| | |_) | |_| |___) | / /   ___) |
 |_| \_|\___/|______|_|\__, |_| |_|\__|_|  \___/|_|  |____/ \__,_|_.__/ \__, |____/ /_/   |____/ 
                        __/ |                                            __/ |                   
                       |___/                                            |___/                    
                        ");
            }
            base.OnEnabled();
        }
        
        public override void OnDisabled()
        {
            if (Instance.Config.StartupMessage)
            {
                Log.Info(@"
  _   _       _      _       _     _   ______         ____        _           _____ ______ _____ 
 | \ | |     | |    (_)     | |   | | |  ____|       |  _ \      | |         | ____|____  | ____|
 |  \| | ___ | |     _  __ _| |__ | |_| |__ ___  _ __| |_) | __ _| |__  _   _| |__     / /| |__  
 | . ` |/ _ \| |    | |/ _` | '_ \| __|  __/ _ \| '__|  _ < / _` | '_ \| | | |___ \   / / |___ \ 
 | |\  | (_) | |____| | (_| | | | | |_| | | (_) | |  | |_) | (_| | |_) | |_| |___) | / /   ___) |
 |_| \_|\___/|______|_|\__, |_| |_|\__|_|  \___/|_|  |____/ \__,_|_.__/ \__, |____/ /_/   |____/ 
                        __/ |                                            __/ |                   
                       |___/                                            |___/                    
                        ");
            }
            Instance = null;
            base.OnDisabled();
        }
    }
}