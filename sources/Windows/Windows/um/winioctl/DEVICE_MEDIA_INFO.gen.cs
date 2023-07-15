// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DEVICE_MEDIA_INFO.xml' path='doc/member[@name="DEVICE_MEDIA_INFO"]/*'/>
public partial struct DEVICE_MEDIA_INFO
{
    /// <include file='DEVICE_MEDIA_INFO.xml' path='doc/member[@name="DEVICE_MEDIA_INFO.DeviceSpecific"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L934_C5")]
    public _DeviceSpecific_e__Union DeviceSpecific;
    /// <include file='_DeviceSpecific_e__Union.xml' path='doc/member[@name="_DeviceSpecific_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _DeviceSpecific_e__Union
    {
        /// <include file='_DeviceSpecific_e__Union.xml' path='doc/member[@name="_DeviceSpecific_e__Union.DiskInfo"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L935_C9")]
        public _DiskInfo_e__Struct DiskInfo;
        /// <include file='_DeviceSpecific_e__Union.xml' path='doc/member[@name="_DeviceSpecific_e__Union.RemovableDiskInfo"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L945_C9")]
        public _RemovableDiskInfo_e__Struct RemovableDiskInfo;
        /// <include file='_DeviceSpecific_e__Union.xml' path='doc/member[@name="_DeviceSpecific_e__Union.TapeInfo"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L955_C9")]
        public _TapeInfo_e__Struct TapeInfo;
        /// <include file='_DiskInfo_e__Struct.xml' path='doc/member[@name="_DiskInfo_e__Struct"]/*'/>
        public partial struct _DiskInfo_e__Struct
        {
            /// <include file='_DiskInfo_e__Struct.xml' path='doc/member[@name="_DiskInfo_e__Struct.Cylinders"]/*'/>
            public LARGE_INTEGER Cylinders;
            /// <include file='_DiskInfo_e__Struct.xml' path='doc/member[@name="_DiskInfo_e__Struct.MediaType"]/*'/>
            public STORAGE_MEDIA_TYPE MediaType;
            /// <include file='_DiskInfo_e__Struct.xml' path='doc/member[@name="_DiskInfo_e__Struct.TracksPerCylinder"]/*'/>
            [NativeTypeName("DWORD")]
            public uint TracksPerCylinder;
            /// <include file='_DiskInfo_e__Struct.xml' path='doc/member[@name="_DiskInfo_e__Struct.SectorsPerTrack"]/*'/>
            [NativeTypeName("DWORD")]
            public uint SectorsPerTrack;
            /// <include file='_DiskInfo_e__Struct.xml' path='doc/member[@name="_DiskInfo_e__Struct.BytesPerSector"]/*'/>
            [NativeTypeName("DWORD")]
            public uint BytesPerSector;
            /// <include file='_DiskInfo_e__Struct.xml' path='doc/member[@name="_DiskInfo_e__Struct.NumberMediaSides"]/*'/>
            [NativeTypeName("DWORD")]
            public uint NumberMediaSides;
            /// <include file='_DiskInfo_e__Struct.xml' path='doc/member[@name="_DiskInfo_e__Struct.MediaCharacteristics"]/*'/>
            [NativeTypeName("DWORD")]
            public uint MediaCharacteristics;
        }

        /// <include file='_RemovableDiskInfo_e__Struct.xml' path='doc/member[@name="_RemovableDiskInfo_e__Struct"]/*'/>
        public partial struct _RemovableDiskInfo_e__Struct
        {
            /// <include file='_RemovableDiskInfo_e__Struct.xml' path='doc/member[@name="_RemovableDiskInfo_e__Struct.Cylinders"]/*'/>
            public LARGE_INTEGER Cylinders;
            /// <include file='_RemovableDiskInfo_e__Struct.xml' path='doc/member[@name="_RemovableDiskInfo_e__Struct.MediaType"]/*'/>
            public STORAGE_MEDIA_TYPE MediaType;
            /// <include file='_RemovableDiskInfo_e__Struct.xml' path='doc/member[@name="_RemovableDiskInfo_e__Struct.TracksPerCylinder"]/*'/>
            [NativeTypeName("DWORD")]
            public uint TracksPerCylinder;
            /// <include file='_RemovableDiskInfo_e__Struct.xml' path='doc/member[@name="_RemovableDiskInfo_e__Struct.SectorsPerTrack"]/*'/>
            [NativeTypeName("DWORD")]
            public uint SectorsPerTrack;
            /// <include file='_RemovableDiskInfo_e__Struct.xml' path='doc/member[@name="_RemovableDiskInfo_e__Struct.BytesPerSector"]/*'/>
            [NativeTypeName("DWORD")]
            public uint BytesPerSector;
            /// <include file='_RemovableDiskInfo_e__Struct.xml' path='doc/member[@name="_RemovableDiskInfo_e__Struct.NumberMediaSides"]/*'/>
            [NativeTypeName("DWORD")]
            public uint NumberMediaSides;
            /// <include file='_RemovableDiskInfo_e__Struct.xml' path='doc/member[@name="_RemovableDiskInfo_e__Struct.MediaCharacteristics"]/*'/>
            [NativeTypeName("DWORD")]
            public uint MediaCharacteristics;
        }

        /// <include file='_TapeInfo_e__Struct.xml' path='doc/member[@name="_TapeInfo_e__Struct"]/*'/>
        public partial struct _TapeInfo_e__Struct
        {
            /// <include file='_TapeInfo_e__Struct.xml' path='doc/member[@name="_TapeInfo_e__Struct.MediaType"]/*'/>
            public STORAGE_MEDIA_TYPE MediaType;
            /// <include file='_TapeInfo_e__Struct.xml' path='doc/member[@name="_TapeInfo_e__Struct.MediaCharacteristics"]/*'/>
            [NativeTypeName("DWORD")]
            public uint MediaCharacteristics;
            /// <include file='_TapeInfo_e__Struct.xml' path='doc/member[@name="_TapeInfo_e__Struct.CurrentBlockSize"]/*'/>
            [NativeTypeName("DWORD")]
            public uint CurrentBlockSize;
            /// <include file='_TapeInfo_e__Struct.xml' path='doc/member[@name="_TapeInfo_e__Struct.BusType"]/*'/>
            public STORAGE_BUS_TYPE BusType;
            /// <include file='_TapeInfo_e__Struct.xml' path='doc/member[@name="_TapeInfo_e__Struct.BusSpecificData"]/*'/>
            [NativeTypeName("__AnonymousRecord_winioctl_L965_C13")]
            public _BusSpecificData_e__Union BusSpecificData;
            /// <include file='_BusSpecificData_e__Union.xml' path='doc/member[@name="_BusSpecificData_e__Union"]/*'/>
            [StructLayout(LayoutKind.Explicit)]
            public partial struct _BusSpecificData_e__Union
            {
                /// <include file='_BusSpecificData_e__Union.xml' path='doc/member[@name="_BusSpecificData_e__Union.ScsiInformation"]/*'/>
                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_winioctl_L966_C17")]
                public _ScsiInformation_e__Struct ScsiInformation;
                /// <include file='_ScsiInformation_e__Struct.xml' path='doc/member[@name="_ScsiInformation_e__Struct"]/*'/>
                public partial struct _ScsiInformation_e__Struct
                {
                    /// <include file='_ScsiInformation_e__Struct.xml' path='doc/member[@name="_ScsiInformation_e__Struct.MediumType"]/*'/>
                    public byte MediumType;
                    /// <include file='_ScsiInformation_e__Struct.xml' path='doc/member[@name="_ScsiInformation_e__Struct.DensityCode"]/*'/>
                    public byte DensityCode;
                }
            }
        }
    }
}