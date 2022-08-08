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

public unsafe static class DirectXVideoDecoderServiceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, void** pSharedHandle) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, ref void* pSharedHandle) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurface, void** pSharedHandle) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurfacePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurface, ref void* pSharedHandle) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurfacePtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderDeviceGuids<TThis>(this TThis thisVtbl, uint* pCount, Guid** pGuids) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint*, Guid**, int>)@this->LpVtbl[4])(@this, pCount, pGuids);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderDeviceGuids<TThis>(this TThis thisVtbl, uint* pCount, ref Guid* pGuids) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid** pGuidsPtr = &pGuids)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint*, Guid**, int>)@this->LpVtbl[4])(@this, pCount, pGuidsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderDeviceGuids<TThis>(this TThis thisVtbl, ref uint pCount, Guid** pGuids) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint*, Guid**, int>)@this->LpVtbl[4])(@this, pCountPtr, pGuids);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderDeviceGuids<TThis>(this TThis thisVtbl, ref uint pCount, ref Guid* pGuids) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            fixed (Guid** pGuidsPtr = &pGuids)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint*, Guid**, int>)@this->LpVtbl[4])(@this, pCountPtr, pGuidsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, Guid* Guid, uint* pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, Guid, pCount, pFormats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, Guid* Guid, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, Guid, pCount, pFormatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, Guid* Guid, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, Guid, pCountPtr, pFormats);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, Guid* Guid, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, Guid, pCountPtr, pFormatsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, ref Guid Guid, uint* pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, GuidPtr, pCount, pFormats);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, ref Guid Guid, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, GuidPtr, pCount, pFormatsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, ref Guid Guid, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, GuidPtr, pCountPtr, pFormats);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, ref Guid Guid, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, GuidPtr, pCountPtr, pFormatsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReserved, pCount, ppConfigs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReserved, pCount, ppConfigsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReserved, pCountPtr, ppConfigs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReserved, pCountPtr, ppConfigsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pReservedPtr = &pReserved)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReservedPtr, pCount, ppConfigs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pReservedPtr = &pReserved)
        {
            fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReservedPtr, pCount, ppConfigsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pReservedPtr = &pReserved)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReservedPtr, pCountPtr, ppConfigs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pReservedPtr = &pReserved)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReservedPtr, pCountPtr, ppConfigsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDescPtr, pReserved, pCount, ppConfigs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDescPtr, pReserved, pCount, ppConfigsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDescPtr, pReserved, pCountPtr, ppConfigs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDescPtr, pReserved, pCountPtr, ppConfigsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (void* pReservedPtr = &pReserved)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDescPtr, pReservedPtr, pCount, ppConfigs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (void* pReservedPtr = &pReserved)
            {
                fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDescPtr, pReservedPtr, pCount, ppConfigsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (void* pReservedPtr = &pReserved)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDescPtr, pReservedPtr, pCountPtr, ppConfigs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (void* pReservedPtr = &pReserved)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDescPtr, pReservedPtr, pCountPtr, ppConfigsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReserved, pCount, ppConfigs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReserved, pCount, ppConfigsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReserved, pCountPtr, ppConfigs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReserved, pCountPtr, ppConfigsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (void* pReservedPtr = &pReserved)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReservedPtr, pCount, ppConfigs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (void* pReservedPtr = &pReserved)
            {
                fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReservedPtr, pCount, ppConfigsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (void* pReservedPtr = &pReserved)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReservedPtr, pCountPtr, ppConfigs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (void* pReservedPtr = &pReserved)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReservedPtr, pCountPtr, ppConfigsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReserved, pCount, ppConfigs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReserved, pCount, ppConfigsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReserved, pCountPtr, ppConfigs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReserved, pCountPtr, ppConfigsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReservedPtr, pCount, ppConfigs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReservedPtr, pCount, ppConfigsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    fixed (uint* pCountPtr = &pCount)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReservedPtr, pCountPtr, ppConfigs);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    fixed (uint* pCountPtr = &pCount)
                    {
                        fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReservedPtr, pCountPtr, ppConfigsPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
        {
            fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
        {
            fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
            {
                fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
            {
                fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                {
                    fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
            {
                fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                {
                    fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                {
                    fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                    {
                        fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderDeviceGuids<TThis>(this TThis thisVtbl, Span<uint> pCount, Guid** pGuids) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderDeviceGuids(ref pCount.GetPinnableReference(), pGuids);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderDeviceGuids<TThis>(this TThis thisVtbl, Span<uint> pCount, ref Guid* pGuids) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderDeviceGuids(ref pCount.GetPinnableReference(), ref pGuids);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, Guid* Guid, Span<uint> pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderRenderTargets(Guid, ref pCount.GetPinnableReference(), pFormats);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, Guid* Guid, Span<uint> pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderRenderTargets(Guid, ref pCount.GetPinnableReference(), ref pFormats);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, Span<Guid> Guid, uint* pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderRenderTargets(ref Guid.GetPinnableReference(), pCount, pFormats);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, Span<Guid> Guid, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderRenderTargets(ref Guid.GetPinnableReference(), pCount, ref pFormats);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<uint> pCount, Silk.NET.Direct3D9.Format** pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderRenderTargets(ref Guid.GetPinnableReference(), ref pCount.GetPinnableReference(), pFormats);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<uint> pCount, ref Silk.NET.Direct3D9.Format* pFormats) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderRenderTargets(ref Guid.GetPinnableReference(), ref pCount.GetPinnableReference(), ref pFormats);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, pVideoDesc, pReserved, ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, pVideoDesc, pReserved, ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, pVideoDesc, ref pReserved.GetPinnableReference(), pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, pVideoDesc, ref pReserved.GetPinnableReference(), pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, pVideoDesc, ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, pVideoDesc, ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, ref pVideoDesc.GetPinnableReference(), pReserved, pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, ref pVideoDesc.GetPinnableReference(), pReserved, pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, void* pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, ref pVideoDesc.GetPinnableReference(), pReserved, ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, void* pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, ref pVideoDesc.GetPinnableReference(), pReserved, ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, ref pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, ref pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, ref pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, ref pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, pReserved, pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, pReserved, pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, pReserved, ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, pReserved, ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, ref pReserved.GetPinnableReference(), pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, ref pReserved.GetPinnableReference(), pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pReserved, pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pReserved, pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, void* pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pReserved, ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, void* pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pReserved, ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0, TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, pVideoDesc, ref pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, pVideoDesc, ref pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, pVideoDesc, ref pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, pVideoDesc, ref pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, ref pVideoDesc.GetPinnableReference(), pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, ref pVideoDesc.GetPinnableReference(), pConfig, ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, ref pVideoDesc.GetPinnableReference(), pConfig, ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, ref pVideoDesc.GetPinnableReference(), pConfig, ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Guid* Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, pConfig, ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, pConfig, ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, ref pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, ref pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, ref pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, ref pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pConfig, ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pConfig, ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pConfig, ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<Guid> Guid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode) where TThis : IComVtbl<IDirectXVideoDecoderService>
    {
        var @this = (IDirectXVideoDecoderService*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

}
