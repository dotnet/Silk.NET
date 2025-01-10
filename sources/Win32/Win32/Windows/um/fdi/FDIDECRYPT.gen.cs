// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct FDIDECRYPT
{
    public FDIDECRYPTTYPE fdidt;
    public void* pvUser;

    [NativeTypeName("__AnonymousRecord_fdi_L416_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._cabinet_e__Struct cabinet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.cabinet; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._folder_e__Struct folder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.folder; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._decrypt_e__Struct decrypt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.decrypt; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_fdi_L417_C9")]
        public _cabinet_e__Struct cabinet;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_fdi_L424_C9")]
        public _folder_e__Struct folder;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_fdi_L430_C9")]
        public _decrypt_e__Struct decrypt;

        public unsafe partial struct _cabinet_e__Struct
        {
            public void* pHeaderReserve;
            public ushort cbHeaderReserve;
            public ushort setID;
            public int iCabinet;
        }

        public unsafe partial struct _folder_e__Struct
        {
            public void* pFolderReserve;
            public ushort cbFolderReserve;
            public ushort iFolder;
        }

        public unsafe partial struct _decrypt_e__Struct
        {
            public void* pDataReserve;
            public ushort cbDataReserve;
            public void* pbData;
            public ushort cbData;
            public BOOL fSplit;
            public ushort cbPartial;
        }
    }
}
