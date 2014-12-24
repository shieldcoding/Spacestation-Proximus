namespace SSP.Gamemode.Gamemodes
{
    using System;
    using System.Linq;

    using SSP.Localization;

    public class MixedGamemode : BaseGamemode
    {
        public override string Name
        {
            get
            {
                return Gamemode.MixedGamemodeName;
            }
        }
    }
}