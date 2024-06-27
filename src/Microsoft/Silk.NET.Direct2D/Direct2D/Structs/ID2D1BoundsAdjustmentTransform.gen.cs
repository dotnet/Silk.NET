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
    [Guid("90f732e2-5092-4606-a819-8651970baccd")]
    [NativeName("Name", "ID2D1BoundsAdjustmentTransform")]
    public unsafe partial struct ID2D1BoundsAdjustmentTransform : IComVtbl<ID2D1BoundsAdjustmentTransform>, IComVtbl<ID2D1TransformNode>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("90f732e2-5092-4606-a819-8651970baccd");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1TransformNode(ID2D1BoundsAdjustmentTransform val)
            => Unsafe.As<ID2D1BoundsAdjustmentTransform, ID2D1TransformNode>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1BoundsAdjustmentTransform val)
            => Unsafe.As<ID2D1BoundsAdjustmentTransform, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1BoundsAdjustmentTransform
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
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetInputCount()
        {
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetOutputBounds([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputBounds)
        {
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[4])(@this, outputBounds);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetOutputBounds([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputBounds)
        {
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* outputBoundsPtr = &outputBounds)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[4])(@this, outputBoundsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputBounds(Silk.NET.Maths.Box2D<int>* outputBounds)
        {
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[5])(@this, outputBounds);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetOutputBounds(ref Silk.NET.Maths.Box2D<int> outputBounds)
        {
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* outputBoundsPtr = &outputBounds)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[5])(@this, outputBoundsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1BoundsAdjustmentTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
