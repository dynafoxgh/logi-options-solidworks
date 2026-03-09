namespace Loupedeck.SolidWorksPlugin
{
    public class ViewFront : BasicSolidWorksAction
    {
        public ViewFront()
            : base("View Front", "View the front face", "View Toolbar", swCommands_e.swCommands_Front)
        {
        }
    }

    public class ViewBack : BasicSolidWorksAction
    {
        public ViewBack()
            : base("View Back", "View the back face", "View Toolbar", swCommands_e.swCommands_Back)
        {
        }
    }
    public class ViewLeft : BasicSolidWorksAction
    {
        public ViewLeft()
            : base("View Left", "View the left face", "View Toolbar", swCommands_e.swCommands_Left)
        {
        }
    }

    public class ViewRight : BasicSolidWorksAction
    {
        public ViewRight()
            : base("View Right", "View the right face", "View Toolbar", swCommands_e.swCommands_Right)
        {
        }
    }

    public class ViewBottom : BasicSolidWorksAction
    {
        public ViewBottom()
            : base("View Bottom", "View the bottom face", "View Toolbar", swCommands_e.swCommands_Bottom)
        {
        }
    }
    public class ViewTop : BasicSolidWorksAction
    {
        public ViewTop()
        : base("View Top", "View the top face", "View Toolbar", swCommands_e.swCommands_Top)
        {
        }
    }

    public class ViewIsometric : BasicSolidWorksAction
    {
        public ViewIsometric()
            : base("View Isometric", "View the isometric view", "View Toolbar", swCommands_e.swCommands_Isometric)
        {
        }
    }


}