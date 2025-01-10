// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct STGMEDIUM
{
    [NativeTypeName("DWORD")]
    public uint tymed;

    [NativeTypeName("__AnonymousRecord_objidl_L12046_C36")]
    public _Anonymous_e__Union Anonymous;
    public IUnknown pUnkForRelease;

    [UnscopedRef]
    public ref HBITMAP hBitmap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hBitmap; }
    }

    [UnscopedRef]
    public ref HMETAFILEPICT hMetaFilePict
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hMetaFilePict; }
    }

    [UnscopedRef]
    public ref HENHMETAFILE hEnhMetaFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hEnhMetaFile; }
    }

    [UnscopedRef]
    public ref HGLOBAL hGlobal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hGlobal; }
    }

    [UnscopedRef]
    public ref ushort* lpszFileName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.lpszFileName; }
    }

    [UnscopedRef]
    public ref IStream pstm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pstm; }
    }

    [UnscopedRef]
    public ref IStorage pstg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pstg; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HBITMAP hBitmap;

        [FieldOffset(0)]
        public HMETAFILEPICT hMetaFilePict;

        [FieldOffset(0)]
        public HENHMETAFILE hEnhMetaFile;

        [FieldOffset(0)]
        public HGLOBAL hGlobal;

        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* lpszFileName;

        [FieldOffset(0)]
        public IStream pstm;

        [FieldOffset(0)]
        public IStorage pstg;
    }
}
