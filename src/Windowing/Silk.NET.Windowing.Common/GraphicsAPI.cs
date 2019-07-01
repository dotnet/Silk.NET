// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Represents the context API, and associated configuration, that the window should use.
    /// </summary>
    /// <remarks>
    /// <para>
    /// By default, this struct uses OpenGL 3.3, core profile, forward-compatable.
    /// </para>
    /// </remarks>
    public struct GraphicsAPI
    {
        /// <summary>
        /// The rendering API to use.
        /// </summary>
        public ContextAPI API { get; set; }

        /// <summary>
        /// The profile to use.
        /// </summary>
        public ContextProfile Profile { get; set; }

        /// <summary>
        /// Context creation flags.
        /// </summary>
        public ContextFlags Flags { get; set; }

        /// <summary>
        /// The version of the API to use.
        /// </summary>
        public APIVersion Version { get; set; }

        /// <summary>
        /// Create a new instance of the GraphicsAPI struct.
        /// </summary>
        /// <param name="api">The context API to use.</param>
        /// <param name="profile">The context profile to use.</param>
        /// <param name="flags">The context flags to use.</param>
        /// <param name="apiVersion">The API version to use.</param>
        public GraphicsAPI(ContextAPI api, ContextProfile profile, ContextFlags flags, APIVersion apiVersion)
        {
            API = api;
            Profile = profile;
            Flags = flags;
            Version = apiVersion;
        }
        
        /// <summary>
        /// The default graphics API. This is OpenGL 3.3 core profile, with forward compatability enabled.
        /// </summary>
        public static GraphicsAPI Default => new GraphicsAPI(ContextAPI.OpenGL, ContextProfile.Core, ContextFlags.ForwardCompatible, new APIVersion(3, 3));
    }
}