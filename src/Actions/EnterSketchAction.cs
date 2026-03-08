using System;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace Loupedeck.SolidWorksPlugin
{
    using System;
    public class SolidworksCommand : PluginDynamicCommand
    {
        public SolidworksCommand()
            : base(displayName: "Enter Sketch", description: "Enters sketch mode", groupName: "Commands")
        {
        }

        protected override void RunCommand(String actionParameter)
        {
            try
            {
                // Connect to SolidWorks
                Type swType = Type.GetTypeFromProgID("SldWorks.Application");
                SldWorks swApp = null;
                // If solidworks is not running, do nothing
                if (swType == null)
                {
                    Console.WriteLine("SolidWorks is not running.");
                    return;
                }
                else
                {
                    Console.WriteLine("Connected to SolidWorks.");
                    swApp = (SldWorks)Activator.CreateInstance(swType);
                }
                

                // Attach to the active document
                ModelDoc2 model = (ModelDoc2)swApp.ActiveDoc;
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

    }
}