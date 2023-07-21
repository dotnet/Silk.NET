// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IOverlay.xml' path='doc/member[@name="IOverlay"]/*' />
[Guid("56A868A1-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IOverlay : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOverlay : IOverlay.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOverlay));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOverlay*, Guid*, void**, int>)(lpVtbl[0]))((IOverlay*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOverlay*, uint>)(lpVtbl[1]))((IOverlay*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOverlay*, uint>)(lpVtbl[2]))((IOverlay*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOverlay.xml' path='doc/member[@name="IOverlay.GetPalette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPalette([NativeTypeName("DWORD *")] uint* pdwColors, PALETTEENTRY** ppPalette)
    {
        return ((delegate* unmanaged<IOverlay*, uint*, PALETTEENTRY**, int>)(lpVtbl[3]))((IOverlay*)Unsafe.AsPointer(ref this), pdwColors, ppPalette);
    }

    /// <include file='IOverlay.xml' path='doc/member[@name="IOverlay.SetPalette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPalette([NativeTypeName("DWORD")] uint dwColors, PALETTEENTRY* pPalette)
    {
        return ((delegate* unmanaged<IOverlay*, uint, PALETTEENTRY*, int>)(lpVtbl[4]))((IOverlay*)Unsafe.AsPointer(ref this), dwColors, pPalette);
    }

    /// <include file='IOverlay.xml' path='doc/member[@name="IOverlay.GetDefaultColorKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDefaultColorKey(COLORKEY* pColorKey)
    {
        return ((delegate* unmanaged<IOverlay*, COLORKEY*, int>)(lpVtbl[5]))((IOverlay*)Unsafe.AsPointer(ref this), pColorKey);
    }

    /// <include file='IOverlay.xml' path='doc/member[@name="IOverlay.GetColorKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetColorKey(COLORKEY* pColorKey)
    {
        return ((delegate* unmanaged<IOverlay*, COLORKEY*, int>)(lpVtbl[6]))((IOverlay*)Unsafe.AsPointer(ref this), pColorKey);
    }

    /// <include file='IOverlay.xml' path='doc/member[@name="IOverlay.SetColorKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetColorKey(COLORKEY* pColorKey)
    {
        return ((delegate* unmanaged<IOverlay*, COLORKEY*, int>)(lpVtbl[7]))((IOverlay*)Unsafe.AsPointer(ref this), pColorKey);
    }

    /// <include file='IOverlay.xml' path='doc/member[@name="IOverlay.GetWindowHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWindowHandle(HWND* pHwnd)
    {
        return ((delegate* unmanaged<IOverlay*, HWND*, int>)(lpVtbl[8]))((IOverlay*)Unsafe.AsPointer(ref this), pHwnd);
    }

    /// <include file='IOverlay.xml' path='doc/member[@name="IOverlay.GetClipList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetClipList(RECT* pSourceRect, RECT* pDestinationRect, RGNDATA** ppRgnData)
    {
        return ((delegate* unmanaged<IOverlay*, RECT*, RECT*, RGNDATA**, int>)(lpVtbl[9]))((IOverlay*)Unsafe.AsPointer(ref this), pSourceRect, pDestinationRect, ppRgnData);
    }

    /// <include file='IOverlay.xml' path='doc/member[@name="IOverlay.GetVideoPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetVideoPosition(RECT* pSourceRect, RECT* pDestinationRect)
    {
        return ((delegate* unmanaged<IOverlay*, RECT*, RECT*, int>)(lpVtbl[10]))((IOverlay*)Unsafe.AsPointer(ref this), pSourceRect, pDestinationRect);
    }

    /// <include file='IOverlay.xml' path='doc/member[@name="IOverlay.Advise"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Advise(IOverlayNotify* pOverlayNotify, [NativeTypeName("DWORD")] uint dwInterests)
    {
        return ((delegate* unmanaged<IOverlay*, IOverlayNotify*, uint, int>)(lpVtbl[11]))((IOverlay*)Unsafe.AsPointer(ref this), pOverlayNotify, dwInterests);
    }

    /// <include file='IOverlay.xml' path='doc/member[@name="IOverlay.Unadvise"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Unadvise()
    {
        return ((delegate* unmanaged<IOverlay*, int>)(lpVtbl[12]))((IOverlay*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPalette([NativeTypeName("DWORD *")] uint* pdwColors, PALETTEENTRY** ppPalette);

        [VtblIndex(4)]
        HRESULT SetPalette([NativeTypeName("DWORD")] uint dwColors, PALETTEENTRY* pPalette);

        [VtblIndex(5)]
        HRESULT GetDefaultColorKey(COLORKEY* pColorKey);

        [VtblIndex(6)]
        HRESULT GetColorKey(COLORKEY* pColorKey);

        [VtblIndex(7)]
        HRESULT SetColorKey(COLORKEY* pColorKey);

        [VtblIndex(8)]
        HRESULT GetWindowHandle(HWND* pHwnd);

        [VtblIndex(9)]
        HRESULT GetClipList(RECT* pSourceRect, RECT* pDestinationRect, RGNDATA** ppRgnData);

        [VtblIndex(10)]
        HRESULT GetVideoPosition(RECT* pSourceRect, RECT* pDestinationRect);

        [VtblIndex(11)]
        HRESULT Advise(IOverlayNotify* pOverlayNotify, [NativeTypeName("DWORD")] uint dwInterests);

        [VtblIndex(12)]
        HRESULT Unadvise();
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

        [NativeTypeName("HRESULT (DWORD *, PALETTEENTRY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, PALETTEENTRY**, int> GetPalette;

        [NativeTypeName("HRESULT (DWORD, PALETTEENTRY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PALETTEENTRY*, int> SetPalette;

        [NativeTypeName("HRESULT (COLORKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORKEY*, int> GetDefaultColorKey;

        [NativeTypeName("HRESULT (COLORKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORKEY*, int> GetColorKey;

        [NativeTypeName("HRESULT (COLORKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORKEY*, int> SetColorKey;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWindowHandle;

        [NativeTypeName("HRESULT (RECT *, RECT *, RGNDATA **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, RGNDATA**, int> GetClipList;

        [NativeTypeName("HRESULT (RECT *, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, int> GetVideoPosition;

        [NativeTypeName("HRESULT (IOverlayNotify *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOverlayNotify*, uint, int> Advise;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unadvise;
    }
}
