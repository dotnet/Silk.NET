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

public unsafe static class PersistFileVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistFile> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistFile> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistFile> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistFile> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPersistFile> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPersistFile> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassID(this ComPtr<IPersistFile> thisVtbl, Guid* pClassID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, Guid*, int>)@this->LpVtbl[3])(@this, pClassID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClassID(this ComPtr<IPersistFile> thisVtbl, ref Guid pClassID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pClassIDPtr = &pClassID)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, Guid*, int>)@this->LpVtbl[3])(@this, pClassIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsDirty(this ComPtr<IPersistFile> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IPersistFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszFileName, uint dwMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char*, uint, int>)@this->LpVtbl[5])(@this, pszFileName, dwMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IPersistFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszFileName, uint dwMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszFileNamePtr = &pszFileName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char*, uint, int>)@this->LpVtbl[5])(@this, pszFileNamePtr, dwMode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IPersistFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszFileName, uint dwMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszFileNamePtr = (byte*) SilkMarshal.StringToPtr(pszFileName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, byte*, uint, int>)@this->LpVtbl[5])(@this, pszFileNamePtr, dwMode);
        SilkMarshal.Free((nint)pszFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Save(this ComPtr<IPersistFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszFileName, Silk.NET.Core.Bool32 fRemember)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pszFileName, fRemember);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Save(this ComPtr<IPersistFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszFileName, Silk.NET.Core.Bool32 fRemember)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszFileNamePtr = &pszFileName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pszFileNamePtr, fRemember);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Save(this ComPtr<IPersistFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszFileName, Silk.NET.Core.Bool32 fRemember)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszFileNamePtr = (byte*) SilkMarshal.StringToPtr(pszFileName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, byte*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pszFileNamePtr, fRemember);
        SilkMarshal.Free((nint)pszFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveCompleted(this ComPtr<IPersistFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszFileName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char*, int>)@this->LpVtbl[7])(@this, pszFileName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SaveCompleted(this ComPtr<IPersistFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszFileName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszFileNamePtr = &pszFileName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char*, int>)@this->LpVtbl[7])(@this, pszFileNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SaveCompleted(this ComPtr<IPersistFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszFileName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszFileNamePtr = (byte*) SilkMarshal.StringToPtr(pszFileName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, byte*, int>)@this->LpVtbl[7])(@this, pszFileNamePtr);
        SilkMarshal.Free((nint)pszFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurFile(this ComPtr<IPersistFile> thisVtbl, char** ppszFileName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char**, int>)@this->LpVtbl[8])(@this, ppszFileName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurFile(this ComPtr<IPersistFile> thisVtbl, ref char* ppszFileName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** ppszFileNamePtr = &ppszFileName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char**, int>)@this->LpVtbl[8])(@this, ppszFileNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPersistFile> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistFile> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistFile> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetClassID(this ComPtr<IPersistFile> thisVtbl, Span<Guid> pClassID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassID(ref pClassID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IPersistFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pszFileName, uint dwMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(in pszFileName.GetPinnableReference(), dwMode);
    }

    /// <summary>To be documented.</summary>
    public static int Save(this ComPtr<IPersistFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pszFileName, Silk.NET.Core.Bool32 fRemember)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Save(in pszFileName.GetPinnableReference(), fRemember);
    }

    /// <summary>To be documented.</summary>
    public static int SaveCompleted(this ComPtr<IPersistFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pszFileName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SaveCompleted(in pszFileName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCurFile(this ComPtr<IPersistFile> thisVtbl, string[] ppszFileNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppszFileName = (char**) SilkMarshal.StringArrayToPtr(ppszFileNameSa);
        var ret = @this->GetCurFile(ppszFileName);
        SilkMarshal.CopyPtrToStringArray((nint) ppszFileName, ppszFileNameSa);
        SilkMarshal.Free((nint) ppszFileName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPersistFile> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
