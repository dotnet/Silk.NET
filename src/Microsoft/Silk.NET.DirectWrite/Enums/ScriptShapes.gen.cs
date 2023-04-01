// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_SCRIPT_SHAPES")]
    public enum ScriptShapes : int
    {
        [NativeName("Name", "DWRITE_SCRIPT_SHAPES_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "DWRITE_SCRIPT_SHAPES_NO_VISUAL")]
        NoVisual = 0x1,
    }
}
