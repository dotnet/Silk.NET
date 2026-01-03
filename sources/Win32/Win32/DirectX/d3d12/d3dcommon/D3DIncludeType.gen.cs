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

/// <include file='D3D_INCLUDE_TYPE.xml' path='doc/member[@name="D3D_INCLUDE_TYPE"]/*'/>
public enum D3DIncludeType
{
    /// <include file='D3D_INCLUDE_TYPE.xml' path='doc/member[@name="D3D_INCLUDE_TYPE.D3D_INCLUDE_LOCAL"]/*'/>

    DIncludeLocal = 0,

    /// <include file='D3D_INCLUDE_TYPE.xml' path='doc/member[@name="D3D_INCLUDE_TYPE.D3D_INCLUDE_SYSTEM"]/*'/>

    DIncludeSystem = (DIncludeLocal + 1),

    /// <include file='D3D_INCLUDE_TYPE.xml' path='doc/member[@name="D3D_INCLUDE_TYPE.D3D10_INCLUDE_LOCAL"]/*'/>

    D10IncludeLocal = DIncludeLocal,

    /// <include file='D3D_INCLUDE_TYPE.xml' path='doc/member[@name="D3D_INCLUDE_TYPE.D3D10_INCLUDE_SYSTEM"]/*'/>

    D10IncludeSystem = DIncludeSystem,

    /// <include file='D3D_INCLUDE_TYPE.xml' path='doc/member[@name="D3D_INCLUDE_TYPE.D3D_INCLUDE_FORCE_DWORD"]/*'/>

    DIncludeForceDword = 0x7fffffff,
}
