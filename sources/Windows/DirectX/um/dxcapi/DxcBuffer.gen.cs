// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
namespace Silk.NET.DirectX;
/// <include file='DxcBuffer.xml' path='doc/member[@name="DxcBuffer"]/*'/>
public unsafe partial struct DxcBuffer
{
    /// <include file='DxcBuffer.xml' path='doc/member[@name="DxcBuffer.Ptr"]/*'/>
    [NativeTypeName("LPCVOID")]
    public void* Ptr;
    /// <include file='DxcBuffer.xml' path='doc/member[@name="DxcBuffer.Size"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint Size;
    /// <include file='DxcBuffer.xml' path='doc/member[@name="DxcBuffer.Encoding"]/*'/>
    public uint Encoding;
}