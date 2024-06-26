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

public unsafe static class WICImageEncoderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICImageEncoder> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICImageEncoder> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICImageEncoder> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICImageEncoder> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICImageEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICImageEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImage, pFrameEncode, pImageParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImage, pFrameEncode, pImageParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImage, pFrameEncodePtr, pImageParameters);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
        {
            fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImage, pFrameEncodePtr, pImageParametersPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImagePtr, pFrameEncode, pImageParameters);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
        {
            fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImagePtr, pFrameEncode, pImageParametersPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
        {
            fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImagePtr, pFrameEncodePtr, pImageParameters);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
        {
            fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
            {
                fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImagePtr, pFrameEncodePtr, pImageParametersPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImage, pFrameEncode, pImageParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImage, pFrameEncode, pImageParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImage, pFrameEncodePtr, pImageParameters);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
        {
            fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImage, pFrameEncodePtr, pImageParametersPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImagePtr, pFrameEncode, pImageParameters);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
        {
            fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImagePtr, pFrameEncode, pImageParametersPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
        {
            fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImagePtr, pFrameEncodePtr, pImageParameters);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
        {
            fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
            {
                fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImagePtr, pFrameEncodePtr, pImageParametersPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapEncoder* pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImage, pEncoder, pImageParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapEncoder* pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImage, pEncoder, pImageParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, ref IWICBitmapEncoder pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapEncoder* pEncoderPtr = &pEncoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImage, pEncoderPtr, pImageParameters);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, ref IWICBitmapEncoder pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapEncoder* pEncoderPtr = &pEncoder)
        {
            fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImage, pEncoderPtr, pImageParametersPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, IWICBitmapEncoder* pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImagePtr, pEncoder, pImageParameters);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, IWICBitmapEncoder* pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
        {
            fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImagePtr, pEncoder, pImageParametersPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, ref IWICBitmapEncoder pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
        {
            fixed (IWICBitmapEncoder* pEncoderPtr = &pEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImagePtr, pEncoderPtr, pImageParameters);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, ref IWICBitmapEncoder pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
        {
            fixed (IWICBitmapEncoder* pEncoderPtr = &pEncoder)
            {
                fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImagePtr, pEncoderPtr, pImageParametersPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICImageEncoder> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICImageEncoder> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteFrame(pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageParameters> pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrame(pImage, pFrameEncode, in pImageParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteFrame(pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, in pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, Span<IWICBitmapFrameEncode> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrame(pImage, ref pFrameEncode.GetPinnableReference(), pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, Span<IWICBitmapFrameEncode> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageParameters> pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrame(pImage, ref pFrameEncode.GetPinnableReference(), in pImageParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, Span<Silk.NET.Direct2D.ID2D1Image> pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrame(ref pImage.GetPinnableReference(), pFrameEncode, pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteFrame(ref pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, Span<Silk.NET.Direct2D.ID2D1Image> pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageParameters> pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrame(ref pImage.GetPinnableReference(), pFrameEncode, in pImageParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int WriteFrame<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteFrame(ref pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, in pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, Span<Silk.NET.Direct2D.ID2D1Image> pImage, Span<IWICBitmapFrameEncode> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrame(ref pImage.GetPinnableReference(), ref pFrameEncode.GetPinnableReference(), pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static int WriteFrame(this ComPtr<IWICImageEncoder> thisVtbl, Span<Silk.NET.Direct2D.ID2D1Image> pImage, Span<IWICBitmapFrameEncode> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageParameters> pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrame(ref pImage.GetPinnableReference(), ref pFrameEncode.GetPinnableReference(), in pImageParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteFrameThumbnail(pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageParameters> pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrameThumbnail(pImage, pFrameEncode, in pImageParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteFrameThumbnail(pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, in pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, Span<IWICBitmapFrameEncode> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrameThumbnail(pImage, ref pFrameEncode.GetPinnableReference(), pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, Span<IWICBitmapFrameEncode> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageParameters> pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrameThumbnail(pImage, ref pFrameEncode.GetPinnableReference(), in pImageParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Span<Silk.NET.Direct2D.ID2D1Image> pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrameThumbnail(ref pImage.GetPinnableReference(), pFrameEncode, pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteFrameThumbnail(ref pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Span<Silk.NET.Direct2D.ID2D1Image> pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageParameters> pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrameThumbnail(ref pImage.GetPinnableReference(), pFrameEncode, in pImageParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int WriteFrameThumbnail<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteFrameThumbnail(ref pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, in pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Span<Silk.NET.Direct2D.ID2D1Image> pImage, Span<IWICBitmapFrameEncode> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrameThumbnail(ref pImage.GetPinnableReference(), ref pFrameEncode.GetPinnableReference(), pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static int WriteFrameThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Span<Silk.NET.Direct2D.ID2D1Image> pImage, Span<IWICBitmapFrameEncode> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageParameters> pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteFrameThumbnail(ref pImage.GetPinnableReference(), ref pFrameEncode.GetPinnableReference(), in pImageParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, ComPtr<TI0> pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteThumbnail(pImage, (IWICBitmapEncoder*) pEncoder.Handle, pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapEncoder* pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageParameters> pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteThumbnail(pImage, pEncoder, in pImageParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, ComPtr<TI0> pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteThumbnail(pImage, (IWICBitmapEncoder*) pEncoder.Handle, in pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, Span<IWICBitmapEncoder> pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteThumbnail(pImage, ref pEncoder.GetPinnableReference(), pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Silk.NET.Direct2D.ID2D1Image* pImage, Span<IWICBitmapEncoder> pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageParameters> pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteThumbnail(pImage, ref pEncoder.GetPinnableReference(), in pImageParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Span<Silk.NET.Direct2D.ID2D1Image> pImage, IWICBitmapEncoder* pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteThumbnail(ref pImage.GetPinnableReference(), pEncoder, pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, ComPtr<TI0> pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteThumbnail(ref pImage, (IWICBitmapEncoder*) pEncoder.Handle, pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Span<Silk.NET.Direct2D.ID2D1Image> pImage, IWICBitmapEncoder* pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageParameters> pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteThumbnail(ref pImage.GetPinnableReference(), pEncoder, in pImageParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int WriteThumbnail<TI0>(this ComPtr<IWICImageEncoder> thisVtbl, ref Silk.NET.Direct2D.ID2D1Image pImage, ComPtr<TI0> pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteThumbnail(ref pImage, (IWICBitmapEncoder*) pEncoder.Handle, in pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Span<Silk.NET.Direct2D.ID2D1Image> pImage, Span<IWICBitmapEncoder> pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteThumbnail(ref pImage.GetPinnableReference(), ref pEncoder.GetPinnableReference(), pImageParameters);
    }

    /// <summary>To be documented.</summary>
    public static int WriteThumbnail(this ComPtr<IWICImageEncoder> thisVtbl, Span<Silk.NET.Direct2D.ID2D1Image> pImage, Span<IWICBitmapEncoder> pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageParameters> pImageParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteThumbnail(ref pImage.GetPinnableReference(), ref pEncoder.GetPinnableReference(), in pImageParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICImageEncoder> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
