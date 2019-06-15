//
// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Context related attributes.
    /// </summary>
    /// <seealso cref="IGLFW.WindowHint(WindowHintInt,int)"/>
    public enum WindowHintInt
    {
        /// <summary>
        /// Indicate the client API version(major part) of the window's context.
        /// </summary>
        ContextVersionMajor = 0x00022002,

        /// <summary>
        /// Indicate the client API version(minor part) of the window's context.
        /// </summary>
        ContextVersionMinor = 0x00022003,

        /// <summary>
        /// Indicate the client API version(revision part) of the window's context.
        /// </summary>
        ContextRevision = 0x00022004,

        /// <summary>
        /// Specify the desired bit depths of the red component of the default framebuffer.
        /// <see cref="GLFW.DontCare"/> means the application has no preference.
        /// </summary>
        RedBits = 0x00021001,

        /// <summary>
        /// Specify the desired bit depths of the green component of the default framebuffer.
        /// <see cref="GLFW.DontCare"/> means the application has no preference.
        /// </summary>
        GreenBits = 0x00021002,

        /// <summary>
        /// Specify the desired bit depths of the blue component of the default framebuffer.
        /// <see cref="GLFW.DontCare"/> means the application has no preference.
        /// </summary>
        BlueBits = 0x00021003,

        /// <summary>
        /// Specify the desired bit depths of the alpha component of the default framebuffer.
        /// <see cref="GLFW.DontCare"/> means the application has no preference.
        /// </summary>
        AlphaBits = 0x00021004,

        /// <summary>
        /// Specify the desired bit depths of the depth component of the default framebuffer.
        /// <see cref="GLFW.DontCare"/> means the application has no preference.
        /// </summary>
        DepthBits = 0x00021005,

        /// <summary>
        /// Specify the desired bit depths of the stencil component of the default framebuffer.
        /// <see cref="GLFW.DontCare"/> means the application has no preference.
        /// </summary>
        StencilBits = 0x00021006,

        /// <summary>
        /// Specify the desired bit depths of the red component of the accumulation buffer.
        /// <see cref="GLFW.DontCare"/> means the application has no preference.
        /// </summary>
        /// <remarks>Accumulation buffers are a legacy OpenGL feature and should not be used in new code.</remarks>
        AccumRedBits = 0x00021007,

        /// <summary>
        /// Specify the desired bit depths of the green component of the accumulation buffer.
        /// <see cref="GLFW.DontCare"/> means the application has no preference.
        /// </summary>
        /// <remarks>Accumulation buffers are a legacy OpenGL feature and should not be used in new code.</remarks>
        AccumGreenBits = 0x00021008,

        /// <summary>
        /// Specify the desired bit depths of the blue component of the accumulation buffer.
        /// <see cref="GLFW.DontCare"/> means the application has no preference.
        /// </summary>
        /// <remarks>Accumulation buffers are a legacy OpenGL feature and should not be used in new code.</remarks>
        AccumBlueBits = 0x00021009,

        /// <summary>
        /// Specify the desired bit depths of the alpha component of the accumulation buffer.
        /// <see cref="GLFW.DontCare"/> means the application has no preference.
        /// </summary>
        /// <remarks>Accumulation buffers are a legacy OpenGL feature and should not be used in new code.</remarks>
        AccumAlphaBits = 0x0002100A,

        /// <summary>
        /// Specifies the desired number of auxiliary buffers.
        /// <see cref="GLFW.DontCare"/> means the application has no preference.
        /// </summary>
        /// <remarks>Auxiliary buffers are a legacy OpenGL feature and should not be used in new code.</remarks>
        AuxBuffers = 0x0002100B,

        /// <summary>
        /// Specifies the desired number of samples to use for multisampling. Zero disables multisampling.
        /// <see cref="GLFW.DontCare"/> means the application has no preference.
        /// </summary>
        Samples = 0x0002100D,

        /// <summary>
        /// Specifies the desired refresh rate for full screen windows.
        /// If set to <see cref="GLFW.DontCare"/>,
        /// the highest available refresh rate will be used. This hint is ignored for windowed mode windows.
        /// </summary>
        RefreshRate = 0x0002100F,
    }
}
