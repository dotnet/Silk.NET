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

namespace Silk.NET.Core.Native;

public unsafe static class D3DDestructionNotifierVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterDestructionCallback<TThis>(this TThis thisVtbl, PfnDestructionCallback callbackFn, void* pData, uint* pCallbackID) where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)@this->LpVtbl[3])(@this, callbackFn, pData, pCallbackID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterDestructionCallback<TThis>(this TThis thisVtbl, PfnDestructionCallback callbackFn, void* pData, ref uint pCallbackID) where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCallbackIDPtr = &pCallbackID)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)@this->LpVtbl[3])(@this, callbackFn, pData, pCallbackIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterDestructionCallback<T0, TThis>(this TThis thisVtbl, PfnDestructionCallback callbackFn, ref T0 pData, uint* pCallbackID) where T0 : unmanaged where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)@this->LpVtbl[3])(@this, callbackFn, pDataPtr, pCallbackID);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterDestructionCallback<T0, TThis>(this TThis thisVtbl, PfnDestructionCallback callbackFn, ref T0 pData, ref uint pCallbackID) where T0 : unmanaged where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (uint* pCallbackIDPtr = &pCallbackID)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)@this->LpVtbl[3])(@this, callbackFn, pDataPtr, pCallbackIDPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterDestructionCallback<TThis>(this TThis thisVtbl, uint callbackID) where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint, int>)@this->LpVtbl[4])(@this, callbackID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterDestructionCallback<TThis>(this TThis thisVtbl, PfnDestructionCallback callbackFn, void* pData, Span<uint> pCallbackID) where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterDestructionCallback(callbackFn, pData, ref pCallbackID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterDestructionCallback<T0, TThis>(this TThis thisVtbl, PfnDestructionCallback callbackFn, Span<T0> pData, uint* pCallbackID) where T0 : unmanaged where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterDestructionCallback(callbackFn, ref pData.GetPinnableReference(), pCallbackID);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterDestructionCallback<T0, TThis>(this TThis thisVtbl, PfnDestructionCallback callbackFn, Span<T0> pData, Span<uint> pCallbackID) where T0 : unmanaged where TThis : IComVtbl<ID3DDestructionNotifier>
    {
        var @this = (ID3DDestructionNotifier*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterDestructionCallback(callbackFn, ref pData.GetPinnableReference(), ref pCallbackID.GetPinnableReference());
    }

}
