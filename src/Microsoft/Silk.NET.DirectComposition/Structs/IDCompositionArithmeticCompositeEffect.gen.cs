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
    [Guid("3b67dfa8-e3dd-4e61-b640-46c2f3d739dc")]
    [NativeName("Name", "IDCompositionArithmeticCompositeEffect")]
    public unsafe partial struct IDCompositionArithmeticCompositeEffect : IComVtbl<IDCompositionArithmeticCompositeEffect>, IComVtbl<IDCompositionFilterEffect>, IComVtbl<IDCompositionEffect>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("3b67dfa8-e3dd-4e61-b640-46c2f3d739dc");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionFilterEffect(IDCompositionArithmeticCompositeEffect val)
            => Unsafe.As<IDCompositionArithmeticCompositeEffect, IDCompositionFilterEffect>(ref val);

        public static implicit operator IDCompositionEffect(IDCompositionArithmeticCompositeEffect val)
            => Unsafe.As<IDCompositionArithmeticCompositeEffect, IDCompositionEffect>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionArithmeticCompositeEffect val)
            => Unsafe.As<IDCompositionArithmeticCompositeEffect, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionArithmeticCompositeEffect
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
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInput(uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInput(uint index, ref Silk.NET.Core.Native.IUnknown input, uint flags)
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* inputPtr = &input)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, inputPtr, flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetCoefficients(Silk.NET.Maths.Vector4D<float>* coefficients)
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Silk.NET.Maths.Vector4D<float>*, int>)@this->LpVtbl[4])(@this, coefficients);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCoefficients(ref Silk.NET.Maths.Vector4D<float> coefficients)
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector4D<float>* coefficientsPtr = &coefficients)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Silk.NET.Maths.Vector4D<float>*, int>)@this->LpVtbl[4])(@this, coefficientsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetClampOutput(Silk.NET.Core.Bool32 clampoutput)
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[5])(@this, clampoutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCoefficient1(float Coeffcient1)
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, float, int>)@this->LpVtbl[7])(@this, Coeffcient1);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCoefficient2(float Coefficient2)
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, float, int>)@this->LpVtbl[9])(@this, Coefficient2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCoefficient3(float Coefficient3)
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, float, int>)@this->LpVtbl[11])(@this, Coefficient3);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCoefficient4(float Coefficient4)
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, float, int>)@this->LpVtbl[13])(@this, Coefficient4);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInput<TI0>(uint index, ComPtr<TI0> input, uint flags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetInput(index, (Silk.NET.Core.Native.IUnknown*) input.Handle, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionArithmeticCompositeEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
