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

public unsafe static class MallocVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMalloc> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMalloc*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMalloc> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMalloc> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMalloc> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMalloc*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMalloc> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMalloc*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMalloc> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMalloc*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* Alloc(this ComPtr<IMalloc> thisVtbl, nuint cb)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMalloc*, nuint, void*>)@this->LpVtbl[3])(@this, cb);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* Realloc(this ComPtr<IMalloc> thisVtbl, void* pv, nuint cb)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, nuint, void*>)@this->LpVtbl[4])(@this, pv, cb);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* Realloc<T0>(this ComPtr<IMalloc> thisVtbl, ref T0 pv, nuint cb) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, nuint, void*>)@this->LpVtbl[4])(@this, pvPtr, cb);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Free(this ComPtr<IMalloc> thisVtbl, void* pv)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IMalloc*, void*, void>)@this->LpVtbl[5])(@this, pv);
    }

    /// <summary>To be documented.</summary>
    public static void Free<T0>(this ComPtr<IMalloc> thisVtbl, ref T0 pv) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pvPtr = &pv)
        {
            ((delegate* unmanaged[Cdecl]<IMalloc*, void*, void>)@this->LpVtbl[5])(@this, pvPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe nuint GetSize(this ComPtr<IMalloc> thisVtbl, void* pv)
    {
        var @this = thisVtbl.Handle;
        nuint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, nuint>)@this->LpVtbl[6])(@this, pv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nuint GetSize<T0>(this ComPtr<IMalloc> thisVtbl, ref T0 pv) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        nuint ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, nuint>)@this->LpVtbl[6])(@this, pvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DidAlloc(this ComPtr<IMalloc> thisVtbl, void* pv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, int>)@this->LpVtbl[7])(@this, pv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DidAlloc<T0>(this ComPtr<IMalloc> thisVtbl, ref T0 pv) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, int>)@this->LpVtbl[7])(@this, pvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void HeapMinimize(this ComPtr<IMalloc> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IMalloc*, void>)@this->LpVtbl[8])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMalloc> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMalloc> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMalloc> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* Realloc<T0>(this ComPtr<IMalloc> thisVtbl, Span<T0> pv, nuint cb) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Realloc(ref pv.GetPinnableReference(), cb);
    }

    /// <summary>To be documented.</summary>
    public static void Free<T0>(this ComPtr<IMalloc> thisVtbl, Span<T0> pv) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Free(ref pv.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static nuint GetSize<T0>(this ComPtr<IMalloc> thisVtbl, Span<T0> pv) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref pv.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DidAlloc<T0>(this ComPtr<IMalloc> thisVtbl, Span<T0> pv) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DidAlloc(ref pv.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMalloc> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
