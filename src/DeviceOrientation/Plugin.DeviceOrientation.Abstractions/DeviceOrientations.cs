using System;

namespace Plugin.DeviceOrientation.Abstractions
{
    /// <summary>
    ///     Current device orientation
    /// </summary>
	[Flags]
    public enum DeviceOrientations : uint
    {
        /// <summary>
        ///     Undefined or other orientation
        /// </summary>
        Undefined = 0u,

        /// <summary>
        ///     When rotate the device 0 degrees
        /// </summary>
        Portrait = 2u,

        /// <summary>
        ///     When rotate the device 90 degrees
        /// </summary>
        Landscape = 1u,

        /// <summary>
        ///     When rotate the device 180 degrees
        /// </summary>
        PortraitFlipped = 8u,

        /// <summary>
        ///     When rotate the device 270 degrees
        /// </summary>
        LandscapeFlipped = 4u
    }
}