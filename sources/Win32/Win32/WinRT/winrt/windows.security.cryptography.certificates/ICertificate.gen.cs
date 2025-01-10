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

[Guid("333F740C-04D8-43B3-B278-8C5FCC9BE5A0")]
[NativeTypeName("struct ICertificate : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificate : ICertificate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificate));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICertificate, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICertificate, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICertificate, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICertificate, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICertificate, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICertificate, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BuildChainAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *"
        )]
            IIterable<IntPtr>* certificates,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateChain_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<ICertificate, IIterable<IntPtr>*, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, certificates, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BuildChainWithParametersAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *"
        )]
            IIterable<IntPtr>* certificates,
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Certificates::IChainBuildingParameters *"
        )]
            IChainBuildingParameters parameters,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateChain_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                ICertificate,
                IIterable<IntPtr>*,
                IChainBuildingParameters,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, certificates, parameters, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SerialNumber([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged<ICertificate, uint*, byte**, int>)((*lpVtbl)[8]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetHashValue([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged<ICertificate, uint*, byte**, int>)((*lpVtbl)[9]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetHashValueWithAlgorithm(
        HSTRING hashAlgorithmName,
        [NativeTypeName("UINT32 *")] uint* valueLength,
        byte** value
    )
    {
        return ((delegate* unmanaged<ICertificate, HSTRING, uint*, byte**, int>)((*lpVtbl)[10]))(
            this,
            hashAlgorithmName,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCertificateBlob(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return ((delegate* unmanaged<ICertificate, IBuffer*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Subject(HSTRING* value)
    {
        return ((delegate* unmanaged<ICertificate, HSTRING*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Issuer(HSTRING* value)
    {
        return ((delegate* unmanaged<ICertificate, HSTRING*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_HasPrivateKey([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICertificate, byte*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsStronglyProtected([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICertificate, byte*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ValidFrom(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<ICertificate, WinRTDateTime*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ValidTo(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<ICertificate, WinRTDateTime*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_EnhancedKeyUsages(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
            IVectorView<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<ICertificate, IVectorView<HSTRING>**, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_FriendlyName(HSTRING value)
    {
        return ((delegate* unmanaged<ICertificate, HSTRING, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_FriendlyName(HSTRING* value)
    {
        return ((delegate* unmanaged<ICertificate, HSTRING*, int>)((*lpVtbl)[20]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT BuildChainAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *"
            )]
                IIterable<IntPtr>* certificates,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateChain_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT BuildChainWithParametersAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *"
            )]
                IIterable<IntPtr>* certificates,
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::IChainBuildingParameters *"
            )]
                IChainBuildingParameters parameters,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateChain_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(8)]
        HRESULT get_SerialNumber([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(9)]
        HRESULT GetHashValue([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(10)]
        HRESULT GetHashValueWithAlgorithm(
            HSTRING hashAlgorithmName,
            [NativeTypeName("UINT32 *")] uint* valueLength,
            byte** value
        );

        [VtblIndex(11)]
        HRESULT GetCertificateBlob(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(12)]
        HRESULT get_Subject(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Issuer(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_HasPrivateKey([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT get_IsStronglyProtected([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT get_ValidFrom(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(17)]
        HRESULT get_ValidTo(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(18)]
        HRESULT get_EnhancedKeyUsages(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
                IVectorView<HSTRING>** value
        );

        [VtblIndex(19)]
        HRESULT put_FriendlyName(HSTRING value);

        [VtblIndex(20)]
        HRESULT get_FriendlyName(HSTRING* value);
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateChain_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IAsyncOperation<IntPtr>**,
            int> BuildChainAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *, ABI::Windows::Security::Cryptography::Certificates::IChainBuildingParameters *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateChain_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IChainBuildingParameters,
            IAsyncOperation<IntPtr>**,
            int> BuildChainWithParametersAsync;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, byte**, int> get_SerialNumber;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, byte**, int> GetHashValue;

        [NativeTypeName("HRESULT (HSTRING, UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, uint*, byte**, int> GetHashValueWithAlgorithm;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> GetCertificateBlob;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Subject;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Issuer;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_HasPrivateKey;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsStronglyProtected;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_ValidFrom;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_ValidTo;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<HSTRING>**, int> get_EnhancedKeyUsages;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_FriendlyName;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICertificate"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICertificate(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICertificate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICertificate(Silk.NET.WinRT.IInspectable value)
    {
        return new ICertificate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificate"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificate"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICertificate value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICertificate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICertificate(Silk.NET.Windows.IUnknown value)
    {
        return new ICertificate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificate"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificate"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICertificate value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
