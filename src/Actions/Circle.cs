namespace Loupedeck.SolidWorksPlugin
{
    using System;

    using Loupedeck.SolidWorksPlugin.Helpers;
    public class Circle : BasicSolidWorksAction
    {
        private readonly String _Icon;
        public Circle()
            : base("Circle", "Create a circle","Sketch Tools",swCommands_e.swCommands_Circle)
        {
        }
    }
}