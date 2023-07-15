// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDWriteFontFallbackBuilder.xml' path='doc/member[@name="IDWriteFontFallbackBuilder"]/*'/>
[Guid("FD882D06-8ABA-4FB8-B849-8BE8B73E14DE")]
[NativeTypeName("struct IDWriteFontFallbackBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDWriteFontFallbackBuilder : IDWriteFontFallbackBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFallbackBuilder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontFallbackBuilder*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontFallbackBuilder*, uint> )(lpVtbl[1]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontFallbackBuilder*, uint> )(lpVtbl[2]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFallbackBuilder.xml' path='doc/member[@name="IDWriteFontFallbackBuilder.AddMapping"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddMapping([NativeTypeName("const DWRITE_UNICODE_RANGE *")] DWRITE_UNICODE_RANGE* ranges, [NativeTypeName("UINT32")] uint rangesCount, [NativeTypeName("const WCHAR **")] ushort** targetFamilyNames, [NativeTypeName("UINT32")] uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection = null, [NativeTypeName("const WCHAR *")] ushort* localeName = null, [NativeTypeName("const WCHAR *")] ushort* baseFamilyName = null, float scale = 1.0f)
    {
        return ((delegate* unmanaged<IDWriteFontFallbackBuilder*, DWRITE_UNICODE_RANGE*, uint, ushort**, uint, IDWriteFontCollection*, ushort*, ushort*, float, int> )(lpVtbl[3]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
    }

    /// <include file='IDWriteFontFallbackBuilder.xml' path='doc/member[@name="IDWriteFontFallbackBuilder.AddMappings"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddMappings(IDWriteFontFallback* fontFallback)
    {
        return ((delegate* unmanaged<IDWriteFontFallbackBuilder*, IDWriteFontFallback*, int> )(lpVtbl[4]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), fontFallback);
    }

    /// <include file='IDWriteFontFallbackBuilder.xml' path='doc/member[@name="IDWriteFontFallbackBuilder.CreateFontFallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateFontFallback(IDWriteFontFallback** fontFallback)
    {
        return ((delegate* unmanaged<IDWriteFontFallbackBuilder*, IDWriteFontFallback**, int> )(lpVtbl[5]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), fontFallback);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddMapping([NativeTypeName("const DWRITE_UNICODE_RANGE *")] DWRITE_UNICODE_RANGE* ranges, [NativeTypeName("UINT32")] uint rangesCount, [NativeTypeName("const WCHAR **")] ushort** targetFamilyNames, [NativeTypeName("UINT32")] uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection = null, [NativeTypeName("const WCHAR *")] ushort* localeName = null, [NativeTypeName("const WCHAR *")] ushort* baseFamilyName = null, float scale = 1.0f);
        [VtblIndex(4)]
        HRESULT AddMappings(IDWriteFontFallback* fontFallback);
        [VtblIndex(5)]
        HRESULT CreateFontFallback(IDWriteFontFallback** fontFallback);
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
        [NativeTypeName("HRESULT (const DWRITE_UNICODE_RANGE *, UINT32, const WCHAR **, UINT32, IDWriteFontCollection *, const WCHAR *, const WCHAR *, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_UNICODE_RANGE*, uint, ushort**, uint, IDWriteFontCollection*, ushort*, ushort*, float, int> AddMapping;
        [NativeTypeName("HRESULT (IDWriteFontFallback *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFallback*, int> AddMappings;
        [NativeTypeName("HRESULT (IDWriteFontFallback **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFallback**, int> CreateFontFallback;
    }
}