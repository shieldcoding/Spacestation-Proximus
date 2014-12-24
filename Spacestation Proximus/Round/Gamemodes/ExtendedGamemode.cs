namespace SSP.Gamemode.Gamemodes
{
    using System;
    using System.Linq;

    using SSP.Localization;

    public class ExtendedGamemode : BaseGamemode
    {
        public override string Name
        {
            get
            {
                return Gamemode.ExtendedGamemodeName;
            }
        }
    }
}