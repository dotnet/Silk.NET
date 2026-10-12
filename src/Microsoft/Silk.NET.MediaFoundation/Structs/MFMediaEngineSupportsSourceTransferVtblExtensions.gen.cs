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

public unsafe static class MFMediaEngineSupportsSourceTransferVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ShouldTransferSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, int* pfShouldTransfer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, int*, int>)@this->LpVtbl[3])(@this, pfShouldTransfer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ShouldTransferSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref int pfShouldTransfer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfShouldTransferPtr = &pfShouldTransfer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, int*, int>)@this->LpVtbl[3])(@this, pfShouldTransferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream** ppByteStream, IMFMediaSource** ppMediaSource, IMFMediaSourceExtension** ppMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStream, ppMediaSource, ppMSE);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream** ppByteStream, IMFMediaSource** ppMediaSource, ref IMFMediaSourceExtension* ppMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaSourceExtension** ppMSEPtr = &ppMSE)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStream, ppMediaSource, ppMSEPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream** ppByteStream, ref IMFMediaSource* ppMediaSource, IMFMediaSourceExtension** ppMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaSource** ppMediaSourcePtr = &ppMediaSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStream, ppMediaSourcePtr, ppMSE);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream** ppByteStream, ref IMFMediaSource* ppMediaSource, ref IMFMediaSourceExtension* ppMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaSource** ppMediaSourcePtr = &ppMediaSource)
        {
            fixed (IMFMediaSourceExtension** ppMSEPtr = &ppMSE)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStream, ppMediaSourcePtr, ppMSEPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref IMFByteStream* ppByteStream, IMFMediaSource** ppMediaSource, IMFMediaSourceExtension** ppMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream** ppByteStreamPtr = &ppByteStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStreamPtr, ppMediaSource, ppMSE);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref IMFByteStream* ppByteStream, IMFMediaSource** ppMediaSource, ref IMFMediaSourceExtension* ppMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream** ppByteStreamPtr = &ppByteStream)
        {
            fixed (IMFMediaSourceExtension** ppMSEPtr = &ppMSE)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStreamPtr, ppMediaSource, ppMSEPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref IMFByteStream* ppByteStream, ref IMFMediaSource* ppMediaSource, IMFMediaSourceExtension** ppMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream** ppByteStreamPtr = &ppByteStream)
        {
            fixed (IMFMediaSource** ppMediaSourcePtr = &ppMediaSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStreamPtr, ppMediaSourcePtr, ppMSE);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref IMFByteStream* ppByteStream, ref IMFMediaSource* ppMediaSource, ref IMFMediaSourceExtension* ppMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream** ppByteStreamPtr = &ppByteStream)
        {
            fixed (IMFMediaSource** ppMediaSourcePtr = &ppMediaSource)
            {
                fixed (IMFMediaSourceExtension** ppMSEPtr = &ppMSE)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStreamPtr, ppMediaSourcePtr, ppMSEPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream* pByteStream, IMFMediaSource* pMediaSource, IMFMediaSourceExtension* pMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStream, pMediaSource, pMSE);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream* pByteStream, IMFMediaSource* pMediaSource, ref IMFMediaSourceExtension pMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaSourceExtension* pMSEPtr = &pMSE)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStream, pMediaSource, pMSEPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream* pByteStream, ref IMFMediaSource pMediaSource, IMFMediaSourceExtension* pMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaSource* pMediaSourcePtr = &pMediaSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStream, pMediaSourcePtr, pMSE);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream* pByteStream, ref IMFMediaSource pMediaSource, ref IMFMediaSourceExtension pMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaSource* pMediaSourcePtr = &pMediaSource)
        {
            fixed (IMFMediaSourceExtension* pMSEPtr = &pMSE)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStream, pMediaSourcePtr, pMSEPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref IMFByteStream pByteStream, IMFMediaSource* pMediaSource, IMFMediaSourceExtension* pMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStreamPtr, pMediaSource, pMSE);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref IMFByteStream pByteStream, IMFMediaSource* pMediaSource, ref IMFMediaSourceExtension pMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (IMFMediaSourceExtension* pMSEPtr = &pMSE)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStreamPtr, pMediaSource, pMSEPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref IMFByteStream pByteStream, ref IMFMediaSource pMediaSource, IMFMediaSourceExtension* pMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (IMFMediaSource* pMediaSourcePtr = &pMediaSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStreamPtr, pMediaSourcePtr, pMSE);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref IMFByteStream pByteStream, ref IMFMediaSource pMediaSource, ref IMFMediaSourceExtension pMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (IMFMediaSource* pMediaSourcePtr = &pMediaSource)
            {
                fixed (IMFMediaSourceExtension* pMSEPtr = &pMSE)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStreamPtr, pMediaSourcePtr, pMSEPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int ShouldTransferSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, Span<int> pfShouldTransfer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ShouldTransferSource(ref pfShouldTransfer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetachMediaSource<TI0>(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream** ppByteStream, IMFMediaSource** ppMediaSource, ref ComPtr<TI0> ppMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DetachMediaSource(ppByteStream, ppMediaSource, (IMFMediaSourceExtension**) ppMSE.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetachMediaSource<TI0>(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream** ppByteStream, ref IMFMediaSource* ppMediaSource, ref ComPtr<TI0> ppMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DetachMediaSource(ppByteStream, ref ppMediaSource, (IMFMediaSourceExtension**) ppMSE.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetachMediaSource<TI0>(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref IMFByteStream* ppByteStream, IMFMediaSource** ppMediaSource, ref ComPtr<TI0> ppMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DetachMediaSource(ref ppByteStream, ppMediaSource, (IMFMediaSourceExtension**) ppMSE.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetachMediaSource<TI0>(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref IMFByteStream* ppByteStream, ref IMFMediaSource* ppMediaSource, ref ComPtr<TI0> ppMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DetachMediaSource(ref ppByteStream, ref ppMediaSource, (IMFMediaSourceExtension**) ppMSE.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource<TI0>(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream* pByteStream, IMFMediaSource* pMediaSource, ComPtr<TI0> pMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AttachMediaSource(pByteStream, pMediaSource, (IMFMediaSourceExtension*) pMSE.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream* pByteStream, IMFMediaSource* pMediaSource, Span<IMFMediaSourceExtension> pMSE)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AttachMediaSource(pByteStream, pMediaSource, ref pMSE.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream* pByteStream, Span<IMFMediaSource> pMediaSource, IMFMediaSourceExtension* pMSE)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AttachMediaSource(pByteStream, ref pMediaSource.GetPinnableReference(), pMSE);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource<TI0>(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream* pByteStream, ref IMFMediaSource pMediaSource, ComPtr<TI0> pMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AttachMediaSource(pByteStream, ref pMediaSource, (IMFMediaSourceExtension*) pMSE.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, IMFByteStream* pByteStream, Span<IMFMediaSource> pMediaSource, Span<IMFMediaSourceExtension> pMSE)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AttachMediaSource(pByteStream, ref pMediaSource.GetPinnableReference(), ref pMSE.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, Span<IMFByteStream> pByteStream, IMFMediaSource* pMediaSource, IMFMediaSourceExtension* pMSE)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AttachMediaSource(ref pByteStream.GetPinnableReference(), pMediaSource, pMSE);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource<TI0>(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref IMFByteStream pByteStream, IMFMediaSource* pMediaSource, ComPtr<TI0> pMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AttachMediaSource(ref pByteStream, pMediaSource, (IMFMediaSourceExtension*) pMSE.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, Span<IMFByteStream> pByteStream, IMFMediaSource* pMediaSource, Span<IMFMediaSourceExtension> pMSE)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AttachMediaSource(ref pByteStream.GetPinnableReference(), pMediaSource, ref pMSE.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, Span<IMFByteStream> pByteStream, Span<IMFMediaSource> pMediaSource, IMFMediaSourceExtension* pMSE)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AttachMediaSource(ref pByteStream.GetPinnableReference(), ref pMediaSource.GetPinnableReference(), pMSE);
    }

    /// <summary>To be documented.</summary>
    public static int AttachMediaSource<TI0>(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, ref IMFByteStream pByteStream, ref IMFMediaSource pMediaSource, ComPtr<TI0> pMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AttachMediaSource(ref pByteStream, ref pMediaSource, (IMFMediaSourceExtension*) pMSE.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AttachMediaSource(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl, Span<IMFByteStream> pByteStream, Span<IMFMediaSource> pMediaSource, Span<IMFMediaSourceExtension> pMSE)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AttachMediaSource(ref pByteStream.GetPinnableReference(), ref pMediaSource.GetPinnableReference(), ref pMSE.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineSupportsSourceTransfer> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
