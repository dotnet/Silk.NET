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

public unsafe static class ClassActivatorVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IClassActivator> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IClassActivator> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IClassActivator> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IClassActivator> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IClassActivator> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IClassActivator> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, Guid* rclsid, uint dwClassContext, uint locale, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsid, dwClassContext, locale, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, Guid* rclsid, uint dwClassContext, uint locale, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsid, dwClassContext, locale, riid, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, Guid* rclsid, uint dwClassContext, uint locale, ref Guid riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsid, dwClassContext, locale, riidPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, Guid* rclsid, uint dwClassContext, uint locale, ref Guid riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsid, dwClassContext, locale, riidPtr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, ref Guid rclsid, uint dwClassContext, uint locale, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rclsidPtr = &rclsid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsidPtr, dwClassContext, locale, riid, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, ref Guid rclsid, uint dwClassContext, uint locale, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rclsidPtr = &rclsid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsidPtr, dwClassContext, locale, riid, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, ref Guid rclsid, uint dwClassContext, uint locale, ref Guid riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rclsidPtr = &rclsid)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsidPtr, dwClassContext, locale, riidPtr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, ref Guid rclsid, uint dwClassContext, uint locale, ref Guid riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rclsidPtr = &rclsid)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsidPtr, dwClassContext, locale, riidPtr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IClassActivator> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IClassActivator> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IClassActivator> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject<TI0>(this ComPtr<IClassActivator> thisVtbl, Guid* rclsid, uint dwClassContext, uint locale, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->GetClassObject(rclsid, dwClassContext, locale, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, Guid* rclsid, uint dwClassContext, uint locale, Span<Guid> riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassObject(rclsid, dwClassContext, locale, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, Guid* rclsid, uint dwClassContext, uint locale, Span<Guid> riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassObject(rclsid, dwClassContext, locale, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, Span<Guid> rclsid, uint dwClassContext, uint locale, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassObject(ref rclsid.GetPinnableReference(), dwClassContext, locale, riid, ppv);
    }

    /// <summary>To be documented.</summary>
    public static int GetClassObject<TI0>(this ComPtr<IClassActivator> thisVtbl, ref Guid rclsid, uint dwClassContext, uint locale, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->GetClassObject(ref rclsid, dwClassContext, locale, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, Span<Guid> rclsid, uint dwClassContext, uint locale, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassObject(ref rclsid.GetPinnableReference(), dwClassContext, locale, riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, Span<Guid> rclsid, uint dwClassContext, uint locale, Span<Guid> riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassObject(ref rclsid.GetPinnableReference(), dwClassContext, locale, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassObject(this ComPtr<IClassActivator> thisVtbl, Span<Guid> rclsid, uint dwClassContext, uint locale, Span<Guid> riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassObject(ref rclsid.GetPinnableReference(), dwClassContext, locale, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IClassActivator> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetClassObject<TI0>(this ComPtr<IClassActivator> thisVtbl, Guid* rclsid, uint dwClassContext, uint locale) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetClassObject(rclsid, dwClassContext, locale, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetClassObject<TI0>(this ComPtr<IClassActivator> thisVtbl, ref Guid rclsid, uint dwClassContext, uint locale) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetClassObject(ref rclsid, dwClassContext, locale, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
