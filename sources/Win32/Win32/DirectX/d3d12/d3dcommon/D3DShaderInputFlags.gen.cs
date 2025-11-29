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

/// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS"]/*'/>
[Flags]
public enum D3DShaderInputFlags
{
    /// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS.D3D_SIF_USERPACKED"]/*'/>

    DSifUserpacked = 0x1,

    /// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS.D3D_SIF_COMPARISON_SAMPLER"]/*'/>

    DSifComparisonSampler = 0x2,

    /// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS.D3D_SIF_TEXTURE_COMPONENT_0"]/*'/>

    DSifTextureComponent0 = 0x4,

    /// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS.D3D_SIF_TEXTURE_COMPONENT_1"]/*'/>

    DSifTextureComponent1 = 0x8,

    /// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS.D3D_SIF_TEXTURE_COMPONENTS"]/*'/>

    DSifTextureComponents = 0xc,

    /// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS.D3D_SIF_UNUSED"]/*'/>

    DSifUnused = 0x10,

    /// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS.D3D10_SIF_USERPACKED"]/*'/>

    D10SifUserpacked = DSifUserpacked,

    /// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS.D3D10_SIF_COMPARISON_SAMPLER"]/*'/>

    D10SifComparisonSampler = DSifComparisonSampler,

    /// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS.D3D10_SIF_TEXTURE_COMPONENT_0"]/*'/>

    D10SifTextureComponent0 = DSifTextureComponent0,

    /// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS.D3D10_SIF_TEXTURE_COMPONENT_1"]/*'/>

    D10SifTextureComponent1 = DSifTextureComponent1,

    /// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS.D3D10_SIF_TEXTURE_COMPONENTS"]/*'/>

    D10SifTextureComponents = DSifTextureComponents,

    /// <include file='D3D_SHADER_INPUT_FLAGS.xml' path='doc/member[@name="D3D_SHADER_INPUT_FLAGS.D3D_SIF_FORCE_DWORD"]/*'/>

    DSifForceDword = 0x7fffffff,
}
