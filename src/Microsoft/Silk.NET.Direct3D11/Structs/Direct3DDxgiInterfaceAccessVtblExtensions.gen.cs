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

namespace Silk.NET.Direct3D11;

public unsafe static class Direct3DDxgiInterfaceAccessVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterface(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, Guid* iid, void** p)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[3])(@this, iid, p);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterface(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, Guid* iid, ref void* p)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pPtr = &p)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[3])(@this, iid, pPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterface(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, ref Guid iid, void** p)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[3])(@this, iidPtr, p);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterface(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, ref Guid iid, ref void* p)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** pPtr = &p)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[3])(@this, iidPtr, pPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetInterface<TI0>(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, out ComPtr<TI0> p) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        p = default;
        return @this->GetInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) p.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterface(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, Span<Guid> iid, void** p)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInterface(ref iid.GetPinnableReference(), p);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterface(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl, Span<Guid> iid, ref void* p)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInterface(ref iid.GetPinnableReference(), ref p);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetInterface<TI0>(this ComPtr<IDirect3DDxgiInterfaceAccess> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
