// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core.Native
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    public class PinObjectAttribute : Attribute
    {
        public PinObjectAttribute(PinMode mode = PinMode.Persist)
        {
            Mode = mode;
        }
        
        // This is a separate constructor so we can always assume that the second argument is this discriminants.
        public PinObjectAttribute(PinMode mode, string[] discriminants)
        {
            Mode = mode;
            Discriminants = discriminants;
        }

        public PinMode Mode { get; }
        public string[] Discriminants { get; } = Array.Empty<string>();
    }
}
