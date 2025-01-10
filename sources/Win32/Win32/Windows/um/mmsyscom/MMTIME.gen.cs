// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MMTIME
{
    public uint wType;

    [NativeTypeName("__AnonymousRecord_mmsyscom_L110_C5")]
    public _u_e__Union u;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _u_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint ms;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint sample;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cb;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint ticks;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_mmsyscom_L118_C9")]
        public _smpte_e__Struct smpte;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_mmsyscom_L132_C9")]
        public _midi_e__Struct midi;

        public partial struct _smpte_e__Struct
        {
            public byte hour;
            public byte min;
            public byte sec;
            public byte frame;
            public byte fps;
            public byte dummy;

            [NativeTypeName("BYTE[2]")]
            public _pad_e__FixedBuffer pad;

            [InlineArray(2)]
            public partial struct _pad_e__FixedBuffer
            {
                public byte e0;
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _midi_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint songptrpos;
        }
    }
}
