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

namespace Silk.NET.Direct2D
{
    [Guid("7bfef914-2d75-4bad-be87-e18ddb077b6d")]
    [NativeName("Name", "ID2D1Device6")]
    public unsafe partial struct ID2D1Device6 : IComVtbl<ID2D1Device6>, IComVtbl<ID2D1Device5>, IComVtbl<ID2D1Device4>, IComVtbl<ID2D1Device3>, IComVtbl<ID2D1Device2>, IComVtbl<ID2D1Device1>, IComVtbl<ID2D1Device>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("7bfef914-2d75-4bad-be87-e18ddb077b6d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Device5(ID2D1Device6 val)
            => Unsafe.As<ID2D1Device6, ID2D1Device5>(ref val);

        public static implicit operator ID2D1Device4(ID2D1Device6 val)
            => Unsafe.As<ID2D1Device6, ID2D1Device4>(ref val);

        public static implicit operator ID2D1Device3(ID2D1Device6 val)
            => Unsafe.As<ID2D1Device6, ID2D1Device3>(ref val);

        public static implicit operator ID2D1Device2(ID2D1Device6 val)
            => Unsafe.As<ID2D1Device6, ID2D1Device2>(ref val);

        public static implicit operator ID2D1Device1(ID2D1Device6 val)
            => Unsafe.As<ID2D1Device6, ID2D1Device1>(ref val);

        public static implicit operator ID2D1Device(ID2D1Device6 val)
            => Unsafe.As<ID2D1Device6, ID2D1Device>(ref val);

        public static implicit operator ID2D1Resource(ID2D1Device6 val)
            => Unsafe.As<ID2D1Device6, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Device6 val)
            => Unsafe.As<ID2D1Device6, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Device6
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
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device6*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device6*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device6*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceContext(DeviceContextOptions options, ID2D1DeviceContext** deviceContext)
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device6*, DeviceContextOptions, ID2D1DeviceContext**, int>)@this->LpVtbl[4])(@this, options, deviceContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device6*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTarget, printControlProperties, printControl);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMaximumTextureMemory(ulong maximumInBytes)
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device6*, ulong, void>)@this->LpVtbl[6])(@this, maximumInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetMaximumTextureMemory()
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device6*, ulong>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearResources(uint millisecondsSinceUse)
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device6*, uint, void>)@this->LpVtbl[8])(@this, millisecondsSinceUse);
        }

        /// <summary>To be documented.</summary>
        public readonly RenderingPriority GetRenderingPriority()
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            RenderingPriority ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device6*, RenderingPriority>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetRenderingPriority(RenderingPriority renderingPriority)
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device6*, RenderingPriority, void>)@this->LpVtbl[10])(@this, renderingPriority);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FlushDeviceContexts(ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device6*, ID2D1Bitmap*, void>)@this->LpVtbl[13])(@this, bitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDxgiDevice(Silk.NET.DXGI.IDXGIDevice** dxgiDevice)
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device6*, Silk.NET.DXGI.IDXGIDevice**, int>)@this->LpVtbl[14])(@this, dxgiDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMaximumColorGlyphCacheMemory(ulong maximumInBytes)
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device6*, ulong, void>)@this->LpVtbl[17])(@this, maximumInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetMaximumColorGlyphCacheMemory()
        {
            var @this = (ID2D1Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device6*, ulong>)@this->LpVtbl[18])(@this);
            return ret;
        }

    }
}
