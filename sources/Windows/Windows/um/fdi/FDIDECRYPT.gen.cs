// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='FDIDECRYPT.xml' path='doc/member[@name="FDIDECRYPT"]/*'/>
public unsafe partial struct FDIDECRYPT
{
    /// <include file='FDIDECRYPT.xml' path='doc/member[@name="FDIDECRYPT.fdidt"]/*'/>
    public FDIDECRYPTTYPE fdidt;
    /// <include file='FDIDECRYPT.xml' path='doc/member[@name="FDIDECRYPT.pvUser"]/*'/>
    public void* pvUser;
    /// <include file='FDIDECRYPT.xml' path='doc/member[@name="FDIDECRYPT.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_fdi_L416_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabinet"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._cabinet_e__Struct cabinet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.cabinet;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.folder"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._folder_e__Struct folder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.folder;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.decrypt"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._decrypt_e__Struct decrypt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.decrypt;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabinet"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_fdi_L417_C9")]
        public _cabinet_e__Struct cabinet;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.folder"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_fdi_L424_C9")]
        public _folder_e__Struct folder;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.decrypt"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_fdi_L430_C9")]
        public _decrypt_e__Struct decrypt;
        /// <include file='_cabinet_e__Struct.xml' path='doc/member[@name="_cabinet_e__Struct"]/*'/>
        public unsafe partial struct _cabinet_e__Struct
        {
            /// <include file='_cabinet_e__Struct.xml' path='doc/member[@name="_cabinet_e__Struct.pHeaderReserve"]/*'/>
            public void* pHeaderReserve;
            /// <include file='_cabinet_e__Struct.xml' path='doc/member[@name="_cabinet_e__Struct.cbHeaderReserve"]/*'/>
            public ushort cbHeaderReserve;
            /// <include file='_cabinet_e__Struct.xml' path='doc/member[@name="_cabinet_e__Struct.setID"]/*'/>
            public ushort setID;
            /// <include file='_cabinet_e__Struct.xml' path='doc/member[@name="_cabinet_e__Struct.iCabinet"]/*'/>
            public int iCabinet;
        }

        /// <include file='_folder_e__Struct.xml' path='doc/member[@name="_folder_e__Struct"]/*'/>
        public unsafe partial struct _folder_e__Struct
        {
            /// <include file='_folder_e__Struct.xml' path='doc/member[@name="_folder_e__Struct.pFolderReserve"]/*'/>
            public void* pFolderReserve;
            /// <include file='_folder_e__Struct.xml' path='doc/member[@name="_folder_e__Struct.cbFolderReserve"]/*'/>
            public ushort cbFolderReserve;
            /// <include file='_folder_e__Struct.xml' path='doc/member[@name="_folder_e__Struct.iFolder"]/*'/>
            public ushort iFolder;
        }

        /// <include file='_decrypt_e__Struct.xml' path='doc/member[@name="_decrypt_e__Struct"]/*'/>
        public unsafe partial struct _decrypt_e__Struct
        {
            /// <include file='_decrypt_e__Struct.xml' path='doc/member[@name="_decrypt_e__Struct.pDataReserve"]/*'/>
            public void* pDataReserve;
            /// <include file='_decrypt_e__Struct.xml' path='doc/member[@name="_decrypt_e__Struct.cbDataReserve"]/*'/>
            public ushort cbDataReserve;
            /// <include file='_decrypt_e__Struct.xml' path='doc/member[@name="_decrypt_e__Struct.pbData"]/*'/>
            public void* pbData;
            /// <include file='_decrypt_e__Struct.xml' path='doc/member[@name="_decrypt_e__Struct.cbData"]/*'/>
            public ushort cbData;
            /// <include file='_decrypt_e__Struct.xml' path='doc/member[@name="_decrypt_e__Struct.fSplit"]/*'/>
            public BOOL fSplit;
            /// <include file='_decrypt_e__Struct.xml' path='doc/member[@name="_decrypt_e__Struct.cbPartial"]/*'/>
            public ushort cbPartial;
        }
    }
}