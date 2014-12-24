namespace SSP.Gamemode.Role
{
    using System;
    using System.Linq;

    public class WizardRole : BaseRole
    {
        public override string Name
        {
            get
            {
                return Localization.Gamemode.WizardRoleName;
            }
        }
    }
}