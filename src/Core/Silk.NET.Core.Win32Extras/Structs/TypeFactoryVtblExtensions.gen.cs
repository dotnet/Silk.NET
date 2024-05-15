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

public unsafe static class TypeFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeFactory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeFactory> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeFactory> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeFactory> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ITypeFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ITypeFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, ITypeInfo* pTypeInfo, Guid* riid, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfo, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, ITypeInfo* pTypeInfo, Guid* riid, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfo, riid, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, ITypeInfo* pTypeInfo, ref Guid riid, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfo, riidPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, ITypeInfo* pTypeInfo, ref Guid riid, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfo, riidPtr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, ref ITypeInfo pTypeInfo, Guid* riid, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTypeInfoPtr = &pTypeInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfoPtr, riid, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, ref ITypeInfo pTypeInfo, Guid* riid, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTypeInfoPtr = &pTypeInfo)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfoPtr, riid, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, ref ITypeInfo pTypeInfo, ref Guid riid, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTypeInfoPtr = &pTypeInfo)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfoPtr, riidPtr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, ref ITypeInfo pTypeInfo, ref Guid riid, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTypeInfoPtr = &pTypeInfo)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfoPtr, riidPtr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ITypeFactory> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeFactory> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeFactory> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFromTypeInfo<TI0, TI1>(this ComPtr<ITypeFactory> thisVtbl, ComPtr<TI0> pTypeInfo, out ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->CreateFromTypeInfo((ITypeInfo*) pTypeInfo.Handle, SilkMarshal.GuidPtrOf<TI1>(), (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo<TI0>(this ComPtr<ITypeFactory> thisVtbl, ComPtr<TI0> pTypeInfo, Guid* riid, ref Silk.NET.Core.Native.IUnknown* ppv) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFromTypeInfo((ITypeInfo*) pTypeInfo.Handle, riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, ITypeInfo* pTypeInfo, Span<Guid> riid, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFromTypeInfo(pTypeInfo, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFromTypeInfo<TI0, TI1>(this ComPtr<ITypeFactory> thisVtbl, ComPtr<TI0> pTypeInfo, ref Guid riid, ref ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFromTypeInfo((ITypeInfo*) pTypeInfo.Handle, ref riid, (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, ITypeInfo* pTypeInfo, Span<Guid> riid, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFromTypeInfo(pTypeInfo, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo<TI0>(this ComPtr<ITypeFactory> thisVtbl, ComPtr<TI0> pTypeInfo, ref Guid riid, ref Silk.NET.Core.Native.IUnknown* ppv) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFromTypeInfo((ITypeInfo*) pTypeInfo.Handle, ref riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, Span<ITypeInfo> pTypeInfo, Guid* riid, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFromTypeInfo(ref pTypeInfo.GetPinnableReference(), riid, ppv);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFromTypeInfo<TI0>(this ComPtr<ITypeFactory> thisVtbl, ref ITypeInfo pTypeInfo, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->CreateFromTypeInfo(ref pTypeInfo, SilkMarshal.GuidPtrOf<TI0>(), (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, Span<ITypeInfo> pTypeInfo, Guid* riid, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFromTypeInfo(ref pTypeInfo.GetPinnableReference(), riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, Span<ITypeInfo> pTypeInfo, Span<Guid> riid, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFromTypeInfo(ref pTypeInfo.GetPinnableReference(), ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFromTypeInfo<TI0>(this ComPtr<ITypeFactory> thisVtbl, ref ITypeInfo pTypeInfo, ref Guid riid, ref ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFromTypeInfo(ref pTypeInfo, ref riid, (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFromTypeInfo(this ComPtr<ITypeFactory> thisVtbl, Span<ITypeInfo> pTypeInfo, Span<Guid> riid, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFromTypeInfo(ref pTypeInfo.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ITypeFactory> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateFromTypeInfo<TI0, TI1>(this ComPtr<ITypeFactory> thisVtbl, ComPtr<TI0> pTypeInfo) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateFromTypeInfo(pTypeInfo, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateFromTypeInfo<TI0>(this ComPtr<ITypeFactory> thisVtbl, ref ITypeInfo pTypeInfo) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateFromTypeInfo(ref pTypeInfo, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
