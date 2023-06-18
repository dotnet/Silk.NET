// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Microsoft.Extensions.DependencyModel;
using Silk.NET.Core;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Maths;

namespace Silk.NET.OpenGL
{
    public partial class GL
    {
        /// <summary>
        ///     Creates a <see cref="GL" /> instance from an <see cref="IGLContextSource" />.
        /// </summary>
        /// <param name="contextSource">
        /// <see cref="IGLContextSource" /> to create <see cref="GL" /> from.
        /// </param>
        /// <returns>
        ///     A <see cref="GL" /> instance.
        /// </returns>
        public static GL GetApi(IGLContextSource contextSource) => GetApi
        (
             contextSource.GLContext ??
             throw new InvalidOperationException("The given IGLContextSource is not configured with a context.")
        );

        /// <summary>
        ///     Creates a <see cref="GL" /> instance from an <see cref="IGLContext" />.
        /// </summary>
        /// <param name="ctx">
        ///     <see cref="IGLContext" /> to create <see cref="GL" /> from.
        /// </param>
        /// <returns>
        ///     A <see cref="GL" /> instance.
        /// </returns>
        public static GL GetApi(IGLContext ctx) => GetApi((INativeContext) ctx);

        /// <summary>
        ///     Creates a <see cref="GL" /> instance using a function that returns a native OpenGL context.
        /// </summary>
        /// <param name="getProcAddress">
        /// <para>
        ///     Function returning a native OpenGL context.
        /// </para>
        /// <para>
        ///     The <c>string</c> parameter of the <paramref name="getProcAddress" /> function should be the name
        ///     of the native function with needs to be called.
        /// </para>
        /// </param>
        /// <returns>
        ///     A <see cref="GL" /> instance.
        /// </returns>
        public static GL GetApi(Func<string, nint> getProcAddress) => GetApi(new LamdaNativeContext(getProcAddress));

        /// <summary>
        ///     Creates a <see cref="GL" /> instance from an <see cref="INativeContext" />.
        /// </summary>
        /// <param name="ctx">
        ///     <see cref="INativeContext" /> to create <see cref="GL" /> from.
        /// </param>
        /// <returns>
        ///     A <see cref="GL" /> instance.
        /// </returns>
        public static GL GetApi(INativeContext ctx) => new GL(ctx);

        /// <summary>
        ///     Attempts to load a native OpenGL extension of type <typeparamref name="T" />.
        /// </summary>
        /// <param name="ext">
        ///     The loaded extension.
        /// </param>
        /// <typeparam name="T">
        ///     Type of <see cref="NativeExtension{T}" /> to load.
        /// </typeparam>
        /// <returns>
        ///     <c>True</c> if the extension was loaded, otherwise <c>False</c>.
        /// </returns>
        public bool TryGetExtension<T>(out T ext)
            where T : NativeExtension<GL>
        {
            ext = IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T)Activator.CreateInstance(typeof(T), Context)
                : null;
            return ext != null;
        }

        private List<string> _extensions;

        /// <summary>
        ///     Determines whether a particular OpenGL extension is present on the machine's driver.
        /// </summary>
        /// <param name="extension">
        ///     Standard identifier for the extension.
        /// </param>
        /// <returns>
        ///     <c>True</c> if the extension is present, otherwise <c>False</c>.
        /// </returns>
        public override unsafe bool IsExtensionPresent(string extension)
        {
            int numExtensions;
            GetInteger(GLEnum.NumExtensions, &numExtensions);
            _extensions ??= Enumerable.Range(0, numExtensions)
                .Select(x => SilkMarshal.PtrToString((nint) GetString(GLEnum.Extensions, (uint) x)))
                .ToList();

            return _extensions.Contains("GL_" + (extension.StartsWith("GL_") ? extension.Substring(3) : extension));
        }
    }
}
