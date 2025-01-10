// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("310D36A0-D2E7-4C0A-AA04-6A9D23B8886A")]
[NativeTypeName("struct IDXGISwapChain : IDXGIDeviceSubObject")]
[NativeInheritance("IDXGIDeviceSubObject")]
public unsafe partial struct IDXGISwapChain : IDXGISwapChain.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChain));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGISwapChain, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGISwapChain, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGISwapChain, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<IDXGISwapChain, Guid*, uint, void*, int>)((*lpVtbl)[3]))(
            this,
            Name,
            DataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* Name,
        [NativeTypeName("const IUnknown *")] IUnknown pUnknown
    )
    {
        return ((delegate* unmanaged<IDXGISwapChain, Guid*, IUnknown, int>)((*lpVtbl)[4]))(
            this,
            Name,
            pUnknown
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<IDXGISwapChain, Guid*, uint*, void*, int>)((*lpVtbl)[5]))(
            this,
            Name,
            pDataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGISwapChain, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppParent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
    {
        return ((delegate* unmanaged<IDXGISwapChain, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Present(uint SyncInterval, uint Flags)
    {
        return ((delegate* unmanaged<IDXGISwapChain, uint, uint, int>)((*lpVtbl)[8]))(
            this,
            SyncInterval,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBuffer(
        uint Buffer,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppSurface
    )
    {
        return ((delegate* unmanaged<IDXGISwapChain, uint, Guid*, void**, int>)((*lpVtbl)[9]))(
            this,
            Buffer,
            riid,
            ppSurface
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetFullscreenState(BOOL Fullscreen, IDXGIOutput pTarget)
    {
        return ((delegate* unmanaged<IDXGISwapChain, BOOL, IDXGIOutput, int>)((*lpVtbl)[10]))(
            this,
            Fullscreen,
            pTarget
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFullscreenState(BOOL* pFullscreen, IDXGIOutput* ppTarget)
    {
        return ((delegate* unmanaged<IDXGISwapChain, BOOL*, IDXGIOutput*, int>)((*lpVtbl)[11]))(
            this,
            pFullscreen,
            ppTarget
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetDesc(DXGI_SWAP_CHAIN_DESC* pDesc)
    {
        return ((delegate* unmanaged<IDXGISwapChain, DXGI_SWAP_CHAIN_DESC*, int>)((*lpVtbl)[12]))(
            this,
            pDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ResizeBuffers(
        uint BufferCount,
        uint Width,
        uint Height,
        DXGI_FORMAT NewFormat,
        uint SwapChainFlags
    )
    {
        return (
            (delegate* unmanaged<IDXGISwapChain, uint, uint, uint, DXGI_FORMAT, uint, int>)(
                (*lpVtbl)[13]
            )
        )(this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ResizeTarget(
        [NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pNewTargetParameters
    )
    {
        return ((delegate* unmanaged<IDXGISwapChain, DXGI_MODE_DESC*, int>)((*lpVtbl)[14]))(
            this,
            pNewTargetParameters
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetContainingOutput(IDXGIOutput* ppOutput)
    {
        return ((delegate* unmanaged<IDXGISwapChain, IDXGIOutput*, int>)((*lpVtbl)[15]))(
            this,
            ppOutput
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
    {
        return ((delegate* unmanaged<IDXGISwapChain, DXGI_FRAME_STATISTICS*, int>)((*lpVtbl)[16]))(
            this,
            pStats
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetLastPresentCount(uint* pLastPresentCount)
    {
        return ((delegate* unmanaged<IDXGISwapChain, uint*, int>)((*lpVtbl)[17]))(
            this,
            pLastPresentCount
        );
    }

    public interface Interface : IDXGIDeviceSubObject.Interface
    {
        [VtblIndex(8)]
        HRESULT Present(uint SyncInterval, uint Flags);

        [VtblIndex(9)]
        HRESULT GetBuffer(
            uint Buffer,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppSurface
        );

        [VtblIndex(10)]
        HRESULT SetFullscreenState(BOOL Fullscreen, IDXGIOutput pTarget);

        [VtblIndex(11)]
        HRESULT GetFullscreenState(BOOL* pFullscreen, IDXGIOutput* ppTarget);

        [VtblIndex(12)]
        HRESULT GetDesc(DXGI_SWAP_CHAIN_DESC* pDesc);

        [VtblIndex(13)]
        HRESULT ResizeBuffers(
            uint BufferCount,
            uint Width,
            uint Height,
            DXGI_FORMAT NewFormat,
            uint SwapChainFlags
        );

        [VtblIndex(14)]
        HRESULT ResizeTarget(
            [NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pNewTargetParameters
        );

        [VtblIndex(15)]
        HRESULT GetContainingOutput(IDXGIOutput* ppOutput);

        [VtblIndex(16)]
        HRESULT GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats);

        [VtblIndex(17)]
        HRESULT GetLastPresentCount(uint* pLastPresentCount);
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
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

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
        public delegate* unmanaged<TSelf*, BOOL, IDXGIOutput, int> SetFullscreenState;

        [NativeTypeName("HRESULT (BOOL *, IDXGIOutput **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, IDXGIOutput*, int> GetFullscreenState;

        [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_SWAP_CHAIN_DESC*, int> GetDesc;

        [NativeTypeName("HRESULT (UINT, UINT, UINT, DXGI_FORMAT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, DXGI_FORMAT, uint, int> ResizeBuffers;

        [NativeTypeName("HRESULT (const DXGI_MODE_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MODE_DESC*, int> ResizeTarget;

        [NativeTypeName("HRESULT (IDXGIOutput **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIOutput*, int> GetContainingOutput;

        [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FRAME_STATISTICS*, int> GetFrameStatistics;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLastPresentCount;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGISwapChain"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGISwapChain(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIDeviceSubObject"/> to <see cref = "IDXGISwapChain"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIDeviceSubObject"/> instance to be converted </param>
    public static explicit operator IDXGISwapChain(Silk.NET.DirectX.IDXGIDeviceSubObject value)
    {
        return new IDXGISwapChain(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISwapChain"/> to <see cref = "Silk.NET.DirectX.IDXGIDeviceSubObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISwapChain"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIDeviceSubObject(IDXGISwapChain value)
    {
        return new Silk.NET.DirectX.IDXGIDeviceSubObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIObject"/> to <see cref = "IDXGISwapChain"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIObject"/> instance to be converted </param>
    public static explicit operator IDXGISwapChain(Silk.NET.DirectX.IDXGIObject value)
    {
        return new IDXGISwapChain(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISwapChain"/> to <see cref = "Silk.NET.DirectX.IDXGIObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISwapChain"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIObject(IDXGISwapChain value)
    {
        return new Silk.NET.DirectX.IDXGIObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGISwapChain"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGISwapChain(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGISwapChain(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISwapChain"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISwapChain"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGISwapChain value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
