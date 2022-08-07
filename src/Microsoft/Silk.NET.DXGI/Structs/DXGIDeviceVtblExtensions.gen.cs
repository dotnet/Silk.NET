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

public unsafe static class DXGIDeviceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAdapter<TThis>(this TThis thisVtbl, Silk.NET.DXGI.IDXGIAdapter** pAdapter) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, pAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAdapter<TThis>(this TThis thisVtbl, ref Silk.NET.DXGI.IDXGIAdapter* pAdapter) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIAdapter** pAdapterPtr = &pAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, pAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref IDXGISurface* ppSurface) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, IDXGISurface** ppSurface) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, ref IDXGISurface* ppSurface) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
        {
            fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref IDXGISurface* ppSurface) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, IDXGISurface** ppSurface) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, ref IDXGISurface* ppSurface) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
            {
                fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResources, pResidencyStatus, NumResources);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown** ppResources, ref Residency pResidencyStatus, uint NumResources) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResources, pResidencyStatusPtr, NumResources);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown* ppResources, Residency* pResidencyStatus, uint NumResources) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppResourcesPtr = &ppResources)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatus, NumResources);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown* ppResources, ref Residency pResidencyStatus, uint NumResources) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppResourcesPtr = &ppResources)
        {
            fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatusPtr, NumResources);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGPUThreadPriority<TThis>(this TThis thisVtbl, int Priority) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, int, int>)@this->LpVtbl[10])(@this, Priority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGPUThreadPriority<TThis>(this TThis thisVtbl, int* pPriority) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, int*, int>)@this->LpVtbl[11])(@this, pPriority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGPUThreadPriority<TThis>(this TThis thisVtbl, ref int pPriority) where TThis : IComVtbl<IDXGIDevice>
    {
        var @this = (IDXGIDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pPriorityPtr = &pPriority)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice*, int*, int>)@this->LpVtbl[11])(@this, pPriorityPtr);
        }
        return ret;
    }

}
