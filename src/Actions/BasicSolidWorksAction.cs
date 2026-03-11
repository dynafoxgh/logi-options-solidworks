namespace Loupedeck.SolidWorksPlugin;

using Helpers;

public abstract class BasicSolidWorksAction : PluginDynamicCommand
{
    private readonly String _Icon;
    private readonly swCommands_e _Command;
    public BasicSolidWorksAction(String displayName, String description, String groupName, swCommands_e command)
        : base(displayName: displayName,
            description: description,
            groupName: groupName)
    {
        this._Icon = displayName.Replace(" ", "").Replace("/", "");
        this._Command = command;
    }

    protected override void RunCommand(String actionParameter)
    {
        try
        {
            // get the SolidWorks application; exit if not available
            if (!SolidWorksConnector.TryGetApplication(out var swApp))
            {
                Console.WriteLine("SolidWorks is not running.");
                return;
            }
            Console.WriteLine("Connected to SolidWorks.");

            // Attach to the active document
            var model = (ModelDoc2)swApp.ActiveDoc;
            if (model == null)
            {
                Console.WriteLine("No active document in SolidWorks.");
                return;
            }

            swApp.RunCommand((Int32)this._Command, ""); // Run the Add Relation command

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        => BitmapImage.FromResource(this.Plugin.Assembly, $"Loupedeck.SolidWorksPlugin.{this._Icon}.png");
}
