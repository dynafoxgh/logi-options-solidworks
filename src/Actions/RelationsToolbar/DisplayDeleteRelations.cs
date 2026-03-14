// swCommands_e.swCommands_DisplayDeleteRelations

namespace Loupedeck.SolidWorksPlugin
{
    public class DisplayDeleteRelations : BasicSolidWorksAction
    {
        private readonly String _Icon;
        public DisplayDeleteRelations()
            : base("Display/Delete Relations", "Display or delete relations", "Relations Toolbar", swCommands_e.swCommands_DisplayDeleteRelations)
        {

        }
    }
}