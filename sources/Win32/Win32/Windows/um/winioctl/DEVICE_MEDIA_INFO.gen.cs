// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DEVICE_MEDIA_INFO
{
    [NativeTypeName("__AnonymousRecord_winioctl_L940_C5")]
    public _DeviceSpecific_e__Union DeviceSpecific;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _DeviceSpecific_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L941_C9")]
        public _DiskInfo_e__Struct DiskInfo;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L951_C9")]
        public _RemovableDiskInfo_e__Struct RemovableDiskInfo;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L961_C9")]
        public _TapeInfo_e__Struct TapeInfo;

        public partial struct _DiskInfo_e__Struct
        {
            public LARGE_INTEGER Cylinders;
            public STORAGE_MEDIA_TYPE MediaType;

            [NativeTypeName("DWORD")]
            public uint TracksPerCylinder;

            [NativeTypeName("DWORD")]
            public uint SectorsPerTrack;

            [NativeTypeName("DWORD")]
            public uint BytesPerSector;

            [NativeTypeName("DWORD")]
            public uint NumberMediaSides;

            [NativeTypeName("DWORD")]
            public uint MediaCharacteristics;
        }

        public partial struct _RemovableDiskInfo_e__Struct
        {
            public LARGE_INTEGER Cylinders;
            public STORAGE_MEDIA_TYPE MediaType;

            [NativeTypeName("DWORD")]
            public uint TracksPerCylinder;

            [NativeTypeName("DWORD")]
            public uint SectorsPerTrack;

            [NativeTypeName("DWORD")]
            public uint BytesPerSector;

            [NativeTypeName("DWORD")]
            public uint NumberMediaSides;

            [NativeTypeName("DWORD")]
            public uint MediaCharacteristics;
        }

        public partial struct _TapeInfo_e__Struct
        {
            public STORAGE_MEDIA_TYPE MediaType;

            [NativeTypeName("DWORD")]
            public uint MediaCharacteristics;

            [NativeTypeName("DWORD")]
            public uint CurrentBlockSize;
            public STORAGE_BUS_TYPE BusType;

            [NativeTypeName("__AnonymousRecord_winioctl_L971_C13")]
            public _BusSpecificData_e__Union BusSpecificData;

            [StructLayout(LayoutKind.Explicit)]
            public partial struct _BusSpecificData_e__Union
            {
                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_winioctl_L972_C17")]
                public _ScsiInformation_e__Struct ScsiInformation;

                public partial struct _ScsiInformation_e__Struct
                {
                    public byte MediumType;
                    public byte DensityCode;
                }
            }
        }
    }
}
