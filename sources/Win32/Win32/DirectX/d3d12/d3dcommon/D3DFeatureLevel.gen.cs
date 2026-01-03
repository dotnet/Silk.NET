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

/// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL"]/*'/>
public enum D3DFeatureLevel
{
    /// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_1_0_GENERIC"]/*'/>

    Level1X0Generic = 0x100,

    /// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_1_0_CORE"]/*'/>

    Level1X0Core = 0x1000,

    /// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_1"]/*'/>

    Level9X1 = 0x9100,

    /// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_2"]/*'/>

    Level9X2 = 0x9200,

    /// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_3"]/*'/>

    Level9X3 = 0x9300,

    /// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_0"]/*'/>

    Level10X0 = 0xa000,

    /// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_1"]/*'/>

    Level10X1 = 0xa100,

    /// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0"]/*'/>

    Level11X0 = 0xb000,

    /// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_1"]/*'/>

    Level11X1 = 0xb100,

    /// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_12_0"]/*'/>

    Level12X0 = 0xc000,

    /// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_12_1"]/*'/>

    Level12X1 = 0xc100,

    /// <include file='D3D_FEATURE_LEVEL.xml' path='doc/member[@name="D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_12_2"]/*'/>

    Level12X2 = 0xc200,
}
