// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IMAGE_DELAYLOAD_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_DELAYLOAD_DESCRIPTOR"]/*'/>
public partial struct IMAGE_DELAYLOAD_DESCRIPTOR
{
    /// <include file='IMAGE_DELAYLOAD_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_DELAYLOAD_DESCRIPTOR.Attributes"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L19671_C5")]
    public _Attributes_e__Union Attributes;
    /// <include file='IMAGE_DELAYLOAD_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_DELAYLOAD_DESCRIPTOR.DllNameRVA"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DllNameRVA;
    /// <include file='IMAGE_DELAYLOAD_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_DELAYLOAD_DESCRIPTOR.ModuleHandleRVA"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ModuleHandleRVA;
    /// <include file='IMAGE_DELAYLOAD_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_DELAYLOAD_DESCRIPTOR.ImportAddressTableRVA"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ImportAddressTableRVA;
    /// <include file='IMAGE_DELAYLOAD_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_DELAYLOAD_DESCRIPTOR.ImportNameTableRVA"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ImportNameTableRVA;
    /// <include file='IMAGE_DELAYLOAD_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_DELAYLOAD_DESCRIPTOR.BoundImportAddressTableRVA"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BoundImportAddressTableRVA;
    /// <include file='IMAGE_DELAYLOAD_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_DELAYLOAD_DESCRIPTOR.UnloadInformationTableRVA"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UnloadInformationTableRVA;
    /// <include file='IMAGE_DELAYLOAD_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_DELAYLOAD_DESCRIPTOR.TimeDateStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;
    /// <include file='_Attributes_e__Union.xml' path='doc/member[@name="_Attributes_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Attributes_e__Union
    {
        /// <include file='_Attributes_e__Union.xml' path='doc/member[@name="_Attributes_e__Union.AllAttributes"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint AllAttributes;
        /// <include file='_Attributes_e__Union.xml' path='doc/member[@name="_Attributes_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L19673_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RvaBased"]/*'/>
        public uint RvaBased
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.RvaBased;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.RvaBased = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedAttributes"]/*'/>
        public uint ReservedAttributes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.ReservedAttributes;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.ReservedAttributes = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RvaBased"]/*'/>
            [NativeTypeName("DWORD : 1")]
            public uint RvaBased
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedAttributes"]/*'/>
            [NativeTypeName("DWORD : 31")]
            public uint ReservedAttributes
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 1) & 0x7FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
                }
            }
        }
    }
}