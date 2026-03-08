namespace Loupedeck.SolidWorksPlugin
{
    using System;

    using Loupedeck.SolidWorksPlugin.Helpers;
    public class Sketch : PluginDynamicCommand
    {

        private Boolean _isInSketchMode = false;

        public Sketch()
            : base(displayName: "Sketch", description: "Sketch mode", groupName: "Sketch Tools")
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

                // Enter sketch on the selected plane
                SketchManager sketchMgr = model.SketchManager;
                sketchMgr.InsertSketch(true);

                Console.WriteLine("Entered sketch mode.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
            => BitmapImage.FromResource(this.Plugin.Assembly, "Loupedeck.SolidWorksPlugin.Sketch.png");

    }
}