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

public unsafe static class MessageFilterVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMessageFilter> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMessageFilter> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMessageFilter> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMessageFilter> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMessageFilter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMessageFilter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint HandleInComingCall(this ComPtr<IMessageFilter> thisVtbl, uint dwCallType, void* htaskCaller, uint dwTickCount, InterfaceInfo* lpInterfaceInfo)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, uint, void*, uint, InterfaceInfo*, uint>)@this->LpVtbl[3])(@this, dwCallType, htaskCaller, dwTickCount, lpInterfaceInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint HandleInComingCall(this ComPtr<IMessageFilter> thisVtbl, uint dwCallType, void* htaskCaller, uint dwTickCount, ref InterfaceInfo lpInterfaceInfo)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (InterfaceInfo* lpInterfaceInfoPtr = &lpInterfaceInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, uint, void*, uint, InterfaceInfo*, uint>)@this->LpVtbl[3])(@this, dwCallType, htaskCaller, dwTickCount, lpInterfaceInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint HandleInComingCall<T0>(this ComPtr<IMessageFilter> thisVtbl, uint dwCallType, ref T0 htaskCaller, uint dwTickCount, InterfaceInfo* lpInterfaceInfo) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (void* htaskCallerPtr = &htaskCaller)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, uint, void*, uint, InterfaceInfo*, uint>)@this->LpVtbl[3])(@this, dwCallType, htaskCallerPtr, dwTickCount, lpInterfaceInfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint HandleInComingCall<T0>(this ComPtr<IMessageFilter> thisVtbl, uint dwCallType, ref T0 htaskCaller, uint dwTickCount, ref InterfaceInfo lpInterfaceInfo) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (void* htaskCallerPtr = &htaskCaller)
        {
            fixed (InterfaceInfo* lpInterfaceInfoPtr = &lpInterfaceInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, uint, void*, uint, InterfaceInfo*, uint>)@this->LpVtbl[3])(@this, dwCallType, htaskCallerPtr, dwTickCount, lpInterfaceInfoPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint RetryRejectedCall(this ComPtr<IMessageFilter> thisVtbl, void* htaskCallee, uint dwTickCount, uint dwRejectType)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, void*, uint, uint, uint>)@this->LpVtbl[4])(@this, htaskCallee, dwTickCount, dwRejectType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint RetryRejectedCall<T0>(this ComPtr<IMessageFilter> thisVtbl, ref T0 htaskCallee, uint dwTickCount, uint dwRejectType) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (void* htaskCalleePtr = &htaskCallee)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, void*, uint, uint, uint>)@this->LpVtbl[4])(@this, htaskCalleePtr, dwTickCount, dwRejectType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint MessagePending(this ComPtr<IMessageFilter> thisVtbl, void* htaskCallee, uint dwTickCount, uint dwPendingType)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, void*, uint, uint, uint>)@this->LpVtbl[5])(@this, htaskCallee, dwTickCount, dwPendingType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint MessagePending<T0>(this ComPtr<IMessageFilter> thisVtbl, ref T0 htaskCallee, uint dwTickCount, uint dwPendingType) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (void* htaskCalleePtr = &htaskCallee)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, void*, uint, uint, uint>)@this->LpVtbl[5])(@this, htaskCalleePtr, dwTickCount, dwPendingType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMessageFilter> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMessageFilter> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMessageFilter> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint HandleInComingCall(this ComPtr<IMessageFilter> thisVtbl, uint dwCallType, void* htaskCaller, uint dwTickCount, Span<InterfaceInfo> lpInterfaceInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HandleInComingCall(dwCallType, htaskCaller, dwTickCount, ref lpInterfaceInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint HandleInComingCall<T0>(this ComPtr<IMessageFilter> thisVtbl, uint dwCallType, Span<T0> htaskCaller, uint dwTickCount, InterfaceInfo* lpInterfaceInfo) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HandleInComingCall(dwCallType, ref htaskCaller.GetPinnableReference(), dwTickCount, lpInterfaceInfo);
    }

    /// <summary>To be documented.</summary>
    public static uint HandleInComingCall<T0>(this ComPtr<IMessageFilter> thisVtbl, uint dwCallType, Span<T0> htaskCaller, uint dwTickCount, Span<InterfaceInfo> lpInterfaceInfo) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HandleInComingCall(dwCallType, ref htaskCaller.GetPinnableReference(), dwTickCount, ref lpInterfaceInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static uint RetryRejectedCall<T0>(this ComPtr<IMessageFilter> thisVtbl, Span<T0> htaskCallee, uint dwTickCount, uint dwRejectType) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RetryRejectedCall(ref htaskCallee.GetPinnableReference(), dwTickCount, dwRejectType);
    }

    /// <summary>To be documented.</summary>
    public static uint MessagePending<T0>(this ComPtr<IMessageFilter> thisVtbl, Span<T0> htaskCallee, uint dwTickCount, uint dwPendingType) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MessagePending(ref htaskCallee.GetPinnableReference(), dwTickCount, dwPendingType);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMessageFilter> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
