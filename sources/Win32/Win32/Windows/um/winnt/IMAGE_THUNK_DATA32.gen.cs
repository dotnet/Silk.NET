// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_THUNK_DATA32
{
    [NativeTypeName("__AnonymousRecord_winnt_L20512_C5")]
    public _u1_e__Union u1;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _u1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint ForwarderString;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Function;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Ordinal;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint AddressOfData;
    }
}
