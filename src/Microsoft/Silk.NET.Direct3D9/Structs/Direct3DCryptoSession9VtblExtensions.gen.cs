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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCertificateSize<TThis>(this TThis thisVtbl, uint* pCertificateSize) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint*, int>)@this->LpVtbl[3])(@this, pCertificateSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificateSize<TThis>(this TThis thisVtbl, ref uint pCertificateSize) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCertificateSizePtr = &pCertificateSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint*, int>)@this->LpVtbl[3])(@this, pCertificateSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCertificate<TThis>(this TThis thisVtbl, uint CertifacteSize, byte* ppCertificate) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate<TThis>(this TThis thisVtbl, uint CertifacteSize, ref byte ppCertificate) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* ppCertificatePtr = &ppCertificate)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate<TThis>(this TThis thisVtbl, uint CertifacteSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ppCertificate) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        var ppCertificatePtr = (byte*) SilkMarshal.StringToPtr(ppCertificate, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
        SilkMarshal.Free((nint)ppCertificatePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateKeyExchange<TThis>(this TThis thisVtbl, uint DataSize, void* pData) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, void*, int>)@this->LpVtbl[5])(@this, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateKeyExchange<T0, TThis>(this TThis thisVtbl, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, void*, int>)@this->LpVtbl[5])(@this, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)@this->LpVtbl[6])(@this, pSrcSurface, pDstSurface, DstSurfaceSize, pIV);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pIVPtr = &pIV)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)@this->LpVtbl[6])(@this, pSrcSurface, pDstSurface, DstSurfaceSize, pIVPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)@this->LpVtbl[6])(@this, pSrcSurface, pDstSurfacePtr, DstSurfaceSize, pIV);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int EncryptionBlt<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)@this->LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurface, DstSurfaceSize, pIV);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<T0, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int EncryptionBlt<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static int EncryptionBlt<T0, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pIVPtr = &pIV)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pContentKeyPtr = &pContentKey)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)@this->LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetSurfacePitch<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, uint* pSurfacePitch) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)@this->LpVtbl[8])(@this, pSrcSurface, pSurfacePitch);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSurfacePitch<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, ref uint pSurfacePitch) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pSurfacePitchPtr = &pSurfacePitch)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)@this->LpVtbl[8])(@this, pSrcSurface, pSurfacePitchPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSurfacePitch<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, uint* pSurfacePitch) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)@this->LpVtbl[8])(@this, pSrcSurfacePtr, pSurfacePitch);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSurfacePitch<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrcSurface, ref uint pSurfacePitch) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int StartSessionKeyRefresh<TThis>(this TThis thisVtbl, void* pRandomNumber, uint RandomNumberSize) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, void*, uint, int>)@this->LpVtbl[9])(@this, pRandomNumber, RandomNumberSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StartSessionKeyRefresh<T0, TThis>(this TThis thisVtbl, ref T0 pRandomNumber, uint RandomNumberSize) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pRandomNumberPtr = &pRandomNumber)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, void*, uint, int>)@this->LpVtbl[9])(@this, pRandomNumberPtr, RandomNumberSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FinishSessionKeyRefresh<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, int>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncryptionBltKey<TThis>(this TThis thisVtbl, void* pReadbackKey, uint KeySize) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, void*, uint, int>)@this->LpVtbl[11])(@this, pReadbackKey, KeySize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetEncryptionBltKey<T0, TThis>(this TThis thisVtbl, ref T0 pReadbackKey, uint KeySize) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pReadbackKeyPtr = &pReadbackKey)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, void*, uint, int>)@this->LpVtbl[11])(@this, pReadbackKeyPtr, KeySize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificateSize<TThis>(this TThis thisVtbl, Span<uint> pCertificateSize) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCertificateSize(ref pCertificateSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate<TThis>(this TThis thisVtbl, uint CertifacteSize, Span<byte> ppCertificate) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCertificate(CertifacteSize, ref ppCertificate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateKeyExchange<T0, TThis>(this TThis thisVtbl, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->NegotiateKeyExchange(DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EncryptionBlt(pSrcSurface, pDstSurface, DstSurfaceSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint DstSurfaceSize, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EncryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), DstSurfaceSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint DstSurfaceSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EncryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), DstSurfaceSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EncryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, DstSurfaceSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<T0, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EncryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, DstSurfaceSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EncryptionBlt<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint DstSurfaceSize, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EncryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), DstSurfaceSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static int EncryptionBlt<T0, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint DstSurfaceSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EncryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), DstSurfaceSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(pSrcSurface, ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), pDstSurface, SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, pEncryptedBlockInfo, ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, void* pIV) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, void* pContentKey, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), pContentKey, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, void* pIV) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), pIV);
    }

    /// <summary>To be documented.</summary>
    public static int DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<IDirect3DSurface9> pDstSurface, uint SrcSurfaceSize, Span<EncryptedBlockInfo> pEncryptedBlockInfo, Span<T0> pContentKey, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecryptionBlt(ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), SrcSurfaceSize, ref pEncryptedBlockInfo.GetPinnableReference(), ref pContentKey.GetPinnableReference(), ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSurfacePitch<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrcSurface, Span<uint> pSurfacePitch) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetSurfacePitch(pSrcSurface, ref pSurfacePitch.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSurfacePitch<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, uint* pSurfacePitch) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetSurfacePitch(ref pSrcSurface.GetPinnableReference(), pSurfacePitch);
    }

    /// <summary>To be documented.</summary>
    public static int GetSurfacePitch<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrcSurface, Span<uint> pSurfacePitch) where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetSurfacePitch(ref pSrcSurface.GetPinnableReference(), ref pSurfacePitch.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int StartSessionKeyRefresh<T0, TThis>(this TThis thisVtbl, Span<T0> pRandomNumber, uint RandomNumberSize) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StartSessionKeyRefresh(ref pRandomNumber.GetPinnableReference(), RandomNumberSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetEncryptionBltKey<T0, TThis>(this TThis thisVtbl, Span<T0> pReadbackKey, uint KeySize) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetEncryptionBltKey(ref pReadbackKey.GetPinnableReference(), KeySize);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDirect3DCryptoSession9>
    {
        var @this = (IDirect3DCryptoSession9*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
