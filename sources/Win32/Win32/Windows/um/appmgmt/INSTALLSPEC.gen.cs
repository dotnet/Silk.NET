// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmgmt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct INSTALLSPEC
{
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_appmgmt_L39_C5")]
    public _AppName_e__Struct AppName;

    [FieldOffset(0)]
    [NativeTypeName("WCHAR *")]
    public ushort* FileExt;

    [FieldOffset(0)]
    [NativeTypeName("WCHAR *")]
    public ushort* ProgId;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_appmgmt_L46_C5")]
    public _COMClass_e__Struct COMClass;

    public unsafe partial struct _AppName_e__Struct
    {
        [NativeTypeName("WCHAR *")]
        public ushort* Name;
        public Guid GPOId;
    }

    public partial struct _COMClass_e__Struct
    {
        public Guid Clsid;

        [NativeTypeName("DWORD")]
        public uint ClsCtx;
    }
}
