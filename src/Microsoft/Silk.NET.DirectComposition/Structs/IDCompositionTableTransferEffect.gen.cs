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
    [Guid("9b7e82e2-69c5-4eb4-a5f5-a7033f5132cd")]
    [NativeName("Name", "IDCompositionTableTransferEffect")]
    public unsafe partial struct IDCompositionTableTransferEffect : IComVtbl<IDCompositionTableTransferEffect>, IComVtbl<IDCompositionFilterEffect>, IComVtbl<IDCompositionEffect>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("9b7e82e2-69c5-4eb4-a5f5-a7033f5132cd");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionFilterEffect(IDCompositionTableTransferEffect val)
            => Unsafe.As<IDCompositionTableTransferEffect, IDCompositionFilterEffect>(ref val);

        public static implicit operator IDCompositionEffect(IDCompositionTableTransferEffect val)
            => Unsafe.As<IDCompositionTableTransferEffect, IDCompositionEffect>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionTableTransferEffect val)
            => Unsafe.As<IDCompositionTableTransferEffect, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionTableTransferEffect
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
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInput(uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInput(uint index, ref Silk.NET.Core.Native.IUnknown input, uint flags)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* inputPtr = &input)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, inputPtr, flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetRedTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tableValues, uint count)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[4])(@this, tableValues, count);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRedTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tableValues, uint count)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* tableValuesPtr = &tableValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[4])(@this, tableValuesPtr, count);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetGreenTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tableValues, uint count)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[5])(@this, tableValues, count);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGreenTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tableValues, uint count)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* tableValuesPtr = &tableValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[5])(@this, tableValuesPtr, count);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlueTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tableValues, uint count)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[6])(@this, tableValues, count);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlueTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tableValues, uint count)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* tableValuesPtr = &tableValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[6])(@this, tableValuesPtr, count);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetAlphaTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tableValues, uint count)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[7])(@this, tableValues, count);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAlphaTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tableValues, uint count)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* tableValuesPtr = &tableValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[7])(@this, tableValuesPtr, count);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRedDisable(Silk.NET.Core.Bool32 redDisable)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, redDisable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGreenDisable(Silk.NET.Core.Bool32 greenDisable)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[9])(@this, greenDisable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlueDisable(Silk.NET.Core.Bool32 blueDisable)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, blueDisable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAlphaDisable(Silk.NET.Core.Bool32 alphaDisable)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[11])(@this, alphaDisable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetClampOutput(Silk.NET.Core.Bool32 clampOutput)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[12])(@this, clampOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRedTableValue(uint index, float value)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint, float, int>)@this->LpVtbl[14])(@this, index, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGreenTableValue(uint index, float value)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint, float, int>)@this->LpVtbl[16])(@this, index, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlueTableValue(uint index, float value)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint, float, int>)@this->LpVtbl[18])(@this, index, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAlphaTableValue(uint index, float value)
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint, float, int>)@this->LpVtbl[20])(@this, index, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInput<TI0>(uint index, ComPtr<TI0> input, uint flags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetInput(index, (Silk.NET.Core.Native.IUnknown*) input.Handle, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionTableTransferEffect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
