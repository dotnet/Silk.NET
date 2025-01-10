// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FFEFFE48-022A-4AB7-8B36-E10AF4640E6B")]
[NativeTypeName("struct IWebSocketServerCustomValidationRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebSocketServerCustomValidationRequestedEventArgs
    : IWebSocketServerCustomValidationRequestedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IWebSocketServerCustomValidationRequestedEventArgs)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IWebSocketServerCustomValidationRequestedEventArgs,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IWebSocketServerCustomValidationRequestedEventArgs, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IWebSocketServerCustomValidationRequestedEventArgs, uint>)(
                (*lpVtbl)[2]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<
                IWebSocketServerCustomValidationRequestedEventArgs,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<
                IWebSocketServerCustomValidationRequestedEventArgs,
                HSTRING*,
                int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<
                IWebSocketServerCustomValidationRequestedEventArgs,
                TrustLevel*,
                int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ServerCertificate(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")]
            ICertificate* value
    )
    {
        return (
            (delegate* unmanaged<
                IWebSocketServerCustomValidationRequestedEventArgs,
                ICertificate*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ServerCertificateErrorSeverity(
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketSslErrorSeverity *")]
            SocketSslErrorSeverity* value
    )
    {
        return (
            (delegate* unmanaged<
                IWebSocketServerCustomValidationRequestedEventArgs,
                SocketSslErrorSeverity*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ServerCertificateErrors(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CChainValidationResult_t **"
        )]
            IVectorView<ChainValidationResult>** value
    )
    {
        return (
            (delegate* unmanaged<
                IWebSocketServerCustomValidationRequestedEventArgs,
                IVectorView<ChainValidationResult>**,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ServerIntermediateCertificates(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IWebSocketServerCustomValidationRequestedEventArgs,
                IVectorView<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Reject()
    {
        return (
            (delegate* unmanaged<IWebSocketServerCustomValidationRequestedEventArgs, int>)(
                (*lpVtbl)[10]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* result
    )
    {
        return (
            (delegate* unmanaged<
                IWebSocketServerCustomValidationRequestedEventArgs,
                IDeferral*,
                int>)((*lpVtbl)[11])
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ServerCertificate(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")]
                ICertificate* value
        );

        [VtblIndex(7)]
        HRESULT get_ServerCertificateErrorSeverity(
            [NativeTypeName("ABI::Windows::Networking::Sockets::SocketSslErrorSeverity *")]
                SocketSslErrorSeverity* value
        );

        [VtblIndex(8)]
        HRESULT get_ServerCertificateErrors(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CChainValidationResult_t **"
            )]
                IVectorView<ChainValidationResult>** value
        );

        [VtblIndex(9)]
        HRESULT get_ServerIntermediateCertificates(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(10)]
        HRESULT Reject();

        [VtblIndex(11)]
        HRESULT GetDeferral(
            [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* result
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICertificate*, int> get_ServerCertificate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::SocketSslErrorSeverity *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SocketSslErrorSeverity*,
            int> get_ServerCertificateErrorSeverity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CChainValidationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<ChainValidationResult>**,
            int> get_ServerCertificateErrors;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<IntPtr>**,
            int> get_ServerIntermediateCertificates;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reject;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebSocketServerCustomValidationRequestedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebSocketServerCustomValidationRequestedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebSocketServerCustomValidationRequestedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebSocketServerCustomValidationRequestedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IWebSocketServerCustomValidationRequestedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebSocketServerCustomValidationRequestedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebSocketServerCustomValidationRequestedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IWebSocketServerCustomValidationRequestedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebSocketServerCustomValidationRequestedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebSocketServerCustomValidationRequestedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IWebSocketServerCustomValidationRequestedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebSocketServerCustomValidationRequestedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebSocketServerCustomValidationRequestedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IWebSocketServerCustomValidationRequestedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
