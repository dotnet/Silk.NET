// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDXGISwapChainMedia.xml' path='doc/member[@name="IDXGISwapChainMedia"]/*'/>
[Guid("DD95B90B-F05F-4F6A-BD65-25BFB264BD84")]
[NativeTypeName("struct IDXGISwapChainMedia : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDXGISwapChainMedia : IDXGISwapChainMedia.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChainMedia));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGISwapChainMedia*, Guid*, void**, int> )(lpVtbl[0]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGISwapChainMedia*, uint> )(lpVtbl[1]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGISwapChainMedia*, uint> )(lpVtbl[2]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXGISwapChainMedia.xml' path='doc/member[@name="IDXGISwapChainMedia.GetFrameStatisticsMedia"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFrameStatisticsMedia(DXGI_FRAME_STATISTICS_MEDIA* pStats)
    {
        return ((delegate* unmanaged<IDXGISwapChainMedia*, DXGI_FRAME_STATISTICS_MEDIA*, int> )(lpVtbl[3]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), pStats);
    }

    /// <include file='IDXGISwapChainMedia.xml' path='doc/member[@name="IDXGISwapChainMedia.SetPresentDuration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPresentDuration(uint Duration)
    {
        return ((delegate* unmanaged<IDXGISwapChainMedia*, uint, int> )(lpVtbl[4]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), Duration);
    }

    /// <include file='IDXGISwapChainMedia.xml' path='doc/member[@name="IDXGISwapChainMedia.CheckPresentDurationSupport"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CheckPresentDurationSupport(uint DesiredPresentDuration, uint* pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration)
    {
        return ((delegate* unmanaged<IDXGISwapChainMedia*, uint, uint*, uint*, int> )(lpVtbl[5]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), DesiredPresentDuration, pClosestSmallerPresentDuration, pClosestLargerPresentDuration);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFrameStatisticsMedia(DXGI_FRAME_STATISTICS_MEDIA* pStats);
        [VtblIndex(4)]
        HRESULT SetPresentDuration(uint Duration);
        [VtblIndex(5)]
        HRESULT CheckPresentDurationSupport(uint DesiredPresentDuration, uint* pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration);
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
        public delegate* unmanaged<TSelf*, DXGI_FRAME_STATISTICS_MEDIA*, int> GetFrameStatisticsMedia;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetPresentDuration;
        [NativeTypeName("HRESULT (UINT, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint*, int> CheckPresentDurationSupport;
    }
}