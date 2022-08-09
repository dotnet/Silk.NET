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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVideoProcessBltState<TThis>(this TThis thisVtbl, HDBltState State, uint DataSize, void* pData) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, HDBltState, uint, void*, int>)@this->LpVtbl[3])(@this, State, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVideoProcessBltState<T0, TThis>(this TThis thisVtbl, HDBltState State, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, HDBltState, uint, void*, int>)@this->LpVtbl[3])(@this, State, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessBltState<TThis>(this TThis thisVtbl, HDBltState State, uint DataSize, void* pData) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, HDBltState, uint, void*, int>)@this->LpVtbl[4])(@this, State, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessBltState<T0, TThis>(this TThis thisVtbl, HDBltState State, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, HDBltState, uint, void*, int>)@this->LpVtbl[4])(@this, State, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVideoProcessStreamState<TThis>(this TThis thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, void* pData) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, void*, int>)@this->LpVtbl[5])(@this, StreamNumber, State, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVideoProcessStreamState<T0, TThis>(this TThis thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, void*, int>)@this->LpVtbl[5])(@this, StreamNumber, State, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessStreamState<TThis>(this TThis thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, void* pData) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, void*, int>)@this->LpVtbl[6])(@this, StreamNumber, State, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessStreamState<T0, TThis>(this TThis thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, void*, int>)@this->LpVtbl[6])(@this, StreamNumber, State, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBltHD<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurface, uint OutputFrame, uint StreamCount, HDStreamData* pStreams) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>)@this->LpVtbl[7])(@this, pOutputSurface, OutputFrame, StreamCount, pStreams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBltHD<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurface, uint OutputFrame, uint StreamCount, ref HDStreamData pStreams) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HDStreamData* pStreamsPtr = &pStreams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>)@this->LpVtbl[7])(@this, pOutputSurface, OutputFrame, StreamCount, pStreamsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBltHD<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pOutputSurface, uint OutputFrame, uint StreamCount, HDStreamData* pStreams) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurfacePtr = &pOutputSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>)@this->LpVtbl[7])(@this, pOutputSurfacePtr, OutputFrame, StreamCount, pStreams);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessBltHD<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DSurface9 pOutputSurface, uint OutputFrame, uint StreamCount, ref HDStreamData pStreams) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
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
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetVideoProcessBltState<T0, TThis>(this TThis thisVtbl, HDBltState State, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetVideoProcessBltState(State, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessBltState<T0, TThis>(this TThis thisVtbl, HDBltState State, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoProcessBltState(State, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetVideoProcessStreamState<T0, TThis>(this TThis thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetVideoProcessStreamState(StreamNumber, State, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessStreamState<T0, TThis>(this TThis thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoProcessStreamState(StreamNumber, State, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBltHD<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurface, uint OutputFrame, uint StreamCount, Span<HDStreamData> pStreams) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBltHD(pOutputSurface, OutputFrame, StreamCount, ref pStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessBltHD<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pOutputSurface, uint OutputFrame, uint StreamCount, HDStreamData* pStreams) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBltHD(ref pOutputSurface.GetPinnableReference(), OutputFrame, StreamCount, pStreams);
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessBltHD<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DSurface9> pOutputSurface, uint OutputFrame, uint StreamCount, Span<HDStreamData> pStreams) where TThis : IComVtbl<IDXVAHDVideoProcessor>
    {
        var @this = (IDXVAHDVideoProcessor*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessBltHD(ref pOutputSurface.GetPinnableReference(), OutputFrame, StreamCount, ref pStreams.GetPinnableReference());
    }

}
