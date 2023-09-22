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

namespace Silk.NET.WindowsCodecs;

public unsafe static class WICStreamProviderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICStreamProvider> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICStreamProvider> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICStreamProvider> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICStreamProvider> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICStreamProvider> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICStreamProvider> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStream(this ComPtr<IWICStreamProvider> thisVtbl, Silk.NET.Core.Win32Extras.IStream** ppIStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[3])(@this, ppIStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStream(this ComPtr<IWICStreamProvider> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream* ppIStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream** ppIStreamPtr = &ppIStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[3])(@this, ppIStreamPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPersistOptions(this ComPtr<IWICStreamProvider> thisVtbl, uint* pdwPersistOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, uint*, int>)@this->LpVtbl[4])(@this, pdwPersistOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPersistOptions(this ComPtr<IWICStreamProvider> thisVtbl, ref uint pdwPersistOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwPersistOptionsPtr = &pdwPersistOptions)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, uint*, int>)@this->LpVtbl[4])(@this, pdwPersistOptionsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPreferredVendorGUID(this ComPtr<IWICStreamProvider> thisVtbl, Guid* pguidPreferredVendor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, int>)@this->LpVtbl[5])(@this, pguidPreferredVendor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPreferredVendorGUID(this ComPtr<IWICStreamProvider> thisVtbl, ref Guid pguidPreferredVendor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidPreferredVendorPtr = &pguidPreferredVendor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, int>)@this->LpVtbl[5])(@this, pguidPreferredVendorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RefreshStream(this ComPtr<IWICStreamProvider> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICStreamProvider> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICStreamProvider> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICStreamProvider> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetStream<TI0>(this ComPtr<IWICStreamProvider> thisVtbl, ref ComPtr<TI0> ppIStream) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetStream((Silk.NET.Core.Win32Extras.IStream**) ppIStream.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetPersistOptions(this ComPtr<IWICStreamProvider> thisVtbl, Span<uint> pdwPersistOptions)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPersistOptions(ref pdwPersistOptions.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPreferredVendorGUID(this ComPtr<IWICStreamProvider> thisVtbl, Span<Guid> pguidPreferredVendor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPreferredVendorGUID(ref pguidPreferredVendor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICStreamProvider> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
