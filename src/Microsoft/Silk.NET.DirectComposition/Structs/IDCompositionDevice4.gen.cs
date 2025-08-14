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
    [Guid("85fc5cca-2da6-494c-86b6-4a775c049b8a")]
    [NativeName("Name", "IDCompositionDevice4")]
    public unsafe partial struct IDCompositionDevice4 : IComVtbl<IDCompositionDevice4>, IComVtbl<IDCompositionDevice3>, IComVtbl<IDCompositionDevice2>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("85fc5cca-2da6-494c-86b6-4a775c049b8a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionDevice3(IDCompositionDevice4 val)
            => Unsafe.As<IDCompositionDevice4, IDCompositionDevice3>(ref val);

        public static implicit operator IDCompositionDevice2(IDCompositionDevice4 val)
            => Unsafe.As<IDCompositionDevice4, IDCompositionDevice2>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionDevice4 val)
            => Unsafe.As<IDCompositionDevice4, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionDevice4
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
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Commit()
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, int>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WaitForCommitCompletion()
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameStatistics(FRAMESTATISTICS* statistics)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, FRAMESTATISTICS*, int>)@this->LpVtbl[5])(@this, statistics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameStatistics(ref FRAMESTATISTICS statistics)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FRAMESTATISTICS* statisticsPtr = &statistics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, FRAMESTATISTICS*, int>)@this->LpVtbl[5])(@this, statisticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVisual(IDCompositionVisual2** visual)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionVisual2**, int>)@this->LpVtbl[6])(@this, visual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVisual(ref IDCompositionVisual2* visual)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual2** visualPtr = &visual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionVisual2**, int>)@this->LpVtbl[6])(@this, visualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFactory(Silk.NET.Core.Native.IUnknown* renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Silk.NET.Core.Native.IUnknown*, IDCompositionSurfaceFactory**, int>)@this->LpVtbl[7])(@this, renderingDevice, surfaceFactory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFactory(Silk.NET.Core.Native.IUnknown* renderingDevice, ref IDCompositionSurfaceFactory* surfaceFactory)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionSurfaceFactory** surfaceFactoryPtr = &surfaceFactory)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Silk.NET.Core.Native.IUnknown*, IDCompositionSurfaceFactory**, int>)@this->LpVtbl[7])(@this, renderingDevice, surfaceFactoryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFactory(ref Silk.NET.Core.Native.IUnknown renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* renderingDevicePtr = &renderingDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Silk.NET.Core.Native.IUnknown*, IDCompositionSurfaceFactory**, int>)@this->LpVtbl[7])(@this, renderingDevicePtr, surfaceFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFactory(ref Silk.NET.Core.Native.IUnknown renderingDevice, ref IDCompositionSurfaceFactory* surfaceFactory)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* renderingDevicePtr = &renderingDevice)
            {
                fixed (IDCompositionSurfaceFactory** surfaceFactoryPtr = &surfaceFactory)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Silk.NET.Core.Native.IUnknown*, IDCompositionSurfaceFactory**, int>)@this->LpVtbl[7])(@this, renderingDevicePtr, surfaceFactoryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionSurface** surface)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionSurface**, int>)@this->LpVtbl[8])(@this, width, height, pixelFormat, alphaMode, surface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref IDCompositionSurface* surface)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionSurface** surfacePtr = &surface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionSurface**, int>)@this->LpVtbl[8])(@this, width, height, pixelFormat, alphaMode, surfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVirtualSurface(uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionVirtualSurface** virtualSurface)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionVirtualSurface**, int>)@this->LpVtbl[9])(@this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVirtualSurface(uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref IDCompositionVirtualSurface* virtualSurface)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVirtualSurface** virtualSurfacePtr = &virtualSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionVirtualSurface**, int>)@this->LpVtbl[9])(@this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTranslateTransform**, int>)@this->LpVtbl[10])(@this, translateTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform(ref IDCompositionTranslateTransform* translateTransform)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTranslateTransform** translateTransformPtr = &translateTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTranslateTransform**, int>)@this->LpVtbl[10])(@this, translateTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform(IDCompositionScaleTransform** scaleTransform)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionScaleTransform**, int>)@this->LpVtbl[11])(@this, scaleTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform(ref IDCompositionScaleTransform* scaleTransform)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionScaleTransform** scaleTransformPtr = &scaleTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionScaleTransform**, int>)@this->LpVtbl[11])(@this, scaleTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform(IDCompositionRotateTransform** rotateTransform)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionRotateTransform**, int>)@this->LpVtbl[12])(@this, rotateTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform(ref IDCompositionRotateTransform* rotateTransform)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionRotateTransform** rotateTransformPtr = &rotateTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionRotateTransform**, int>)@this->LpVtbl[12])(@this, rotateTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSkewTransform(IDCompositionSkewTransform** skewTransform)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionSkewTransform**, int>)@this->LpVtbl[13])(@this, skewTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSkewTransform(ref IDCompositionSkewTransform* skewTransform)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionSkewTransform** skewTransformPtr = &skewTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionSkewTransform**, int>)@this->LpVtbl[13])(@this, skewTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionMatrixTransform**, int>)@this->LpVtbl[14])(@this, matrixTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform(ref IDCompositionMatrixTransform* matrixTransform)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionMatrixTransform** matrixTransformPtr = &matrixTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionMatrixTransform**, int>)@this->LpVtbl[14])(@this, matrixTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[15])(@this, transforms, elements, transformGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(IDCompositionTransform** transforms, uint elements, ref IDCompositionTransform* transformGroup)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform** transformGroupPtr = &transformGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[15])(@this, transforms, elements, transformGroupPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(ref IDCompositionTransform* transforms, uint elements, IDCompositionTransform** transformGroup)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform** transformsPtr = &transforms)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[15])(@this, transformsPtr, elements, transformGroup);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(ref IDCompositionTransform* transforms, uint elements, ref IDCompositionTransform* transformGroup)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform** transformsPtr = &transforms)
            {
                fixed (IDCompositionTransform** transformGroupPtr = &transformGroup)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[15])(@this, transformsPtr, elements, transformGroupPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTranslateTransform3D**, int>)@this->LpVtbl[16])(@this, translateTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform3D(ref IDCompositionTranslateTransform3D* translateTransform3D)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTranslateTransform3D** translateTransform3DPtr = &translateTransform3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTranslateTransform3D**, int>)@this->LpVtbl[16])(@this, translateTransform3DPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionScaleTransform3D**, int>)@this->LpVtbl[17])(@this, scaleTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform3D(ref IDCompositionScaleTransform3D* scaleTransform3D)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionScaleTransform3D** scaleTransform3DPtr = &scaleTransform3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionScaleTransform3D**, int>)@this->LpVtbl[17])(@this, scaleTransform3DPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionRotateTransform3D**, int>)@this->LpVtbl[18])(@this, rotateTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform3D(ref IDCompositionRotateTransform3D* rotateTransform3D)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionRotateTransform3D** rotateTransform3DPtr = &rotateTransform3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionRotateTransform3D**, int>)@this->LpVtbl[18])(@this, rotateTransform3DPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionMatrixTransform3D**, int>)@this->LpVtbl[19])(@this, matrixTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform3D(ref IDCompositionMatrixTransform3D* matrixTransform3D)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionMatrixTransform3D** matrixTransform3DPtr = &matrixTransform3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionMatrixTransform3D**, int>)@this->LpVtbl[19])(@this, matrixTransform3DPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[20])(@this, transforms3D, elements, transform3DGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, ref IDCompositionTransform3D* transform3DGroup)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform3D** transform3DGroupPtr = &transform3DGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[20])(@this, transforms3D, elements, transform3DGroupPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(ref IDCompositionTransform3D* transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform3D** transforms3DPtr = &transforms3D)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[20])(@this, transforms3DPtr, elements, transform3DGroup);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(ref IDCompositionTransform3D* transforms3D, uint elements, ref IDCompositionTransform3D* transform3DGroup)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTransform3D** transforms3DPtr = &transforms3D)
            {
                fixed (IDCompositionTransform3D** transform3DGroupPtr = &transform3DGroup)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[20])(@this, transforms3DPtr, elements, transform3DGroupPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffectGroup(IDCompositionEffectGroup** effectGroup)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionEffectGroup**, int>)@this->LpVtbl[21])(@this, effectGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffectGroup(ref IDCompositionEffectGroup* effectGroup)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionEffectGroup** effectGroupPtr = &effectGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionEffectGroup**, int>)@this->LpVtbl[21])(@this, effectGroupPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleClip(IDCompositionRectangleClip** clip)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionRectangleClip**, int>)@this->LpVtbl[22])(@this, clip);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleClip(ref IDCompositionRectangleClip* clip)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionRectangleClip** clipPtr = &clip)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionRectangleClip**, int>)@this->LpVtbl[22])(@this, clipPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAnimation(IDCompositionAnimation** animation)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionAnimation**, int>)@this->LpVtbl[23])(@this, animation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAnimation(ref IDCompositionAnimation* animation)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionAnimation** animationPtr = &animation)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionAnimation**, int>)@this->LpVtbl[23])(@this, animationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGaussianBlurEffect(IDCompositionGaussianBlurEffect** gaussianBlurEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionGaussianBlurEffect**, int>)@this->LpVtbl[24])(@this, gaussianBlurEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGaussianBlurEffect(ref IDCompositionGaussianBlurEffect* gaussianBlurEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionGaussianBlurEffect** gaussianBlurEffectPtr = &gaussianBlurEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionGaussianBlurEffect**, int>)@this->LpVtbl[24])(@this, gaussianBlurEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBrightnessEffect(IDCompositionBrightnessEffect** brightnessEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionBrightnessEffect**, int>)@this->LpVtbl[25])(@this, brightnessEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBrightnessEffect(ref IDCompositionBrightnessEffect* brightnessEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionBrightnessEffect** brightnessEffectPtr = &brightnessEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionBrightnessEffect**, int>)@this->LpVtbl[25])(@this, brightnessEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorMatrixEffect(IDCompositionColorMatrixEffect** colorMatrixEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionColorMatrixEffect**, int>)@this->LpVtbl[26])(@this, colorMatrixEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorMatrixEffect(ref IDCompositionColorMatrixEffect* colorMatrixEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionColorMatrixEffect** colorMatrixEffectPtr = &colorMatrixEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionColorMatrixEffect**, int>)@this->LpVtbl[26])(@this, colorMatrixEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateShadowEffect(IDCompositionShadowEffect** shadowEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionShadowEffect**, int>)@this->LpVtbl[27])(@this, shadowEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateShadowEffect(ref IDCompositionShadowEffect* shadowEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionShadowEffect** shadowEffectPtr = &shadowEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionShadowEffect**, int>)@this->LpVtbl[27])(@this, shadowEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHueRotationEffect(IDCompositionHueRotationEffect** hueRotationEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionHueRotationEffect**, int>)@this->LpVtbl[28])(@this, hueRotationEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHueRotationEffect(ref IDCompositionHueRotationEffect* hueRotationEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionHueRotationEffect** hueRotationEffectPtr = &hueRotationEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionHueRotationEffect**, int>)@this->LpVtbl[28])(@this, hueRotationEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSaturationEffect(IDCompositionSaturationEffect** saturationEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionSaturationEffect**, int>)@this->LpVtbl[29])(@this, saturationEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSaturationEffect(ref IDCompositionSaturationEffect* saturationEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionSaturationEffect** saturationEffectPtr = &saturationEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionSaturationEffect**, int>)@this->LpVtbl[29])(@this, saturationEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTurbulenceEffect(IDCompositionTurbulenceEffect** turbulenceEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTurbulenceEffect**, int>)@this->LpVtbl[30])(@this, turbulenceEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTurbulenceEffect(ref IDCompositionTurbulenceEffect* turbulenceEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTurbulenceEffect** turbulenceEffectPtr = &turbulenceEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTurbulenceEffect**, int>)@this->LpVtbl[30])(@this, turbulenceEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearTransferEffect(IDCompositionLinearTransferEffect** linearTransferEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionLinearTransferEffect**, int>)@this->LpVtbl[31])(@this, linearTransferEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearTransferEffect(ref IDCompositionLinearTransferEffect* linearTransferEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionLinearTransferEffect** linearTransferEffectPtr = &linearTransferEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionLinearTransferEffect**, int>)@this->LpVtbl[31])(@this, linearTransferEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTableTransferEffect(IDCompositionTableTransferEffect** tableTransferEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTableTransferEffect**, int>)@this->LpVtbl[32])(@this, tableTransferEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTableTransferEffect(ref IDCompositionTableTransferEffect* tableTransferEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTableTransferEffect** tableTransferEffectPtr = &tableTransferEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionTableTransferEffect**, int>)@this->LpVtbl[32])(@this, tableTransferEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeEffect(IDCompositionCompositeEffect** compositeEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionCompositeEffect**, int>)@this->LpVtbl[33])(@this, compositeEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositeEffect(ref IDCompositionCompositeEffect* compositeEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionCompositeEffect** compositeEffectPtr = &compositeEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionCompositeEffect**, int>)@this->LpVtbl[33])(@this, compositeEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendEffect(IDCompositionBlendEffect** blendEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionBlendEffect**, int>)@this->LpVtbl[34])(@this, blendEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendEffect(ref IDCompositionBlendEffect* blendEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionBlendEffect** blendEffectPtr = &blendEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionBlendEffect**, int>)@this->LpVtbl[34])(@this, blendEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateArithmeticCompositeEffect(IDCompositionArithmeticCompositeEffect** arithmeticCompositeEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionArithmeticCompositeEffect**, int>)@this->LpVtbl[35])(@this, arithmeticCompositeEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateArithmeticCompositeEffect(ref IDCompositionArithmeticCompositeEffect* arithmeticCompositeEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionArithmeticCompositeEffect** arithmeticCompositeEffectPtr = &arithmeticCompositeEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionArithmeticCompositeEffect**, int>)@this->LpVtbl[35])(@this, arithmeticCompositeEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAffineTransform2DEffect(IDCompositionAffineTransform2DEffect** affineTransform2dEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionAffineTransform2DEffect**, int>)@this->LpVtbl[36])(@this, affineTransform2dEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAffineTransform2DEffect(ref IDCompositionAffineTransform2DEffect* affineTransform2dEffect)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionAffineTransform2DEffect** affineTransform2dEffectPtr = &affineTransform2dEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, IDCompositionAffineTransform2DEffect**, int>)@this->LpVtbl[36])(@this, affineTransform2dEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCompositionTextureSupport(Silk.NET.Core.Native.IUnknown* renderingDevice, int* supportsCompositionTextures)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Silk.NET.Core.Native.IUnknown*, int*, int>)@this->LpVtbl[37])(@this, renderingDevice, supportsCompositionTextures);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCompositionTextureSupport(Silk.NET.Core.Native.IUnknown* renderingDevice, ref int supportsCompositionTextures)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* supportsCompositionTexturesPtr = &supportsCompositionTextures)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Silk.NET.Core.Native.IUnknown*, int*, int>)@this->LpVtbl[37])(@this, renderingDevice, supportsCompositionTexturesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCompositionTextureSupport(ref Silk.NET.Core.Native.IUnknown renderingDevice, int* supportsCompositionTextures)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* renderingDevicePtr = &renderingDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Silk.NET.Core.Native.IUnknown*, int*, int>)@this->LpVtbl[37])(@this, renderingDevicePtr, supportsCompositionTextures);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckCompositionTextureSupport(ref Silk.NET.Core.Native.IUnknown renderingDevice, ref int supportsCompositionTextures)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* renderingDevicePtr = &renderingDevice)
            {
                fixed (int* supportsCompositionTexturesPtr = &supportsCompositionTextures)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Silk.NET.Core.Native.IUnknown*, int*, int>)@this->LpVtbl[37])(@this, renderingDevicePtr, supportsCompositionTexturesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositionTexture(Silk.NET.Core.Native.IUnknown* d3dTexture, IDCompositionTexture** compositionTexture)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Silk.NET.Core.Native.IUnknown*, IDCompositionTexture**, int>)@this->LpVtbl[38])(@this, d3dTexture, compositionTexture);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositionTexture(Silk.NET.Core.Native.IUnknown* d3dTexture, ref IDCompositionTexture* compositionTexture)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionTexture** compositionTexturePtr = &compositionTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Silk.NET.Core.Native.IUnknown*, IDCompositionTexture**, int>)@this->LpVtbl[38])(@this, d3dTexture, compositionTexturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositionTexture(ref Silk.NET.Core.Native.IUnknown d3dTexture, IDCompositionTexture** compositionTexture)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* d3dTexturePtr = &d3dTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Silk.NET.Core.Native.IUnknown*, IDCompositionTexture**, int>)@this->LpVtbl[38])(@this, d3dTexturePtr, compositionTexture);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositionTexture(ref Silk.NET.Core.Native.IUnknown d3dTexture, ref IDCompositionTexture* compositionTexture)
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* d3dTexturePtr = &d3dTexture)
            {
                fixed (IDCompositionTexture** compositionTexturePtr = &compositionTexture)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice4*, Silk.NET.Core.Native.IUnknown*, IDCompositionTexture**, int>)@this->LpVtbl[38])(@this, d3dTexturePtr, compositionTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVisual<TI0>(ref ComPtr<TI0> visual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual2>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVisual((IDCompositionVisual2**) visual.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSurfaceFactory<TI0, TI1>(ComPtr<TI0> renderingDevice, ref ComPtr<TI1> surfaceFactory) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDCompositionSurfaceFactory>, IComVtbl<TI1>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurfaceFactory((Silk.NET.Core.Native.IUnknown*) renderingDevice.Handle, (IDCompositionSurfaceFactory**) surfaceFactory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFactory<TI0>(ComPtr<TI0> renderingDevice, ref IDCompositionSurfaceFactory* surfaceFactory) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurfaceFactory((Silk.NET.Core.Native.IUnknown*) renderingDevice.Handle, ref surfaceFactory);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSurfaceFactory<TI0>(ref Silk.NET.Core.Native.IUnknown renderingDevice, ref ComPtr<TI0> surfaceFactory) where TI0 : unmanaged, IComVtbl<IDCompositionSurfaceFactory>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurfaceFactory(ref renderingDevice, (IDCompositionSurfaceFactory**) surfaceFactory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSurface<TI0>(uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref ComPtr<TI0> surface) where TI0 : unmanaged, IComVtbl<IDCompositionSurface>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurface(width, height, pixelFormat, alphaMode, (IDCompositionSurface**) surface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVirtualSurface<TI0>(uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref ComPtr<TI0> virtualSurface) where TI0 : unmanaged, IComVtbl<IDCompositionVirtualSurface>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVirtualSurface(initialWidth, initialHeight, pixelFormat, alphaMode, (IDCompositionVirtualSurface**) virtualSurface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTranslateTransform<TI0>(ref ComPtr<TI0> translateTransform) where TI0 : unmanaged, IComVtbl<IDCompositionTranslateTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTranslateTransform((IDCompositionTranslateTransform**) translateTransform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateScaleTransform<TI0>(ref ComPtr<TI0> scaleTransform) where TI0 : unmanaged, IComVtbl<IDCompositionScaleTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateScaleTransform((IDCompositionScaleTransform**) scaleTransform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRotateTransform<TI0>(ref ComPtr<TI0> rotateTransform) where TI0 : unmanaged, IComVtbl<IDCompositionRotateTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRotateTransform((IDCompositionRotateTransform**) rotateTransform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSkewTransform<TI0>(ref ComPtr<TI0> skewTransform) where TI0 : unmanaged, IComVtbl<IDCompositionSkewTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSkewTransform((IDCompositionSkewTransform**) skewTransform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMatrixTransform<TI0>(ref ComPtr<TI0> matrixTransform) where TI0 : unmanaged, IComVtbl<IDCompositionMatrixTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMatrixTransform((IDCompositionMatrixTransform**) matrixTransform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTransformGroup<TI0, TI1>(ref ComPtr<TI0> transforms, uint elements, ref ComPtr<TI1> transformGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDCompositionTransform>, IComVtbl<TI1>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformGroup((IDCompositionTransform**) transforms.GetAddressOf(), elements, (IDCompositionTransform**) transformGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup<TI0>(ref ComPtr<TI0> transforms, uint elements, ref IDCompositionTransform* transformGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformGroup((IDCompositionTransform**) transforms.GetAddressOf(), elements, ref transformGroup);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup<TI0>(ref IDCompositionTransform* transforms, uint elements, ref ComPtr<TI0> transformGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformGroup(ref transforms, elements, (IDCompositionTransform**) transformGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTranslateTransform3D<TI0>(ref ComPtr<TI0> translateTransform3D) where TI0 : unmanaged, IComVtbl<IDCompositionTranslateTransform3D>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTranslateTransform3D((IDCompositionTranslateTransform3D**) translateTransform3D.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateScaleTransform3D<TI0>(ref ComPtr<TI0> scaleTransform3D) where TI0 : unmanaged, IComVtbl<IDCompositionScaleTransform3D>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateScaleTransform3D((IDCompositionScaleTransform3D**) scaleTransform3D.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRotateTransform3D<TI0>(ref ComPtr<TI0> rotateTransform3D) where TI0 : unmanaged, IComVtbl<IDCompositionRotateTransform3D>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRotateTransform3D((IDCompositionRotateTransform3D**) rotateTransform3D.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMatrixTransform3D<TI0>(ref ComPtr<TI0> matrixTransform3D) where TI0 : unmanaged, IComVtbl<IDCompositionMatrixTransform3D>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMatrixTransform3D((IDCompositionMatrixTransform3D**) matrixTransform3D.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTransform3DGroup<TI0, TI1>(ref ComPtr<TI0> transforms3D, uint elements, ref ComPtr<TI1> transform3DGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform3D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDCompositionTransform3D>, IComVtbl<TI1>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransform3DGroup((IDCompositionTransform3D**) transforms3D.GetAddressOf(), elements, (IDCompositionTransform3D**) transform3DGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup<TI0>(ref ComPtr<TI0> transforms3D, uint elements, ref IDCompositionTransform3D* transform3DGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform3D>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransform3DGroup((IDCompositionTransform3D**) transforms3D.GetAddressOf(), elements, ref transform3DGroup);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup<TI0>(ref IDCompositionTransform3D* transforms3D, uint elements, ref ComPtr<TI0> transform3DGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform3D>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransform3DGroup(ref transforms3D, elements, (IDCompositionTransform3D**) transform3DGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEffectGroup<TI0>(ref ComPtr<TI0> effectGroup) where TI0 : unmanaged, IComVtbl<IDCompositionEffectGroup>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEffectGroup((IDCompositionEffectGroup**) effectGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRectangleClip<TI0>(ref ComPtr<TI0> clip) where TI0 : unmanaged, IComVtbl<IDCompositionRectangleClip>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRectangleClip((IDCompositionRectangleClip**) clip.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateAnimation<TI0>(ref ComPtr<TI0> animation) where TI0 : unmanaged, IComVtbl<IDCompositionAnimation>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateAnimation((IDCompositionAnimation**) animation.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGaussianBlurEffect<TI0>(ref ComPtr<TI0> gaussianBlurEffect) where TI0 : unmanaged, IComVtbl<IDCompositionGaussianBlurEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGaussianBlurEffect((IDCompositionGaussianBlurEffect**) gaussianBlurEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBrightnessEffect<TI0>(ref ComPtr<TI0> brightnessEffect) where TI0 : unmanaged, IComVtbl<IDCompositionBrightnessEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBrightnessEffect((IDCompositionBrightnessEffect**) brightnessEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateColorMatrixEffect<TI0>(ref ComPtr<TI0> colorMatrixEffect) where TI0 : unmanaged, IComVtbl<IDCompositionColorMatrixEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorMatrixEffect((IDCompositionColorMatrixEffect**) colorMatrixEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateShadowEffect<TI0>(ref ComPtr<TI0> shadowEffect) where TI0 : unmanaged, IComVtbl<IDCompositionShadowEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateShadowEffect((IDCompositionShadowEffect**) shadowEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateHueRotationEffect<TI0>(ref ComPtr<TI0> hueRotationEffect) where TI0 : unmanaged, IComVtbl<IDCompositionHueRotationEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHueRotationEffect((IDCompositionHueRotationEffect**) hueRotationEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSaturationEffect<TI0>(ref ComPtr<TI0> saturationEffect) where TI0 : unmanaged, IComVtbl<IDCompositionSaturationEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSaturationEffect((IDCompositionSaturationEffect**) saturationEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTurbulenceEffect<TI0>(ref ComPtr<TI0> turbulenceEffect) where TI0 : unmanaged, IComVtbl<IDCompositionTurbulenceEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTurbulenceEffect((IDCompositionTurbulenceEffect**) turbulenceEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateLinearTransferEffect<TI0>(ref ComPtr<TI0> linearTransferEffect) where TI0 : unmanaged, IComVtbl<IDCompositionLinearTransferEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLinearTransferEffect((IDCompositionLinearTransferEffect**) linearTransferEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTableTransferEffect<TI0>(ref ComPtr<TI0> tableTransferEffect) where TI0 : unmanaged, IComVtbl<IDCompositionTableTransferEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTableTransferEffect((IDCompositionTableTransferEffect**) tableTransferEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCompositeEffect<TI0>(ref ComPtr<TI0> compositeEffect) where TI0 : unmanaged, IComVtbl<IDCompositionCompositeEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositeEffect((IDCompositionCompositeEffect**) compositeEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBlendEffect<TI0>(ref ComPtr<TI0> blendEffect) where TI0 : unmanaged, IComVtbl<IDCompositionBlendEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBlendEffect((IDCompositionBlendEffect**) blendEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateArithmeticCompositeEffect<TI0>(ref ComPtr<TI0> arithmeticCompositeEffect) where TI0 : unmanaged, IComVtbl<IDCompositionArithmeticCompositeEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateArithmeticCompositeEffect((IDCompositionArithmeticCompositeEffect**) arithmeticCompositeEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateAffineTransform2DEffect<TI0>(ref ComPtr<TI0> affineTransform2dEffect) where TI0 : unmanaged, IComVtbl<IDCompositionAffineTransform2DEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateAffineTransform2DEffect((IDCompositionAffineTransform2DEffect**) affineTransform2dEffect.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCompositionTextureSupport<TI0>(ComPtr<TI0> renderingDevice, int* supportsCompositionTextures) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CheckCompositionTextureSupport((Silk.NET.Core.Native.IUnknown*) renderingDevice.Handle, supportsCompositionTextures);
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckCompositionTextureSupport<TI0>(ComPtr<TI0> renderingDevice, ref int supportsCompositionTextures) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CheckCompositionTextureSupport((Silk.NET.Core.Native.IUnknown*) renderingDevice.Handle, ref supportsCompositionTextures);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCompositionTexture<TI0, TI1>(ComPtr<TI0> d3dTexture, ref ComPtr<TI1> compositionTexture) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDCompositionTexture>, IComVtbl<TI1>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositionTexture((Silk.NET.Core.Native.IUnknown*) d3dTexture.Handle, (IDCompositionTexture**) compositionTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompositionTexture<TI0>(ComPtr<TI0> d3dTexture, ref IDCompositionTexture* compositionTexture) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositionTexture((Silk.NET.Core.Native.IUnknown*) d3dTexture.Handle, ref compositionTexture);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCompositionTexture<TI0>(ref Silk.NET.Core.Native.IUnknown d3dTexture, ref ComPtr<TI0> compositionTexture) where TI0 : unmanaged, IComVtbl<IDCompositionTexture>, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompositionTexture(ref d3dTexture, (IDCompositionTexture**) compositionTexture.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
