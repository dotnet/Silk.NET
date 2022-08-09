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

public unsafe static class DirectXVideoDecoderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderService<TThis>(this TThis thisVtbl, IDirectXVideoDecoderService** ppService) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, IDirectXVideoDecoderService**, int>)@this->LpVtbl[3])(@this, ppService);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderService<TThis>(this TThis thisVtbl, ref IDirectXVideoDecoderService* ppService) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirectXVideoDecoderService** ppServicePtr = &ppService)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, IDirectXVideoDecoderService**, int>)@this->LpVtbl[3])(@this, ppServicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
        {
            fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
        {
            fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfaces);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfaces);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
        {
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
                        fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint BufferType, void** ppBuffer, uint* pBufferSize) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, void**, uint*, int>)@this->LpVtbl[5])(@this, BufferType, ppBuffer, pBufferSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint BufferType, void** ppBuffer, ref uint pBufferSize) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pBufferSizePtr = &pBufferSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, void**, uint*, int>)@this->LpVtbl[5])(@this, BufferType, ppBuffer, pBufferSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint BufferType, ref void* ppBuffer, uint* pBufferSize) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppBufferPtr = &ppBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, void**, uint*, int>)@this->LpVtbl[5])(@this, BufferType, ppBufferPtr, pBufferSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint BufferType, ref void* ppBuffer, ref uint pBufferSize) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppBufferPtr = &ppBuffer)
        {
            fixed (uint* pBufferSizePtr = &pBufferSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, void**, uint*, int>)@this->LpVtbl[5])(@this, BufferType, ppBufferPtr, pBufferSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseBuffer<TThis>(this TThis thisVtbl, uint BufferType) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, int>)@this->LpVtbl[6])(@this, BufferType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginFrame<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, void* pvPVPData) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)@this->LpVtbl[7])(@this, pRenderTarget, pvPVPData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginFrame<T0, TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, ref T0 pvPVPData) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pvPVPDataPtr = &pvPVPData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)@this->LpVtbl[7])(@this, pRenderTarget, pvPVPDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginFrame<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, void* pvPVPData) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)@this->LpVtbl[7])(@this, pRenderTargetPtr, pvPVPData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginFrame<T0, TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, ref T0 pvPVPData) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            fixed (void* pvPVPDataPtr = &pvPVPData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)@this->LpVtbl[7])(@this, pRenderTargetPtr, pvPVPDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndFrame<TThis>(this TThis thisVtbl, void** pHandleComplete) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, void**, int>)@this->LpVtbl[8])(@this, pHandleComplete);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndFrame<TThis>(this TThis thisVtbl, ref void* pHandleComplete) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pHandleCompletePtr = &pHandleComplete)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, void**, int>)@this->LpVtbl[8])(@this, pHandleCompletePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Execute<TThis>(this TThis thisVtbl, DXVA2DecodeExecuteParams* pExecuteParams) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, DXVA2DecodeExecuteParams*, int>)@this->LpVtbl[9])(@this, pExecuteParams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Execute<TThis>(this TThis thisVtbl, ref DXVA2DecodeExecuteParams pExecuteParams) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DXVA2DecodeExecuteParams* pExecuteParamsPtr = &pExecuteParams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, DXVA2DecodeExecuteParams*, int>)@this->LpVtbl[9])(@this, pExecuteParamsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderService<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppService) where TI0 : unmanaged, IComVtbl<IDirectXVideoDecoderService>, IComVtbl<TI0> where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetVideoDecoderService((IDirectXVideoDecoderService**) ppService.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, pVideoDesc, pConfig, ref pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, pVideoDesc, ref pConfig.GetPinnableReference(), pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, pVideoDesc, ref pConfig.GetPinnableReference(), pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, pVideoDesc, ref pConfig.GetPinnableReference(), ref pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, pVideoDesc, ref pConfig.GetPinnableReference(), ref pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, ref pVideoDesc.GetPinnableReference(), pConfig, pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, ref pVideoDesc.GetPinnableReference(), pConfig, pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, ref pVideoDesc.GetPinnableReference(), pConfig, ref pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, ref pVideoDesc.GetPinnableReference(), pConfig, ref pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ref pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Guid* pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(pDeviceGuid, ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ref pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), pVideoDesc, pConfig, pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), pVideoDesc, pConfig, ref pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), pVideoDesc, pConfig, ref pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), pVideoDesc, ref pConfig.GetPinnableReference(), pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), pVideoDesc, ref pConfig.GetPinnableReference(), pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), pVideoDesc, ref pConfig.GetPinnableReference(), ref pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, DXVA2VideoDesc* pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), pVideoDesc, ref pConfig.GetPinnableReference(), ref pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pConfig, pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pConfig, pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pConfig, ref pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), pConfig, ref pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ref pDecoderRenderTargets, pNumSurfaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, Span<Guid> pDeviceGuid, Span<DXVA2VideoDesc> pVideoDesc, Span<DXVA2ConfigPictureDecode> pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, Span<uint> pNumSurfaces) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pDeviceGuid.GetPinnableReference(), ref pVideoDesc.GetPinnableReference(), ref pConfig.GetPinnableReference(), ref pDecoderRenderTargets, ref pNumSurfaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint BufferType, void** ppBuffer, Span<uint> pBufferSize) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBuffer(BufferType, ppBuffer, ref pBufferSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint BufferType, ref void* ppBuffer, Span<uint> pBufferSize) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBuffer(BufferType, ref ppBuffer, ref pBufferSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginFrame<T0, TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, Span<T0> pvPVPData) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BeginFrame(pRenderTarget, ref pvPVPData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginFrame<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pRenderTarget, void* pvPVPData) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BeginFrame(ref pRenderTarget.GetPinnableReference(), pvPVPData);
    }

    /// <summary>To be documented.</summary>
    public static int BeginFrame<T0, TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pRenderTarget, Span<T0> pvPVPData) where T0 : unmanaged where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BeginFrame(ref pRenderTarget.GetPinnableReference(), ref pvPVPData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Execute<TThis>(this TThis thisVtbl, Span<DXVA2DecodeExecuteParams> pExecuteParams) where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Execute(ref pExecuteParams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDirectXVideoDecoder>
    {
        var @this = (IDirectXVideoDecoder*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
