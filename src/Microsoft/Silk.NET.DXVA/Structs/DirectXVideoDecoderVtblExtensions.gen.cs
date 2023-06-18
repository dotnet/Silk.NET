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

public unsafe static class DirectXVideoDecoderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirectXVideoDecoder> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirectXVideoDecoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirectXVideoDecoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderService(this ComPtr<IDirectXVideoDecoder> thisVtbl, IDirectXVideoDecoderService** ppService)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, IDirectXVideoDecoderService**, int>)@this->LpVtbl[3])(@this, ppService);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters(this ComPtr<IDirectXVideoDecoder> thisVtbl, Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)@this->LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IDirectXVideoDecoder> thisVtbl, uint BufferType, void** ppBuffer, uint* pBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, void**, uint*, int>)@this->LpVtbl[5])(@this, BufferType, ppBuffer, pBufferSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseBuffer(this ComPtr<IDirectXVideoDecoder> thisVtbl, uint BufferType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint, int>)@this->LpVtbl[6])(@this, BufferType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginFrame(this ComPtr<IDirectXVideoDecoder> thisVtbl, Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, void* pvPVPData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)@this->LpVtbl[7])(@this, pRenderTarget, pvPVPData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndFrame(this ComPtr<IDirectXVideoDecoder> thisVtbl, void** pHandleComplete)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, void**, int>)@this->LpVtbl[8])(@this, pHandleComplete);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Execute(this ComPtr<IDirectXVideoDecoder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DXVA2DecodeExecuteParams* pExecuteParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, DXVA2DecodeExecuteParams*, int>)@this->LpVtbl[9])(@this, pExecuteParams);
        return ret;
    }

}
