// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct uCLSSPEC
{
    [NativeTypeName("DWORD")]
    public uint tyspec;

    [NativeTypeName("union __MIDL___MIDL_itf_wtypes_0000_0001_0005")]
    public _tagged_union_e__Union tagged_union;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _tagged_union_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("CLSID")]
        public Guid clsid;

        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* pFileExt;

        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* pMimeType;

        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* pProgId;

        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* pFileName;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wtypes_L938_C24")]
        public _ByName_e__Struct ByName;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wtypes_L943_C24")]
        public _ByObjectId_e__Struct ByObjectId;

        public unsafe partial struct _ByName_e__Struct
        {
            [NativeTypeName("LPOLESTR")]
            public ushort* pPackageName;
            public Guid PolicyId;
        }

        public partial struct _ByObjectId_e__Struct
        {
            public Guid ObjectId;
            public Guid PolicyId;
        }
    }
}
