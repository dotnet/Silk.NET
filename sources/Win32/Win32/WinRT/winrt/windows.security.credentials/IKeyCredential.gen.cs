// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("9585EF8D-457B-4847-B11A-FA960BBDB138")]
[NativeTypeName("struct IKeyCredential : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyCredential : IKeyCredential.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKeyCredential));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKeyCredential, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IKeyCredential, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKeyCredential, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IKeyCredential, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IKeyCredential, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IKeyCredential, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IKeyCredential, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RetrievePublicKeyWithDefaultBlobType(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return ((delegate* unmanaged<IKeyCredential, IBuffer*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RetrievePublicKeyWithBlobType(
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType"
        )]
            CryptographicPublicKeyBlobType blobType,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return (
            (delegate* unmanaged<IKeyCredential, CryptographicPublicKeyBlobType, IBuffer*, int>)(
                (*lpVtbl)[8]
            )
        )(this, blobType, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestSignAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialOperationResult_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IKeyCredential, IBuffer, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, data, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetAttestationAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialAttestationResult_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IKeyCredential, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[10])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT RetrievePublicKeyWithDefaultBlobType(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(8)]
        HRESULT RetrievePublicKeyWithBlobType(
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType"
            )]
                CryptographicPublicKeyBlobType blobType,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(9)]
        HRESULT RequestSignAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialOperationResult_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(10)]
        HRESULT GetAttestationAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialAttestationResult_t **"
            )]
                IAsyncOperation<IntPtr>** value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> RetrievePublicKeyWithDefaultBlobType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CryptographicPublicKeyBlobType,
            IBuffer*,
            int> RetrievePublicKeyWithBlobType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialOperationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            IAsyncOperation<IntPtr>**,
            int> RequestSignAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialAttestationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetAttestationAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IKeyCredential"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IKeyCredential(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IKeyCredential"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IKeyCredential(Silk.NET.WinRT.IInspectable value)
    {
        return new IKeyCredential(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKeyCredential"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IKeyCredential"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IKeyCredential value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IKeyCredential"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IKeyCredential(Silk.NET.Windows.IUnknown value)
    {
        return new IKeyCredential(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKeyCredential"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IKeyCredential"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IKeyCredential value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
