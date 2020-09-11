// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "IDirect3DSwapChain9")]
    public unsafe partial struct IDirect3DSwapChain9
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DSwapChain9 val)
            => Unsafe.As<IDirect3DSwapChain9, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDirect3DSwapChain9
        (
            PresentParameters presentParameters = default,
            Displaymode displayMode = default,
            void** lpVtbl = default
        )
        {
            PresentParameters = presentParameters;
            DisplayMode = displayMode;
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "D3DPRESENT_PARAMETERS")]
        [NativeName("Type.Name", "D3DPRESENT_PARAMETERS")]
        [NativeName("Name", "PresentParameters")]
        public PresentParameters PresentParameters;

        [NativeName("Type", "D3DDISPLAYMODE")]
        [NativeName("Type.Name", "D3DDISPLAYMODE")]
        [NativeName("Name", "DisplayMode")]
        public Displaymode DisplayMode;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DSwapChain9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDirect3DSwapChain9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDirect3DSwapChain9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDirect3DSwapChain9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DSwapChain9*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DSwapChain9*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(Silk.NET.Core.Native.TagRect* pSourceRect, Silk.NET.Core.Native.TagRect* pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DSwapChain9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(Silk.NET.Core.Native.TagRect* pSourceRect, Silk.NET.Core.Native.TagRect* pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* cdecl<IDirect3DSwapChain9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(Silk.NET.Core.Native.TagRect* pSourceRect, ref Silk.NET.Core.Native.TagRect pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* cdecl<IDirect3DSwapChain9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(Silk.NET.Core.Native.TagRect* pSourceRect, ref Silk.NET.Core.Native.TagRect pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                {
                    fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                    {
                        ret = ((delegate* cdecl<IDirect3DSwapChain9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(ref Silk.NET.Core.Native.TagRect pSourceRect, Silk.NET.Core.Native.TagRect* pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    ret = ((delegate* cdecl<IDirect3DSwapChain9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(ref Silk.NET.Core.Native.TagRect pSourceRect, Silk.NET.Core.Native.TagRect* pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                    {
                        ret = ((delegate* cdecl<IDirect3DSwapChain9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(ref Silk.NET.Core.Native.TagRect pSourceRect, ref Silk.NET.Core.Native.TagRect pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* cdecl<IDirect3DSwapChain9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Present(ref Silk.NET.Core.Native.TagRect pSourceRect, ref Silk.NET.Core.Native.TagRect pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                    {
                        fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                        {
                            ret = ((delegate* cdecl<IDirect3DSwapChain9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrontBufferData(IDirect3DSurface9* pDestSurface)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DSwapChain9*, IDirect3DSurface9*, int>)LpVtbl[4])(@this, pDestSurface);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFrontBufferData(ref IDirect3DSurface9 pDestSurface)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    ret = ((delegate* cdecl<IDirect3DSwapChain9*, IDirect3DSurface9*, int>)LpVtbl[4])(@this, pDestSurfacePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBackBuffer(uint iBackBuffer, BackbufferType Type, IDirect3DSurface9** ppBackBuffer)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DSwapChain9*, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[5])(@this, iBackBuffer, Type, ppBackBuffer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBackBuffer(uint iBackBuffer, BackbufferType Type, ref IDirect3DSurface9* ppBackBuffer)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9** ppBackBufferPtr = &ppBackBuffer)
                {
                    ret = ((delegate* cdecl<IDirect3DSwapChain9*, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[5])(@this, iBackBuffer, Type, ppBackBufferPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRasterStatus(RasterStatus* pRasterStatus)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DSwapChain9*, RasterStatus*, int>)LpVtbl[6])(@this, pRasterStatus);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetRasterStatus(ref RasterStatus pRasterStatus)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (RasterStatus* pRasterStatusPtr = &pRasterStatus)
                {
                    ret = ((delegate* cdecl<IDirect3DSwapChain9*, RasterStatus*, int>)LpVtbl[6])(@this, pRasterStatusPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDisplayMode(Displaymode* pMode)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DSwapChain9*, Displaymode*, int>)LpVtbl[7])(@this, pMode);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDisplayMode(ref Displaymode pMode)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (Displaymode* pModePtr = &pMode)
                {
                    ret = ((delegate* cdecl<IDirect3DSwapChain9*, Displaymode*, int>)LpVtbl[7])(@this, pModePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DSwapChain9*, IDirect3DDevice9**, int>)LpVtbl[8])(@this, ppDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* cdecl<IDirect3DSwapChain9*, IDirect3DDevice9**, int>)LpVtbl[8])(@this, ppDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPresentParameters(PresentParameters* pPresentationParameters)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DSwapChain9*, PresentParameters*, int>)LpVtbl[9])(@this, pPresentationParameters);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPresentParameters(ref PresentParameters pPresentationParameters)
        {
            fixed (IDirect3DSwapChain9* @this = &this)
            {
                int ret = default;
                fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
                {
                    ret = ((delegate* cdecl<IDirect3DSwapChain9*, PresentParameters*, int>)LpVtbl[9])(@this, pPresentationParametersPtr);
                }
                return ret;
            }
        }

    }
}
