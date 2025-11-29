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

/// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS"]/*'/>
[Flags]
public enum D3DParameterFlags
{
    /// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS.D3D_PF_NONE"]/*'/>

    None = 0,

    /// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS.D3D_PF_IN"]/*'/>

    In = 0x1,

    /// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS.D3D_PF_OUT"]/*'/>

    Out = 0x2,

    /// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS.D3D_PF_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
