// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Windowing
{
    /// <summary>
    /// A surface that can have a desktop GL context.
    /// </summary>
    public interface IGLSurface : INativeGLSurface
    {
        /// <summary>
        /// The flags the context was created with
        /// </summary>
        ContextFlags ContextFlags { get; set; }
        /// <summary>
        /// The profile of the specified context.
        /// </summary>
        ContextProfile ContextProfile { get; set; }
        /// <summary>
        /// The surface representing the context to use.
        /// </summary>
        IGLSurface? SharedContext { get; set; } // Redhacker1/Donovan: DAFUQ? What exactly is supposed to be going on here

        /// <summary>
        /// Enables OpenGL support for this surface. This will create a surface upon initialization.
        /// </summary>
        bool TryEnableOpenGL();
    }
}
