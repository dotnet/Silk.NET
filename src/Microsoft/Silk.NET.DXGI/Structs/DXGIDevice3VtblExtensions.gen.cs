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

public unsafe static class DXGIDevice3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAdapter<TThis>(this TThis thisVtbl, Silk.NET.DXGI.IDXGIAdapter** pAdapter) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, pAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAdapter<TThis>(this TThis thisVtbl, ref Silk.NET.DXGI.IDXGIAdapter* pAdapter) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIAdapter** pAdapterPtr = &pAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, pAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref IDXGISurface* ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, IDXGISurface** ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, ref IDXGISurface* ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
        {
            fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref IDXGISurface* ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, IDXGISurface** ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, ref IDXGISurface* ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
            {
                fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)@this->LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResources, pResidencyStatus, NumResources);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown** ppResources, ref Residency pResidencyStatus, uint NumResources) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResources, pResidencyStatusPtr, NumResources);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown* ppResources, Residency* pResidencyStatus, uint NumResources) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppResourcesPtr = &ppResources)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatus, NumResources);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown* ppResources, ref Residency pResidencyStatus, uint NumResources) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppResourcesPtr = &ppResources)
        {
            fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)@this->LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatusPtr, NumResources);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGPUThreadPriority<TThis>(this TThis thisVtbl, int Priority) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, int, int>)@this->LpVtbl[10])(@this, Priority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGPUThreadPriority<TThis>(this TThis thisVtbl, int* pPriority) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, int*, int>)@this->LpVtbl[11])(@this, pPriority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGPUThreadPriority<TThis>(this TThis thisVtbl, ref int pPriority) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pPriorityPtr = &pPriority)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, int*, int>)@this->LpVtbl[11])(@this, pPriorityPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaximumFrameLatency<TThis>(this TThis thisVtbl, uint MaxLatency) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint, int>)@this->LpVtbl[12])(@this, MaxLatency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaximumFrameLatency<TThis>(this TThis thisVtbl, uint* pMaxLatency) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint*, int>)@this->LpVtbl[13])(@this, pMaxLatency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMaximumFrameLatency<TThis>(this TThis thisVtbl, ref uint pMaxLatency) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pMaxLatencyPtr = &pMaxLatency)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint*, int>)@this->LpVtbl[13])(@this, pMaxLatencyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OfferResources<TThis>(this TThis thisVtbl, uint NumResources, IDXGIResource** ppResources, OfferResourcePriority Priority) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint, IDXGIResource**, OfferResourcePriority, int>)@this->LpVtbl[14])(@this, NumResources, ppResources, Priority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OfferResources<TThis>(this TThis thisVtbl, uint NumResources, ref IDXGIResource* ppResources, OfferResourcePriority Priority) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIResource** ppResourcesPtr = &ppResources)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint, IDXGIResource**, OfferResourcePriority, int>)@this->LpVtbl[14])(@this, NumResources, ppResourcesPtr, Priority);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources<TThis>(this TThis thisVtbl, uint NumResources, IDXGIResource** ppResources, int* pDiscarded) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint, IDXGIResource**, int*, int>)@this->LpVtbl[15])(@this, NumResources, ppResources, pDiscarded);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources<TThis>(this TThis thisVtbl, uint NumResources, IDXGIResource** ppResources, ref int pDiscarded) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pDiscardedPtr = &pDiscarded)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint, IDXGIResource**, int*, int>)@this->LpVtbl[15])(@this, NumResources, ppResources, pDiscardedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources<TThis>(this TThis thisVtbl, uint NumResources, ref IDXGIResource* ppResources, int* pDiscarded) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIResource** ppResourcesPtr = &ppResources)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint, IDXGIResource**, int*, int>)@this->LpVtbl[15])(@this, NumResources, ppResourcesPtr, pDiscarded);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources<TThis>(this TThis thisVtbl, uint NumResources, ref IDXGIResource* ppResources, ref int pDiscarded) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIResource** ppResourcesPtr = &ppResources)
        {
            fixed (int* pDiscardedPtr = &pDiscarded)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint, IDXGIResource**, int*, int>)@this->LpVtbl[15])(@this, NumResources, ppResourcesPtr, pDiscardedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueSetEvent<TThis>(this TThis thisVtbl, void* hEvent) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, void*, int>)@this->LpVtbl[16])(@this, hEvent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnqueueSetEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, void*, int>)@this->LpVtbl[16])(@this, hEventPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void Trim<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, void>)@this->LpVtbl[17])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParent<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppParent = default;
        return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppParent) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppParent) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TI0, TThis>(this TThis thisVtbl, SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<IDXGISurface>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSurface(pDesc, NumSurfaces, Usage, pSharedResource, (IDXGISurface**) ppSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, Span<SharedResource> pSharedResource, IDXGISurface** ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSurface(pDesc, NumSurfaces, Usage, ref pSharedResource.GetPinnableReference(), ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TI0, TThis>(this TThis thisVtbl, SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, ref ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<IDXGISurface>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSurface(pDesc, NumSurfaces, Usage, ref pSharedResource, (IDXGISurface**) ppSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, Span<SharedResource> pSharedResource, ref IDXGISurface* ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSurface(pDesc, NumSurfaces, Usage, ref pSharedResource.GetPinnableReference(), ref ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, Span<SurfaceDesc> pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSurface(ref pDesc.GetPinnableReference(), NumSurfaces, Usage, pSharedResource, ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TI0, TThis>(this TThis thisVtbl, ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<IDXGISurface>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSurface(ref pDesc, NumSurfaces, Usage, pSharedResource, (IDXGISurface**) ppSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, Span<SurfaceDesc> pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref IDXGISurface* ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSurface(ref pDesc.GetPinnableReference(), NumSurfaces, Usage, pSharedResource, ref ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, Span<SurfaceDesc> pDesc, uint NumSurfaces, uint Usage, Span<SharedResource> pSharedResource, IDXGISurface** ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSurface(ref pDesc.GetPinnableReference(), NumSurfaces, Usage, ref pSharedResource.GetPinnableReference(), ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSurface<TI0, TThis>(this TThis thisVtbl, ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, ref ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<IDXGISurface>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSurface(ref pDesc, NumSurfaces, Usage, ref pSharedResource, (IDXGISurface**) ppSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, Span<SurfaceDesc> pDesc, uint NumSurfaces, uint Usage, Span<SharedResource> pSharedResource, ref IDXGISurface* ppSurface) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSurface(ref pDesc.GetPinnableReference(), NumSurfaces, Usage, ref pSharedResource.GetPinnableReference(), ref ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown** ppResources, Span<Residency> pResidencyStatus, uint NumResources) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryResourceResidency(ppResources, ref pResidencyStatus.GetPinnableReference(), NumResources);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryResourceResidency<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown* ppResources, Span<Residency> pResidencyStatus, uint NumResources) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryResourceResidency(ref ppResources, ref pResidencyStatus.GetPinnableReference(), NumResources);
    }

    /// <summary>To be documented.</summary>
    public static int GetGPUThreadPriority<TThis>(this TThis thisVtbl, Span<int> pPriority) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetGPUThreadPriority(ref pPriority.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMaximumFrameLatency<TThis>(this TThis thisVtbl, Span<uint> pMaxLatency) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetMaximumFrameLatency(ref pMaxLatency.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int OfferResources<TI0, TThis>(this TThis thisVtbl, uint NumResources, ref ComPtr<TI0> ppResources, OfferResourcePriority Priority) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->OfferResources(NumResources, (IDXGIResource**) ppResources.GetAddressOf(), Priority);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources<TI0, TThis>(this TThis thisVtbl, uint NumResources, ref ComPtr<TI0> ppResources, int* pDiscarded) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->ReclaimResources(NumResources, (IDXGIResource**) ppResources.GetAddressOf(), pDiscarded);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources<TThis>(this TThis thisVtbl, uint NumResources, IDXGIResource** ppResources, Span<int> pDiscarded) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ReclaimResources(NumResources, ppResources, ref pDiscarded.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ReclaimResources<TI0, TThis>(this TThis thisVtbl, uint NumResources, ref ComPtr<TI0> ppResources, ref int pDiscarded) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->ReclaimResources(NumResources, (IDXGIResource**) ppResources.GetAddressOf(), ref pDiscarded);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReclaimResources<TThis>(this TThis thisVtbl, uint NumResources, ref IDXGIResource* ppResources, Span<int> pDiscarded) where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ReclaimResources(NumResources, ref ppResources, ref pDiscarded.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnqueueSetEvent<T0, TThis>(this TThis thisVtbl, Span<T0> hEvent) where T0 : unmanaged where TThis : IComVtbl<IDXGIDevice3>
    {
        var @this = (IDXGIDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EnqueueSetEvent(ref hEvent.GetPinnableReference());
    }

}
