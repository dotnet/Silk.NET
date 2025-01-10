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

[Guid("A8BE2AC4-199F-4946-B331-79599FB98DE7")]
[NativeTypeName("struct IDXGISwapChain2 : IDXGISwapChain1")]
[NativeInheritance("IDXGISwapChain1")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDXGISwapChain2 : IDXGISwapChain2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChain2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGISwapChain2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGISwapChain2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<IDXGISwapChain2, Guid*, uint, void*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<IDXGISwapChain2, Guid*, IUnknown, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<IDXGISwapChain2, Guid*, uint*, void*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IDXGISwapChain2, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppParent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Present(uint SyncInterval, uint Flags)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, uint, uint, int>)((*lpVtbl)[8]))(
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
        return ((delegate* unmanaged<IDXGISwapChain2, uint, Guid*, void**, int>)((*lpVtbl)[9]))(
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
        return ((delegate* unmanaged<IDXGISwapChain2, BOOL, IDXGIOutput, int>)((*lpVtbl)[10]))(
            this,
            Fullscreen,
            pTarget
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFullscreenState(BOOL* pFullscreen, IDXGIOutput* ppTarget)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, BOOL*, IDXGIOutput*, int>)((*lpVtbl)[11]))(
            this,
            pFullscreen,
            ppTarget
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetDesc(DXGI_SWAP_CHAIN_DESC* pDesc)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, DXGI_SWAP_CHAIN_DESC*, int>)((*lpVtbl)[12]))(
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
            (delegate* unmanaged<IDXGISwapChain2, uint, uint, uint, DXGI_FORMAT, uint, int>)(
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
        return ((delegate* unmanaged<IDXGISwapChain2, DXGI_MODE_DESC*, int>)((*lpVtbl)[14]))(
            this,
            pNewTargetParameters
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetContainingOutput(IDXGIOutput* ppOutput)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, IDXGIOutput*, int>)((*lpVtbl)[15]))(
            this,
            ppOutput
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, DXGI_FRAME_STATISTICS*, int>)((*lpVtbl)[16]))(
            this,
            pStats
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetLastPresentCount(uint* pLastPresentCount)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, uint*, int>)((*lpVtbl)[17]))(
            this,
            pLastPresentCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetDesc1(DXGI_SWAP_CHAIN_DESC1* pDesc)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, DXGI_SWAP_CHAIN_DESC1*, int>)((*lpVtbl)[18]))(
            this,
            pDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFullscreenDesc(DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<IDXGISwapChain2, DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, int>)(
                (*lpVtbl)[19]
            )
        )(this, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetHwnd(HWND* pHwnd)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, HWND*, int>)((*lpVtbl)[20]))(this, pHwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetCoreWindow([NativeTypeName("const IID &")] Guid* refiid, void** ppUnk)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, Guid*, void**, int>)((*lpVtbl)[21]))(
            this,
            refiid,
            ppUnk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT Present1(
        uint SyncInterval,
        uint PresentFlags,
        [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")]
            DXGI_PRESENT_PARAMETERS* pPresentParameters
    )
    {
        return (
            (delegate* unmanaged<IDXGISwapChain2, uint, uint, DXGI_PRESENT_PARAMETERS*, int>)(
                (*lpVtbl)[22]
            )
        )(this, SyncInterval, PresentFlags, pPresentParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public BOOL IsTemporaryMonoSupported()
    {
        return ((delegate* unmanaged<IDXGISwapChain2, int>)((*lpVtbl)[23]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetRestrictToOutput(IDXGIOutput* ppRestrictToOutput)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, IDXGIOutput*, int>)((*lpVtbl)[24]))(
            this,
            ppRestrictToOutput
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] DXGI_RGBA* pColor)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, DXGI_RGBA*, int>)((*lpVtbl)[25]))(
            this,
            pColor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetBackgroundColor(DXGI_RGBA* pColor)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, DXGI_RGBA*, int>)((*lpVtbl)[26]))(
            this,
            pColor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetRotation(DXGI_MODE_ROTATION Rotation)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, DXGI_MODE_ROTATION, int>)((*lpVtbl)[27]))(
            this,
            Rotation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetRotation(DXGI_MODE_ROTATION* pRotation)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, DXGI_MODE_ROTATION*, int>)((*lpVtbl)[28]))(
            this,
            pRotation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetSourceSize(uint Width, uint Height)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, uint, uint, int>)((*lpVtbl)[29]))(
            this,
            Width,
            Height
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetSourceSize(uint* pWidth, uint* pHeight)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, uint*, uint*, int>)((*lpVtbl)[30]))(
            this,
            pWidth,
            pHeight
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetMaximumFrameLatency(uint MaxLatency)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, uint, int>)((*lpVtbl)[31]))(this, MaxLatency);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetMaximumFrameLatency(uint* pMaxLatency)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, uint*, int>)((*lpVtbl)[32]))(
            this,
            pMaxLatency
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HANDLE GetFrameLatencyWaitableObject()
    {
        return ((HANDLE)(((delegate* unmanaged<IDXGISwapChain2, void*>)((*lpVtbl)[33]))(this)));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT SetMatrixTransform(
        [NativeTypeName("const DXGI_MATRIX_3X2_F *")] DXGI_MATRIX_3X2_F* pMatrix
    )
    {
        return ((delegate* unmanaged<IDXGISwapChain2, DXGI_MATRIX_3X2_F*, int>)((*lpVtbl)[34]))(
            this,
            pMatrix
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetMatrixTransform(DXGI_MATRIX_3X2_F* pMatrix)
    {
        return ((delegate* unmanaged<IDXGISwapChain2, DXGI_MATRIX_3X2_F*, int>)((*lpVtbl)[35]))(
            this,
            pMatrix
        );
    }

    public interface Interface : IDXGISwapChain1.Interface
    {
        [VtblIndex(29)]
        HRESULT SetSourceSize(uint Width, uint Height);

        [VtblIndex(30)]
        HRESULT GetSourceSize(uint* pWidth, uint* pHeight);

        [VtblIndex(31)]
        HRESULT SetMaximumFrameLatency(uint MaxLatency);

        [VtblIndex(32)]
        HRESULT GetMaximumFrameLatency(uint* pMaxLatency);

        [VtblIndex(33)]
        HANDLE GetFrameLatencyWaitableObject();

        [VtblIndex(34)]
        HRESULT SetMatrixTransform(
            [NativeTypeName("const DXGI_MATRIX_3X2_F *")] DXGI_MATRIX_3X2_F* pMatrix
        );

        [VtblIndex(35)]
        HRESULT GetMatrixTransform(DXGI_MATRIX_3X2_F* pMatrix);
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

        [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_DESC1 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_SWAP_CHAIN_DESC1*, int> GetDesc1;

        [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_FULLSCREEN_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, int> GetFullscreenDesc;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetHwnd;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetCoreWindow;

        [NativeTypeName(
            "HRESULT (UINT, UINT, const DXGI_PRESENT_PARAMETERS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, DXGI_PRESENT_PARAMETERS*, int> Present1;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsTemporaryMonoSupported;

        [NativeTypeName("HRESULT (IDXGIOutput **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIOutput*, int> GetRestrictToOutput;

        [NativeTypeName("HRESULT (const DXGI_RGBA *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_RGBA*, int> SetBackgroundColor;

        [NativeTypeName("HRESULT (DXGI_RGBA *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_RGBA*, int> GetBackgroundColor;

        [NativeTypeName("HRESULT (DXGI_MODE_ROTATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MODE_ROTATION, int> SetRotation;

        [NativeTypeName("HRESULT (DXGI_MODE_ROTATION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MODE_ROTATION*, int> GetRotation;

        [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetSourceSize;

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetSourceSize;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetMaximumFrameLatency;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaximumFrameLatency;

        [NativeTypeName("HANDLE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetFrameLatencyWaitableObject;

        [NativeTypeName("HRESULT (const DXGI_MATRIX_3X2_F *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MATRIX_3X2_F*, int> SetMatrixTransform;

        [NativeTypeName("HRESULT (DXGI_MATRIX_3X2_F *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MATRIX_3X2_F*, int> GetMatrixTransform;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGISwapChain2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGISwapChain2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGISwapChain1"/> to <see cref = "IDXGISwapChain2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGISwapChain1"/> instance to be converted </param>
    public static explicit operator IDXGISwapChain2(Silk.NET.DirectX.IDXGISwapChain1 value)
    {
        return new IDXGISwapChain2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISwapChain2"/> to <see cref = "Silk.NET.DirectX.IDXGISwapChain1"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISwapChain2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGISwapChain1(IDXGISwapChain2 value)
    {
        return new Silk.NET.DirectX.IDXGISwapChain1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGISwapChain"/> to <see cref = "IDXGISwapChain2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGISwapChain"/> instance to be converted </param>
    public static explicit operator IDXGISwapChain2(Silk.NET.DirectX.IDXGISwapChain value)
    {
        return new IDXGISwapChain2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISwapChain2"/> to <see cref = "Silk.NET.DirectX.IDXGISwapChain"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISwapChain2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGISwapChain(IDXGISwapChain2 value)
    {
        return new Silk.NET.DirectX.IDXGISwapChain(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIDeviceSubObject"/> to <see cref = "IDXGISwapChain2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIDeviceSubObject"/> instance to be converted </param>
    public static explicit operator IDXGISwapChain2(Silk.NET.DirectX.IDXGIDeviceSubObject value)
    {
        return new IDXGISwapChain2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISwapChain2"/> to <see cref = "Silk.NET.DirectX.IDXGIDeviceSubObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISwapChain2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIDeviceSubObject(IDXGISwapChain2 value)
    {
        return new Silk.NET.DirectX.IDXGIDeviceSubObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIObject"/> to <see cref = "IDXGISwapChain2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIObject"/> instance to be converted </param>
    public static explicit operator IDXGISwapChain2(Silk.NET.DirectX.IDXGIObject value)
    {
        return new IDXGISwapChain2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISwapChain2"/> to <see cref = "Silk.NET.DirectX.IDXGIObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISwapChain2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIObject(IDXGISwapChain2 value)
    {
        return new Silk.NET.DirectX.IDXGIObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGISwapChain2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGISwapChain2(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGISwapChain2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGISwapChain2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGISwapChain2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGISwapChain2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
