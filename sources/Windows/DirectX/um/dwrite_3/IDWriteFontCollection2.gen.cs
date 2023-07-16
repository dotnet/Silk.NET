// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteFontCollection2.xml' path='doc/member[@name="IDWriteFontCollection2"]/*'/>
[Guid("514039C6-4617-4064-BF8B-92EA83E506E0")]
[NativeTypeName("struct IDWriteFontCollection2 : IDWriteFontCollection1")]
[NativeInheritance("IDWriteFontCollection1")]
public unsafe partial struct IDWriteFontCollection2 : IDWriteFontCollection2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontCollection2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, uint> )(lpVtbl[1]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, uint> )(lpVtbl[2]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontCollection.GetFontFamilyCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFamilyCount()
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, uint> )(lpVtbl[3]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontCollection.GetFontFamily"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily** fontFamily)
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, uint, IDWriteFontFamily**, int> )(lpVtbl[4]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), index, fontFamily);
    }

    /// <inheritdoc cref = "IDWriteFontCollection.FindFamilyName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FindFamilyName([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("UINT32 *")] uint* index, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, ushort*, uint*, BOOL*, int> )(lpVtbl[5]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), familyName, index, exists);
    }

    /// <inheritdoc cref = "IDWriteFontCollection.GetFontFromFontFace"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, IDWriteFontFace*, IDWriteFont**, int> )(lpVtbl[6]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), fontFace, font);
    }

    /// <inheritdoc cref = "IDWriteFontCollection1.GetFontSet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFontSet(IDWriteFontSet** fontSet)
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, IDWriteFontSet**, int> )(lpVtbl[7]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), fontSet);
    }

    /// <inheritdoc cref = "IDWriteFontCollection1.GetFontFamily"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily1** fontFamily)
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, uint, IDWriteFontFamily1**, int> )(lpVtbl[8]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), index, fontFamily);
    }

    /// <include file='IDWriteFontCollection2.xml' path='doc/member[@name="IDWriteFontCollection2.GetFontFamily"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily2** fontFamily)
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, uint, IDWriteFontFamily2**, int> )(lpVtbl[9]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), index, fontFamily);
    }

    /// <include file='IDWriteFontCollection2.xml' path='doc/member[@name="IDWriteFontCollection2.GetMatchingFonts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, ushort*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontList2**, int> )(lpVtbl[10]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), familyName, fontAxisValues, fontAxisValueCount, fontList);
    }

    /// <include file='IDWriteFontCollection2.xml' path='doc/member[@name="IDWriteFontCollection2.GetFontFamilyModel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DWRITE_FONT_FAMILY_MODEL GetFontFamilyModel()
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, DWRITE_FONT_FAMILY_MODEL> )(lpVtbl[11]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontCollection2.xml' path='doc/member[@name="IDWriteFontCollection2.GetFontSet"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFontSet(IDWriteFontSet1** fontSet)
    {
        return ((delegate* unmanaged<IDWriteFontCollection2*, IDWriteFontSet1**, int> )(lpVtbl[12]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), fontSet);
    }

    public interface Interface : IDWriteFontCollection1.Interface
    {
        [VtblIndex(9)]
        HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily2** fontFamily);
        [VtblIndex(10)]
        HRESULT GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontList2** fontList);
        [VtblIndex(11)]
        DWRITE_FONT_FAMILY_MODEL GetFontFamilyModel();
        [VtblIndex(12)]
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
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontFamilyCount;
        [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontFamily**, int> GetFontFamily;
        [NativeTypeName("HRESULT (const WCHAR *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, BOOL*, int> FindFamilyName;
        [NativeTypeName("HRESULT (IDWriteFontFace *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFace*, IDWriteFont**, int> GetFontFromFontFace;
        [NativeTypeName("HRESULT (IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontSet**, int> GetFontSet;
        [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontFamily1**, int> GetFontFamily1;
        [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontFamily2**, int> GetFontFamily2;
        [NativeTypeName("HRESULT (const WCHAR *, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontList2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontList2**, int> GetMatchingFonts;
        [NativeTypeName("DWRITE_FONT_FAMILY_MODEL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_FAMILY_MODEL> GetFontFamilyModel;
        [NativeTypeName("HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontSet1**, int> GetFontSet1;
    }
}