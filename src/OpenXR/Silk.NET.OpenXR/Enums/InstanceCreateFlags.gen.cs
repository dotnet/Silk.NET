// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrInstanceCreateFlags")]
    public enum InstanceCreateFlags : long
    {
        [NativeName("Name", "")]
        None = 0,
    }
}