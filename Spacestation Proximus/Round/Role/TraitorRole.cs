namespace SSP.Gamemode.Role
{
    using System;
    using System.Linq;

    public class TraitorRole : BaseRole
    {
        public override string Name
        {
            get
            {
                return Localization.Gamemode.TraitorRoleName;
            }
        }
    }
}