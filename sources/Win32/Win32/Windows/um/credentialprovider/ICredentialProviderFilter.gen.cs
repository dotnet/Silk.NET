// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A5DA53F9-D475-4080-A120-910C4A739880")]
[NativeTypeName("struct ICredentialProviderFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICredentialProviderFilter
    : ICredentialProviderFilter.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICredentialProviderFilter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICredentialProviderFilter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICredentialProviderFilter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICredentialProviderFilter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Filter(
        CREDENTIAL_PROVIDER_USAGE_SCENARIO cpus,
        [NativeTypeName("DWORD")] uint dwFlags,
        Guid* rgclsidProviders,
        BOOL* rgbAllow,
        [NativeTypeName("DWORD")] uint cProviders
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderFilter,
                CREDENTIAL_PROVIDER_USAGE_SCENARIO,
                uint,
                Guid*,
                BOOL*,
                uint,
                int>)((*lpVtbl)[3])
        )(this, cpus, dwFlags, rgclsidProviders, rgbAllow, cProviders);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UpdateRemoteCredential(
        [NativeTypeName("const CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION *")]
            CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcsIn,
        CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcsOut
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderFilter,
                CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*,
                CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*,
                int>)((*lpVtbl)[4])
        )(this, pcpcsIn, pcpcsOut);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Filter(
            CREDENTIAL_PROVIDER_USAGE_SCENARIO cpus,
            [NativeTypeName("DWORD")] uint dwFlags,
            Guid* rgclsidProviders,
            BOOL* rgbAllow,
            [NativeTypeName("DWORD")] uint cProviders
        );

        [VtblIndex(4)]
        HRESULT UpdateRemoteCredential(
            [NativeTypeName("const CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION *")]
                CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcsIn,
            CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcsOut
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
            "HRESULT (CREDENTIAL_PROVIDER_USAGE_SCENARIO, DWORD, GUID *, BOOL *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CREDENTIAL_PROVIDER_USAGE_SCENARIO,
            uint,
            Guid*,
            BOOL*,
            uint,
            int> Filter;

        [NativeTypeName(
            "HRESULT (const CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION *, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*,
            CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*,
            int> UpdateRemoteCredential;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICredentialProviderFilter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICredentialProviderFilter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICredentialProviderFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICredentialProviderFilter(Silk.NET.Windows.IUnknown value)
    {
        return new ICredentialProviderFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICredentialProviderFilter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICredentialProviderFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICredentialProviderFilter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
