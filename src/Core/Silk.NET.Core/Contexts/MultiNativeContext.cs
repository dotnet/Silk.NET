// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable
using System;
using System.Linq;

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
            foreach (var nativeContext in Contexts)
            {
                var ret = nativeContext?.GetProcAddress(proc, slot) ?? default;
                if (ret != default)
                {
                    return ret;
                }
            }

            return default;
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
