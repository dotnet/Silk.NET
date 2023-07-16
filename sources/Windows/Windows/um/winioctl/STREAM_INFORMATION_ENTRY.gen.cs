// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='STREAM_INFORMATION_ENTRY.xml' path='doc/member[@name="STREAM_INFORMATION_ENTRY"]/*'/>
public partial struct STREAM_INFORMATION_ENTRY
{
    /// <include file='STREAM_INFORMATION_ENTRY.xml' path='doc/member[@name="STREAM_INFORMATION_ENTRY.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STREAM_INFORMATION_ENTRY.xml' path='doc/member[@name="STREAM_INFORMATION_ENTRY.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='STREAM_INFORMATION_ENTRY.xml' path='doc/member[@name="STREAM_INFORMATION_ENTRY.StreamInformation"]/*'/>
    [NativeTypeName("union _StreamInformation")]
    public _StreamInformation StreamInformation;
    /// <include file='_StreamInformation.xml' path='doc/member[@name="_StreamInformation"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _StreamInformation
    {
        /// <include file='_StreamInformation.xml' path='doc/member[@name="_StreamInformation.DesiredStorageClass"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct _DesiredStorageClass")]
        public _DesiredStorageClass DesiredStorageClass;
        /// <include file='_StreamInformation.xml' path='doc/member[@name="_StreamInformation.DataStream"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct _DataStream")]
        public _DataStream DataStream;
        /// <include file='_StreamInformation.xml' path='doc/member[@name="_StreamInformation.Reparse"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct _Reparse")]
        public _Reparse Reparse;
        /// <include file='_StreamInformation.xml' path='doc/member[@name="_StreamInformation.Ea"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct _Ea")]
        public _Ea Ea;
        /// <include file='_DesiredStorageClass.xml' path='doc/member[@name="_DesiredStorageClass"]/*'/>
        public partial struct _DesiredStorageClass
        {
            /// <include file='_DesiredStorageClass.xml' path='doc/member[@name="_DesiredStorageClass.Class"]/*'/>
            public FILE_STORAGE_TIER_CLASS Class;
            /// <include file='_DesiredStorageClass.xml' path='doc/member[@name="_DesiredStorageClass.Flags"]/*'/>
            [NativeTypeName("DWORD")]
            public uint Flags;
        }

        /// <include file='_DataStream.xml' path='doc/member[@name="_DataStream"]/*'/>
        public partial struct _DataStream
        {
            /// <include file='_DataStream.xml' path='doc/member[@name="_DataStream.Length"]/*'/>
            [NativeTypeName("WORD")]
            public ushort Length;
            /// <include file='_DataStream.xml' path='doc/member[@name="_DataStream.Flags"]/*'/>
            [NativeTypeName("WORD")]
            public ushort Flags;
            /// <include file='_DataStream.xml' path='doc/member[@name="_DataStream.Reserved"]/*'/>
            [NativeTypeName("DWORD")]
            public uint Reserved;
            /// <include file='_DataStream.xml' path='doc/member[@name="_DataStream.Vdl"]/*'/>
            [NativeTypeName("DWORDLONG")]
            public ulong Vdl;
        }

        /// <include file='_Reparse.xml' path='doc/member[@name="_Reparse"]/*'/>
        public partial struct _Reparse
        {
            /// <include file='_Reparse.xml' path='doc/member[@name="_Reparse.Length"]/*'/>
            [NativeTypeName("WORD")]
            public ushort Length;
            /// <include file='_Reparse.xml' path='doc/member[@name="_Reparse.Flags"]/*'/>
            [NativeTypeName("WORD")]
            public ushort Flags;
            /// <include file='_Reparse.xml' path='doc/member[@name="_Reparse.ReparseDataSize"]/*'/>
            [NativeTypeName("DWORD")]
            public uint ReparseDataSize;
            /// <include file='_Reparse.xml' path='doc/member[@name="_Reparse.ReparseDataOffset"]/*'/>
            [NativeTypeName("DWORD")]
            public uint ReparseDataOffset;
        }

        /// <include file='_Ea.xml' path='doc/member[@name="_Ea"]/*'/>
        public partial struct _Ea
        {
            /// <include file='_Ea.xml' path='doc/member[@name="_Ea.Length"]/*'/>
            [NativeTypeName("WORD")]
            public ushort Length;
            /// <include file='_Ea.xml' path='doc/member[@name="_Ea.Flags"]/*'/>
            [NativeTypeName("WORD")]
            public ushort Flags;
            /// <include file='_Ea.xml' path='doc/member[@name="_Ea.EaSize"]/*'/>
            [NativeTypeName("DWORD")]
            public uint EaSize;
            /// <include file='_Ea.xml' path='doc/member[@name="_Ea.EaInformationOffset"]/*'/>
            [NativeTypeName("DWORD")]
            public uint EaInformationOffset;
        }
    }
}