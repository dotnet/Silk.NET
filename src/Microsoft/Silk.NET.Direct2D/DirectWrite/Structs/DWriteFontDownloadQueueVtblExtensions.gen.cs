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

public unsafe static class DWriteFontDownloadQueueVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontDownloadQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontDownloadQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddListener(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, IDWriteFontDownloadListener* listener, uint* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int>)@this->LpVtbl[3])(@this, listener, token);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddListener(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, IDWriteFontDownloadListener* listener, ref uint token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tokenPtr = &token)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int>)@this->LpVtbl[3])(@this, listener, tokenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddListener(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, ref IDWriteFontDownloadListener listener, uint* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontDownloadListener* listenerPtr = &listener)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int>)@this->LpVtbl[3])(@this, listenerPtr, token);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddListener(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, ref IDWriteFontDownloadListener listener, ref uint token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontDownloadListener* listenerPtr = &listener)
        {
            fixed (uint* tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int>)@this->LpVtbl[3])(@this, listenerPtr, tokenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveListener(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, uint token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, uint, int>)@this->LpVtbl[4])(@this, token);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsEmpty(this ComPtr<IDWriteFontDownloadQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Silk.NET.Core.Bool32>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDownload(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, Silk.NET.Core.Native.IUnknown* context)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, context);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginDownload(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, ref Silk.NET.Core.Native.IUnknown context)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* contextPtr = &context)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, contextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CancelDownload(this ComPtr<IDWriteFontDownloadQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, int>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetGenerationCount(this ComPtr<IDWriteFontDownloadQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, ulong>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddListener<TI0>(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, ComPtr<TI0> listener, uint* token) where TI0 : unmanaged, IComVtbl<IDWriteFontDownloadListener>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddListener((IDWriteFontDownloadListener*) listener.Handle, token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddListener(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, IDWriteFontDownloadListener* listener, Span<uint> token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddListener(listener, ref token.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddListener<TI0>(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, ComPtr<TI0> listener, ref uint token) where TI0 : unmanaged, IComVtbl<IDWriteFontDownloadListener>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddListener((IDWriteFontDownloadListener*) listener.Handle, ref token);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddListener(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, Span<IDWriteFontDownloadListener> listener, uint* token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddListener(ref listener.GetPinnableReference(), token);
    }

    /// <summary>To be documented.</summary>
    public static int AddListener(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, Span<IDWriteFontDownloadListener> listener, Span<uint> token)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddListener(ref listener.GetPinnableReference(), ref token.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int BeginDownload<TI0>(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, ComPtr<TI0> context) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginDownload((Silk.NET.Core.Native.IUnknown*) context.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int BeginDownload(this ComPtr<IDWriteFontDownloadQueue> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> context)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDownload(ref context.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontDownloadQueue> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
