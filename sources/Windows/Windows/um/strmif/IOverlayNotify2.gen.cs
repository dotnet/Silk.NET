// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IOverlayNotify2.xml' path='doc/member[@name="IOverlayNotify2"]/*' />
[Guid("680EFA10-D535-11D1-87C8-00A0C9223196")]
[NativeTypeName("struct IOverlayNotify2 : IOverlayNotify")]
[NativeInheritance("IOverlayNotify")]
public unsafe partial struct IOverlayNotify2 : IOverlayNotify2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOverlayNotify2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOverlayNotify2*, Guid*, void**, int>)(lpVtbl[0]))((IOverlayNotify2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOverlayNotify2*, uint>)(lpVtbl[1]))((IOverlayNotify2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOverlayNotify2*, uint>)(lpVtbl[2]))((IOverlayNotify2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IOverlayNotify.OnPaletteChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnPaletteChange([NativeTypeName("DWORD")] uint dwColors, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pPalette)
    {
        return ((delegate* unmanaged<IOverlayNotify2*, uint, PALETTEENTRY*, int>)(lpVtbl[3]))((IOverlayNotify2*)Unsafe.AsPointer(ref this), dwColors, pPalette);
    }

    /// <inheritdoc cref="IOverlayNotify.OnClipChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnClipChange([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestinationRect, [NativeTypeName("const RGNDATA *")] RGNDATA* pRgnData)
    {
        return ((delegate* unmanaged<IOverlayNotify2*, RECT*, RECT*, RGNDATA*, int>)(lpVtbl[4]))((IOverlayNotify2*)Unsafe.AsPointer(ref this), pSourceRect, pDestinationRect, pRgnData);
    }

    /// <inheritdoc cref="IOverlayNotify.OnColorKeyChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnColorKeyChange([NativeTypeName("const COLORKEY *")] COLORKEY* pColorKey)
    {
        return ((delegate* unmanaged<IOverlayNotify2*, COLORKEY*, int>)(lpVtbl[5]))((IOverlayNotify2*)Unsafe.AsPointer(ref this), pColorKey);
    }

    /// <inheritdoc cref="IOverlayNotify.OnPositionChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnPositionChange([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestinationRect)
    {
        return ((delegate* unmanaged<IOverlayNotify2*, RECT*, RECT*, int>)(lpVtbl[6]))((IOverlayNotify2*)Unsafe.AsPointer(ref this), pSourceRect, pDestinationRect);
    }

    /// <include file='IOverlayNotify2.xml' path='doc/member[@name="IOverlayNotify2.OnDisplayChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnDisplayChange(HMONITOR hMonitor)
    {
        return ((delegate* unmanaged<IOverlayNotify2*, HMONITOR, int>)(lpVtbl[7]))((IOverlayNotify2*)Unsafe.AsPointer(ref this), hMonitor);
    }

    public interface Interface : IOverlayNotify.Interface
    {
        [VtblIndex(7)]
        HRESULT OnDisplayChange(HMONITOR hMonitor);
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

        [NativeTypeName("HRESULT (DWORD, const PALETTEENTRY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PALETTEENTRY*, int> OnPaletteChange;

        [NativeTypeName("HRESULT (const RECT *, const RECT *, const RGNDATA *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, RGNDATA*, int> OnClipChange;

        [NativeTypeName("HRESULT (const COLORKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORKEY*, int> OnColorKeyChange;

        [NativeTypeName("HRESULT (const RECT *, const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, int> OnPositionChange;

        [NativeTypeName("HRESULT (HMONITOR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMONITOR, int> OnDisplayChange;
    }
}
