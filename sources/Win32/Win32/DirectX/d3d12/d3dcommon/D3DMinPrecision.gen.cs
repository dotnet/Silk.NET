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

/// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION"]/*'/>
public enum D3DMinPrecision
{
    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_DEFAULT"]/*'/>

    Default = 0,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_FLOAT_16"]/*'/>

    Float16 = 1,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_FLOAT_2_8"]/*'/>

    Float2X8 = 2,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_RESERVED"]/*'/>

    Reserved = 3,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_SINT_16"]/*'/>

    Sint16 = 4,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_UINT_16"]/*'/>

    Uint16 = 5,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_ANY_16"]/*'/>

    Any16 = 0xf0,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_ANY_10"]/*'/>

    Any10 = 0xf1,
}
