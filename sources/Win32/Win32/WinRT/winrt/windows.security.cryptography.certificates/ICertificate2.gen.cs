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

[Guid("17B8374C-8A25-4D96-A492-8FC29AC4FDA6")]
[NativeTypeName("struct ICertificate2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificate2 : ICertificate2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificate2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICertificate2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICertificate2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICertificate2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICertificate2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICertificate2, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICertificate2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsSecurityDeviceBound([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICertificate2, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_KeyUsages(
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Certificates::ICertificateKeyUsages **"
        )]
            ICertificateKeyUsages* value
    )
    {
        return ((delegate* unmanaged<ICertificate2, ICertificateKeyUsages*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KeyAlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged<ICertificate2, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SignatureAlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged<ICertificate2, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SignatureHashAlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged<ICertificate2, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SubjectAlternativeName(
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Certificates::ISubjectAlternativeNameInfo **"
        )]
            ISubjectAlternativeNameInfo* value
    )
    {
        return (
            (delegate* unmanaged<ICertificate2, ISubjectAlternativeNameInfo*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsSecurityDeviceBound([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_KeyUsages(
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::ICertificateKeyUsages **"
            )]
                ICertificateKeyUsages* value
        );

        [VtblIndex(8)]
        HRESULT get_KeyAlgorithmName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_SignatureAlgorithmName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_SignatureHashAlgorithmName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_SubjectAlternativeName(
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Certificates::ISubjectAlternativeNameInfo **"
            )]
                ISubjectAlternativeNameInfo* value
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsSecurityDeviceBound;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificateKeyUsages **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICertificateKeyUsages*, int> get_KeyUsages;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_KeyAlgorithmName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SignatureAlgorithmName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SignatureHashAlgorithmName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ISubjectAlternativeNameInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISubjectAlternativeNameInfo*,
            int> get_SubjectAlternativeName;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICertificate2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICertificate2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICertificate2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICertificate2(Silk.NET.WinRT.IInspectable value)
    {
        return new ICertificate2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificate2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificate2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICertificate2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICertificate2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICertificate2(Silk.NET.Windows.IUnknown value)
    {
        return new ICertificate2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICertificate2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICertificate2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICertificate2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
