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
    public static unsafe int QueryInterface(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static int GetCertificateSize(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref uint pCertificateSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCertificateSizePtr = &pCertificateSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint*, int>)@this->LpVtbl[3])(@this, pCertificateSizePtr);
        }
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
    public static int GetCertificate(this ComPtr<IDirect3DCryptoSession9> thisVtbl, uint CertifacteSize, ref byte ppCertificate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* ppCertificatePtr = &ppCertificate)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate(this ComPtr<IDirect3DCryptoSession9> thisVtbl, uint CertifacteSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ppCertificate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var ppCertificatePtr = (byte*) SilkMarshal.StringToPtr(ppCertificate, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
        SilkMarshal.Free((nint)ppCertificatePtr);
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
    public static int NegotiateKeyExchange<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, void*, int>)@this->LpVtbl[5])(@this, DataSize, pDataPtr);
        }
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
    public static unsafe int EncryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pIVPtr = &pIV)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)@this->LpVtbl[6])(@this, pSrcSurface, pDstSurface, DstSurfaceSize, pIVPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, void* pIV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)@this->LpVtbl[6])(@this, pSrcSurface, pDstSurfacePtr, DstSurfaceSize, pIV);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)@this->LpVtbl[6])(@this, pSrcSurface, pDstSurfacePtr, DstSurfaceSize, pIVPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, void* pIV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)@this->LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurface, DstSurfaceSize, pIV);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)@this->LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurface, DstSurfaceSize, pIVPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, void* pIV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)@this->LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurfacePtr, DstSurfaceSize, pIV);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EncryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)@this->LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurfacePtr, DstSurfaceSize, pIVPtr);
                }
            }
        }
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
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pIVPtr = &pIV)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pContentKeyPtr = &pContentKey)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pContentKeyPtr = &pContentKey)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
                        }
                    }
                }
            }
        }
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
    public static unsafe int GetSurfacePitch(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, ref uint pSurfacePitch)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pSurfacePitchPtr = &pSurfacePitch)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)@this->LpVtbl[8])(@this, pSrcSurface, pSurfacePitchPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSurfacePitch(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, uint* pSurfacePitch)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)@this->LpVtbl[8])(@this, pSrcSurfacePtr, pSurfacePitch);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSurfacePitch(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref uint pSurfacePitch)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (uint* pSurfacePitchPtr = &pSurfacePitch)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)@this->LpVtbl[8])(@this, pSrcSurfacePtr, pSurfacePitchPtr);
            }
        }
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
    public static int StartSessionKeyRefresh<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref T0 pRandomNumber, uint RandomNumberSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pRandomNumberPtr = &pRandomNumber)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, void*, uint, int>)@this->LpVtbl[9])(@this, pRandomNumberPtr, RandomNumberSize);
        }
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

    /// <summary>To be documented.</summary>
    public static int GetEncryptionBltKey<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref T0 pReadbackKey, uint KeySize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pReadbackKeyPtr = &pReadbackKey)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, void*, uint, int>)@this->LpVtbl[11])(@this, pReadbackKeyPtr, KeySize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificateSize(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<uint> pCertificateSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCertificateSize(ref pCertificateSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate(this ComPtr<IDirect3DCryptoSession9> thisVtbl, uint CertifacteSize, Span<byte> ppCertificate)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCertificate(CertifacteSize, ref ppCertificate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateKeyExchange<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->NegotiateKeyExchange(DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<TI0, TI1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, uint DstSurfaceSize, void* pIV) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EncryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, (IDirect3DSurface9*) pDstSurface.Handle, DstSurfaceSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, Span<T0> pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EncryptionBlt(pSrcSurface, pDstSurface, DstSurfaceSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EncryptionBlt<T0, TI0, TI1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EncryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, (IDirect3DSurface9*) pDstSurface.Handle, DstSurfaceSize, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint DstSurfaceSize, void* pIV)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EncryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), DstSurfaceSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, void* pIV) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EncryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, ref pDstSurface, DstSurfaceSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint DstSurfaceSize, Span<T0> pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EncryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), DstSurfaceSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EncryptionBlt<T0, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EncryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, ref pDstSurface, DstSurfaceSize, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, void* pIV)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EncryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, DstSurfaceSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ComPtr<TI0> pDstSurface, uint DstSurfaceSize, void* pIV) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EncryptionBlt(ref pSrcSurface, (IDirect3DSurface9*) pDstSurface.Handle, DstSurfaceSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, Span<T0> pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EncryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, DstSurfaceSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EncryptionBlt<T0, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ComPtr<TI0> pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EncryptionBlt(ref pSrcSurface, (IDirect3DSurface9*) pDstSurface.Handle, DstSurfaceSize, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint DstSurfaceSize, void* pIV)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EncryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), DstSurfaceSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static int EncryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint DstSurfaceSize, Span<T0> pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EncryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), DstSurfaceSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TI0, TI1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TI0, TI1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TI0, TI1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1, TI0, TI1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TI0, TI1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, ref pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TI0, TI1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, ref pEncryptedBlockInfo, pContentKey, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TI0, TI1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, ref pEncryptedBlockInfo, ref pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DecryptionBlt<T0, T1, TI0, TI1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, ref pEncryptedBlockInfo, ref pContentKey, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, ref pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, ref pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, ref pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, ref pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, ref pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, ref pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo, pContentKey, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, ref pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo, ref pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DecryptionBlt<T0, T1, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt((IDirect3DSurface9*) pSrcSurface.Handle, ref pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo, ref pContentKey, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ComPtr<TI0> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt(ref pSrcSurface, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ComPtr<TI0> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt(ref pSrcSurface, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ComPtr<TI0> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt(ref pSrcSurface, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ComPtr<TI0> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt(ref pSrcSurface, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ComPtr<TI0> pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt(ref pSrcSurface, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, ref pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ComPtr<TI0> pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt(ref pSrcSurface, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, ref pEncryptedBlockInfo, pContentKey, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ComPtr<TI0> pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt(ref pSrcSurface, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, ref pEncryptedBlockInfo, ref pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DecryptionBlt<T0, T1, TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ref IDirect3DSurface9 pSrcSurface, ComPtr<TI0> pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DecryptionBlt(ref pSrcSurface, (IDirect3DSurface9*) pDstSurface.Handle, SrcSurfaceSize, ref pEncryptedBlockInfo, ref pContentKey, ref pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static int DecryptionBlt<T0, T1>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSurfacePitch<TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, uint* pSurfacePitch) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSurfacePitch((IDirect3DSurface9*) pSrcSurface.Handle, pSurfacePitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSurfacePitch(this ComPtr<IDirect3DCryptoSession9> thisVtbl, IDirect3DSurface9* pSrcSurface, Span<uint> pSurfacePitch)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSurfacePitch(pSrcSurface, ref pSurfacePitch.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSurfacePitch<TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, ComPtr<TI0> pSrcSurface, ref uint pSurfacePitch) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSurfacePitch((IDirect3DSurface9*) pSrcSurface.Handle, ref pSurfacePitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSurfacePitch(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, uint* pSurfacePitch)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSurfacePitch(ref pSrcSurface.GetPinnableReference(), pSurfacePitch);
    }

    /// <summary>To be documented.</summary>
    public static int GetSurfacePitch(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<uint> pSurfacePitch)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSurfacePitch(ref pSrcSurface.GetPinnableReference(), ref pSurfacePitch.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int StartSessionKeyRefresh<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<T0> pRandomNumber, uint RandomNumberSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StartSessionKeyRefresh(ref pRandomNumber.GetPinnableReference(), RandomNumberSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetEncryptionBltKey<T0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl, Span<T0> pReadbackKey, uint KeySize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEncryptionBltKey(ref pReadbackKey.GetPinnableReference(), KeySize);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDirect3DCryptoSession9> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
