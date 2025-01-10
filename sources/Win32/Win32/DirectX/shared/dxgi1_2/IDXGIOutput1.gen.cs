// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("00CDDEA8-939B-4B83-A340-A685226666CC")]
[NativeTypeName("struct IDXGIOutput1 : IDXGIOutput")]
[NativeInheritance("IDXGIOutput")]
public unsafe partial struct IDXGIOutput1 : IDXGIOutput1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIOutput1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIOutput1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGIOutput1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIOutput1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<IDXGIOutput1, Guid*, uint, void*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<IDXGIOutput1, Guid*, IUnknown, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<IDXGIOutput1, Guid*, uint*, void*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IDXGIOutput1, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppParent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDesc(DXGI_OUTPUT_DESC* pDesc)
    {
        return ((delegate* unmanaged<IDXGIOutput1, DXGI_OUTPUT_DESC*, int>)((*lpVtbl)[7]))(
            this,
            pDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDisplayModeList(
        DXGI_FORMAT EnumFormat,
        uint Flags,
        uint* pNumModes,
        DXGI_MODE_DESC* pDesc
    )
    {
        return (
            (delegate* unmanaged<IDXGIOutput1, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC*, int>)(
                (*lpVtbl)[8]
            )
        )(this, EnumFormat, Flags, pNumModes, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindClosestMatchingMode(
        [NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pModeToMatch,
        DXGI_MODE_DESC* pClosestMatch,
        IUnknown pConcernedDevice
    )
    {
        return (
            (delegate* unmanaged<IDXGIOutput1, DXGI_MODE_DESC*, DXGI_MODE_DESC*, IUnknown, int>)(
                (*lpVtbl)[9]
            )
        )(this, pModeToMatch, pClosestMatch, pConcernedDevice);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT WaitForVBlank()
    {
        return ((delegate* unmanaged<IDXGIOutput1, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TakeOwnership(IUnknown pDevice, BOOL Exclusive)
    {
        return ((delegate* unmanaged<IDXGIOutput1, IUnknown, BOOL, int>)((*lpVtbl)[11]))(
            this,
            pDevice,
            Exclusive
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void ReleaseOwnership()
    {
        ((delegate* unmanaged<IDXGIOutput1, void>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGammaControlCapabilities(DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)
    {
        return (
            (delegate* unmanaged<IDXGIOutput1, DXGI_GAMMA_CONTROL_CAPABILITIES*, int>)(
                (*lpVtbl)[13]
            )
        )(this, pGammaCaps);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetGammaControl(
        [NativeTypeName("const DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray
    )
    {
        return ((delegate* unmanaged<IDXGIOutput1, DXGI_GAMMA_CONTROL*, int>)((*lpVtbl)[14]))(
            this,
            pArray
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetGammaControl(DXGI_GAMMA_CONTROL* pArray)
    {
        return ((delegate* unmanaged<IDXGIOutput1, DXGI_GAMMA_CONTROL*, int>)((*lpVtbl)[15]))(
            this,
            pArray
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetDisplaySurface(IDXGISurface pScanoutSurface)
    {
        return ((delegate* unmanaged<IDXGIOutput1, IDXGISurface, int>)((*lpVtbl)[16]))(
            this,
            pScanoutSurface
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetDisplaySurfaceData(IDXGISurface pDestination)
    {
        return ((delegate* unmanaged<IDXGIOutput1, IDXGISurface, int>)((*lpVtbl)[17]))(
            this,
            pDestination
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
    {
        return ((delegate* unmanaged<IDXGIOutput1, DXGI_FRAME_STATISTICS*, int>)((*lpVtbl)[18]))(
            this,
            pStats
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetDisplayModeList1(
        DXGI_FORMAT EnumFormat,
        uint Flags,
        uint* pNumModes,
        DXGI_MODE_DESC1* pDesc
    )
    {
        return (
            (delegate* unmanaged<IDXGIOutput1, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC1*, int>)(
                (*lpVtbl)[19]
            )
        )(this, EnumFormat, Flags, pNumModes, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT FindClosestMatchingMode1(
        [NativeTypeName("const DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pModeToMatch,
        DXGI_MODE_DESC1* pClosestMatch,
        IUnknown pConcernedDevice
    )
    {
        return (
            (delegate* unmanaged<IDXGIOutput1, DXGI_MODE_DESC1*, DXGI_MODE_DESC1*, IUnknown, int>)(
                (*lpVtbl)[20]
            )
        )(this, pModeToMatch, pClosestMatch, pConcernedDevice);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetDisplaySurfaceData1(IDXGIResource pDestination)
    {
        return ((delegate* unmanaged<IDXGIOutput1, IDXGIResource, int>)((*lpVtbl)[21]))(
            this,
            pDestination
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT DuplicateOutput(IUnknown pDevice, IDXGIOutputDuplication* ppOutputDuplication)
    {
        return (
            (delegate* unmanaged<IDXGIOutput1, IUnknown, IDXGIOutputDuplication*, int>)(
                (*lpVtbl)[22]
            )
        )(this, pDevice, ppOutputDuplication);
    }

    public interface Interface : IDXGIOutput.Interface
    {
        [VtblIndex(19)]
        HRESULT GetDisplayModeList1(
            DXGI_FORMAT EnumFormat,
            uint Flags,
            uint* pNumModes,
            DXGI_MODE_DESC1* pDesc
        );

        [VtblIndex(20)]
        HRESULT FindClosestMatchingMode1(
            [NativeTypeName("const DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pModeToMatch,
            DXGI_MODE_DESC1* pClosestMatch,
            IUnknown pConcernedDevice
        );

        [VtblIndex(21)]
        HRESULT GetDisplaySurfaceData1(IDXGIResource pDestination);

        [VtblIndex(22)]
        HRESULT DuplicateOutput(IUnknown pDevice, IDXGIOutputDuplication* ppOutputDuplication);
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

        [NativeTypeName("HRESULT (DXGI_OUTPUT_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_OUTPUT_DESC*, int> GetDesc;

        [NativeTypeName(
            "HRESULT (DXGI_FORMAT, UINT, UINT *, DXGI_MODE_DESC *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXGI_FORMAT,
            uint,
            uint*,
            DXGI_MODE_DESC*,
            int> GetDisplayModeList;

        [NativeTypeName(
            "HRESULT (const DXGI_MODE_DESC *, DXGI_MODE_DESC *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXGI_MODE_DESC*,
            DXGI_MODE_DESC*,
            IUnknown,
            int> FindClosestMatchingMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> WaitForVBlank;

        [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, BOOL, int> TakeOwnership;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> ReleaseOwnership;

        [NativeTypeName("HRESULT (DXGI_GAMMA_CONTROL_CAPABILITIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            DXGI_GAMMA_CONTROL_CAPABILITIES*,
            int> GetGammaControlCapabilities;

        [NativeTypeName("HRESULT (const DXGI_GAMMA_CONTROL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_GAMMA_CONTROL*, int> SetGammaControl;

        [NativeTypeName("HRESULT (DXGI_GAMMA_CONTROL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_GAMMA_CONTROL*, int> GetGammaControl;

        [NativeTypeName("HRESULT (IDXGISurface *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGISurface, int> SetDisplaySurface;

        [NativeTypeName("HRESULT (IDXGISurface *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGISurface, int> GetDisplaySurfaceData;

        [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FRAME_STATISTICS*, int> GetFrameStatistics;

        [NativeTypeName(
            "HRESULT (DXGI_FORMAT, UINT, UINT *, DXGI_MODE_DESC1 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXGI_FORMAT,
            uint,
            uint*,
            DXGI_MODE_DESC1*,
            int> GetDisplayModeList1;

        [NativeTypeName(
            "HRESULT (const DXGI_MODE_DESC1 *, DXGI_MODE_DESC1 *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXGI_MODE_DESC1*,
            DXGI_MODE_DESC1*,
            IUnknown,
            int> FindClosestMatchingMode1;

        [NativeTypeName("HRESULT (IDXGIResource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIResource, int> GetDisplaySurfaceData1;

        [NativeTypeName("HRESULT (IUnknown *, IDXGIOutputDuplication **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, IDXGIOutputDuplication*, int> DuplicateOutput;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGIOutput1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIOutput1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIOutput"/> to <see cref = "IDXGIOutput1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIOutput"/> instance to be converted </param>
    public static explicit operator IDXGIOutput1(Silk.NET.DirectX.IDXGIOutput value)
    {
        return new IDXGIOutput1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIOutput1"/> to <see cref = "Silk.NET.DirectX.IDXGIOutput"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIOutput1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIOutput(IDXGIOutput1 value)
    {
        return new Silk.NET.DirectX.IDXGIOutput(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIObject"/> to <see cref = "IDXGIOutput1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIObject"/> instance to be converted </param>
    public static explicit operator IDXGIOutput1(Silk.NET.DirectX.IDXGIObject value)
    {
        return new IDXGIOutput1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIOutput1"/> to <see cref = "Silk.NET.DirectX.IDXGIObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIOutput1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIObject(IDXGIOutput1 value)
    {
        return new Silk.NET.DirectX.IDXGIObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGIOutput1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGIOutput1(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGIOutput1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIOutput1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIOutput1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGIOutput1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
