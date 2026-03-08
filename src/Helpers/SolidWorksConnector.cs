namespace Loupedeck.SolidWorksPlugin.Helpers
{
    using SolidWorks.Interop.sldworks;
    /// <summary>
    /// Provides helper methods for acquiring a SolidWorks COM application instance.
    /// </summary>
    public static class SolidWorksConnector
    {
        /// <summary>
        /// Attempts to return a running instance of the SolidWorks application.
        /// </summary>
        /// <param name="swApp">Out parameter containing the application if successful.</param>
        /// <returns>True if SolidWorks was found/is running; otherwise false.</returns>
        public static Boolean TryGetApplication(out SldWorks swApp)
        {
            swApp = null;
            var swType = Type.GetTypeFromProgID("SldWorks.Application");
            if (swType == null)
            {
                return false;
            }

            swApp = (SldWorks)Activator.CreateInstance(swType);
            return swApp != null;
        }

        /// <summary>
        /// Gets the SolidWorks application instance or throws if it cannot be obtained.
        /// </summary>
        /// <returns>Running <see cref="SldWorks"/> instance.</returns>
        public static SldWorks GetApplicationOrThrow()
        {
            return !TryGetApplication(out var swApp) || swApp == null
                ? throw new InvalidOperationException("SolidWorks is not running or could not be started.")
                : swApp;
        }
    }
}