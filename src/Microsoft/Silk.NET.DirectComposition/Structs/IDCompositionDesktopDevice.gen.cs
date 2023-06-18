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
    [Guid("5f4633fe-1e08-4cb8-8c75-ce24333f5602")]
    [NativeName("Name", "IDCompositionDesktopDevice")]
    public unsafe partial struct IDCompositionDesktopDevice : IComVtbl<IDCompositionDesktopDevice>, IComVtbl<IDCompositionDevice2>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("5f4633fe-1e08-4cb8-8c75-ce24333f5602");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Commit()
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, int>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WaitForCommitCompletion()
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameStatistics(FRAMESTATISTICS* statistics)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, FRAMESTATISTICS*, int>)@this->LpVtbl[5])(@this, statistics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVisual(IDCompositionVisual2** visual)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionVisual2**, int>)@this->LpVtbl[6])(@this, visual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFactory(Silk.NET.Core.Native.IUnknown* renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, Silk.NET.Core.Native.IUnknown*, IDCompositionSurfaceFactory**, int>)@this->LpVtbl[7])(@this, renderingDevice, surfaceFactory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionSurface** surface)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionSurface**, int>)@this->LpVtbl[8])(@this, width, height, pixelFormat, alphaMode, surface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVirtualSurface(uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionVirtualSurface** virtualSurface)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionVirtualSurface**, int>)@this->LpVtbl[9])(@this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTranslateTransform**, int>)@this->LpVtbl[10])(@this, translateTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform(IDCompositionScaleTransform** scaleTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionScaleTransform**, int>)@this->LpVtbl[11])(@this, scaleTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform(IDCompositionRotateTransform** rotateTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionRotateTransform**, int>)@this->LpVtbl[12])(@this, rotateTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSkewTransform(IDCompositionSkewTransform** skewTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionSkewTransform**, int>)@this->LpVtbl[13])(@this, skewTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionMatrixTransform**, int>)@this->LpVtbl[14])(@this, matrixTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformGroup(IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[15])(@this, transforms, elements, transformGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTranslateTransform3D**, int>)@this->LpVtbl[16])(@this, translateTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionScaleTransform3D**, int>)@this->LpVtbl[17])(@this, scaleTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionRotateTransform3D**, int>)@this->LpVtbl[18])(@this, rotateTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionMatrixTransform3D**, int>)@this->LpVtbl[19])(@this, matrixTransform3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[20])(@this, transforms3D, elements, transform3DGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffectGroup(IDCompositionEffectGroup** effectGroup)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionEffectGroup**, int>)@this->LpVtbl[21])(@this, effectGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleClip(IDCompositionRectangleClip** clip)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionRectangleClip**, int>)@this->LpVtbl[22])(@this, clip);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAnimation(IDCompositionAnimation** animation)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionAnimation**, int>)@this->LpVtbl[23])(@this, animation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTargetForHwnd(nint hwnd, Silk.NET.Core.Bool32 topmost, IDCompositionTarget** target)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, nint, Silk.NET.Core.Bool32, IDCompositionTarget**, int>)@this->LpVtbl[24])(@this, hwnd, topmost, target);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFromHandle(void* handle, Silk.NET.Core.Native.IUnknown** surface)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, void*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[25])(@this, handle, surface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurfaceFromHwnd(nint hwnd, Silk.NET.Core.Native.IUnknown** surface)
        {
            var @this = (IDCompositionDesktopDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, nint, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[26])(@this, hwnd, surface);
            return ret;
        }

    }
}
