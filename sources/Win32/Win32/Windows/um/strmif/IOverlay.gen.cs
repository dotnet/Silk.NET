// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A868A1-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IOverlay : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOverlay : IOverlay.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOverlay));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOverlay, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOverlay, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOverlay, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPalette([NativeTypeName("DWORD *")] uint* pdwColors, PALETTEENTRY** ppPalette)
    {
        return ((delegate* unmanaged<IOverlay, uint*, PALETTEENTRY**, int>)((*lpVtbl)[3]))(
            this,
            pdwColors,
            ppPalette
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPalette([NativeTypeName("DWORD")] uint dwColors, PALETTEENTRY* pPalette)
    {
        return ((delegate* unmanaged<IOverlay, uint, PALETTEENTRY*, int>)((*lpVtbl)[4]))(
            this,
            dwColors,
            pPalette
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDefaultColorKey(COLORKEY* pColorKey)
    {
        return ((delegate* unmanaged<IOverlay, COLORKEY*, int>)((*lpVtbl)[5]))(this, pColorKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetColorKey(COLORKEY* pColorKey)
    {
        return ((delegate* unmanaged<IOverlay, COLORKEY*, int>)((*lpVtbl)[6]))(this, pColorKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetColorKey(COLORKEY* pColorKey)
    {
        return ((delegate* unmanaged<IOverlay, COLORKEY*, int>)((*lpVtbl)[7]))(this, pColorKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWindowHandle(HWND* pHwnd)
    {
        return ((delegate* unmanaged<IOverlay, HWND*, int>)((*lpVtbl)[8]))(this, pHwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetClipList(RECT* pSourceRect, RECT* pDestinationRect, RGNDATA** ppRgnData)
    {
        return ((delegate* unmanaged<IOverlay, RECT*, RECT*, RGNDATA**, int>)((*lpVtbl)[9]))(
            this,
            pSourceRect,
            pDestinationRect,
            ppRgnData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetVideoPosition(RECT* pSourceRect, RECT* pDestinationRect)
    {
        return ((delegate* unmanaged<IOverlay, RECT*, RECT*, int>)((*lpVtbl)[10]))(
            this,
            pSourceRect,
            pDestinationRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Advise(IOverlayNotify pOverlayNotify, [NativeTypeName("DWORD")] uint dwInterests)
    {
        return ((delegate* unmanaged<IOverlay, IOverlayNotify, uint, int>)((*lpVtbl)[11]))(
            this,
            pOverlayNotify,
            dwInterests
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Unadvise()
    {
        return ((delegate* unmanaged<IOverlay, int>)((*lpVtbl)[12]))(this);
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
        HRESULT Advise(IOverlayNotify pOverlayNotify, [NativeTypeName("DWORD")] uint dwInterests);

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
        public delegate* unmanaged<TSelf*, IOverlayNotify, uint, int> Advise;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unadvise;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOverlay"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOverlay(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOverlay"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOverlay(Silk.NET.Windows.IUnknown value)
    {
        return new IOverlay(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOverlay"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOverlay"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOverlay value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
