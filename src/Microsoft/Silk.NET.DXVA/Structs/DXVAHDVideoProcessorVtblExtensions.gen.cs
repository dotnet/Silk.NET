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

namespace Silk.NET.DXVA;

public unsafe static class DXVAHDVideoProcessorVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXVAHDVideoProcessor> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXVAHDVideoProcessor> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVideoProcessBltState(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, HDBltState State, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, HDBltState, uint, void*, int>)@this->LpVtbl[3])(@this, State, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVideoProcessBltState<T0>(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, HDBltState State, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, HDBltState, uint, void*, int>)@this->LpVtbl[3])(@this, State, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessBltState(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, HDBltState State, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, HDBltState, uint, void*, int>)@this->LpVtbl[4])(@this, State, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessBltState<T0>(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, HDBltState State, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, HDBltState, uint, void*, int>)@this->LpVtbl[4])(@this, State, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVideoProcessStreamState(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, void*, int>)@this->LpVtbl[5])(@this, StreamNumber, State, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVideoProcessStreamState<T0>(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, void*, int>)@this->LpVtbl[5])(@this, StreamNumber, State, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessStreamState(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, void*, int>)@this->LpVtbl[6])(@this, StreamNumber, State, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessStreamState<T0>(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, void*, int>)@this->LpVtbl[6])(@this, StreamNumber, State, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBltHD(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurface, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HDStreamData* pStreams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>)@this->LpVtbl[7])(@this, pOutputSurface, OutputFrame, StreamCount, pStreams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBltHD(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurface, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HDStreamData pStreams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HDStreamData* pStreamsPtr = &pStreams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>)@this->LpVtbl[7])(@this, pOutputSurface, OutputFrame, StreamCount, pStreamsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBltHD(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pOutputSurface, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HDStreamData* pStreams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurfacePtr = &pOutputSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>)@this->LpVtbl[7])(@this, pOutputSurfacePtr, OutputFrame, StreamCount, pStreams);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessBltHD(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pOutputSurface, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HDStreamData pStreams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurfacePtr = &pOutputSurface)
        {
            fixed (HDStreamData* pStreamsPtr = &pStreams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>)@this->LpVtbl[7])(@this, pOutputSurfacePtr, OutputFrame, StreamCount, pStreamsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetVideoProcessBltState<T0>(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, HDBltState State, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVideoProcessBltState(State, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessBltState<T0>(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, HDBltState State, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoProcessBltState(State, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetVideoProcessStreamState<T0>(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVideoProcessStreamState(StreamNumber, State, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessStreamState<T0>(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoProcessStreamState(StreamNumber, State, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBltHD(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurface, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HDStreamData> pStreams)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->VideoProcessBltHD(pOutputSurface, OutputFrame, StreamCount, in pStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBltHD(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pOutputSurface, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HDStreamData* pStreams)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->VideoProcessBltHD(ref pOutputSurface.GetPinnableReference(), OutputFrame, StreamCount, pStreams);
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessBltHD(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pOutputSurface, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HDStreamData> pStreams)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->VideoProcessBltHD(ref pOutputSurface.GetPinnableReference(), OutputFrame, StreamCount, in pStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDXVAHDVideoProcessor> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
