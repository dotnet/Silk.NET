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

public unsafe static class MFMediaKeySessionNotifyVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaKeySessionNotify> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaKeySessionNotify> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, char* destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message, uint cb)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, char*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURL, message, cb);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, char* destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte message, uint cb)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* messagePtr = &message)
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, char*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURL, messagePtr, cb);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, char* destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message, uint cb)
    {
        var @this = thisVtbl.Handle;
        var messagePtr = (byte*) SilkMarshal.StringToPtr(message, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, char*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURL, messagePtr, cb);
        SilkMarshal.Free((nint)messagePtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, ref char destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message, uint cb)
    {
        var @this = thisVtbl.Handle;
        fixed (char* destinationURLPtr = &destinationURL)
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, char*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURLPtr, message, cb);
        }
    }

    /// <summary>To be documented.</summary>
    public static void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, ref char destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte message, uint cb)
    {
        var @this = thisVtbl.Handle;
        fixed (char* destinationURLPtr = &destinationURL)
        {
            fixed (byte* messagePtr = &message)
            {
                ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, char*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURLPtr, messagePtr, cb);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, ref char destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message, uint cb)
    {
        var @this = thisVtbl.Handle;
        fixed (char* destinationURLPtr = &destinationURL)
        {
        var messagePtr = (byte*) SilkMarshal.StringToPtr(message, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, char*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURLPtr, messagePtr, cb);
        SilkMarshal.Free((nint)messagePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message, uint cb)
    {
        var @this = thisVtbl.Handle;
        var destinationURLPtr = (byte*) SilkMarshal.StringToPtr(destinationURL, NativeStringEncoding.BStr);
        ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, byte*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURLPtr, message, cb);
        SilkMarshal.Free((nint)destinationURLPtr);
    }

    /// <summary>To be documented.</summary>
    public static void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte message, uint cb)
    {
        var @this = thisVtbl.Handle;
        var destinationURLPtr = (byte*) SilkMarshal.StringToPtr(destinationURL, NativeStringEncoding.BStr);
        fixed (byte* messagePtr = &message)
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, byte*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURLPtr, messagePtr, cb);
        }
        SilkMarshal.Free((nint)destinationURLPtr);
    }

    /// <summary>To be documented.</summary>
    public static void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message, uint cb)
    {
        var @this = thisVtbl.Handle;
        var destinationURLPtr = (byte*) SilkMarshal.StringToPtr(destinationURL, NativeStringEncoding.BStr);
        var messagePtr = (byte*) SilkMarshal.StringToPtr(message, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, byte*, byte*, uint, void>)@this->LpVtbl[3])(@this, destinationURLPtr, messagePtr, cb);
        SilkMarshal.Free((nint)messagePtr);
        SilkMarshal.Free((nint)destinationURLPtr);
    }

    /// <summary>To be documented.</summary>
    public static void KeyAdded(this ComPtr<IMFMediaKeySessionNotify> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, void>)@this->LpVtbl[4])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void KeyError(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, ushort code, uint systemCode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IMFMediaKeySessionNotify*, ushort, uint, void>)@this->LpVtbl[5])(@this, code, systemCode);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, char* destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->KeyMessage(destinationURL, in message.GetPinnableReference(), cb);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, Span<char> destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->KeyMessage(ref destinationURL.GetPinnableReference(), message, cb);
    }

    /// <summary>To be documented.</summary>
    public static void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, Span<char> destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->KeyMessage(ref destinationURL.GetPinnableReference(), in message.GetPinnableReference(), cb);
    }

    /// <summary>To be documented.</summary>
    public static void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, Span<char> destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->KeyMessage(ref destinationURL.GetPinnableReference(), message, cb);
    }

    /// <summary>To be documented.</summary>
    public static void KeyMessage(this ComPtr<IMFMediaKeySessionNotify> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string destinationURL, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->KeyMessage(destinationURL, in message.GetPinnableReference(), cb);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaKeySessionNotify> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
