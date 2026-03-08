namespace Loupedeck.SolidWorksPlugin
{
    using System;

    using Loupedeck.SolidWorksPlugin.Helpers;
    public class SmartDimension : PluginDynamicCommand
    {
        private readonly String _Icon;
        public SmartDimension()
            : base(displayName: "Smart Dimension", description: "Create a smart dimension", groupName: "Sketch Tools")
        {
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
                swApp.RunCommand((Int32)swCommands_e.swCommands_SmartDimension, ""); // Run the Smart Dimension command

                // check if sketch is in sketch mode
                Console.WriteLine("Entered sketch mode.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            this.ActionImageChanged();
        }

        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
            => BitmapImage.FromResource(this.Plugin.Assembly, "Loupedeck.SolidWorksPlugin.SmartDimension.png");

    }
}