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

public unsafe static class AsyncIPipeByteVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIPipeByte> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIPipeByte> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIPipeByte> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIPipeByte> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<AsyncIPipeByte> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<AsyncIPipeByte> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginPull(this ComPtr<AsyncIPipeByte> thisVtbl, uint cRequest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, uint, int>)@this->LpVtbl[3])(@this, cRequest);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishPull(this ComPtr<AsyncIPipeByte> thisVtbl, byte* buf, uint* pcReturned)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint*, int>)@this->LpVtbl[4])(@this, buf, pcReturned);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishPull(this ComPtr<AsyncIPipeByte> thisVtbl, byte* buf, ref uint pcReturned)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcReturnedPtr = &pcReturned)
        {
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint*, int>)@this->LpVtbl[4])(@this, buf, pcReturnedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishPull(this ComPtr<AsyncIPipeByte> thisVtbl, ref byte buf, uint* pcReturned)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* bufPtr = &buf)
        {
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint*, int>)@this->LpVtbl[4])(@this, bufPtr, pcReturned);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FinishPull(this ComPtr<AsyncIPipeByte> thisVtbl, ref byte buf, ref uint pcReturned)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* bufPtr = &buf)
        {
            fixed (uint* pcReturnedPtr = &pcReturned)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint*, int>)@this->LpVtbl[4])(@this, bufPtr, pcReturnedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishPull(this ComPtr<AsyncIPipeByte> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint* pcReturned)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bufPtr = (byte*) SilkMarshal.StringToPtr(buf, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint*, int>)@this->LpVtbl[4])(@this, bufPtr, pcReturned);
        SilkMarshal.Free((nint)bufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FinishPull(this ComPtr<AsyncIPipeByte> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, ref uint pcReturned)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bufPtr = (byte*) SilkMarshal.StringToPtr(buf, NativeStringEncoding.UTF8);
        fixed (uint* pcReturnedPtr = &pcReturned)
        {
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint*, int>)@this->LpVtbl[4])(@this, bufPtr, pcReturnedPtr);
        }
        SilkMarshal.Free((nint)bufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginPush(this ComPtr<AsyncIPipeByte> thisVtbl, byte* buf, uint cSent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint, int>)@this->LpVtbl[5])(@this, buf, cSent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginPush(this ComPtr<AsyncIPipeByte> thisVtbl, ref byte buf, uint cSent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* bufPtr = &buf)
        {
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint, int>)@this->LpVtbl[5])(@this, bufPtr, cSent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginPush(this ComPtr<AsyncIPipeByte> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint cSent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bufPtr = (byte*) SilkMarshal.StringToPtr(buf, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint, int>)@this->LpVtbl[5])(@this, bufPtr, cSent);
        SilkMarshal.Free((nint)bufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FinishPush(this ComPtr<AsyncIPipeByte> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<AsyncIPipeByte> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIPipeByte> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIPipeByte> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishPull(this ComPtr<AsyncIPipeByte> thisVtbl, byte* buf, Span<uint> pcReturned)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FinishPull(buf, ref pcReturned.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishPull(this ComPtr<AsyncIPipeByte> thisVtbl, Span<byte> buf, uint* pcReturned)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FinishPull(ref buf.GetPinnableReference(), pcReturned);
    }

    /// <summary>To be documented.</summary>
    public static int FinishPull(this ComPtr<AsyncIPipeByte> thisVtbl, Span<byte> buf, Span<uint> pcReturned)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FinishPull(ref buf.GetPinnableReference(), ref pcReturned.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FinishPull(this ComPtr<AsyncIPipeByte> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, Span<uint> pcReturned)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FinishPull(buf, ref pcReturned.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int BeginPush(this ComPtr<AsyncIPipeByte> thisVtbl, Span<byte> buf, uint cSent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginPush(ref buf.GetPinnableReference(), cSent);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<AsyncIPipeByte> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
