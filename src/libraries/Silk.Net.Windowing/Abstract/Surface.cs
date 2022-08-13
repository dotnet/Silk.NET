// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
namespace Silk.NET.Windowing
{
    /// <summary>
    /// A factory that creates and/or gets surfaces.
    /// </summary>
    public static class Surface
    {
        /// <summary>
        /// Whether the platform is supported by any backend of of Silk.Net.Windowing.
        /// <seealso cref="ISurface"/>
        /// </summary>
        public static bool IsPlatformSupported { get => throw new NotImplementedException(); }

        /// <summary>
        /// Gets a surface if a surface already exist, if it does then return said surface.
        /// </summary>
        /// <returns>an <see cref="ISurface"/> object.</returns>
        // Does this return null on IsPlatformSupported is false? Does it throw? Should it return a bool indicating whether it returned an existing surface or created a new one?
        public static ISurface GetOrCreate()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Creates an <see cref="ISurface"/> regardless as to whether one already exists
        /// </summary>
        /// <returns>an <see cref="ISurface"/> object.</returns>
        // Does this return null on IsPlatformSupported is false? Does it throw? Should it return a bool indicating whether it returned an existing surface or created a new one?
        public static ISurface CreateNew()        
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Clears the contexts of ALL <see cref="ISurface"/> objects. 
        /// </summary>
        public static void ClearCurrentContexts()
        {
            throw new NotImplementedException();
        }
    }
}
