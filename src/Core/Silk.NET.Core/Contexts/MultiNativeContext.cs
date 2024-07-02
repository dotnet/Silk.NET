// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable
using System;
using System.Linq;
using Silk.NET.Core.Loader;

namespace Silk.NET.Core.Contexts
{
    /// <summary>
    /// A <see cref="INativeContext"/> implementation which uses multiple children <see cref="INativeContext"/>s for
    /// sourcing its function pointers.
    /// </summary>
    public class MultiNativeContext : INativeContext
    {
        /// <summary>
        /// The child contexts.
        /// </summary>
        public INativeContext?[] Contexts { get; set; }

        /// <summary>
        /// Creates a <see cref="MultiNativeContext"/> from the given child contexts.
        /// </summary>
        /// <param name="contexts">The children to use.</param>
        public MultiNativeContext(params INativeContext?[] contexts)
        {
            Contexts = contexts;
        }

        /// <inheritdoc />
        public nint GetProcAddress(string proc, int? slot = default)
        {
            if (!TryGetProcAddress(proc, out var ret, slot))
            {
                static void Throw(string fn) => throw new SymbolLoadingException(fn);
                Throw(proc);
            }

            return ret;
        }

        /// <inheritdoc />
        public bool TryGetProcAddress(string proc, out nint addr, int? slot = default)
        {
            addr = 0;
            foreach (var nativeContext in Contexts)
            {
                if (nativeContext?.TryGetProcAddress(proc, out addr, slot) ?? false)
                {
                    return true;
                }
            }

            addr = default;
            return false;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            foreach (var context in Contexts)
            {
                context?.Dispose();
            }
        }
    }
}
