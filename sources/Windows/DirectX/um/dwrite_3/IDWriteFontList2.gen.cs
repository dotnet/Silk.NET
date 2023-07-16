// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteFontList2.xml' path='doc/member[@name="IDWriteFontList2"]/*'/>
[Guid("C0763A34-77AF-445A-B735-08C37B0A5BF5")]
[NativeTypeName("struct IDWriteFontList2 : IDWriteFontList1")]
[NativeInheritance("IDWriteFontList1")]
public unsafe partial struct IDWriteFontList2 : IDWriteFontList2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontList2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontList2*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontList2*, uint> )(lpVtbl[1]))((IDWriteFontList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontList2*, uint> )(lpVtbl[2]))((IDWriteFontList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontList.GetFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFontCollection(IDWriteFontCollection** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteFontList2*, IDWriteFontCollection**, int> )(lpVtbl[3]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), fontCollection);
    }

    /// <inheritdoc cref = "IDWriteFontList.GetFontCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontCount()
    {
        return ((delegate* unmanaged<IDWriteFontList2*, uint> )(lpVtbl[4]))((IDWriteFontList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontList.GetFont"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFont([NativeTypeName("UINT32")] uint index, IDWriteFont** font)
    {
        return ((delegate* unmanaged<IDWriteFontList2*, uint, IDWriteFont**, int> )(lpVtbl[5]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), index, font);
    }

    /// <inheritdoc cref = "IDWriteFontList1.GetFontLocality"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
    {
        return ((delegate* unmanaged<IDWriteFontList2*, uint, DWRITE_LOCALITY> )(lpVtbl[6]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), listIndex);
    }

    /// <inheritdoc cref = "IDWriteFontList1.GetFont"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFont([NativeTypeName("UINT32")] uint listIndex, IDWriteFont3** font)
    {
        return ((delegate* unmanaged<IDWriteFontList2*, uint, IDWriteFont3**, int> )(lpVtbl[7]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), listIndex, font);
    }

    /// <inheritdoc cref = "IDWriteFontList1.GetFontFaceReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference** fontFaceReference)
    {
        return ((delegate* unmanaged<IDWriteFontList2*, uint, IDWriteFontFaceReference**, int> )(lpVtbl[8]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
    }

    /// <include file='IDWriteFontList2.xml' path='doc/member[@name="IDWriteFontList2.GetFontSet"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFontSet(IDWriteFontSet1** fontSet)
    {
        return ((delegate* unmanaged<IDWriteFontList2*, IDWriteFontSet1**, int> )(lpVtbl[9]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), fontSet);
    }

    public interface Interface : IDWriteFontList1.Interface
    {
        [VtblIndex(9)]
        HRESULT GetFontSet(IDWriteFontSet1** fontSet);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontCollection**, int> GetFontCollection;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontCount;
        [NativeTypeName("HRESULT (UINT32, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteFont**, int> GetFont;
        [NativeTypeName("DWRITE_LOCALITY (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DWRITE_LOCALITY> GetFontLocality;
        [NativeTypeName("HRESULT (UINT32, IDWriteFont3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteFont3**, int> GetFont1;
        [NativeTypeName("HRESULT (UINT32, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontFaceReference**, int> GetFontFaceReference;
        [NativeTypeName("HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontSet1**, int> GetFontSet;
    }
}