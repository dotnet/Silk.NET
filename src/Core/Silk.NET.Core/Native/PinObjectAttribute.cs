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

        public PinMode Mode { get; }
    }
}
