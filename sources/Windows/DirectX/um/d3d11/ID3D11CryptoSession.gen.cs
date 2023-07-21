// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D11CryptoSession.xml' path='doc/member[@name="ID3D11CryptoSession"]/*' />
[Guid("9B32F9AD-BDCC-40A6-A39D-D5C865845720")]
[NativeTypeName("struct ID3D11CryptoSession : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ID3D11CryptoSession : ID3D11CryptoSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11CryptoSession));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11CryptoSession*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11CryptoSession*, uint>)(lpVtbl[1]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11CryptoSession*, uint>)(lpVtbl[2]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device** ppDevice)
    {
        ((delegate* unmanaged<ID3D11CryptoSession*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11CryptoSession*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D11CryptoSession*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D11CryptoSession*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <include file='ID3D11CryptoSession.xml' path='doc/member[@name="ID3D11CryptoSession.GetCryptoType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetCryptoType(Guid* pCryptoType)
    {
        ((delegate* unmanaged<ID3D11CryptoSession*, Guid*, void>)(lpVtbl[7]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCryptoType);
    }

    /// <include file='ID3D11CryptoSession.xml' path='doc/member[@name="ID3D11CryptoSession.GetDecoderProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetDecoderProfile(Guid* pDecoderProfile)
    {
        ((delegate* unmanaged<ID3D11CryptoSession*, Guid*, void>)(lpVtbl[8]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pDecoderProfile);
    }

    /// <include file='ID3D11CryptoSession.xml' path='doc/member[@name="ID3D11CryptoSession.GetCertificateSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCertificateSize(uint* pCertificateSize)
    {
        return ((delegate* unmanaged<ID3D11CryptoSession*, uint*, int>)(lpVtbl[9]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCertificateSize);
    }

    /// <include file='ID3D11CryptoSession.xml' path='doc/member[@name="ID3D11CryptoSession.GetCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetCertificate(uint CertificateSize, byte* pCertificate)
    {
        return ((delegate* unmanaged<ID3D11CryptoSession*, uint, byte*, int>)(lpVtbl[10]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), CertificateSize, pCertificate);
    }

    /// <include file='ID3D11CryptoSession.xml' path='doc/member[@name="ID3D11CryptoSession.GetCryptoSessionHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void GetCryptoSessionHandle(HANDLE* pCryptoSessionHandle)
    {
        ((delegate* unmanaged<ID3D11CryptoSession*, HANDLE*, void>)(lpVtbl[11]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCryptoSessionHandle);
    }

    public interface Interface : ID3D11DeviceChild.Interface
    {
        [VtblIndex(7)]
        void GetCryptoType(Guid* pCryptoType);

        [VtblIndex(8)]
        void GetDecoderProfile(Guid* pDecoderProfile);

        [VtblIndex(9)]
        HRESULT GetCertificateSize(uint* pCertificateSize);

        [VtblIndex(10)]
        HRESULT GetCertificate(uint CertificateSize, byte* pCertificate);

        [VtblIndex(11)]
        void GetCryptoSessionHandle(HANDLE* pCryptoSessionHandle);
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

        [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Device**, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("void (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void> GetCryptoType;

        [NativeTypeName("void (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void> GetDecoderProfile;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCertificateSize;

        [NativeTypeName("HRESULT (UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> GetCertificate;

        [NativeTypeName("void (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, void> GetCryptoSessionHandle;
    }
}
