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
    [Guid("d0223b96-bf7a-43fd-92bd-a43b0d82b9eb")]
    [NativeName("Name", "IDirect3DDevice9")]
    public unsafe partial struct IDirect3DDevice9 : IComVtbl<IDirect3DDevice9>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d0223b96-bf7a-43fd-92bd-a43b0d82b9eb");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DDevice9 val)
            => Unsafe.As<IDirect3DDevice9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DDevice9
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
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int TestCooperativeLevel()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetAvailableTextureMem()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EvictManagedResources()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDirect3D(IDirect3D9** ppD3D9)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3D9**, int>)@this->LpVtbl[6])(@this, ppD3D9);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDirect3D(ref IDirect3D9* ppD3D9)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3D9** ppD3D9Ptr = &ppD3D9)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3D9**, int>)@this->LpVtbl[6])(@this, ppD3D9Ptr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceCaps(Caps9* pCaps)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Caps9*, int>)@this->LpVtbl[7])(@this, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceCaps(ref Caps9 pCaps)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Caps9* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Caps9*, int>)@this->LpVtbl[7])(@this, pCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayMode(uint iSwapChain, Displaymode* pMode)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Displaymode*, int>)@this->LpVtbl[8])(@this, iSwapChain, pMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayMode(uint iSwapChain, ref Displaymode pMode)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymode* pModePtr = &pMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Displaymode*, int>)@this->LpVtbl[8])(@this, iSwapChain, pModePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(DeviceCreationParameters* pParameters)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, DeviceCreationParameters*, int>)@this->LpVtbl[9])(@this, pParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCreationParameters(ref DeviceCreationParameters pParameters)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DeviceCreationParameters* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, DeviceCreationParameters*, int>)@this->LpVtbl[9])(@this, pParametersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetCursorProperties(uint XHotSpot, uint YHotSpot, IDirect3DSurface9* pCursorBitmap)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)@this->LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCursorProperties(uint XHotSpot, uint YHotSpot, ref IDirect3DSurface9 pCursorBitmap)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pCursorBitmapPtr = &pCursorBitmap)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)@this->LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetCursorPosition(int X, int Y, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int, int, uint, void>)@this->LpVtbl[11])(@this, X, Y, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 ShowCursor(Silk.NET.Core.Bool32 bShow)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32>)@this->LpVtbl[12])(@this, bShow);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAdditionalSwapChain(PresentParameters* pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)@this->LpVtbl[13])(@this, pPresentationParameters, pSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAdditionalSwapChain(PresentParameters* pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)@this->LpVtbl[13])(@this, pPresentationParameters, pSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAdditionalSwapChain(ref PresentParameters pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)@this->LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAdditionalSwapChain(ref PresentParameters pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)@this->LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChain(uint iSwapChain, IDirect3DSwapChain9** pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)@this->LpVtbl[14])(@this, iSwapChain, pSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChain(uint iSwapChain, ref IDirect3DSwapChain9* pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)@this->LpVtbl[14])(@this, iSwapChain, pSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNumberOfSwapChains()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint>)@this->LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(PresentParameters* pPresentationParameters)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, int>)@this->LpVtbl[16])(@this, pPresentationParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset(ref PresentParameters pPresentationParameters)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, int>)@this->LpVtbl[16])(@this, pPresentationParametersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Present([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                {
                    fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBackBuffer(uint iSwapChain, uint iBackBuffer, BackbufferType Type, IDirect3DSurface9** ppBackBuffer)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBackBuffer(uint iSwapChain, uint iBackBuffer, BackbufferType Type, ref IDirect3DSurface9* ppBackBuffer)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppBackBufferPtr = &ppBackBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRasterStatus(uint iSwapChain, RasterStatus* pRasterStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, RasterStatus*, int>)@this->LpVtbl[19])(@this, iSwapChain, pRasterStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRasterStatus(uint iSwapChain, ref RasterStatus pRasterStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RasterStatus* pRasterStatusPtr = &pRasterStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, RasterStatus*, int>)@this->LpVtbl[19])(@this, iSwapChain, pRasterStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDialogBoxMode(Silk.NET.Core.Bool32 bEnableDialogs)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[20])(@this, bEnableDialogs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetGammaRamp(uint iSwapChain, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Gammaramp* pRamp)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Gammaramp*, void>)@this->LpVtbl[21])(@this, iSwapChain, Flags, pRamp);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGammaRamp(uint iSwapChain, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Gammaramp pRamp)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Gammaramp* pRampPtr = &pRamp)
            {
                ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Gammaramp*, void>)@this->LpVtbl[21])(@this, iSwapChain, Flags, pRampPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetGammaRamp(uint iSwapChain, Gammaramp* pRamp)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Gammaramp*, void>)@this->LpVtbl[22])(@this, iSwapChain, pRamp);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetGammaRamp(uint iSwapChain, ref Gammaramp pRamp)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Gammaramp* pRampPtr = &pRamp)
            {
                ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Gammaramp*, void>)@this->LpVtbl[22])(@this, iSwapChain, pRampPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DTexture9** ppTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)@this->LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DTexture9** ppTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)@this->LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DTexture9* ppTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DTexture9** ppTexturePtr = &ppTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)@this->LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DTexture9* ppTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DTexture9** ppTexturePtr = &ppTexture)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)@this->LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)@this->LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)@this->LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DVolumeTexture9* ppVolumeTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVolumeTexture9** ppVolumeTexturePtr = &ppVolumeTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)@this->LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DVolumeTexture9* ppVolumeTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVolumeTexture9** ppVolumeTexturePtr = &ppVolumeTexture)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)@this->LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DCubeTexture9** ppCubeTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)@this->LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DCubeTexture9** ppCubeTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)@this->LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DCubeTexture9* ppCubeTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DCubeTexture9** ppCubeTexturePtr = &ppCubeTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)@this->LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DCubeTexture9* ppCubeTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DCubeTexture9** ppCubeTexturePtr = &ppCubeTexture)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)@this->LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)@this->LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)@this->LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, ref IDirect3DVertexBuffer9* ppVertexBuffer, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9** ppVertexBufferPtr = &ppVertexBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)@this->LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, ref IDirect3DVertexBuffer9* ppVertexBuffer, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9** ppVertexBufferPtr = &ppVertexBuffer)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)@this->LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, IDirect3DIndexBuffer9** ppIndexBuffer, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)@this->LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, IDirect3DIndexBuffer9** ppIndexBuffer, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)@this->LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, ref IDirect3DIndexBuffer9* ppIndexBuffer, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DIndexBuffer9** ppIndexBufferPtr = &ppIndexBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)@this->LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, ref IDirect3DIndexBuffer9* ppIndexBuffer, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DIndexBuffer9** ppIndexBufferPtr = &ppIndexBuffer)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)@this->LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPoint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPoint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPoint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPointPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPoint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPoint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                    {
                        fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTexture(IDirect3DBaseTexture9* pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)@this->LpVtbl[31])(@this, pSourceTexture, pDestinationTexture);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTexture(IDirect3DBaseTexture9* pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DBaseTexture9* pDestinationTexturePtr = &pDestinationTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)@this->LpVtbl[31])(@this, pSourceTexture, pDestinationTexturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTexture(ref IDirect3DBaseTexture9 pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DBaseTexture9* pSourceTexturePtr = &pSourceTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)@this->LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexture);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateTexture(ref IDirect3DBaseTexture9 pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DBaseTexture9* pSourceTexturePtr = &pSourceTexture)
            {
                fixed (IDirect3DBaseTexture9* pDestinationTexturePtr = &pDestinationTexture)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)@this->LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderTargetData(IDirect3DSurface9* pRenderTarget, IDirect3DSurface9* pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)@this->LpVtbl[32])(@this, pRenderTarget, pDestSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderTargetData(IDirect3DSurface9* pRenderTarget, ref IDirect3DSurface9 pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)@this->LpVtbl[32])(@this, pRenderTarget, pDestSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderTargetData(ref IDirect3DSurface9 pRenderTarget, IDirect3DSurface9* pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)@this->LpVtbl[32])(@this, pRenderTargetPtr, pDestSurface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRenderTargetData(ref IDirect3DSurface9 pRenderTarget, ref IDirect3DSurface9 pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)@this->LpVtbl[32])(@this, pRenderTargetPtr, pDestSurfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrontBufferData(uint iSwapChain, IDirect3DSurface9* pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)@this->LpVtbl[33])(@this, iSwapChain, pDestSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrontBufferData(uint iSwapChain, ref IDirect3DSurface9 pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)@this->LpVtbl[33])(@this, iSwapChain, pDestSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRectPtr, Filter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRect, Filter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRect, Filter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRectPtr, Filter);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRect, Filter);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StretchRect(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                    {
                        fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ColorFill(IDirect3DSurface9* pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint color)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[35])(@this, pSurface, pRect, color);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ColorFill(IDirect3DSurface9* pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect, uint color)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[35])(@this, pSurface, pRectPtr, color);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ColorFill(ref IDirect3DSurface9 pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint color)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSurfacePtr = &pSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[35])(@this, pSurfacePtr, pRect, color);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ColorFill(ref IDirect3DSurface9 pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect, uint color)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSurfacePtr = &pSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[35])(@this, pSurfacePtr, pRectPtr, color);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)@this->LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)@this->LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)@this->LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)@this->LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetRenderTarget(uint RenderTargetIndex, IDirect3DSurface9* pRenderTarget)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)@this->LpVtbl[37])(@this, RenderTargetIndex, pRenderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRenderTarget(uint RenderTargetIndex, ref IDirect3DSurface9 pRenderTarget)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)@this->LpVtbl[37])(@this, RenderTargetIndex, pRenderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderTarget(uint RenderTargetIndex, IDirect3DSurface9** ppRenderTarget)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)@this->LpVtbl[38])(@this, RenderTargetIndex, ppRenderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderTarget(uint RenderTargetIndex, ref IDirect3DSurface9* ppRenderTarget)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppRenderTargetPtr = &ppRenderTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)@this->LpVtbl[38])(@this, RenderTargetIndex, ppRenderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetDepthStencilSurface(IDirect3DSurface9* pNewZStencil)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, int>)@this->LpVtbl[39])(@this, pNewZStencil);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDepthStencilSurface(ref IDirect3DSurface9 pNewZStencil)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pNewZStencilPtr = &pNewZStencil)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, int>)@this->LpVtbl[39])(@this, pNewZStencilPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDepthStencilSurface(IDirect3DSurface9** ppZStencilSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9**, int>)@this->LpVtbl[40])(@this, ppZStencilSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDepthStencilSurface(ref IDirect3DSurface9* ppZStencilSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppZStencilSurfacePtr = &ppZStencilSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9**, int>)@this->LpVtbl[40])(@this, ppZStencilSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginScene()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)@this->LpVtbl[41])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndScene()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)@this->LpVtbl[42])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clear(uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Rect* pRects, uint Flags, uint Color, float Z, uint Stencil)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Rect*, uint, uint, float, uint, int>)@this->LpVtbl[43])(@this, Count, pRects, Flags, Color, Z, Stencil);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Clear(uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Rect pRects, uint Flags, uint Color, float Z, uint Stencil)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Rect* pRectsPtr = &pRects)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Rect*, uint, uint, float, uint, int>)@this->LpVtbl[43])(@this, Count, pRectsPtr, Flags, Color, Z, Stencil);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTransform(Transformstatetype State, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* pMatrix)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[44])(@this, State, pMatrix);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTransform(Transformstatetype State, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 pMatrix)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (System.Numerics.Matrix4x4* pMatrixPtr = &pMatrix)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[44])(@this, State, pMatrixPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTransform(Transformstatetype State, System.Numerics.Matrix4x4* pMatrix)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[45])(@this, State, pMatrix);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTransform(Transformstatetype State, ref System.Numerics.Matrix4x4 pMatrix)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (System.Numerics.Matrix4x4* pMatrixPtr = &pMatrix)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[45])(@this, State, pMatrixPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MultiplyTransform(Transformstatetype arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[46])(@this, arg0, arg1);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MultiplyTransform(Transformstatetype arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (System.Numerics.Matrix4x4* arg1Ptr = &arg1)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[46])(@this, arg0, arg1Ptr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetViewport([Flow(Silk.NET.Core.Native.FlowDirection.In)] Viewport9* pViewport)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Viewport9*, int>)@this->LpVtbl[47])(@this, pViewport);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetViewport([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Viewport9 pViewport)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Viewport9* pViewportPtr = &pViewport)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Viewport9*, int>)@this->LpVtbl[47])(@this, pViewportPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetViewport(Viewport9* pViewport)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Viewport9*, int>)@this->LpVtbl[48])(@this, pViewport);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetViewport(ref Viewport9 pViewport)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Viewport9* pViewportPtr = &pViewport)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Viewport9*, int>)@this->LpVtbl[48])(@this, pViewportPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] Material9* pMaterial)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Material9*, int>)@this->LpVtbl[49])(@this, pMaterial);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material9 pMaterial)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Material9* pMaterialPtr = &pMaterial)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Material9*, int>)@this->LpVtbl[49])(@this, pMaterialPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaterial(Material9* pMaterial)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Material9*, int>)@this->LpVtbl[50])(@this, pMaterial);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMaterial(ref Material9 pMaterial)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Material9* pMaterialPtr = &pMaterial)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Material9*, int>)@this->LpVtbl[50])(@this, pMaterialPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetLight(uint Index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Light9* arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Light9*, int>)@this->LpVtbl[51])(@this, Index, arg1);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLight(uint Index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Light9 arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Light9* arg1Ptr = &arg1)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Light9*, int>)@this->LpVtbl[51])(@this, Index, arg1Ptr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLight(uint Index, Light9* arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Light9*, int>)@this->LpVtbl[52])(@this, Index, arg1);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLight(uint Index, ref Light9 arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Light9* arg1Ptr = &arg1)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Light9*, int>)@this->LpVtbl[52])(@this, Index, arg1Ptr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LightEnable(uint Index, Silk.NET.Core.Bool32 Enable)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Core.Bool32, int>)@this->LpVtbl[53])(@this, Index, Enable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLightEnable(uint Index, int* pEnable)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, int>)@this->LpVtbl[54])(@this, Index, pEnable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLightEnable(uint Index, ref int pEnable)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pEnablePtr = &pEnable)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, int>)@this->LpVtbl[54])(@this, Index, pEnablePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetClipPlane(uint Index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pPlane)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, int>)@this->LpVtbl[55])(@this, Index, pPlane);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetClipPlane(uint Index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pPlane)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pPlanePtr = &pPlane)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, int>)@this->LpVtbl[55])(@this, Index, pPlanePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClipPlane(uint Index, float* pPlane)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, int>)@this->LpVtbl[56])(@this, Index, pPlane);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClipPlane(uint Index, ref float pPlane)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pPlanePtr = &pPlane)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, int>)@this->LpVtbl[56])(@this, Index, pPlanePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRenderState(Renderstatetype State, uint Value)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Renderstatetype, uint, int>)@this->LpVtbl[57])(@this, State, Value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderState(Renderstatetype State, uint* pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Renderstatetype, uint*, int>)@this->LpVtbl[58])(@this, State, pValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRenderState(Renderstatetype State, ref uint pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Renderstatetype, uint*, int>)@this->LpVtbl[58])(@this, State, pValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateBlock(Stateblocktype Type, IDirect3DStateBlock9** ppSB)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Stateblocktype, IDirect3DStateBlock9**, int>)@this->LpVtbl[59])(@this, Type, ppSB);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateBlock(Stateblocktype Type, ref IDirect3DStateBlock9* ppSB)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DStateBlock9** ppSBPtr = &ppSB)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Stateblocktype, IDirect3DStateBlock9**, int>)@this->LpVtbl[59])(@this, Type, ppSBPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginStateBlock()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)@this->LpVtbl[60])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndStateBlock(IDirect3DStateBlock9** ppSB)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)@this->LpVtbl[61])(@this, ppSB);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndStateBlock(ref IDirect3DStateBlock9* ppSB)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DStateBlock9** ppSBPtr = &ppSB)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)@this->LpVtbl[61])(@this, ppSBPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetClipStatus([Flow(Silk.NET.Core.Native.FlowDirection.In)] Clipstatus9* pClipStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Clipstatus9*, int>)@this->LpVtbl[62])(@this, pClipStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetClipStatus([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Clipstatus9 pClipStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Clipstatus9* pClipStatusPtr = &pClipStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Clipstatus9*, int>)@this->LpVtbl[62])(@this, pClipStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClipStatus(Clipstatus9* pClipStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Clipstatus9*, int>)@this->LpVtbl[63])(@this, pClipStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClipStatus(ref Clipstatus9 pClipStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Clipstatus9* pClipStatusPtr = &pClipStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Clipstatus9*, int>)@this->LpVtbl[63])(@this, pClipStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTexture(uint Stage, IDirect3DBaseTexture9** ppTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)@this->LpVtbl[64])(@this, Stage, ppTexture);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTexture(uint Stage, ref IDirect3DBaseTexture9* ppTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DBaseTexture9** ppTexturePtr = &ppTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)@this->LpVtbl[64])(@this, Stage, ppTexturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTexture(uint Stage, IDirect3DBaseTexture9* pTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)@this->LpVtbl[65])(@this, Stage, pTexture);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTexture(uint Stage, ref IDirect3DBaseTexture9 pTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DBaseTexture9* pTexturePtr = &pTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)@this->LpVtbl[65])(@this, Stage, pTexturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextureStageState(uint Stage, Texturestagestatetype Type, uint* pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Texturestagestatetype, uint*, int>)@this->LpVtbl[66])(@this, Stage, Type, pValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTextureStageState(uint Stage, Texturestagestatetype Type, ref uint pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Texturestagestatetype, uint*, int>)@this->LpVtbl[66])(@this, Stage, Type, pValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextureStageState(uint Stage, Texturestagestatetype Type, uint Value)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Texturestagestatetype, uint, int>)@this->LpVtbl[67])(@this, Stage, Type, Value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSamplerState(uint Sampler, Samplerstatetype Type, uint* pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Samplerstatetype, uint*, int>)@this->LpVtbl[68])(@this, Sampler, Type, pValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSamplerState(uint Sampler, Samplerstatetype Type, ref uint pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Samplerstatetype, uint*, int>)@this->LpVtbl[68])(@this, Sampler, Type, pValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSamplerState(uint Sampler, Samplerstatetype Type, uint Value)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Samplerstatetype, uint, int>)@this->LpVtbl[69])(@this, Sampler, Type, Value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateDevice(uint* pNumPasses)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)@this->LpVtbl[70])(@this, pNumPasses);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ValidateDevice(ref uint pNumPasses)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumPassesPtr = &pNumPasses)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)@this->LpVtbl[70])(@this, pNumPassesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPaletteEntries(uint PaletteNumber, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector4D<byte>* pEntries)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[71])(@this, PaletteNumber, pEntries);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPaletteEntries(uint PaletteNumber, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector4D<byte> pEntries)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector4D<byte>* pEntriesPtr = &pEntries)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[71])(@this, PaletteNumber, pEntriesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPaletteEntries(uint PaletteNumber, Silk.NET.Maths.Vector4D<byte>* pEntries)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[72])(@this, PaletteNumber, pEntries);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPaletteEntries(uint PaletteNumber, ref Silk.NET.Maths.Vector4D<byte> pEntries)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector4D<byte>* pEntriesPtr = &pEntries)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[72])(@this, PaletteNumber, pEntriesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCurrentTexturePalette(uint PaletteNumber)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int>)@this->LpVtbl[73])(@this, PaletteNumber);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentTexturePalette(uint* PaletteNumber)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)@this->LpVtbl[74])(@this, PaletteNumber);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCurrentTexturePalette(ref uint PaletteNumber)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* PaletteNumberPtr = &PaletteNumber)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)@this->LpVtbl[74])(@this, PaletteNumberPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetScissorRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[75])(@this, pRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetScissorRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[75])(@this, pRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetScissorRect(Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[76])(@this, pRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetScissorRect(ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[76])(@this, pRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSoftwareVertexProcessing(Silk.NET.Core.Bool32 bSoftware)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[77])(@this, bSoftware);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetSoftwareVertexProcessing()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Core.Bool32>)@this->LpVtbl[78])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetNPatchMode(float nSegments)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, float, int>)@this->LpVtbl[79])(@this, nSegments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetNPatchMode()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, float>)@this->LpVtbl[80])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawPrimitive(Primitivetype PrimitiveType, uint StartVertex, uint PrimitiveCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, int>)@this->LpVtbl[81])(@this, PrimitiveType, StartVertex, PrimitiveCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawIndexedPrimitive(Primitivetype arg0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, int, uint, uint, uint, uint, int>)@this->LpVtbl[82])(@this, arg0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawPrimitiveUP(Primitivetype PrimitiveType, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, void*, uint, int>)@this->LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawPrimitiveUP<T0>(Primitivetype PrimitiveType, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, void*, uint, int>)@this->LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawIndexedPrimitiveUP(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pIndexData, Format IndexDataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)@this->LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawIndexedPrimitiveUP<T0>(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pIndexData, Format IndexDataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)@this->LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawIndexedPrimitiveUP<T0>(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pIndexData, Format IndexDataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pIndexDataPtr = &pIndexData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)@this->LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawIndexedPrimitiveUP<T0, T1>(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pIndexData, Format IndexDataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pIndexDataPtr = &pIndexData)
            {
                fixed (void* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)@this->LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)@this->LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexDeclaration9* pVertexDeclPtr = &pVertexDecl)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)@this->LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDeclPtr, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9* pDestBufferPtr = &pDestBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)@this->LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDecl, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9* pDestBufferPtr = &pDestBuffer)
            {
                fixed (IDirect3DVertexDeclaration9* pVertexDeclPtr = &pVertexDecl)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)@this->LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDeclPtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexDeclaration([Flow(Silk.NET.Core.Native.FlowDirection.In)] Vertexelement9* pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[86])(@this, pVertexElements, ppDecl);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexDeclaration([Flow(Silk.NET.Core.Native.FlowDirection.In)] Vertexelement9* pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[86])(@this, pVertexElements, ppDeclPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexDeclaration([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Vertexelement9 pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Vertexelement9* pVertexElementsPtr = &pVertexElements)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[86])(@this, pVertexElementsPtr, ppDecl);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexDeclaration([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Vertexelement9 pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Vertexelement9* pVertexElementsPtr = &pVertexElements)
            {
                fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[86])(@this, pVertexElementsPtr, ppDeclPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexDeclaration(IDirect3DVertexDeclaration9* pDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)@this->LpVtbl[87])(@this, pDecl);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexDeclaration(ref IDirect3DVertexDeclaration9 pDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexDeclaration9* pDeclPtr = &pDecl)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)@this->LpVtbl[87])(@this, pDeclPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexDeclaration(IDirect3DVertexDeclaration9** ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[88])(@this, ppDecl);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexDeclaration(ref IDirect3DVertexDeclaration9* ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[88])(@this, ppDeclPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFVF(uint FVF)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int>)@this->LpVtbl[89])(@this, FVF);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFVF(uint* pFVF)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)@this->LpVtbl[90])(@this, pFVF);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFVF(ref uint pFVF)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFVFPtr = &pFVF)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)@this->LpVtbl[90])(@this, pFVFPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, IDirect3DVertexShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)@this->LpVtbl[91])(@this, pFunction, ppShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, ref IDirect3DVertexShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)@this->LpVtbl[91])(@this, pFunction, ppShaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFunction, IDirect3DVertexShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFunctionPtr = &pFunction)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)@this->LpVtbl[91])(@this, pFunctionPtr, ppShader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFunction, ref IDirect3DVertexShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFunctionPtr = &pFunction)
            {
                fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)@this->LpVtbl[91])(@this, pFunctionPtr, ppShaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexShader(IDirect3DVertexShader9* pShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)@this->LpVtbl[92])(@this, pShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexShader(ref IDirect3DVertexShader9 pShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexShader9* pShaderPtr = &pShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)@this->LpVtbl[92])(@this, pShaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexShader(IDirect3DVertexShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)@this->LpVtbl[93])(@this, ppShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexShader(ref IDirect3DVertexShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)@this->LpVtbl[93])(@this, ppShaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexShaderConstantF(uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)@this->LpVtbl[94])(@this, StartRegister, pConstantData, Vector4fCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexShaderConstantF(uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)@this->LpVtbl[94])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)@this->LpVtbl[95])(@this, StartRegister, pConstantData, Vector4fCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVertexShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)@this->LpVtbl[95])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexShaderConstantI(uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[96])(@this, StartRegister, pConstantData, Vector4iCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexShaderConstantI(uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[96])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[97])(@this, StartRegister, pConstantData, Vector4iCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVertexShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[97])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexShaderConstantB(uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[98])(@this, StartRegister, pConstantData, BoolCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexShaderConstantB(uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[98])(@this, StartRegister, pConstantDataPtr, BoolCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[99])(@this, StartRegister, pConstantData, BoolCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVertexShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[99])(@this, StartRegister, pConstantDataPtr, BoolCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9* pStreamData, uint OffsetInBytes, uint Stride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)@this->LpVtbl[100])(@this, StreamNumber, pStreamData, OffsetInBytes, Stride);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9 pStreamData, uint OffsetInBytes, uint Stride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9* pStreamDataPtr = &pStreamData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)@this->LpVtbl[100])(@this, StreamNumber, pStreamDataPtr, OffsetInBytes, Stride);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, uint* pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStride);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, ref uint pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pStridePtr = &pStride)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStridePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, ref uint pOffsetInBytes, uint* pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytesPtr, pStride);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, ref uint pOffsetInBytes, ref uint pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
            {
                fixed (uint* pStridePtr = &pStride)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytesPtr, pStridePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* pOffsetInBytes, uint* pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytes, pStride);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* pOffsetInBytes, ref uint pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
            {
                fixed (uint* pStridePtr = &pStride)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytes, pStridePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, ref uint pOffsetInBytes, uint* pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
            {
                fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytesPtr, pStride);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, ref uint pOffsetInBytes, ref uint pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
            {
                fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
                {
                    fixed (uint* pStridePtr = &pStride)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytesPtr, pStridePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStreamSourceFreq(uint StreamNumber, uint Setting)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, int>)@this->LpVtbl[102])(@this, StreamNumber, Setting);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSourceFreq(uint StreamNumber, uint* pSetting)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint*, int>)@this->LpVtbl[103])(@this, StreamNumber, pSetting);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStreamSourceFreq(uint StreamNumber, ref uint pSetting)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSettingPtr = &pSetting)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint*, int>)@this->LpVtbl[103])(@this, StreamNumber, pSettingPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetIndices(IDirect3DIndexBuffer9* pIndexData)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)@this->LpVtbl[104])(@this, pIndexData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetIndices(ref IDirect3DIndexBuffer9 pIndexData)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DIndexBuffer9* pIndexDataPtr = &pIndexData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)@this->LpVtbl[104])(@this, pIndexDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIndices(IDirect3DIndexBuffer9** ppIndexData)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)@this->LpVtbl[105])(@this, ppIndexData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIndices(ref IDirect3DIndexBuffer9* ppIndexData)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DIndexBuffer9** ppIndexDataPtr = &ppIndexData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)@this->LpVtbl[105])(@this, ppIndexDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePixelShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, IDirect3DPixelShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)@this->LpVtbl[106])(@this, pFunction, ppShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePixelShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, ref IDirect3DPixelShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)@this->LpVtbl[106])(@this, pFunction, ppShaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePixelShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFunction, IDirect3DPixelShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFunctionPtr = &pFunction)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)@this->LpVtbl[106])(@this, pFunctionPtr, ppShader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePixelShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFunction, ref IDirect3DPixelShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFunctionPtr = &pFunction)
            {
                fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)@this->LpVtbl[106])(@this, pFunctionPtr, ppShaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPixelShader(IDirect3DPixelShader9* pShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)@this->LpVtbl[107])(@this, pShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelShader(ref IDirect3DPixelShader9 pShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DPixelShader9* pShaderPtr = &pShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)@this->LpVtbl[107])(@this, pShaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelShader(IDirect3DPixelShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)@this->LpVtbl[108])(@this, ppShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelShader(ref IDirect3DPixelShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)@this->LpVtbl[108])(@this, ppShaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPixelShaderConstantF(uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)@this->LpVtbl[109])(@this, StartRegister, pConstantData, Vector4fCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelShaderConstantF(uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)@this->LpVtbl[109])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)@this->LpVtbl[110])(@this, StartRegister, pConstantData, Vector4fCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)@this->LpVtbl[110])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPixelShaderConstantI(uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[111])(@this, StartRegister, pConstantData, Vector4iCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelShaderConstantI(uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[111])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[112])(@this, StartRegister, pConstantData, Vector4iCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[112])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPixelShaderConstantB(uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[113])(@this, StartRegister, pConstantData, BoolCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelShaderConstantB(uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[113])(@this, StartRegister, pConstantDataPtr, BoolCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[114])(@this, StartRegister, pConstantData, BoolCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)@this->LpVtbl[114])(@this, StartRegister, pConstantDataPtr, BoolCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectPatch(uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RectpatchInfo* pRectPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)@this->LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectPatch(uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RectpatchInfo pRectPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RectpatchInfo* pRectPatchInfoPtr = &pRectPatchInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)@this->LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectPatch(uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RectpatchInfo* pRectPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pNumSegsPtr = &pNumSegs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)@this->LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfo);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawRectPatch(uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RectpatchInfo pRectPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pNumSegsPtr = &pNumSegs)
            {
                fixed (RectpatchInfo* pRectPatchInfoPtr = &pRectPatchInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)@this->LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfoPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawTriPatch(uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TripatchInfo* pTriPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)@this->LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawTriPatch(uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TripatchInfo pTriPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TripatchInfo* pTriPatchInfoPtr = &pTriPatchInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)@this->LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawTriPatch(uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TripatchInfo* pTriPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pNumSegsPtr = &pNumSegs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)@this->LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfo);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawTriPatch(uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TripatchInfo pTriPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pNumSegsPtr = &pNumSegs)
            {
                fixed (TripatchInfo* pTriPatchInfoPtr = &pTriPatchInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)@this->LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfoPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DeletePatch(uint Handle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int>)@this->LpVtbl[117])(@this, Handle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQuery(Querytype Type, IDirect3DQuery9** ppQuery)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Querytype, IDirect3DQuery9**, int>)@this->LpVtbl[118])(@this, Type, ppQuery);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQuery(Querytype Type, ref IDirect3DQuery9* ppQuery)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DQuery9** ppQueryPtr = &ppQuery)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Querytype, IDirect3DQuery9**, int>)@this->LpVtbl[118])(@this, Type, ppQueryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDirect3D<TI0>(ref ComPtr<TI0> ppD3D9) where TI0 : unmanaged, IComVtbl<IDirect3D9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDirect3D((IDirect3D9**) ppD3D9.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCursorProperties<TI0>(uint XHotSpot, uint YHotSpot, ComPtr<TI0> pCursorBitmap) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetCursorProperties(XHotSpot, YHotSpot, (IDirect3DSurface9*) pCursorBitmap.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAdditionalSwapChain<TI0>(PresentParameters* pPresentationParameters, ref ComPtr<TI0> pSwapChain) where TI0 : unmanaged, IComVtbl<IDirect3DSwapChain9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateAdditionalSwapChain(pPresentationParameters, (IDirect3DSwapChain9**) pSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateAdditionalSwapChain<TI0>(ref PresentParameters pPresentationParameters, ref ComPtr<TI0> pSwapChain) where TI0 : unmanaged, IComVtbl<IDirect3DSwapChain9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateAdditionalSwapChain(ref pPresentationParameters, (IDirect3DSwapChain9**) pSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSwapChain<TI0>(uint iSwapChain, ref ComPtr<TI0> pSwapChain) where TI0 : unmanaged, IComVtbl<IDirect3DSwapChain9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSwapChain(iSwapChain, (IDirect3DSwapChain9**) pSwapChain.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBackBuffer<TI0>(uint iSwapChain, uint iBackBuffer, BackbufferType Type, ref ComPtr<TI0> ppBackBuffer) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBackBuffer(iSwapChain, iBackBuffer, Type, (IDirect3DSurface9**) ppBackBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture<TI0>(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppTexture, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DTexture9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTexture(Width, Height, Levels, Usage, Format, Pool, (IDirect3DTexture9**) ppTexture.GetAddressOf(), pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture<TI0>(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppTexture, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DTexture9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTexture(Width, Height, Levels, Usage, Format, Pool, (IDirect3DTexture9**) ppTexture.GetAddressOf(), ref pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVolumeTexture<TI0>(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppVolumeTexture, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DVolumeTexture9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVolumeTexture(Width, Height, Depth, Levels, Usage, Format, Pool, (IDirect3DVolumeTexture9**) ppVolumeTexture.GetAddressOf(), pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVolumeTexture<TI0>(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppVolumeTexture, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DVolumeTexture9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVolumeTexture(Width, Height, Depth, Levels, Usage, Format, Pool, (IDirect3DVolumeTexture9**) ppVolumeTexture.GetAddressOf(), ref pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCubeTexture<TI0>(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppCubeTexture, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DCubeTexture9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCubeTexture(EdgeLength, Levels, Usage, Format, Pool, (IDirect3DCubeTexture9**) ppCubeTexture.GetAddressOf(), pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCubeTexture<TI0>(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppCubeTexture, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DCubeTexture9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCubeTexture(EdgeLength, Levels, Usage, Format, Pool, (IDirect3DCubeTexture9**) ppCubeTexture.GetAddressOf(), ref pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer<TI0>(uint Length, uint Usage, uint FVF, Pool Pool, ref ComPtr<TI0> ppVertexBuffer, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexBuffer(Length, Usage, FVF, Pool, (IDirect3DVertexBuffer9**) ppVertexBuffer.GetAddressOf(), pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer<TI0>(uint Length, uint Usage, uint FVF, Pool Pool, ref ComPtr<TI0> ppVertexBuffer, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexBuffer(Length, Usage, FVF, Pool, (IDirect3DVertexBuffer9**) ppVertexBuffer.GetAddressOf(), ref pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateIndexBuffer<TI0>(uint Length, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppIndexBuffer, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DIndexBuffer9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateIndexBuffer(Length, Usage, Format, Pool, (IDirect3DIndexBuffer9**) ppIndexBuffer.GetAddressOf(), pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateIndexBuffer<TI0>(uint Length, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppIndexBuffer, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DIndexBuffer9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateIndexBuffer(Length, Usage, Format, Pool, (IDirect3DIndexBuffer9**) ppIndexBuffer.GetAddressOf(), ref pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderTarget<TI0>(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, ref ComPtr<TI0> ppSurface, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRenderTarget(Width, Height, Format, MultiSample, MultisampleQuality, Lockable, (IDirect3DSurface9**) ppSurface.GetAddressOf(), pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderTarget<TI0>(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, ref ComPtr<TI0> ppSurface, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRenderTarget(Width, Height, Format, MultiSample, MultisampleQuality, Lockable, (IDirect3DSurface9**) ppSurface.GetAddressOf(), ref pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDepthStencilSurface<TI0>(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, ref ComPtr<TI0> ppSurface, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDepthStencilSurface(Width, Height, Format, MultiSample, MultisampleQuality, Discard, (IDirect3DSurface9**) ppSurface.GetAddressOf(), pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDepthStencilSurface<TI0>(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, ref ComPtr<TI0> ppSurface, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDepthStencilSurface(Width, Height, Format, MultiSample, MultisampleQuality, Discard, (IDirect3DSurface9**) ppSurface.GetAddressOf(), ref pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface<TI0, TI1>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI1> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, pDestPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface<TI0, TI1>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI1> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, in pDestPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface<TI0>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, ref pDestinationSurface, pDestPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface<TI0>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, ref pDestinationSurface, in pDestPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface<TI0, TI1>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI1> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, pDestPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateSurface<TI0, TI1>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI1> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, in pDestPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface<TI0>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, ref pDestinationSurface, pDestPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateSurface<TI0>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, ref pDestinationSurface, in pDestPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface<TI0>(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI0> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateSurface(ref pSourceSurface, pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, pDestPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface<TI0>(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI0> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateSurface(ref pSourceSurface, pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, in pDestPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface<TI0>(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI0> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateSurface(ref pSourceSurface, in pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, pDestPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateSurface<TI0>(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI0> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateSurface(ref pSourceSurface, in pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, in pDestPoint);
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateTexture<TI0, TI1>(ComPtr<TI0> pSourceTexture, ComPtr<TI1> pDestinationTexture) where TI0 : unmanaged, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<TI1>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTexture((IDirect3DBaseTexture9*) pSourceTexture.Handle, (IDirect3DBaseTexture9*) pDestinationTexture.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateTexture<TI0>(ComPtr<TI0> pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture) where TI0 : unmanaged, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTexture((IDirect3DBaseTexture9*) pSourceTexture.Handle, ref pDestinationTexture);
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateTexture<TI0>(ref IDirect3DBaseTexture9 pSourceTexture, ComPtr<TI0> pDestinationTexture) where TI0 : unmanaged, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTexture(ref pSourceTexture, (IDirect3DBaseTexture9*) pDestinationTexture.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRenderTargetData<TI0, TI1>(ComPtr<TI0> pRenderTarget, ComPtr<TI1> pDestSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRenderTargetData((IDirect3DSurface9*) pRenderTarget.Handle, (IDirect3DSurface9*) pDestSurface.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRenderTargetData<TI0>(ComPtr<TI0> pRenderTarget, ref IDirect3DSurface9 pDestSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRenderTargetData((IDirect3DSurface9*) pRenderTarget.Handle, ref pDestSurface);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRenderTargetData<TI0>(ref IDirect3DSurface9 pRenderTarget, ComPtr<TI0> pDestSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRenderTargetData(ref pRenderTarget, (IDirect3DSurface9*) pDestSurface.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrontBufferData<TI0>(uint iSwapChain, ComPtr<TI0> pDestSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFrontBufferData(iSwapChain, (IDirect3DSurface9*) pDestSurface.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect<TI0, TI1>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI1> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, pDestRect, Filter);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect<TI0, TI1>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI1> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, in pDestRect, Filter);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect<TI0>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, ref pDestSurface, pDestRect, Filter);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect<TI0>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, ref pDestSurface, in pDestRect, Filter);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect<TI0, TI1>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI1> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, pDestRect, Filter);
        }

        /// <summary>To be documented.</summary>
        public readonly int StretchRect<TI0, TI1>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI1> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, in pDestRect, Filter);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect<TI0>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, ref pDestSurface, pDestRect, Filter);
        }

        /// <summary>To be documented.</summary>
        public readonly int StretchRect<TI0>(ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, ref pDestSurface, in pDestRect, Filter);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect<TI0>(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI0> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StretchRect(ref pSourceSurface, pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, pDestRect, Filter);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect<TI0>(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI0> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StretchRect(ref pSourceSurface, pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, in pDestRect, Filter);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect<TI0>(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI0> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StretchRect(ref pSourceSurface, in pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, pDestRect, Filter);
        }

        /// <summary>To be documented.</summary>
        public readonly int StretchRect<TI0>(ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI0> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StretchRect(ref pSourceSurface, in pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, in pDestRect, Filter);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ColorFill<TI0>(ComPtr<TI0> pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint color) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ColorFill((IDirect3DSurface9*) pSurface.Handle, pRect, color);
        }

        /// <summary>To be documented.</summary>
        public readonly int ColorFill<TI0>(ComPtr<TI0> pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect, uint color) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ColorFill((IDirect3DSurface9*) pSurface.Handle, in pRect, color);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface<TI0>(uint Width, uint Height, Format Format, Pool Pool, ref ComPtr<TI0> ppSurface, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateOffscreenPlainSurface(Width, Height, Format, Pool, (IDirect3DSurface9**) ppSurface.GetAddressOf(), pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface<TI0>(uint Width, uint Height, Format Format, Pool Pool, ref ComPtr<TI0> ppSurface, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateOffscreenPlainSurface(Width, Height, Format, Pool, (IDirect3DSurface9**) ppSurface.GetAddressOf(), ref pSharedHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRenderTarget<TI0>(uint RenderTargetIndex, ComPtr<TI0> pRenderTarget) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetRenderTarget(RenderTargetIndex, (IDirect3DSurface9*) pRenderTarget.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRenderTarget<TI0>(uint RenderTargetIndex, ref ComPtr<TI0> ppRenderTarget) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRenderTarget(RenderTargetIndex, (IDirect3DSurface9**) ppRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDepthStencilSurface<TI0>(ComPtr<TI0> pNewZStencil) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetDepthStencilSurface((IDirect3DSurface9*) pNewZStencil.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDepthStencilSurface<TI0>(ref ComPtr<TI0> ppZStencilSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDepthStencilSurface((IDirect3DSurface9**) ppZStencilSurface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStateBlock<TI0>(Stateblocktype Type, ref ComPtr<TI0> ppSB) where TI0 : unmanaged, IComVtbl<IDirect3DStateBlock9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStateBlock(Type, (IDirect3DStateBlock9**) ppSB.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int EndStateBlock<TI0>(ref ComPtr<TI0> ppSB) where TI0 : unmanaged, IComVtbl<IDirect3DStateBlock9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EndStateBlock((IDirect3DStateBlock9**) ppSB.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTexture<TI0>(uint Stage, ref ComPtr<TI0> ppTexture) where TI0 : unmanaged, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTexture(Stage, (IDirect3DBaseTexture9**) ppTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTexture<TI0>(uint Stage, ComPtr<TI0> pTexture) where TI0 : unmanaged, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetTexture(Stage, (IDirect3DBaseTexture9*) pTexture.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int ProcessVertices<TI0, TI1>(uint SrcStartIndex, uint DestIndex, uint VertexCount, ComPtr<TI0> pDestBuffer, ComPtr<TI1> pVertexDecl, uint Flags) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<TI1>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, (IDirect3DVertexBuffer9*) pDestBuffer.Handle, (IDirect3DVertexDeclaration9*) pVertexDecl.Handle, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int ProcessVertices<TI0>(uint SrcStartIndex, uint DestIndex, uint VertexCount, ComPtr<TI0> pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, (IDirect3DVertexBuffer9*) pDestBuffer.Handle, ref pVertexDecl, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int ProcessVertices<TI0>(uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, ComPtr<TI0> pVertexDecl, uint Flags) where TI0 : unmanaged, IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, ref pDestBuffer, (IDirect3DVertexDeclaration9*) pVertexDecl.Handle, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexDeclaration<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Vertexelement9* pVertexElements, ref ComPtr<TI0> ppDecl) where TI0 : unmanaged, IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexDeclaration(pVertexElements, (IDirect3DVertexDeclaration9**) ppDecl.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVertexDeclaration<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Vertexelement9 pVertexElements, ref ComPtr<TI0> ppDecl) where TI0 : unmanaged, IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexDeclaration(in pVertexElements, (IDirect3DVertexDeclaration9**) ppDecl.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexDeclaration<TI0>(ComPtr<TI0> pDecl) where TI0 : unmanaged, IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetVertexDeclaration((IDirect3DVertexDeclaration9*) pDecl.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVertexDeclaration<TI0>(ref ComPtr<TI0> ppDecl) where TI0 : unmanaged, IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetVertexDeclaration((IDirect3DVertexDeclaration9**) ppDecl.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexShader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, ref ComPtr<TI0> ppShader) where TI0 : unmanaged, IComVtbl<IDirect3DVertexShader9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexShader(pFunction, (IDirect3DVertexShader9**) ppShader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVertexShader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFunction, ref ComPtr<TI0> ppShader) where TI0 : unmanaged, IComVtbl<IDirect3DVertexShader9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVertexShader(in pFunction, (IDirect3DVertexShader9**) ppShader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexShader<TI0>(ComPtr<TI0> pShader) where TI0 : unmanaged, IComVtbl<IDirect3DVertexShader9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetVertexShader((IDirect3DVertexShader9*) pShader.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVertexShader<TI0>(ref ComPtr<TI0> ppShader) where TI0 : unmanaged, IComVtbl<IDirect3DVertexShader9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetVertexShader((IDirect3DVertexShader9**) ppShader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStreamSource<TI0>(uint StreamNumber, ComPtr<TI0> pStreamData, uint OffsetInBytes, uint Stride) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetStreamSource(StreamNumber, (IDirect3DVertexBuffer9*) pStreamData.Handle, OffsetInBytes, Stride);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource<TI0>(uint StreamNumber, ref ComPtr<TI0> ppStreamData, uint* pOffsetInBytes, uint* pStride) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetStreamSource(StreamNumber, (IDirect3DVertexBuffer9**) ppStreamData.GetAddressOf(), pOffsetInBytes, pStride);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource<TI0>(uint StreamNumber, ref ComPtr<TI0> ppStreamData, uint* pOffsetInBytes, ref uint pStride) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetStreamSource(StreamNumber, (IDirect3DVertexBuffer9**) ppStreamData.GetAddressOf(), pOffsetInBytes, ref pStride);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource<TI0>(uint StreamNumber, ref ComPtr<TI0> ppStreamData, ref uint pOffsetInBytes, uint* pStride) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetStreamSource(StreamNumber, (IDirect3DVertexBuffer9**) ppStreamData.GetAddressOf(), ref pOffsetInBytes, pStride);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStreamSource<TI0>(uint StreamNumber, ref ComPtr<TI0> ppStreamData, ref uint pOffsetInBytes, ref uint pStride) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetStreamSource(StreamNumber, (IDirect3DVertexBuffer9**) ppStreamData.GetAddressOf(), ref pOffsetInBytes, ref pStride);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetIndices<TI0>(ComPtr<TI0> pIndexData) where TI0 : unmanaged, IComVtbl<IDirect3DIndexBuffer9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetIndices((IDirect3DIndexBuffer9*) pIndexData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetIndices<TI0>(ref ComPtr<TI0> ppIndexData) where TI0 : unmanaged, IComVtbl<IDirect3DIndexBuffer9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetIndices((IDirect3DIndexBuffer9**) ppIndexData.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePixelShader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, ref ComPtr<TI0> ppShader) where TI0 : unmanaged, IComVtbl<IDirect3DPixelShader9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePixelShader(pFunction, (IDirect3DPixelShader9**) ppShader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreatePixelShader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFunction, ref ComPtr<TI0> ppShader) where TI0 : unmanaged, IComVtbl<IDirect3DPixelShader9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePixelShader(in pFunction, (IDirect3DPixelShader9**) ppShader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelShader<TI0>(ComPtr<TI0> pShader) where TI0 : unmanaged, IComVtbl<IDirect3DPixelShader9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPixelShader((IDirect3DPixelShader9*) pShader.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelShader<TI0>(ref ComPtr<TI0> ppShader) where TI0 : unmanaged, IComVtbl<IDirect3DPixelShader9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetPixelShader((IDirect3DPixelShader9**) ppShader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQuery<TI0>(Querytype Type, ref ComPtr<TI0> ppQuery) where TI0 : unmanaged, IComVtbl<IDirect3DQuery9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQuery(Type, (IDirect3DQuery9**) ppQuery.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
