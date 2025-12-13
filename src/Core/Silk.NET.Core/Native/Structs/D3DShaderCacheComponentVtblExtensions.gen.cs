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

namespace Silk.NET.Core.Native;

public unsafe static class D3DShaderCacheComponentVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheComponent> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheComponent> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheComponent> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheComponent> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3DShaderCacheComponent> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3DShaderCacheComponent> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComponentName(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char**, int>)@this->LpVtbl[3])(@this, pName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComponentName(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char**, int>)@this->LpVtbl[3])(@this, pNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStateObjectDatabasePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char**, int>)@this->LpVtbl[4])(@this, pPath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStateObjectDatabasePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pPathPtr = &pPath)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char**, int>)@this->LpVtbl[4])(@this, pPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledCachePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char*, char**, int>)@this->LpVtbl[5])(@this, pAdapterFamily, pPath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledCachePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pPathPtr = &pPath)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char*, char**, int>)@this->LpVtbl[5])(@this, pAdapterFamily, pPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledCachePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pAdapterFamilyPtr = &pAdapterFamily)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char*, char**, int>)@this->LpVtbl[5])(@this, pAdapterFamilyPtr, pPath);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledCachePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pAdapterFamilyPtr = &pAdapterFamily)
        {
            fixed (char** pPathPtr = &pPath)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char*, char**, int>)@this->LpVtbl[5])(@this, pAdapterFamilyPtr, pPathPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledCachePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pAdapterFamilyPtr = (byte*) SilkMarshal.StringToPtr(pAdapterFamily, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, byte*, char**, int>)@this->LpVtbl[5])(@this, pAdapterFamilyPtr, pPath);
        SilkMarshal.Free((nint)pAdapterFamilyPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledCachePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pAdapterFamilyPtr = (byte*) SilkMarshal.StringToPtr(pAdapterFamily, NativeStringEncoding.UTF8);
        fixed (char** pPathPtr = &pPath)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, byte*, char**, int>)@this->LpVtbl[5])(@this, pAdapterFamilyPtr, pPathPtr);
        }
        SilkMarshal.Free((nint)pAdapterFamilyPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPrecompiledShaderDatabaseCount(this ComPtr<ID3DShaderCacheComponent> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, uint>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledShaderDatabases(this ComPtr<ID3DShaderCacheComponent> thisVtbl, uint ArraySize, D3DShaderCachePsdbProperties* pPSDBs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, uint, D3DShaderCachePsdbProperties*, int>)@this->LpVtbl[7])(@this, ArraySize, pPSDBs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrecompiledShaderDatabases(this ComPtr<ID3DShaderCacheComponent> thisVtbl, uint ArraySize, ref D3DShaderCachePsdbProperties pPSDBs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, uint, D3DShaderCachePsdbProperties*, int>)@this->LpVtbl[7])(@this, ArraySize, pPSDBsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3DShaderCacheComponent> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheComponent> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheComponent> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetComponentName(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pName = (char**) SilkMarshal.StringArrayToPtr(pNameSa);
        var ret = @this->GetComponentName(pName);
        SilkMarshal.CopyPtrToStringArray((nint) pName, pNameSa);
        SilkMarshal.Free((nint) pName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStateObjectDatabasePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pPathSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pPath = (char**) SilkMarshal.StringArrayToPtr(pPathSa);
        var ret = @this->GetStateObjectDatabasePath(pPath);
        SilkMarshal.CopyPtrToStringArray((nint) pPath, pPathSa);
        SilkMarshal.Free((nint) pPath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledCachePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pPathSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pPath = (char**) SilkMarshal.StringArrayToPtr(pPathSa);
        var ret = @this->GetPrecompiledCachePath(pAdapterFamily, pPath);
        SilkMarshal.CopyPtrToStringArray((nint) pPath, pPathSa);
        SilkMarshal.Free((nint) pPath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrecompiledCachePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pPathSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pPath = (char**) SilkMarshal.StringArrayToPtr(pPathSa);
        var ret = @this->GetPrecompiledCachePath(in pAdapterFamily, pPath);
        SilkMarshal.CopyPtrToStringArray((nint) pPath, pPathSa);
        SilkMarshal.Free((nint) pPath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledCachePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pPath)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrecompiledCachePath(in pAdapterFamily.GetPinnableReference(), pPath);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrecompiledCachePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pPath)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrecompiledCachePath(in pAdapterFamily.GetPinnableReference(), in pPath);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrecompiledCachePath(this ComPtr<ID3DShaderCacheComponent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pPathSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pPath = (char**) SilkMarshal.StringArrayToPtr(pPathSa);
        var ret = @this->GetPrecompiledCachePath(pAdapterFamily, pPath);
        SilkMarshal.CopyPtrToStringArray((nint) pPath, pPathSa);
        SilkMarshal.Free((nint) pPath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrecompiledShaderDatabases(this ComPtr<ID3DShaderCacheComponent> thisVtbl, uint ArraySize, Span<D3DShaderCachePsdbProperties> pPSDBs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrecompiledShaderDatabases(ArraySize, ref pPSDBs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3DShaderCacheComponent> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
