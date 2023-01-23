// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing
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
        /// Create a new instance of the GraphicsAPI struct, implicitly using the core profile and default context
        /// flags of the given api.
        /// </summary>
        /// <param name="api">The context API to use.</param>
        /// <param name="apiVersion">The API version to use.</param>
        public GraphicsAPI(ContextAPI api, APIVersion apiVersion)
            : this(api, ContextProfile.Core, ContextFlags.Default, apiVersion)
        {
            // do nothing else
        }

        /// <summary>
        /// The default graphics API. This is OpenGL 3.3 core profile, with forward compatability enabled.
        /// </summary>
        public static GraphicsAPI Default => new GraphicsAPI
        (
            ContextAPI.OpenGL, ContextProfile.Core,
            ContextFlags.ForwardCompatible, new APIVersion(3, 3)
        );

        /// <summary>
        /// The default vulkan graphics API. This is Vulkan 1.1.
        /// </summary>
        public static GraphicsAPI DefaultVulkan => new GraphicsAPI
        (
            ContextAPI.Vulkan, ContextProfile.Core,
            ContextFlags.ForwardCompatible, new APIVersion(1, 1)
        );

        /// <summary>
        /// No graphics API.
        /// </summary>
        public static GraphicsAPI None => default;
    }
}