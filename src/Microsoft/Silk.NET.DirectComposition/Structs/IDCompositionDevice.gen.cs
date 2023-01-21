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

namespace Silk.NET.DirectComposition
{
    [Guid("c37ea93a-e7aa-450d-b16f-9746cb0407f3")]
    [NativeName("Name", "IDCompositionDevice")]
    public unsafe partial struct IDCompositionDevice : IComVtbl<IDCompositionDevice>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c37ea93a-e7aa-450d-b16f-9746cb0407f3");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionDevice val)
            => Unsafe.As<IDCompositionDevice, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionDevice
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
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Commit()
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, int>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WaitForCommitCompletion()
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameStatistics(FRAMESTATISTICS* statistics)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, FRAMESTATISTICS*, int>)@this->LpVtbl[5])(@this, statistics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameStatistics(ref FRAMESTATISTICS statistics)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FRAMESTATISTICS* statisticsPtr = &statistics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, FRAMESTATISTICS*, int>)@this->LpVtbl[5])(@this, statisticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTargetForHwnd(nint hwnd, Silk.NET.Core.Bool32 topmost, IDCompositionTarget** target)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, nint, Silk.NET.Core.Bool32, IDCompositionTarget**, int>)@this->LpVtbl[6])(@this, hwnd, topmost, target);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTargetForHwnd(nint hwnd, Silk.NET.Core.Bool32 topmost, ref IDCompositionTarget* target)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTarget** targetPtr = &target)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, nint, Silk.NET.Core.Bool32, IDCompositionTarget**, int>)@this->LpVtbl[6])(@this, hwnd, topmost, targetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVisual(IDCompositionVisual** visual)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionVisual**, int>)@this->LpVtbl[7])(@this, visual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVisual(ref IDCompositionVisual* visual)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual** visualPtr = &visual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionVisual**, int>)@this->LpVtbl[7])(@this, visualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionSurface** surface)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionSurface**, int>)@this->LpVtbl[8])(@this, width, height, pixelFormat, alphaMode, surface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref IDCompositionSurface* surface)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionSurface** surfacePtr = &surface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionSurface**, int>)@this->LpVtbl[8])(@this, width, height, pixelFormat, alphaMode, surfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVirtualSurface(uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionVirtualSurface** virtualSurface)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionVirtualSurface**, int>)@this->LpVtbl[9])(@this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVirtualSurface(uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref IDCompositionVirtualSurface* virtualSurface)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVirtualSurface** virtualSurfacePtr = &virtualSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionVirtualSurface**, int>)@this->LpVtbl[9])(@this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFromHandle(void* handle, Silk.NET.Core.Native.IUnknown** surface)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, void*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, handle, surface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFromHandle(void* handle, ref Silk.NET.Core.Native.IUnknown* surface)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** surfacePtr = &surface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, void*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, handle, surfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFromHandle<T0>(ref T0 handle, Silk.NET.Core.Native.IUnknown** surface) where T0 : unmanaged
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* handlePtr = &handle)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, void*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, handlePtr, surface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFromHandle<T0>(ref T0 handle, ref Silk.NET.Core.Native.IUnknown* surface) where T0 : unmanaged
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* handlePtr = &handle)
            {
                fixed (Silk.NET.Core.Native.IUnknown** surfacePtr = &surface)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, void*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, handlePtr, surfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFromHwnd(nint hwnd, Silk.NET.Core.Native.IUnknown** surface)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, nint, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[11])(@this, hwnd, surface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFromHwnd(nint hwnd, ref Silk.NET.Core.Native.IUnknown* surface)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** surfacePtr = &surface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, nint, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[11])(@this, hwnd, surfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTranslateTransform**, int>)@this->LpVtbl[12])(@this, translateTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform(ref IDCompositionTranslateTransform* translateTransform)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTranslateTransform** translateTransformPtr = &translateTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTranslateTransform**, int>)@this->LpVtbl[12])(@this, translateTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform(IDCompositionScaleTransform** scaleTransform)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionScaleTransform**, int>)@this->LpVtbl[13])(@this, scaleTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform(ref IDCompositionScaleTransform* scaleTransform)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionScaleTransform** scaleTransformPtr = &scaleTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionScaleTransform**, int>)@this->LpVtbl[13])(@this, scaleTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform(IDCompositionRotateTransform** rotateTransform)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRotateTransform**, int>)@this->LpVtbl[14])(@this, rotateTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform(ref IDCompositionRotateTransform* rotateTransform)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionRotateTransform** rotateTransformPtr = &rotateTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRotateTransform**, int>)@this->LpVtbl[14])(@this, rotateTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSkewTransform(IDCompositionSkewTransform** skewTransform)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionSkewTransform**, int>)@this->LpVtbl[15])(@this, skewTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSkewTransform(ref IDCompositionSkewTransform* skewTransform)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionSkewTransform** skewTransformPtr = &skewTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionSkewTransform**, int>)@this->LpVtbl[15])(@this, skewTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionMatrixTransform**, int>)@this->LpVtbl[16])(@this, matrixTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform(ref IDCompositionMatrixTransform* matrixTransform)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionMatrixTransform** matrixTransformPtr = &matrixTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionMatrixTransform**, int>)@this->LpVtbl[16])(@this, matrixTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[17])(@this, transforms, elements, transformGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(IDCompositionTransform** transforms, uint elements, ref IDCompositionTransform* transformGroup)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform** transformGroupPtr = &transformGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[17])(@this, transforms, elements, transformGroupPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(ref IDCompositionTransform* transforms, uint elements, IDCompositionTransform** transformGroup)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform** transformsPtr = &transforms)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[17])(@this, transformsPtr, elements, transformGroup);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(ref IDCompositionTransform* transforms, uint elements, ref IDCompositionTransform* transformGroup)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform** transformsPtr = &transforms)
            {
                fixed (IDCompositionTransform** transformGroupPtr = &transformGroup)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[17])(@this, transformsPtr, elements, transformGroupPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTranslateTransform3D**, int>)@this->LpVtbl[18])(@this, translateTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform3D(ref IDCompositionTranslateTransform3D* translateTransform3D)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTranslateTransform3D** translateTransform3DPtr = &translateTransform3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTranslateTransform3D**, int>)@this->LpVtbl[18])(@this, translateTransform3DPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionScaleTransform3D**, int>)@this->LpVtbl[19])(@this, scaleTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform3D(ref IDCompositionScaleTransform3D* scaleTransform3D)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionScaleTransform3D** scaleTransform3DPtr = &scaleTransform3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionScaleTransform3D**, int>)@this->LpVtbl[19])(@this, scaleTransform3DPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRotateTransform3D**, int>)@this->LpVtbl[20])(@this, rotateTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform3D(ref IDCompositionRotateTransform3D* rotateTransform3D)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionRotateTransform3D** rotateTransform3DPtr = &rotateTransform3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRotateTransform3D**, int>)@this->LpVtbl[20])(@this, rotateTransform3DPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionMatrixTransform3D**, int>)@this->LpVtbl[21])(@this, matrixTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform3D(ref IDCompositionMatrixTransform3D* matrixTransform3D)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionMatrixTransform3D** matrixTransform3DPtr = &matrixTransform3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionMatrixTransform3D**, int>)@this->LpVtbl[21])(@this, matrixTransform3DPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[22])(@this, transforms3D, elements, transform3DGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, ref IDCompositionTransform3D* transform3DGroup)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform3D** transform3DGroupPtr = &transform3DGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[22])(@this, transforms3D, elements, transform3DGroupPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(ref IDCompositionTransform3D* transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform3D** transforms3DPtr = &transforms3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[22])(@this, transforms3DPtr, elements, transform3DGroup);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(ref IDCompositionTransform3D* transforms3D, uint elements, ref IDCompositionTransform3D* transform3DGroup)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform3D** transforms3DPtr = &transforms3D)
            {
                fixed (IDCompositionTransform3D** transform3DGroupPtr = &transform3DGroup)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[22])(@this, transforms3DPtr, elements, transform3DGroupPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffectGroup(IDCompositionEffectGroup** effectGroup)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionEffectGroup**, int>)@this->LpVtbl[23])(@this, effectGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffectGroup(ref IDCompositionEffectGroup* effectGroup)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionEffectGroup** effectGroupPtr = &effectGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionEffectGroup**, int>)@this->LpVtbl[23])(@this, effectGroupPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleClip(IDCompositionRectangleClip** clip)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRectangleClip**, int>)@this->LpVtbl[24])(@this, clip);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleClip(ref IDCompositionRectangleClip* clip)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionRectangleClip** clipPtr = &clip)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRectangleClip**, int>)@this->LpVtbl[24])(@this, clipPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAnimation(IDCompositionAnimation** animation)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionAnimation**, int>)@this->LpVtbl[25])(@this, animation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAnimation(ref IDCompositionAnimation* animation)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionAnimation** animationPtr = &animation)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionAnimation**, int>)@this->LpVtbl[25])(@this, animationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckDeviceState(int* pfValid)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, int*, int>)@this->LpVtbl[26])(@this, pfValid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckDeviceState(ref int pfValid)
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfValidPtr = &pfValid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, int*, int>)@this->LpVtbl[26])(@this, pfValidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTargetForHwnd<TI0>(nint hwnd, Silk.NET.Core.Bool32 topmost, ref ComPtr<TI0> target) where TI0 : unmanaged, IComVtbl<IDCompositionTarget>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTargetForHwnd(hwnd, topmost, (IDCompositionTarget**) target.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVisual<TI0>(ref ComPtr<TI0> visual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVisual((IDCompositionVisual**) visual.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSurface<TI0>(uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref ComPtr<TI0> surface) where TI0 : unmanaged, IComVtbl<IDCompositionSurface>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurface(width, height, pixelFormat, alphaMode, (IDCompositionSurface**) surface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVirtualSurface<TI0>(uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref ComPtr<TI0> virtualSurface) where TI0 : unmanaged, IComVtbl<IDCompositionVirtualSurface>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVirtualSurface(initialWidth, initialHeight, pixelFormat, alphaMode, (IDCompositionVirtualSurface**) virtualSurface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFromHandle<TI0>(void* handle, ref ComPtr<TI0> surface) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurfaceFromHandle(handle, (Silk.NET.Core.Native.IUnknown**) surface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSurfaceFromHandle<T0, TI0>(ref T0 handle, ref ComPtr<TI0> surface) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurfaceFromHandle(ref handle, (Silk.NET.Core.Native.IUnknown**) surface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSurfaceFromHwnd<TI0>(nint hwnd, ref ComPtr<TI0> surface) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurfaceFromHwnd(hwnd, (Silk.NET.Core.Native.IUnknown**) surface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTranslateTransform<TI0>(ref ComPtr<TI0> translateTransform) where TI0 : unmanaged, IComVtbl<IDCompositionTranslateTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTranslateTransform((IDCompositionTranslateTransform**) translateTransform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateScaleTransform<TI0>(ref ComPtr<TI0> scaleTransform) where TI0 : unmanaged, IComVtbl<IDCompositionScaleTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateScaleTransform((IDCompositionScaleTransform**) scaleTransform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRotateTransform<TI0>(ref ComPtr<TI0> rotateTransform) where TI0 : unmanaged, IComVtbl<IDCompositionRotateTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRotateTransform((IDCompositionRotateTransform**) rotateTransform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSkewTransform<TI0>(ref ComPtr<TI0> skewTransform) where TI0 : unmanaged, IComVtbl<IDCompositionSkewTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSkewTransform((IDCompositionSkewTransform**) skewTransform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMatrixTransform<TI0>(ref ComPtr<TI0> matrixTransform) where TI0 : unmanaged, IComVtbl<IDCompositionMatrixTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMatrixTransform((IDCompositionMatrixTransform**) matrixTransform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTransformGroup<TI0, TI1>(ref ComPtr<TI0> transforms, uint elements, ref ComPtr<TI1> transformGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDCompositionTransform>, IComVtbl<TI1>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformGroup((IDCompositionTransform**) transforms.GetAddressOf(), elements, (IDCompositionTransform**) transformGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup<TI0>(ref ComPtr<TI0> transforms, uint elements, ref IDCompositionTransform* transformGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformGroup((IDCompositionTransform**) transforms.GetAddressOf(), elements, ref transformGroup);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup<TI0>(ref IDCompositionTransform* transforms, uint elements, ref ComPtr<TI0> transformGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformGroup(ref transforms, elements, (IDCompositionTransform**) transformGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTranslateTransform3D<TI0>(ref ComPtr<TI0> translateTransform3D) where TI0 : unmanaged, IComVtbl<IDCompositionTranslateTransform3D>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTranslateTransform3D((IDCompositionTranslateTransform3D**) translateTransform3D.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateScaleTransform3D<TI0>(ref ComPtr<TI0> scaleTransform3D) where TI0 : unmanaged, IComVtbl<IDCompositionScaleTransform3D>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateScaleTransform3D((IDCompositionScaleTransform3D**) scaleTransform3D.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRotateTransform3D<TI0>(ref ComPtr<TI0> rotateTransform3D) where TI0 : unmanaged, IComVtbl<IDCompositionRotateTransform3D>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRotateTransform3D((IDCompositionRotateTransform3D**) rotateTransform3D.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMatrixTransform3D<TI0>(ref ComPtr<TI0> matrixTransform3D) where TI0 : unmanaged, IComVtbl<IDCompositionMatrixTransform3D>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMatrixTransform3D((IDCompositionMatrixTransform3D**) matrixTransform3D.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTransform3DGroup<TI0, TI1>(ref ComPtr<TI0> transforms3D, uint elements, ref ComPtr<TI1> transform3DGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform3D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDCompositionTransform3D>, IComVtbl<TI1>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransform3DGroup((IDCompositionTransform3D**) transforms3D.GetAddressOf(), elements, (IDCompositionTransform3D**) transform3DGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup<TI0>(ref ComPtr<TI0> transforms3D, uint elements, ref IDCompositionTransform3D* transform3DGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform3D>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransform3DGroup((IDCompositionTransform3D**) transforms3D.GetAddressOf(), elements, ref transform3DGroup);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup<TI0>(ref IDCompositionTransform3D* transforms3D, uint elements, ref ComPtr<TI0> transform3DGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform3D>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransform3DGroup(ref transforms3D, elements, (IDCompositionTransform3D**) transform3DGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEffectGroup<TI0>(ref ComPtr<TI0> effectGroup) where TI0 : unmanaged, IComVtbl<IDCompositionEffectGroup>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEffectGroup((IDCompositionEffectGroup**) effectGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRectangleClip<TI0>(ref ComPtr<TI0> clip) where TI0 : unmanaged, IComVtbl<IDCompositionRectangleClip>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRectangleClip((IDCompositionRectangleClip**) clip.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateAnimation<TI0>(ref ComPtr<TI0> animation) where TI0 : unmanaged, IComVtbl<IDCompositionAnimation>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateAnimation((IDCompositionAnimation**) animation.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
