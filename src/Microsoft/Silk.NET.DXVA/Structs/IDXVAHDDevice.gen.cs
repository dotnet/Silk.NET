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
    [Guid("95f12dfd-d77e-49be-815f-57d579634d6d")]
    [NativeName("Name", "IDXVAHD_Device")]
    public unsafe partial struct IDXVAHDDevice
    {
        public static readonly Guid Guid = new("95f12dfd-d77e-49be-815f-57d579634d6d");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXVAHDDevice val)
            => Unsafe.As<IDXVAHDDevice, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXVAHDDevice
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
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXVAHDDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXVAHDDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoSurface(uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfaces, void** pSharedHandle)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfaces, pSharedHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfaces, pSharedHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfaces, pSharedHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoSurface(uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfaces, ref void* pSharedHandle)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfaces, pSharedHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfaces, pSharedHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfaces, pSharedHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoSurface(uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurfaces, void** pSharedHandle)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacesPtr = &ppSurfaces)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfacesPtr, pSharedHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfacesPtr, pSharedHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfacesPtr, pSharedHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoSurface(uint Width, uint Height, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, HDSurfaceType Type, uint NumSurfaces, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurfaces, ref void* pSharedHandle)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacesPtr = &ppSurfaces)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfacesPtr, pSharedHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfacesPtr, pSharedHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, HDSurfaceType, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, Format, Pool, Usage, Type, NumSurfaces, ppSurfacesPtr, pSharedHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorDeviceCaps(HDVpdevcaps* pCaps)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXVAHDDevice*, HDVpdevcaps*, int>)LpVtbl[4])(@this, pCaps);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDVpdevcaps*, int>)LpVtbl[4])(@this, pCaps);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, HDVpdevcaps*, int>)LpVtbl[4])(@this, pCaps);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorDeviceCaps(ref HDVpdevcaps pCaps)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HDVpdevcaps* pCapsPtr = &pCaps)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, HDVpdevcaps*, int>)LpVtbl[4])(@this, pCapsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDVpdevcaps*, int>)LpVtbl[4])(@this, pCapsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, HDVpdevcaps*, int>)LpVtbl[4])(@this, pCapsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorOutputFormats(uint Count, Silk.NET.Direct3D9.Format* pFormats)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)LpVtbl[5])(@this, Count, pFormats);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)LpVtbl[5])(@this, Count, pFormats);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)LpVtbl[5])(@this, Count, pFormats);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorOutputFormats(uint Count, ref Silk.NET.Direct3D9.Format pFormats)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.Format* pFormatsPtr = &pFormats)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)LpVtbl[5])(@this, Count, pFormatsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)LpVtbl[5])(@this, Count, pFormatsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)LpVtbl[5])(@this, Count, pFormatsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorInputFormats(uint Count, Silk.NET.Direct3D9.Format* pFormats)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)LpVtbl[6])(@this, Count, pFormats);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)LpVtbl[6])(@this, Count, pFormats);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)LpVtbl[6])(@this, Count, pFormats);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorInputFormats(uint Count, ref Silk.NET.Direct3D9.Format pFormats)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.Format* pFormatsPtr = &pFormats)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)LpVtbl[6])(@this, Count, pFormatsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)LpVtbl[6])(@this, Count, pFormatsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, uint, Silk.NET.Direct3D9.Format*, int>)LpVtbl[6])(@this, Count, pFormatsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCaps(uint Count, HDVpcaps* pCaps)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXVAHDDevice*, uint, HDVpcaps*, int>)LpVtbl[7])(@this, Count, pCaps);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, HDVpcaps*, int>)LpVtbl[7])(@this, Count, pCaps);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, uint, HDVpcaps*, int>)LpVtbl[7])(@this, Count, pCaps);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorCaps(uint Count, ref HDVpcaps pCaps)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HDVpcaps* pCapsPtr = &pCaps)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, uint, HDVpcaps*, int>)LpVtbl[7])(@this, Count, pCapsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, uint, HDVpcaps*, int>)LpVtbl[7])(@this, Count, pCapsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, uint, HDVpcaps*, int>)LpVtbl[7])(@this, Count, pCapsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCustomRates(Guid* pVPGuid, uint Count, HDCustomRateData* pRates)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)LpVtbl[8])(@this, pVPGuid, Count, pRates);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)LpVtbl[8])(@this, pVPGuid, Count, pRates);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)LpVtbl[8])(@this, pVPGuid, Count, pRates);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCustomRates(Guid* pVPGuid, uint Count, ref HDCustomRateData pRates)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HDCustomRateData* pRatesPtr = &pRates)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)LpVtbl[8])(@this, pVPGuid, Count, pRatesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)LpVtbl[8])(@this, pVPGuid, Count, pRatesPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)LpVtbl[8])(@this, pVPGuid, Count, pRatesPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCustomRates(ref Guid pVPGuid, uint Count, HDCustomRateData* pRates)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pVPGuidPtr = &pVPGuid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)LpVtbl[8])(@this, pVPGuidPtr, Count, pRates);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)LpVtbl[8])(@this, pVPGuidPtr, Count, pRates);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)LpVtbl[8])(@this, pVPGuidPtr, Count, pRates);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorCustomRates(ref Guid pVPGuid, uint Count, ref HDCustomRateData pRates)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pVPGuidPtr = &pVPGuid)
            {
                fixed (HDCustomRateData* pRatesPtr = &pRates)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)LpVtbl[8])(@this, pVPGuidPtr, Count, pRatesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)LpVtbl[8])(@this, pVPGuidPtr, Count, pRatesPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, Guid*, uint, HDCustomRateData*, int>)LpVtbl[8])(@this, pVPGuidPtr, Count, pRatesPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorFilterRange(HDFilter Filter, HDFilterRangeData* pRange)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXVAHDDevice*, HDFilter, HDFilterRangeData*, int>)LpVtbl[9])(@this, Filter, pRange);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDFilter, HDFilterRangeData*, int>)LpVtbl[9])(@this, Filter, pRange);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, HDFilter, HDFilterRangeData*, int>)LpVtbl[9])(@this, Filter, pRange);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessorFilterRange(HDFilter Filter, ref HDFilterRangeData pRange)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HDFilterRangeData* pRangePtr = &pRange)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, HDFilter, HDFilterRangeData*, int>)LpVtbl[9])(@this, Filter, pRangePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, HDFilter, HDFilterRangeData*, int>)LpVtbl[9])(@this, Filter, pRangePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, HDFilter, HDFilterRangeData*, int>)LpVtbl[9])(@this, Filter, pRangePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(Guid* pVPGuid, IDXVAHDVideoProcessor** ppVideoProcessor)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)LpVtbl[10])(@this, pVPGuid, ppVideoProcessor);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)LpVtbl[10])(@this, pVPGuid, ppVideoProcessor);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)LpVtbl[10])(@this, pVPGuid, ppVideoProcessor);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(Guid* pVPGuid, ref IDXVAHDVideoProcessor* ppVideoProcessor)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXVAHDVideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)LpVtbl[10])(@this, pVPGuid, ppVideoProcessorPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)LpVtbl[10])(@this, pVPGuid, ppVideoProcessorPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)LpVtbl[10])(@this, pVPGuid, ppVideoProcessorPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(ref Guid pVPGuid, IDXVAHDVideoProcessor** ppVideoProcessor)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pVPGuidPtr = &pVPGuid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)LpVtbl[10])(@this, pVPGuidPtr, ppVideoProcessor);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)LpVtbl[10])(@this, pVPGuidPtr, ppVideoProcessor);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)LpVtbl[10])(@this, pVPGuidPtr, ppVideoProcessor);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(ref Guid pVPGuid, ref IDXVAHDVideoProcessor* ppVideoProcessor)
        {
            var @this = (IDXVAHDDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pVPGuidPtr = &pVPGuid)
            {
                fixed (IDXVAHDVideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)LpVtbl[10])(@this, pVPGuidPtr, ppVideoProcessorPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)LpVtbl[10])(@this, pVPGuidPtr, ppVideoProcessorPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXVAHDDevice*, Guid*, IDXVAHDVideoProcessor**, int>)LpVtbl[10])(@this, pVPGuidPtr, ppVideoProcessorPtr);
                    }
            #endif
                }
            }
            return ret;
        }

    }
}
