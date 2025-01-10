// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1F3345C5-1C3B-4DC7-B410-6373783E545D")]
[NativeTypeName("struct IEmailMailboxPolicies : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxPolicies : IEmailMailboxPolicies.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailboxPolicies));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEmailMailboxPolicies, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEmailMailboxPolicies, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailMailboxPolicies, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IEmailMailboxPolicies, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailMailboxPolicies, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IEmailMailboxPolicies, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllowedSmimeEncryptionAlgorithmNegotiation(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Email::EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation *"
        )]
            EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation* value
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailboxPolicies,
                EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AllowSmimeSoftCertificates([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IEmailMailboxPolicies, byte*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RequiredSmimeEncryptionAlgorithm(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CEmail__CEmailMailboxSmimeEncryptionAlgorithm_t **"
        )]
            IReference<EmailMailboxSmimeEncryptionAlgorithm>** value
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailboxPolicies,
                IReference<EmailMailboxSmimeEncryptionAlgorithm>**,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_RequiredSmimeSigningAlgorithm(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CEmail__CEmailMailboxSmimeSigningAlgorithm_t **"
        )]
            IReference<EmailMailboxSmimeSigningAlgorithm>** value
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailboxPolicies,
                IReference<EmailMailboxSmimeSigningAlgorithm>**,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllowedSmimeEncryptionAlgorithmNegotiation(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Email::EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation *"
            )]
                EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation* value
        );

        [VtblIndex(7)]
        HRESULT get_AllowSmimeSoftCertificates([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_RequiredSmimeEncryptionAlgorithm(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CEmail__CEmailMailboxSmimeEncryptionAlgorithm_t **"
            )]
                IReference<EmailMailboxSmimeEncryptionAlgorithm>** value
        );

        [VtblIndex(9)]
        HRESULT get_RequiredSmimeSigningAlgorithm(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CEmail__CEmailMailboxSmimeSigningAlgorithm_t **"
            )]
                IReference<EmailMailboxSmimeSigningAlgorithm>** value
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
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation*,
            int> get_AllowedSmimeEncryptionAlgorithmNegotiation;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AllowSmimeSoftCertificates;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CEmail__CEmailMailboxSmimeEncryptionAlgorithm_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<EmailMailboxSmimeEncryptionAlgorithm>**,
            int> get_RequiredSmimeEncryptionAlgorithm;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CEmail__CEmailMailboxSmimeSigningAlgorithm_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<EmailMailboxSmimeSigningAlgorithm>**,
            int> get_RequiredSmimeSigningAlgorithm;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailMailboxPolicies"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailMailboxPolicies(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailMailboxPolicies"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailMailboxPolicies(Silk.NET.WinRT.IInspectable value)
    {
        return new IEmailMailboxPolicies(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailMailboxPolicies"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailMailboxPolicies"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IEmailMailboxPolicies value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailMailboxPolicies"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailMailboxPolicies(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailMailboxPolicies(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailMailboxPolicies"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailMailboxPolicies"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailMailboxPolicies value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
