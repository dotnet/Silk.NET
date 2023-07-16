// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DML_BUFFER_BINDING.xml' path='doc/member[@name="DML_BUFFER_BINDING"]/*'/>
public unsafe partial struct DML_BUFFER_BINDING
{
    /// <include file='DML_BUFFER_BINDING.xml' path='doc/member[@name="DML_BUFFER_BINDING.Buffer"]/*'/>
    public ID3D12Resource* Buffer;
    /// <include file='DML_BUFFER_BINDING.xml' path='doc/member[@name="DML_BUFFER_BINDING.Offset"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong Offset;
    /// <include file='DML_BUFFER_BINDING.xml' path='doc/member[@name="DML_BUFFER_BINDING.SizeInBytes"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong SizeInBytes;
}