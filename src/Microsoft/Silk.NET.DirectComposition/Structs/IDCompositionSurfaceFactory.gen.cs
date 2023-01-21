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
    [Guid("e334bc12-3937-4e02-85eb-fcf4eb30d2c8")]
    [NativeName("Name", "IDCompositionSurfaceFactory")]
    public unsafe partial struct IDCompositionSurfaceFactory : IComVtbl<IDCompositionSurfaceFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("e334bc12-3937-4e02-85eb-fcf4eb30d2c8");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionSurfaceFactory val)
            => Unsafe.As<IDCompositionSurfaceFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionSurfaceFactory
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
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurfaceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurfaceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurfaceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurfaceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurfaceFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurfaceFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionSurface** surface)
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurfaceFactory*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionSurface**, int>)@this->LpVtbl[3])(@this, width, height, pixelFormat, alphaMode, surface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref IDCompositionSurface* surface)
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionSurface** surfacePtr = &surface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurfaceFactory*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionSurface**, int>)@this->LpVtbl[3])(@this, width, height, pixelFormat, alphaMode, surfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVirtualSurface(uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionVirtualSurface** virtualSurface)
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurfaceFactory*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionVirtualSurface**, int>)@this->LpVtbl[4])(@this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVirtualSurface(uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref IDCompositionVirtualSurface* virtualSurface)
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVirtualSurface** virtualSurfacePtr = &virtualSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurfaceFactory*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionVirtualSurface**, int>)@this->LpVtbl[4])(@this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateSurface<TI0>(uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref ComPtr<TI0> surface) where TI0 : unmanaged, IComVtbl<IDCompositionSurface>, IComVtbl<TI0>
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSurface(width, height, pixelFormat, alphaMode, (IDCompositionSurface**) surface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVirtualSurface<TI0>(uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref ComPtr<TI0> virtualSurface) where TI0 : unmanaged, IComVtbl<IDCompositionVirtualSurface>, IComVtbl<TI0>
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVirtualSurface(initialWidth, initialHeight, pixelFormat, alphaMode, (IDCompositionVirtualSurface**) virtualSurface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionSurfaceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
