// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("36D39EB0-DD75-11CE-BF0E-00AA0055595A")]
[NativeTypeName("struct IDirectDrawVideo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectDrawVideo : IDirectDrawVideo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectDrawVideo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirectDrawVideo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectDrawVideo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSwitches([NativeTypeName("DWORD *")] uint* pSwitches)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, uint*, int>)((*lpVtbl)[3]))(this, pSwitches);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSwitches([NativeTypeName("DWORD")] uint Switches)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, uint, int>)((*lpVtbl)[4]))(this, Switches);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCaps([NativeTypeName("DDCAPS *")] DDCAPS_DX7* pCaps)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, DDCAPS_DX7*, int>)((*lpVtbl)[5]))(
            this,
            pCaps
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEmulatedCaps([NativeTypeName("DDCAPS *")] DDCAPS_DX7* pCaps)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, DDCAPS_DX7*, int>)((*lpVtbl)[6]))(
            this,
            pCaps
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSurfaceDesc(DDSURFACEDESC* pSurfaceDesc)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, DDSURFACEDESC*, int>)((*lpVtbl)[7]))(
            this,
            pSurfaceDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFourCCCodes(
        [NativeTypeName("DWORD *")] uint* pCount,
        [NativeTypeName("DWORD *")] uint* pCodes
    )
    {
        return ((delegate* unmanaged<IDirectDrawVideo, uint*, uint*, int>)((*lpVtbl)[8]))(
            this,
            pCount,
            pCodes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetDirectDraw([NativeTypeName("LPDIRECTDRAW")] IDirectDraw pDirectDraw)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, IDirectDraw, int>)((*lpVtbl)[9]))(
            this,
            pDirectDraw
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDirectDraw([NativeTypeName("LPDIRECTDRAW *")] IDirectDraw* ppDirectDraw)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, IDirectDraw*, int>)((*lpVtbl)[10]))(
            this,
            ppDirectDraw
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSurfaceType([NativeTypeName("DWORD *")] uint* pSurfaceType)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, uint*, int>)((*lpVtbl)[11]))(
            this,
            pSurfaceType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetDefault()
    {
        return ((delegate* unmanaged<IDirectDrawVideo, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT UseScanLine([NativeTypeName("long")] int UseScanLine)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, int, int>)((*lpVtbl)[13]))(
            this,
            UseScanLine
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CanUseScanLine([NativeTypeName("long *")] int* UseScanLine)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, int*, int>)((*lpVtbl)[14]))(
            this,
            UseScanLine
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT UseOverlayStretch([NativeTypeName("long")] int UseOverlayStretch)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, int, int>)((*lpVtbl)[15]))(
            this,
            UseOverlayStretch
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CanUseOverlayStretch([NativeTypeName("long *")] int* UseOverlayStretch)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, int*, int>)((*lpVtbl)[16]))(
            this,
            UseOverlayStretch
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT UseWhenFullScreen([NativeTypeName("long")] int UseWhenFullScreen)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, int, int>)((*lpVtbl)[17]))(
            this,
            UseWhenFullScreen
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT WillUseFullScreen([NativeTypeName("long *")] int* UseWhenFullScreen)
    {
        return ((delegate* unmanaged<IDirectDrawVideo, int*, int>)((*lpVtbl)[18]))(
            this,
            UseWhenFullScreen
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSwitches([NativeTypeName("DWORD *")] uint* pSwitches);

        [VtblIndex(4)]
        HRESULT SetSwitches([NativeTypeName("DWORD")] uint Switches);

        [VtblIndex(5)]
        HRESULT GetCaps([NativeTypeName("DDCAPS *")] DDCAPS_DX7* pCaps);

        [VtblIndex(6)]
        HRESULT GetEmulatedCaps([NativeTypeName("DDCAPS *")] DDCAPS_DX7* pCaps);

        [VtblIndex(7)]
        HRESULT GetSurfaceDesc(DDSURFACEDESC* pSurfaceDesc);

        [VtblIndex(8)]
        HRESULT GetFourCCCodes(
            [NativeTypeName("DWORD *")] uint* pCount,
            [NativeTypeName("DWORD *")] uint* pCodes
        );

        [VtblIndex(9)]
        HRESULT SetDirectDraw([NativeTypeName("LPDIRECTDRAW")] IDirectDraw pDirectDraw);

        [VtblIndex(10)]
        HRESULT GetDirectDraw([NativeTypeName("LPDIRECTDRAW *")] IDirectDraw* ppDirectDraw);

        [VtblIndex(11)]
        HRESULT GetSurfaceType([NativeTypeName("DWORD *")] uint* pSurfaceType);

        [VtblIndex(12)]
        HRESULT SetDefault();

        [VtblIndex(13)]
        HRESULT UseScanLine([NativeTypeName("long")] int UseScanLine);

        [VtblIndex(14)]
        HRESULT CanUseScanLine([NativeTypeName("long *")] int* UseScanLine);

        [VtblIndex(15)]
        HRESULT UseOverlayStretch([NativeTypeName("long")] int UseOverlayStretch);

        [VtblIndex(16)]
        HRESULT CanUseOverlayStretch([NativeTypeName("long *")] int* UseOverlayStretch);

        [VtblIndex(17)]
        HRESULT UseWhenFullScreen([NativeTypeName("long")] int UseWhenFullScreen);

        [VtblIndex(18)]
        HRESULT WillUseFullScreen([NativeTypeName("long *")] int* UseWhenFullScreen);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSwitches;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetSwitches;

        [NativeTypeName("HRESULT (DDCAPS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDCAPS_DX7*, int> GetCaps;

        [NativeTypeName("HRESULT (DDCAPS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDCAPS_DX7*, int> GetEmulatedCaps;

        [NativeTypeName(
            "HRESULT (DDSURFACEDESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DDSURFACEDESC*, int> GetSurfaceDesc;

        [NativeTypeName(
            "HRESULT (DWORD *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetFourCCCodes;

        [NativeTypeName("HRESULT (LPDIRECTDRAW) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw, int> SetDirectDraw;

        [NativeTypeName(
            "HRESULT (LPDIRECTDRAW *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirectDraw*, int> GetDirectDraw;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSurfaceType;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetDefault;

        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> UseScanLine;

        [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> CanUseScanLine;

        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> UseOverlayStretch;

        [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> CanUseOverlayStretch;

        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> UseWhenFullScreen;

        [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> WillUseFullScreen;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectDrawVideo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectDrawVideo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectDrawVideo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectDrawVideo(Silk.NET.Windows.IUnknown value)
    {
        return new IDirectDrawVideo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectDrawVideo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectDrawVideo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirectDrawVideo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
