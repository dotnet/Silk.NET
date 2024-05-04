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
    [Guid("77395441-1c8f-4555-8683-f50dab0fe792")]
    [NativeName("Name", "ID2D1ImageSourceFromWic")]
    public unsafe partial struct ID2D1ImageSourceFromWic : IComVtbl<ID2D1ImageSourceFromWic>, IComVtbl<ID2D1ImageSource>, IComVtbl<ID2D1Image>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("77395441-1c8f-4555-8683-f50dab0fe792");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1ImageSource(ID2D1ImageSourceFromWic val)
            => Unsafe.As<ID2D1ImageSourceFromWic, ID2D1ImageSource>(ref val);

        public static implicit operator ID2D1Image(ID2D1ImageSourceFromWic val)
            => Unsafe.As<ID2D1ImageSourceFromWic, ID2D1Image>(ref val);

        public static implicit operator ID2D1Resource(ID2D1ImageSourceFromWic val)
            => Unsafe.As<ID2D1ImageSourceFromWic, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1ImageSourceFromWic val)
            => Unsafe.As<ID2D1ImageSourceFromWic, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1ImageSourceFromWic
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
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int OfferResources()
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryReclaimResources(int* resourcesDiscarded)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, int*, int>)@this->LpVtbl[5])(@this, resourcesDiscarded);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int TryReclaimResources(ref int resourcesDiscarded)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* resourcesDiscardedPtr = &resourcesDiscarded)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, int*, int>)@this->LpVtbl[5])(@this, resourcesDiscardedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnsureCached([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* rectangleToFill)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[6])(@this, rectangleToFill);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnsureCached([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> rectangleToFill)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<uint>* rectangleToFillPtr = &rectangleToFill)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[6])(@this, rectangleToFillPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TrimCache([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* rectangleToPreserve)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[7])(@this, rectangleToPreserve);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int TrimCache([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> rectangleToPreserve)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<uint>* rectangleToPreservePtr = &rectangleToPreserve)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[7])(@this, rectangleToPreservePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetSource(IWICBitmapSource** wicBitmapSource)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, IWICBitmapSource**, void>)@this->LpVtbl[8])(@this, wicBitmapSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetSource(ref IWICBitmapSource* wicBitmapSource)
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IWICBitmapSource** wicBitmapSourcePtr = &wicBitmapSource)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, IWICBitmapSource**, void>)@this->LpVtbl[8])(@this, wicBitmapSourcePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFactory<TI0>(ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1ImageSourceFromWic*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
