namespace Loupedeck.SolidWorksPlugin
{
    using System;

    using Loupedeck.SolidWorksPlugin.Helpers;

    public class Line : BasicSolidWorksAction
    {
        private readonly String _Icon;
        public Line()
            : base("Line", "Create a line", "Sketch Tools", swCommands_e.swCommands_Line)
        {
        }
    }
}