// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

namespace Silk.NET.DirectX;

/// <include file='DxcShaderHash.xml' path='doc/member[@name="DxcShaderHash"]/*' />
public unsafe partial struct DxcShaderHash
{
    /// <include file='DxcShaderHash.xml' path='doc/member[@name="DxcShaderHash.Flags"]/*' />
    [NativeTypeName("UINT32")]
    public uint Flags;

    /// <include file='DxcShaderHash.xml' path='doc/member[@name="DxcShaderHash.HashDigest"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte HashDigest[16];
}
