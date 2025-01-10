// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C9FB1D83-789F-4B4E-9180-045A757AAC6D")]
[NativeTypeName("struct IUserCertificateStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserCertificateStore : IUserCertificateStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserCertificateStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserCertificateStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUserCertificateStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserCertificateStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IUserCertificateStore, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUserCertificateStore, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUserCertificateStore, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAddAsync(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")]
            ICertificate certificate,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IUserCertificateStore,
                ICertificate,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[6])
        )(this, certificate, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestDeleteAsync(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")]
            ICertificate certificate,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IUserCertificateStore,
                ICertificate,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[7])
        )(this, certificate, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IUserCertificateStore, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAddAsync(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")]
                ICertificate certificate,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(7)]
        HRESULT RequestDeleteAsync(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")]
                ICertificate certificate,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(8)]
        HRESULT get_Name(HSTRING* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICertificate,
            IAsyncOperation<byte>**,
            int> RequestAddAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICertificate,
            IAsyncOperation<byte>**,
            int> RequestDeleteAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUserCertificateStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUserCertificateStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUserCertificateStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUserCertificateStore(Silk.NET.WinRT.IInspectable value)
    {
        return new IUserCertificateStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserCertificateStore"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUserCertificateStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IUserCertificateStore value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUserCertificateStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUserCertificateStore(Silk.NET.Windows.IUnknown value)
    {
        return new IUserCertificateStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserCertificateStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUserCertificateStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUserCertificateStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
