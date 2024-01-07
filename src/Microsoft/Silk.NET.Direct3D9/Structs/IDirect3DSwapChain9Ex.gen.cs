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

namespace Silk.NET.Direct3D9
{
    [Guid("91886caf-1c3d-4d2e-a0ab-3e4c7d8d3303")]
    [NativeName("Name", "IDirect3DSwapChain9Ex")]
    public unsafe partial struct IDirect3DSwapChain9Ex : IComVtbl<IDirect3DSwapChain9Ex>, IComVtbl<IDirect3DSwapChain9>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("91886caf-1c3d-4d2e-a0ab-3e4c7d8d3303");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDirect3DSwapChain9(IDirect3DSwapChain9Ex val)
            => Unsafe.As<IDirect3DSwapChain9Ex, IDirect3DSwapChain9>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DSwapChain9Ex val)
            => Unsafe.As<IDirect3DSwapChain9Ex, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DSwapChain9Ex
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
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion, uint dwFlags)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                {
                    fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrontBufferData(IDirect3DSurface9* pDestSurface)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, IDirect3DSurface9*, int>)@this->LpVtbl[4])(@this, pDestSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrontBufferData(ref IDirect3DSurface9 pDestSurface)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, IDirect3DSurface9*, int>)@this->LpVtbl[4])(@this, pDestSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBackBuffer(uint iBackBuffer, BackbufferType Type, IDirect3DSurface9** ppBackBuffer)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[5])(@this, iBackBuffer, Type, ppBackBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBackBuffer(uint iBackBuffer, BackbufferType Type, ref IDirect3DSurface9* ppBackBuffer)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppBackBufferPtr = &ppBackBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[5])(@this, iBackBuffer, Type, ppBackBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRasterStatus(RasterStatus* pRasterStatus)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, RasterStatus*, int>)@this->LpVtbl[6])(@this, pRasterStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRasterStatus(ref RasterStatus pRasterStatus)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RasterStatus* pRasterStatusPtr = &pRasterStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, RasterStatus*, int>)@this->LpVtbl[6])(@this, pRasterStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayMode(Displaymode* pMode)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Displaymode*, int>)@this->LpVtbl[7])(@this, pMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayMode(ref Displaymode pMode)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymode* pModePtr = &pMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Displaymode*, int>)@this->LpVtbl[7])(@this, pModePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, IDirect3DDevice9**, int>)@this->LpVtbl[8])(@this, ppDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, IDirect3DDevice9**, int>)@this->LpVtbl[8])(@this, ppDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPresentParameters(PresentParameters* pPresentationParameters)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, PresentParameters*, int>)@this->LpVtbl[9])(@this, pPresentationParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPresentParameters(ref PresentParameters pPresentationParameters)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, PresentParameters*, int>)@this->LpVtbl[9])(@this, pPresentationParametersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastPresentCount(uint* pLastPresentCount)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, uint*, int>)@this->LpVtbl[10])(@this, pLastPresentCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLastPresentCount(ref uint pLastPresentCount)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pLastPresentCountPtr = &pLastPresentCount)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, uint*, int>)@this->LpVtbl[10])(@this, pLastPresentCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPresentStats(Presentstats* pPresentationStatistics)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Presentstats*, int>)@this->LpVtbl[11])(@this, pPresentationStatistics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPresentStats(ref Presentstats pPresentationStatistics)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Presentstats* pPresentationStatisticsPtr = &pPresentationStatistics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Presentstats*, int>)@this->LpVtbl[11])(@this, pPresentationStatisticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeEx(Displaymodeex* pMode, Displayrotation* pRotation)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[12])(@this, pMode, pRotation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeEx(Displaymodeex* pMode, ref Displayrotation pRotation)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displayrotation* pRotationPtr = &pRotation)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[12])(@this, pMode, pRotationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeEx(ref Displaymodeex pMode, Displayrotation* pRotation)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodeex* pModePtr = &pMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[12])(@this, pModePtr, pRotation);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayModeEx(ref Displaymodeex pMode, ref Displayrotation pRotation)
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodeex* pModePtr = &pMode)
            {
                fixed (Displayrotation* pRotationPtr = &pRotation)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[12])(@this, pModePtr, pRotationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrontBufferData<TI0>(ComPtr<TI0> pDestSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFrontBufferData((IDirect3DSurface9*) pDestSurface.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBackBuffer<TI0>(uint iBackBuffer, BackbufferType Type, ref ComPtr<TI0> ppBackBuffer) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBackBuffer(iBackBuffer, Type, (IDirect3DSurface9**) ppBackBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDevice<TI0>(ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDevice((IDirect3DDevice9**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DSwapChain9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
