// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct REASON_CONTEXT
{
    [NativeTypeName("ULONG")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("__AnonymousRecord_minwinbase_L276_C5")]
    public _Reason_e__Union Reason;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Reason_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minwinbase_L277_C9")]
        public _Detailed_e__Struct Detailed;

        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* SimpleReasonString;

        public unsafe partial struct _Detailed_e__Struct
        {
            public HMODULE LocalizedReasonModule;

            [NativeTypeName("ULONG")]
            public uint LocalizedReasonId;

            [NativeTypeName("ULONG")]
            public uint ReasonStringCount;

            [NativeTypeName("LPWSTR *")]
            public ushort** ReasonStrings;
        }
    }
}
