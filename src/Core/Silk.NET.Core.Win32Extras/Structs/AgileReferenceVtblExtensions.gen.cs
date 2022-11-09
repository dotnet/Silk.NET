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

public unsafe static class AgileReferenceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAgileReference> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAgileReference> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAgileReference> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAgileReference> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IAgileReference> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IAgileReference> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Resolve(this ComPtr<IAgileReference> thisVtbl, Guid* riid, void** ppvObjectReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppvObjectReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Resolve(this ComPtr<IAgileReference> thisVtbl, Guid* riid, ref void* ppvObjectReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectReferencePtr = &ppvObjectReference)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppvObjectReferencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Resolve(this ComPtr<IAgileReference> thisVtbl, ref Guid riid, void** ppvObjectReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppvObjectReference);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Resolve(this ComPtr<IAgileReference> thisVtbl, ref Guid riid, ref void* ppvObjectReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectReferencePtr = &ppvObjectReference)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppvObjectReferencePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IAgileReference> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAgileReference> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAgileReference> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Resolve<TI0>(this ComPtr<IAgileReference> thisVtbl, out ComPtr<TI0> ppvObjectReference) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObjectReference = default;
        return @this->Resolve(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObjectReference.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Resolve(this ComPtr<IAgileReference> thisVtbl, Span<Guid> riid, void** ppvObjectReference)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Resolve(ref riid.GetPinnableReference(), ppvObjectReference);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Resolve(this ComPtr<IAgileReference> thisVtbl, Span<Guid> riid, ref void* ppvObjectReference)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Resolve(ref riid.GetPinnableReference(), ref ppvObjectReference);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IAgileReference> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> Resolve<TI0>(this ComPtr<IAgileReference> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->Resolve(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
