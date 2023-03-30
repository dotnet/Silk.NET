// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_OPACITYMETADATA_PROP")]
    public enum OpacitymetadataProp : int
    {
        [NativeName("Name", "D2D1_OPACITYMETADATA_PROP_INPUT_OPAQUE_RECT")]
        InputOpaqueRect = 0x0,
        [NativeName("Name", "D2D1_OPACITYMETADATA_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
