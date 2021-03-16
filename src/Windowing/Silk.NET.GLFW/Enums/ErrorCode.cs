// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Error codes, used in the error callback.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// Everything is running as intended. Yay!
        /// </summary>
        NoError = 0,

        /// <summary>
        /// Called a function before calling <see cref="IGlfw.Init" />. Initialize GLFW and then try again.
        /// </summary>
        NotInitialized = 0x00010001,

        /// <summary>
        /// No OpenGL/OpenGL ES context on this thread.
        /// </summary>
        NoContext = 0x00010002,

        /// <summary>
        /// Used an invalid enum value on a function.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This should hopefully never happen in the bindings, due to the added type safety of C# enums VS. GLFW's native #defines
        /// </para>
        /// </remarks>
        InvalidEnum = 0x00010003,

        /// <summary>
        /// Called a function with an invalid argument.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This can happen if you request an OpenGL version that doesn't exist, like 2.7.
        /// </para>
        /// <para>
        /// If you request a version of OpenGL that exists, but isn't supported by this graphics card, it will return
        /// VersionUnavailable instead.
        /// </para>
        /// </remarks>
        InvalidValue = 0x00010004,

        /// <summary>
        /// A memory allocation failed on GLFW's end.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Report this to the GLFW issue tracker if encountered.
        /// </para>
        /// </remarks>
        OutOfMemory = 0x00010005,

        /// <summary>
        /// The requested API is not available on the system.
        /// </summary>
        ApiUnavailable = 0x00010006,

        /// <summary>
        /// The requested OpenGL version is not available on the system.
        /// </summary>
        VersionUnavailable = 0x00010007,

        /// <summary>
        /// A platform-specific error occurred that doesn't fit into any more specific category.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Report this to the GLFW issue tracker if encountered.
        /// </para>
        /// </remarks>
        PlatformError = 0x00010008,

        /// <summary>
        /// The requested format is unavailable.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If emitted during window creation, the requested pixel format isn't available.
        /// </para>
        /// <para>
        /// If emitted when using the clipboard, the contents of the clipboard couldn't be converted to the requested format.
        /// </para>
        /// </remarks>
        FormatUnavailable = 0x00010009,

        /// <summary>
        /// There is no OpenGL/OpenGL ES context attached to this window.
        /// </summary>
        NoWindowContext = 0x0001000A
    }
}