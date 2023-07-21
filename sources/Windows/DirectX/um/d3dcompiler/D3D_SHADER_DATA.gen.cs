// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D_SHADER_DATA.xml' path='doc/member[@name="D3D_SHADER_DATA"]/*' />
public unsafe partial struct D3D_SHADER_DATA
{
    /// <include file='D3D_SHADER_DATA.xml' path='doc/member[@name="D3D_SHADER_DATA.pBytecode"]/*' />
    [NativeTypeName("LPCVOID")]
    public void* pBytecode;

    /// <include file='D3D_SHADER_DATA.xml' path='doc/member[@name="D3D_SHADER_DATA.BytecodeLength"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint BytecodeLength;
}
