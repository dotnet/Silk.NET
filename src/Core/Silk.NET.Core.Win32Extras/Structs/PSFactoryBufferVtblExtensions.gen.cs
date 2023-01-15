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

public unsafe static class PSFactoryBufferVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPSFactoryBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPSFactoryBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, IRpcProxyBuffer** ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuter, riid, ppProxy, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, IRpcProxyBuffer** ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuter, riid, ppProxy, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, ref IRpcProxyBuffer* ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuter, riid, ppProxyPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuter, riid, ppProxyPtr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, IRpcProxyBuffer** ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuter, riidPtr, ppProxy, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, IRpcProxyBuffer** ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuter, riidPtr, ppProxy, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, ref IRpcProxyBuffer* ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuter, riidPtr, ppProxyPtr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuter, riidPtr, ppProxyPtr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, IRpcProxyBuffer** ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuterPtr, riid, ppProxy, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, IRpcProxyBuffer** ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuterPtr, riid, ppProxy, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, ref IRpcProxyBuffer* ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuterPtr, riid, ppProxyPtr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuterPtr, riid, ppProxyPtr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, IRpcProxyBuffer** ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuterPtr, riidPtr, ppProxy, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, IRpcProxyBuffer** ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuterPtr, riidPtr, ppProxy, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, ref IRpcProxyBuffer* ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuterPtr, riidPtr, ppProxyPtr, ppv);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuterPtr, riidPtr, ppProxyPtr, ppvPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, Silk.NET.Core.Native.IUnknown* pUnkServer, IRpcStubBuffer** ppStub)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)@this->LpVtbl[4])(@this, riid, pUnkServer, ppStub);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, Silk.NET.Core.Native.IUnknown* pUnkServer, ref IRpcStubBuffer* ppStub)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IRpcStubBuffer** ppStubPtr = &ppStub)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)@this->LpVtbl[4])(@this, riid, pUnkServer, ppStubPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, ref Silk.NET.Core.Native.IUnknown pUnkServer, IRpcStubBuffer** ppStub)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkServerPtr = &pUnkServer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)@this->LpVtbl[4])(@this, riid, pUnkServerPtr, ppStub);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, ref Silk.NET.Core.Native.IUnknown pUnkServer, ref IRpcStubBuffer* ppStub)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkServerPtr = &pUnkServer)
        {
            fixed (IRpcStubBuffer** ppStubPtr = &ppStub)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)@this->LpVtbl[4])(@this, riid, pUnkServerPtr, ppStubPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Guid riid, Silk.NET.Core.Native.IUnknown* pUnkServer, IRpcStubBuffer** ppStub)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)@this->LpVtbl[4])(@this, riidPtr, pUnkServer, ppStub);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Guid riid, Silk.NET.Core.Native.IUnknown* pUnkServer, ref IRpcStubBuffer* ppStub)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (IRpcStubBuffer** ppStubPtr = &ppStub)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)@this->LpVtbl[4])(@this, riidPtr, pUnkServer, ppStubPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Guid riid, ref Silk.NET.Core.Native.IUnknown pUnkServer, IRpcStubBuffer** ppStub)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnkServerPtr = &pUnkServer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)@this->LpVtbl[4])(@this, riidPtr, pUnkServerPtr, ppStub);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Guid riid, ref Silk.NET.Core.Native.IUnknown pUnkServer, ref IRpcStubBuffer* ppStub)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnkServerPtr = &pUnkServer)
            {
                fixed (IRpcStubBuffer** ppStubPtr = &ppStub)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)@this->LpVtbl[4])(@this, riidPtr, pUnkServerPtr, ppStubPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy<TI0, TI1>(this ComPtr<IPSFactoryBuffer> thisVtbl, ComPtr<TI0> pUnkOuter, ref ComPtr<TI1> ppProxy, void** ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IRpcProxyBuffer>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateProxy((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, SilkMarshal.GuidPtrOf<TI1>(), (IRpcProxyBuffer**) ppProxy.GetAddressOf(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy<TI0, TI1>(this ComPtr<IPSFactoryBuffer> thisVtbl, ComPtr<TI0> pUnkOuter, ref ComPtr<TI1> ppProxy, ref void* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IRpcProxyBuffer>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateProxy((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, SilkMarshal.GuidPtrOf<TI1>(), (IRpcProxyBuffer**) ppProxy.GetAddressOf(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, ComPtr<TI0> pUnkOuter, Guid* riid, ref IRpcProxyBuffer* ppProxy, void** ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateProxy((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, riid, ref ppProxy, ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, ComPtr<TI0> pUnkOuter, Guid* riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateProxy((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, riid, ref ppProxy, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Span<Guid> riid, IRpcProxyBuffer** ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProxy(pUnkOuter, ref riid.GetPinnableReference(), ppProxy, ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy<TI0, TI1>(this ComPtr<IPSFactoryBuffer> thisVtbl, ComPtr<TI0> pUnkOuter, ref Guid riid, ref ComPtr<TI1> ppProxy, void** ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IRpcProxyBuffer>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateProxy((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, ref riid, (IRpcProxyBuffer**) ppProxy.GetAddressOf(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Span<Guid> riid, IRpcProxyBuffer** ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProxy(pUnkOuter, ref riid.GetPinnableReference(), ppProxy, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy<TI0, TI1>(this ComPtr<IPSFactoryBuffer> thisVtbl, ComPtr<TI0> pUnkOuter, ref Guid riid, ref ComPtr<TI1> ppProxy, ref void* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IRpcProxyBuffer>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateProxy((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, ref riid, (IRpcProxyBuffer**) ppProxy.GetAddressOf(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Span<Guid> riid, ref IRpcProxyBuffer* ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProxy(pUnkOuter, ref riid.GetPinnableReference(), ref ppProxy, ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, ComPtr<TI0> pUnkOuter, ref Guid riid, ref IRpcProxyBuffer* ppProxy, void** ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateProxy((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, ref riid, ref ppProxy, ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Span<Guid> riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProxy(pUnkOuter, ref riid.GetPinnableReference(), ref ppProxy, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, ComPtr<TI0> pUnkOuter, ref Guid riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateProxy((Silk.NET.Core.Native.IUnknown*) pUnkOuter.Handle, ref riid, ref ppProxy, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Guid* riid, IRpcProxyBuffer** ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProxy(ref pUnkOuter.GetPinnableReference(), riid, ppProxy, ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref ComPtr<TI0> ppProxy, void** ppv) where TI0 : unmanaged, IComVtbl<IRpcProxyBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateProxy(ref pUnkOuter, SilkMarshal.GuidPtrOf<TI0>(), (IRpcProxyBuffer**) ppProxy.GetAddressOf(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Guid* riid, IRpcProxyBuffer** ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProxy(ref pUnkOuter.GetPinnableReference(), riid, ppProxy, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref ComPtr<TI0> ppProxy, ref void* ppv) where TI0 : unmanaged, IComVtbl<IRpcProxyBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateProxy(ref pUnkOuter, SilkMarshal.GuidPtrOf<TI0>(), (IRpcProxyBuffer**) ppProxy.GetAddressOf(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Guid* riid, ref IRpcProxyBuffer* ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProxy(ref pUnkOuter.GetPinnableReference(), riid, ref ppProxy, ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Guid* riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProxy(ref pUnkOuter.GetPinnableReference(), riid, ref ppProxy, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Span<Guid> riid, IRpcProxyBuffer** ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProxy(ref pUnkOuter.GetPinnableReference(), ref riid.GetPinnableReference(), ppProxy, ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, ref ComPtr<TI0> ppProxy, void** ppv) where TI0 : unmanaged, IComVtbl<IRpcProxyBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateProxy(ref pUnkOuter, ref riid, (IRpcProxyBuffer**) ppProxy.GetAddressOf(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Span<Guid> riid, IRpcProxyBuffer** ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProxy(ref pUnkOuter.GetPinnableReference(), ref riid.GetPinnableReference(), ppProxy, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, ref ComPtr<TI0> ppProxy, ref void* ppv) where TI0 : unmanaged, IComVtbl<IRpcProxyBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateProxy(ref pUnkOuter, ref riid, (IRpcProxyBuffer**) ppProxy.GetAddressOf(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Span<Guid> riid, ref IRpcProxyBuffer* ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProxy(ref pUnkOuter.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppProxy, ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkOuter, Span<Guid> riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateProxy(ref pUnkOuter.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppProxy, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub<TI0, TI1>(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, ComPtr<TI0> pUnkServer, ref ComPtr<TI1> ppStub) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IRpcStubBuffer>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStub(riid, (Silk.NET.Core.Native.IUnknown*) pUnkServer.Handle, (IRpcStubBuffer**) ppStub.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, ComPtr<TI0> pUnkServer, ref IRpcStubBuffer* ppStub) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStub(riid, (Silk.NET.Core.Native.IUnknown*) pUnkServer.Handle, ref ppStub);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, Span<Silk.NET.Core.Native.IUnknown> pUnkServer, IRpcStubBuffer** ppStub)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStub(riid, ref pUnkServer.GetPinnableReference(), ppStub);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, ref Silk.NET.Core.Native.IUnknown pUnkServer, ref ComPtr<TI0> ppStub) where TI0 : unmanaged, IComVtbl<IRpcStubBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStub(riid, ref pUnkServer, (IRpcStubBuffer**) ppStub.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, Span<Silk.NET.Core.Native.IUnknown> pUnkServer, ref IRpcStubBuffer* ppStub)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStub(riid, ref pUnkServer.GetPinnableReference(), ref ppStub);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Guid> riid, Silk.NET.Core.Native.IUnknown* pUnkServer, IRpcStubBuffer** ppStub)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStub(ref riid.GetPinnableReference(), pUnkServer, ppStub);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStub<TI0, TI1>(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Guid riid, ComPtr<TI0> pUnkServer, ref ComPtr<TI1> ppStub) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IRpcStubBuffer>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStub(ref riid, (Silk.NET.Core.Native.IUnknown*) pUnkServer.Handle, (IRpcStubBuffer**) ppStub.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Guid> riid, Silk.NET.Core.Native.IUnknown* pUnkServer, ref IRpcStubBuffer* ppStub)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStub(ref riid.GetPinnableReference(), pUnkServer, ref ppStub);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Guid riid, ComPtr<TI0> pUnkServer, ref IRpcStubBuffer* ppStub) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStub(ref riid, (Silk.NET.Core.Native.IUnknown*) pUnkServer.Handle, ref ppStub);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Guid> riid, Span<Silk.NET.Core.Native.IUnknown> pUnkServer, IRpcStubBuffer** ppStub)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStub(ref riid.GetPinnableReference(), ref pUnkServer.GetPinnableReference(), ppStub);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStub<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl, ref Guid riid, ref Silk.NET.Core.Native.IUnknown pUnkServer, ref ComPtr<TI0> ppStub) where TI0 : unmanaged, IComVtbl<IRpcStubBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStub(ref riid, ref pUnkServer, (IRpcStubBuffer**) ppStub.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, Span<Guid> riid, Span<Silk.NET.Core.Native.IUnknown> pUnkServer, ref IRpcStubBuffer* ppStub)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStub(ref riid.GetPinnableReference(), ref pUnkServer.GetPinnableReference(), ref ppStub);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPSFactoryBuffer> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
