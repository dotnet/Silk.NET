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

namespace Silk.NET.DXVA;

public unsafe static class DirectXVideoProcessorServiceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, void** pSharedHandle) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, ref void* pSharedHandle) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurface, void** pSharedHandle) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurfacePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurface, ref void* pSharedHandle) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurfacePtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoProcessorSoftwareDevice<TThis>(this TThis thisVtbl, void* pCallbacks) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, void*, int>)@this->LpVtbl[4])(@this, pCallbacks);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterVideoProcessorSoftwareDevice<T0, TThis>(this TThis thisVtbl, ref T0 pCallbacks) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCallbacksPtr = &pCallbacks)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, void*, int>)@this->LpVtbl[4])(@this, pCallbacksPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorDeviceGuids<TThis>(this TThis thisVtbl, DXVA2VideoDesc* pVideoDesc, uint* pCount, Guid** pGuids) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, DXVA2VideoDesc*, uint*, Guid**, int>)@this->LpVtbl[5])(@this, pVideoDesc, pCount, pGuids);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorDeviceGuids<TThis>(this TThis thisVtbl, DXVA2VideoDesc* pVideoDesc, uint* pCount, ref Guid* pGuids) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid** pGuidsPtr = &pGuids)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, DXVA2VideoDesc*, uint*, Guid**, int>)@this->LpVtbl[5])(@this, pVideoDesc, pCount, pGuidsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorDeviceGuids<TThis>(this TThis thisVtbl, DXVA2VideoDesc* pVideoDesc, ref uint pCount, Guid** pGuids) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, DXVA2VideoDesc*, uint*, Guid**, int>)@this->LpVtbl[5])(@this, pVideoDesc, pCountPtr, pGuids);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorDeviceGuids<TThis>(this TThis thisVtbl, DXVA2VideoDesc* pVideoDesc, ref uint pCount, ref Guid* pGuids) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            fixed (Guid** pGuidsPtr = &pGuids)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, DXVA2VideoDesc*, uint*, Guid**, int>)@this->LpVtbl[5])(@this, pVideoDesc, pCountPtr, pGuidsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorDeviceGuids<TThis>(this TThis thisVtbl, ref DXVA2VideoDesc pVideoDesc, uint* pCount, Guid** pGuids) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, DXVA2VideoDesc*, uint*, Guid**, int>)@this->LpVtbl[5])(@this, pVideoDescPtr, pCount, pGuids);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorDeviceGuids<TThis>(this TThis thisVtbl, ref DXVA2VideoDesc pVideoDesc, uint* pCount, ref Guid* pGuids) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (Guid** pGuidsPtr = &pGuids)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, DXVA2VideoDesc*, uint*, Guid**, int>)@this->LpVtbl[5])(@this, pVideoDescPtr, pCount, pGuidsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorDeviceGuids<TThis>(this TThis thisVtbl, ref DXVA2VideoDesc pVideoDesc, ref uint pCount, Guid** pGuids) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, DXVA2VideoDesc*, uint*, Guid**, int>)@this->LpVtbl[5])(@this, pVideoDescPtr, pCountPtr, pGuids);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorDeviceGuids<TThis>(this TThis thisVtbl, ref DXVA2VideoDesc pVideoDesc, ref uint pCount, ref Guid* pGuids) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                fixed (Guid** pGuidsPtr = &pGuids)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, DXVA2VideoDesc*, uint*, Guid**, int>)@this->LpVtbl[5])(@this, pVideoDescPtr, pCountPtr, pGuidsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, uint* pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuid, pVideoDesc, pCount, pFormats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuid, pVideoDesc, pCount, pFormatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuid, pVideoDesc, pCountPtr, pFormats);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuid, pVideoDesc, pCountPtr, pFormatsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, uint* pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuid, pVideoDescPtr, pCount, pFormats);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuid, pVideoDescPtr, pCount, pFormatsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuid, pVideoDescPtr, pCountPtr, pFormats);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuid, pVideoDescPtr, pCountPtr, pFormatsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, uint* pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuidPtr, pVideoDesc, pCount, pFormats);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuidPtr, pVideoDesc, pCount, pFormatsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuidPtr, pVideoDesc, pCountPtr, pFormats);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuidPtr, pVideoDesc, pCountPtr, pFormatsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, uint* pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, pCount, pFormats);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, pCount, pFormatsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, pCountPtr, pFormats);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRenderTargets<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[6])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, pCountPtr, pFormatsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint* pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, pCount, pFormats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, pCount, pFormatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, pCountPtr, pFormats);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, pCountPtr, pFormatsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint* pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuid, pVideoDescPtr, RenderTargetFormat, pCount, pFormats);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuid, pVideoDescPtr, RenderTargetFormat, pCount, pFormatsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuid, pVideoDescPtr, RenderTargetFormat, pCountPtr, pFormats);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuid, pVideoDescPtr, RenderTargetFormat, pCountPtr, pFormatsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint* pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuidPtr, pVideoDesc, RenderTargetFormat, pCount, pFormats);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuidPtr, pVideoDesc, RenderTargetFormat, pCount, pFormatsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuidPtr, pVideoDesc, RenderTargetFormat, pCountPtr, pFormats);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuidPtr, pVideoDesc, RenderTargetFormat, pCountPtr, pFormatsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint* pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, RenderTargetFormat, pCount, pFormats);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, RenderTargetFormat, pCount, pFormatsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, RenderTargetFormat, pCountPtr, pFormats);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorSubStreamFormats<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[7])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, RenderTargetFormat, pCountPtr, pFormatsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, DXVA2VideoProcessorCaps* pCaps) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[8])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, ref DXVA2VideoProcessorCaps pCaps) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoProcessorCaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[8])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, DXVA2VideoProcessorCaps* pCaps) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[8])(@this, VideoProcDeviceGuid, pVideoDescPtr, RenderTargetFormat, pCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, ref DXVA2VideoProcessorCaps pCaps) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (DXVA2VideoProcessorCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[8])(@this, VideoProcDeviceGuid, pVideoDescPtr, RenderTargetFormat, pCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, DXVA2VideoProcessorCaps* pCaps) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[8])(@this, VideoProcDeviceGuidPtr, pVideoDesc, RenderTargetFormat, pCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, ref DXVA2VideoProcessorCaps pCaps) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoProcessorCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[8])(@this, VideoProcDeviceGuidPtr, pVideoDesc, RenderTargetFormat, pCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, DXVA2VideoProcessorCaps* pCaps) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[8])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, RenderTargetFormat, pCaps);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorCaps<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, ref DXVA2VideoProcessorCaps pCaps) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2VideoProcessorCaps* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>)@this->LpVtbl[8])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, RenderTargetFormat, pCapsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProcAmpRange<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint ProcAmpCap, DXVA2ValueRange* pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[9])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, ProcAmpCap, pRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProcAmpRange<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint ProcAmpCap, ref DXVA2ValueRange pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ValueRange* pRangePtr = &pRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[9])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, ProcAmpCap, pRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProcAmpRange<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint ProcAmpCap, DXVA2ValueRange* pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[9])(@this, VideoProcDeviceGuid, pVideoDescPtr, RenderTargetFormat, ProcAmpCap, pRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProcAmpRange<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint ProcAmpCap, ref DXVA2ValueRange pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (DXVA2ValueRange* pRangePtr = &pRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[9])(@this, VideoProcDeviceGuid, pVideoDescPtr, RenderTargetFormat, ProcAmpCap, pRangePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProcAmpRange<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint ProcAmpCap, DXVA2ValueRange* pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[9])(@this, VideoProcDeviceGuidPtr, pVideoDesc, RenderTargetFormat, ProcAmpCap, pRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProcAmpRange<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint ProcAmpCap, ref DXVA2ValueRange pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2ValueRange* pRangePtr = &pRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[9])(@this, VideoProcDeviceGuidPtr, pVideoDesc, RenderTargetFormat, ProcAmpCap, pRangePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProcAmpRange<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint ProcAmpCap, DXVA2ValueRange* pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[9])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, RenderTargetFormat, ProcAmpCap, pRange);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetProcAmpRange<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint ProcAmpCap, ref DXVA2ValueRange pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ValueRange* pRangePtr = &pRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[9])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, RenderTargetFormat, ProcAmpCap, pRangePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilterPropertyRange<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint FilterSetting, DXVA2ValueRange* pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[10])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, FilterSetting, pRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilterPropertyRange<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint FilterSetting, ref DXVA2ValueRange pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ValueRange* pRangePtr = &pRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[10])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, FilterSetting, pRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilterPropertyRange<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint FilterSetting, DXVA2ValueRange* pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[10])(@this, VideoProcDeviceGuid, pVideoDescPtr, RenderTargetFormat, FilterSetting, pRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilterPropertyRange<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint FilterSetting, ref DXVA2ValueRange pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (DXVA2ValueRange* pRangePtr = &pRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[10])(@this, VideoProcDeviceGuid, pVideoDescPtr, RenderTargetFormat, FilterSetting, pRangePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilterPropertyRange<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint FilterSetting, DXVA2ValueRange* pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[10])(@this, VideoProcDeviceGuidPtr, pVideoDesc, RenderTargetFormat, FilterSetting, pRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilterPropertyRange<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint FilterSetting, ref DXVA2ValueRange pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2ValueRange* pRangePtr = &pRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[10])(@this, VideoProcDeviceGuidPtr, pVideoDesc, RenderTargetFormat, FilterSetting, pRangePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilterPropertyRange<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint FilterSetting, DXVA2ValueRange* pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[10])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, RenderTargetFormat, FilterSetting, pRange);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFilterPropertyRange<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint FilterSetting, ref DXVA2ValueRange pRange) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ValueRange* pRangePtr = &pRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>)@this->LpVtbl[10])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, RenderTargetFormat, FilterSetting, pRangePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint MaxNumSubStreams, IDirectXVideoProcessor** ppVidProcess) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, IDirectXVideoProcessor**, int>)@this->LpVtbl[11])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, MaxNumSubStreams, ppVidProcess);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint MaxNumSubStreams, ref IDirectXVideoProcessor* ppVidProcess) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirectXVideoProcessor** ppVidProcessPtr = &ppVidProcess)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, IDirectXVideoProcessor**, int>)@this->LpVtbl[11])(@this, VideoProcDeviceGuid, pVideoDesc, RenderTargetFormat, MaxNumSubStreams, ppVidProcessPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint MaxNumSubStreams, IDirectXVideoProcessor** ppVidProcess) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, IDirectXVideoProcessor**, int>)@this->LpVtbl[11])(@this, VideoProcDeviceGuid, pVideoDescPtr, RenderTargetFormat, MaxNumSubStreams, ppVidProcess);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, Guid* VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint MaxNumSubStreams, ref IDirectXVideoProcessor* ppVidProcess) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (IDirectXVideoProcessor** ppVidProcessPtr = &ppVidProcess)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, IDirectXVideoProcessor**, int>)@this->LpVtbl[11])(@this, VideoProcDeviceGuid, pVideoDescPtr, RenderTargetFormat, MaxNumSubStreams, ppVidProcessPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint MaxNumSubStreams, IDirectXVideoProcessor** ppVidProcess) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, IDirectXVideoProcessor**, int>)@this->LpVtbl[11])(@this, VideoProcDeviceGuidPtr, pVideoDesc, RenderTargetFormat, MaxNumSubStreams, ppVidProcess);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, DXVA2VideoDesc* pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint MaxNumSubStreams, ref IDirectXVideoProcessor* ppVidProcess) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (IDirectXVideoProcessor** ppVidProcessPtr = &ppVidProcess)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, IDirectXVideoProcessor**, int>)@this->LpVtbl[11])(@this, VideoProcDeviceGuidPtr, pVideoDesc, RenderTargetFormat, MaxNumSubStreams, ppVidProcessPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint MaxNumSubStreams, IDirectXVideoProcessor** ppVidProcess) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, IDirectXVideoProcessor**, int>)@this->LpVtbl[11])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, RenderTargetFormat, MaxNumSubStreams, ppVidProcess);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, ref Guid VideoProcDeviceGuid, ref DXVA2VideoDesc pVideoDesc, Silk.NET.Direct3D9.Format RenderTargetFormat, uint MaxNumSubStreams, ref IDirectXVideoProcessor* ppVidProcess) where TThis : IComVtbl<IDirectXVideoProcessorService>
    {
        var @this = (IDirectXVideoProcessorService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* VideoProcDeviceGuidPtr = &VideoProcDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (IDirectXVideoProcessor** ppVidProcessPtr = &ppVidProcess)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoProcessorService*, Guid*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, IDirectXVideoProcessor**, int>)@this->LpVtbl[11])(@this, VideoProcDeviceGuidPtr, pVideoDescPtr, RenderTargetFormat, MaxNumSubStreams, ppVidProcessPtr);
                }
            }
        }
        return ret;
    }

}
