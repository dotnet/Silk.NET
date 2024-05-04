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

public unsafe static class WICDdsFrameDecodeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsFrameDecode> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsFrameDecode> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsFrameDecode> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsFrameDecode> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICDdsFrameDecode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICDdsFrameDecode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSizeInBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, uint* pWidthInBlocks, uint* pHeightInBlocks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pWidthInBlocks, pHeightInBlocks);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSizeInBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, uint* pWidthInBlocks, ref uint pHeightInBlocks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pHeightInBlocksPtr = &pHeightInBlocks)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pWidthInBlocks, pHeightInBlocksPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSizeInBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, ref uint pWidthInBlocks, uint* pHeightInBlocks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pWidthInBlocksPtr = &pWidthInBlocks)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pWidthInBlocksPtr, pHeightInBlocks);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSizeInBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, ref uint pWidthInBlocks, ref uint pHeightInBlocks)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pWidthInBlocksPtr = &pWidthInBlocks)
        {
            fixed (uint* pHeightInBlocksPtr = &pHeightInBlocks)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pWidthInBlocksPtr, pHeightInBlocksPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFormatInfo(this ComPtr<IWICDdsFrameDecode> thisVtbl, DdsFormatInfo* pFormatInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, DdsFormatInfo*, int>)@this->LpVtbl[4])(@this, pFormatInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFormatInfo(this ComPtr<IWICDdsFrameDecode> thisVtbl, ref DdsFormatInfo pFormatInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DdsFormatInfo* pFormatInfoPtr = &pFormatInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, DdsFormatInfo*, int>)@this->LpVtbl[4])(@this, pFormatInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[5])(@this, prcBoundsInBlocks, cbStride, cbBufferSize, pbBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBufferPtr = &pbBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[5])(@this, prcBoundsInBlocks, cbStride, cbBufferSize, pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[5])(@this, prcBoundsInBlocks, cbStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prcBoundsInBlocks, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocksPtr = &prcBoundsInBlocks)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[5])(@this, prcBoundsInBlocksPtr, cbStride, cbBufferSize, pbBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prcBoundsInBlocks, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocksPtr = &prcBoundsInBlocks)
        {
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[5])(@this, prcBoundsInBlocksPtr, cbStride, cbBufferSize, pbBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prcBoundsInBlocks, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocksPtr = &prcBoundsInBlocks)
        {
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[5])(@this, prcBoundsInBlocksPtr, cbStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICDdsFrameDecode> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsFrameDecode> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsFrameDecode> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSizeInBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, uint* pWidthInBlocks, Span<uint> pHeightInBlocks)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSizeInBlocks(pWidthInBlocks, ref pHeightInBlocks.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSizeInBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, Span<uint> pWidthInBlocks, uint* pHeightInBlocks)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSizeInBlocks(ref pWidthInBlocks.GetPinnableReference(), pHeightInBlocks);
    }

    /// <summary>To be documented.</summary>
    public static int GetSizeInBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, Span<uint> pWidthInBlocks, Span<uint> pHeightInBlocks)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSizeInBlocks(ref pWidthInBlocks.GetPinnableReference(), ref pHeightInBlocks.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFormatInfo(this ComPtr<IWICDdsFrameDecode> thisVtbl, Span<DdsFormatInfo> pFormatInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFormatInfo(ref pFormatInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyBlocks(prcBoundsInBlocks, cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prcBoundsInBlocks, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyBlocks(in prcBoundsInBlocks.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int CopyBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prcBoundsInBlocks, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyBlocks(in prcBoundsInBlocks.GetPinnableReference(), cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyBlocks(this ComPtr<IWICDdsFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prcBoundsInBlocks, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyBlocks(in prcBoundsInBlocks.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICDdsFrameDecode> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
