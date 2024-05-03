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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class TypeInfo2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeInfo2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeInfo2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeInfo2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeInfo2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<ITypeInfo2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ITypeInfo2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeAttr(this ComPtr<ITypeInfo2> thisVtbl, TypeAttr** ppTypeAttr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, TypeAttr**, int>)@this->LpVtbl[3])(@this, ppTypeAttr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeAttr(this ComPtr<ITypeInfo2> thisVtbl, ref TypeAttr* ppTypeAttr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TypeAttr** ppTypeAttrPtr = &ppTypeAttr)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, TypeAttr**, int>)@this->LpVtbl[3])(@this, ppTypeAttrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeComp(this ComPtr<ITypeInfo2> thisVtbl, ITypeComp** ppTComp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, ITypeComp**, int>)@this->LpVtbl[4])(@this, ppTComp);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeComp(this ComPtr<ITypeInfo2> thisVtbl, ref ITypeComp* ppTComp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeComp** ppTCompPtr = &ppTComp)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, ITypeComp**, int>)@this->LpVtbl[4])(@this, ppTCompPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFuncDesc(this ComPtr<ITypeInfo2> thisVtbl, uint index, FuncDesc** ppFuncDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, FuncDesc**, int>)@this->LpVtbl[5])(@this, index, ppFuncDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFuncDesc(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref FuncDesc* ppFuncDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FuncDesc** ppFuncDescPtr = &ppFuncDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, FuncDesc**, int>)@this->LpVtbl[5])(@this, index, ppFuncDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVarDesc(this ComPtr<ITypeInfo2> thisVtbl, uint index, VarDesc** ppVarDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, VarDesc**, int>)@this->LpVtbl[6])(@this, index, ppVarDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVarDesc(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref VarDesc* ppVarDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VarDesc** ppVarDescPtr = &ppVarDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, VarDesc**, int>)@this->LpVtbl[6])(@this, index, ppVarDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** rgBstrNames, uint cMaxNames, uint* pcNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, uint, uint*, int>)@this->LpVtbl[7])(@this, memid, rgBstrNames, cMaxNames, pcNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** rgBstrNames, uint cMaxNames, ref uint pcNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcNamesPtr = &pcNames)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, uint, uint*, int>)@this->LpVtbl[7])(@this, memid, rgBstrNames, cMaxNames, pcNamesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* rgBstrNames, uint cMaxNames, uint* pcNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** rgBstrNamesPtr = &rgBstrNames)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, uint, uint*, int>)@this->LpVtbl[7])(@this, memid, rgBstrNamesPtr, cMaxNames, pcNames);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* rgBstrNames, uint cMaxNames, ref uint pcNames)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetRefTypeOfImplType(this ComPtr<ITypeInfo2> thisVtbl, uint index, uint* pRefType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint*, int>)@this->LpVtbl[8])(@this, index, pRefType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRefTypeOfImplType(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref uint pRefType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pRefTypePtr = &pRefType)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint*, int>)@this->LpVtbl[8])(@this, index, pRefTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImplTypeFlags(this ComPtr<ITypeInfo2> thisVtbl, uint index, int* pImplTypeFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, int*, int>)@this->LpVtbl[9])(@this, index, pImplTypeFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetImplTypeFlags(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref int pImplTypeFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pImplTypeFlagsPtr = &pImplTypeFlags)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, int*, int>)@this->LpVtbl[9])(@this, index, pImplTypeFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo2> thisVtbl, char** rgszNames, uint cNames, int* pMemId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, char**, uint, int*, int>)@this->LpVtbl[10])(@this, rgszNames, cNames, pMemId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo2> thisVtbl, char** rgszNames, uint cNames, ref int pMemId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pMemIdPtr = &pMemId)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, char**, uint, int*, int>)@this->LpVtbl[10])(@this, rgszNames, cNames, pMemIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo2> thisVtbl, ref char* rgszNames, uint cNames, int* pMemId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** rgszNamesPtr = &rgszNames)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, char**, uint, int*, int>)@this->LpVtbl[10])(@this, rgszNamesPtr, cNames, pMemId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo2> thisVtbl, ref char* rgszNames, uint cNames, ref int pMemId)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puArgErrPtr = &puArgErr)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarResultPtr = &pVarResult)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvInstancePtr = &pvInstance)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrName, char** pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocString, pdwHelpContextPtr, pBstrHelpFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrName, char** pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDocStringPtr = &pBstrDocString)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, char** pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, char** pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, char** pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, char** pBstrDllName, char** pBstrName, ushort* pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, char** pBstrDllName, char** pBstrName, ref ushort pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* pwOrdinalPtr = &pwOrdinal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllName, pBstrName, pwOrdinalPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, char** pBstrDllName, ref char* pBstrName, ushort* pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllName, pBstrNamePtr, pwOrdinal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, char** pBstrDllName, ref char* pBstrName, ref ushort pwOrdinal)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, char** pBstrName, ushort* pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDllNamePtr = &pBstrDllName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllNamePtr, pBstrName, pwOrdinal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, char** pBstrName, ref ushort pwOrdinal)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, ref char* pBstrName, ushort* pwOrdinal)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, ref char* pBstrName, ref ushort pwOrdinal)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetRefTypeInfo(this ComPtr<ITypeInfo2> thisVtbl, uint hRefType, ITypeInfo** ppTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, ITypeInfo**, int>)@this->LpVtbl[14])(@this, hRefType, ppTInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRefTypeInfo(this ComPtr<ITypeInfo2> thisVtbl, uint hRefType, ref ITypeInfo* ppTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, ITypeInfo**, int>)@this->LpVtbl[14])(@this, hRefType, ppTInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddressOfMember(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, void**, int>)@this->LpVtbl[15])(@this, memid, invKind, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddressOfMember(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, void**, int>)@this->LpVtbl[15])(@this, memid, invKind, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuter, riid, ppvObj);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjPtr = &ppvObj)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuter, riid, ppvObjPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuter, riidPtr, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuterPtr, riid, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetMops(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrMops)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, int>)@this->LpVtbl[17])(@this, memid, pBstrMops);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMops(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrMops)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrMopsPtr = &pBstrMops)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, char**, int>)@this->LpVtbl[17])(@this, memid, pBstrMopsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib(this ComPtr<ITypeInfo2> thisVtbl, ITypeLib** ppTLib, uint* pIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, ITypeLib**, uint*, int>)@this->LpVtbl[18])(@this, ppTLib, pIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib(this ComPtr<ITypeInfo2> thisVtbl, ITypeLib** ppTLib, ref uint pIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pIndexPtr = &pIndex)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, ITypeLib**, uint*, int>)@this->LpVtbl[18])(@this, ppTLib, pIndexPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib(this ComPtr<ITypeInfo2> thisVtbl, ref ITypeLib* ppTLib, uint* pIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeLib** ppTLibPtr = &ppTLib)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, ITypeLib**, uint*, int>)@this->LpVtbl[18])(@this, ppTLibPtr, pIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib(this ComPtr<ITypeInfo2> thisVtbl, ref ITypeLib* ppTLib, ref uint pIndex)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe void ReleaseTypeAttr(this ComPtr<ITypeInfo2> thisVtbl, TypeAttr* pTypeAttr)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ITypeInfo2*, TypeAttr*, void>)@this->LpVtbl[19])(@this, pTypeAttr);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseTypeAttr(this ComPtr<ITypeInfo2> thisVtbl, ref TypeAttr pTypeAttr)
    {
        var @this = thisVtbl.Handle;
        fixed (TypeAttr* pTypeAttrPtr = &pTypeAttr)
        {
            ((delegate* unmanaged[Cdecl]<ITypeInfo2*, TypeAttr*, void>)@this->LpVtbl[19])(@this, pTypeAttrPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseFuncDesc(this ComPtr<ITypeInfo2> thisVtbl, FuncDesc* pFuncDesc)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ITypeInfo2*, FuncDesc*, void>)@this->LpVtbl[20])(@this, pFuncDesc);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFuncDesc(this ComPtr<ITypeInfo2> thisVtbl, ref FuncDesc pFuncDesc)
    {
        var @this = thisVtbl.Handle;
        fixed (FuncDesc* pFuncDescPtr = &pFuncDesc)
        {
            ((delegate* unmanaged[Cdecl]<ITypeInfo2*, FuncDesc*, void>)@this->LpVtbl[20])(@this, pFuncDescPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseVarDesc(this ComPtr<ITypeInfo2> thisVtbl, VarDesc* pVarDesc)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ITypeInfo2*, VarDesc*, void>)@this->LpVtbl[21])(@this, pVarDesc);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseVarDesc(this ComPtr<ITypeInfo2> thisVtbl, ref VarDesc pVarDesc)
    {
        var @this = thisVtbl.Handle;
        fixed (VarDesc* pVarDescPtr = &pVarDesc)
        {
            ((delegate* unmanaged[Cdecl]<ITypeInfo2*, VarDesc*, void>)@this->LpVtbl[21])(@this, pVarDescPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeKind(this ComPtr<ITypeInfo2> thisVtbl, TypeKind* pTypeKind)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, TypeKind*, int>)@this->LpVtbl[22])(@this, pTypeKind);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeKind(this ComPtr<ITypeInfo2> thisVtbl, ref TypeKind pTypeKind)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TypeKind* pTypeKindPtr = &pTypeKind)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, TypeKind*, int>)@this->LpVtbl[22])(@this, pTypeKindPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeFlags(this ComPtr<ITypeInfo2> thisVtbl, uint* pTypeFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint*, int>)@this->LpVtbl[23])(@this, pTypeFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeFlags(this ComPtr<ITypeInfo2> thisVtbl, ref uint pTypeFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pTypeFlagsPtr = &pTypeFlags)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint*, int>)@this->LpVtbl[23])(@this, pTypeFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFuncIndexOfMemId(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, uint* pFuncIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, uint*, int>)@this->LpVtbl[24])(@this, memid, invKind, pFuncIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFuncIndexOfMemId(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, ref uint pFuncIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pFuncIndexPtr = &pFuncIndex)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, InvokeKind, uint*, int>)@this->LpVtbl[24])(@this, memid, invKind, pFuncIndexPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVarIndexOfMemId(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint* pVarIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint*, int>)@this->LpVtbl[25])(@this, memid, pVarIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVarIndexOfMemId(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref uint pVarIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pVarIndexPtr = &pVarIndex)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint*, int>)@this->LpVtbl[25])(@this, memid, pVarIndexPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustData(this ComPtr<ITypeInfo2> thisVtbl, Guid* guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[26])(@this, guid, pVarVal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustData(this ComPtr<ITypeInfo2> thisVtbl, Guid* guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarValPtr = &pVarVal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[26])(@this, guid, pVarValPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustData(this ComPtr<ITypeInfo2> thisVtbl, ref Guid guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[26])(@this, guidPtr, pVarVal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCustData(this ComPtr<ITypeInfo2> thisVtbl, ref Guid guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetFuncCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Guid* guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[27])(@this, index, guid, pVarVal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFuncCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Guid* guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarValPtr = &pVarVal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[27])(@this, index, guid, pVarValPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFuncCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref Guid guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[27])(@this, index, guidPtr, pVarVal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFuncCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref Guid guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetParamCustData(this ComPtr<ITypeInfo2> thisVtbl, uint indexFunc, uint indexParam, Guid* guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[28])(@this, indexFunc, indexParam, guid, pVarVal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParamCustData(this ComPtr<ITypeInfo2> thisVtbl, uint indexFunc, uint indexParam, Guid* guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarValPtr = &pVarVal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[28])(@this, indexFunc, indexParam, guid, pVarValPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParamCustData(this ComPtr<ITypeInfo2> thisVtbl, uint indexFunc, uint indexParam, ref Guid guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[28])(@this, indexFunc, indexParam, guidPtr, pVarVal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetParamCustData(this ComPtr<ITypeInfo2> thisVtbl, uint indexFunc, uint indexParam, ref Guid guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetVarCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Guid* guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[29])(@this, index, guid, pVarVal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVarCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Guid* guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarValPtr = &pVarVal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[29])(@this, index, guid, pVarValPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVarCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref Guid guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[29])(@this, index, guidPtr, pVarVal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVarCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref Guid guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetImplTypeCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Guid* guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[30])(@this, index, guid, pVarVal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImplTypeCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Guid* guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarValPtr = &pVarVal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[30])(@this, index, guid, pVarValPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImplTypeCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref Guid guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[30])(@this, index, guidPtr, pVarVal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetImplTypeCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref Guid guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, char** pbstrHelpString, uint* pdwHelpStringContext, char** pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[31])(@this, memid, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, char** pbstrHelpString, uint* pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pbstrHelpStringDllPtr = &pbstrHelpStringDll)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[31])(@this, memid, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDllPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, char** pbstrHelpString, ref uint pdwHelpStringContext, char** pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwHelpStringContextPtr = &pdwHelpStringContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[31])(@this, memid, lcid, pbstrHelpString, pdwHelpStringContextPtr, pbstrHelpStringDll);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, char** pbstrHelpString, ref uint pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, ref char* pbstrHelpString, uint* pdwHelpStringContext, char** pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pbstrHelpStringPtr = &pbstrHelpString)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[31])(@this, memid, lcid, pbstrHelpStringPtr, pdwHelpStringContext, pbstrHelpStringDll);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, ref char* pbstrHelpString, uint* pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, ref char* pbstrHelpString, ref uint pdwHelpStringContext, char** pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, ref char* pbstrHelpString, ref uint pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetAllCustData(this ComPtr<ITypeInfo2> thisVtbl, CustomData* pCustData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, CustomData*, int>)@this->LpVtbl[32])(@this, pCustData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAllCustData(this ComPtr<ITypeInfo2> thisVtbl, ref CustomData pCustData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CustomData* pCustDataPtr = &pCustData)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, CustomData*, int>)@this->LpVtbl[32])(@this, pCustDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAllFuncCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, CustomData* pCustData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, CustomData*, int>)@this->LpVtbl[33])(@this, index, pCustData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAllFuncCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref CustomData pCustData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CustomData* pCustDataPtr = &pCustData)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, CustomData*, int>)@this->LpVtbl[33])(@this, index, pCustDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAllParamCustData(this ComPtr<ITypeInfo2> thisVtbl, uint indexFunc, uint indexParam, CustomData* pCustData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint, CustomData*, int>)@this->LpVtbl[34])(@this, indexFunc, indexParam, pCustData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAllParamCustData(this ComPtr<ITypeInfo2> thisVtbl, uint indexFunc, uint indexParam, ref CustomData pCustData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CustomData* pCustDataPtr = &pCustData)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, uint, CustomData*, int>)@this->LpVtbl[34])(@this, indexFunc, indexParam, pCustDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAllVarCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, CustomData* pCustData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, CustomData*, int>)@this->LpVtbl[35])(@this, index, pCustData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAllVarCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref CustomData pCustData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CustomData* pCustDataPtr = &pCustData)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, CustomData*, int>)@this->LpVtbl[35])(@this, index, pCustDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAllImplTypeCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, CustomData* pCustData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, CustomData*, int>)@this->LpVtbl[36])(@this, index, pCustData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAllImplTypeCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, ref CustomData pCustData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CustomData* pCustDataPtr = &pCustData)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo2*, uint, CustomData*, int>)@this->LpVtbl[36])(@this, index, pCustDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ITypeInfo2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeInfo2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeInfo2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeComp<TI0>(this ComPtr<ITypeInfo2> thisVtbl, ref ComPtr<TI0> ppTComp) where TI0 : unmanaged, IComVtbl<ITypeComp>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypeComp((ITypeComp**) ppTComp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo2> thisVtbl, int memid, string[] rgBstrNamesSa, uint cMaxNames, uint* pcNames)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rgBstrNames = (char**) SilkMarshal.StringArrayToPtr(rgBstrNamesSa);
        var ret = @this->GetNames(memid, rgBstrNames, cMaxNames, pcNames);
        SilkMarshal.CopyPtrToStringArray((nint) rgBstrNames, rgBstrNamesSa);
        SilkMarshal.Free((nint) rgBstrNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetNames(this ComPtr<ITypeInfo2> thisVtbl, int memid, string[] rgBstrNamesSa, uint cMaxNames, ref uint pcNames)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rgBstrNames = (char**) SilkMarshal.StringArrayToPtr(rgBstrNamesSa);
        var ret = @this->GetNames(memid, rgBstrNames, cMaxNames, ref pcNames);
        SilkMarshal.CopyPtrToStringArray((nint) rgBstrNames, rgBstrNamesSa);
        SilkMarshal.Free((nint) rgBstrNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** rgBstrNames, uint cMaxNames, Span<uint> pcNames)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNames(memid, rgBstrNames, cMaxNames, ref pcNames.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* rgBstrNames, uint cMaxNames, Span<uint> pcNames)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNames(memid, ref rgBstrNames, cMaxNames, ref pcNames.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRefTypeOfImplType(this ComPtr<ITypeInfo2> thisVtbl, uint index, Span<uint> pRefType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRefTypeOfImplType(index, ref pRefType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetImplTypeFlags(this ComPtr<ITypeInfo2> thisVtbl, uint index, Span<int> pImplTypeFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetImplTypeFlags(index, ref pImplTypeFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo2> thisVtbl, string[] rgszNamesSa, uint cNames, int* pMemId)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
        var ret = @this->GetIDsOfNames(rgszNames, cNames, pMemId);
        SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
        SilkMarshal.Free((nint) rgszNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetIDsOfNames(this ComPtr<ITypeInfo2> thisVtbl, string[] rgszNamesSa, uint cNames, ref int pMemId)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
        var ret = @this->GetIDsOfNames(rgszNames, cNames, ref pMemId);
        SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
        SilkMarshal.Free((nint) rgszNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo2> thisVtbl, char** rgszNames, uint cNames, Span<int> pMemId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIDsOfNames(rgszNames, cNames, ref pMemId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo2> thisVtbl, ref char* rgszNames, uint cNames, Span<int> pMemId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIDsOfNames(ref rgszNames, cNames, ref pMemId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, pVarResult, ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, pVarResult, ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo2> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, pVarResult, pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, pVarResult, ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, pVarResult, ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static int Invoke<T0>(this ComPtr<ITypeInfo2> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, string[] pBstrNameSa, string[] pBstrDocStringSa, uint* pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, string[] pBstrNameSa, string[] pBstrDocStringSa, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, string[] pBstrNameSa, string[] pBstrDocStringSa, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrName, char** pBstrDocString, Span<uint> pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, pBstrName, pBstrDocString, ref pdwHelpContext.GetPinnableReference(), pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, string[] pBstrNameSa, string[] pBstrDocStringSa, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrName, char** pBstrDocString, Span<uint> pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, pBstrName, pBstrDocString, ref pdwHelpContext.GetPinnableReference(), ref pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, string[] pBstrNameSa, ref char* pBstrDocString, uint* pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, string[] pBstrNameSa, ref char* pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
        var ret = @this->GetDocumentation(memid, pBstrName, ref pBstrDocString, pdwHelpContext, ref pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
        SilkMarshal.Free((nint) pBstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, string[] pBstrNameSa, ref char* pBstrDocString, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrName, ref char* pBstrDocString, Span<uint> pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, pBstrName, ref pBstrDocString, ref pdwHelpContext.GetPinnableReference(), pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, string[] pBstrNameSa, ref char* pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
        var ret = @this->GetDocumentation(memid, pBstrName, ref pBstrDocString, ref pdwHelpContext, ref pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
        SilkMarshal.Free((nint) pBstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, char** pBstrName, ref char* pBstrDocString, Span<uint> pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, pBstrName, ref pBstrDocString, ref pdwHelpContext.GetPinnableReference(), ref pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, string[] pBstrDocStringSa, uint* pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, string[] pBstrDocStringSa, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
        var ret = @this->GetDocumentation(memid, ref pBstrName, pBstrDocString, pdwHelpContext, ref pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
        SilkMarshal.Free((nint) pBstrDocString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, string[] pBstrDocStringSa, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, char** pBstrDocString, Span<uint> pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, ref pBstrName, pBstrDocString, ref pdwHelpContext.GetPinnableReference(), pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, string[] pBstrDocStringSa, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
        var ret = @this->GetDocumentation(memid, ref pBstrName, pBstrDocString, ref pdwHelpContext, ref pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
        SilkMarshal.Free((nint) pBstrDocString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, char** pBstrDocString, Span<uint> pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, ref pBstrName, pBstrDocString, ref pdwHelpContext.GetPinnableReference(), ref pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
        var ret = @this->GetDocumentation(memid, ref pBstrName, ref pBstrDocString, pdwHelpContext, pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
        SilkMarshal.Free((nint) pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
        var ret = @this->GetDocumentation(memid, ref pBstrName, ref pBstrDocString, ref pdwHelpContext, pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
        SilkMarshal.Free((nint) pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, Span<uint> pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, ref pBstrName, ref pBstrDocString, ref pdwHelpContext.GetPinnableReference(), pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo2> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, Span<uint> pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, ref pBstrName, ref pBstrDocString, ref pdwHelpContext.GetPinnableReference(), ref pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, string[] pBstrDllNameSa, string[] pBstrNameSa, ushort* pwOrdinal)
    {
        var @this = thisVtbl.Handle;
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
    public static int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, string[] pBstrDllNameSa, string[] pBstrNameSa, ref ushort pwOrdinal)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, char** pBstrDllName, char** pBstrName, Span<ushort> pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDllEntry(memid, invKind, pBstrDllName, pBstrName, ref pwOrdinal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, string[] pBstrDllNameSa, ref char* pBstrName, ushort* pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrDllName = (char**) SilkMarshal.StringArrayToPtr(pBstrDllNameSa);
        var ret = @this->GetDllEntry(memid, invKind, pBstrDllName, ref pBstrName, pwOrdinal);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDllName, pBstrDllNameSa);
        SilkMarshal.Free((nint) pBstrDllName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, string[] pBstrDllNameSa, ref char* pBstrName, ref ushort pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrDllName = (char**) SilkMarshal.StringArrayToPtr(pBstrDllNameSa);
        var ret = @this->GetDllEntry(memid, invKind, pBstrDllName, ref pBstrName, ref pwOrdinal);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDllName, pBstrDllNameSa);
        SilkMarshal.Free((nint) pBstrDllName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, char** pBstrDllName, ref char* pBstrName, Span<ushort> pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDllEntry(memid, invKind, pBstrDllName, ref pBstrName, ref pwOrdinal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, string[] pBstrNameSa, ushort* pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
        var ret = @this->GetDllEntry(memid, invKind, ref pBstrDllName, pBstrName, pwOrdinal);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
        SilkMarshal.Free((nint) pBstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, string[] pBstrNameSa, ref ushort pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
        var ret = @this->GetDllEntry(memid, invKind, ref pBstrDllName, pBstrName, ref pwOrdinal);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
        SilkMarshal.Free((nint) pBstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, char** pBstrName, Span<ushort> pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDllEntry(memid, invKind, ref pBstrDllName, pBstrName, ref pwOrdinal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, ref char* pBstrName, Span<ushort> pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDllEntry(memid, invKind, ref pBstrDllName, ref pBstrName, ref pwOrdinal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRefTypeInfo<TI0>(this ComPtr<ITypeInfo2> thisVtbl, uint hRefType, ref ComPtr<TI0> ppTInfo) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRefTypeInfo(hRefType, (ITypeInfo**) ppTInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateInstance<TI0, TI1>(this ComPtr<ITypeInfo2> thisVtbl, ComPtr<TI0> pUnkOuter, out ComPtr<TI1> ppvObj) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObj = default;
        return @this->CreateInstance((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvObj.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TI0>(this ComPtr<ITypeInfo2> thisVtbl, ComPtr<TI0> pUnkOuter, Guid* riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInstance((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Span<Guid> riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(pUnkOuter, ref riid.GetPinnableReference(), ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TI0>(this ComPtr<ITypeInfo2> thisVtbl, ComPtr<TI0> pUnkOuter, ref Guid riid, void** ppvObj) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInstance((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, ref riid, ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Span<Guid> riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(pUnkOuter, ref riid.GetPinnableReference(), ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TI0>(this ComPtr<ITypeInfo2> thisVtbl, ComPtr<TI0> pUnkOuter, ref Guid riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInstance((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, ref riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(ref pUnkOuter.GetPinnableReference(), riid, ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static int CreateInstance<TI0>(this ComPtr<ITypeInfo2> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, out ComPtr<TI0> ppvObj) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObj = default;
        return @this->CreateInstance(ref pUnkOuter, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObj.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(ref pUnkOuter.GetPinnableReference(), riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Span<Guid> riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(ref pUnkOuter.GetPinnableReference(), ref riid.GetPinnableReference(), ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo2> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Span<Guid> riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(ref pUnkOuter.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static int GetMops(this ComPtr<ITypeInfo2> thisVtbl, int memid, string[] pBstrMopsSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrMops = (char**) SilkMarshal.StringArrayToPtr(pBstrMopsSa);
        var ret = @this->GetMops(memid, pBstrMops);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrMops, pBstrMopsSa);
        SilkMarshal.Free((nint) pBstrMops);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib<TI0>(this ComPtr<ITypeInfo2> thisVtbl, ref ComPtr<TI0> ppTLib, uint* pIndex) where TI0 : unmanaged, IComVtbl<ITypeLib>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetContainingTypeLib((ITypeLib**) ppTLib.GetAddressOf(), pIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib(this ComPtr<ITypeInfo2> thisVtbl, ITypeLib** ppTLib, Span<uint> pIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContainingTypeLib(ppTLib, ref pIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetContainingTypeLib<TI0>(this ComPtr<ITypeInfo2> thisVtbl, ref ComPtr<TI0> ppTLib, ref uint pIndex) where TI0 : unmanaged, IComVtbl<ITypeLib>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetContainingTypeLib((ITypeLib**) ppTLib.GetAddressOf(), ref pIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib(this ComPtr<ITypeInfo2> thisVtbl, ref ITypeLib* ppTLib, Span<uint> pIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContainingTypeLib(ref ppTLib, ref pIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseTypeAttr(this ComPtr<ITypeInfo2> thisVtbl, Span<TypeAttr> pTypeAttr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseTypeAttr(ref pTypeAttr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFuncDesc(this ComPtr<ITypeInfo2> thisVtbl, Span<FuncDesc> pFuncDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseFuncDesc(ref pFuncDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseVarDesc(this ComPtr<ITypeInfo2> thisVtbl, Span<VarDesc> pVarDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseVarDesc(ref pVarDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeKind(this ComPtr<ITypeInfo2> thisVtbl, Span<TypeKind> pTypeKind)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypeKind(ref pTypeKind.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeFlags(this ComPtr<ITypeInfo2> thisVtbl, Span<uint> pTypeFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypeFlags(ref pTypeFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFuncIndexOfMemId(this ComPtr<ITypeInfo2> thisVtbl, int memid, InvokeKind invKind, Span<uint> pFuncIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFuncIndexOfMemId(memid, invKind, ref pFuncIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVarIndexOfMemId(this ComPtr<ITypeInfo2> thisVtbl, int memid, Span<uint> pVarIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVarIndexOfMemId(memid, ref pVarIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustData(this ComPtr<ITypeInfo2> thisVtbl, Guid* guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCustData(guid, ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustData(this ComPtr<ITypeInfo2> thisVtbl, Span<Guid> guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCustData(ref guid.GetPinnableReference(), pVarVal);
    }

    /// <summary>To be documented.</summary>
    public static int GetCustData(this ComPtr<ITypeInfo2> thisVtbl, Span<Guid> guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCustData(ref guid.GetPinnableReference(), ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFuncCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Guid* guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFuncCustData(index, guid, ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFuncCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Span<Guid> guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFuncCustData(index, ref guid.GetPinnableReference(), pVarVal);
    }

    /// <summary>To be documented.</summary>
    public static int GetFuncCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Span<Guid> guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFuncCustData(index, ref guid.GetPinnableReference(), ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParamCustData(this ComPtr<ITypeInfo2> thisVtbl, uint indexFunc, uint indexParam, Guid* guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParamCustData(indexFunc, indexParam, guid, ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParamCustData(this ComPtr<ITypeInfo2> thisVtbl, uint indexFunc, uint indexParam, Span<Guid> guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParamCustData(indexFunc, indexParam, ref guid.GetPinnableReference(), pVarVal);
    }

    /// <summary>To be documented.</summary>
    public static int GetParamCustData(this ComPtr<ITypeInfo2> thisVtbl, uint indexFunc, uint indexParam, Span<Guid> guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParamCustData(indexFunc, indexParam, ref guid.GetPinnableReference(), ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVarCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Guid* guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVarCustData(index, guid, ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVarCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Span<Guid> guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVarCustData(index, ref guid.GetPinnableReference(), pVarVal);
    }

    /// <summary>To be documented.</summary>
    public static int GetVarCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Span<Guid> guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVarCustData(index, ref guid.GetPinnableReference(), ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImplTypeCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Guid* guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetImplTypeCustData(index, guid, ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImplTypeCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Span<Guid> guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetImplTypeCustData(index, ref guid.GetPinnableReference(), pVarVal);
    }

    /// <summary>To be documented.</summary>
    public static int GetImplTypeCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Span<Guid> guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetImplTypeCustData(index, ref guid.GetPinnableReference(), ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, string[] pbstrHelpStringSa, uint* pdwHelpStringContext, string[] pbstrHelpStringDllSa)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, string[] pbstrHelpStringSa, uint* pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pbstrHelpString = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringSa);
        var ret = @this->GetDocumentation2(memid, lcid, pbstrHelpString, pdwHelpStringContext, ref pbstrHelpStringDll);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpString, pbstrHelpStringSa);
        SilkMarshal.Free((nint) pbstrHelpString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, string[] pbstrHelpStringSa, ref uint pdwHelpStringContext, string[] pbstrHelpStringDllSa)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, char** pbstrHelpString, Span<uint> pdwHelpStringContext, char** pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation2(memid, lcid, pbstrHelpString, ref pdwHelpStringContext.GetPinnableReference(), pbstrHelpStringDll);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, string[] pbstrHelpStringSa, ref uint pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pbstrHelpString = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringSa);
        var ret = @this->GetDocumentation2(memid, lcid, pbstrHelpString, ref pdwHelpStringContext, ref pbstrHelpStringDll);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpString, pbstrHelpStringSa);
        SilkMarshal.Free((nint) pbstrHelpString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, char** pbstrHelpString, Span<uint> pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation2(memid, lcid, pbstrHelpString, ref pdwHelpStringContext.GetPinnableReference(), ref pbstrHelpStringDll);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, ref char* pbstrHelpString, uint* pdwHelpStringContext, string[] pbstrHelpStringDllSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pbstrHelpStringDll = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringDllSa);
        var ret = @this->GetDocumentation2(memid, lcid, ref pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpStringDll, pbstrHelpStringDllSa);
        SilkMarshal.Free((nint) pbstrHelpStringDll);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, ref char* pbstrHelpString, ref uint pdwHelpStringContext, string[] pbstrHelpStringDllSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pbstrHelpStringDll = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringDllSa);
        var ret = @this->GetDocumentation2(memid, lcid, ref pbstrHelpString, ref pdwHelpStringContext, pbstrHelpStringDll);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpStringDll, pbstrHelpStringDllSa);
        SilkMarshal.Free((nint) pbstrHelpStringDll);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, ref char* pbstrHelpString, Span<uint> pdwHelpStringContext, char** pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation2(memid, lcid, ref pbstrHelpString, ref pdwHelpStringContext.GetPinnableReference(), pbstrHelpStringDll);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeInfo2> thisVtbl, int memid, uint lcid, ref char* pbstrHelpString, Span<uint> pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation2(memid, lcid, ref pbstrHelpString, ref pdwHelpStringContext.GetPinnableReference(), ref pbstrHelpStringDll);
    }

    /// <summary>To be documented.</summary>
    public static int GetAllCustData(this ComPtr<ITypeInfo2> thisVtbl, Span<CustomData> pCustData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAllCustData(ref pCustData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAllFuncCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Span<CustomData> pCustData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAllFuncCustData(index, ref pCustData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAllParamCustData(this ComPtr<ITypeInfo2> thisVtbl, uint indexFunc, uint indexParam, Span<CustomData> pCustData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAllParamCustData(indexFunc, indexParam, ref pCustData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAllVarCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Span<CustomData> pCustData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAllVarCustData(index, ref pCustData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAllImplTypeCustData(this ComPtr<ITypeInfo2> thisVtbl, uint index, Span<CustomData> pCustData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAllImplTypeCustData(index, ref pCustData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ITypeInfo2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateInstance<TI0, TI1>(this ComPtr<ITypeInfo2> thisVtbl, ComPtr<TI0> pUnkOuter) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateInstance(pUnkOuter, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateInstance<TI0>(this ComPtr<ITypeInfo2> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateInstance(ref pUnkOuter, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
