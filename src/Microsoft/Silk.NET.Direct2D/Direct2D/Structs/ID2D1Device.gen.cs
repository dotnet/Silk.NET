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
    [Guid("47dd575d-ac05-4cdd-8049-9b02cd16f44c")]
    [NativeName("Name", "ID2D1Device")]
    public unsafe partial struct ID2D1Device : IComVtbl<ID2D1Device>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("47dd575d-ac05-4cdd-8049-9b02cd16f44c");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Resource(ID2D1Device val)
            => Unsafe.As<ID2D1Device, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Device val)
            => Unsafe.As<ID2D1Device, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Device
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
            var @this = (ID2D1Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceContext(DeviceContextOptions options, ID2D1DeviceContext** deviceContext)
        {
            var @this = (ID2D1Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, DeviceContextOptions, ID2D1DeviceContext**, int>)@this->LpVtbl[4])(@this, options, deviceContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePrintControl(IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
        {
            var @this = (ID2D1Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTarget, printControlProperties, printControl);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMaximumTextureMemory(ulong maximumInBytes)
        {
            var @this = (ID2D1Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device*, ulong, void>)@this->LpVtbl[6])(@this, maximumInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetMaximumTextureMemory()
        {
            var @this = (ID2D1Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, ulong>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearResources(uint millisecondsSinceUse)
        {
            var @this = (ID2D1Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Device*, uint, void>)@this->LpVtbl[8])(@this, millisecondsSinceUse);
        }

    }
}
