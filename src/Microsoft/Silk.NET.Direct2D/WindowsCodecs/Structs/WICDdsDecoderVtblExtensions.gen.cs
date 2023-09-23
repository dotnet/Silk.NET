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

public unsafe static class WICDdsDecoderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsDecoder> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsDecoder> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsDecoder> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsDecoder> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICDdsDecoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICDdsDecoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParameters(this ComPtr<IWICDdsDecoder> thisVtbl, DdsParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, DdsParameters*, int>)@this->LpVtbl[3])(@this, pParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetParameters(this ComPtr<IWICDdsDecoder> thisVtbl, ref DdsParameters pParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DdsParameters* pParametersPtr = &pParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, DdsParameters*, int>)@this->LpVtbl[3])(@this, pParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrame(this ComPtr<IWICDdsDecoder> thisVtbl, uint arrayIndex, uint mipLevel, uint sliceIndex, IWICBitmapFrameDecode** ppIBitmapFrame)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, uint, uint, uint, IWICBitmapFrameDecode**, int>)@this->LpVtbl[4])(@this, arrayIndex, mipLevel, sliceIndex, ppIBitmapFrame);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrame(this ComPtr<IWICDdsDecoder> thisVtbl, uint arrayIndex, uint mipLevel, uint sliceIndex, ref IWICBitmapFrameDecode* ppIBitmapFrame)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameDecode** ppIBitmapFramePtr = &ppIBitmapFrame)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, uint, uint, uint, IWICBitmapFrameDecode**, int>)@this->LpVtbl[4])(@this, arrayIndex, mipLevel, sliceIndex, ppIBitmapFramePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICDdsDecoder> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsDecoder> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsDecoder> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetParameters(this ComPtr<IWICDdsDecoder> thisVtbl, Span<DdsParameters> pParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParameters(ref pParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFrame<TI0>(this ComPtr<IWICDdsDecoder> thisVtbl, uint arrayIndex, uint mipLevel, uint sliceIndex, ref ComPtr<TI0> ppIBitmapFrame) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameDecode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFrame(arrayIndex, mipLevel, sliceIndex, (IWICBitmapFrameDecode**) ppIBitmapFrame.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICDdsDecoder> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
