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

public unsafe static class CreateTypeInfo2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICreateTypeInfo2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICreateTypeInfo2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICreateTypeInfo2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICreateTypeInfo2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ICreateTypeInfo2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ICreateTypeInfo2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetGuid(this ComPtr<ICreateTypeInfo2> thisVtbl, Guid* guid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, int>)@this->LpVtbl[3])(@this, guid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGuid(this ComPtr<ICreateTypeInfo2> thisVtbl, ref Guid guid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, int>)@this->LpVtbl[3])(@this, guidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTypeFlags(this ComPtr<ICreateTypeInfo2> thisVtbl, uint uTypeFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int>)@this->LpVtbl[4])(@this, uTypeFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDocString(this ComPtr<ICreateTypeInfo2> thisVtbl, char* pStrDoc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, char*, int>)@this->LpVtbl[5])(@this, pStrDoc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDocString(this ComPtr<ICreateTypeInfo2> thisVtbl, ref char pStrDoc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStrDocPtr = &pStrDoc)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, char*, int>)@this->LpVtbl[5])(@this, pStrDocPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDocString(this ComPtr<ICreateTypeInfo2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrDoc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStrDocPtr = (byte*) SilkMarshal.StringToPtr(pStrDoc, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, byte*, int>)@this->LpVtbl[5])(@this, pStrDocPtr);
        SilkMarshal.Free((nint)pStrDocPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetHelpContext(this ComPtr<ICreateTypeInfo2> thisVtbl, uint dwHelpContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int>)@this->LpVtbl[6])(@this, dwHelpContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVersion(this ComPtr<ICreateTypeInfo2> thisVtbl, ushort wMajorVerNum, ushort wMinorVerNum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, ushort, ushort, int>)@this->LpVtbl[7])(@this, wMajorVerNum, wMinorVerNum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddRefTypeInfo(this ComPtr<ICreateTypeInfo2> thisVtbl, ITypeInfo* pTInfo, uint* phRefType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, ITypeInfo*, uint*, int>)@this->LpVtbl[8])(@this, pTInfo, phRefType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddRefTypeInfo(this ComPtr<ICreateTypeInfo2> thisVtbl, ITypeInfo* pTInfo, ref uint phRefType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* phRefTypePtr = &phRefType)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, ITypeInfo*, uint*, int>)@this->LpVtbl[8])(@this, pTInfo, phRefTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddRefTypeInfo(this ComPtr<ICreateTypeInfo2> thisVtbl, ref ITypeInfo pTInfo, uint* phRefType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTInfoPtr = &pTInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, ITypeInfo*, uint*, int>)@this->LpVtbl[8])(@this, pTInfoPtr, phRefType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddRefTypeInfo(this ComPtr<ICreateTypeInfo2> thisVtbl, ref ITypeInfo pTInfo, ref uint phRefType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTInfoPtr = &pTInfo)
        {
            fixed (uint* phRefTypePtr = &phRefType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, ITypeInfo*, uint*, int>)@this->LpVtbl[8])(@this, pTInfoPtr, phRefTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFuncDesc(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, FuncDesc* pFuncDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, FuncDesc*, int>)@this->LpVtbl[9])(@this, index, pFuncDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddFuncDesc(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref FuncDesc pFuncDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FuncDesc* pFuncDescPtr = &pFuncDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, FuncDesc*, int>)@this->LpVtbl[9])(@this, index, pFuncDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddImplType(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, uint hRefType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, int>)@this->LpVtbl[10])(@this, index, hRefType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetImplTypeFlags(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, int implTypeFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int, int>)@this->LpVtbl[11])(@this, index, implTypeFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAlignment(this ComPtr<ICreateTypeInfo2> thisVtbl, ushort cbAlignment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, ushort, int>)@this->LpVtbl[12])(@this, cbAlignment);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSchema(this ComPtr<ICreateTypeInfo2> thisVtbl, char* pStrSchema)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, char*, int>)@this->LpVtbl[13])(@this, pStrSchema);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSchema(this ComPtr<ICreateTypeInfo2> thisVtbl, ref char pStrSchema)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStrSchemaPtr = &pStrSchema)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, char*, int>)@this->LpVtbl[13])(@this, pStrSchemaPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSchema(this ComPtr<ICreateTypeInfo2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrSchema)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStrSchemaPtr = (byte*) SilkMarshal.StringToPtr(pStrSchema, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, byte*, int>)@this->LpVtbl[13])(@this, pStrSchemaPtr);
        SilkMarshal.Free((nint)pStrSchemaPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddVarDesc(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, VarDesc* pVarDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, VarDesc*, int>)@this->LpVtbl[14])(@this, index, pVarDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddVarDesc(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref VarDesc pVarDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VarDesc* pVarDescPtr = &pVarDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, VarDesc*, int>)@this->LpVtbl[14])(@this, index, pVarDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFuncAndParamNames(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, char** rgszNames, uint cNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char**, uint, int>)@this->LpVtbl[15])(@this, index, rgszNames, cNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFuncAndParamNames(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref char* rgszNames, uint cNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** rgszNamesPtr = &rgszNames)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char**, uint, int>)@this->LpVtbl[15])(@this, index, rgszNamesPtr, cNames);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVarName(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, char* szName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[16])(@this, index, szName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVarName(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref char szName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNamePtr = &szName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[16])(@this, index, szNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVarName(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, int>)@this->LpVtbl[16])(@this, index, szNamePtr);
        SilkMarshal.Free((nint)szNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTypeDescAlias(this ComPtr<ICreateTypeInfo2> thisVtbl, TypeDesc* pTDescAlias)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, TypeDesc*, int>)@this->LpVtbl[17])(@this, pTDescAlias);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTypeDescAlias(this ComPtr<ICreateTypeInfo2> thisVtbl, ref TypeDesc pTDescAlias)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TypeDesc* pTDescAliasPtr = &pTDescAlias)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, TypeDesc*, int>)@this->LpVtbl[17])(@this, pTDescAliasPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, char* szDllName, char* szProcName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, char*, int>)@this->LpVtbl[18])(@this, index, szDllName, szProcName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, char* szDllName, ref char szProcName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szProcNamePtr = &szProcName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, char*, int>)@this->LpVtbl[18])(@this, index, szDllName, szProcNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, char* szDllName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szProcName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szProcNamePtr = (byte*) SilkMarshal.StringToPtr(szProcName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, byte*, int>)@this->LpVtbl[18])(@this, index, szDllName, szProcNamePtr);
        SilkMarshal.Free((nint)szProcNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref char szDllName, char* szProcName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szDllNamePtr = &szDllName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, char*, int>)@this->LpVtbl[18])(@this, index, szDllNamePtr, szProcName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref char szDllName, ref char szProcName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szDllNamePtr = &szDllName)
        {
            fixed (char* szProcNamePtr = &szProcName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, char*, int>)@this->LpVtbl[18])(@this, index, szDllNamePtr, szProcNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref char szDllName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szProcName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szDllNamePtr = &szDllName)
        {
        var szProcNamePtr = (byte*) SilkMarshal.StringToPtr(szProcName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, byte*, int>)@this->LpVtbl[18])(@this, index, szDllNamePtr, szProcNamePtr);
        SilkMarshal.Free((nint)szProcNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDllName, char* szProcName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szDllNamePtr = (byte*) SilkMarshal.StringToPtr(szDllName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, char*, int>)@this->LpVtbl[18])(@this, index, szDllNamePtr, szProcName);
        SilkMarshal.Free((nint)szDllNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDllName, ref char szProcName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szDllNamePtr = (byte*) SilkMarshal.StringToPtr(szDllName, NativeStringEncoding.UTF8);
        fixed (char* szProcNamePtr = &szProcName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, char*, int>)@this->LpVtbl[18])(@this, index, szDllNamePtr, szProcNamePtr);
        }
        SilkMarshal.Free((nint)szDllNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDllName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szProcName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szDllNamePtr = (byte*) SilkMarshal.StringToPtr(szDllName, NativeStringEncoding.UTF8);
        var szProcNamePtr = (byte*) SilkMarshal.StringToPtr(szProcName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, byte*, int>)@this->LpVtbl[18])(@this, index, szDllNamePtr, szProcNamePtr);
        SilkMarshal.Free((nint)szProcNamePtr);
        SilkMarshal.Free((nint)szDllNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFuncDocString(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, char* szDocString)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[19])(@this, index, szDocString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFuncDocString(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref char szDocString)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szDocStringPtr = &szDocString)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[19])(@this, index, szDocStringPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFuncDocString(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDocString)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szDocStringPtr = (byte*) SilkMarshal.StringToPtr(szDocString, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, int>)@this->LpVtbl[19])(@this, index, szDocStringPtr);
        SilkMarshal.Free((nint)szDocStringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVarDocString(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, char* szDocString)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[20])(@this, index, szDocString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVarDocString(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref char szDocString)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szDocStringPtr = &szDocString)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[20])(@this, index, szDocStringPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVarDocString(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDocString)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szDocStringPtr = (byte*) SilkMarshal.StringToPtr(szDocString, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, int>)@this->LpVtbl[20])(@this, index, szDocStringPtr);
        SilkMarshal.Free((nint)szDocStringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFuncHelpContext(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, uint dwHelpContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, int>)@this->LpVtbl[21])(@this, index, dwHelpContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVarHelpContext(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, uint dwHelpContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, int>)@this->LpVtbl[22])(@this, index, dwHelpContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetMops(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, char* bstrMops)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[23])(@this, index, bstrMops);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMops(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref char bstrMops)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrMopsPtr = &bstrMops)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[23])(@this, index, bstrMopsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMops(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrMops)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrMopsPtr = (byte*) SilkMarshal.StringToPtr(bstrMops, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, int>)@this->LpVtbl[23])(@this, index, bstrMopsPtr);
        SilkMarshal.Free((nint)bstrMopsPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTypeIdldesc(this ComPtr<ICreateTypeInfo2> thisVtbl, IdlDesc* pIdlDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, IdlDesc*, int>)@this->LpVtbl[24])(@this, pIdlDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTypeIdldesc(this ComPtr<ICreateTypeInfo2> thisVtbl, ref IdlDesc pIdlDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IdlDesc* pIdlDescPtr = &pIdlDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, IdlDesc*, int>)@this->LpVtbl[24])(@this, pIdlDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LayOut(this ComPtr<ICreateTypeInfo2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, int>)@this->LpVtbl[25])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DeleteFuncDesc(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int>)@this->LpVtbl[26])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DeleteFuncDescByMemId(this ComPtr<ICreateTypeInfo2> thisVtbl, int memid, InvokeKind invKind)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, int, InvokeKind, int>)@this->LpVtbl[27])(@this, memid, invKind);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DeleteVarDesc(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int>)@this->LpVtbl[28])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DeleteVarDescByMemId(this ComPtr<ICreateTypeInfo2> thisVtbl, int memid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, int, int>)@this->LpVtbl[29])(@this, memid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DeleteImplType(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int>)@this->LpVtbl[30])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, Guid* guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[31])(@this, guid, pVarVal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, Guid* guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarValPtr = &pVarVal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[31])(@this, guid, pVarValPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, ref Guid guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[31])(@this, guidPtr, pVarVal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, ref Guid guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[31])(@this, guidPtr, pVarValPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFuncCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Guid* guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[32])(@this, index, guid, pVarVal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFuncCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Guid* guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarValPtr = &pVarVal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[32])(@this, index, guid, pVarValPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFuncCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref Guid guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[32])(@this, index, guidPtr, pVarVal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFuncCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref Guid guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[32])(@this, index, guidPtr, pVarValPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetParamCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint indexFunc, uint indexParam, Guid* guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[33])(@this, indexFunc, indexParam, guid, pVarVal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetParamCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint indexFunc, uint indexParam, Guid* guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarValPtr = &pVarVal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[33])(@this, indexFunc, indexParam, guid, pVarValPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetParamCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint indexFunc, uint indexParam, ref Guid guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[33])(@this, indexFunc, indexParam, guidPtr, pVarVal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetParamCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint indexFunc, uint indexParam, ref Guid guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[33])(@this, indexFunc, indexParam, guidPtr, pVarValPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVarCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Guid* guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[34])(@this, index, guid, pVarVal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVarCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Guid* guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarValPtr = &pVarVal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[34])(@this, index, guid, pVarValPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVarCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref Guid guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[34])(@this, index, guidPtr, pVarVal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVarCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref Guid guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[34])(@this, index, guidPtr, pVarValPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetImplTypeCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Guid* guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[35])(@this, index, guid, pVarVal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetImplTypeCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Guid* guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarValPtr = &pVarVal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[35])(@this, index, guid, pVarValPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetImplTypeCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref Guid guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[35])(@this, index, guidPtr, pVarVal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetImplTypeCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, ref Guid guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[35])(@this, index, guidPtr, pVarValPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetHelpStringContext(this ComPtr<ICreateTypeInfo2> thisVtbl, uint dwHelpStringContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int>)@this->LpVtbl[36])(@this, dwHelpStringContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFuncHelpStringContext(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, uint dwHelpStringContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, int>)@this->LpVtbl[37])(@this, index, dwHelpStringContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVarHelpStringContext(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, uint dwHelpStringContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, int>)@this->LpVtbl[38])(@this, index, dwHelpStringContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Invalidate(this ComPtr<ICreateTypeInfo2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, int>)@this->LpVtbl[39])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ICreateTypeInfo2> thisVtbl, char* szName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, char*, int>)@this->LpVtbl[40])(@this, szName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ICreateTypeInfo2> thisVtbl, ref char szName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNamePtr = &szName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, char*, int>)@this->LpVtbl[40])(@this, szNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ICreateTypeInfo2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, byte*, int>)@this->LpVtbl[40])(@this, szNamePtr);
        SilkMarshal.Free((nint)szNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ICreateTypeInfo2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICreateTypeInfo2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICreateTypeInfo2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetGuid(this ComPtr<ICreateTypeInfo2> thisVtbl, Span<Guid> guid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetGuid(ref guid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetDocString(this ComPtr<ICreateTypeInfo2> thisVtbl, Span<char> pStrDoc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetDocString(ref pStrDoc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddRefTypeInfo<TI0>(this ComPtr<ICreateTypeInfo2> thisVtbl, ComPtr<TI0> pTInfo, uint* phRefType) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddRefTypeInfo((ITypeInfo*) pTInfo.Handle, phRefType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddRefTypeInfo(this ComPtr<ICreateTypeInfo2> thisVtbl, ITypeInfo* pTInfo, Span<uint> phRefType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddRefTypeInfo(pTInfo, ref phRefType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddRefTypeInfo<TI0>(this ComPtr<ICreateTypeInfo2> thisVtbl, ComPtr<TI0> pTInfo, ref uint phRefType) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddRefTypeInfo((ITypeInfo*) pTInfo.Handle, ref phRefType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddRefTypeInfo(this ComPtr<ICreateTypeInfo2> thisVtbl, Span<ITypeInfo> pTInfo, uint* phRefType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddRefTypeInfo(ref pTInfo.GetPinnableReference(), phRefType);
    }

    /// <summary>To be documented.</summary>
    public static int AddRefTypeInfo(this ComPtr<ICreateTypeInfo2> thisVtbl, Span<ITypeInfo> pTInfo, Span<uint> phRefType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddRefTypeInfo(ref pTInfo.GetPinnableReference(), ref phRefType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddFuncDesc(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<FuncDesc> pFuncDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFuncDesc(index, ref pFuncDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetSchema(this ComPtr<ICreateTypeInfo2> thisVtbl, Span<char> pStrSchema)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSchema(ref pStrSchema.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddVarDesc(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<VarDesc> pVarDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddVarDesc(index, ref pVarDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetFuncAndParamNames(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, string[] rgszNamesSa, uint cNames)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
        var ret = @this->SetFuncAndParamNames(index, rgszNames, cNames);
        SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
        SilkMarshal.Free((nint) rgszNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVarName(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<char> szName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVarName(index, ref szName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetTypeDescAlias(this ComPtr<ICreateTypeInfo2> thisVtbl, Span<TypeDesc> pTDescAlias)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTypeDescAlias(ref pTDescAlias.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, char* szDllName, Span<char> szProcName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DefineFuncAsDllEntry(index, szDllName, ref szProcName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<char> szDllName, char* szProcName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DefineFuncAsDllEntry(index, ref szDllName.GetPinnableReference(), szProcName);
    }

    /// <summary>To be documented.</summary>
    public static int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<char> szDllName, Span<char> szProcName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DefineFuncAsDllEntry(index, ref szDllName.GetPinnableReference(), ref szProcName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<char> szDllName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szProcName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DefineFuncAsDllEntry(index, ref szDllName.GetPinnableReference(), szProcName);
    }

    /// <summary>To be documented.</summary>
    public static int DefineFuncAsDllEntry(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDllName, Span<char> szProcName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DefineFuncAsDllEntry(index, szDllName, ref szProcName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetFuncDocString(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<char> szDocString)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetFuncDocString(index, ref szDocString.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetVarDocString(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<char> szDocString)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVarDocString(index, ref szDocString.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetMops(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<char> bstrMops)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetMops(index, ref bstrMops.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetTypeIdldesc(this ComPtr<ICreateTypeInfo2> thisVtbl, Span<IdlDesc> pIdlDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTypeIdldesc(ref pIdlDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, Guid* guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetCustData(guid, ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, Span<Guid> guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetCustData(ref guid.GetPinnableReference(), pVarVal);
    }

    /// <summary>To be documented.</summary>
    public static int SetCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, Span<Guid> guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetCustData(ref guid.GetPinnableReference(), ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFuncCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Guid* guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetFuncCustData(index, guid, ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFuncCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<Guid> guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetFuncCustData(index, ref guid.GetPinnableReference(), pVarVal);
    }

    /// <summary>To be documented.</summary>
    public static int SetFuncCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<Guid> guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetFuncCustData(index, ref guid.GetPinnableReference(), ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetParamCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint indexFunc, uint indexParam, Guid* guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetParamCustData(indexFunc, indexParam, guid, ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetParamCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint indexFunc, uint indexParam, Span<Guid> guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetParamCustData(indexFunc, indexParam, ref guid.GetPinnableReference(), pVarVal);
    }

    /// <summary>To be documented.</summary>
    public static int SetParamCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint indexFunc, uint indexParam, Span<Guid> guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetParamCustData(indexFunc, indexParam, ref guid.GetPinnableReference(), ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVarCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Guid* guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVarCustData(index, guid, ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVarCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<Guid> guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVarCustData(index, ref guid.GetPinnableReference(), pVarVal);
    }

    /// <summary>To be documented.</summary>
    public static int SetVarCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<Guid> guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVarCustData(index, ref guid.GetPinnableReference(), ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetImplTypeCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Guid* guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetImplTypeCustData(index, guid, ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetImplTypeCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<Guid> guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetImplTypeCustData(index, ref guid.GetPinnableReference(), pVarVal);
    }

    /// <summary>To be documented.</summary>
    public static int SetImplTypeCustData(this ComPtr<ICreateTypeInfo2> thisVtbl, uint index, Span<Guid> guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetImplTypeCustData(index, ref guid.GetPinnableReference(), ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ICreateTypeInfo2> thisVtbl, Span<char> szName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetName(ref szName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ICreateTypeInfo2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
