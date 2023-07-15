// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
/// <include file='DML_SCALAR_UNION.xml' path='doc/member[@name="DML_SCALAR_UNION"]/*'/>
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct DML_SCALAR_UNION
{
    /// <include file='DML_SCALAR_UNION.xml' path='doc/member[@name="DML_SCALAR_UNION.Bytes"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("BYTE[8]")]
    public fixed byte Bytes[8];
    /// <include file='DML_SCALAR_UNION.xml' path='doc/member[@name="DML_SCALAR_UNION.Int8"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("INT8")]
    public sbyte Int8;
    /// <include file='DML_SCALAR_UNION.xml' path='doc/member[@name="DML_SCALAR_UNION.UInt8"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("UINT8")]
    public byte UInt8;
    /// <include file='DML_SCALAR_UNION.xml' path='doc/member[@name="DML_SCALAR_UNION.Int16"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("INT16")]
    public short Int16;
    /// <include file='DML_SCALAR_UNION.xml' path='doc/member[@name="DML_SCALAR_UNION.UInt16"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("UINT16")]
    public ushort UInt16;
    /// <include file='DML_SCALAR_UNION.xml' path='doc/member[@name="DML_SCALAR_UNION.Int32"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("INT32")]
    public int Int32;
    /// <include file='DML_SCALAR_UNION.xml' path='doc/member[@name="DML_SCALAR_UNION.UInt32"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("UINT32")]
    public uint UInt32;
    /// <include file='DML_SCALAR_UNION.xml' path='doc/member[@name="DML_SCALAR_UNION.Int64"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("INT64")]
    public long Int64;
    /// <include file='DML_SCALAR_UNION.xml' path='doc/member[@name="DML_SCALAR_UNION.UInt64"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("UINT64")]
    public ulong UInt64;
    /// <include file='DML_SCALAR_UNION.xml' path='doc/member[@name="DML_SCALAR_UNION.Float32"]/*'/>
    [FieldOffset(0)]
    public float Float32;
    /// <include file='DML_SCALAR_UNION.xml' path='doc/member[@name="DML_SCALAR_UNION.Float64"]/*'/>
    [FieldOffset(0)]
    public double Float64;
}