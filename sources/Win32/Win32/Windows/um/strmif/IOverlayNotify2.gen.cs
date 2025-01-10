// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("680EFA10-D535-11D1-87C8-00A0C9223196")]
[NativeTypeName("struct IOverlayNotify2 : IOverlayNotify")]
[NativeInheritance("IOverlayNotify")]
public unsafe partial struct IOverlayNotify2 : IOverlayNotify2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOverlayNotify2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOverlayNotify2, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOverlayNotify2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOverlayNotify2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnPaletteChange(
        [NativeTypeName("DWORD")] uint dwColors,
        [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pPalette
    )
    {
        return ((delegate* unmanaged<IOverlayNotify2, uint, PALETTEENTRY*, int>)((*lpVtbl)[3]))(
            this,
            dwColors,
            pPalette
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnClipChange(
        [NativeTypeName("const RECT *")] RECT* pSourceRect,
        [NativeTypeName("const RECT *")] RECT* pDestinationRect,
        [NativeTypeName("const RGNDATA *")] RGNDATA* pRgnData
    )
    {
        return ((delegate* unmanaged<IOverlayNotify2, RECT*, RECT*, RGNDATA*, int>)((*lpVtbl)[4]))(
            this,
            pSourceRect,
            pDestinationRect,
            pRgnData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnColorKeyChange([NativeTypeName("const COLORKEY *")] COLORKEY* pColorKey)
    {
        return ((delegate* unmanaged<IOverlayNotify2, COLORKEY*, int>)((*lpVtbl)[5]))(
            this,
            pColorKey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnPositionChange(
        [NativeTypeName("const RECT *")] RECT* pSourceRect,
        [NativeTypeName("const RECT *")] RECT* pDestinationRect
    )
    {
        return ((delegate* unmanaged<IOverlayNotify2, RECT*, RECT*, int>)((*lpVtbl)[6]))(
            this,
            pSourceRect,
            pDestinationRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnDisplayChange(HMONITOR hMonitor)
    {
        return ((delegate* unmanaged<IOverlayNotify2, HMONITOR, int>)((*lpVtbl)[7]))(
            this,
            hMonitor
        );
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

        [NativeTypeName(
            "HRESULT (const RECT *, const RECT *, const RGNDATA *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, RGNDATA*, int> OnClipChange;

        [NativeTypeName("HRESULT (const COLORKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORKEY*, int> OnColorKeyChange;

        [NativeTypeName("HRESULT (const RECT *, const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, int> OnPositionChange;

        [NativeTypeName("HRESULT (HMONITOR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMONITOR, int> OnDisplayChange;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOverlayNotify2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOverlayNotify2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOverlayNotify"/> to <see cref = "IOverlayNotify2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOverlayNotify"/> instance to be converted </param>
    public static explicit operator IOverlayNotify2(Silk.NET.Windows.IOverlayNotify value)
    {
        return new IOverlayNotify2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOverlayNotify2"/> to <see cref = "Silk.NET.Windows.IOverlayNotify"/>.</summary>
    /// <param name = "value">The <see cref = "IOverlayNotify2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOverlayNotify(IOverlayNotify2 value)
    {
        return new Silk.NET.Windows.IOverlayNotify(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOverlayNotify2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOverlayNotify2(Silk.NET.Windows.IUnknown value)
    {
        return new IOverlayNotify2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOverlayNotify2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOverlayNotify2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOverlayNotify2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
