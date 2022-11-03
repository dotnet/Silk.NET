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

namespace Silk.NET.Direct3D11
{
    [Guid("36b013e6-2811-4845-baa7-d623fe0df104")]
    [NativeName("Name", "ID3D11ShaderTrace")]
    public unsafe partial struct ID3D11ShaderTrace : IComVtbl<ID3D11ShaderTrace>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("36b013e6-2811-4845-baa7-d623fe0df104");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11ShaderTrace val)
            => Unsafe.As<ID3D11ShaderTrace, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11ShaderTrace
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
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TraceReady(ulong* pTestCount)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, ulong*, int>)@this->LpVtbl[3])(@this, pTestCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int TraceReady(ref ulong pTestCount)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pTestCountPtr = &pTestCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, ulong*, int>)@this->LpVtbl[3])(@this, pTestCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ResetTrace()
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, void>)@this->LpVtbl[4])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTraceStats(TraceStats* pTraceStats)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceStats*, int>)@this->LpVtbl[5])(@this, pTraceStats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTraceStats(ref TraceStats pTraceStats)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceStats* pTraceStatsPtr = &pTraceStats)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceStats*, int>)@this->LpVtbl[5])(@this, pTraceStatsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PSSelectStamp(uint stampIndex)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, int>)@this->LpVtbl[6])(@this, stampIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInitialRegisterContents(TraceRegister* pRegister, TraceValue* pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)@this->LpVtbl[7])(@this, pRegister, pValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInitialRegisterContents(TraceRegister* pRegister, ref TraceValue pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceValue* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)@this->LpVtbl[7])(@this, pRegister, pValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInitialRegisterContents(ref TraceRegister pRegister, TraceValue* pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceRegister* pRegisterPtr = &pRegister)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)@this->LpVtbl[7])(@this, pRegisterPtr, pValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetInitialRegisterContents(ref TraceRegister pRegister, ref TraceValue pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceRegister* pRegisterPtr = &pRegister)
            {
                fixed (TraceValue* pValuePtr = &pValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)@this->LpVtbl[7])(@this, pRegisterPtr, pValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStep(uint stepIndex, TraceStep* pTraceStep)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, TraceStep*, int>)@this->LpVtbl[8])(@this, stepIndex, pTraceStep);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStep(uint stepIndex, ref TraceStep pTraceStep)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceStep* pTraceStepPtr = &pTraceStep)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, TraceStep*, int>)@this->LpVtbl[8])(@this, stepIndex, pTraceStepPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, TraceValue* pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, ref TraceValue pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceValue* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, ref TraceRegister pRegister, TraceValue* pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceRegister* pRegisterPtr = &pRegister)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, ref TraceRegister pRegister, ref TraceValue pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceRegister* pRegisterPtr = &pRegister)
            {
                fixed (TraceValue* pValuePtr = &pValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetReadRegister(uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, TraceValue* pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetReadRegister(uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, ref TraceValue pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceValue* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetReadRegister(uint stepIndex, uint readRegisterIndex, ref TraceRegister pRegister, TraceValue* pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceRegister* pRegisterPtr = &pRegister)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetReadRegister(uint stepIndex, uint readRegisterIndex, ref TraceRegister pRegister, ref TraceValue pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceRegister* pRegisterPtr = &pRegister)
            {
                fixed (TraceValue* pValuePtr = &pValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
