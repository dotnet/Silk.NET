// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STREAM_INFORMATION_ENTRY
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("union _StreamInformation")]
    public _StreamInformation StreamInformation;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _StreamInformation
    {
        [FieldOffset(0)]
        [NativeTypeName("struct _DesiredStorageClass")]
        public _DesiredStorageClass DesiredStorageClass;

        [FieldOffset(0)]
        [NativeTypeName("struct _DataStream")]
        public _DataStream DataStream;

        [FieldOffset(0)]
        [NativeTypeName("struct _Reparse")]
        public _Reparse Reparse;

        [FieldOffset(0)]
        [NativeTypeName("struct _Ea")]
        public _Ea Ea;

        public partial struct _DesiredStorageClass
        {
            public FILE_STORAGE_TIER_CLASS Class;

            [NativeTypeName("DWORD")]
            public uint Flags;
        }

        public partial struct _DataStream
        {
            [NativeTypeName("WORD")]
            public ushort Length;

            [NativeTypeName("WORD")]
            public ushort Flags;

            [NativeTypeName("DWORD")]
            public uint Reserved;

            [NativeTypeName("DWORDLONG")]
            public ulong Vdl;
        }

        public partial struct _Reparse
        {
            [NativeTypeName("WORD")]
            public ushort Length;

            [NativeTypeName("WORD")]
            public ushort Flags;

            [NativeTypeName("DWORD")]
            public uint ReparseDataSize;

            [NativeTypeName("DWORD")]
            public uint ReparseDataOffset;
        }

        public partial struct _Ea
        {
            [NativeTypeName("WORD")]
            public ushort Length;

            [NativeTypeName("WORD")]
            public ushort Flags;

            [NativeTypeName("DWORD")]
            public uint EaSize;

            [NativeTypeName("DWORD")]
            public uint EaInformationOffset;
        }
    }
}
