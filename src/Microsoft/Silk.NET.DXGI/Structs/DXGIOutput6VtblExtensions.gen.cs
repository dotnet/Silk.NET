// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI;

public unsafe static class DXGIOutput6VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutput6> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGIOutput6> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGIOutput6> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIOutput6> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIOutput6> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutput6> thisVtbl, Guid* Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutput6> thisVtbl, Guid* riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<IDXGIOutput6> thisVtbl, OutputDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, OutputDesc*, int>)@this->LpVtbl[7])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList(this ComPtr<IDXGIOutput6> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WaitForVBlank(this ComPtr<IDXGIOutput6> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, int>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TakeOwnership(this ComPtr<IDXGIOutput6> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Bool32 Exclusive)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[11])(@this, pDevice, Exclusive);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseOwnership(this ComPtr<IDXGIOutput6> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, void>)@this->LpVtbl[12])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGammaControlCapabilities(this ComPtr<IDXGIOutput6> thisVtbl, GammaControlCapabilities* pGammaCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControlCapabilities*, int>)@this->LpVtbl[13])(@this, pGammaCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetGammaControl(this ComPtr<IDXGIOutput6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GammaControl* pArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControl*, int>)@this->LpVtbl[14])(@this, pArray);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGammaControl(this ComPtr<IDXGIOutput6> thisVtbl, GammaControl* pArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControl*, int>)@this->LpVtbl[15])(@this, pArray);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDisplaySurface(this ComPtr<IDXGIOutput6> thisVtbl, Silk.NET.DXGI.IDXGISurface* pScanoutSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[16])(@this, pScanoutSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplaySurfaceData(this ComPtr<IDXGIOutput6> thisVtbl, Silk.NET.DXGI.IDXGISurface* pDestination)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[17])(@this, pDestination);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameStatistics(this ComPtr<IDXGIOutput6> thisVtbl, FrameStatistics* pStats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, FrameStatistics*, int>)@this->LpVtbl[18])(@this, pStats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList1(this ComPtr<IDXGIOutput6> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc1* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplaySurfaceData1(this ComPtr<IDXGIOutput6> thisVtbl, IDXGIResource* pDestination)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IDXGIResource*, int>)@this->LpVtbl[21])(@this, pDestination);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput(this ComPtr<IDXGIOutput6> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevice, ppOutputDuplication);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 SupportsOverlays(this ComPtr<IDXGIOutput6> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Bool32>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlaySupport(this ComPtr<IDXGIOutput6> thisVtbl, Silk.NET.DXGI.Format EnumFormat, Silk.NET.Core.Native.IUnknown* pConcernedDevice, uint* pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlayColorSpaceSupport(this ComPtr<IDXGIOutput6> thisVtbl, Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, Silk.NET.Core.Native.IUnknown* pConcernedDevice, uint* pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput1(this ComPtr<IDXGIOutput6> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Format* pSupportedFormats, IDXGIOutputDuplication** ppOutputDuplication)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevice, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplication);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc1(this ComPtr<IDXGIOutput6> thisVtbl, OutputDesc1* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, OutputDesc1*, int>)@this->LpVtbl[27])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckHardwareCompositionSupport(this ComPtr<IDXGIOutput6> thisVtbl, uint* pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint*, int>)@this->LpVtbl[28])(@this, pFlags);
        return ret;
    }

}
