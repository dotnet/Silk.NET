// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteFontList.xml' path='doc/member[@name="IDWriteFontList"]/*'/>
[Guid("1A0D8438-1D97-4EC1-AEF9-A2FB86ED6ACB")]
[NativeTypeName("struct IDWriteFontList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontList : IDWriteFontList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontList));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontList*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontList*, uint> )(lpVtbl[1]))((IDWriteFontList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontList*, uint> )(lpVtbl[2]))((IDWriteFontList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontList.xml' path='doc/member[@name="IDWriteFontList.GetFontCollection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFontCollection(IDWriteFontCollection** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteFontList*, IDWriteFontCollection**, int> )(lpVtbl[3]))((IDWriteFontList*)Unsafe.AsPointer(ref this), fontCollection);
    }

    /// <include file='IDWriteFontList.xml' path='doc/member[@name="IDWriteFontList.GetFontCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontCount()
    {
        return ((delegate* unmanaged<IDWriteFontList*, uint> )(lpVtbl[4]))((IDWriteFontList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontList.xml' path='doc/member[@name="IDWriteFontList.GetFont"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFont([NativeTypeName("UINT32")] uint index, IDWriteFont** font)
    {
        return ((delegate* unmanaged<IDWriteFontList*, uint, IDWriteFont**, int> )(lpVtbl[5]))((IDWriteFontList*)Unsafe.AsPointer(ref this), index, font);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFontCollection(IDWriteFontCollection** fontCollection);
        [VtblIndex(4)]
        [return: NativeTypeName("UINT32")]
        uint GetFontCount();
        [VtblIndex(5)]
        HRESULT GetFont([NativeTypeName("UINT32")] uint index, IDWriteFont** font);
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
    }
}