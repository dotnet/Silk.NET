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
    public static unsafe int GetVideoProcessBltState(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, HDBltState State, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, HDBltState, uint, void*, int>)@this->LpVtbl[4])(@this, State, DataSize, pData);
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
    public static unsafe int GetVideoProcessStreamState(this ComPtr<IDXVAHDVideoProcessor> thisVtbl, uint StreamNumber, HDStreamState State, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, void*, int>)@this->LpVtbl[6])(@this, StreamNumber, State, DataSize, pData);
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

}
