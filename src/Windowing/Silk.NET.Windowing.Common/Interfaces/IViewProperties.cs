// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using Silk.NET.Core.Contexts;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    public interface IViewProperties
    {
        /// <summary>
        /// If true, SwapBuffers will be called automatically at the end of each Render event.
        /// </summary>
        bool ShouldSwapAutomatically { get; set; }

        /// <summary>
        /// If true, instead of executing the Update and Render events at a fixed interval, they will only be executed
        /// once there are events waiting to be processed.
        /// </summary>
        /// <remarks>
        /// The <see cref="UpdatesPerSecond"/> and <see cref="FramesPerSecond"/> will still be respected and treated as
        /// the "maximum" number of frames per second. Typically, the time between events is greater than the frame
        /// period, however.
        /// </remarks>
        bool IsEventDriven { get; set; }

        /// <summary>
        /// If true, disables automatically controlling the OpenGL context on the thread on which the
        /// <see cref="IView.Render"/> event is called i.e. disables moving the OpenGL context to that thread, or
        /// updating the <see cref="IGLContext.SwapInterval"/> in response to the <see cref="VSync"/> property. This
        /// property will also disable automatic buffer swapping regardless of whether
        /// <see cref="ShouldSwapAutomatically" /> is true or not.
        /// </summary>
        /// <remarks>
        /// This is useful for scenarios where you are temporarily moving the OpenGL context to a separate thread to
        /// load resources in the background, for instance. You can toggle this on and off as many times as you want
        /// throughout the window/view's lifetime.
        /// </remarks>
        bool IsContextControlDisabled { get; set; }

        /// <summary>
        /// The size of the window in pixels.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This will be replaced with an integer vector once System.Numerics supports them.
        /// </para>
        /// </remarks>
        Vector2D<int> Size { get; }

        /// <summary>
        /// The number of rendering operations to run every second.
        /// </summary>
        double FramesPerSecond { get; set; }

        /// <summary>
        /// The number of update operations to run every second.
        /// </summary>
        double UpdatesPerSecond { get; set; }

        /// <summary>
        /// The graphics API to use, and associated configurations.
        /// </summary>
        GraphicsAPI API { get; }

        /// <summary>
        /// Whether or not VSync is enabled for this view.
        /// </summary>
        bool VSync { get; set; }

        /// <summary>
        /// The video mode.
        /// </summary>
        VideoMode VideoMode { get; }

        /// <summary>
        /// Preferred depth buffer bits of the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>-1</c> to always use the system/backend default. Uses <c>24</c> as the default if <c>null</c> and
        /// <see cref="PreferredStencilBufferBits"/> is also <c>null</c>
        /// </remarks>
        int? PreferredDepthBufferBits { get; }

        /// <summary>
        /// Preferred stencil buffer bits of the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>-1</c> to always use the system/backend default. Uses <c>8</c> as the default if <c>null</c> and
        /// <see cref="PreferredDepthBufferBits"/> is also <c>null</c>
        /// </remarks>
        int? PreferredStencilBufferBits { get; }

        /// <summary>
        /// Preferred red, green, blue, and alpha bits of the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>null</c> or <c>-1</c> for any of the axes to use the system default. 
        /// </remarks>
        Vector4D<int>? PreferredBitDepth { get; }

        /// <summary>
        /// The number of samples per pixel to use for multisampling on the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>null</c> or <c>-1</c> to use the system default.
        /// </remarks>
        int? Samples { get; }
    }
}
