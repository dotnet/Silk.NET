// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE"]/*'/>
public enum D3DDriverType
{
    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_UNKNOWN"]/*'/>

    Unknown = 0,

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE"]/*'/>

    Hardware = (Unknown + 1),

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_REFERENCE"]/*'/>

    Reference = (Hardware + 1),

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_NULL"]/*'/>

    Null = (Reference + 1),

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_SOFTWARE"]/*'/>

    Software = (Null + 1),

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_WARP"]/*'/>

    Warp = (Software + 1),
}
