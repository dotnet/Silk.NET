// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Explicit)]
public partial struct DML_SCALAR_UNION
{
    [FieldOffset(0)]
    [NativeTypeName("BYTE[8]")]
    public _Bytes_e__FixedBuffer Bytes;

    [FieldOffset(0)]
    [NativeTypeName("INT8")]
    public sbyte Int8;

    [FieldOffset(0)]
    [NativeTypeName("UINT8")]
    public byte UInt8;

    [FieldOffset(0)]
    [NativeTypeName("INT16")]
    public short Int16;

    [FieldOffset(0)]
    [NativeTypeName("UINT16")]
    public ushort UInt16;

    [FieldOffset(0)]
    [NativeTypeName("INT32")]
    public int Int32;

    [FieldOffset(0)]
    [NativeTypeName("UINT32")]
    public uint UInt32;

    [FieldOffset(0)]
    [NativeTypeName("INT64")]
    public long Int64;

    [FieldOffset(0)]
    [NativeTypeName("UINT64")]
    public ulong UInt64;

    [FieldOffset(0)]
    public float Float32;

    [FieldOffset(0)]
    public double Float64;

    [InlineArray(8)]
    public partial struct _Bytes_e__FixedBuffer
    {
        public byte e0;
    }
}
