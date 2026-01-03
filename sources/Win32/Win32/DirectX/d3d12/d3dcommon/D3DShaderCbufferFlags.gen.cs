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

/// <include file='D3D_SHADER_CBUFFER_FLAGS.xml' path='doc/member[@name="D3D_SHADER_CBUFFER_FLAGS"]/*'/>
[Flags]
public enum D3DShaderCbufferFlags
{
    /// <include file='D3D_SHADER_CBUFFER_FLAGS.xml' path='doc/member[@name="D3D_SHADER_CBUFFER_FLAGS.D3D_CBF_USERPACKED"]/*'/>

    DCbfUserpacked = 1,

    /// <include file='D3D_SHADER_CBUFFER_FLAGS.xml' path='doc/member[@name="D3D_SHADER_CBUFFER_FLAGS.D3D10_CBF_USERPACKED"]/*'/>

    D10CbfUserpacked = DCbfUserpacked,

    /// <include file='D3D_SHADER_CBUFFER_FLAGS.xml' path='doc/member[@name="D3D_SHADER_CBUFFER_FLAGS.D3D_CBF_FORCE_DWORD"]/*'/>

    DCbfForceDword = 0x7fffffff,
}
