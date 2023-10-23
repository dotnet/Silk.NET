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

public unsafe static class RpcOptionsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcOptions> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcOptions> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcOptions> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcOptions> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IRpcOptions> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IRpcOptions> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Set(this ComPtr<IRpcOptions> thisVtbl, Silk.NET.Core.Native.IUnknown* pPrx, RPCOptProperties dwProperty, nuint dwValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, RPCOptProperties, nuint, int>)@this->LpVtbl[3])(@this, pPrx, dwProperty, dwValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Set(this ComPtr<IRpcOptions> thisVtbl, ref Silk.NET.Core.Native.IUnknown pPrx, RPCOptProperties dwProperty, nuint dwValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pPrxPtr = &pPrx)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, RPCOptProperties, nuint, int>)@this->LpVtbl[3])(@this, pPrxPtr, dwProperty, dwValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query(this ComPtr<IRpcOptions> thisVtbl, Silk.NET.Core.Native.IUnknown* pPrx, RPCOptProperties dwProperty, nuint* pdwValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, RPCOptProperties, nuint*, int>)@this->LpVtbl[4])(@this, pPrx, dwProperty, pdwValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query(this ComPtr<IRpcOptions> thisVtbl, Silk.NET.Core.Native.IUnknown* pPrx, RPCOptProperties dwProperty, ref nuint pdwValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nuint* pdwValuePtr = &pdwValue)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, RPCOptProperties, nuint*, int>)@this->LpVtbl[4])(@this, pPrx, dwProperty, pdwValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query(this ComPtr<IRpcOptions> thisVtbl, ref Silk.NET.Core.Native.IUnknown pPrx, RPCOptProperties dwProperty, nuint* pdwValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pPrxPtr = &pPrx)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, RPCOptProperties, nuint*, int>)@this->LpVtbl[4])(@this, pPrxPtr, dwProperty, pdwValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Query(this ComPtr<IRpcOptions> thisVtbl, ref Silk.NET.Core.Native.IUnknown pPrx, RPCOptProperties dwProperty, ref nuint pdwValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pPrxPtr = &pPrx)
        {
            fixed (nuint* pdwValuePtr = &pdwValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, RPCOptProperties, nuint*, int>)@this->LpVtbl[4])(@this, pPrxPtr, dwProperty, pdwValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IRpcOptions> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcOptions> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcOptions> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Set<TI0>(this ComPtr<IRpcOptions> thisVtbl, ComPtr<TI0> pPrx, RPCOptProperties dwProperty, nuint dwValue) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Set((Silk.NET.Core.Native.IUnknown*) pPrx.Handle, dwProperty, dwValue);
    }

    /// <summary>To be documented.</summary>
    public static int Set(this ComPtr<IRpcOptions> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pPrx, RPCOptProperties dwProperty, nuint dwValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Set(ref pPrx.GetPinnableReference(), dwProperty, dwValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query<TI0>(this ComPtr<IRpcOptions> thisVtbl, ComPtr<TI0> pPrx, RPCOptProperties dwProperty, nuint* pdwValue) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Query((Silk.NET.Core.Native.IUnknown*) pPrx.Handle, dwProperty, pdwValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query(this ComPtr<IRpcOptions> thisVtbl, Silk.NET.Core.Native.IUnknown* pPrx, RPCOptProperties dwProperty, Span<nuint> pdwValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Query(pPrx, dwProperty, ref pdwValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Query<TI0>(this ComPtr<IRpcOptions> thisVtbl, ComPtr<TI0> pPrx, RPCOptProperties dwProperty, ref nuint pdwValue) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Query((Silk.NET.Core.Native.IUnknown*) pPrx.Handle, dwProperty, ref pdwValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query(this ComPtr<IRpcOptions> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pPrx, RPCOptProperties dwProperty, nuint* pdwValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Query(ref pPrx.GetPinnableReference(), dwProperty, pdwValue);
    }

    /// <summary>To be documented.</summary>
    public static int Query(this ComPtr<IRpcOptions> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pPrx, RPCOptProperties dwProperty, Span<nuint> pdwValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Query(ref pPrx.GetPinnableReference(), dwProperty, ref pdwValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IRpcOptions> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
