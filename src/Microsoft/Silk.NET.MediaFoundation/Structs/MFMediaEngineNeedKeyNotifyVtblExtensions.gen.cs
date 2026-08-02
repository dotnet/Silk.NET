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

namespace Silk.NET.MediaFoundation;

public unsafe static class MFMediaEngineNeedKeyNotifyVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineNeedKeyNotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineNeedKeyNotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineNeedKeyNotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineNeedKeyNotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineNeedKeyNotify*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineNeedKeyNotify*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void NeedKey(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IMFMediaEngineNeedKeyNotify*, byte*, uint, void>)@this->LpVtbl[3])(@this, initData, cb);
    }

    /// <summary>To be documented.</summary>
    public static void NeedKey(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* initDataPtr = &initData)
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaEngineNeedKeyNotify*, byte*, uint, void>)@this->LpVtbl[3])(@this, initDataPtr, cb);
        }
    }

    /// <summary>To be documented.</summary>
    public static void NeedKey(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb)
    {
        var @this = thisVtbl.Handle;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Stdcall]<IMFMediaEngineNeedKeyNotify*, byte*, uint, void>)@this->LpVtbl[3])(@this, initDataPtr, cb);
        SilkMarshal.Free((nint)initDataPtr);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void NeedKey(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->NeedKey(in initData.GetPinnableReference(), cb);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineNeedKeyNotify> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
