// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("FA0AB799-7A9C-48CA-8C5B-237E71A54434")]
[NativeTypeName("struct IDirect3DCryptoSession9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DCryptoSession9
    : IDirect3DCryptoSession9.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DCryptoSession9));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirect3DCryptoSession9, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirect3DCryptoSession9, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirect3DCryptoSession9, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCertificateSize(uint* pCertificateSize)
    {
        return ((delegate* unmanaged<IDirect3DCryptoSession9, uint*, int>)((*lpVtbl)[3]))(
            this,
            pCertificateSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCertificate(uint CertifacteSize, byte* ppCertificate)
    {
        return ((delegate* unmanaged<IDirect3DCryptoSession9, uint, byte*, int>)((*lpVtbl)[4]))(
            this,
            CertifacteSize,
            ppCertificate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT NegotiateKeyExchange(uint DataSize, void* pData)
    {
        return ((delegate* unmanaged<IDirect3DCryptoSession9, uint, void*, int>)((*lpVtbl)[5]))(
            this,
            DataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EncryptionBlt(
        IDirect3DSurface9 pSrcSurface,
        IDirect3DSurface9 pDstSurface,
        uint DstSurfaceSize,
        void* pIV
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DCryptoSession9,
                IDirect3DSurface9,
                IDirect3DSurface9,
                uint,
                void*,
                int>)((*lpVtbl)[6])
        )(this, pSrcSurface, pDstSurface, DstSurfaceSize, pIV);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DecryptionBlt(
        IDirect3DSurface9 pSrcSurface,
        IDirect3DSurface9 pDstSurface,
        uint SrcSurfaceSize,
        D3DENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo,
        void* pContentKey,
        void* pIV
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DCryptoSession9,
                IDirect3DSurface9,
                IDirect3DSurface9,
                uint,
                D3DENCRYPTED_BLOCK_INFO*,
                void*,
                void*,
                int>)((*lpVtbl)[7])
        )(this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSurfacePitch(IDirect3DSurface9 pSrcSurface, uint* pSurfacePitch)
    {
        return (
            (delegate* unmanaged<IDirect3DCryptoSession9, IDirect3DSurface9, uint*, int>)(
                (*lpVtbl)[8]
            )
        )(this, pSrcSurface, pSurfacePitch);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartSessionKeyRefresh(void* pRandomNumber, uint RandomNumberSize)
    {
        return ((delegate* unmanaged<IDirect3DCryptoSession9, void*, uint, int>)((*lpVtbl)[9]))(
            this,
            pRandomNumber,
            RandomNumberSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FinishSessionKeyRefresh()
    {
        return ((delegate* unmanaged<IDirect3DCryptoSession9, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetEncryptionBltKey(void* pReadbackKey, uint KeySize)
    {
        return ((delegate* unmanaged<IDirect3DCryptoSession9, void*, uint, int>)((*lpVtbl)[11]))(
            this,
            pReadbackKey,
            KeySize
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCertificateSize(uint* pCertificateSize);

        [VtblIndex(4)]
        HRESULT GetCertificate(uint CertifacteSize, byte* ppCertificate);

        [VtblIndex(5)]
        HRESULT NegotiateKeyExchange(uint DataSize, void* pData);

        [VtblIndex(6)]
        HRESULT EncryptionBlt(
            IDirect3DSurface9 pSrcSurface,
            IDirect3DSurface9 pDstSurface,
            uint DstSurfaceSize,
            void* pIV
        );

        [VtblIndex(7)]
        HRESULT DecryptionBlt(
            IDirect3DSurface9 pSrcSurface,
            IDirect3DSurface9 pDstSurface,
            uint SrcSurfaceSize,
            D3DENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo,
            void* pContentKey,
            void* pIV
        );

        [VtblIndex(8)]
        HRESULT GetSurfacePitch(IDirect3DSurface9 pSrcSurface, uint* pSurfacePitch);

        [VtblIndex(9)]
        HRESULT StartSessionKeyRefresh(void* pRandomNumber, uint RandomNumberSize);

        [VtblIndex(10)]
        HRESULT FinishSessionKeyRefresh();

        [VtblIndex(11)]
        HRESULT GetEncryptionBltKey(void* pReadbackKey, uint KeySize);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCertificateSize;

        [NativeTypeName("HRESULT (UINT, BYTE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> GetCertificate;

        [NativeTypeName("HRESULT (UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, int> NegotiateKeyExchange;

        [NativeTypeName(
            "HRESULT (IDirect3DSurface9 *, IDirect3DSurface9 *, UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirect3DSurface9,
            IDirect3DSurface9,
            uint,
            void*,
            int> EncryptionBlt;

        [NativeTypeName(
            "HRESULT (IDirect3DSurface9 *, IDirect3DSurface9 *, UINT, D3DENCRYPTED_BLOCK_INFO *, void *, void *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirect3DSurface9,
            IDirect3DSurface9,
            uint,
            D3DENCRYPTED_BLOCK_INFO*,
            void*,
            void*,
            int> DecryptionBlt;

        [NativeTypeName(
            "HRESULT (IDirect3DSurface9 *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DSurface9, uint*, int> GetSurfacePitch;

        [NativeTypeName("HRESULT (void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, int> StartSessionKeyRefresh;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FinishSessionKeyRefresh;

        [NativeTypeName("HRESULT (void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, int> GetEncryptionBltKey;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DCryptoSession9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DCryptoSession9(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirect3DCryptoSession9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirect3DCryptoSession9(Silk.NET.Windows.IUnknown value)
    {
        return new IDirect3DCryptoSession9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DCryptoSession9"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DCryptoSession9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirect3DCryptoSession9 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
