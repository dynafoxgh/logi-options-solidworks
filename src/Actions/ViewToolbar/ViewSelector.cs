namespace Loupedeck.SolidWorksPlugin
{
    public class ViewSelector : PluginDynamicFolder
    {

        public ViewSelector()
        {
            this.DisplayName = "View Orientation";
            this.GroupName = "View Toolbar###View Orientation";
            this.Description = "Select a view orientation";
        }

        public override IEnumerable<String> GetButtonPressActionNames(DeviceType _)
        {
            return new[]
            {
                PluginDynamicFolder.NavigateUpActionName,
                this.CreateCommandName("Top"),
                this.CreateCommandName(""),
                this.CreateCommandName("Left"),
                this.CreateCommandName("Front"),
                this.CreateCommandName("Right"),
                this.CreateCommandName("Back"),
                this.CreateCommandName("Bottom"),
            };
        }

        public override void RunCommand(String actionParameter)
        {
            switch (actionParameter)
            {
                case "Top":
                    new ViewTop().TryRunCommand(actionParameter);
                    break;
                case "Left":
                    new ViewLeft().TryRunCommand(actionParameter);
                    break;
                case "Front":
                    new ViewFront().TryRunCommand(actionParameter);
                    break;
                case "Right":
                    new ViewRight().TryRunCommand(actionParameter);
                    break;
                case "Back":
                    new ViewBack().TryRunCommand(actionParameter);
                    break;
                case "Bottom":
                    new ViewBottom().TryRunCommand(actionParameter);
                    break;
            }
        }

        public override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            switch (actionParameter)
            {
                case "Front":
                    return BitmapImage.FromResource(this.Plugin.Assembly, $"Loupedeck.SolidWorksPlugin.ViewFront.png");
                // Else return a default image or null
                default:
                    return BitmapImage.FromResource(this.Plugin.Assembly, $"Loupedeck.SolidWorksPlugin.ViewSelector.png");
            }

        }
    }
}