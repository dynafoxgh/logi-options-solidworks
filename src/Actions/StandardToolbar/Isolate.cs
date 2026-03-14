namespace Loupedeck.SolidWorksPlugin
{
    public class Isolate : BasicSolidWorksAction
    {
        public Isolate()
            : base("Isolate", "Isolate the selected components", "Standard Toolbar", swCommands_e.swCommands_Comp_Isolate)
        {
        }
    }

    // public class IsolateExit : BasicSolidWorksAction
    // {
    //     public IsolateExit()
    //         : base("Isolate Exit", "Exit the isolate mode", "Standard Toolbar", swCommands_e.swCommands_Comp_Isolate_Exit)
    //     {
    //     }
    // }

}