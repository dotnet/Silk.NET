// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='uCLSSPEC.xml' path='doc/member[@name="uCLSSPEC"]/*' />
public partial struct uCLSSPEC
{
    /// <include file='uCLSSPEC.xml' path='doc/member[@name="uCLSSPEC.tyspec"]/*' />
    [NativeTypeName("DWORD")]
    public uint tyspec;

    /// <include file='uCLSSPEC.xml' path='doc/member[@name="uCLSSPEC.tagged_union"]/*' />
    [NativeTypeName("union __MIDL___MIDL_itf_wtypes_0000_0001_0005")]
    public _tagged_union_e__Union tagged_union;

    /// <include file='_tagged_union_e__Union.xml' path='doc/member[@name="_tagged_union_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _tagged_union_e__Union
    {
        /// <include file='_tagged_union_e__Union.xml' path='doc/member[@name="_tagged_union_e__Union.clsid"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("CLSID")]
        public Guid clsid;

        /// <include file='_tagged_union_e__Union.xml' path='doc/member[@name="_tagged_union_e__Union.pFileExt"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* pFileExt;

        /// <include file='_tagged_union_e__Union.xml' path='doc/member[@name="_tagged_union_e__Union.pMimeType"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* pMimeType;

        /// <include file='_tagged_union_e__Union.xml' path='doc/member[@name="_tagged_union_e__Union.pProgId"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* pProgId;

        /// <include file='_tagged_union_e__Union.xml' path='doc/member[@name="_tagged_union_e__Union.pFileName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* pFileName;

        /// <include file='_tagged_union_e__Union.xml' path='doc/member[@name="_tagged_union_e__Union.ByName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wtypes_L938_C24")]
        public _ByName_e__Struct ByName;

        /// <include file='_tagged_union_e__Union.xml' path='doc/member[@name="_tagged_union_e__Union.ByObjectId"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wtypes_L943_C24")]
        public _ByObjectId_e__Struct ByObjectId;

        /// <include file='_ByName_e__Struct.xml' path='doc/member[@name="_ByName_e__Struct"]/*' />
        public unsafe partial struct _ByName_e__Struct
        {
            /// <include file='_ByName_e__Struct.xml' path='doc/member[@name="_ByName_e__Struct.pPackageName"]/*' />
            [NativeTypeName("LPOLESTR")]
            public ushort* pPackageName;

            /// <include file='_ByName_e__Struct.xml' path='doc/member[@name="_ByName_e__Struct.PolicyId"]/*' />
            public Guid PolicyId;
        }

        /// <include file='_ByObjectId_e__Struct.xml' path='doc/member[@name="_ByObjectId_e__Struct"]/*' />
        public partial struct _ByObjectId_e__Struct
        {
            /// <include file='_ByObjectId_e__Struct.xml' path='doc/member[@name="_ByObjectId_e__Struct.ObjectId"]/*' />
            public Guid ObjectId;

            /// <include file='_ByObjectId_e__Struct.xml' path='doc/member[@name="_ByObjectId_e__Struct.PolicyId"]/*' />
            public Guid PolicyId;
        }
    }
}
