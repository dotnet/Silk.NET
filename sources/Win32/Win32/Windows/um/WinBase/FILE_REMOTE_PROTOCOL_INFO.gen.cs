// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FILE_REMOTE_PROTOCOL_INFO
{
    public ushort StructureVersion;
    public ushort StructureSize;

    [NativeTypeName("ULONG")]
    public uint Protocol;
    public ushort ProtocolMajorVersion;
    public ushort ProtocolMinorVersion;
    public ushort ProtocolRevision;
    public ushort Reserved;

    [NativeTypeName("ULONG")]
    public uint Flags;

    [NativeTypeName("__AnonymousRecord_winbase_L9340_C5")]
    public _GenericReserved_e__Struct GenericReserved;

    [NativeTypeName("__AnonymousRecord_winbase_L9353_C5")]
    public _ProtocolSpecific_e__Union ProtocolSpecific;

    public partial struct _GenericReserved_e__Struct
    {
        [NativeTypeName("ULONG[8]")]
        public _Reserved_e__FixedBuffer Reserved;

        [InlineArray(8)]
        public partial struct _Reserved_e__FixedBuffer
        {
            public uint e0;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _ProtocolSpecific_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winbase_L9355_C9")]
        public _Smb2_e__Struct Smb2;

        [FieldOffset(0)]
        [NativeTypeName("ULONG[16]")]
        public _Reserved_e__FixedBuffer Reserved;

        public partial struct _Smb2_e__Struct
        {
            [NativeTypeName("__AnonymousRecord_winbase_L9357_C13")]
            public _Server_e__Struct Server;

            [NativeTypeName("__AnonymousRecord_winbase_L9361_C13")]
            public _Share_e__Struct Share;

            public partial struct _Server_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Capabilities;
            }

            public partial struct _Share_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Capabilities;

                [NativeTypeName("ULONG")]
                public uint ShareFlags;
            }
        }

        [InlineArray(16)]
        public partial struct _Reserved_e__FixedBuffer
        {
            public uint e0;
        }
    }
}
