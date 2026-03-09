namespace Loupedeck.SolidWorksPlugin
{
    using System;

    using Loupedeck.SolidWorksPlugin.Helpers;
    public class CornerRectangle : BasicSolidWorksAction
    {
        private readonly String _Icon;
        public CornerRectangle()
            : base( "Corner Rectangle", "Create a corner rectangle", "Sketch Tools", swCommands_e.swCommands_Rectangle)
        {
        }
    }
}