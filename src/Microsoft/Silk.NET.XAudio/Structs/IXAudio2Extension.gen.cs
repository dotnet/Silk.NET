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

namespace Silk.NET.XAudio
{
    [Guid("84ac29bb-d619-44d2-b197-e4acf7df3ed6")]
    [NativeName("Name", "IXAudio2Extension")]
    public unsafe partial struct IXAudio2Extension : IComVtbl<IXAudio2Extension>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("84ac29bb-d619-44d2-b197-e4acf7df3ed6");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IXAudio2Extension val)
            => Unsafe.As<IXAudio2Extension, Silk.NET.Core.Native.IUnknown>(ref val);

        public IXAudio2Extension
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
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetProcessingQuantum(uint* quantumNumerator, uint* quantumDenominator)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)@this->LpVtbl[3])(@this, quantumNumerator, quantumDenominator);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetProcessingQuantum(uint* quantumNumerator, ref uint quantumDenominator)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* quantumDenominatorPtr = &quantumDenominator)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)@this->LpVtbl[3])(@this, quantumNumerator, quantumDenominatorPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetProcessingQuantum(ref uint quantumNumerator, uint* quantumDenominator)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* quantumNumeratorPtr = &quantumNumerator)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)@this->LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominator);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetProcessingQuantum(ref uint quantumNumerator, ref uint quantumDenominator)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* quantumNumeratorPtr = &quantumNumerator)
            {
                fixed (uint* quantumDenominatorPtr = &quantumDenominator)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)@this->LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominatorPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetProcessor(uint* processor)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, void>)@this->LpVtbl[4])(@this, processor);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetProcessor(ref uint processor)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* processorPtr = &processor)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, void>)@this->LpVtbl[4])(@this, processorPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
