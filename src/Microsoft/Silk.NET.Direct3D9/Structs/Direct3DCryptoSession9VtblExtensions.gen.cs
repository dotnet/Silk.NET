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

namespace Silk.NET.Direct3D9;

public unsafe static class Direct3DCryptoSession9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirect3DCryptoSession9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DCryptoSession9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCertificateSize(this ComPtr<IDirect3DCryptoSession9> thisVtbl, uint* pCertificateSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint*, int>)@this->LpVtbl[3])(@this, pCertificateSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCertificate(this ComPtr<IDirect3DCryptoSession9> thisVtbl, uint CertifacteSize, byte* ppCertificate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateKeyExchange(this ComPtr<IDirect3DCryptoSession9> thisVtbl, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, void*, int>)@this->LpVtbl[5])(@this, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, void* pIV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)@this->LpVtbl[6])(@this, pSrcSurface, pDstSurface, DstSurfaceSize, pIV);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSurfacePitch(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, uint* pSurfacePitch)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)@this->LpVtbl[8])(@this, pSrcSurface, pSurfacePitch);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StartSessionKeyRefresh(this ComPtr<IDirect3DCryptoSession9> thisVtbl, void* pRandomNumber, uint RandomNumberSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, void*, uint, int>)@this->LpVtbl[9])(@this, pRandomNumber, RandomNumberSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FinishSessionKeyRefresh(this ComPtr<IDirect3DCryptoSession9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, int>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncryptionBltKey(this ComPtr<IDirect3DCryptoSession9> thisVtbl, void* pReadbackKey, uint KeySize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, void*, uint, int>)@this->LpVtbl[11])(@this, pReadbackKey, KeySize);
        return ret;
    }

}
