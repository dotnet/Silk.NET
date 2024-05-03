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

public unsafe static class PrintDocumentPackageStatusEventVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfoCount(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, uint* pctinfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint*, int>)@this->LpVtbl[3])(@this, pctinfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeInfoCount(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, ref uint pctinfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pctinfoPtr = &pctinfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint*, int>)@this->LpVtbl[3])(@this, pctinfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfo(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, uint iTInfo, uint lcid, ITypeInfo** ppTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint, uint, ITypeInfo**, int>)@this->LpVtbl[4])(@this, iTInfo, lcid, ppTInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfo(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, uint iTInfo, uint lcid, ref ITypeInfo* ppTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint, uint, ITypeInfo**, int>)@this->LpVtbl[4])(@this, iTInfo, lcid, ppTInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Guid* riid, char** rgszNames, uint cNames, uint lcid, int* rgDispId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riid, rgszNames, cNames, lcid, rgDispId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Guid* riid, char** rgszNames, uint cNames, uint lcid, ref int rgDispId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* rgDispIdPtr = &rgDispId)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riid, rgszNames, cNames, lcid, rgDispIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Guid* riid, ref char* rgszNames, uint cNames, uint lcid, int* rgDispId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** rgszNamesPtr = &rgszNames)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riid, rgszNamesPtr, cNames, lcid, rgDispId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Guid* riid, ref char* rgszNames, uint cNames, uint lcid, ref int rgDispId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** rgszNamesPtr = &rgszNames)
        {
            fixed (int* rgDispIdPtr = &rgDispId)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riid, rgszNamesPtr, cNames, lcid, rgDispIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, ref Guid riid, char** rgszNames, uint cNames, uint lcid, int* rgDispId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riidPtr, rgszNames, cNames, lcid, rgDispId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, ref Guid riid, char** rgszNames, uint cNames, uint lcid, ref int rgDispId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (int* rgDispIdPtr = &rgDispId)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riidPtr, rgszNames, cNames, lcid, rgDispIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, ref Guid riid, ref char* rgszNames, uint cNames, uint lcid, int* rgDispId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (char** rgszNamesPtr = &rgszNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riidPtr, rgszNamesPtr, cNames, lcid, rgDispId);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, ref Guid riid, ref char* rgszNames, uint cNames, uint lcid, ref int rgDispId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (char** rgszNamesPtr = &rgszNames)
            {
                fixed (int* rgDispIdPtr = &rgDispId)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riidPtr, rgszNamesPtr, cNames, lcid, rgDispIdPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puArgErrPtr = &puArgErr)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
        {
            fixed (uint* puArgErrPtr = &puArgErr)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarResultPtr = &pVarResult)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarResultPtr = &pVarResult)
        {
            fixed (uint* puArgErrPtr = &puArgErr)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarResultPtr = &pVarResult)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarResultPtr = &pVarResult)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            fixed (uint* puArgErrPtr = &puArgErr)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DispatchParams* pDispParamsPtr = &pDispParams)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
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
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (uint* puArgErrPtr = &puArgErr)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErrPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErrPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        fixed (uint* puArgErrPtr = &puArgErr)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PackageStatusUpdated(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, MIDLMIDLItfDocumentTarget000000020001* packageStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, MIDLMIDLItfDocumentTarget000000020001*, int>)@this->LpVtbl[7])(@this, packageStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PackageStatusUpdated(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, ref MIDLMIDLItfDocumentTarget000000020001 packageStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MIDLMIDLItfDocumentTarget000000020001* packageStatusPtr = &packageStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, MIDLMIDLItfDocumentTarget000000020001*, int>)@this->LpVtbl[7])(@this, packageStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeInfoCount(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Span<uint> pctinfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypeInfoCount(ref pctinfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeInfo<TI0>(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, uint iTInfo, uint lcid, ref ComPtr<TI0> ppTInfo) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypeInfo(iTInfo, lcid, (ITypeInfo**) ppTInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Guid* riid, string[] rgszNamesSa, uint cNames, uint lcid, int* rgDispId)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
        var ret = @this->GetIDsOfNames(riid, rgszNames, cNames, lcid, rgDispId);
        SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
        SilkMarshal.Free((nint) rgszNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Guid* riid, string[] rgszNamesSa, uint cNames, uint lcid, ref int rgDispId)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
        var ret = @this->GetIDsOfNames(riid, rgszNames, cNames, lcid, ref rgDispId);
        SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
        SilkMarshal.Free((nint) rgszNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Guid* riid, char** rgszNames, uint cNames, uint lcid, Span<int> rgDispId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIDsOfNames(riid, rgszNames, cNames, lcid, ref rgDispId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Guid* riid, ref char* rgszNames, uint cNames, uint lcid, Span<int> rgDispId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIDsOfNames(riid, ref rgszNames, cNames, lcid, ref rgDispId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, ref Guid riid, string[] rgszNamesSa, uint cNames, uint lcid, int* rgDispId)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
        var ret = @this->GetIDsOfNames(ref riid, rgszNames, cNames, lcid, rgDispId);
        SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
        SilkMarshal.Free((nint) rgszNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Span<Guid> riid, char** rgszNames, uint cNames, uint lcid, int* rgDispId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIDsOfNames(ref riid.GetPinnableReference(), rgszNames, cNames, lcid, rgDispId);
    }

    /// <summary>To be documented.</summary>
    public static int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, ref Guid riid, string[] rgszNamesSa, uint cNames, uint lcid, ref int rgDispId)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
        var ret = @this->GetIDsOfNames(ref riid, rgszNames, cNames, lcid, ref rgDispId);
        SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
        SilkMarshal.Free((nint) rgszNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Span<Guid> riid, char** rgszNames, uint cNames, uint lcid, Span<int> rgDispId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIDsOfNames(ref riid.GetPinnableReference(), rgszNames, cNames, lcid, ref rgDispId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Span<Guid> riid, ref char* rgszNames, uint cNames, uint lcid, int* rgDispId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIDsOfNames(ref riid.GetPinnableReference(), ref rgszNames, cNames, lcid, rgDispId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Span<Guid> riid, ref char* rgszNames, uint cNames, uint lcid, Span<int> rgDispId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIDsOfNames(ref riid.GetPinnableReference(), ref rgszNames, cNames, lcid, ref rgDispId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, riid, lcid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, pDispParams, pVarResult, pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, pDispParams, pVarResult, ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, pDispParams, pVarResult, ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, pDispParams, ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Variant* pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, ref pDispParams.GetPinnableReference(), pVarResult, ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), pExcepInfo, puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, ExceptionInfo* pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), pExcepInfo, ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), puArgErr);
    }

    /// <summary>To be documented.</summary>
    public static int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Span<Guid> riid, uint lcid, ushort wFlags, Span<DispatchParams> pDispParams, Span<Variant> pVarResult, Span<ExceptionInfo> pExcepInfo, Span<uint> puArgErr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(dispIdMember, ref riid.GetPinnableReference(), lcid, wFlags, ref pDispParams.GetPinnableReference(), ref pVarResult.GetPinnableReference(), ref pExcepInfo.GetPinnableReference(), ref puArgErr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PackageStatusUpdated(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Span<MIDLMIDLItfDocumentTarget000000020001> packageStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PackageStatusUpdated(ref packageStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
