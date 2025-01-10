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

[Guid("90C119AE-0F18-4520-A1F1-114366A40FE8")]
[NativeTypeName("struct ICredentialProviderUserArray : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ICredentialProviderUserArray
    : ICredentialProviderUserArray.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICredentialProviderUserArray));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICredentialProviderUserArray, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICredentialProviderUserArray, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICredentialProviderUserArray, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetProviderFilter([NativeTypeName("const GUID &")] Guid* guidProviderToFilterTo)
    {
        return ((delegate* unmanaged<ICredentialProviderUserArray, Guid*, int>)((*lpVtbl)[3]))(
            this,
            guidProviderToFilterTo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAccountOptions(
        CREDENTIAL_PROVIDER_ACCOUNT_OPTIONS* credentialProviderAccountOptions
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderUserArray,
                CREDENTIAL_PROVIDER_ACCOUNT_OPTIONS*,
                int>)((*lpVtbl)[4])
        )(this, credentialProviderAccountOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCount([NativeTypeName("DWORD *")] uint* userCount)
    {
        return ((delegate* unmanaged<ICredentialProviderUserArray, uint*, int>)((*lpVtbl)[5]))(
            this,
            userCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAt([NativeTypeName("DWORD")] uint userIndex, ICredentialProviderUser* user)
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderUserArray,
                uint,
                ICredentialProviderUser*,
                int>)((*lpVtbl)[6])
        )(this, userIndex, user);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetProviderFilter([NativeTypeName("const GUID &")] Guid* guidProviderToFilterTo);

        [VtblIndex(4)]
        HRESULT GetAccountOptions(
            CREDENTIAL_PROVIDER_ACCOUNT_OPTIONS* credentialProviderAccountOptions
        );

        [VtblIndex(5)]
        HRESULT GetCount([NativeTypeName("DWORD *")] uint* userCount);

        [VtblIndex(6)]
        HRESULT GetAt([NativeTypeName("DWORD")] uint userIndex, ICredentialProviderUser* user);
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

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetProviderFilter;

        [NativeTypeName("HRESULT (CREDENTIAL_PROVIDER_ACCOUNT_OPTIONS *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            CREDENTIAL_PROVIDER_ACCOUNT_OPTIONS*,
            int> GetAccountOptions;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (DWORD, ICredentialProviderUser **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ICredentialProviderUser*, int> GetAt;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICredentialProviderUserArray"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICredentialProviderUserArray(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICredentialProviderUserArray"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICredentialProviderUserArray(Silk.NET.Windows.IUnknown value)
    {
        return new ICredentialProviderUserArray(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICredentialProviderUserArray"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICredentialProviderUserArray"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICredentialProviderUserArray value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
