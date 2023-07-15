// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput"]/*'/>
[Guid("AE02EEDB-C735-4690-8D52-5A8DC20213AA")]
[NativeTypeName("struct IDXGIOutput : IDXGIObject")]
[NativeInheritance("IDXGIObject")]
public unsafe partial struct IDXGIOutput : IDXGIOutput.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIOutput));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIOutput*, Guid*, void**, int> )(lpVtbl[0]))((IDXGIOutput*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIOutput*, uint> )(lpVtbl[1]))((IDXGIOutput*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIOutput*, uint> )(lpVtbl[2]))((IDXGIOutput*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<IDXGIOutput*, Guid*, uint, void*, int> )(lpVtbl[3]))((IDXGIOutput*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IDXGIOutput*, Guid*, IUnknown*, int> )(lpVtbl[4]))((IDXGIOutput*)Unsafe.AsPointer(ref this), Name, pUnknown);
    }

    /// <inheritdoc cref = "IDXGIObject.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<IDXGIOutput*, Guid*, uint*, void*, int> )(lpVtbl[5]))((IDXGIOutput*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.GetParent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGIOutput*, Guid*, void**, int> )(lpVtbl[6]))((IDXGIOutput*)Unsafe.AsPointer(ref this), riid, ppParent);
    }

    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDesc(DXGI_OUTPUT_DESC* pDesc)
    {
        return ((delegate* unmanaged<IDXGIOutput*, DXGI_OUTPUT_DESC*, int> )(lpVtbl[7]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.GetDisplayModeList"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDisplayModeList(DXGI_FORMAT EnumFormat, uint Flags, uint* pNumModes, DXGI_MODE_DESC* pDesc)
    {
        return ((delegate* unmanaged<IDXGIOutput*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC*, int> )(lpVtbl[8]))((IDXGIOutput*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
    }

    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.FindClosestMatchingMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindClosestMatchingMode([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pModeToMatch, DXGI_MODE_DESC* pClosestMatch, IUnknown* pConcernedDevice)
    {
        return ((delegate* unmanaged<IDXGIOutput*, DXGI_MODE_DESC*, DXGI_MODE_DESC*, IUnknown*, int> )(lpVtbl[9]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
    }

    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.WaitForVBlank"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT WaitForVBlank()
    {
        return ((delegate* unmanaged<IDXGIOutput*, int> )(lpVtbl[10]))((IDXGIOutput*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.TakeOwnership"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TakeOwnership(IUnknown* pDevice, BOOL Exclusive)
    {
        return ((delegate* unmanaged<IDXGIOutput*, IUnknown*, BOOL, int> )(lpVtbl[11]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
    }

    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.ReleaseOwnership"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void ReleaseOwnership()
    {
        ((delegate* unmanaged<IDXGIOutput*, void> )(lpVtbl[12]))((IDXGIOutput*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.GetGammaControlCapabilities"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGammaControlCapabilities(DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)
    {
        return ((delegate* unmanaged<IDXGIOutput*, DXGI_GAMMA_CONTROL_CAPABILITIES*, int> )(lpVtbl[13]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pGammaCaps);
    }

    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.SetGammaControl"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetGammaControl([NativeTypeName("const DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
    {
        return ((delegate* unmanaged<IDXGIOutput*, DXGI_GAMMA_CONTROL*, int> )(lpVtbl[14]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pArray);
    }

    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.GetGammaControl"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetGammaControl(DXGI_GAMMA_CONTROL* pArray)
    {
        return ((delegate* unmanaged<IDXGIOutput*, DXGI_GAMMA_CONTROL*, int> )(lpVtbl[15]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pArray);
    }

    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.SetDisplaySurface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetDisplaySurface(IDXGISurface* pScanoutSurface)
    {
        return ((delegate* unmanaged<IDXGIOutput*, IDXGISurface*, int> )(lpVtbl[16]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pScanoutSurface);
    }

    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.GetDisplaySurfaceData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetDisplaySurfaceData(IDXGISurface* pDestination)
    {
        return ((delegate* unmanaged<IDXGIOutput*, IDXGISurface*, int> )(lpVtbl[17]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pDestination);
    }

    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.GetFrameStatistics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
    {
        return ((delegate* unmanaged<IDXGIOutput*, DXGI_FRAME_STATISTICS*, int> )(lpVtbl[18]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pStats);
    }

    public interface Interface : IDXGIObject.Interface
    {
        [VtblIndex(7)]
        HRESULT GetDesc(DXGI_OUTPUT_DESC* pDesc);
        [VtblIndex(8)]
        HRESULT GetDisplayModeList(DXGI_FORMAT EnumFormat, uint Flags, uint* pNumModes, DXGI_MODE_DESC* pDesc);
        [VtblIndex(9)]
        HRESULT FindClosestMatchingMode([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pModeToMatch, DXGI_MODE_DESC* pClosestMatch, IUnknown* pConcernedDevice);
        [VtblIndex(10)]
        HRESULT WaitForVBlank();
        [VtblIndex(11)]
        HRESULT TakeOwnership(IUnknown* pDevice, BOOL Exclusive);
        [VtblIndex(12)]
        void ReleaseOwnership();
        [VtblIndex(13)]
        HRESULT GetGammaControlCapabilities(DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps);
        [VtblIndex(14)]
        HRESULT SetGammaControl([NativeTypeName("const DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray);
        [VtblIndex(15)]
        HRESULT GetGammaControl(DXGI_GAMMA_CONTROL* pArray);
        [VtblIndex(16)]
        HRESULT SetDisplaySurface(IDXGISurface* pScanoutSurface);
        [VtblIndex(17)]
        HRESULT GetDisplaySurfaceData(IDXGISurface* pDestination);
        [VtblIndex(18)]
        HRESULT GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats);
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
    }
}