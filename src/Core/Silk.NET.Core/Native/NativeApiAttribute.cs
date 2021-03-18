// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public class NativeApiAttribute : Attribute
    {
        private CallingConvention? _actualConvention;
        
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
        public CallingConvention Convention
        {
            get => _actualConvention ?? CallingConvention.Cdecl;
            set => _actualConvention = value;
        }

        public static string GetEntryPoint(NativeApiAttribute attr, NativeApiAttribute parent, string method)
        {
            return (string.IsNullOrEmpty(attr?.Prefix) ? parent?.Prefix : attr.Prefix) +
                   (string.IsNullOrEmpty(attr?.EntryPoint) ? method : attr.EntryPoint);
        }

        public static CallingConvention GetCallingConvention(NativeApiAttribute attr, NativeApiAttribute parent)
        {
            return attr?._actualConvention ?? parent?._actualConvention ?? CallingConvention.Cdecl;
        }
    }
}
