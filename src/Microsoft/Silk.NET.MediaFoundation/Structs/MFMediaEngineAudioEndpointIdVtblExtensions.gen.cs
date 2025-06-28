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

public unsafe static class MFMediaEngineAudioEndpointIdVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetAudioEndpointId(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszEndpointId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, char*, int>)@this->LpVtbl[3])(@this, pszEndpointId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAudioEndpointId(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszEndpointId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszEndpointIdPtr = &pszEndpointId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, char*, int>)@this->LpVtbl[3])(@this, pszEndpointIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAudioEndpointId(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszEndpointId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszEndpointIdPtr = (byte*) SilkMarshal.StringToPtr(pszEndpointId, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, byte*, int>)@this->LpVtbl[3])(@this, pszEndpointIdPtr);
        SilkMarshal.Free((nint)pszEndpointIdPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAudioEndpointId(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, char** ppszEndpointId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, char**, int>)@this->LpVtbl[4])(@this, ppszEndpointId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAudioEndpointId(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, ref char* ppszEndpointId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** ppszEndpointIdPtr = &ppszEndpointId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, char**, int>)@this->LpVtbl[4])(@this, ppszEndpointIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetAudioEndpointId(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pszEndpointId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetAudioEndpointId(in pszEndpointId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAudioEndpointId(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl, string[] ppszEndpointIdSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppszEndpointId = (char**) SilkMarshal.StringArrayToPtr(ppszEndpointIdSa);
        var ret = @this->GetAudioEndpointId(ppszEndpointId);
        SilkMarshal.CopyPtrToStringArray((nint) ppszEndpointId, ppszEndpointIdSa);
        SilkMarshal.Free((nint) ppszEndpointId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineAudioEndpointId> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
