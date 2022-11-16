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

public unsafe static class ComThreadingInfoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComThreadingInfo> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComThreadingInfo> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComThreadingInfo> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComThreadingInfo> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IComThreadingInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IComThreadingInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentApartmentType(this ComPtr<IComThreadingInfo> thisVtbl, Apttype* pAptType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Apttype*, int>)@this->LpVtbl[3])(@this, pAptType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentApartmentType(this ComPtr<IComThreadingInfo> thisVtbl, ref Apttype pAptType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Apttype* pAptTypePtr = &pAptType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Apttype*, int>)@this->LpVtbl[3])(@this, pAptTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentThreadType(this ComPtr<IComThreadingInfo> thisVtbl, Thdtype* pThreadType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Thdtype*, int>)@this->LpVtbl[4])(@this, pThreadType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentThreadType(this ComPtr<IComThreadingInfo> thisVtbl, ref Thdtype pThreadType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Thdtype* pThreadTypePtr = &pThreadType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Thdtype*, int>)@this->LpVtbl[4])(@this, pThreadTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentLogicalThreadId(this ComPtr<IComThreadingInfo> thisVtbl, Guid* pguidLogicalThreadId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, int>)@this->LpVtbl[5])(@this, pguidLogicalThreadId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentLogicalThreadId(this ComPtr<IComThreadingInfo> thisVtbl, ref Guid pguidLogicalThreadId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidLogicalThreadIdPtr = &pguidLogicalThreadId)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, int>)@this->LpVtbl[5])(@this, pguidLogicalThreadIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCurrentLogicalThreadId(this ComPtr<IComThreadingInfo> thisVtbl, Guid* rguid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, int>)@this->LpVtbl[6])(@this, rguid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCurrentLogicalThreadId(this ComPtr<IComThreadingInfo> thisVtbl, ref Guid rguid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rguidPtr = &rguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, int>)@this->LpVtbl[6])(@this, rguidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IComThreadingInfo> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComThreadingInfo> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComThreadingInfo> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentApartmentType(this ComPtr<IComThreadingInfo> thisVtbl, Span<Apttype> pAptType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentApartmentType(ref pAptType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentThreadType(this ComPtr<IComThreadingInfo> thisVtbl, Span<Thdtype> pThreadType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentThreadType(ref pThreadType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentLogicalThreadId(this ComPtr<IComThreadingInfo> thisVtbl, Span<Guid> pguidLogicalThreadId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentLogicalThreadId(ref pguidLogicalThreadId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetCurrentLogicalThreadId(this ComPtr<IComThreadingInfo> thisVtbl, Span<Guid> rguid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetCurrentLogicalThreadId(ref rguid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IComThreadingInfo> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
