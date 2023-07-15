// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC"]/*'/>
public unsafe partial struct DML_BUFFER_TENSOR_DESC
{
    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.DataType"]/*'/>
    public DML_TENSOR_DATA_TYPE DataType;
    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.Flags"]/*'/>
    public DML_TENSOR_FLAGS Flags;
    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.DimensionCount"]/*'/>
    public uint DimensionCount;
    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.Sizes"]/*'/>
    [NativeTypeName("const UINT *")]
    public uint* Sizes;
    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.Strides"]/*'/>
    [NativeTypeName("const UINT *")]
    public uint* Strides;
    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.TotalTensorSizeInBytes"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong TotalTensorSizeInBytes;
    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.GuaranteedBaseOffsetAlignment"]/*'/>
    public uint GuaranteedBaseOffsetAlignment;
}