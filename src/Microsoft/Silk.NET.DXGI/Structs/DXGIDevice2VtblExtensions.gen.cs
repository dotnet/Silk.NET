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

public unsafe static class DXGIDevice2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDevice2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDevice2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGIDevice2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGIDevice2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid Name, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIDevice2> thisVtbl, Guid* riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIDevice2> thisVtbl, Guid* riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAdapter(this ComPtr<IDXGIDevice2> thisVtbl, Silk.NET.DXGI.IDXGIAdapter** pAdapter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, pAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAdapter(this ComPtr<IDXGIDevice2> thisVtbl, ref Silk.NET.DXGI.IDXGIAdapter* pAdapter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIAdapter** pAdapterPtr = &pAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, pAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, Silk.NET.DXGI.IDXGISurface** ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, ref Silk.NET.DXGI.IDXGISurface* ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedResource pSharedResource, Silk.NET.DXGI.IDXGISurface** ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedResource pSharedResource, ref Silk.NET.DXGI.IDXGISurface* ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
        {
            fixed (Silk.NET.DXGI.IDXGISurface** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SurfaceDesc pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, Silk.NET.DXGI.IDXGISurface** ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SurfaceDesc pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, ref Silk.NET.DXGI.IDXGISurface* ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            fixed (Silk.NET.DXGI.IDXGISurface** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SurfaceDesc pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedResource pSharedResource, Silk.NET.DXGI.IDXGISurface** ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SurfaceDesc pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedResource pSharedResource, ref Silk.NET.DXGI.IDXGISurface* ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
            {
                fixed (Silk.NET.DXGI.IDXGISurface** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, SurfaceDesc*, uint, uint, SharedResource*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResources, pResidencyStatus, NumResources);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppResources, ref Residency pResidencyStatus, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResources, pResidencyStatusPtr, NumResources);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppResources, Residency* pResidencyStatus, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppResourcesPtr = &ppResources)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatus, NumResources);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppResources, ref Residency pResidencyStatus, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppResourcesPtr = &ppResources)
        {
            fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatusPtr, NumResources);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGPUThreadPriority(this ComPtr<IDXGIDevice2> thisVtbl, int Priority)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, int, int>)@this->LpVtbl[10])(@this, Priority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGPUThreadPriority(this ComPtr<IDXGIDevice2> thisVtbl, int* pPriority)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, int*, int>)@this->LpVtbl[11])(@this, pPriority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGPUThreadPriority(this ComPtr<IDXGIDevice2> thisVtbl, ref int pPriority)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pPriorityPtr = &pPriority)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, int*, int>)@this->LpVtbl[11])(@this, pPriorityPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaximumFrameLatency(this ComPtr<IDXGIDevice2> thisVtbl, uint MaxLatency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint, int>)@this->LpVtbl[12])(@this, MaxLatency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaximumFrameLatency(this ComPtr<IDXGIDevice2> thisVtbl, uint* pMaxLatency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint*, int>)@this->LpVtbl[13])(@this, pMaxLatency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMaximumFrameLatency(this ComPtr<IDXGIDevice2> thisVtbl, ref uint pMaxLatency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMaxLatencyPtr = &pMaxLatency)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint*, int>)@this->LpVtbl[13])(@this, pMaxLatencyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OfferResources(this ComPtr<IDXGIDevice2> thisVtbl, uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDXGIResource** ppResources, OfferResourcePriority Priority)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint, IDXGIResource**, OfferResourcePriority, int>)@this->LpVtbl[14])(@this, NumResources, ppResources, Priority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OfferResources(this ComPtr<IDXGIDevice2> thisVtbl, uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IDXGIResource* ppResources, OfferResourcePriority Priority)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIResource** ppResourcesPtr = &ppResources)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint, IDXGIResource**, OfferResourcePriority, int>)@this->LpVtbl[14])(@this, NumResources, ppResourcesPtr, Priority);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources(this ComPtr<IDXGIDevice2> thisVtbl, uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDXGIResource** ppResources, int* pDiscarded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint, IDXGIResource**, int*, int>)@this->LpVtbl[15])(@this, NumResources, ppResources, pDiscarded);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources(this ComPtr<IDXGIDevice2> thisVtbl, uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDXGIResource** ppResources, ref int pDiscarded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pDiscardedPtr = &pDiscarded)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint, IDXGIResource**, int*, int>)@this->LpVtbl[15])(@this, NumResources, ppResources, pDiscardedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources(this ComPtr<IDXGIDevice2> thisVtbl, uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IDXGIResource* ppResources, int* pDiscarded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIResource** ppResourcesPtr = &ppResources)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint, IDXGIResource**, int*, int>)@this->LpVtbl[15])(@this, NumResources, ppResourcesPtr, pDiscarded);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources(this ComPtr<IDXGIDevice2> thisVtbl, uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IDXGIResource* ppResources, ref int pDiscarded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIResource** ppResourcesPtr = &ppResources)
        {
            fixed (int* pDiscardedPtr = &pDiscarded)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint, IDXGIResource**, int*, int>)@this->LpVtbl[15])(@this, NumResources, ppResourcesPtr, pDiscardedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueSetEvent(this ComPtr<IDXGIDevice2> thisVtbl, void* hEvent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, void*, int>)@this->LpVtbl[16])(@this, hEvent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnqueueSetEvent<T0>(this ComPtr<IDXGIDevice2> thisVtbl, ref T0 hEvent) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, void*, int>)@this->LpVtbl[16])(@this, hEventPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDevice2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDevice2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIDevice2> thisVtbl, Span<Guid> Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDXGIDevice2> thisVtbl, Span<Guid> Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIDevice2> thisVtbl, Span<Guid> Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<IDXGIDevice2> thisVtbl, Span<Guid> Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIDevice2> thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIDevice2> thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIDevice2> thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIDevice2> thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDXGIDevice2> thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParent<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppParent = default;
        return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIDevice2> thisVtbl, Span<Guid> riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIDevice2> thisVtbl, Span<Guid> riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static int GetAdapter<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, ref ComPtr<TI0> pAdapter) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAdapter((Silk.NET.DXGI.IDXGIAdapter**) pAdapter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, ref ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSurface(pDesc, NumSurfaces, Usage, pSharedResource, (Silk.NET.DXGI.IDXGISurface**) ppSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedResource> pSharedResource, Silk.NET.DXGI.IDXGISurface** ppSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSurface(pDesc, NumSurfaces, Usage, in pSharedResource.GetPinnableReference(), ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedResource pSharedResource, ref ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSurface(pDesc, NumSurfaces, Usage, in pSharedResource, (Silk.NET.DXGI.IDXGISurface**) ppSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedResource> pSharedResource, ref Silk.NET.DXGI.IDXGISurface* ppSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSurface(pDesc, NumSurfaces, Usage, in pSharedResource.GetPinnableReference(), ref ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SurfaceDesc> pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, Silk.NET.DXGI.IDXGISurface** ppSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSurface(in pDesc.GetPinnableReference(), NumSurfaces, Usage, pSharedResource, ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SurfaceDesc pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, ref ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSurface(in pDesc, NumSurfaces, Usage, pSharedResource, (Silk.NET.DXGI.IDXGISurface**) ppSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SurfaceDesc> pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedResource* pSharedResource, ref Silk.NET.DXGI.IDXGISurface* ppSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSurface(in pDesc.GetPinnableReference(), NumSurfaces, Usage, pSharedResource, ref ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SurfaceDesc> pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedResource> pSharedResource, Silk.NET.DXGI.IDXGISurface** ppSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSurface(in pDesc.GetPinnableReference(), NumSurfaces, Usage, in pSharedResource.GetPinnableReference(), ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSurface<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SurfaceDesc pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedResource pSharedResource, ref ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSurface(in pDesc, NumSurfaces, Usage, in pSharedResource, (Silk.NET.DXGI.IDXGISurface**) ppSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SurfaceDesc> pDesc, uint NumSurfaces, uint Usage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedResource> pSharedResource, ref Silk.NET.DXGI.IDXGISurface* ppSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSurface(in pDesc.GetPinnableReference(), NumSurfaces, Usage, in pSharedResource.GetPinnableReference(), ref ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppResources, Residency* pResidencyStatus, uint NumResources) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->QueryResourceResidency((Silk.NET.Core.Native.IUnknown**) ppResources.GetAddressOf(), pResidencyStatus, NumResources);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppResources, Span<Residency> pResidencyStatus, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryResourceResidency(ppResources, ref pResidencyStatus.GetPinnableReference(), NumResources);
    }

    /// <summary>To be documented.</summary>
    public static int QueryResourceResidency<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppResources, ref Residency pResidencyStatus, uint NumResources) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->QueryResourceResidency((Silk.NET.Core.Native.IUnknown**) ppResources.GetAddressOf(), ref pResidencyStatus, NumResources);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency(this ComPtr<IDXGIDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppResources, Span<Residency> pResidencyStatus, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryResourceResidency(in ppResources, ref pResidencyStatus.GetPinnableReference(), NumResources);
    }

    /// <summary>To be documented.</summary>
    public static int GetGPUThreadPriority(this ComPtr<IDXGIDevice2> thisVtbl, Span<int> pPriority)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGPUThreadPriority(ref pPriority.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMaximumFrameLatency(this ComPtr<IDXGIDevice2> thisVtbl, Span<uint> pMaxLatency)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMaximumFrameLatency(ref pMaxLatency.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int OfferResources<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppResources, OfferResourcePriority Priority) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OfferResources(NumResources, (IDXGIResource**) ppResources.GetAddressOf(), Priority);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppResources, int* pDiscarded) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ReclaimResources(NumResources, (IDXGIResource**) ppResources.GetAddressOf(), pDiscarded);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources(this ComPtr<IDXGIDevice2> thisVtbl, uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDXGIResource** ppResources, Span<int> pDiscarded)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReclaimResources(NumResources, ppResources, ref pDiscarded.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ReclaimResources<TI0>(this ComPtr<IDXGIDevice2> thisVtbl, uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppResources, ref int pDiscarded) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ReclaimResources(NumResources, (IDXGIResource**) ppResources.GetAddressOf(), ref pDiscarded);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources(this ComPtr<IDXGIDevice2> thisVtbl, uint NumResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IDXGIResource* ppResources, Span<int> pDiscarded)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReclaimResources(NumResources, in ppResources, ref pDiscarded.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnqueueSetEvent<T0>(this ComPtr<IDXGIDevice2> thisVtbl, Span<T0> hEvent) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnqueueSetEvent(ref hEvent.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDXGIDevice2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetParent<TI0>(this ComPtr<IDXGIDevice2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
