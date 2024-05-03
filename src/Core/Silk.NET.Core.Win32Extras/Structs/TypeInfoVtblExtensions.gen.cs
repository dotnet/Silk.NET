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

public unsafe static class TypeInfoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeInfo> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeInfo> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeInfo> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeInfo> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ITypeInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ITypeInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeAttr(this ComPtr<ITypeInfo> thisVtbl, TypeAttr** ppTypeAttr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, TypeAttr**, int>)@this->LpVtbl[3])(@this, ppTypeAttr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeAttr(this ComPtr<ITypeInfo> thisVtbl, ref TypeAttr* ppTypeAttr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TypeAttr** ppTypeAttrPtr = &ppTypeAttr)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, TypeAttr**, int>)@this->LpVtbl[3])(@this, ppTypeAttrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeComp(this ComPtr<ITypeInfo> thisVtbl, ITypeComp** ppTComp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, ITypeComp**, int>)@this->LpVtbl[4])(@this, ppTComp);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeComp(this ComPtr<ITypeInfo> thisVtbl, ref ITypeComp* ppTComp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeComp** ppTCompPtr = &ppTComp)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, ITypeComp**, int>)@this->LpVtbl[4])(@this, ppTCompPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFuncDesc(this ComPtr<ITypeInfo> thisVtbl, uint index, FuncDesc** ppFuncDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, uint, FuncDesc**, int>)@this->LpVtbl[5])(@this, index, ppFuncDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFuncDesc(this ComPtr<ITypeInfo> thisVtbl, uint index, ref FuncDesc* ppFuncDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FuncDesc** ppFuncDescPtr = &ppFuncDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, uint, FuncDesc**, int>)@this->LpVtbl[5])(@this, index, ppFuncDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVarDesc(this ComPtr<ITypeInfo> thisVtbl, uint index, VarDesc** ppVarDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, uint, VarDesc**, int>)@this->LpVtbl[6])(@this, index, ppVarDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVarDesc(this ComPtr<ITypeInfo> thisVtbl, uint index, ref VarDesc* ppVarDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VarDesc** ppVarDescPtr = &ppVarDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, uint, VarDesc**, int>)@this->LpVtbl[6])(@this, index, ppVarDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo> thisVtbl, int memid, char** rgBstrNames, uint cMaxNames, uint* pcNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, uint, uint*, int>)@this->LpVtbl[7])(@this, memid, rgBstrNames, cMaxNames, pcNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo> thisVtbl, int memid, char** rgBstrNames, uint cMaxNames, ref uint pcNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcNamesPtr = &pcNames)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, uint, uint*, int>)@this->LpVtbl[7])(@this, memid, rgBstrNames, cMaxNames, pcNamesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* rgBstrNames, uint cMaxNames, uint* pcNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** rgBstrNamesPtr = &rgBstrNames)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, uint, uint*, int>)@this->LpVtbl[7])(@this, memid, rgBstrNamesPtr, cMaxNames, pcNames);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* rgBstrNames, uint cMaxNames, ref uint pcNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** rgBstrNamesPtr = &rgBstrNames)
        {
            fixed (uint* pcNamesPtr = &pcNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, uint, uint*, int>)@this->LpVtbl[7])(@this, memid, rgBstrNamesPtr, cMaxNames, pcNamesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRefTypeOfImplType(this ComPtr<ITypeInfo> thisVtbl, uint index, uint* pRefType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, uint, uint*, int>)@this->LpVtbl[8])(@this, index, pRefType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRefTypeOfImplType(this ComPtr<ITypeInfo> thisVtbl, uint index, ref uint pRefType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pRefTypePtr = &pRefType)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, uint, uint*, int>)@this->LpVtbl[8])(@this, index, pRefTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImplTypeFlags(this ComPtr<ITypeInfo> thisVtbl, uint index, int* pImplTypeFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, uint, int*, int>)@this->LpVtbl[9])(@this, index, pImplTypeFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetImplTypeFlags(this ComPtr<ITypeInfo> thisVtbl, uint index, ref int pImplTypeFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pImplTypeFlagsPtr = &pImplTypeFlags)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, uint, int*, int>)@this->LpVtbl[9])(@this, index, pImplTypeFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo> thisVtbl, char** rgszNames, uint cNames, int* pMemId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, char**, uint, int*, int>)@this->LpVtbl[10])(@this, rgszNames, cNames, pMemId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo> thisVtbl, char** rgszNames, uint cNames, ref int pMemId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pMemIdPtr = &pMemId)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, char**, uint, int*, int>)@this->LpVtbl[10])(@this, rgszNames, cNames, pMemIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo> thisVtbl, ref char* rgszNames, uint cNames, int* pMemId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** rgszNamesPtr = &rgszNames)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, char**, uint, int*, int>)@this->LpVtbl[10])(@this, rgszNamesPtr, cNames, pMemId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo> thisVtbl, ref char* rgszNames, uint cNames, ref int pMemId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** rgszNamesPtr = &rgszNames)
        {
            fixed (int* pMemIdPtr = &pMemId)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, char**, uint, int*, int>)@this->LpVtbl[10])(@this, rgszNamesPtr, cNames, pMemIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puArgErrPtr = &puArgErr)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
        {
            fixed (uint* puArgErrPtr = &puArgErr)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarResultPtr = &pVarResult)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarResultPtr = &pVarResult)
        {
            fixed (uint* puArgErrPtr = &puArgErr)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarResultPtr = &pVarResult)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarResultPtr = &pVarResult)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            fixed (uint* puArgErrPtr = &puArgErr)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
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
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstance, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvInstancePtr = &pvInstance)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvInstancePtr = &pvInstance)
        {
            fixed (uint* puArgErrPtr = &puArgErr)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvInstancePtr = &pvInstance)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvInstancePtr = &pvInstance)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvInstancePtr = &pvInstance)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvInstancePtr = &pvInstance)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvInstancePtr = &pvInstance)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr) where T0 : unmanaged
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
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvInstancePtr = &pvInstance)
        {
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvInstancePtr = &pvInstance)
        {
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvInstancePtr = &pvInstance)
        {
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr) where T0 : unmanaged
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
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErrPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvInstancePtr = &pvInstance)
        {
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr) where T0 : unmanaged
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
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErrPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr) where T0 : unmanaged
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
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, ref T0 pvInstance, int memid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr) where T0 : unmanaged
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
                            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, void*, int, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[11])(@this, pvInstancePtr, memid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrName, char** pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocString, pdwHelpContextPtr, pBstrHelpFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrName, char** pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
        {
            fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocString, pdwHelpContextPtr, pBstrHelpFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDocStringPtr = &pBstrDocString)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDocStringPtr = &pBstrDocString)
        {
            fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDocStringPtr = &pBstrDocString)
        {
            fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocStringPtr, pdwHelpContextPtr, pBstrHelpFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDocStringPtr = &pBstrDocString)
        {
            fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
            {
                fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrName, pBstrDocStringPtr, pdwHelpContextPtr, pBstrHelpFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, char** pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocString, pdwHelpContext, pBstrHelpFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, char** pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocString, pdwHelpContextPtr, pBstrHelpFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, char** pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
            {
                fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocString, pdwHelpContextPtr, pBstrHelpFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (char** pBstrDocStringPtr = &pBstrDocString)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (char** pBstrDocStringPtr = &pBstrDocString)
            {
                fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (char** pBstrDocStringPtr = &pBstrDocString)
            {
                fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocStringPtr, pdwHelpContextPtr, pBstrHelpFile);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
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
                        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[12])(@this, memid, pBstrNamePtr, pBstrDocStringPtr, pdwHelpContextPtr, pBstrHelpFilePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, char** pBstrDllName, char** pBstrName, ushort* pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, char** pBstrDllName, char** pBstrName, ref ushort pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* pwOrdinalPtr = &pwOrdinal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllName, pBstrName, pwOrdinalPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, char** pBstrDllName, ref char* pBstrName, ushort* pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllName, pBstrNamePtr, pwOrdinal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, char** pBstrDllName, ref char* pBstrName, ref ushort pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (ushort* pwOrdinalPtr = &pwOrdinal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllName, pBstrNamePtr, pwOrdinalPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, char** pBstrName, ushort* pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDllNamePtr = &pBstrDllName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllNamePtr, pBstrName, pwOrdinal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, char** pBstrName, ref ushort pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDllNamePtr = &pBstrDllName)
        {
            fixed (ushort* pwOrdinalPtr = &pwOrdinal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllNamePtr, pBstrName, pwOrdinalPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, ref char* pBstrName, ushort* pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDllNamePtr = &pBstrDllName)
        {
            fixed (char** pBstrNamePtr = &pBstrName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllNamePtr, pBstrNamePtr, pwOrdinal);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, ref char* pBstrName, ref ushort pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDllNamePtr = &pBstrDllName)
        {
            fixed (char** pBstrNamePtr = &pBstrName)
            {
                fixed (ushort* pwOrdinalPtr = &pwOrdinal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, InvokeKind, char**, char**, ushort*, int>)@this->LpVtbl[13])(@this, memid, invKind, pBstrDllNamePtr, pBstrNamePtr, pwOrdinalPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRefTypeInfo(this ComPtr<ITypeInfo> thisVtbl, uint hRefType, ITypeInfo** ppTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, uint, ITypeInfo**, int>)@this->LpVtbl[14])(@this, hRefType, ppTInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRefTypeInfo(this ComPtr<ITypeInfo> thisVtbl, uint hRefType, ref ITypeInfo* ppTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, uint, ITypeInfo**, int>)@this->LpVtbl[14])(@this, hRefType, ppTInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddressOfMember(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, InvokeKind, void**, int>)@this->LpVtbl[15])(@this, memid, invKind, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddressOfMember(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, InvokeKind, void**, int>)@this->LpVtbl[15])(@this, memid, invKind, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuter, riid, ppvObj);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjPtr = &ppvObj)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuter, riid, ppvObjPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuter, riidPtr, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuter, riidPtr, ppvObjPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuterPtr, riid, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuterPtr, riid, ppvObjPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuterPtr, riidPtr, ppvObj);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[16])(@this, pUnkOuterPtr, riidPtr, ppvObjPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMops(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrMops)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, int>)@this->LpVtbl[17])(@this, memid, pBstrMops);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMops(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrMops)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrMopsPtr = &pBstrMops)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, int, char**, int>)@this->LpVtbl[17])(@this, memid, pBstrMopsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib(this ComPtr<ITypeInfo> thisVtbl, ITypeLib** ppTLib, uint* pIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, ITypeLib**, uint*, int>)@this->LpVtbl[18])(@this, ppTLib, pIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib(this ComPtr<ITypeInfo> thisVtbl, ITypeLib** ppTLib, ref uint pIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pIndexPtr = &pIndex)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, ITypeLib**, uint*, int>)@this->LpVtbl[18])(@this, ppTLib, pIndexPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib(this ComPtr<ITypeInfo> thisVtbl, ref ITypeLib* ppTLib, uint* pIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeLib** ppTLibPtr = &ppTLib)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, ITypeLib**, uint*, int>)@this->LpVtbl[18])(@this, ppTLibPtr, pIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib(this ComPtr<ITypeInfo> thisVtbl, ref ITypeLib* ppTLib, ref uint pIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeLib** ppTLibPtr = &ppTLib)
        {
            fixed (uint* pIndexPtr = &pIndex)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeInfo*, ITypeLib**, uint*, int>)@this->LpVtbl[18])(@this, ppTLibPtr, pIndexPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseTypeAttr(this ComPtr<ITypeInfo> thisVtbl, TypeAttr* pTypeAttr)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ITypeInfo*, TypeAttr*, void>)@this->LpVtbl[19])(@this, pTypeAttr);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseTypeAttr(this ComPtr<ITypeInfo> thisVtbl, ref TypeAttr pTypeAttr)
    {
        var @this = thisVtbl.Handle;
        fixed (TypeAttr* pTypeAttrPtr = &pTypeAttr)
        {
            ((delegate* unmanaged[Cdecl]<ITypeInfo*, TypeAttr*, void>)@this->LpVtbl[19])(@this, pTypeAttrPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseFuncDesc(this ComPtr<ITypeInfo> thisVtbl, FuncDesc* pFuncDesc)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ITypeInfo*, FuncDesc*, void>)@this->LpVtbl[20])(@this, pFuncDesc);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFuncDesc(this ComPtr<ITypeInfo> thisVtbl, ref FuncDesc pFuncDesc)
    {
        var @this = thisVtbl.Handle;
        fixed (FuncDesc* pFuncDescPtr = &pFuncDesc)
        {
            ((delegate* unmanaged[Cdecl]<ITypeInfo*, FuncDesc*, void>)@this->LpVtbl[20])(@this, pFuncDescPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseVarDesc(this ComPtr<ITypeInfo> thisVtbl, VarDesc* pVarDesc)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ITypeInfo*, VarDesc*, void>)@this->LpVtbl[21])(@this, pVarDesc);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseVarDesc(this ComPtr<ITypeInfo> thisVtbl, ref VarDesc pVarDesc)
    {
        var @this = thisVtbl.Handle;
        fixed (VarDesc* pVarDescPtr = &pVarDesc)
        {
            ((delegate* unmanaged[Cdecl]<ITypeInfo*, VarDesc*, void>)@this->LpVtbl[21])(@this, pVarDescPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ITypeInfo> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeInfo> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeInfo> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeComp<TI0>(this ComPtr<ITypeInfo> thisVtbl, ref ComPtr<TI0> ppTComp) where TI0 : unmanaged, IComVtbl<ITypeComp>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypeComp((ITypeComp**) ppTComp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo> thisVtbl, int memid, string[] rgBstrNamesSa, uint cMaxNames, uint* pcNames)
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
    public static int GetNames(this ComPtr<ITypeInfo> thisVtbl, int memid, string[] rgBstrNamesSa, uint cMaxNames, ref uint pcNames)
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
    public static unsafe int GetNames(this ComPtr<ITypeInfo> thisVtbl, int memid, char** rgBstrNames, uint cMaxNames, Span<uint> pcNames)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNames(memid, rgBstrNames, cMaxNames, ref pcNames.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNames(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* rgBstrNames, uint cMaxNames, Span<uint> pcNames)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNames(memid, ref rgBstrNames, cMaxNames, ref pcNames.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRefTypeOfImplType(this ComPtr<ITypeInfo> thisVtbl, uint index, Span<uint> pRefType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRefTypeOfImplType(index, ref pRefType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetImplTypeFlags(this ComPtr<ITypeInfo> thisVtbl, uint index, Span<int> pImplTypeFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetImplTypeFlags(index, ref pImplTypeFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo> thisVtbl, string[] rgszNamesSa, uint cNames, int* pMemId)
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
    public static int GetIDsOfNames(this ComPtr<ITypeInfo> thisVtbl, string[] rgszNamesSa, uint cNames, ref int pMemId)
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
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo> thisVtbl, char** rgszNames, uint cNames, Span<int> pMemId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIDsOfNames(rgszNames, cNames, ref pMemId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<ITypeInfo> thisVtbl, ref char* rgszNames, uint cNames, Span<int> pMemId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIDsOfNames(ref rgszNames, cNames, ref pMemId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, pVarResult, ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, pVarResult, ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<ITypeInfo> thisVtbl, void* pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(pvInstance, memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, pVarResult, pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, pVarResult, ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, pVarResult, ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static int Invoke<T0>(this ComPtr<ITypeInfo> thisVtbl, Span<T0> pvInstance, int memid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref pvInstance.GetPinnableReference(), memid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, string[] pBstrNameSa, string[] pBstrDocStringSa, uint* pdwHelpContext, string[] pBstrHelpFileSa)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, string[] pBstrNameSa, string[] pBstrDocStringSa, uint* pdwHelpContext, ref char* pBstrHelpFile)
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
    public static int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, string[] pBstrNameSa, string[] pBstrDocStringSa, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrName, char** pBstrDocString, Span<uint> pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, pBstrName, pBstrDocString, ref pdwHelpContext.GetPinnableReference(), pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, string[] pBstrNameSa, string[] pBstrDocStringSa, ref uint pdwHelpContext, ref char* pBstrHelpFile)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrName, char** pBstrDocString, Span<uint> pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, pBstrName, pBstrDocString, ref pdwHelpContext.GetPinnableReference(), ref pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, string[] pBstrNameSa, ref char* pBstrDocString, uint* pdwHelpContext, string[] pBstrHelpFileSa)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, string[] pBstrNameSa, ref char* pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, string[] pBstrNameSa, ref char* pBstrDocString, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrName, ref char* pBstrDocString, Span<uint> pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, pBstrName, ref pBstrDocString, ref pdwHelpContext.GetPinnableReference(), pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, string[] pBstrNameSa, ref char* pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, char** pBstrName, ref char* pBstrDocString, Span<uint> pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, pBstrName, ref pBstrDocString, ref pdwHelpContext.GetPinnableReference(), ref pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, string[] pBstrDocStringSa, uint* pdwHelpContext, string[] pBstrHelpFileSa)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, string[] pBstrDocStringSa, uint* pdwHelpContext, ref char* pBstrHelpFile)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, string[] pBstrDocStringSa, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, char** pBstrDocString, Span<uint> pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, ref pBstrName, pBstrDocString, ref pdwHelpContext.GetPinnableReference(), pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, string[] pBstrDocStringSa, ref uint pdwHelpContext, ref char* pBstrHelpFile)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, char** pBstrDocString, Span<uint> pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, ref pBstrName, pBstrDocString, ref pdwHelpContext.GetPinnableReference(), ref pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, string[] pBstrHelpFileSa)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
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
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, Span<uint> pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, ref pBstrName, ref pBstrDocString, ref pdwHelpContext.GetPinnableReference(), pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeInfo> thisVtbl, int memid, ref char* pBstrName, ref char* pBstrDocString, Span<uint> pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(memid, ref pBstrName, ref pBstrDocString, ref pdwHelpContext.GetPinnableReference(), ref pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, string[] pBstrDllNameSa, string[] pBstrNameSa, ushort* pwOrdinal)
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
    public static int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, string[] pBstrDllNameSa, string[] pBstrNameSa, ref ushort pwOrdinal)
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
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, char** pBstrDllName, char** pBstrName, Span<ushort> pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDllEntry(memid, invKind, pBstrDllName, pBstrName, ref pwOrdinal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, string[] pBstrDllNameSa, ref char* pBstrName, ushort* pwOrdinal)
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
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, string[] pBstrDllNameSa, ref char* pBstrName, ref ushort pwOrdinal)
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
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, char** pBstrDllName, ref char* pBstrName, Span<ushort> pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDllEntry(memid, invKind, pBstrDllName, ref pBstrName, ref pwOrdinal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, string[] pBstrNameSa, ushort* pwOrdinal)
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
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, string[] pBstrNameSa, ref ushort pwOrdinal)
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
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, char** pBstrName, Span<ushort> pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDllEntry(memid, invKind, ref pBstrDllName, pBstrName, ref pwOrdinal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDllEntry(this ComPtr<ITypeInfo> thisVtbl, int memid, InvokeKind invKind, ref char* pBstrDllName, ref char* pBstrName, Span<ushort> pwOrdinal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDllEntry(memid, invKind, ref pBstrDllName, ref pBstrName, ref pwOrdinal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRefTypeInfo<TI0>(this ComPtr<ITypeInfo> thisVtbl, uint hRefType, ref ComPtr<TI0> ppTInfo) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRefTypeInfo(hRefType, (ITypeInfo**) ppTInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateInstance<TI0, TI1>(this ComPtr<ITypeInfo> thisVtbl, ComPtr<TI0> pUnkOuter, out ComPtr<TI1> ppvObj) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObj = default;
        return @this->CreateInstance((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvObj.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TI0>(this ComPtr<ITypeInfo> thisVtbl, ComPtr<TI0> pUnkOuter, Guid* riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInstance((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Span<Guid> riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(pUnkOuter, ref riid.GetPinnableReference(), ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TI0>(this ComPtr<ITypeInfo> thisVtbl, ComPtr<TI0> pUnkOuter, ref Guid riid, void** ppvObj) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInstance((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, ref riid, ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Span<Guid> riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(pUnkOuter, ref riid.GetPinnableReference(), ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TI0>(this ComPtr<ITypeInfo> thisVtbl, ComPtr<TI0> pUnkOuter, ref Guid riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInstance((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, ref riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(ref pUnkOuter.GetPinnableReference(), riid, ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static int CreateInstance<TI0>(this ComPtr<ITypeInfo> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, out ComPtr<TI0> ppvObj) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObj = default;
        return @this->CreateInstance(ref pUnkOuter, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObj.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(ref pUnkOuter.GetPinnableReference(), riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Span<Guid> riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(ref pUnkOuter.GetPinnableReference(), ref riid.GetPinnableReference(), ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<ITypeInfo> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Span<Guid> riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(ref pUnkOuter.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static int GetMops(this ComPtr<ITypeInfo> thisVtbl, int memid, string[] pBstrMopsSa)
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
    public static unsafe int GetContainingTypeLib<TI0>(this ComPtr<ITypeInfo> thisVtbl, ref ComPtr<TI0> ppTLib, uint* pIndex) where TI0 : unmanaged, IComVtbl<ITypeLib>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetContainingTypeLib((ITypeLib**) ppTLib.GetAddressOf(), pIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib(this ComPtr<ITypeInfo> thisVtbl, ITypeLib** ppTLib, Span<uint> pIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContainingTypeLib(ppTLib, ref pIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetContainingTypeLib<TI0>(this ComPtr<ITypeInfo> thisVtbl, ref ComPtr<TI0> ppTLib, ref uint pIndex) where TI0 : unmanaged, IComVtbl<ITypeLib>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetContainingTypeLib((ITypeLib**) ppTLib.GetAddressOf(), ref pIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingTypeLib(this ComPtr<ITypeInfo> thisVtbl, ref ITypeLib* ppTLib, Span<uint> pIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContainingTypeLib(ref ppTLib, ref pIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseTypeAttr(this ComPtr<ITypeInfo> thisVtbl, Span<TypeAttr> pTypeAttr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseTypeAttr(ref pTypeAttr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFuncDesc(this ComPtr<ITypeInfo> thisVtbl, Span<FuncDesc> pFuncDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseFuncDesc(ref pFuncDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseVarDesc(this ComPtr<ITypeInfo> thisVtbl, Span<VarDesc> pVarDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseVarDesc(ref pVarDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ITypeInfo> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateInstance<TI0, TI1>(this ComPtr<ITypeInfo> thisVtbl, ComPtr<TI0> pUnkOuter) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateInstance(pUnkOuter, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateInstance<TI0>(this ComPtr<ITypeInfo> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateInstance(ref pUnkOuter, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
