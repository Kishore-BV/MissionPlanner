using System;

namespace XYZ  // <<-- IMPORTANT: use the SAME namespace as in GDAL.cs
{
    /// <summary>
    /// Minimal stub so MissionPlanner can build without native GDAL setup.
    /// </summary>
    public static class GdalConfiguration
    {
        public static void ConfigureGdal()
        {
            // In the real implementation, this would load GDAL native binaries
            // and set up environment variables. For now we keep it empty so
            // the rest of Mission Planner can run.
        }

        public static void ConfigureOgr()
        {
            // Same idea as above – stubbed out.
        }
    }
}
