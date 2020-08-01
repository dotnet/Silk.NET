// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public class NativeApiAttribute : Attribute
    {
        // ReSharper disable once EmptyConstructor
        public NativeApiAttribute()
        {
        }

        /// <summary>
        ///     Gets or sets the native entry point for this method. Ignored on classes and interfaces.
        /// </summary>
        public string EntryPoint { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the native entry point prefix for this method. If used on a method, this will override the
        ///     prefix set in a class or interface declaration. Otherwise, this will be inherited from the class or
        ///     interface.
        /// </summary>
        public string Prefix { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the calling convention.
        /// </summary>
        public CallingConvention? Convention { get; set; } = null;

        public static string GetEntryPoint(NativeApiAttribute attr, NativeApiAttribute parent, string method)
        {
            return (string.IsNullOrEmpty(attr?.Prefix) ? parent?.Prefix : attr.Prefix) +
                   (string.IsNullOrEmpty(attr?.EntryPoint) ? method : attr.EntryPoint);
        }

        public static CallingConvention GetCallingConvention(NativeApiAttribute attr, NativeApiAttribute parent)
        {
            return attr?.Convention ?? parent?.Convention ?? CallingConvention.Cdecl;
        }
    }
}
