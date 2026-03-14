namespace Loupedeck.SolidWorksPlugin
{
    public class EditComponent : BasicSolidWorksAction
    {
        public EditComponent()
            : base("Edit Component", "Edit the selected component", "Assembly Toolbar", swCommands_e.swCommands_EditComponent)
        {
        }
    }
}