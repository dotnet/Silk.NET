// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B92B56A9-8B55-4E14-9A89-0199BBB6F93B")]
[NativeTypeName("struct IDesktopWallpaper : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDesktopWallpaper : IDesktopWallpaper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDesktopWallpaper));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDesktopWallpaper, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDesktopWallpaper, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDesktopWallpaper, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetWallpaper(
        [NativeTypeName("LPCWSTR")] ushort* monitorID,
        [NativeTypeName("LPCWSTR")] ushort* wallpaper
    )
    {
        return ((delegate* unmanaged<IDesktopWallpaper, ushort*, ushort*, int>)((*lpVtbl)[3]))(
            this,
            monitorID,
            wallpaper
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetWallpaper(
        [NativeTypeName("LPCWSTR")] ushort* monitorID,
        [NativeTypeName("LPWSTR *")] ushort** wallpaper
    )
    {
        return ((delegate* unmanaged<IDesktopWallpaper, ushort*, ushort**, int>)((*lpVtbl)[4]))(
            this,
            monitorID,
            wallpaper
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMonitorDevicePathAt(
        uint monitorIndex,
        [NativeTypeName("LPWSTR *")] ushort** monitorID
    )
    {
        return ((delegate* unmanaged<IDesktopWallpaper, uint, ushort**, int>)((*lpVtbl)[5]))(
            this,
            monitorIndex,
            monitorID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMonitorDevicePathCount(uint* count)
    {
        return ((delegate* unmanaged<IDesktopWallpaper, uint*, int>)((*lpVtbl)[6]))(this, count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMonitorRECT([NativeTypeName("LPCWSTR")] ushort* monitorID, RECT* displayRect)
    {
        return ((delegate* unmanaged<IDesktopWallpaper, ushort*, RECT*, int>)((*lpVtbl)[7]))(
            this,
            monitorID,
            displayRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetBackgroundColor(COLORREF color)
    {
        return ((delegate* unmanaged<IDesktopWallpaper, COLORREF, int>)((*lpVtbl)[8]))(this, color);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBackgroundColor(COLORREF* color)
    {
        return ((delegate* unmanaged<IDesktopWallpaper, COLORREF*, int>)((*lpVtbl)[9]))(
            this,
            color
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPosition(DESKTOP_WALLPAPER_POSITION position)
    {
        return (
            (delegate* unmanaged<IDesktopWallpaper, DESKTOP_WALLPAPER_POSITION, int>)((*lpVtbl)[10])
        )(this, position);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPosition(DESKTOP_WALLPAPER_POSITION* position)
    {
        return (
            (delegate* unmanaged<IDesktopWallpaper, DESKTOP_WALLPAPER_POSITION*, int>)(
                (*lpVtbl)[11]
            )
        )(this, position);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetSlideshow(IShellItemArray items)
    {
        return ((delegate* unmanaged<IDesktopWallpaper, IShellItemArray, int>)((*lpVtbl)[12]))(
            this,
            items
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetSlideshow(IShellItemArray* items)
    {
        return ((delegate* unmanaged<IDesktopWallpaper, IShellItemArray*, int>)((*lpVtbl)[13]))(
            this,
            items
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS options, uint slideshowTick)
    {
        return (
            (delegate* unmanaged<IDesktopWallpaper, DESKTOP_SLIDESHOW_OPTIONS, uint, int>)(
                (*lpVtbl)[14]
            )
        )(this, options, slideshowTick);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS* options, uint* slideshowTick)
    {
        return (
            (delegate* unmanaged<IDesktopWallpaper, DESKTOP_SLIDESHOW_OPTIONS*, uint*, int>)(
                (*lpVtbl)[15]
            )
        )(this, options, slideshowTick);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AdvanceSlideshow(
        [NativeTypeName("LPCWSTR")] ushort* monitorID,
        DESKTOP_SLIDESHOW_DIRECTION direction
    )
    {
        return (
            (delegate* unmanaged<IDesktopWallpaper, ushort*, DESKTOP_SLIDESHOW_DIRECTION, int>)(
                (*lpVtbl)[16]
            )
        )(this, monitorID, direction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetStatus(DESKTOP_SLIDESHOW_STATE* state)
    {
        return (
            (delegate* unmanaged<IDesktopWallpaper, DESKTOP_SLIDESHOW_STATE*, int>)((*lpVtbl)[17])
        )(this, state);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Enable(BOOL enable)
    {
        return ((delegate* unmanaged<IDesktopWallpaper, BOOL, int>)((*lpVtbl)[18]))(this, enable);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetWallpaper(
            [NativeTypeName("LPCWSTR")] ushort* monitorID,
            [NativeTypeName("LPCWSTR")] ushort* wallpaper
        );

        [VtblIndex(4)]
        HRESULT GetWallpaper(
            [NativeTypeName("LPCWSTR")] ushort* monitorID,
            [NativeTypeName("LPWSTR *")] ushort** wallpaper
        );

        [VtblIndex(5)]
        HRESULT GetMonitorDevicePathAt(
            uint monitorIndex,
            [NativeTypeName("LPWSTR *")] ushort** monitorID
        );

        [VtblIndex(6)]
        HRESULT GetMonitorDevicePathCount(uint* count);

        [VtblIndex(7)]
        HRESULT GetMonitorRECT([NativeTypeName("LPCWSTR")] ushort* monitorID, RECT* displayRect);

        [VtblIndex(8)]
        HRESULT SetBackgroundColor(COLORREF color);

        [VtblIndex(9)]
        HRESULT GetBackgroundColor(COLORREF* color);

        [VtblIndex(10)]
        HRESULT SetPosition(DESKTOP_WALLPAPER_POSITION position);

        [VtblIndex(11)]
        HRESULT GetPosition(DESKTOP_WALLPAPER_POSITION* position);

        [VtblIndex(12)]
        HRESULT SetSlideshow(IShellItemArray items);

        [VtblIndex(13)]
        HRESULT GetSlideshow(IShellItemArray* items);

        [VtblIndex(14)]
        HRESULT SetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS options, uint slideshowTick);

        [VtblIndex(15)]
        HRESULT GetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS* options, uint* slideshowTick);

        [VtblIndex(16)]
        HRESULT AdvanceSlideshow(
            [NativeTypeName("LPCWSTR")] ushort* monitorID,
            DESKTOP_SLIDESHOW_DIRECTION direction
        );

        [VtblIndex(17)]
        HRESULT GetStatus(DESKTOP_SLIDESHOW_STATE* state);

        [VtblIndex(18)]
        HRESULT Enable(BOOL enable);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> SetWallpaper;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> GetWallpaper;

        [NativeTypeName("HRESULT (UINT, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetMonitorDevicePathAt;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMonitorDevicePathCount;

        [NativeTypeName("HRESULT (LPCWSTR, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, RECT*, int> GetMonitorRECT;

        [NativeTypeName("HRESULT (COLORREF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF, int> SetBackgroundColor;

        [NativeTypeName("HRESULT (COLORREF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF*, int> GetBackgroundColor;

        [NativeTypeName("HRESULT (DESKTOP_WALLPAPER_POSITION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DESKTOP_WALLPAPER_POSITION, int> SetPosition;

        [NativeTypeName("HRESULT (DESKTOP_WALLPAPER_POSITION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DESKTOP_WALLPAPER_POSITION*, int> GetPosition;

        [NativeTypeName("HRESULT (IShellItemArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray, int> SetSlideshow;

        [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray*, int> GetSlideshow;

        [NativeTypeName("HRESULT (DESKTOP_SLIDESHOW_OPTIONS, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            DESKTOP_SLIDESHOW_OPTIONS,
            uint,
            int> SetSlideshowOptions;

        [NativeTypeName("HRESULT (DESKTOP_SLIDESHOW_OPTIONS *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            DESKTOP_SLIDESHOW_OPTIONS*,
            uint*,
            int> GetSlideshowOptions;

        [NativeTypeName("HRESULT (LPCWSTR, DESKTOP_SLIDESHOW_DIRECTION) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            DESKTOP_SLIDESHOW_DIRECTION,
            int> AdvanceSlideshow;

        [NativeTypeName("HRESULT (DESKTOP_SLIDESHOW_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DESKTOP_SLIDESHOW_STATE*, int> GetStatus;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Enable;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDesktopWallpaper"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDesktopWallpaper(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDesktopWallpaper"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDesktopWallpaper(Silk.NET.Windows.IUnknown value)
    {
        return new IDesktopWallpaper(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDesktopWallpaper"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDesktopWallpaper"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDesktopWallpaper value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
