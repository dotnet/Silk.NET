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

public unsafe static class AsyncManagerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAsyncManager> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAsyncManager> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAsyncManager> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAsyncManager> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IAsyncManager> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IAsyncManager> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CompleteCall(this ComPtr<IAsyncManager> thisVtbl, int Result)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, int, int>)@this->LpVtbl[3])(@this, Result);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IAsyncManager> thisVtbl, Guid* riid, void** pInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, pInterface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IAsyncManager> thisVtbl, Guid* riid, ref void* pInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pInterfacePtr = &pInterface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, pInterfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IAsyncManager> thisVtbl, ref Guid riid, void** pInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, pInterface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IAsyncManager> thisVtbl, ref Guid riid, ref void* pInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** pInterfacePtr = &pInterface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, pInterfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetState(this ComPtr<IAsyncManager> thisVtbl, uint* pulStateFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, uint*, int>)@this->LpVtbl[5])(@this, pulStateFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetState(this ComPtr<IAsyncManager> thisVtbl, ref uint pulStateFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pulStateFlagsPtr = &pulStateFlags)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, uint*, int>)@this->LpVtbl[5])(@this, pulStateFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IAsyncManager> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAsyncManager> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAsyncManager> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetCallContext<TI0>(this ComPtr<IAsyncManager> thisVtbl, out ComPtr<TI0> pInterface) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        pInterface = default;
        return @this->GetCallContext(SilkMarshal.GuidPtrOf<TI0>(), (void**) pInterface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IAsyncManager> thisVtbl, Span<Guid> riid, void** pInterface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCallContext(ref riid.GetPinnableReference(), pInterface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IAsyncManager> thisVtbl, Span<Guid> riid, ref void* pInterface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCallContext(ref riid.GetPinnableReference(), ref pInterface);
    }

    /// <summary>To be documented.</summary>
    public static int GetState(this ComPtr<IAsyncManager> thisVtbl, Span<uint> pulStateFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetState(ref pulStateFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IAsyncManager> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetCallContext<TI0>(this ComPtr<IAsyncManager> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCallContext(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
