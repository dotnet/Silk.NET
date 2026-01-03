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

/// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS"]/*'/>
[Flags]
public enum D3DShaderVariableFlags
{
    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D_SVF_USERPACKED"]/*'/>

    DSvfUserpacked = 1,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D_SVF_USED"]/*'/>

    DSvfUsed = 2,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D_SVF_INTERFACE_POINTER"]/*'/>

    DSvfInterfacePointer = 4,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D_SVF_INTERFACE_PARAMETER"]/*'/>

    DSvfInterfaceParameter = 8,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D10_SVF_USERPACKED"]/*'/>

    D10SvfUserpacked = DSvfUserpacked,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D10_SVF_USED"]/*'/>

    D10SvfUsed = DSvfUsed,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D11_SVF_INTERFACE_POINTER"]/*'/>

    D11SvfInterfacePointer = DSvfInterfacePointer,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D11_SVF_INTERFACE_PARAMETER"]/*'/>

    D11SvfInterfaceParameter = DSvfInterfaceParameter,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D_SVF_FORCE_DWORD"]/*'/>

    DSvfForceDword = 0x7fffffff,
}
