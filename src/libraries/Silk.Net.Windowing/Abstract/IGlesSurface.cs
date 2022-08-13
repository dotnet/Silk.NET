// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Windowing
{
    /// <summary>
    /// Defines a surface that can have a GLES context attatched
    /// </summary>
    public interface IGlesSurface : INativeGLSurface
    {
        /// <summary>
        /// The surface representing the context to use.
        /// </summary>
        IGlesSurface? SharedContext { get; set; } // Donovan/Redhacker1: How on earth is this supposed to work?
        /// <summary>
        /// Enables OpenGLES support for this surface. This will create a surface upon initialization.
        /// </summary>
        bool TryEnableOpenGLES();
    }
}
