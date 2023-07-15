// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDWriteFontCollection.xml' path='doc/member[@name="IDWriteFontCollection"]/*'/>
[Guid("A84CEE02-3EEA-4EEE-A827-87C1A02A0FCC")]
[NativeTypeName("struct IDWriteFontCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontCollection : IDWriteFontCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontCollection));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontCollection*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontCollection*, uint> )(lpVtbl[1]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontCollection*, uint> )(lpVtbl[2]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontCollection.xml' path='doc/member[@name="IDWriteFontCollection.GetFontFamilyCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFamilyCount()
    {
        return ((delegate* unmanaged<IDWriteFontCollection*, uint> )(lpVtbl[3]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontCollection.xml' path='doc/member[@name="IDWriteFontCollection.GetFontFamily"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily** fontFamily)
    {
        return ((delegate* unmanaged<IDWriteFontCollection*, uint, IDWriteFontFamily**, int> )(lpVtbl[4]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this), index, fontFamily);
    }

    /// <include file='IDWriteFontCollection.xml' path='doc/member[@name="IDWriteFontCollection.FindFamilyName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FindFamilyName([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("UINT32 *")] uint* index, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFontCollection*, ushort*, uint*, BOOL*, int> )(lpVtbl[5]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this), familyName, index, exists);
    }

    /// <include file='IDWriteFontCollection.xml' path='doc/member[@name="IDWriteFontCollection.GetFontFromFontFace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
    {
        return ((delegate* unmanaged<IDWriteFontCollection*, IDWriteFontFace*, IDWriteFont**, int> )(lpVtbl[6]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this), fontFace, font);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        uint GetFontFamilyCount();
        [VtblIndex(4)]
        HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily** fontFamily);
        [VtblIndex(5)]
        HRESULT FindFamilyName([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("UINT32 *")] uint* index, BOOL* exists);
        [VtblIndex(6)]
        HRESULT GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font);
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
    }
}