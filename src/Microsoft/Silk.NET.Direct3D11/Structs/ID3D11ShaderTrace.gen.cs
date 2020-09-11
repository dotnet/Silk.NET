// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "ID3D11ShaderTrace")]
    public unsafe partial struct ID3D11ShaderTrace
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11ShaderTrace val)
            => Unsafe.As<ID3D11ShaderTrace, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D11ShaderTrace
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11ShaderTrace*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int TraceReady(ulong* pTestCount)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTrace*, ulong*, int>)LpVtbl[3])(@this, pTestCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int TraceReady(ref ulong pTestCount)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (ulong* pTestCountPtr = &pTestCount)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTrace*, ulong*, int>)LpVtbl[3])(@this, pTestCountPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void ResetTrace()
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                ((delegate* cdecl<ID3D11ShaderTrace*, void>)LpVtbl[4])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetTraceStats(TraceStats* pTraceStats)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTrace*, TraceStats*, int>)LpVtbl[5])(@this, pTraceStats);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetTraceStats(ref TraceStats pTraceStats)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (TraceStats* pTraceStatsPtr = &pTraceStats)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTrace*, TraceStats*, int>)LpVtbl[5])(@this, pTraceStatsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int PSSelectStamp(uint stampIndex)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint, int>)LpVtbl[6])(@this, stampIndex);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetInitialRegisterContents(TraceRegister* pRegister, TraceValue* pValue)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegister, pValue);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetInitialRegisterContents(TraceRegister* pRegister, ref TraceValue pValue)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (TraceValue* pValuePtr = &pValue)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegister, pValuePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetInitialRegisterContents(ref TraceRegister pRegister, TraceValue* pValue)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (TraceRegister* pRegisterPtr = &pRegister)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegisterPtr, pValue);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetInitialRegisterContents(ref TraceRegister pRegister, ref TraceValue pValue)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (TraceRegister* pRegisterPtr = &pRegister)
                {
                    fixed (TraceValue* pValuePtr = &pValue)
                    {
                        ret = ((delegate* cdecl<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)LpVtbl[7])(@this, pRegisterPtr, pValuePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStep(uint stepIndex, TraceStep* pTraceStep)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint, TraceStep*, int>)LpVtbl[8])(@this, stepIndex, pTraceStep);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetStep(uint stepIndex, ref TraceStep pTraceStep)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (TraceStep* pTraceStepPtr = &pTraceStep)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint, TraceStep*, int>)LpVtbl[8])(@this, stepIndex, pTraceStepPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, TraceValue* pValue)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValue);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, ref TraceValue pValue)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (TraceValue* pValuePtr = &pValue)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValuePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, ref TraceRegister pRegister, TraceValue* pValue)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (TraceRegister* pRegisterPtr = &pRegister)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValue);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, ref TraceRegister pRegister, ref TraceValue pValue)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (TraceRegister* pRegisterPtr = &pRegister)
                {
                    fixed (TraceValue* pValuePtr = &pValue)
                    {
                        ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValuePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetReadRegister(uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, TraceValue* pValue)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValue);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetReadRegister(uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, ref TraceValue pValue)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (TraceValue* pValuePtr = &pValue)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValuePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetReadRegister(uint stepIndex, uint readRegisterIndex, ref TraceRegister pRegister, TraceValue* pValue)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (TraceRegister* pRegisterPtr = &pRegister)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValue);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetReadRegister(uint stepIndex, uint readRegisterIndex, ref TraceRegister pRegister, ref TraceValue pValue)
        {
            fixed (ID3D11ShaderTrace* @this = &this)
            {
                int ret = default;
                fixed (TraceRegister* pRegisterPtr = &pRegister)
                {
                    fixed (TraceValue* pValuePtr = &pValue)
                    {
                        ret = ((delegate* cdecl<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValuePtr);
                    }
                }
                return ret;
            }
        }

    }
}
