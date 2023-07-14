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
    [Guid("4ad18ac0-cfd2-4c2f-bb62-96e54fdb6879")]
    [NativeName("Name", "IDCompositionShadowEffect")]
    public unsafe partial struct IDCompositionShadowEffect : IComVtbl<IDCompositionShadowEffect>, IComVtbl<IDCompositionFilterEffect>, IComVtbl<IDCompositionEffect>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("4ad18ac0-cfd2-4c2f-bb62-96e54fdb6879");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionFilterEffect(IDCompositionShadowEffect val)
            => Unsafe.As<IDCompositionShadowEffect, IDCompositionFilterEffect>(ref val);

        public static implicit operator IDCompositionEffect(IDCompositionShadowEffect val)
            => Unsafe.As<IDCompositionShadowEffect, IDCompositionEffect>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionShadowEffect val)
            => Unsafe.As<IDCompositionShadowEffect, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionShadowEffect
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
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInput(uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInput(uint index, ref Silk.NET.Core.Native.IUnknown input, uint flags)
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* inputPtr = &input)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, inputPtr, flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStandardDeviation(float amount)
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)@this->LpVtbl[5])(@this, amount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetColor(Silk.NET.Maths.Vector4D<float>* color)
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Silk.NET.Maths.Vector4D<float>*, int>)@this->LpVtbl[6])(@this, color);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetColor(ref Silk.NET.Maths.Vector4D<float> color)
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector4D<float>* colorPtr = &color)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Silk.NET.Maths.Vector4D<float>*, int>)@this->LpVtbl[6])(@this, colorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRed(float amount)
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)@this->LpVtbl[8])(@this, amount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGreen(float amount)
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)@this->LpVtbl[10])(@this, amount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlue(float amount)
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)@this->LpVtbl[12])(@this, amount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAlpha(float amount)
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)@this->LpVtbl[14])(@this, amount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInput<TI0>(uint index, ComPtr<TI0> input, uint flags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetInput(index, (Silk.NET.Core.Native.IUnknown*) input.Handle, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionShadowEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
