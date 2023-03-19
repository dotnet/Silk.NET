// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_MODE_ROTATION")]
    public enum ModeRotation : int
    {
        [Obsolete("Deprecated in favour of \"Unspecified\"")]
        [NativeName("Name", "DXGI_MODE_ROTATION_UNSPECIFIED")]
        ModeRotationUnspecified = 0x0,
        [Obsolete("Deprecated in favour of \"Identity\"")]
        [NativeName("Name", "DXGI_MODE_ROTATION_IDENTITY")]
        ModeRotationIdentity = 0x1,
        [Obsolete("Deprecated in favour of \"Rotate90\"")]
        [NativeName("Name", "DXGI_MODE_ROTATION_ROTATE90")]
        ModeRotationRotate90 = 0x2,
        [Obsolete("Deprecated in favour of \"Rotate180\"")]
        [NativeName("Name", "DXGI_MODE_ROTATION_ROTATE180")]
        ModeRotationRotate180 = 0x3,
        [Obsolete("Deprecated in favour of \"Rotate270\"")]
        [NativeName("Name", "DXGI_MODE_ROTATION_ROTATE270")]
        ModeRotationRotate270 = 0x4,
        [NativeName("Name", "DXGI_MODE_ROTATION_UNSPECIFIED")]
        Unspecified = 0x0,
        [NativeName("Name", "DXGI_MODE_ROTATION_IDENTITY")]
        Identity = 0x1,
        [NativeName("Name", "DXGI_MODE_ROTATION_ROTATE90")]
        Rotate90 = 0x2,
        [NativeName("Name", "DXGI_MODE_ROTATION_ROTATE180")]
        Rotate180 = 0x3,
        [NativeName("Name", "DXGI_MODE_ROTATION_ROTATE270")]
        Rotate270 = 0x4,
    }
}
