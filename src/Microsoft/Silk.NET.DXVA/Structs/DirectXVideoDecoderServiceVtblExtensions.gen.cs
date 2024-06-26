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
    public static unsafe int QueryInterface(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<IDirectXVideoDecoderService> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirectXVideoDecoderService> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDirectXVideoDecoderService> thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDirectXVideoDecoderService> thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDirectXVideoDecoderService> thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurface, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurfacePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDirectXVideoDecoderService> thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderDeviceGuids(this ComPtr<IDirectXVideoDecoderService> thisVtbl, uint* pCount, Guid** pGuids)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint*, Guid**, int>)@this->LpVtbl[4])(@this, pCount, pGuids);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderDeviceGuids(this ComPtr<IDirectXVideoDecoderService> thisVtbl, uint* pCount, ref Guid* pGuids)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid** pGuidsPtr = &pGuids)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint*, Guid**, int>)@this->LpVtbl[4])(@this, pCount, pGuidsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderDeviceGuids(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref uint pCount, Guid** pGuids)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint*, Guid**, int>)@this->LpVtbl[4])(@this, pCountPtr, pGuids);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderDeviceGuids(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref uint pCount, ref Guid* pGuids)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, uint* pCount, Silk.NET.Direct3D9.Format** pFormats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, Guid, pCount, pFormats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, Guid, pCount, pFormatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, Guid, pCountPtr, pFormats);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, uint* pCount, Silk.NET.Direct3D9.Format** pFormats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)@this->LpVtbl[5])(@this, GuidPtr, pCount, pFormats);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReserved, pCount, ppConfigs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReserved, pCount, ppConfigsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReserved, pCountPtr, ppConfigs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pReservedPtr = &pReserved)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDesc, pReservedPtr, pCount, ppConfigs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, Guid, pVideoDescPtr, pReserved, pCount, ppConfigs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, void* pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, void* pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, ref T0 pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, ref T0 pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, ref T0 pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, ref T0 pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)@this->LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReserved, pCount, ppConfigs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, void* pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, void* pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, ref T0 pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, ref T0 pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, ref T0 pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, ref T0 pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDesc, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* GuidPtr = &Guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)@this->LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
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
    public static int QueryInterface<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderDeviceGuids(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<uint> pCount, Guid** pGuids)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderDeviceGuids(ref pCount.GetPinnableReference(), pGuids);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderDeviceGuids(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<uint> pCount, ref Guid* pGuids)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderDeviceGuids(ref pCount.GetPinnableReference(), ref pGuids);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, Span<uint> pCount, Silk.NET.Direct3D9.Format** pFormats)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderRenderTargets(Guid, ref pCount.GetPinnableReference(), pFormats);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, Span<uint> pCount, ref Silk.NET.Direct3D9.Format* pFormats)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderRenderTargets(Guid, ref pCount.GetPinnableReference(), ref pFormats);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, uint* pCount, Silk.NET.Direct3D9.Format** pFormats)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderRenderTargets(ref Guid.GetPinnableReference(), pCount, pFormats);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderRenderTargets(ref Guid.GetPinnableReference(), pCount, ref pFormats);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, Span<uint> pCount, Silk.NET.Direct3D9.Format** pFormats)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderRenderTargets(ref Guid.GetPinnableReference(), ref pCount.GetPinnableReference(), pFormats);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderRenderTargets(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, Span<uint> pCount, ref Silk.NET.Direct3D9.Format* pFormats)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderRenderTargets(ref Guid.GetPinnableReference(), ref pCount.GetPinnableReference(), ref pFormats);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, pVideoDesc, pReserved, ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, pVideoDesc, pReserved, ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, pVideoDesc, ref pReserved.GetPinnableReference(), pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, pVideoDesc, ref pReserved.GetPinnableReference(), pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, pVideoDesc, ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, pVideoDesc, ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, in pVideoDesc.GetPinnableReference(), pReserved, pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, in pVideoDesc.GetPinnableReference(), pReserved, pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, void* pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, in pVideoDesc.GetPinnableReference(), pReserved, ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, void* pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, in pVideoDesc.GetPinnableReference(), pReserved, ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, in pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, in pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, in pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(Guid, in pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, pReserved, pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, pReserved, pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, pReserved, ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, void* pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, pReserved, ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, ref pReserved.GetPinnableReference(), pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, ref pReserved.GetPinnableReference(), pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, Span<T0> pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), pVideoDesc, ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), pReserved, pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), pReserved, pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, void* pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), pReserved, ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, void* pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), pReserved, ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), pCount, ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), pCount, ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, Span<uint> pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderConfigurations<T0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, Span<T0> pReserved, Span<uint> pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDecoderConfigurations(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), ref pReserved.GetPinnableReference(), ref pCount.GetPinnableReference(), ref ppConfigs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(Guid, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(Guid, pVideoDesc, pConfig, ref ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, pVideoDesc, in pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(Guid, pVideoDesc, in pConfig, ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, pVideoDesc, in pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, pVideoDesc, in pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(Guid, pVideoDesc, in pConfig, ref ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, pVideoDesc, in pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, in pVideoDesc.GetPinnableReference(), pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(Guid, in pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, in pVideoDesc.GetPinnableReference(), pConfig, ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, in pVideoDesc.GetPinnableReference(), pConfig, ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(Guid, in pVideoDesc, pConfig, ref ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, in pVideoDesc.GetPinnableReference(), pConfig, ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, in pVideoDesc.GetPinnableReference(), in pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(Guid, in pVideoDesc, in pConfig, ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, in pVideoDesc.GetPinnableReference(), in pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, in pVideoDesc.GetPinnableReference(), in pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(Guid, in pVideoDesc, in pConfig, ref ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Guid* Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(Guid, in pVideoDesc.GetPinnableReference(), in pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(ref Guid, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, pConfig, ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(ref Guid, pVideoDesc, pConfig, ref ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, pConfig, ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, in pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(ref Guid, pVideoDesc, in pConfig, ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, in pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, in pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(ref Guid, pVideoDesc, in pConfig, ref ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2VideoDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), pVideoDesc, in pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(ref Guid, in pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), pConfig, ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), pConfig, ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(ref Guid, in pVideoDesc, pConfig, ref ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), pConfig, ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), in pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(ref Guid, in pVideoDesc, in pConfig, ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), in pConfig.GetPinnableReference(), ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), in pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl, ref Guid Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2VideoDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref ComPtr<TI0> ppDecode) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(ref Guid, in pVideoDesc, in pConfig, ref ppDecoderRenderTargets, NumRenderTargets, (IDirectXVideoDecoder**) ppDecode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<IDirectXVideoDecoderService> thisVtbl, Span<Guid> Guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2VideoDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(ref Guid.GetPinnableReference(), in pVideoDesc.GetPinnableReference(), in pConfig.GetPinnableReference(), ref ppDecoderRenderTargets, NumRenderTargets, ref ppDecode);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDirectXVideoDecoderService> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
