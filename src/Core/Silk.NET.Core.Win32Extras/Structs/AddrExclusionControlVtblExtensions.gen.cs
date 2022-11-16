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

public unsafe static class AddrExclusionControlVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAddrExclusionControl> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAddrExclusionControl> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAddrExclusionControl> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAddrExclusionControl> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IAddrExclusionControl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IAddrExclusionControl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentAddrExclusionList(this ComPtr<IAddrExclusionControl> thisVtbl, Guid* riid, void** ppEnumerator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppEnumerator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentAddrExclusionList(this ComPtr<IAddrExclusionControl> thisVtbl, Guid* riid, ref void* ppEnumerator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppEnumeratorPtr = &ppEnumerator)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppEnumeratorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentAddrExclusionList(this ComPtr<IAddrExclusionControl> thisVtbl, ref Guid riid, void** ppEnumerator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppEnumerator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentAddrExclusionList(this ComPtr<IAddrExclusionControl> thisVtbl, ref Guid riid, ref void* ppEnumerator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppEnumeratorPtr = &ppEnumerator)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppEnumeratorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateAddrExclusionList(this ComPtr<IAddrExclusionControl> thisVtbl, Silk.NET.Core.Native.IUnknown* pEnumerator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, pEnumerator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UpdateAddrExclusionList(this ComPtr<IAddrExclusionControl> thisVtbl, ref Silk.NET.Core.Native.IUnknown pEnumerator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pEnumeratorPtr = &pEnumerator)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, pEnumeratorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IAddrExclusionControl> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAddrExclusionControl> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAddrExclusionControl> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentAddrExclusionList<TI0>(this ComPtr<IAddrExclusionControl> thisVtbl, out ComPtr<TI0> ppEnumerator) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppEnumerator = default;
        return @this->GetCurrentAddrExclusionList(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppEnumerator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentAddrExclusionList(this ComPtr<IAddrExclusionControl> thisVtbl, Span<Guid> riid, void** ppEnumerator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentAddrExclusionList(ref riid.GetPinnableReference(), ppEnumerator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentAddrExclusionList(this ComPtr<IAddrExclusionControl> thisVtbl, Span<Guid> riid, ref void* ppEnumerator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentAddrExclusionList(ref riid.GetPinnableReference(), ref ppEnumerator);
    }

    /// <summary>To be documented.</summary>
    public static int UpdateAddrExclusionList<TI0>(this ComPtr<IAddrExclusionControl> thisVtbl, ComPtr<TI0> pEnumerator) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateAddrExclusionList((Silk.NET.Core.Native.IUnknown*) pEnumerator.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int UpdateAddrExclusionList(this ComPtr<IAddrExclusionControl> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pEnumerator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateAddrExclusionList(ref pEnumerator.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IAddrExclusionControl> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetCurrentAddrExclusionList<TI0>(this ComPtr<IAddrExclusionControl> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCurrentAddrExclusionList(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
