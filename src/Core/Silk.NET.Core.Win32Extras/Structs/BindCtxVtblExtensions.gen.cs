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

public unsafe static class BindCtxVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IBindCtx> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IBindCtx> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IBindCtx> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IBindCtx> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IBindCtx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IBindCtx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObjectBound(this ComPtr<IBindCtx> thisVtbl, Silk.NET.Core.Native.IUnknown* punk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, punk);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterObjectBound(this ComPtr<IBindCtx> thisVtbl, ref Silk.NET.Core.Native.IUnknown punk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* punkPtr = &punk)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, punkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RevokeObjectBound(this ComPtr<IBindCtx> thisVtbl, Silk.NET.Core.Native.IUnknown* punk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, punk);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RevokeObjectBound(this ComPtr<IBindCtx> thisVtbl, ref Silk.NET.Core.Native.IUnknown punk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* punkPtr = &punk)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, punkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseBoundObjects(this ComPtr<IBindCtx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBindOptions(this ComPtr<IBindCtx> thisVtbl, BindOpts* pbindopts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, BindOpts*, int>)@this->LpVtbl[6])(@this, pbindopts);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBindOptions(this ComPtr<IBindCtx> thisVtbl, ref BindOpts pbindopts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BindOpts* pbindoptsPtr = &pbindopts)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, BindOpts*, int>)@this->LpVtbl[6])(@this, pbindoptsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBindOptions(this ComPtr<IBindCtx> thisVtbl, BindOpts* pbindopts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, BindOpts*, int>)@this->LpVtbl[7])(@this, pbindopts);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBindOptions(this ComPtr<IBindCtx> thisVtbl, ref BindOpts pbindopts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BindOpts* pbindoptsPtr = &pbindopts)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, BindOpts*, int>)@this->LpVtbl[7])(@this, pbindoptsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRunningObjectTable(this ComPtr<IBindCtx> thisVtbl, IRunningObjectTable** pprot)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, IRunningObjectTable**, int>)@this->LpVtbl[8])(@this, pprot);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRunningObjectTable(this ComPtr<IBindCtx> thisVtbl, ref IRunningObjectTable* pprot)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IRunningObjectTable** pprotPtr = &pprot)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, IRunningObjectTable**, int>)@this->LpVtbl[8])(@this, pprotPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObjectParam(this ComPtr<IBindCtx> thisVtbl, char* pszKey, Silk.NET.Core.Native.IUnknown* punk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pszKey, punk);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObjectParam(this ComPtr<IBindCtx> thisVtbl, char* pszKey, ref Silk.NET.Core.Native.IUnknown punk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* punkPtr = &punk)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pszKey, punkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObjectParam(this ComPtr<IBindCtx> thisVtbl, ref char pszKey, Silk.NET.Core.Native.IUnknown* punk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszKeyPtr = &pszKey)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pszKeyPtr, punk);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterObjectParam(this ComPtr<IBindCtx> thisVtbl, ref char pszKey, ref Silk.NET.Core.Native.IUnknown punk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszKeyPtr = &pszKey)
        {
            fixed (Silk.NET.Core.Native.IUnknown* punkPtr = &punk)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pszKeyPtr, punkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObjectParam(this ComPtr<IBindCtx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, Silk.NET.Core.Native.IUnknown* punk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszKeyPtr = (byte*) SilkMarshal.StringToPtr(pszKey, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, byte*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pszKeyPtr, punk);
        SilkMarshal.Free((nint)pszKeyPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterObjectParam(this ComPtr<IBindCtx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, ref Silk.NET.Core.Native.IUnknown punk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszKeyPtr = (byte*) SilkMarshal.StringToPtr(pszKey, NativeStringEncoding.UTF8);
        fixed (Silk.NET.Core.Native.IUnknown* punkPtr = &punk)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, byte*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pszKeyPtr, punkPtr);
        }
        SilkMarshal.Free((nint)pszKeyPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectParam(this ComPtr<IBindCtx> thisVtbl, char* pszKey, Silk.NET.Core.Native.IUnknown** ppunk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, pszKey, ppunk);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectParam(this ComPtr<IBindCtx> thisVtbl, char* pszKey, ref Silk.NET.Core.Native.IUnknown* ppunk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppunkPtr = &ppunk)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, pszKey, ppunkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectParam(this ComPtr<IBindCtx> thisVtbl, ref char pszKey, Silk.NET.Core.Native.IUnknown** ppunk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszKeyPtr = &pszKey)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, pszKeyPtr, ppunk);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectParam(this ComPtr<IBindCtx> thisVtbl, ref char pszKey, ref Silk.NET.Core.Native.IUnknown* ppunk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszKeyPtr = &pszKey)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppunkPtr = &ppunk)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, pszKeyPtr, ppunkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectParam(this ComPtr<IBindCtx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, Silk.NET.Core.Native.IUnknown** ppunk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszKeyPtr = (byte*) SilkMarshal.StringToPtr(pszKey, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, byte*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, pszKeyPtr, ppunk);
        SilkMarshal.Free((nint)pszKeyPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectParam(this ComPtr<IBindCtx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, ref Silk.NET.Core.Native.IUnknown* ppunk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszKeyPtr = (byte*) SilkMarshal.StringToPtr(pszKey, NativeStringEncoding.UTF8);
        fixed (Silk.NET.Core.Native.IUnknown** ppunkPtr = &ppunk)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, byte*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, pszKeyPtr, ppunkPtr);
        }
        SilkMarshal.Free((nint)pszKeyPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumObjectParam(this ComPtr<IBindCtx> thisVtbl, IEnumString** ppenum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, IEnumString**, int>)@this->LpVtbl[11])(@this, ppenum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumObjectParam(this ComPtr<IBindCtx> thisVtbl, ref IEnumString* ppenum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumString** ppenumPtr = &ppenum)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, IEnumString**, int>)@this->LpVtbl[11])(@this, ppenumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RevokeObjectParam(this ComPtr<IBindCtx> thisVtbl, char* pszKey)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, int>)@this->LpVtbl[12])(@this, pszKey);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RevokeObjectParam(this ComPtr<IBindCtx> thisVtbl, ref char pszKey)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszKeyPtr = &pszKey)
        {
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, int>)@this->LpVtbl[12])(@this, pszKeyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RevokeObjectParam(this ComPtr<IBindCtx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszKeyPtr = (byte*) SilkMarshal.StringToPtr(pszKey, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, byte*, int>)@this->LpVtbl[12])(@this, pszKeyPtr);
        SilkMarshal.Free((nint)pszKeyPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IBindCtx> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IBindCtx> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IBindCtx> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterObjectBound<TI0>(this ComPtr<IBindCtx> thisVtbl, ComPtr<TI0> punk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObjectBound((Silk.NET.Core.Native.IUnknown*) punk.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterObjectBound(this ComPtr<IBindCtx> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> punk)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObjectBound(ref punk.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RevokeObjectBound<TI0>(this ComPtr<IBindCtx> thisVtbl, ComPtr<TI0> punk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RevokeObjectBound((Silk.NET.Core.Native.IUnknown*) punk.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RevokeObjectBound(this ComPtr<IBindCtx> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> punk)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RevokeObjectBound(ref punk.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetBindOptions(this ComPtr<IBindCtx> thisVtbl, Span<BindOpts> pbindopts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetBindOptions(ref pbindopts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBindOptions(this ComPtr<IBindCtx> thisVtbl, Span<BindOpts> pbindopts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBindOptions(ref pbindopts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRunningObjectTable<TI0>(this ComPtr<IBindCtx> thisVtbl, ref ComPtr<TI0> pprot) where TI0 : unmanaged, IComVtbl<IRunningObjectTable>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRunningObjectTable((IRunningObjectTable**) pprot.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObjectParam<TI0>(this ComPtr<IBindCtx> thisVtbl, char* pszKey, ComPtr<TI0> punk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObjectParam(pszKey, (Silk.NET.Core.Native.IUnknown*) punk.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObjectParam(this ComPtr<IBindCtx> thisVtbl, char* pszKey, Span<Silk.NET.Core.Native.IUnknown> punk)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObjectParam(pszKey, ref punk.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObjectParam(this ComPtr<IBindCtx> thisVtbl, Span<char> pszKey, Silk.NET.Core.Native.IUnknown* punk)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObjectParam(ref pszKey.GetPinnableReference(), punk);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterObjectParam<TI0>(this ComPtr<IBindCtx> thisVtbl, ref char pszKey, ComPtr<TI0> punk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObjectParam(ref pszKey, (Silk.NET.Core.Native.IUnknown*) punk.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterObjectParam(this ComPtr<IBindCtx> thisVtbl, Span<char> pszKey, Span<Silk.NET.Core.Native.IUnknown> punk)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObjectParam(ref pszKey.GetPinnableReference(), ref punk.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RegisterObjectParam<TI0>(this ComPtr<IBindCtx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, ComPtr<TI0> punk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterObjectParam(pszKey, (Silk.NET.Core.Native.IUnknown*) punk.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterObjectParam(this ComPtr<IBindCtx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, Span<Silk.NET.Core.Native.IUnknown> punk)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterObjectParam(pszKey, ref punk.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectParam<TI0>(this ComPtr<IBindCtx> thisVtbl, char* pszKey, ref ComPtr<TI0> ppunk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetObjectParam(pszKey, (Silk.NET.Core.Native.IUnknown**) ppunk.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectParam(this ComPtr<IBindCtx> thisVtbl, Span<char> pszKey, Silk.NET.Core.Native.IUnknown** ppunk)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectParam(ref pszKey.GetPinnableReference(), ppunk);
    }

    /// <summary>To be documented.</summary>
    public static int GetObjectParam<TI0>(this ComPtr<IBindCtx> thisVtbl, ref char pszKey, ref ComPtr<TI0> ppunk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetObjectParam(ref pszKey, (Silk.NET.Core.Native.IUnknown**) ppunk.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectParam(this ComPtr<IBindCtx> thisVtbl, Span<char> pszKey, ref Silk.NET.Core.Native.IUnknown* ppunk)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectParam(ref pszKey.GetPinnableReference(), ref ppunk);
    }

    /// <summary>To be documented.</summary>
    public static int GetObjectParam<TI0>(this ComPtr<IBindCtx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, ref ComPtr<TI0> ppunk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetObjectParam(pszKey, (Silk.NET.Core.Native.IUnknown**) ppunk.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int EnumObjectParam<TI0>(this ComPtr<IBindCtx> thisVtbl, ref ComPtr<TI0> ppenum) where TI0 : unmanaged, IComVtbl<IEnumString>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumObjectParam((IEnumString**) ppenum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int RevokeObjectParam(this ComPtr<IBindCtx> thisVtbl, Span<char> pszKey)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RevokeObjectParam(ref pszKey.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IBindCtx> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
