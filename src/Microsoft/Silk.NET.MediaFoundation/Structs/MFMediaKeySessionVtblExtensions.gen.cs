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

public unsafe static class MFMediaKeySessionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySession> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySession> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySession> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySession> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaKeySession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaKeySession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaKeySession> thisVtbl, ushort* code, uint* systemCode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, code, systemCode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaKeySession> thisVtbl, ushort* code, ref uint systemCode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* systemCodePtr = &systemCode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, code, systemCodePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaKeySession> thisVtbl, ref ushort code, uint* systemCode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* codePtr = &code)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, codePtr, systemCode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetError(this ComPtr<IMFMediaKeySession> thisVtbl, ref ushort code, ref uint systemCode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* codePtr = &code)
        {
            fixed (uint* systemCodePtr = &systemCode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, codePtr, systemCodePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeySystem(this ComPtr<IMFMediaKeySession> thisVtbl, char** keySystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, char**, int>)@this->LpVtbl[4])(@this, keySystem);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeySystem(this ComPtr<IMFMediaKeySession> thisVtbl, ref char* keySystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** keySystemPtr = &keySystem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, char**, int>)@this->LpVtbl[4])(@this, keySystemPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSessionId(this ComPtr<IMFMediaKeySession> thisVtbl, char** sessionId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, char**, int>)@this->LpVtbl[5])(@this, sessionId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSessionId(this ComPtr<IMFMediaKeySession> thisVtbl, ref char* sessionId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** sessionIdPtr = &sessionId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, char**, int>)@this->LpVtbl[5])(@this, sessionIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<IMFMediaKeySession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, byte*, uint, int>)@this->LpVtbl[6])(@this, key, cb);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Update(this ComPtr<IMFMediaKeySession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* keyPtr = &key)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, byte*, uint, int>)@this->LpVtbl[6])(@this, keyPtr, cb);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Update(this ComPtr<IMFMediaKeySession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, byte*, uint, int>)@this->LpVtbl[6])(@this, keyPtr, cb);
        SilkMarshal.Free((nint)keyPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<IMFMediaKeySession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, int>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaKeySession> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySession> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySession> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaKeySession> thisVtbl, ushort* code, Span<uint> systemCode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetError(code, ref systemCode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaKeySession> thisVtbl, Span<ushort> code, uint* systemCode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetError(ref code.GetPinnableReference(), systemCode);
    }

    /// <summary>To be documented.</summary>
    public static int GetError(this ComPtr<IMFMediaKeySession> thisVtbl, Span<ushort> code, Span<uint> systemCode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetError(ref code.GetPinnableReference(), ref systemCode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetKeySystem(this ComPtr<IMFMediaKeySession> thisVtbl, string[] keySystemSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var keySystem = (char**) SilkMarshal.StringArrayToPtr(keySystemSa);
        var ret = @this->GetKeySystem(keySystem);
        SilkMarshal.CopyPtrToStringArray((nint) keySystem, keySystemSa);
        SilkMarshal.Free((nint) keySystem);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSessionId(this ComPtr<IMFMediaKeySession> thisVtbl, string[] sessionIdSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var sessionId = (char**) SilkMarshal.StringArrayToPtr(sessionIdSa);
        var ret = @this->GetSessionId(sessionId);
        SilkMarshal.CopyPtrToStringArray((nint) sessionId, sessionIdSa);
        SilkMarshal.Free((nint) sessionId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Update(this ComPtr<IMFMediaKeySession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in key.GetPinnableReference(), cb);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaKeySession> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
