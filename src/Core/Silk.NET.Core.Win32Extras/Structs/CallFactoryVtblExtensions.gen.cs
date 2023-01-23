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

public unsafe static class CallFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICallFactory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ICallFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ICallFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Guid* riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnk, riid2, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnk, riid2, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, ref Guid riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riid2Ptr = &riid2)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnk, riid2Ptr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, ref Guid riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riid2Ptr = &riid2)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnk, riid2Ptr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, Guid* riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnkPtr, riid2, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnkPtr, riid2, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, ref Guid riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
        {
            fixed (Guid* riid2Ptr = &riid2)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnkPtr, riid2Ptr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, ref Guid riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
        {
            fixed (Guid* riid2Ptr = &riid2)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnkPtr, riid2Ptr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Guid* riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnk, riid2, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnk, riid2, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, ref Guid riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Guid* riid2Ptr = &riid2)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnk, riid2Ptr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, ref Guid riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Guid* riid2Ptr = &riid2)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnk, riid2Ptr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, Guid* riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnkPtr, riid2, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnkPtr, riid2, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, ref Guid riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
            {
                fixed (Guid* riid2Ptr = &riid2)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnkPtr, riid2Ptr, ppv);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, ref Guid riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
            {
                fixed (Guid* riid2Ptr = &riid2)
                {
                    fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnkPtr, riid2Ptr, ppvPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ICallFactory> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICallFactory> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ICallFactory> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall<TI0, TI1>(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ComPtr<TI0> pCtrlUnk, out ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->CreateCall(riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, SilkMarshal.GuidPtrOf<TI1>(), (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall<TI0>(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ComPtr<TI0> pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCall(riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, riid2, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Span<Guid> riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(riid, pCtrlUnk, ref riid2.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall<TI0, TI1>(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ComPtr<TI0> pCtrlUnk, ref Guid riid2, ref ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCall(riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, ref riid2, (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Span<Guid> riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(riid, pCtrlUnk, ref riid2.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall<TI0>(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ComPtr<TI0> pCtrlUnk, ref Guid riid2, ref Silk.NET.Core.Native.IUnknown* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCall(riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, ref riid2, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, Span<Silk.NET.Core.Native.IUnknown> pCtrlUnk, Guid* riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(riid, ref pCtrlUnk.GetPinnableReference(), riid2, ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall<TI0>(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->CreateCall(riid, ref pCtrlUnk, SilkMarshal.GuidPtrOf<TI0>(), (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, Span<Silk.NET.Core.Native.IUnknown> pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(riid, ref pCtrlUnk.GetPinnableReference(), riid2, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, Span<Silk.NET.Core.Native.IUnknown> pCtrlUnk, Span<Guid> riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(riid, ref pCtrlUnk.GetPinnableReference(), ref riid2.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall<TI0>(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, ref Guid riid2, ref ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCall(riid, ref pCtrlUnk, ref riid2, (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Guid* riid, Span<Silk.NET.Core.Native.IUnknown> pCtrlUnk, Span<Guid> riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(riid, ref pCtrlUnk.GetPinnableReference(), ref riid2.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Span<Guid> riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Guid* riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(ref riid.GetPinnableReference(), pCtrlUnk, riid2, ppv);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCall<TI0, TI1>(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ComPtr<TI0> pCtrlUnk, out ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->CreateCall(ref riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, SilkMarshal.GuidPtrOf<TI1>(), (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Span<Guid> riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(ref riid.GetPinnableReference(), pCtrlUnk, riid2, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall<TI0>(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ComPtr<TI0> pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCall(ref riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, riid2, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Span<Guid> riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Span<Guid> riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(ref riid.GetPinnableReference(), pCtrlUnk, ref riid2.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCall<TI0, TI1>(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ComPtr<TI0> pCtrlUnk, ref Guid riid2, ref ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCall(ref riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, ref riid2, (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Span<Guid> riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Span<Guid> riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(ref riid.GetPinnableReference(), pCtrlUnk, ref riid2.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall<TI0>(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ComPtr<TI0> pCtrlUnk, ref Guid riid2, ref Silk.NET.Core.Native.IUnknown* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCall(ref riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, ref riid2, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Span<Guid> riid, Span<Silk.NET.Core.Native.IUnknown> pCtrlUnk, Guid* riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(ref riid.GetPinnableReference(), ref pCtrlUnk.GetPinnableReference(), riid2, ppv);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCall<TI0>(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->CreateCall(ref riid, ref pCtrlUnk, SilkMarshal.GuidPtrOf<TI0>(), (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Span<Guid> riid, Span<Silk.NET.Core.Native.IUnknown> pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(ref riid.GetPinnableReference(), ref pCtrlUnk.GetPinnableReference(), riid2, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Span<Guid> riid, Span<Silk.NET.Core.Native.IUnknown> pCtrlUnk, Span<Guid> riid2, Silk.NET.Core.Native.IUnknown** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(ref riid.GetPinnableReference(), ref pCtrlUnk.GetPinnableReference(), ref riid2.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCall<TI0>(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, ref Guid riid2, ref ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCall(ref riid, ref pCtrlUnk, ref riid2, (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCall(this ComPtr<ICallFactory> thisVtbl, Span<Guid> riid, Span<Silk.NET.Core.Native.IUnknown> pCtrlUnk, Span<Guid> riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCall(ref riid.GetPinnableReference(), ref pCtrlUnk.GetPinnableReference(), ref riid2.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ICallFactory> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateCall<TI0, TI1>(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ComPtr<TI0> pCtrlUnk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCall(riid, pCtrlUnk, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCall<TI0>(this ComPtr<ICallFactory> thisVtbl, Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCall(riid, ref pCtrlUnk, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateCall<TI0, TI1>(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ComPtr<TI0> pCtrlUnk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCall(ref riid, pCtrlUnk, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCall<TI0>(this ComPtr<ICallFactory> thisVtbl, ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCall(ref riid, ref pCtrlUnk, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
