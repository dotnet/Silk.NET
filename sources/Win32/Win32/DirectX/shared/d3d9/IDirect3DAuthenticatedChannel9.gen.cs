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

[Guid("FF24BEEE-DA21-4BEB-98B5-D2F899F98AF9")]
[NativeTypeName("struct IDirect3DAuthenticatedChannel9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DAuthenticatedChannel9
    : IDirect3DAuthenticatedChannel9.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DAuthenticatedChannel9));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirect3DAuthenticatedChannel9, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCertificateSize(uint* pCertificateSize)
    {
        return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9, uint*, int>)((*lpVtbl)[3]))(
            this,
            pCertificateSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCertificate(uint CertifacteSize, byte* ppCertificate)
    {
        return (
            (delegate* unmanaged<IDirect3DAuthenticatedChannel9, uint, byte*, int>)((*lpVtbl)[4])
        )(this, CertifacteSize, ppCertificate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT NegotiateKeyExchange(uint DataSize, void* pData)
    {
        return (
            (delegate* unmanaged<IDirect3DAuthenticatedChannel9, uint, void*, int>)((*lpVtbl)[5])
        )(this, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Query(
        uint InputSize,
        [NativeTypeName("const void *")] void* pInput,
        uint OutputSize,
        void* pOutput
    )
    {
        return (
            (delegate* unmanaged<IDirect3DAuthenticatedChannel9, uint, void*, uint, void*, int>)(
                (*lpVtbl)[6]
            )
        )(this, InputSize, pInput, OutputSize, pOutput);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Configure(
        uint InputSize,
        [NativeTypeName("const void *")] void* pInput,
        D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT* pOutput
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DAuthenticatedChannel9,
                uint,
                void*,
                D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT*,
                int>)((*lpVtbl)[7])
        )(this, InputSize, pInput, pOutput);
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
        HRESULT Query(
            uint InputSize,
            [NativeTypeName("const void *")] void* pInput,
            uint OutputSize,
            void* pOutput
        );

        [VtblIndex(7)]
        HRESULT Configure(
            uint InputSize,
            [NativeTypeName("const void *")] void* pInput,
            D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT* pOutput
        );
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
            "HRESULT (UINT, const void *, UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, void*, uint, void*, int> Query;

        [NativeTypeName(
            "HRESULT (UINT, const void *, D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            void*,
            D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT*,
            int> Configure;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DAuthenticatedChannel9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DAuthenticatedChannel9(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirect3DAuthenticatedChannel9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirect3DAuthenticatedChannel9(Silk.NET.Windows.IUnknown value)
    {
        return new IDirect3DAuthenticatedChannel9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DAuthenticatedChannel9"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DAuthenticatedChannel9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirect3DAuthenticatedChannel9 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
