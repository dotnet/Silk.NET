// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DBC6FB30-C843-49E3-A645-573E6F39446A")]
[NativeTypeName("struct ICredentialProviderCredentialWithFieldOptions : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ICredentialProviderCredentialWithFieldOptions
    : ICredentialProviderCredentialWithFieldOptions.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_ICredentialProviderCredentialWithFieldOptions)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredentialWithFieldOptions,
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
            (delegate* unmanaged<ICredentialProviderCredentialWithFieldOptions, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredentialWithFieldOptions, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFieldOptions(
        [NativeTypeName("DWORD")] uint fieldID,
        CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS* options
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredentialWithFieldOptions,
                uint,
                CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS*,
                int>)((*lpVtbl)[3])
        )(this, fieldID, options);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFieldOptions(
            [NativeTypeName("DWORD")] uint fieldID,
            CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS* options
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

        [NativeTypeName(
            "HRESULT (DWORD, CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS*,
            int> GetFieldOptions;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICredentialProviderCredentialWithFieldOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICredentialProviderCredentialWithFieldOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICredentialProviderCredentialWithFieldOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICredentialProviderCredentialWithFieldOptions(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICredentialProviderCredentialWithFieldOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICredentialProviderCredentialWithFieldOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICredentialProviderCredentialWithFieldOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICredentialProviderCredentialWithFieldOptions value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
