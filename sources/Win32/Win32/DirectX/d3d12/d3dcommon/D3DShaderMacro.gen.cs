// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_SHADER_MACRO.xml' path='doc/member[@name="D3D_SHADER_MACRO"]/*'/>
public unsafe partial struct D3DShaderMacro
{
    /// <include file='D3D_SHADER_MACRO.xml' path='doc/member[@name="D3D_SHADER_MACRO.Name"]/*'/>

    [NativeTypeName("LPCSTR")]
    public sbyte* Name;

    /// <include file='D3D_SHADER_MACRO.xml' path='doc/member[@name="D3D_SHADER_MACRO.Definition"]/*'/>

    [NativeTypeName("LPCSTR")]
    public sbyte* Definition;
}
