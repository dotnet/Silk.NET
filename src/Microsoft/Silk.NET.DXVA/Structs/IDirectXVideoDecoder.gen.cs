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

namespace Silk.NET.DXVA
{
    [Guid("f2b0810a-fd00-43c9-918c-df94e2d8ef7d")]
    [NativeName("Name", "IDirectXVideoDecoder")]
    public unsafe partial struct IDirectXVideoDecoder
    {
        public static readonly Guid Guid = new("f2b0810a-fd00-43c9-918c-df94e2d8ef7d");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirectXVideoDecoder val)
            => Unsafe.As<IDirectXVideoDecoder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirectXVideoDecoder
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderService(IDirectXVideoDecoderService** ppService)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, IDirectXVideoDecoderService**, int>)LpVtbl[3])(@this, ppService);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, IDirectXVideoDecoderService**, int>)LpVtbl[3])(@this, ppService);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, IDirectXVideoDecoderService**, int>)LpVtbl[3])(@this, ppService);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderService(ref IDirectXVideoDecoderService* ppService)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirectXVideoDecoderService** ppServicePtr = &ppService)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, IDirectXVideoDecoderService**, int>)LpVtbl[3])(@this, ppServicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, IDirectXVideoDecoderService**, int>)LpVtbl[3])(@this, ppServicePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, IDirectXVideoDecoderService**, int>)LpVtbl[3])(@this, ppServicePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfaces);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfaces);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfaces);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
                        fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
                        fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfaces);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfaces);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfaces);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
                        fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                    {
                        fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                    {
                        fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
            #if NET5_0_OR_GREATER
                                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                                }
                                else
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint BufferType, void** ppBuffer, uint* pBufferSize)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBuffer, pBufferSize);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBuffer, pBufferSize);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBuffer, pBufferSize);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint BufferType, void** ppBuffer, ref uint pBufferSize)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pBufferSizePtr = &pBufferSize)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBuffer, pBufferSizePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBuffer, pBufferSizePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBuffer, pBufferSizePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint BufferType, ref void* ppBuffer, uint* pBufferSize)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppBufferPtr = &ppBuffer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBufferPtr, pBufferSize);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBufferPtr, pBufferSize);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBufferPtr, pBufferSize);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint BufferType, ref void* ppBuffer, ref uint pBufferSize)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppBufferPtr = &ppBuffer)
            {
                fixed (uint* pBufferSizePtr = &pBufferSize)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBufferPtr, pBufferSizePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBufferPtr, pBufferSizePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBufferPtr, pBufferSizePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReleaseBuffer(uint BufferType)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, uint, int>)LpVtbl[6])(@this, BufferType);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, int>)LpVtbl[6])(@this, BufferType);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, uint, int>)LpVtbl[6])(@this, BufferType);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginFrame(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, void* pvPVPData)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTarget, pvPVPData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTarget, pvPVPData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTarget, pvPVPData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginFrame<T0>(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, ref T0 pvPVPData) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPVPDataPtr = &pvPVPData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTarget, pvPVPDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTarget, pvPVPDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTarget, pvPVPDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginFrame(ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, void* pvPVPData)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTargetPtr, pvPVPData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTargetPtr, pvPVPData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTargetPtr, pvPVPData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginFrame<T0>(ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, ref T0 pvPVPData) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                fixed (void* pvPVPDataPtr = &pvPVPData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTargetPtr, pvPVPDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTargetPtr, pvPVPDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTargetPtr, pvPVPDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndFrame(void** pHandleComplete)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, void**, int>)LpVtbl[8])(@this, pHandleComplete);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, void**, int>)LpVtbl[8])(@this, pHandleComplete);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, void**, int>)LpVtbl[8])(@this, pHandleComplete);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndFrame(ref void* pHandleComplete)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pHandleCompletePtr = &pHandleComplete)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, void**, int>)LpVtbl[8])(@this, pHandleCompletePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, void**, int>)LpVtbl[8])(@this, pHandleCompletePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, void**, int>)LpVtbl[8])(@this, pHandleCompletePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Execute(DXVA2DecodeExecuteParams* pExecuteParams)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirectXVideoDecoder*, DXVA2DecodeExecuteParams*, int>)LpVtbl[9])(@this, pExecuteParams);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, DXVA2DecodeExecuteParams*, int>)LpVtbl[9])(@this, pExecuteParams);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, DXVA2DecodeExecuteParams*, int>)LpVtbl[9])(@this, pExecuteParams);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Execute(ref DXVA2DecodeExecuteParams pExecuteParams)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2DecodeExecuteParams* pExecuteParamsPtr = &pExecuteParams)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoDecoder*, DXVA2DecodeExecuteParams*, int>)LpVtbl[9])(@this, pExecuteParamsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, DXVA2DecodeExecuteParams*, int>)LpVtbl[9])(@this, pExecuteParamsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, DXVA2DecodeExecuteParams*, int>)LpVtbl[9])(@this, pExecuteParamsPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
