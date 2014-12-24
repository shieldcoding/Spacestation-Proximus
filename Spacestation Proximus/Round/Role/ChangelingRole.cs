namespace SSP.Gamemode.Role
{
    using System;
    using System.Linq;

    public class ChangelingRole : BaseRole
    {
        public override string Name
        {
            get
            {
                return Localization.Gamemode.ChangelingRoleName;
            }
        }
    }
}