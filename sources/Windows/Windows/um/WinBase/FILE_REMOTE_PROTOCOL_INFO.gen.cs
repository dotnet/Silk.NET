// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO"]/*'/>
public partial struct FILE_REMOTE_PROTOCOL_INFO
{
    /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.StructureVersion"]/*'/>
    public ushort StructureVersion;
    /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.StructureSize"]/*'/>
    public ushort StructureSize;
    /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.Protocol"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Protocol;
    /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.ProtocolMajorVersion"]/*'/>
    public ushort ProtocolMajorVersion;
    /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.ProtocolMinorVersion"]/*'/>
    public ushort ProtocolMinorVersion;
    /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.ProtocolRevision"]/*'/>
    public ushort ProtocolRevision;
    /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.Reserved"]/*'/>
    public ushort Reserved;
    /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.GenericReserved"]/*'/>
    [NativeTypeName("__AnonymousRecord_WinBase_L9201_C5")]
    public _GenericReserved_e__Struct GenericReserved;
    /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.ProtocolSpecific"]/*'/>
    [NativeTypeName("__AnonymousRecord_WinBase_L9214_C5")]
    public _ProtocolSpecific_e__Union ProtocolSpecific;
    /// <include file='_GenericReserved_e__Struct.xml' path='doc/member[@name="_GenericReserved_e__Struct"]/*'/>
    public unsafe partial struct _GenericReserved_e__Struct
    {
        /// <include file='_GenericReserved_e__Struct.xml' path='doc/member[@name="_GenericReserved_e__Struct.Reserved"]/*'/>
        [NativeTypeName("ULONG[8]")]
        public fixed uint Reserved[8];
    }

    /// <include file='_ProtocolSpecific_e__Union.xml' path='doc/member[@name="_ProtocolSpecific_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _ProtocolSpecific_e__Union
    {
        /// <include file='_ProtocolSpecific_e__Union.xml' path='doc/member[@name="_ProtocolSpecific_e__Union.Smb2"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_WinBase_L9216_C9")]
        public _Smb2_e__Struct Smb2;
        /// <include file='_ProtocolSpecific_e__Union.xml' path='doc/member[@name="_ProtocolSpecific_e__Union.Reserved"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONG[16]")]
        public fixed uint Reserved[16];
        /// <include file='_Smb2_e__Struct.xml' path='doc/member[@name="_Smb2_e__Struct"]/*'/>
        public partial struct _Smb2_e__Struct
        {
            /// <include file='_Smb2_e__Struct.xml' path='doc/member[@name="_Smb2_e__Struct.Server"]/*'/>
            [NativeTypeName("__AnonymousRecord_WinBase_L9218_C13")]
            public _Server_e__Struct Server;
            /// <include file='_Smb2_e__Struct.xml' path='doc/member[@name="_Smb2_e__Struct.Share"]/*'/>
            [NativeTypeName("__AnonymousRecord_WinBase_L9222_C13")]
            public _Share_e__Struct Share;
            /// <include file='_Server_e__Struct.xml' path='doc/member[@name="_Server_e__Struct"]/*'/>
            public partial struct _Server_e__Struct
            {
                /// <include file='_Server_e__Struct.xml' path='doc/member[@name="_Server_e__Struct.Capabilities"]/*'/>
                [NativeTypeName("ULONG")]
                public uint Capabilities;
            }

            /// <include file='_Share_e__Struct.xml' path='doc/member[@name="_Share_e__Struct"]/*'/>
            public partial struct _Share_e__Struct
            {
                /// <include file='_Share_e__Struct.xml' path='doc/member[@name="_Share_e__Struct.Capabilities"]/*'/>
                [NativeTypeName("ULONG")]
                public uint Capabilities;
                /// <include file='_Share_e__Struct.xml' path='doc/member[@name="_Share_e__Struct.ShareFlags"]/*'/>
                [NativeTypeName("ULONG")]
                public uint ShareFlags;
            }
        }
    }
}