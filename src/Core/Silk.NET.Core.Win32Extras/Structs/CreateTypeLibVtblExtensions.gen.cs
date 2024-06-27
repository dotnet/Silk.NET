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

public unsafe static class CreateTypeLibVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICreateTypeLib> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICreateTypeLib> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICreateTypeLib> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICreateTypeLib> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ICreateTypeLib> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ICreateTypeLib> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeInfo(this ComPtr<ICreateTypeLib> thisVtbl, char* szName, TypeKind tkind, ICreateTypeInfo** ppCTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, TypeKind, ICreateTypeInfo**, int>)@this->LpVtbl[3])(@this, szName, tkind, ppCTInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeInfo(this ComPtr<ICreateTypeLib> thisVtbl, char* szName, TypeKind tkind, ref ICreateTypeInfo* ppCTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ICreateTypeInfo** ppCTInfoPtr = &ppCTInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, TypeKind, ICreateTypeInfo**, int>)@this->LpVtbl[3])(@this, szName, tkind, ppCTInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeInfo(this ComPtr<ICreateTypeLib> thisVtbl, ref char szName, TypeKind tkind, ICreateTypeInfo** ppCTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNamePtr = &szName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, TypeKind, ICreateTypeInfo**, int>)@this->LpVtbl[3])(@this, szNamePtr, tkind, ppCTInfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeInfo(this ComPtr<ICreateTypeLib> thisVtbl, ref char szName, TypeKind tkind, ref ICreateTypeInfo* ppCTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNamePtr = &szName)
        {
            fixed (ICreateTypeInfo** ppCTInfoPtr = &ppCTInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, TypeKind, ICreateTypeInfo**, int>)@this->LpVtbl[3])(@this, szNamePtr, tkind, ppCTInfoPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeInfo(this ComPtr<ICreateTypeLib> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, TypeKind tkind, ICreateTypeInfo** ppCTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, byte*, TypeKind, ICreateTypeInfo**, int>)@this->LpVtbl[3])(@this, szNamePtr, tkind, ppCTInfo);
        SilkMarshal.Free((nint)szNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeInfo(this ComPtr<ICreateTypeLib> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, TypeKind tkind, ref ICreateTypeInfo* ppCTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
        fixed (ICreateTypeInfo** ppCTInfoPtr = &ppCTInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, byte*, TypeKind, ICreateTypeInfo**, int>)@this->LpVtbl[3])(@this, szNamePtr, tkind, ppCTInfoPtr);
        }
        SilkMarshal.Free((nint)szNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ICreateTypeLib> thisVtbl, char* szName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, int>)@this->LpVtbl[4])(@this, szName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ICreateTypeLib> thisVtbl, ref char szName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNamePtr = &szName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, int>)@this->LpVtbl[4])(@this, szNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ICreateTypeLib> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, byte*, int>)@this->LpVtbl[4])(@this, szNamePtr);
        SilkMarshal.Free((nint)szNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVersion(this ComPtr<ICreateTypeLib> thisVtbl, ushort wMajorVerNum, ushort wMinorVerNum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, ushort, ushort, int>)@this->LpVtbl[5])(@this, wMajorVerNum, wMinorVerNum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetGuid(this ComPtr<ICreateTypeLib> thisVtbl, Guid* guid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, Guid*, int>)@this->LpVtbl[6])(@this, guid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGuid(this ComPtr<ICreateTypeLib> thisVtbl, ref Guid guid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, Guid*, int>)@this->LpVtbl[6])(@this, guidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDocString(this ComPtr<ICreateTypeLib> thisVtbl, char* szDoc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, int>)@this->LpVtbl[7])(@this, szDoc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDocString(this ComPtr<ICreateTypeLib> thisVtbl, ref char szDoc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szDocPtr = &szDoc)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, int>)@this->LpVtbl[7])(@this, szDocPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDocString(this ComPtr<ICreateTypeLib> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDoc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szDocPtr = (byte*) SilkMarshal.StringToPtr(szDoc, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, byte*, int>)@this->LpVtbl[7])(@this, szDocPtr);
        SilkMarshal.Free((nint)szDocPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetHelpFileName(this ComPtr<ICreateTypeLib> thisVtbl, char* szHelpFileName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, int>)@this->LpVtbl[8])(@this, szHelpFileName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetHelpFileName(this ComPtr<ICreateTypeLib> thisVtbl, ref char szHelpFileName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szHelpFileNamePtr = &szHelpFileName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, int>)@this->LpVtbl[8])(@this, szHelpFileNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetHelpFileName(this ComPtr<ICreateTypeLib> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szHelpFileName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szHelpFileNamePtr = (byte*) SilkMarshal.StringToPtr(szHelpFileName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, byte*, int>)@this->LpVtbl[8])(@this, szHelpFileNamePtr);
        SilkMarshal.Free((nint)szHelpFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetHelpContext(this ComPtr<ICreateTypeLib> thisVtbl, uint dwHelpContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, uint, int>)@this->LpVtbl[9])(@this, dwHelpContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLcid(this ComPtr<ICreateTypeLib> thisVtbl, uint lcid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, uint, int>)@this->LpVtbl[10])(@this, lcid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLibFlags(this ComPtr<ICreateTypeLib> thisVtbl, uint uLibFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, uint, int>)@this->LpVtbl[11])(@this, uLibFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SaveAllChanges(this ComPtr<ICreateTypeLib> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, int>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ICreateTypeLib> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICreateTypeLib> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICreateTypeLib> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeInfo<TI0>(this ComPtr<ICreateTypeLib> thisVtbl, char* szName, TypeKind tkind, ref ComPtr<TI0> ppCTInfo) where TI0 : unmanaged, IComVtbl<ICreateTypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTypeInfo(szName, tkind, (ICreateTypeInfo**) ppCTInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeInfo(this ComPtr<ICreateTypeLib> thisVtbl, Span<char> szName, TypeKind tkind, ICreateTypeInfo** ppCTInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTypeInfo(ref szName.GetPinnableReference(), tkind, ppCTInfo);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTypeInfo<TI0>(this ComPtr<ICreateTypeLib> thisVtbl, ref char szName, TypeKind tkind, ref ComPtr<TI0> ppCTInfo) where TI0 : unmanaged, IComVtbl<ICreateTypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTypeInfo(ref szName, tkind, (ICreateTypeInfo**) ppCTInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeInfo(this ComPtr<ICreateTypeLib> thisVtbl, Span<char> szName, TypeKind tkind, ref ICreateTypeInfo* ppCTInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTypeInfo(ref szName.GetPinnableReference(), tkind, ref ppCTInfo);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTypeInfo<TI0>(this ComPtr<ICreateTypeLib> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, TypeKind tkind, ref ComPtr<TI0> ppCTInfo) where TI0 : unmanaged, IComVtbl<ICreateTypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTypeInfo(szName, tkind, (ICreateTypeInfo**) ppCTInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ICreateTypeLib> thisVtbl, Span<char> szName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetName(ref szName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetGuid(this ComPtr<ICreateTypeLib> thisVtbl, Span<Guid> guid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetGuid(ref guid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetDocString(this ComPtr<ICreateTypeLib> thisVtbl, Span<char> szDoc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetDocString(ref szDoc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetHelpFileName(this ComPtr<ICreateTypeLib> thisVtbl, Span<char> szHelpFileName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetHelpFileName(ref szHelpFileName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ICreateTypeLib> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
