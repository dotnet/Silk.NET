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
    [Guid("4305ee5b-c4a0-4c88-9385-67124e017683")]
    [NativeName("Name", "IDCompositionLinearTransferEffect")]
    public unsafe partial struct IDCompositionLinearTransferEffect : IComVtbl<IDCompositionLinearTransferEffect>, IComVtbl<IDCompositionFilterEffect>, IComVtbl<IDCompositionEffect>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("4305ee5b-c4a0-4c88-9385-67124e017683");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionFilterEffect(IDCompositionLinearTransferEffect val)
            => Unsafe.As<IDCompositionLinearTransferEffect, IDCompositionFilterEffect>(ref val);

        public static implicit operator IDCompositionEffect(IDCompositionLinearTransferEffect val)
            => Unsafe.As<IDCompositionLinearTransferEffect, IDCompositionEffect>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionLinearTransferEffect val)
            => Unsafe.As<IDCompositionLinearTransferEffect, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionLinearTransferEffect
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
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInput(uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInput(uint index, ref Silk.NET.Core.Native.IUnknown input, uint flags)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* inputPtr = &input)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, inputPtr, flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRedYIntercept(float redYIntercept)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[5])(@this, redYIntercept);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRedSlope(float redSlope)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[7])(@this, redSlope);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRedDisable(Silk.NET.Core.Bool32 redDisable)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, redDisable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGreenYIntercept(float greenYIntercept)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[10])(@this, greenYIntercept);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGreenSlope(float greenSlope)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[12])(@this, greenSlope);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGreenDisable(Silk.NET.Core.Bool32 greenDisable)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[13])(@this, greenDisable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlueYIntercept(float blueYIntercept)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[15])(@this, blueYIntercept);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlueSlope(float blueSlope)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[17])(@this, blueSlope);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlueDisable(Silk.NET.Core.Bool32 blueDisable)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[18])(@this, blueDisable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAlphaYIntercept(float alphaYIntercept)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[20])(@this, alphaYIntercept);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAlphaSlope(float alphaSlope)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[22])(@this, alphaSlope);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAlphaDisable(Silk.NET.Core.Bool32 alphaDisable)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, alphaDisable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetClampOutput(Silk.NET.Core.Bool32 clampOutput)
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[24])(@this, clampOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInput<TI0>(uint index, ComPtr<TI0> input, uint flags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetInput(index, (Silk.NET.Core.Native.IUnknown*) input.Handle, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionLinearTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
