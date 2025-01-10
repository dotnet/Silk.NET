// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_POLICY_ENTRY
{
    public IMAGE_POLICY_ENTRY_TYPE Type;
    public IMAGE_POLICY_ID PolicyId;

    [NativeTypeName("__AnonymousRecord_winnt_L23683_C5")]
    public _u_e__Union u;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _u_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("const void *")]
        public void* None;

        [FieldOffset(0)]
        [NativeTypeName("BOOLEAN")]
        public byte BoolValue;

        [FieldOffset(0)]
        [NativeTypeName("INT8")]
        public sbyte Int8Value;

        [FieldOffset(0)]
        [NativeTypeName("UINT8")]
        public byte UInt8Value;

        [FieldOffset(0)]
        [NativeTypeName("INT16")]
        public short Int16Value;

        [FieldOffset(0)]
        [NativeTypeName("UINT16")]
        public ushort UInt16Value;

        [FieldOffset(0)]
        [NativeTypeName("INT32")]
        public int Int32Value;

        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint UInt32Value;

        [FieldOffset(0)]
        [NativeTypeName("INT64")]
        public long Int64Value;

        [FieldOffset(0)]
        [NativeTypeName("UINT64")]
        public ulong UInt64Value;

        [FieldOffset(0)]
        [NativeTypeName("PCSTR")]
        public sbyte* AnsiStringValue;

        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* UnicodeStringValue;
    }
}
