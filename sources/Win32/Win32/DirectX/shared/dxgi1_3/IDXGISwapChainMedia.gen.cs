// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("DD95B90B-F05F-4F6A-BD65-25BFB264BD84")]
[NativeTypeName("struct IDXGISwapChainMedia : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDXGISwapChainMedia : IDXGISwapChainMedia.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChainMedia));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGISwapChainMedia, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGISwapChainMedia, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGISwapChainMedia, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFrameStatisticsMedia(DXGI_FRAME_STATISTICS_MEDIA* pStats)
    {
        return (
            (delegate* unmanaged<IDXGISwapChainMedia, DXGI_FRAME_STATISTICS_MEDIA*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pStats);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPresentDuration(uint Duration)
    {
        return ((delegate* unmanaged<IDXGISwapChainMedia, uint, int>)((*lpVtbl)[4]))(
            this,
            Duration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CheckPresentDurationSupport(
        uint DesiredPresentDuration,
        uint* pClosestSmallerPresentDuration,
        uint* pClosestLargerPresentDuration
    )
    {
        return ((delegate* unmanaged<IDXGISwapChainMedia, uint, uint*, uint*, int>)((*lpVtbl)[5]))(
            this,
            DesiredPresentDuration,
            pClosestSmallerPresentDuration,
            pClosestLargerPresentDuration
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFrameStatisticsMedia(DXGI_FRAME_STATISTICS_MEDIA* pStats);

        [VtblIndex(4)]
        HRESULT SetPresentDuration(uint Duration);

        [VtblIndex(5)]
        HRESULT CheckPresentDurationSupport(
            uint DesiredPresentDuration,
            uint* pClosestSmallerPresentDuration,
            uint* pClosestLargerPresentDuration
        );
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

        [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS_MEDIA *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            DXGI_FRAME_STATISTICS_MEDIA*,
            int> GetFrameStatisticsMedia;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetPresentDuration;

        [NativeTypeName("HRESULT (UINT, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint*, int> CheckPresentDurationSupport;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGISwapChainMedia"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGISwapChainMedia(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGISwapChainMedia"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGISwapChainMedia(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGISwapChainMedia(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISwapChainMedia"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISwapChainMedia"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGISwapChainMedia value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
