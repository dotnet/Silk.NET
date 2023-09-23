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

public unsafe static class WICDdsEncoderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsEncoder> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsEncoder> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsEncoder> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsEncoder> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICDdsEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICDdsEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetParameters(this ComPtr<IWICDdsEncoder> thisVtbl, DdsParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, DdsParameters*, int>)@this->LpVtbl[3])(@this, pParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetParameters(this ComPtr<IWICDdsEncoder> thisVtbl, ref DdsParameters pParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DdsParameters* pParametersPtr = &pParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, DdsParameters*, int>)@this->LpVtbl[3])(@this, pParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParameters(this ComPtr<IWICDdsEncoder> thisVtbl, DdsParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, DdsParameters*, int>)@this->LpVtbl[4])(@this, pParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetParameters(this ComPtr<IWICDdsEncoder> thisVtbl, ref DdsParameters pParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DdsParameters* pParametersPtr = &pParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, DdsParameters*, int>)@this->LpVtbl[4])(@this, pParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, ref uint pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pSliceIndexPtr = &pSliceIndex)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndexPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, ref uint pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMipLevelPtr = &pMipLevel)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndex, pMipLevelPtr, pSliceIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, ref uint pMipLevel, ref uint pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMipLevelPtr = &pMipLevel)
        {
            fixed (uint* pSliceIndexPtr = &pSliceIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndex, pMipLevelPtr, pSliceIndexPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, ref uint pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pArrayIndexPtr = &pArrayIndex)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndexPtr, pMipLevel, pSliceIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, ref uint pArrayIndex, uint* pMipLevel, ref uint pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pArrayIndexPtr = &pArrayIndex)
        {
            fixed (uint* pSliceIndexPtr = &pSliceIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndexPtr, pMipLevel, pSliceIndexPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, ref uint pArrayIndex, ref uint pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pArrayIndexPtr = &pArrayIndex)
        {
            fixed (uint* pMipLevelPtr = &pMipLevel)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndexPtr, pMipLevelPtr, pSliceIndex);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, ref uint pArrayIndex, ref uint pMipLevel, ref uint pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pArrayIndexPtr = &pArrayIndex)
        {
            fixed (uint* pMipLevelPtr = &pMipLevel)
            {
                fixed (uint* pSliceIndexPtr = &pSliceIndex)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndexPtr, pMipLevelPtr, pSliceIndexPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndex, pMipLevel, pSliceIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, ref uint pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
        {
            fixed (uint* pSliceIndexPtr = &pSliceIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndex, pMipLevel, pSliceIndexPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, uint* pArrayIndex, ref uint pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
        {
            fixed (uint* pMipLevelPtr = &pMipLevel)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndex, pMipLevelPtr, pSliceIndex);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, uint* pArrayIndex, ref uint pMipLevel, ref uint pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
        {
            fixed (uint* pMipLevelPtr = &pMipLevel)
            {
                fixed (uint* pSliceIndexPtr = &pSliceIndex)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndex, pMipLevelPtr, pSliceIndexPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, ref uint pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
        {
            fixed (uint* pArrayIndexPtr = &pArrayIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndexPtr, pMipLevel, pSliceIndex);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, ref uint pArrayIndex, uint* pMipLevel, ref uint pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
        {
            fixed (uint* pArrayIndexPtr = &pArrayIndex)
            {
                fixed (uint* pSliceIndexPtr = &pSliceIndex)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndexPtr, pMipLevel, pSliceIndexPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, ref uint pArrayIndex, ref uint pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
        {
            fixed (uint* pArrayIndexPtr = &pArrayIndex)
            {
                fixed (uint* pMipLevelPtr = &pMipLevel)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndexPtr, pMipLevelPtr, pSliceIndex);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, ref uint pArrayIndex, ref uint pMipLevel, ref uint pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
        {
            fixed (uint* pArrayIndexPtr = &pArrayIndex)
            {
                fixed (uint* pMipLevelPtr = &pMipLevel)
                {
                    fixed (uint* pSliceIndexPtr = &pSliceIndex)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndexPtr, pMipLevelPtr, pSliceIndexPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICDdsEncoder> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsEncoder> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDdsEncoder> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetParameters(this ComPtr<IWICDdsEncoder> thisVtbl, Span<DdsParameters> pParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetParameters(ref pParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParameters(this ComPtr<IWICDdsEncoder> thisVtbl, Span<DdsParameters> pParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParameters(ref pParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame<TI0>(this ComPtr<IWICDdsEncoder> thisVtbl, ref ComPtr<TI0> ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), pArrayIndex, pMipLevel, pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, Span<uint> pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ppIFrameEncode, pArrayIndex, pMipLevel, ref pSliceIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame<TI0>(this ComPtr<IWICDdsEncoder> thisVtbl, ref ComPtr<TI0> ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, ref uint pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), pArrayIndex, pMipLevel, ref pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, Span<uint> pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ppIFrameEncode, pArrayIndex, ref pMipLevel.GetPinnableReference(), pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame<TI0>(this ComPtr<IWICDdsEncoder> thisVtbl, ref ComPtr<TI0> ppIFrameEncode, uint* pArrayIndex, ref uint pMipLevel, uint* pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), pArrayIndex, ref pMipLevel, pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, Span<uint> pMipLevel, Span<uint> pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ppIFrameEncode, pArrayIndex, ref pMipLevel.GetPinnableReference(), ref pSliceIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame<TI0>(this ComPtr<IWICDdsEncoder> thisVtbl, ref ComPtr<TI0> ppIFrameEncode, uint* pArrayIndex, ref uint pMipLevel, ref uint pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), pArrayIndex, ref pMipLevel, ref pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, Span<uint> pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ppIFrameEncode, ref pArrayIndex.GetPinnableReference(), pMipLevel, pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame<TI0>(this ComPtr<IWICDdsEncoder> thisVtbl, ref ComPtr<TI0> ppIFrameEncode, ref uint pArrayIndex, uint* pMipLevel, uint* pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), ref pArrayIndex, pMipLevel, pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, Span<uint> pArrayIndex, uint* pMipLevel, Span<uint> pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ppIFrameEncode, ref pArrayIndex.GetPinnableReference(), pMipLevel, ref pSliceIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame<TI0>(this ComPtr<IWICDdsEncoder> thisVtbl, ref ComPtr<TI0> ppIFrameEncode, ref uint pArrayIndex, uint* pMipLevel, ref uint pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), ref pArrayIndex, pMipLevel, ref pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, Span<uint> pArrayIndex, Span<uint> pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ppIFrameEncode, ref pArrayIndex.GetPinnableReference(), ref pMipLevel.GetPinnableReference(), pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame<TI0>(this ComPtr<IWICDdsEncoder> thisVtbl, ref ComPtr<TI0> ppIFrameEncode, ref uint pArrayIndex, ref uint pMipLevel, uint* pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), ref pArrayIndex, ref pMipLevel, pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, Span<uint> pArrayIndex, Span<uint> pMipLevel, Span<uint> pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ppIFrameEncode, ref pArrayIndex.GetPinnableReference(), ref pMipLevel.GetPinnableReference(), ref pSliceIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateNewFrame<TI0>(this ComPtr<IWICDdsEncoder> thisVtbl, ref ComPtr<TI0> ppIFrameEncode, ref uint pArrayIndex, ref uint pMipLevel, ref uint pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), ref pArrayIndex, ref pMipLevel, ref pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, Span<uint> pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ref ppIFrameEncode, pArrayIndex, pMipLevel, ref pSliceIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, uint* pArrayIndex, Span<uint> pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ref ppIFrameEncode, pArrayIndex, ref pMipLevel.GetPinnableReference(), pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, uint* pArrayIndex, Span<uint> pMipLevel, Span<uint> pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ref ppIFrameEncode, pArrayIndex, ref pMipLevel.GetPinnableReference(), ref pSliceIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, Span<uint> pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ref ppIFrameEncode, ref pArrayIndex.GetPinnableReference(), pMipLevel, pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, Span<uint> pArrayIndex, uint* pMipLevel, Span<uint> pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ref ppIFrameEncode, ref pArrayIndex.GetPinnableReference(), pMipLevel, ref pSliceIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, Span<uint> pArrayIndex, Span<uint> pMipLevel, uint* pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ref ppIFrameEncode, ref pArrayIndex.GetPinnableReference(), ref pMipLevel.GetPinnableReference(), pSliceIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICDdsEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, Span<uint> pArrayIndex, Span<uint> pMipLevel, Span<uint> pSliceIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNewFrame(ref ppIFrameEncode, ref pArrayIndex.GetPinnableReference(), ref pMipLevel.GetPinnableReference(), ref pSliceIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICDdsEncoder> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
