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

public unsafe static class D3DShaderCacheExplorerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3DShaderCacheExplorer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3DShaderCacheExplorer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePath, riid, ppvApp);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvAppPtr = &ppvApp)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePath, riid, ppvAppPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath, ref Guid riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePath, riidPtr, ppvApp);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath, ref Guid riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvAppPtr = &ppvApp)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePath, riidPtr, ppvAppPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pFullExePath, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFullExePathPtr = &pFullExePath)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riid, ppvApp);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pFullExePath, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFullExePathPtr = &pFullExePath)
        {
            fixed (void** ppvAppPtr = &ppvApp)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riid, ppvAppPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pFullExePath, ref Guid riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFullExePathPtr = &pFullExePath)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riidPtr, ppvApp);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pFullExePath, ref Guid riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFullExePathPtr = &pFullExePath)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvAppPtr = &ppvApp)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riidPtr, ppvAppPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFullExePathPtr = (byte*) SilkMarshal.StringToPtr(pFullExePath, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riid, ppvApp);
        SilkMarshal.Free((nint)pFullExePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFullExePathPtr = (byte*) SilkMarshal.StringToPtr(pFullExePath, NativeStringEncoding.UTF8);
        fixed (void** ppvAppPtr = &ppvApp)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riid, ppvAppPtr);
        }
        SilkMarshal.Free((nint)pFullExePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath, ref Guid riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFullExePathPtr = (byte*) SilkMarshal.StringToPtr(pFullExePath, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riidPtr, ppvApp);
        }
        SilkMarshal.Free((nint)pFullExePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath, ref Guid riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFullExePathPtr = (byte*) SilkMarshal.StringToPtr(pFullExePath, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvAppPtr = &ppvApp)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riidPtr, ppvAppPtr);
            }
        }
        SilkMarshal.Free((nint)pFullExePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath<TI0>(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvApp = default;
        return @this->GetApplicationFromExePath(pFullExePath, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath, Span<Guid> riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationFromExePath(pFullExePath, ref riid.GetPinnableReference(), ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath, Span<Guid> riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationFromExePath(pFullExePath, ref riid.GetPinnableReference(), ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFullExePath, Guid* riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationFromExePath(in pFullExePath.GetPinnableReference(), riid, ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static int GetApplicationFromExePath<TI0>(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pFullExePath, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvApp = default;
        return @this->GetApplicationFromExePath(in pFullExePath, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFullExePath, Guid* riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationFromExePath(in pFullExePath.GetPinnableReference(), riid, ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFullExePath, Span<Guid> riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationFromExePath(in pFullExePath.GetPinnableReference(), ref riid.GetPinnableReference(), ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFullExePath, Span<Guid> riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationFromExePath(in pFullExePath.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static int GetApplicationFromExePath<TI0>(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvApp = default;
        return @this->GetApplicationFromExePath(pFullExePath, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath, Span<Guid> riid, void** ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationFromExePath(pFullExePath, ref riid.GetPinnableReference(), ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetApplicationFromExePath(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath, Span<Guid> riid, ref void* ppvApp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetApplicationFromExePath(pFullExePath, ref riid.GetPinnableReference(), ref ppvApp);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3DShaderCacheExplorer> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetApplicationFromExePath<TI0>(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetApplicationFromExePath(pFullExePath, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetApplicationFromExePath<TI0>(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pFullExePath) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetApplicationFromExePath(in pFullExePath, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetApplicationFromExePath<TI0>(this ComPtr<ID3DShaderCacheExplorer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetApplicationFromExePath(pFullExePath, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
