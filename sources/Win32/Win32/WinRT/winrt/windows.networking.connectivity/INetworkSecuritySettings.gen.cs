// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("7CA07E8D-917B-4B5F-B84D-28F7A5AC5402")]
[NativeTypeName("struct INetworkSecuritySettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INetworkSecuritySettings
    : INetworkSecuritySettings.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INetworkSecuritySettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INetworkSecuritySettings, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<INetworkSecuritySettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INetworkSecuritySettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<INetworkSecuritySettings, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<INetworkSecuritySettings, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<INetworkSecuritySettings, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NetworkAuthenticationType(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkAuthenticationType *")]
            NetworkAuthenticationType* value
    )
    {
        return (
            (delegate* unmanaged<INetworkSecuritySettings, NetworkAuthenticationType*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_NetworkEncryptionType(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkEncryptionType *")]
            NetworkEncryptionType* value
    )
    {
        return (
            (delegate* unmanaged<INetworkSecuritySettings, NetworkEncryptionType*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NetworkAuthenticationType(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkAuthenticationType *")]
                NetworkAuthenticationType* value
        );

        [VtblIndex(7)]
        HRESULT get_NetworkEncryptionType(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkEncryptionType *")]
                NetworkEncryptionType* value
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
            "HRESULT (ABI::Windows::Networking::Connectivity::NetworkAuthenticationType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            NetworkAuthenticationType*,
            int> get_NetworkAuthenticationType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::NetworkEncryptionType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, NetworkEncryptionType*, int> get_NetworkEncryptionType;
    }

    /// <summary>Initializes a new instance of the <see cref = "INetworkSecuritySettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INetworkSecuritySettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "INetworkSecuritySettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator INetworkSecuritySettings(Silk.NET.WinRT.IInspectable value)
    {
        return new INetworkSecuritySettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INetworkSecuritySettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "INetworkSecuritySettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(INetworkSecuritySettings value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INetworkSecuritySettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INetworkSecuritySettings(Silk.NET.Windows.IUnknown value)
    {
        return new INetworkSecuritySettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INetworkSecuritySettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INetworkSecuritySettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INetworkSecuritySettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
