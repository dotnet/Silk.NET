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
    public unsafe partial struct ID3D11ShaderTrace
    {
        public static readonly Guid Guid = new("36b013e6-2811-4845-baa7-d623fe0df104");

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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TraceReady(ulong* pTestCount)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderTrace*, ulong*, int>)LpVtbl[3])(@this, pTestCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, ulong*, int>)LpVtbl[3])(@this, pTestCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, ulong*, int>)LpVtbl[3])(@this, pTestCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int TraceReady(ref ulong pTestCount)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pTestCountPtr = &pTestCount)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderTrace*, ulong*, int>)LpVtbl[3])(@this, pTestCountPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, ulong*, int>)LpVtbl[3])(@this, pTestCountPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, ulong*, int>)LpVtbl[3])(@this, pTestCountPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ResetTrace()
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, void>)LpVtbl[4])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTraceStats(TraceStats* pTraceStats)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderTrace*, TraceStats*, int>)LpVtbl[5])(@this, pTraceStats);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceStats*, int>)LpVtbl[5])(@this, pTraceStats);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, TraceStats*, int>)LpVtbl[5])(@this, pTraceStats);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTraceStats(ref TraceStats pTraceStats)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceStats* pTraceStatsPtr = &pTraceStats)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderTrace*, TraceStats*, int>)LpVtbl[5])(@this, pTraceStatsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceStats*, int>)LpVtbl[5])(@this, pTraceStatsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, TraceStats*, int>)LpVtbl[5])(@this, pTraceStatsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PSSelectStamp(uint stampIndex)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderTrace*, uint, int>)LpVtbl[6])(@this, stampIndex);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, int>)LpVtbl[6])(@this, stampIndex);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, uint, int>)LpVtbl[6])(@this, stampIndex);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInitialRegisterContents(TraceRegister* pRegister, TraceValue* pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegister, pValue);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegister, pValue);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegister, pValue);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInitialRegisterContents(TraceRegister* pRegister, ref TraceValue pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceValue* pValuePtr = &pValue)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegister, pValuePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegister, pValuePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegister, pValuePtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegisterPtr, pValue);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegisterPtr, pValue);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegisterPtr, pValue);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegisterPtr, pValuePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegisterPtr, pValuePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegisterPtr, pValuePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStep(uint stepIndex, TraceStep* pTraceStep)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderTrace*, uint, TraceStep*, int>)LpVtbl[8])(@this, stepIndex, pTraceStep);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, TraceStep*, int>)LpVtbl[8])(@this, stepIndex, pTraceStep);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, uint, TraceStep*, int>)LpVtbl[8])(@this, stepIndex, pTraceStep);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStep(uint stepIndex, ref TraceStep pTraceStep)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceStep* pTraceStepPtr = &pTraceStep)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderTrace*, uint, TraceStep*, int>)LpVtbl[8])(@this, stepIndex, pTraceStepPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, TraceStep*, int>)LpVtbl[8])(@this, stepIndex, pTraceStepPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, uint, TraceStep*, int>)LpVtbl[8])(@this, stepIndex, pTraceStepPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, TraceValue* pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValue);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValue);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValue);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, ref TraceValue pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceValue* pValuePtr = &pValue)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValuePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValuePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValuePtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValue);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValue);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValue);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValuePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValuePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValuePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetReadRegister(uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, TraceValue* pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValue);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValue);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValue);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetReadRegister(uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, ref TraceValue pValue)
        {
            var @this = (ID3D11ShaderTrace*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TraceValue* pValuePtr = &pValue)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValuePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValuePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValuePtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValue);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValue);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValue);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValuePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValuePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValuePtr);
                    }
            #endif
                }
            }
            return ret;
        }

    }
}
