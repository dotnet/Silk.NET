// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Direct3D9
{
    [Guid("794950f2-adfc-458a-905e-10a10b0b503b")]
    [NativeName("Name", "IDirect3DSwapChain9")]
    public unsafe partial struct IDirect3DSwapChain9
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DSwapChain9 val)
            => Unsafe.As<IDirect3DSwapChain9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DSwapChain9
        (
            PresentParameters? presentParameters = null,
            Displaymode? displayMode = null,
            void** lpVtbl = null
        ) : this()
        {
            if (presentParameters is not null)
            {
                PresentParameters = presentParameters.Value;
            }

            if (displayMode is not null)
            {
                DisplayMode = displayMode.Value;
            }

            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
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
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(Silk.NET.Maths.Rectangle<long>* pSourceRect, Silk.NET.Maths.Rectangle<long>* pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(Silk.NET.Maths.Rectangle<long>* pSourceRect, Silk.NET.Maths.Rectangle<long>* pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(Silk.NET.Maths.Rectangle<long>* pSourceRect, ref Silk.NET.Maths.Rectangle<long> pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(Silk.NET.Maths.Rectangle<long>* pSourceRect, ref Silk.NET.Maths.Rectangle<long> pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(ref Silk.NET.Maths.Rectangle<long> pSourceRect, Silk.NET.Maths.Rectangle<long>* pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(ref Silk.NET.Maths.Rectangle<long> pSourceRect, Silk.NET.Maths.Rectangle<long>* pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(ref Silk.NET.Maths.Rectangle<long> pSourceRect, ref Silk.NET.Maths.Rectangle<long> pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Present(ref Silk.NET.Maths.Rectangle<long> pSourceRect, ref Silk.NET.Maths.Rectangle<long> pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
                {
                    fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, uint, int>)LpVtbl[3])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrontBufferData(IDirect3DSurface9* pDestSurface)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, IDirect3DSurface9*, int>)LpVtbl[4])(@this, pDestSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrontBufferData(ref IDirect3DSurface9 pDestSurface)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, IDirect3DSurface9*, int>)LpVtbl[4])(@this, pDestSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBackBuffer(uint iBackBuffer, BackbufferType Type, IDirect3DSurface9** ppBackBuffer)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[5])(@this, iBackBuffer, Type, ppBackBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBackBuffer(uint iBackBuffer, BackbufferType Type, ref IDirect3DSurface9* ppBackBuffer)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9** ppBackBufferPtr = &ppBackBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[5])(@this, iBackBuffer, Type, ppBackBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRasterStatus(RasterStatus* pRasterStatus)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, RasterStatus*, int>)LpVtbl[6])(@this, pRasterStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRasterStatus(ref RasterStatus pRasterStatus)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (RasterStatus* pRasterStatusPtr = &pRasterStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, RasterStatus*, int>)LpVtbl[6])(@this, pRasterStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayMode(Displaymode* pMode)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Displaymode*, int>)LpVtbl[7])(@this, pMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayMode(ref Displaymode pMode)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Displaymode* pModePtr = &pMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Displaymode*, int>)LpVtbl[7])(@this, pModePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, IDirect3DDevice9**, int>)LpVtbl[8])(@this, ppDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, IDirect3DDevice9**, int>)LpVtbl[8])(@this, ppDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPresentParameters(PresentParameters* pPresentationParameters)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, PresentParameters*, int>)LpVtbl[9])(@this, pPresentationParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPresentParameters(ref PresentParameters pPresentationParameters)
        {
            var @this = (IDirect3DSwapChain9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, PresentParameters*, int>)LpVtbl[9])(@this, pPresentationParametersPtr);
            }
            return ret;
        }

    }
}
