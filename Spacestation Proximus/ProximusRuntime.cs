namespace SSP
{
    using System;
    using System.Linq;

    using BeyondSharp.Server;
    using BeyondSharp.Server.Game;

    using SSP.Localization;

    public class ProximusRuntime : ApplicationRuntime
    {
        public override void Initialize()
        {
            ServerProgram.Logger.Info(Runtime.Initializing);
        }
    }
}