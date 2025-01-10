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

[Guid("13793285-3EA6-40FD-B420-15F47DA41FBB")]
[NativeTypeName("struct ICredentialProviderUser : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ICredentialProviderUser
    : ICredentialProviderUser.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICredentialProviderUser));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICredentialProviderUser, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICredentialProviderUser, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICredentialProviderUser, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSid([NativeTypeName("LPWSTR *")] ushort** sid)
    {
        return ((delegate* unmanaged<ICredentialProviderUser, ushort**, int>)((*lpVtbl)[3]))(
            this,
            sid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProviderID(Guid* providerID)
    {
        return ((delegate* unmanaged<ICredentialProviderUser, Guid*, int>)((*lpVtbl)[4]))(
            this,
            providerID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStringValue(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
        [NativeTypeName("LPWSTR *")] ushort** stringValue
    )
    {
        return (
            (delegate* unmanaged<ICredentialProviderUser, PROPERTYKEY*, ushort**, int>)(
                (*lpVtbl)[5]
            )
        )(this, key, stringValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetValue(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
        PROPVARIANT* value
    )
    {
        return (
            (delegate* unmanaged<ICredentialProviderUser, PROPERTYKEY*, PROPVARIANT*, int>)(
                (*lpVtbl)[6]
            )
        )(this, key, value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSid([NativeTypeName("LPWSTR *")] ushort** sid);

        [VtblIndex(4)]
        HRESULT GetProviderID(Guid* providerID);

        [VtblIndex(5)]
        HRESULT GetStringValue(
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
            [NativeTypeName("LPWSTR *")] ushort** stringValue
        );

        [VtblIndex(6)]
        HRESULT GetValue(
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
            PROPVARIANT* value
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSid;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetProviderID;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, ushort**, int> GetStringValue;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, PROPVARIANT*, int> GetValue;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICredentialProviderUser"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICredentialProviderUser(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICredentialProviderUser"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICredentialProviderUser(Silk.NET.Windows.IUnknown value)
    {
        return new ICredentialProviderUser(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICredentialProviderUser"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICredentialProviderUser"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICredentialProviderUser value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
