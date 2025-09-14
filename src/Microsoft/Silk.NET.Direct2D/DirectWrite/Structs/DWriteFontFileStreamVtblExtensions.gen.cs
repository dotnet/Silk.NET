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

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteFontFileStreamVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFileStream> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFileStream> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFileStream> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFileStream> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFileStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFileStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFileFragment(this ComPtr<IDWriteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStart, fileOffset, fragmentSize, fragmentContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFileFragment(this ComPtr<IDWriteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fragmentStart, ulong fileOffset, ulong fragmentSize, ref void* fragmentContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** fragmentContextPtr = &fragmentContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStart, fileOffset, fragmentSize, fragmentContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFileFragment(this ComPtr<IDWriteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly void* fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** fragmentStartPtr = &fragmentStart)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStartPtr, fileOffset, fragmentSize, fragmentContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFileFragment(this ComPtr<IDWriteFontFileStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly void* fragmentStart, ulong fileOffset, ulong fragmentSize, ref void* fragmentContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** fragmentStartPtr = &fragmentStart)
        {
            fixed (void** fragmentContextPtr = &fragmentContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStartPtr, fileOffset, fragmentSize, fragmentContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseFileFragment(this ComPtr<IDWriteFontFileStream> thisVtbl, void* fragmentContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void*, void>)@this->LpVtbl[4])(@this, fragmentContext);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFileFragment<T0>(this ComPtr<IDWriteFontFileStream> thisVtbl, ref T0 fragmentContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* fragmentContextPtr = &fragmentContext)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void*, void>)@this->LpVtbl[4])(@this, fragmentContextPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileSize(this ComPtr<IDWriteFontFileStream> thisVtbl, ulong* fileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, ulong*, int>)@this->LpVtbl[5])(@this, fileSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFileSize(this ComPtr<IDWriteFontFileStream> thisVtbl, ref ulong fileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* fileSizePtr = &fileSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, ulong*, int>)@this->LpVtbl[5])(@this, fileSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastWriteTime(this ComPtr<IDWriteFontFileStream> thisVtbl, ulong* lastWriteTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, ulong*, int>)@this->LpVtbl[6])(@this, lastWriteTime);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLastWriteTime(this ComPtr<IDWriteFontFileStream> thisVtbl, ref ulong lastWriteTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* lastWriteTimePtr = &lastWriteTime)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, ulong*, int>)@this->LpVtbl[6])(@this, lastWriteTimePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontFileStream> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFileStream> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFileStream> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFileFragment<T0>(this ComPtr<IDWriteFontFileStream> thisVtbl, Span<T0> fragmentContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseFileFragment(ref fragmentContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFileSize(this ComPtr<IDWriteFontFileStream> thisVtbl, Span<ulong> fileSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFileSize(ref fileSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLastWriteTime(this ComPtr<IDWriteFontFileStream> thisVtbl, Span<ulong> lastWriteTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLastWriteTime(ref lastWriteTime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontFileStream> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
