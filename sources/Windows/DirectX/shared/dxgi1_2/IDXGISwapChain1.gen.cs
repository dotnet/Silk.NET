// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1"]/*'/>
[Guid("790A45F7-0D42-4876-983A-0A55CFE6F4AA")]
[NativeTypeName("struct IDXGISwapChain1 : IDXGISwapChain")]
[NativeInheritance("IDXGISwapChain")]
public unsafe partial struct IDXGISwapChain1 : IDXGISwapChain1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChain1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, void**, int> )(lpVtbl[0]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, uint> )(lpVtbl[1]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, uint> )(lpVtbl[2]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, uint, void*, int> )(lpVtbl[3]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, IUnknown*, int> )(lpVtbl[4]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, pUnknown);
    }

    /// <inheritdoc cref = "IDXGIObject.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, uint*, void*, int> )(lpVtbl[5]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.GetParent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, void**, int> )(lpVtbl[6]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppParent);
    }

    /// <inheritdoc cref = "IDXGIDeviceSubObject.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, void**, int> )(lpVtbl[7]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppDevice);
    }

    /// <inheritdoc cref = "IDXGISwapChain.Present"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Present(uint SyncInterval, uint Flags)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, uint, uint, int> )(lpVtbl[8]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
    }

    /// <inheritdoc cref = "IDXGISwapChain.GetBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBuffer(uint Buffer, [NativeTypeName("const IID &")] Guid* riid, void** ppSurface)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, uint, Guid*, void**, int> )(lpVtbl[9]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
    }

    /// <inheritdoc cref = "IDXGISwapChain.SetFullscreenState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetFullscreenState(BOOL Fullscreen, IDXGIOutput* pTarget)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, BOOL, IDXGIOutput*, int> )(lpVtbl[10]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
    }

    /// <inheritdoc cref = "IDXGISwapChain.GetFullscreenState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFullscreenState(BOOL* pFullscreen, IDXGIOutput** ppTarget)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, BOOL*, IDXGIOutput**, int> )(lpVtbl[11]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
    }

    /// <inheritdoc cref = "IDXGISwapChain.GetDesc"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetDesc(DXGI_SWAP_CHAIN_DESC* pDesc)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, DXGI_SWAP_CHAIN_DESC*, int> )(lpVtbl[12]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <inheritdoc cref = "IDXGISwapChain.ResizeBuffers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ResizeBuffers(uint BufferCount, uint Width, uint Height, DXGI_FORMAT NewFormat, uint SwapChainFlags)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, uint, uint, uint, DXGI_FORMAT, uint, int> )(lpVtbl[13]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
    }

    /// <inheritdoc cref = "IDXGISwapChain.ResizeTarget"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ResizeTarget([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pNewTargetParameters)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, DXGI_MODE_DESC*, int> )(lpVtbl[14]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pNewTargetParameters);
    }

    /// <inheritdoc cref = "IDXGISwapChain.GetContainingOutput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetContainingOutput(IDXGIOutput** ppOutput)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, IDXGIOutput**, int> )(lpVtbl[15]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), ppOutput);
    }

    /// <inheritdoc cref = "IDXGISwapChain.GetFrameStatistics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, DXGI_FRAME_STATISTICS*, int> )(lpVtbl[16]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pStats);
    }

    /// <inheritdoc cref = "IDXGISwapChain.GetLastPresentCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetLastPresentCount(uint* pLastPresentCount)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, uint*, int> )(lpVtbl[17]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pLastPresentCount);
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetDesc1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetDesc1(DXGI_SWAP_CHAIN_DESC1* pDesc)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, DXGI_SWAP_CHAIN_DESC1*, int> )(lpVtbl[18]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetFullscreenDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFullscreenDesc(DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, int> )(lpVtbl[19]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetHwnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetHwnd(HWND* pHwnd)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, HWND*, int> )(lpVtbl[20]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pHwnd);
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetCoreWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetCoreWindow([NativeTypeName("const IID &")] Guid* refiid, void** ppUnk)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, Guid*, void**, int> )(lpVtbl[21]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), refiid, ppUnk);
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.Present1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT Present1(uint SyncInterval, uint PresentFlags, [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")] DXGI_PRESENT_PARAMETERS* pPresentParameters)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, uint, uint, DXGI_PRESENT_PARAMETERS*, int> )(lpVtbl[22]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), SyncInterval, PresentFlags, pPresentParameters);
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.IsTemporaryMonoSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public BOOL IsTemporaryMonoSupported()
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, int> )(lpVtbl[23]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetRestrictToOutput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, IDXGIOutput**, int> )(lpVtbl[24]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), ppRestrictToOutput);
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.SetBackgroundColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] DXGI_RGBA* pColor)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, DXGI_RGBA*, int> )(lpVtbl[25]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pColor);
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetBackgroundColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetBackgroundColor(DXGI_RGBA* pColor)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, DXGI_RGBA*, int> )(lpVtbl[26]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pColor);
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.SetRotation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetRotation(DXGI_MODE_ROTATION Rotation)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, DXGI_MODE_ROTATION, int> )(lpVtbl[27]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Rotation);
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetRotation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetRotation(DXGI_MODE_ROTATION* pRotation)
    {
        return ((delegate* unmanaged<IDXGISwapChain1*, DXGI_MODE_ROTATION*, int> )(lpVtbl[28]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pRotation);
    }

    public interface Interface : IDXGISwapChain.Interface
    {
        [VtblIndex(18)]
        HRESULT GetDesc1(DXGI_SWAP_CHAIN_DESC1* pDesc);
        [VtblIndex(19)]
        HRESULT GetFullscreenDesc(DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc);
        [VtblIndex(20)]
        HRESULT GetHwnd(HWND* pHwnd);
        [VtblIndex(21)]
        HRESULT GetCoreWindow([NativeTypeName("const IID &")] Guid* refiid, void** ppUnk);
        [VtblIndex(22)]
        HRESULT Present1(uint SyncInterval, uint PresentFlags, [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")] DXGI_PRESENT_PARAMETERS* pPresentParameters);
        [VtblIndex(23)]
        BOOL IsTemporaryMonoSupported();
        [VtblIndex(24)]
        HRESULT GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput);
        [VtblIndex(25)]
        HRESULT SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] DXGI_RGBA* pColor);
        [VtblIndex(26)]
        HRESULT GetBackgroundColor(DXGI_RGBA* pColor);
        [VtblIndex(27)]
        HRESULT SetRotation(DXGI_MODE_ROTATION Rotation);
        [VtblIndex(28)]
        HRESULT GetRotation(DXGI_MODE_ROTATION* pRotation);
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
        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetParent;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;
        [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> Present;
        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetBuffer;
        [NativeTypeName("HRESULT (BOOL, IDXGIOutput *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, IDXGIOutput*, int> SetFullscreenState;
        [NativeTypeName("HRESULT (BOOL *, IDXGIOutput **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, IDXGIOutput**, int> GetFullscreenState;
        [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_SWAP_CHAIN_DESC*, int> GetDesc;
        [NativeTypeName("HRESULT (UINT, UINT, UINT, DXGI_FORMAT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, DXGI_FORMAT, uint, int> ResizeBuffers;
        [NativeTypeName("HRESULT (const DXGI_MODE_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MODE_DESC*, int> ResizeTarget;
        [NativeTypeName("HRESULT (IDXGIOutput **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIOutput**, int> GetContainingOutput;
        [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FRAME_STATISTICS*, int> GetFrameStatistics;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLastPresentCount;
        [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_DESC1 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_SWAP_CHAIN_DESC1*, int> GetDesc1;
        [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_FULLSCREEN_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, int> GetFullscreenDesc;
        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetHwnd;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetCoreWindow;
        [NativeTypeName("HRESULT (UINT, UINT, const DXGI_PRESENT_PARAMETERS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, DXGI_PRESENT_PARAMETERS*, int> Present1;
        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsTemporaryMonoSupported;
        [NativeTypeName("HRESULT (IDXGIOutput **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIOutput**, int> GetRestrictToOutput;
        [NativeTypeName("HRESULT (const DXGI_RGBA *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_RGBA*, int> SetBackgroundColor;
        [NativeTypeName("HRESULT (DXGI_RGBA *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_RGBA*, int> GetBackgroundColor;
        [NativeTypeName("HRESULT (DXGI_MODE_ROTATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MODE_ROTATION, int> SetRotation;
        [NativeTypeName("HRESULT (DXGI_MODE_ROTATION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MODE_ROTATION*, int> GetRotation;
    }
}