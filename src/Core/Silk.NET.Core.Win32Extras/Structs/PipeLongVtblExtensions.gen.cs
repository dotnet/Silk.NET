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

public unsafe static class PipeLongVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPipeLong> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPipeLong*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPipeLong> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPipeLong*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPipeLong> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPipeLong*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPipeLong> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeLong*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPipeLong> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPipeLong*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPipeLong> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPipeLong*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Pull(this ComPtr<IPipeLong> thisVtbl, int* buf, uint cRequest, uint* pcReturned)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPipeLong*, int*, uint, uint*, int>)@this->LpVtbl[3])(@this, buf, cRequest, pcReturned);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Pull(this ComPtr<IPipeLong> thisVtbl, int* buf, uint cRequest, ref uint pcReturned)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcReturnedPtr = &pcReturned)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPipeLong*, int*, uint, uint*, int>)@this->LpVtbl[3])(@this, buf, cRequest, pcReturnedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Pull(this ComPtr<IPipeLong> thisVtbl, ref int buf, uint cRequest, uint* pcReturned)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* bufPtr = &buf)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPipeLong*, int*, uint, uint*, int>)@this->LpVtbl[3])(@this, bufPtr, cRequest, pcReturned);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Pull(this ComPtr<IPipeLong> thisVtbl, ref int buf, uint cRequest, ref uint pcReturned)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* bufPtr = &buf)
        {
            fixed (uint* pcReturnedPtr = &pcReturned)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeLong*, int*, uint, uint*, int>)@this->LpVtbl[3])(@this, bufPtr, cRequest, pcReturnedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Push(this ComPtr<IPipeLong> thisVtbl, int* buf, uint cSent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPipeLong*, int*, uint, int>)@this->LpVtbl[4])(@this, buf, cSent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Push(this ComPtr<IPipeLong> thisVtbl, ref int buf, uint cSent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* bufPtr = &buf)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPipeLong*, int*, uint, int>)@this->LpVtbl[4])(@this, bufPtr, cSent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPipeLong> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPipeLong> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPipeLong> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Pull(this ComPtr<IPipeLong> thisVtbl, int* buf, uint cRequest, Span<uint> pcReturned)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Pull(buf, cRequest, ref pcReturned.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Pull(this ComPtr<IPipeLong> thisVtbl, Span<int> buf, uint cRequest, uint* pcReturned)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Pull(ref buf.GetPinnableReference(), cRequest, pcReturned);
    }

    /// <summary>To be documented.</summary>
    public static int Pull(this ComPtr<IPipeLong> thisVtbl, Span<int> buf, uint cRequest, Span<uint> pcReturned)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Pull(ref buf.GetPinnableReference(), cRequest, ref pcReturned.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Push(this ComPtr<IPipeLong> thisVtbl, Span<int> buf, uint cSent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Push(ref buf.GetPinnableReference(), cSent);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPipeLong> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
