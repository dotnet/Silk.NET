// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDXGIOutput4.xml' path='doc/member[@name="IDXGIOutput4"]/*'/>
[Guid("DC7DCA35-2196-414D-9F53-617884032A60")]
[NativeTypeName("struct IDXGIOutput4 : IDXGIOutput3")]
[NativeInheritance("IDXGIOutput3")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IDXGIOutput4 : IDXGIOutput4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIOutput4));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, Guid*, void**, int> )(lpVtbl[0]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIOutput4*, uint> )(lpVtbl[1]))((IDXGIOutput4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIOutput4*, uint> )(lpVtbl[2]))((IDXGIOutput4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint, void*, int> )(lpVtbl[3]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, Guid*, IUnknown*, int> )(lpVtbl[4]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), Name, pUnknown);
    }

    /// <inheritdoc cref = "IDXGIObject.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint*, void*, int> )(lpVtbl[5]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.GetParent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, Guid*, void**, int> )(lpVtbl[6]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), riid, ppParent);
    }

    /// <inheritdoc cref = "IDXGIOutput.GetDesc"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDesc(DXGI_OUTPUT_DESC* pDesc)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, DXGI_OUTPUT_DESC*, int> )(lpVtbl[7]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <inheritdoc cref = "IDXGIOutput.GetDisplayModeList"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDisplayModeList(DXGI_FORMAT EnumFormat, uint Flags, uint* pNumModes, DXGI_MODE_DESC* pDesc)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC*, int> )(lpVtbl[8]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
    }

    /// <inheritdoc cref = "IDXGIOutput.FindClosestMatchingMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindClosestMatchingMode([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pModeToMatch, DXGI_MODE_DESC* pClosestMatch, IUnknown* pConcernedDevice)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, DXGI_MODE_DESC*, DXGI_MODE_DESC*, IUnknown*, int> )(lpVtbl[9]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
    }

    /// <inheritdoc cref = "IDXGIOutput.WaitForVBlank"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT WaitForVBlank()
    {
        return ((delegate* unmanaged<IDXGIOutput4*, int> )(lpVtbl[10]))((IDXGIOutput4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIOutput.TakeOwnership"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TakeOwnership(IUnknown* pDevice, BOOL Exclusive)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, IUnknown*, BOOL, int> )(lpVtbl[11]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
    }

    /// <inheritdoc cref = "IDXGIOutput.ReleaseOwnership"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void ReleaseOwnership()
    {
        ((delegate* unmanaged<IDXGIOutput4*, void> )(lpVtbl[12]))((IDXGIOutput4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIOutput.GetGammaControlCapabilities"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGammaControlCapabilities(DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, DXGI_GAMMA_CONTROL_CAPABILITIES*, int> )(lpVtbl[13]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), pGammaCaps);
    }

    /// <inheritdoc cref = "IDXGIOutput.SetGammaControl"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetGammaControl([NativeTypeName("const DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, DXGI_GAMMA_CONTROL*, int> )(lpVtbl[14]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), pArray);
    }

    /// <inheritdoc cref = "IDXGIOutput.GetGammaControl"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetGammaControl(DXGI_GAMMA_CONTROL* pArray)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, DXGI_GAMMA_CONTROL*, int> )(lpVtbl[15]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), pArray);
    }

    /// <inheritdoc cref = "IDXGIOutput.SetDisplaySurface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetDisplaySurface(IDXGISurface* pScanoutSurface)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, IDXGISurface*, int> )(lpVtbl[16]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), pScanoutSurface);
    }

    /// <inheritdoc cref = "IDXGIOutput.GetDisplaySurfaceData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetDisplaySurfaceData(IDXGISurface* pDestination)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, IDXGISurface*, int> )(lpVtbl[17]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), pDestination);
    }

    /// <inheritdoc cref = "IDXGIOutput.GetFrameStatistics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, DXGI_FRAME_STATISTICS*, int> )(lpVtbl[18]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), pStats);
    }

    /// <inheritdoc cref = "IDXGIOutput1.GetDisplayModeList1"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetDisplayModeList1(DXGI_FORMAT EnumFormat, uint Flags, uint* pNumModes, DXGI_MODE_DESC1* pDesc)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC1*, int> )(lpVtbl[19]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
    }

    /// <inheritdoc cref = "IDXGIOutput1.FindClosestMatchingMode1"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT FindClosestMatchingMode1([NativeTypeName("const DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pModeToMatch, DXGI_MODE_DESC1* pClosestMatch, IUnknown* pConcernedDevice)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, DXGI_MODE_DESC1*, DXGI_MODE_DESC1*, IUnknown*, int> )(lpVtbl[20]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
    }

    /// <inheritdoc cref = "IDXGIOutput1.GetDisplaySurfaceData1"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetDisplaySurfaceData1(IDXGIResource* pDestination)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, IDXGIResource*, int> )(lpVtbl[21]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), pDestination);
    }

    /// <inheritdoc cref = "IDXGIOutput1.DuplicateOutput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT DuplicateOutput(IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, IUnknown*, IDXGIOutputDuplication**, int> )(lpVtbl[22]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), pDevice, ppOutputDuplication);
    }

    /// <inheritdoc cref = "IDXGIOutput2.SupportsOverlays"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public BOOL SupportsOverlays()
    {
        return ((delegate* unmanaged<IDXGIOutput4*, int> )(lpVtbl[23]))((IDXGIOutput4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIOutput3.CheckOverlaySupport"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CheckOverlaySupport(DXGI_FORMAT EnumFormat, IUnknown* pConcernedDevice, uint* pFlags)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, DXGI_FORMAT, IUnknown*, uint*, int> )(lpVtbl[24]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), EnumFormat, pConcernedDevice, pFlags);
    }

    /// <include file='IDXGIOutput4.xml' path='doc/member[@name="IDXGIOutput4.CheckOverlayColorSpaceSupport"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CheckOverlayColorSpaceSupport(DXGI_FORMAT Format, DXGI_COLOR_SPACE_TYPE ColorSpace, IUnknown* pConcernedDevice, uint* pFlags)
    {
        return ((delegate* unmanaged<IDXGIOutput4*, DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, IUnknown*, uint*, int> )(lpVtbl[25]))((IDXGIOutput4*)Unsafe.AsPointer(ref this), Format, ColorSpace, pConcernedDevice, pFlags);
    }

    public interface Interface : IDXGIOutput3.Interface
    {
        [VtblIndex(25)]
        HRESULT CheckOverlayColorSpaceSupport(DXGI_FORMAT Format, DXGI_COLOR_SPACE_TYPE ColorSpace, IUnknown* pConcernedDevice, uint* pFlags);
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
        [NativeTypeName("HRESULT (DXGI_OUTPUT_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_OUTPUT_DESC*, int> GetDesc;
        [NativeTypeName("HRESULT (DXGI_FORMAT, UINT, UINT *, DXGI_MODE_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC*, int> GetDisplayModeList;
        [NativeTypeName("HRESULT (const DXGI_MODE_DESC *, DXGI_MODE_DESC *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MODE_DESC*, DXGI_MODE_DESC*, IUnknown*, int> FindClosestMatchingMode;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> WaitForVBlank;
        [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, BOOL, int> TakeOwnership;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> ReleaseOwnership;
        [NativeTypeName("HRESULT (DXGI_GAMMA_CONTROL_CAPABILITIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_GAMMA_CONTROL_CAPABILITIES*, int> GetGammaControlCapabilities;
        [NativeTypeName("HRESULT (const DXGI_GAMMA_CONTROL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_GAMMA_CONTROL*, int> SetGammaControl;
        [NativeTypeName("HRESULT (DXGI_GAMMA_CONTROL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_GAMMA_CONTROL*, int> GetGammaControl;
        [NativeTypeName("HRESULT (IDXGISurface *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGISurface*, int> SetDisplaySurface;
        [NativeTypeName("HRESULT (IDXGISurface *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGISurface*, int> GetDisplaySurfaceData;
        [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FRAME_STATISTICS*, int> GetFrameStatistics;
        [NativeTypeName("HRESULT (DXGI_FORMAT, UINT, UINT *, DXGI_MODE_DESC1 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC1*, int> GetDisplayModeList1;
        [NativeTypeName("HRESULT (const DXGI_MODE_DESC1 *, DXGI_MODE_DESC1 *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MODE_DESC1*, DXGI_MODE_DESC1*, IUnknown*, int> FindClosestMatchingMode1;
        [NativeTypeName("HRESULT (IDXGIResource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIResource*, int> GetDisplaySurfaceData1;
        [NativeTypeName("HRESULT (IUnknown *, IDXGIOutputDuplication **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, IDXGIOutputDuplication**, int> DuplicateOutput;
        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SupportsOverlays;
        [NativeTypeName("HRESULT (DXGI_FORMAT, IUnknown *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FORMAT, IUnknown*, uint*, int> CheckOverlaySupport;
        [NativeTypeName("HRESULT (DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, IUnknown *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, IUnknown*, uint*, int> CheckOverlayColorSpaceSupport;
    }
}