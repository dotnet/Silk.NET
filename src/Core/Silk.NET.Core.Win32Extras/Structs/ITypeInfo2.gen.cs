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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("00020412-0000-0000-c000-000000000046")]
    [NativeName("Name", "ITypeInfo2")]
    public unsafe partial struct ITypeInfo2 : IComVtbl<ITypeInfo2>, IComVtbl<ITypeInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00020412-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ITypeInfo(ITypeInfo2 val)
            => Unsafe.As<ITypeInfo2, ITypeInfo>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ITypeInfo2 val)
            => Unsafe.As<ITypeInfo2, Silk.NET.Core.Native.IUnknown>(ref val);

        public ITypeInfo2
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
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeAttr(TypeAttr** ppTypeAttr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, TypeAttr**, int>)@this->LpVtbl[3])(@this, ppTypeAttr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeAttr(ref TypeAttr* ppTypeAttr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TypeAttr** ppTypeAttrPtr = &ppTypeAttr)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, TypeAttr**, int>)@this->LpVtbl[3])(@this, ppTypeAttrPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeComp(ITypeComp** ppTComp)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, ITypeComp**, int>)@this->LpVtbl[4])(@this, ppTComp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeComp(ref ITypeComp* ppTComp)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeComp** ppTCompPtr = &ppTComp)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, ITypeComp**, int>)@this->LpVtbl[4])(@this, ppTCompPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFuncDesc(uint index, FuncDesc** ppFuncDesc)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, FuncDesc**, int>)@this->LpVtbl[5])(@this, index, ppFuncDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFuncDesc(uint index, ref FuncDesc* ppFuncDesc)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FuncDesc** ppFuncDescPtr = &ppFuncDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, FuncDesc**, int>)@this->LpVtbl[5])(@this, index, ppFuncDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVarDesc(uint index, VarDesc** ppVarDesc)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, VarDesc**, int>)@this->LpVtbl[6])(@this, index, ppVarDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVarDesc(uint index, ref VarDesc* ppVarDesc)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VarDesc** ppVarDescPtr = &ppVarDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, VarDesc**, int>)@this->LpVtbl[6])(@this, index, ppVarDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNames(int memid, char** rgBstrNames, uint cMaxNames, uint* pcNames)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, uint, uint*, int>)@this->LpVtbl[7])(@this, memid, rgBstrNames, cMaxNames, pcNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNames(int memid, char** rgBstrNames, uint cMaxNames, ref uint pcNames)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcNamesPtr = &pcNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, uint, uint*, int>)@this->LpVtbl[7])(@this, memid, rgBstrNames, cMaxNames, pcNamesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNames(int memid, ref char* rgBstrNames, uint cMaxNames, uint* pcNames)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** rgBstrNamesPtr = &rgBstrNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, uint, uint*, int>)@this->LpVtbl[7])(@this, memid, rgBstrNamesPtr, cMaxNames, pcNames);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNames(int memid, ref char* rgBstrNames, uint cMaxNames, ref uint pcNames)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** rgBstrNamesPtr = &rgBstrNames)
            {
                fixed (uint* pcNamesPtr = &pcNames)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, uint, uint*, int>)@this->LpVtbl[7])(@this, memid, rgBstrNamesPtr, cMaxNames, pcNamesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRefTypeOfImplType(uint index, uint* pRefType)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint*, int>)@this->LpVtbl[8])(@this, index, pRefType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRefTypeOfImplType(uint index, ref uint pRefType)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pRefTypePtr = &pRefType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint*, int>)@this->LpVtbl[8])(@this, index, pRefTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetImplTypeFlags(uint index, int* pImplTypeFlags)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, int*, int>)@this->LpVtbl[9])(@this, index, pImplTypeFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetImplTypeFlags(uint index, ref int pImplTypeFlags)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pImplTypeFlagsPtr = &pImplTypeFlags)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, int*, int>)@this->LpVtbl[9])(@this, index, pImplTypeFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(char** rgszNames, uint cNames, int* pMemId)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, char**, uint, int*, int>)@this->LpVtbl[10])(@this, rgszNames, cNames, pMemId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(char** rgszNames, uint cNames, ref int pMemId)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pMemIdPtr = &pMemId)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, char**, uint, int*, int>)@this->LpVtbl[10])(@this, rgszNames, cNames, pMemIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(ref char* rgszNames, uint cNames, int* pMemId)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** rgszNamesPtr = &rgszNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, char**, uint, int*, int>)@this->LpVtbl[10])(@this, rgszNamesPtr, cNames, pMemId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(ref char* rgszNames, uint cNames, ref int pMemId)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** rgszNamesPtr = &rgszNames)
            {
                fixed (int* pMemIdPtr = &pMemId)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, char**, uint, int*, int>)@this->LpVtbl[10])(@this, rgszNamesPtr, cNames, pMemIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puArgErrPtr = &puArgErr)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErrPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErrPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErrPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErrPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        fixed (uint* puArgErrPtr = &puArgErr)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErrPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        fixed (uint* puArgErrPtr = &puArgErr)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        fixed (uint* puArgErrPtr = &puArgErr)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErrPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (Variant* pVarResultPtr = &pVarResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (Variant* pVarResultPtr = &pVarResult)
                    {
                        fixed (uint* puArgErrPtr = &puArgErr)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErrPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (Variant* pVarResultPtr = &pVarResult)
                    {
                        fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Invoke<T0>(ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr) where T0 : unmanaged
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvInstancePtr = &pvInstance)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (Variant* pVarResultPtr = &pVarResult)
                    {
                        fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                        {
                            fixed (uint* puArgErrPtr = &puArgErr)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, char** pBstrName, char** pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocString, pdwHelpContextPtr, pBstrHelpFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, char** pBstrName, char** pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
            {
                fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocString, pdwHelpContextPtr, pBstrHelpFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, char** pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrDocStringPtr = &pBstrDocString)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, char** pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrDocStringPtr = &pBstrDocString)
            {
                fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, char** pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrDocStringPtr = &pBstrDocString)
            {
                fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocStringPtr, pdwHelpContextPtr, pBstrHelpFile);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, char** pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrDocStringPtr = &pBstrDocString)
            {
                fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
                {
                    fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocStringPtr, pdwHelpContextPtr, pBstrHelpFilePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrNamePtr = &pBstrName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocString, pdwHelpContext, pBstrHelpFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, char** pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrNamePtr = &pBstrName)
            {
                fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocString, pdwHelpContext, pBstrHelpFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, char** pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrNamePtr = &pBstrName)
            {
                fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocString, pdwHelpContextPtr, pBstrHelpFile);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, char** pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrNamePtr = &pBstrName)
            {
                fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
                {
                    fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocString, pdwHelpContextPtr, pBstrHelpFilePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrNamePtr = &pBstrName)
            {
                fixed (char** pBstrDocStringPtr = &pBstrDocString)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFile);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrNamePtr = &pBstrName)
            {
                fixed (char** pBstrDocStringPtr = &pBstrDocString)
                {
                    fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFilePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrNamePtr = &pBstrName)
            {
                fixed (char** pBstrDocStringPtr = &pBstrDocString)
                {
                    fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocStringPtr, pdwHelpContextPtr, pBstrHelpFile);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrNamePtr = &pBstrName)
            {
                fixed (char** pBstrDocStringPtr = &pBstrDocString)
                {
                    fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
                    {
                        fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocStringPtr, pdwHelpContextPtr, pBstrHelpFilePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, char** pBstrDllName, char** pBstrName, ushort* pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, char** pBstrDllName, char** pBstrName, ref ushort pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* pwOrdinalPtr = &pwOrdinal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllName, pBstrName, pwOrdinalPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, char** pBstrDllName, ref char* pBstrName, ushort* pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrNamePtr = &pBstrName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllName, pBstrNamePtr, pwOrdinal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, char** pBstrDllName, ref char* pBstrName, ref ushort pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrNamePtr = &pBstrName)
            {
                fixed (ushort* pwOrdinalPtr = &pwOrdinal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllName, pBstrNamePtr, pwOrdinalPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, ref char* pBstrDllName, char** pBstrName, ushort* pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrDllNamePtr = &pBstrDllName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllNamePtr, pBstrName, pwOrdinal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, ref char* pBstrDllName, char** pBstrName, ref ushort pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrDllNamePtr = &pBstrDllName)
            {
                fixed (ushort* pwOrdinalPtr = &pwOrdinal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllNamePtr, pBstrName, pwOrdinalPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, ref char* pBstrDllName, ref char* pBstrName, ushort* pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrDllNamePtr = &pBstrDllName)
            {
                fixed (char** pBstrNamePtr = &pBstrName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllNamePtr, pBstrNamePtr, pwOrdinal);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, ref char* pBstrDllName, ref char* pBstrName, ref ushort pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrDllNamePtr = &pBstrDllName)
            {
                fixed (char** pBstrNamePtr = &pBstrName)
                {
                    fixed (ushort* pwOrdinalPtr = &pwOrdinal)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllNamePtr, pBstrNamePtr, pwOrdinalPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRefTypeInfo(uint hRefType, ITypeInfo** ppTInfo)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, ITypeInfo**, int>)@this->LpVtbl[14])(@this, hRefType, ppTInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRefTypeInfo(uint hRefType, ref ITypeInfo* ppTInfo)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, ITypeInfo**, int>)@this->LpVtbl[14])(@this, hRefType, ppTInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddressOfMember(int memid, InvokeKind invKind, void** ppv)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, void**, int>)@this->LpVtbl[15])(@this, memid, invKind, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddressOfMember(int memid, InvokeKind invKind, ref void* ppv)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, void**, int>)@this->LpVtbl[15])(@this, memid, invKind, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, void** ppvObj)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuter, riid, ppvObj);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, ref void* ppvObj)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuter, riid, ppvObjPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, void** ppvObj)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuter, riidPtr, ppvObj);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, ref void* ppvObj)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuter, riidPtr, ppvObjPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, void** ppvObj)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuterPtr, riid, ppvObj);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, ref void* ppvObj)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuterPtr, riid, ppvObjPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, void** ppvObj)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuterPtr, riidPtr, ppvObj);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, ref void* ppvObj)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjPtr = &ppvObj)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuterPtr, riidPtr, ppvObjPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMops(int memid, char** pBstrMops)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, int>)@this->LpVtbl[17])(@this, memid, pBstrMops);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMops(int memid, ref char* pBstrMops)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrMopsPtr = &pBstrMops)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, int>)@this->LpVtbl[17])(@this, memid, pBstrMopsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainingTypeLib(ITypeLib** ppTLib, uint* pIndex)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, ITypeLib**, uint*, int>)@this->LpVtbl[18])(@this, ppTLib, pIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainingTypeLib(ITypeLib** ppTLib, ref uint pIndex)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pIndexPtr = &pIndex)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, ITypeLib**, uint*, int>)@this->LpVtbl[18])(@this, ppTLib, pIndexPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainingTypeLib(ref ITypeLib* ppTLib, uint* pIndex)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeLib** ppTLibPtr = &ppTLib)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, ITypeLib**, uint*, int>)@this->LpVtbl[18])(@this, ppTLibPtr, pIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainingTypeLib(ref ITypeLib* ppTLib, ref uint pIndex)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeLib** ppTLibPtr = &ppTLib)
            {
                fixed (uint* pIndexPtr = &pIndex)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, ITypeLib**, uint*, int>)@this->LpVtbl[18])(@this, ppTLibPtr, pIndexPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseTypeAttr(TypeAttr* pTypeAttr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ITypeInfo2*, TypeAttr*, void>)@this->LpVtbl[19])(@this, pTypeAttr);
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseTypeAttr(ref TypeAttr pTypeAttr)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TypeAttr* pTypeAttrPtr = &pTypeAttr)
            {
                ((delegate* unmanaged[Cdecl]<ITypeInfo2*, TypeAttr*, void>)@this->LpVtbl[19])(@this, pTypeAttrPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseFuncDesc(FuncDesc* pFuncDesc)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ITypeInfo2*, FuncDesc*, void>)@this->LpVtbl[20])(@this, pFuncDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseFuncDesc(ref FuncDesc pFuncDesc)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FuncDesc* pFuncDescPtr = &pFuncDesc)
            {
                ((delegate* unmanaged[Cdecl]<ITypeInfo2*, FuncDesc*, void>)@this->LpVtbl[20])(@this, pFuncDescPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseVarDesc(VarDesc* pVarDesc)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ITypeInfo2*, VarDesc*, void>)@this->LpVtbl[21])(@this, pVarDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseVarDesc(ref VarDesc pVarDesc)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VarDesc* pVarDescPtr = &pVarDesc)
            {
                ((delegate* unmanaged[Cdecl]<ITypeInfo2*, VarDesc*, void>)@this->LpVtbl[21])(@this, pVarDescPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeKind(TypeKind* pTypeKind)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, TypeKind*, int>)@this->LpVtbl[22])(@this, pTypeKind);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTypeKind(ref TypeKind pTypeKind)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TypeKind* pTypeKindPtr = &pTypeKind)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, TypeKind*, int>)@this->LpVtbl[22])(@this, pTypeKindPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeFlags(uint* pTypeFlags)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint*, int>)@this->LpVtbl[23])(@this, pTypeFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTypeFlags(ref uint pTypeFlags)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pTypeFlagsPtr = &pTypeFlags)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint*, int>)@this->LpVtbl[23])(@this, pTypeFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFuncIndexOfMemId(int memid, InvokeKind invKind, uint* pFuncIndex)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, uint*, int>)@this->LpVtbl[24])(@this, memid, invKind, pFuncIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFuncIndexOfMemId(int memid, InvokeKind invKind, ref uint pFuncIndex)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFuncIndexPtr = &pFuncIndex)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, uint*, int>)@this->LpVtbl[24])(@this, memid, invKind, pFuncIndexPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVarIndexOfMemId(int memid, uint* pVarIndex)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint*, int>)@this->LpVtbl[25])(@this, memid, pVarIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVarIndexOfMemId(int memid, ref uint pVarIndex)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pVarIndexPtr = &pVarIndex)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint*, int>)@this->LpVtbl[25])(@this, memid, pVarIndexPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCustData(Guid* guid, Variant* pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[26])(@this, guid, pVarVal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCustData(Guid* guid, ref Variant pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[26])(@this, guid, pVarValPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCustData(ref Guid guid, Variant* pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[26])(@this, guidPtr, pVarVal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCustData(ref Guid guid, ref Variant pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Variant* pVarValPtr = &pVarVal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[26])(@this, guidPtr, pVarValPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFuncCustData(uint index, Guid* guid, Variant* pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[27])(@this, index, guid, pVarVal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFuncCustData(uint index, Guid* guid, ref Variant pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[27])(@this, index, guid, pVarValPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFuncCustData(uint index, ref Guid guid, Variant* pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[27])(@this, index, guidPtr, pVarVal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFuncCustData(uint index, ref Guid guid, ref Variant pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Variant* pVarValPtr = &pVarVal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[27])(@this, index, guidPtr, pVarValPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParamCustData(uint indexFunc, uint indexParam, Guid* guid, Variant* pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[28])(@this, indexFunc, indexParam, guid, pVarVal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParamCustData(uint indexFunc, uint indexParam, Guid* guid, ref Variant pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[28])(@this, indexFunc, indexParam, guid, pVarValPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParamCustData(uint indexFunc, uint indexParam, ref Guid guid, Variant* pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[28])(@this, indexFunc, indexParam, guidPtr, pVarVal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetParamCustData(uint indexFunc, uint indexParam, ref Guid guid, ref Variant pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Variant* pVarValPtr = &pVarVal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[28])(@this, indexFunc, indexParam, guidPtr, pVarValPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVarCustData(uint index, Guid* guid, Variant* pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[29])(@this, index, guid, pVarVal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVarCustData(uint index, Guid* guid, ref Variant pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[29])(@this, index, guid, pVarValPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVarCustData(uint index, ref Guid guid, Variant* pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[29])(@this, index, guidPtr, pVarVal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVarCustData(uint index, ref Guid guid, ref Variant pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Variant* pVarValPtr = &pVarVal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[29])(@this, index, guidPtr, pVarValPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetImplTypeCustData(uint index, Guid* guid, Variant* pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[30])(@this, index, guid, pVarVal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetImplTypeCustData(uint index, Guid* guid, ref Variant pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[30])(@this, index, guid, pVarValPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetImplTypeCustData(uint index, ref Guid guid, Variant* pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[30])(@this, index, guidPtr, pVarVal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetImplTypeCustData(uint index, ref Guid guid, ref Variant pVarVal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Variant* pVarValPtr = &pVarVal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[30])(@this, index, guidPtr, pVarValPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, char** pbstrHelpString, uint* pdwHelpStringContext, char** pbstrHelpStringDll)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[31])(@this, memid, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, char** pbstrHelpString, uint* pdwHelpStringContext, ref char* pbstrHelpStringDll)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pbstrHelpStringDllPtr = &pbstrHelpStringDll)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[31])(@this, memid, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDllPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, char** pbstrHelpString, ref uint pdwHelpStringContext, char** pbstrHelpStringDll)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwHelpStringContextPtr = &pdwHelpStringContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[31])(@this, memid, lcid, pbstrHelpString, pdwHelpStringContextPtr, pbstrHelpStringDll);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, char** pbstrHelpString, ref uint pdwHelpStringContext, ref char* pbstrHelpStringDll)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwHelpStringContextPtr = &pdwHelpStringContext)
            {
                fixed (char** pbstrHelpStringDllPtr = &pbstrHelpStringDll)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[31])(@this, memid, lcid, pbstrHelpString, pdwHelpStringContextPtr, pbstrHelpStringDllPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, ref char* pbstrHelpString, uint* pdwHelpStringContext, char** pbstrHelpStringDll)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pbstrHelpStringPtr = &pbstrHelpString)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[31])(@this, memid, lcid, pbstrHelpStringPtr, pdwHelpStringContext, pbstrHelpStringDll);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, ref char* pbstrHelpString, uint* pdwHelpStringContext, ref char* pbstrHelpStringDll)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pbstrHelpStringPtr = &pbstrHelpString)
            {
                fixed (char** pbstrHelpStringDllPtr = &pbstrHelpStringDll)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[31])(@this, memid, lcid, pbstrHelpStringPtr, pdwHelpStringContext, pbstrHelpStringDllPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, ref char* pbstrHelpString, ref uint pdwHelpStringContext, char** pbstrHelpStringDll)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pbstrHelpStringPtr = &pbstrHelpString)
            {
                fixed (uint* pdwHelpStringContextPtr = &pdwHelpStringContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[31])(@this, memid, lcid, pbstrHelpStringPtr, pdwHelpStringContextPtr, pbstrHelpStringDll);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, ref char* pbstrHelpString, ref uint pdwHelpStringContext, ref char* pbstrHelpStringDll)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pbstrHelpStringPtr = &pbstrHelpString)
            {
                fixed (uint* pdwHelpStringContextPtr = &pdwHelpStringContext)
                {
                    fixed (char** pbstrHelpStringDllPtr = &pbstrHelpStringDll)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[31])(@this, memid, lcid, pbstrHelpStringPtr, pdwHelpStringContextPtr, pbstrHelpStringDllPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAllCustData(CustomData* pCustData)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, CustomData*, int>)@this->LpVtbl[32])(@this, pCustData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAllCustData(ref CustomData pCustData)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CustomData* pCustDataPtr = &pCustData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, CustomData*, int>)@this->LpVtbl[32])(@this, pCustDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAllFuncCustData(uint index, CustomData* pCustData)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, CustomData*, int>)@this->LpVtbl[33])(@this, index, pCustData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAllFuncCustData(uint index, ref CustomData pCustData)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CustomData* pCustDataPtr = &pCustData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, CustomData*, int>)@this->LpVtbl[33])(@this, index, pCustDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAllParamCustData(uint indexFunc, uint indexParam, CustomData* pCustData)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint, CustomData*, int>)@this->LpVtbl[34])(@this, indexFunc, indexParam, pCustData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAllParamCustData(uint indexFunc, uint indexParam, ref CustomData pCustData)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CustomData* pCustDataPtr = &pCustData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint, CustomData*, int>)@this->LpVtbl[34])(@this, indexFunc, indexParam, pCustDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAllVarCustData(uint index, CustomData* pCustData)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, CustomData*, int>)@this->LpVtbl[35])(@this, index, pCustData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAllVarCustData(uint index, ref CustomData pCustData)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CustomData* pCustDataPtr = &pCustData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, CustomData*, int>)@this->LpVtbl[35])(@this, index, pCustDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAllImplTypeCustData(uint index, CustomData* pCustData)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, CustomData*, int>)@this->LpVtbl[36])(@this, index, pCustData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAllImplTypeCustData(uint index, ref CustomData pCustData)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CustomData* pCustDataPtr = &pCustData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, CustomData*, int>)@this->LpVtbl[36])(@this, index, pCustDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTypeComp<TI0>(ref ComPtr<TI0> ppTComp) where TI0 : unmanaged, IComVtbl<ITypeComp>, IComVtbl<TI0>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypeComp((ITypeComp**) ppTComp.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNames(int memid, string[] rgBstrNamesSa, uint cMaxNames, uint* pcNames)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rgBstrNames = (char**) SilkMarshal.StringArrayToPtr(rgBstrNamesSa);
            var ret = @this->GetNames(memid, rgBstrNames, cMaxNames, pcNames);
            SilkMarshal.CopyPtrToStringArray((nint) rgBstrNames, rgBstrNamesSa);
            SilkMarshal.Free((nint) rgBstrNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetNames(int memid, string[] rgBstrNamesSa, uint cMaxNames, ref uint pcNames)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rgBstrNames = (char**) SilkMarshal.StringArrayToPtr(rgBstrNamesSa);
            var ret = @this->GetNames(memid, rgBstrNames, cMaxNames, ref pcNames);
            SilkMarshal.CopyPtrToStringArray((nint) rgBstrNames, rgBstrNamesSa);
            SilkMarshal.Free((nint) rgBstrNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(string[] rgszNamesSa, uint cNames, int* pMemId)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
            var ret = @this->GetIDsOfNames(rgszNames, cNames, pMemId);
            SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
            SilkMarshal.Free((nint) rgszNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetIDsOfNames(string[] rgszNamesSa, uint cNames, ref int pMemId)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
            var ret = @this->GetIDsOfNames(rgszNames, cNames, ref pMemId);
            SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
            SilkMarshal.Free((nint) rgszNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, string[] pBstrNameSa, string[] pBstrDocStringSa, uint* pdwHelpContext, string[] pBstrHelpFileSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
            var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
            var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
            var ret = @this->GetDocumentation(memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
            SilkMarshal.Free((nint) pBstrName);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
            SilkMarshal.Free((nint) pBstrDocString);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
            SilkMarshal.Free((nint) pBstrHelpFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, string[] pBstrNameSa, string[] pBstrDocStringSa, uint* pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
            var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
            var ret = @this->GetDocumentation(memid, pBstrName, pBstrDocString, pdwHelpContext, ref pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
            SilkMarshal.Free((nint) pBstrName);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
            SilkMarshal.Free((nint) pBstrDocString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDocumentation(int memid, string[] pBstrNameSa, string[] pBstrDocStringSa, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
            var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
            var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
            var ret = @this->GetDocumentation(memid, pBstrName, pBstrDocString, ref pdwHelpContext, pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
            SilkMarshal.Free((nint) pBstrName);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
            SilkMarshal.Free((nint) pBstrDocString);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
            SilkMarshal.Free((nint) pBstrHelpFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, string[] pBstrNameSa, string[] pBstrDocStringSa, ref uint pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
            var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
            var ret = @this->GetDocumentation(memid, pBstrName, pBstrDocString, ref pdwHelpContext, ref pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
            SilkMarshal.Free((nint) pBstrName);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
            SilkMarshal.Free((nint) pBstrDocString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, string[] pBstrNameSa, ref char* pBstrDocString, uint* pdwHelpContext, string[] pBstrHelpFileSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
            var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
            var ret = @this->GetDocumentation(memid, pBstrName, ref pBstrDocString, pdwHelpContext, pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
            SilkMarshal.Free((nint) pBstrName);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
            SilkMarshal.Free((nint) pBstrHelpFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, string[] pBstrNameSa, ref char* pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
            var ret = @this->GetDocumentation(memid, pBstrName, ref pBstrDocString, pdwHelpContext, ref pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
            SilkMarshal.Free((nint) pBstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, string[] pBstrNameSa, ref char* pBstrDocString, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
            var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
            var ret = @this->GetDocumentation(memid, pBstrName, ref pBstrDocString, ref pdwHelpContext, pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
            SilkMarshal.Free((nint) pBstrName);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
            SilkMarshal.Free((nint) pBstrHelpFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, string[] pBstrNameSa, ref char* pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
            var ret = @this->GetDocumentation(memid, pBstrName, ref pBstrDocString, ref pdwHelpContext, ref pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
            SilkMarshal.Free((nint) pBstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, string[] pBstrDocStringSa, uint* pdwHelpContext, string[] pBstrHelpFileSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
            var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
            var ret = @this->GetDocumentation(memid, ref pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
            SilkMarshal.Free((nint) pBstrDocString);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
            SilkMarshal.Free((nint) pBstrHelpFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, string[] pBstrDocStringSa, uint* pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
            var ret = @this->GetDocumentation(memid, ref pBstrName, pBstrDocString, pdwHelpContext, ref pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
            SilkMarshal.Free((nint) pBstrDocString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, string[] pBstrDocStringSa, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
            var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
            var ret = @this->GetDocumentation(memid, ref pBstrName, pBstrDocString, ref pdwHelpContext, pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
            SilkMarshal.Free((nint) pBstrDocString);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
            SilkMarshal.Free((nint) pBstrHelpFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, string[] pBstrDocStringSa, ref uint pdwHelpContext, ref char* pBstrHelpFile)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
            var ret = @this->GetDocumentation(memid, ref pBstrName, pBstrDocString, ref pdwHelpContext, ref pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
            SilkMarshal.Free((nint) pBstrDocString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, string[] pBstrHelpFileSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
            var ret = @this->GetDocumentation(memid, ref pBstrName, ref pBstrDocString, pdwHelpContext, pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
            SilkMarshal.Free((nint) pBstrHelpFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation(int memid, ref char* pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
            var ret = @this->GetDocumentation(memid, ref pBstrName, ref pBstrDocString, ref pdwHelpContext, pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
            SilkMarshal.Free((nint) pBstrHelpFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, string[] pBstrDllNameSa, string[] pBstrNameSa, ushort* pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrDllName = (char**) SilkMarshal.StringArrayToPtr(pBstrDllNameSa);
            var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
            var ret = @this->GetDllEntry(memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDllName, pBstrDllNameSa);
            SilkMarshal.Free((nint) pBstrDllName);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
            SilkMarshal.Free((nint) pBstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDllEntry(int memid, InvokeKind invKind, string[] pBstrDllNameSa, string[] pBstrNameSa, ref ushort pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrDllName = (char**) SilkMarshal.StringArrayToPtr(pBstrDllNameSa);
            var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
            var ret = @this->GetDllEntry(memid, invKind, pBstrDllName, pBstrName, ref pwOrdinal);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDllName, pBstrDllNameSa);
            SilkMarshal.Free((nint) pBstrDllName);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
            SilkMarshal.Free((nint) pBstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, string[] pBstrDllNameSa, ref char* pBstrName, ushort* pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrDllName = (char**) SilkMarshal.StringArrayToPtr(pBstrDllNameSa);
            var ret = @this->GetDllEntry(memid, invKind, pBstrDllName, ref pBstrName, pwOrdinal);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDllName, pBstrDllNameSa);
            SilkMarshal.Free((nint) pBstrDllName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, string[] pBstrDllNameSa, ref char* pBstrName, ref ushort pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrDllName = (char**) SilkMarshal.StringArrayToPtr(pBstrDllNameSa);
            var ret = @this->GetDllEntry(memid, invKind, pBstrDllName, ref pBstrName, ref pwOrdinal);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDllName, pBstrDllNameSa);
            SilkMarshal.Free((nint) pBstrDllName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, ref char* pBstrDllName, string[] pBstrNameSa, ushort* pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
            var ret = @this->GetDllEntry(memid, invKind, ref pBstrDllName, pBstrName, pwOrdinal);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
            SilkMarshal.Free((nint) pBstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDllEntry(int memid, InvokeKind invKind, ref char* pBstrDllName, string[] pBstrNameSa, ref ushort pwOrdinal)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
            var ret = @this->GetDllEntry(memid, invKind, ref pBstrDllName, pBstrName, ref pwOrdinal);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
            SilkMarshal.Free((nint) pBstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRefTypeInfo<TI0>(uint hRefType, ref ComPtr<TI0> ppTInfo) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRefTypeInfo(hRefType, (ITypeInfo**) ppTInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInstance<TI0, TI1>(ComPtr<TI0> pUnkOuter, out ComPtr<TI1> ppvObj) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObj = default;
            return @this->CreateInstance((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvObj.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance<TI0>(ComPtr<TI0> pUnkOuter, Guid* riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInstance((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, riid, ref ppvObj);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance<TI0>(ComPtr<TI0> pUnkOuter, ref Guid riid, void** ppvObj) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInstance((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, ref riid, ppvObj);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance<TI0>(ComPtr<TI0> pUnkOuter, ref Guid riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInstance((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, ref riid, ref ppvObj);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInstance<TI0>(ref Silk.NET.Core.Native.IUnknown pUnkOuter, out ComPtr<TI0> ppvObj) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObj = default;
            return @this->CreateInstance(ref pUnkOuter, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObj.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMops(int memid, string[] pBstrMopsSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrMops = (char**) SilkMarshal.StringArrayToPtr(pBstrMopsSa);
            var ret = @this->GetMops(memid, pBstrMops);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrMops, pBstrMopsSa);
            SilkMarshal.Free((nint) pBstrMops);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainingTypeLib<TI0>(ref ComPtr<TI0> ppTLib, uint* pIndex) where TI0 : unmanaged, IComVtbl<ITypeLib>, IComVtbl<TI0>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetContainingTypeLib((ITypeLib**) ppTLib.GetAddressOf(), pIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContainingTypeLib<TI0>(ref ComPtr<TI0> ppTLib, ref uint pIndex) where TI0 : unmanaged, IComVtbl<ITypeLib>, IComVtbl<TI0>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetContainingTypeLib((ITypeLib**) ppTLib.GetAddressOf(), ref pIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, string[] pbstrHelpStringSa, uint* pdwHelpStringContext, string[] pbstrHelpStringDllSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pbstrHelpString = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringSa);
            var pbstrHelpStringDll = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringDllSa);
            var ret = @this->GetDocumentation2(memid, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
            SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpString, pbstrHelpStringSa);
            SilkMarshal.Free((nint) pbstrHelpString);
            SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpStringDll, pbstrHelpStringDllSa);
            SilkMarshal.Free((nint) pbstrHelpStringDll);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, string[] pbstrHelpStringSa, uint* pdwHelpStringContext, ref char* pbstrHelpStringDll)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pbstrHelpString = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringSa);
            var ret = @this->GetDocumentation2(memid, lcid, pbstrHelpString, pdwHelpStringContext, ref pbstrHelpStringDll);
            SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpString, pbstrHelpStringSa);
            SilkMarshal.Free((nint) pbstrHelpString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDocumentation2(int memid, uint lcid, string[] pbstrHelpStringSa, ref uint pdwHelpStringContext, string[] pbstrHelpStringDllSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pbstrHelpString = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringSa);
            var pbstrHelpStringDll = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringDllSa);
            var ret = @this->GetDocumentation2(memid, lcid, pbstrHelpString, ref pdwHelpStringContext, pbstrHelpStringDll);
            SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpString, pbstrHelpStringSa);
            SilkMarshal.Free((nint) pbstrHelpString);
            SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpStringDll, pbstrHelpStringDllSa);
            SilkMarshal.Free((nint) pbstrHelpStringDll);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, string[] pbstrHelpStringSa, ref uint pdwHelpStringContext, ref char* pbstrHelpStringDll)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pbstrHelpString = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringSa);
            var ret = @this->GetDocumentation2(memid, lcid, pbstrHelpString, ref pdwHelpStringContext, ref pbstrHelpStringDll);
            SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpString, pbstrHelpStringSa);
            SilkMarshal.Free((nint) pbstrHelpString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, ref char* pbstrHelpString, uint* pdwHelpStringContext, string[] pbstrHelpStringDllSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pbstrHelpStringDll = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringDllSa);
            var ret = @this->GetDocumentation2(memid, lcid, ref pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
            SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpStringDll, pbstrHelpStringDllSa);
            SilkMarshal.Free((nint) pbstrHelpStringDll);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDocumentation2(int memid, uint lcid, ref char* pbstrHelpString, ref uint pdwHelpStringContext, string[] pbstrHelpStringDllSa)
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pbstrHelpStringDll = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringDllSa);
            var ret = @this->GetDocumentation2(memid, lcid, ref pbstrHelpString, ref pdwHelpStringContext, pbstrHelpStringDll);
            SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpStringDll, pbstrHelpStringDllSa);
            SilkMarshal.Free((nint) pbstrHelpStringDll);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateInstance<TI0, TI1>(ComPtr<TI0> pUnkOuter) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateInstance(pUnkOuter, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateInstance<TI0>(ref Silk.NET.Core.Native.IUnknown pUnkOuter) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ITypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateInstance(ref pUnkOuter, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
