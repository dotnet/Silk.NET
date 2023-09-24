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

public unsafe static class MallocSpyVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMallocSpy> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMallocSpy> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMallocSpy> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMallocSpy> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMallocSpy> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMallocSpy> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nuint PreAlloc(this ComPtr<IMallocSpy> thisVtbl, nuint cbRequest)
    {
        var @this = thisVtbl.Handle;
        nuint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, nuint, nuint>)@this->LpVtbl[3])(@this, cbRequest);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PostAlloc(this ComPtr<IMallocSpy> thisVtbl, void* pActual)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, void*>)@this->LpVtbl[4])(@this, pActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PostAlloc<T0>(this ComPtr<IMallocSpy> thisVtbl, ref T0 pActual) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (void* pActualPtr = &pActual)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, void*>)@this->LpVtbl[4])(@this, pActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PreFree(this ComPtr<IMallocSpy> thisVtbl, void* pRequest, Silk.NET.Core.Bool32 fSpyed)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[5])(@this, pRequest, fSpyed);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PreFree<T0>(this ComPtr<IMallocSpy> thisVtbl, ref T0 pRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (void* pRequestPtr = &pRequest)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[5])(@this, pRequestPtr, fSpyed);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PostFree(this ComPtr<IMallocSpy> thisVtbl, Silk.NET.Core.Bool32 fSpyed)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IMallocSpy*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[6])(@this, fSpyed);
    }

    /// <summary>To be documented.</summary>
    public static unsafe nuint PreRealloc(this ComPtr<IMallocSpy> thisVtbl, void* pRequest, nuint cbRequest, void** ppNewRequest, Silk.NET.Core.Bool32 fSpyed)
    {
        var @this = thisVtbl.Handle;
        nuint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, nuint, void**, Silk.NET.Core.Bool32, nuint>)@this->LpVtbl[7])(@this, pRequest, cbRequest, ppNewRequest, fSpyed);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe nuint PreRealloc(this ComPtr<IMallocSpy> thisVtbl, void* pRequest, nuint cbRequest, ref void* ppNewRequest, Silk.NET.Core.Bool32 fSpyed)
    {
        var @this = thisVtbl.Handle;
        nuint ret = default;
        fixed (void** ppNewRequestPtr = &ppNewRequest)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, nuint, void**, Silk.NET.Core.Bool32, nuint>)@this->LpVtbl[7])(@this, pRequest, cbRequest, ppNewRequestPtr, fSpyed);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe nuint PreRealloc<T0>(this ComPtr<IMallocSpy> thisVtbl, ref T0 pRequest, nuint cbRequest, void** ppNewRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        nuint ret = default;
        fixed (void* pRequestPtr = &pRequest)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, nuint, void**, Silk.NET.Core.Bool32, nuint>)@this->LpVtbl[7])(@this, pRequestPtr, cbRequest, ppNewRequest, fSpyed);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe nuint PreRealloc<T0>(this ComPtr<IMallocSpy> thisVtbl, ref T0 pRequest, nuint cbRequest, ref void* ppNewRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        nuint ret = default;
        fixed (void* pRequestPtr = &pRequest)
        {
            fixed (void** ppNewRequestPtr = &ppNewRequest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, nuint, void**, Silk.NET.Core.Bool32, nuint>)@this->LpVtbl[7])(@this, pRequestPtr, cbRequest, ppNewRequestPtr, fSpyed);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PostRealloc(this ComPtr<IMallocSpy> thisVtbl, void* pActual, Silk.NET.Core.Bool32 fSpyed)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[8])(@this, pActual, fSpyed);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PostRealloc<T0>(this ComPtr<IMallocSpy> thisVtbl, ref T0 pActual, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (void* pActualPtr = &pActual)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[8])(@this, pActualPtr, fSpyed);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PreGetSize(this ComPtr<IMallocSpy> thisVtbl, void* pRequest, Silk.NET.Core.Bool32 fSpyed)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[9])(@this, pRequest, fSpyed);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PreGetSize<T0>(this ComPtr<IMallocSpy> thisVtbl, ref T0 pRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (void* pRequestPtr = &pRequest)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[9])(@this, pRequestPtr, fSpyed);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nuint PostGetSize(this ComPtr<IMallocSpy> thisVtbl, nuint cbActual, Silk.NET.Core.Bool32 fSpyed)
    {
        var @this = thisVtbl.Handle;
        nuint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, nuint, Silk.NET.Core.Bool32, nuint>)@this->LpVtbl[10])(@this, cbActual, fSpyed);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PreDidAlloc(this ComPtr<IMallocSpy> thisVtbl, void* pRequest, Silk.NET.Core.Bool32 fSpyed)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[11])(@this, pRequest, fSpyed);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PreDidAlloc<T0>(this ComPtr<IMallocSpy> thisVtbl, ref T0 pRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        fixed (void* pRequestPtr = &pRequest)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[11])(@this, pRequestPtr, fSpyed);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PostDidAlloc(this ComPtr<IMallocSpy> thisVtbl, void* pRequest, Silk.NET.Core.Bool32 fSpyed, int fActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, int, int>)@this->LpVtbl[12])(@this, pRequest, fSpyed, fActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PostDidAlloc<T0>(this ComPtr<IMallocSpy> thisVtbl, ref T0 pRequest, Silk.NET.Core.Bool32 fSpyed, int fActual) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pRequestPtr = &pRequest)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, int, int>)@this->LpVtbl[12])(@this, pRequestPtr, fSpyed, fActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PreHeapMinimize(this ComPtr<IMallocSpy> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IMallocSpy*, void>)@this->LpVtbl[13])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void PostHeapMinimize(this ComPtr<IMallocSpy> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IMallocSpy*, void>)@this->LpVtbl[14])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMallocSpy> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMallocSpy> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMallocSpy> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PostAlloc<T0>(this ComPtr<IMallocSpy> thisVtbl, Span<T0> pActual) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PostAlloc(ref pActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PreFree<T0>(this ComPtr<IMallocSpy> thisVtbl, Span<T0> pRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PreFree(ref pRequest.GetPinnableReference(), fSpyed);
    }

    /// <summary>To be documented.</summary>
    public static unsafe nuint PreRealloc<T0>(this ComPtr<IMallocSpy> thisVtbl, Span<T0> pRequest, nuint cbRequest, void** ppNewRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PreRealloc(ref pRequest.GetPinnableReference(), cbRequest, ppNewRequest, fSpyed);
    }

    /// <summary>To be documented.</summary>
    public static unsafe nuint PreRealloc<T0>(this ComPtr<IMallocSpy> thisVtbl, Span<T0> pRequest, nuint cbRequest, ref void* ppNewRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PreRealloc(ref pRequest.GetPinnableReference(), cbRequest, ref ppNewRequest, fSpyed);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PostRealloc<T0>(this ComPtr<IMallocSpy> thisVtbl, Span<T0> pActual, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PostRealloc(ref pActual.GetPinnableReference(), fSpyed);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PreGetSize<T0>(this ComPtr<IMallocSpy> thisVtbl, Span<T0> pRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PreGetSize(ref pRequest.GetPinnableReference(), fSpyed);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* PreDidAlloc<T0>(this ComPtr<IMallocSpy> thisVtbl, Span<T0> pRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PreDidAlloc(ref pRequest.GetPinnableReference(), fSpyed);
    }

    /// <summary>To be documented.</summary>
    public static int PostDidAlloc<T0>(this ComPtr<IMallocSpy> thisVtbl, Span<T0> pRequest, Silk.NET.Core.Bool32 fSpyed, int fActual) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PostDidAlloc(ref pRequest.GetPinnableReference(), fSpyed, fActual);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMallocSpy> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
