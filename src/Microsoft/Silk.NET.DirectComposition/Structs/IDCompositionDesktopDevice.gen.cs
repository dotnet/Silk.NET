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
    [NativeName("Name", "IDCompositionDesktopDevice")]
    public unsafe partial struct IDCompositionDesktopDevice
    {
        public static implicit operator IDCompositionDevice2(IDCompositionDesktopDevice val)
            => Unsafe.As<IDCompositionDesktopDevice, IDCompositionDevice2>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionDesktopDevice val)
            => Unsafe.As<IDCompositionDesktopDevice, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionDesktopDevice
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
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Commit()
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, int>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WaitForCommitCompletion()
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, int>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameStatistics(FRAMESTATISTICS* statistics)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, FRAMESTATISTICS*, int>)LpVtbl[5])(@this, statistics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameStatistics(ref FRAMESTATISTICS statistics)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FRAMESTATISTICS* statisticsPtr = &statistics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, FRAMESTATISTICS*, int>)LpVtbl[5])(@this, statisticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVisual(IDCompositionVisual2** visual)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionVisual2**, int>)LpVtbl[6])(@this, visual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVisual(ref IDCompositionVisual2* visual)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual2** visualPtr = &visual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionVisual2**, int>)LpVtbl[6])(@this, visualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFactory(Silk.NET.Core.Native.IUnknown* renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, Silk.NET.Core.Native.IUnknown*, IDCompositionSurfaceFactory**, int>)LpVtbl[7])(@this, renderingDevice, surfaceFactory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFactory(Silk.NET.Core.Native.IUnknown* renderingDevice, ref IDCompositionSurfaceFactory* surfaceFactory)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionSurfaceFactory** surfaceFactoryPtr = &surfaceFactory)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, Silk.NET.Core.Native.IUnknown*, IDCompositionSurfaceFactory**, int>)LpVtbl[7])(@this, renderingDevice, surfaceFactoryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFactory(ref Silk.NET.Core.Native.IUnknown renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* renderingDevicePtr = &renderingDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, Silk.NET.Core.Native.IUnknown*, IDCompositionSurfaceFactory**, int>)LpVtbl[7])(@this, renderingDevicePtr, surfaceFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFactory(ref Silk.NET.Core.Native.IUnknown renderingDevice, ref IDCompositionSurfaceFactory* surfaceFactory)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* renderingDevicePtr = &renderingDevice)
            {
                fixed (IDCompositionSurfaceFactory** surfaceFactoryPtr = &surfaceFactory)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, Silk.NET.Core.Native.IUnknown*, IDCompositionSurfaceFactory**, int>)LpVtbl[7])(@this, renderingDevicePtr, surfaceFactoryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionSurface** surface)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionSurface**, int>)LpVtbl[8])(@this, width, height, pixelFormat, alphaMode, surface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref IDCompositionSurface* surface)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionSurface** surfacePtr = &surface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionSurface**, int>)LpVtbl[8])(@this, width, height, pixelFormat, alphaMode, surfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVirtualSurface(uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionVirtualSurface** virtualSurface)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionVirtualSurface**, int>)LpVtbl[9])(@this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVirtualSurface(uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref IDCompositionVirtualSurface* virtualSurface)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVirtualSurface** virtualSurfacePtr = &virtualSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionVirtualSurface**, int>)LpVtbl[9])(@this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTranslateTransform**, int>)LpVtbl[10])(@this, translateTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform(ref IDCompositionTranslateTransform* translateTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTranslateTransform** translateTransformPtr = &translateTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTranslateTransform**, int>)LpVtbl[10])(@this, translateTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform(IDCompositionScaleTransform** scaleTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionScaleTransform**, int>)LpVtbl[11])(@this, scaleTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform(ref IDCompositionScaleTransform* scaleTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionScaleTransform** scaleTransformPtr = &scaleTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionScaleTransform**, int>)LpVtbl[11])(@this, scaleTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform(IDCompositionRotateTransform** rotateTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionRotateTransform**, int>)LpVtbl[12])(@this, rotateTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform(ref IDCompositionRotateTransform* rotateTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionRotateTransform** rotateTransformPtr = &rotateTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionRotateTransform**, int>)LpVtbl[12])(@this, rotateTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSkewTransform(IDCompositionSkewTransform** skewTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionSkewTransform**, int>)LpVtbl[13])(@this, skewTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSkewTransform(ref IDCompositionSkewTransform* skewTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionSkewTransform** skewTransformPtr = &skewTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionSkewTransform**, int>)LpVtbl[13])(@this, skewTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionMatrixTransform**, int>)LpVtbl[14])(@this, matrixTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform(ref IDCompositionMatrixTransform* matrixTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionMatrixTransform** matrixTransformPtr = &matrixTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionMatrixTransform**, int>)LpVtbl[14])(@this, matrixTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)LpVtbl[15])(@this, transforms, elements, transformGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(IDCompositionTransform** transforms, uint elements, ref IDCompositionTransform* transformGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform** transformGroupPtr = &transformGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)LpVtbl[15])(@this, transforms, elements, transformGroupPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(ref IDCompositionTransform* transforms, uint elements, IDCompositionTransform** transformGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform** transformsPtr = &transforms)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)LpVtbl[15])(@this, transformsPtr, elements, transformGroup);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(ref IDCompositionTransform* transforms, uint elements, ref IDCompositionTransform* transformGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform** transformsPtr = &transforms)
            {
                fixed (IDCompositionTransform** transformGroupPtr = &transformGroup)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)LpVtbl[15])(@this, transformsPtr, elements, transformGroupPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTranslateTransform3D**, int>)LpVtbl[16])(@this, translateTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform3D(ref IDCompositionTranslateTransform3D* translateTransform3D)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTranslateTransform3D** translateTransform3DPtr = &translateTransform3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTranslateTransform3D**, int>)LpVtbl[16])(@this, translateTransform3DPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionScaleTransform3D**, int>)LpVtbl[17])(@this, scaleTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform3D(ref IDCompositionScaleTransform3D* scaleTransform3D)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionScaleTransform3D** scaleTransform3DPtr = &scaleTransform3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionScaleTransform3D**, int>)LpVtbl[17])(@this, scaleTransform3DPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionRotateTransform3D**, int>)LpVtbl[18])(@this, rotateTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform3D(ref IDCompositionRotateTransform3D* rotateTransform3D)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionRotateTransform3D** rotateTransform3DPtr = &rotateTransform3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionRotateTransform3D**, int>)LpVtbl[18])(@this, rotateTransform3DPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionMatrixTransform3D**, int>)LpVtbl[19])(@this, matrixTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform3D(ref IDCompositionMatrixTransform3D* matrixTransform3D)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionMatrixTransform3D** matrixTransform3DPtr = &matrixTransform3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionMatrixTransform3D**, int>)LpVtbl[19])(@this, matrixTransform3DPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)LpVtbl[20])(@this, transforms3D, elements, transform3DGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, ref IDCompositionTransform3D* transform3DGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform3D** transform3DGroupPtr = &transform3DGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)LpVtbl[20])(@this, transforms3D, elements, transform3DGroupPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(ref IDCompositionTransform3D* transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform3D** transforms3DPtr = &transforms3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)LpVtbl[20])(@this, transforms3DPtr, elements, transform3DGroup);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(ref IDCompositionTransform3D* transforms3D, uint elements, ref IDCompositionTransform3D* transform3DGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform3D** transforms3DPtr = &transforms3D)
            {
                fixed (IDCompositionTransform3D** transform3DGroupPtr = &transform3DGroup)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)LpVtbl[20])(@this, transforms3DPtr, elements, transform3DGroupPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffectGroup(IDCompositionEffectGroup** effectGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionEffectGroup**, int>)LpVtbl[21])(@this, effectGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffectGroup(ref IDCompositionEffectGroup* effectGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionEffectGroup** effectGroupPtr = &effectGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionEffectGroup**, int>)LpVtbl[21])(@this, effectGroupPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleClip(IDCompositionRectangleClip** clip)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionRectangleClip**, int>)LpVtbl[22])(@this, clip);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleClip(ref IDCompositionRectangleClip* clip)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionRectangleClip** clipPtr = &clip)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionRectangleClip**, int>)LpVtbl[22])(@this, clipPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAnimation(IDCompositionAnimation** animation)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionAnimation**, int>)LpVtbl[23])(@this, animation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAnimation(ref IDCompositionAnimation* animation)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionAnimation** animationPtr = &animation)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionAnimation**, int>)LpVtbl[23])(@this, animationPtr);
            }
            return ret;
        }

    }
}
