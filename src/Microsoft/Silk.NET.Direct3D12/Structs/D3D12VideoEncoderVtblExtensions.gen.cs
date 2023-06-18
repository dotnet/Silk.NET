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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12VideoEncoderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoEncoder> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12VideoEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12VideoEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoEncoder> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12VideoEncoder> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoEncoder> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12VideoEncoder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoEncoder> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNodeMask(this ComPtr<ID3D12VideoEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, uint>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static VideoEncoderFlags GetEncoderFlags(this ComPtr<ID3D12VideoEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        VideoEncoderFlags ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, VideoEncoderFlags>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static VideoEncoderCodec GetCodec(this ComPtr<ID3D12VideoEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        VideoEncoderCodec ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, VideoEncoderCodec>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCodecProfile(this ComPtr<ID3D12VideoEncoder> thisVtbl, VideoEncoderProfileDesc dstProfile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, VideoEncoderProfileDesc, int>)@this->LpVtbl[11])(@this, dstProfile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCodecConfiguration(this ComPtr<ID3D12VideoEncoder> thisVtbl, VideoEncoderCodecConfiguration dstCodecConfig)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, VideoEncoderCodecConfiguration, int>)@this->LpVtbl[12])(@this, dstCodecConfig);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.DXGI.Format GetInputFormat(this ComPtr<ID3D12VideoEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.DXGI.Format ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, Silk.NET.DXGI.Format>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static VideoEncoderMotionEstimationPrecisionMode GetMaxMotionEstimationPrecision(this ComPtr<ID3D12VideoEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        VideoEncoderMotionEstimationPrecisionMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoder*, VideoEncoderMotionEstimationPrecisionMode>)@this->LpVtbl[14])(@this);
        return ret;
    }

}
