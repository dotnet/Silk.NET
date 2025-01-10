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

[Guid("5074F851-950D-4165-9C15-365619481EEA")]
[NativeTypeName("struct INetworkInformationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INetworkInformationStatics
    : INetworkInformationStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INetworkInformationStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<INetworkInformationStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INetworkInformationStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INetworkInformationStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<INetworkInformationStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<INetworkInformationStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<INetworkInformationStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetConnectionProfiles(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CConnectivity__CConnectionProfile_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<INetworkInformationStatics, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetInternetConnectionProfile(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::IConnectionProfile **")]
            IConnectionProfile* value
    )
    {
        return (
            (delegate* unmanaged<INetworkInformationStatics, IConnectionProfile*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetLanIdentifiers(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CConnectivity__CLanIdentifier_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<INetworkInformationStatics, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetHostNames(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CHostName_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<INetworkInformationStatics, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetProxyConfigurationAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CProxyConfiguration_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                INetworkInformationStatics,
                IUriRuntimeClass,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, uri, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSortedEndpointPairs(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CEndpointPair_t *"
        )]
            IIterable<IntPtr>* destinationList,
        [NativeTypeName("ABI::Windows::Networking::HostNameSortOptions")]
            HostNameSortOptions sortOptions,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CEndpointPair_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                INetworkInformationStatics,
                IIterable<IntPtr>*,
                HostNameSortOptions,
                IVectorView<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, destinationList, sortOptions, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_NetworkStatusChanged(
        [NativeTypeName(
            "ABI::Windows::Networking::Connectivity::INetworkStatusChangedEventHandler *"
        )]
            INetworkStatusChangedEventHandler networkStatusHandler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                INetworkInformationStatics,
                INetworkStatusChangedEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[12])
        )(this, networkStatusHandler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_NetworkStatusChanged(EventRegistrationToken eventCookie)
    {
        return (
            (delegate* unmanaged<INetworkInformationStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[13]
            )
        )(this, eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetConnectionProfiles(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CConnectivity__CConnectionProfile_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT GetInternetConnectionProfile(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::IConnectionProfile **")]
                IConnectionProfile* value
        );

        [VtblIndex(8)]
        HRESULT GetLanIdentifiers(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CConnectivity__CLanIdentifier_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(9)]
        HRESULT GetHostNames(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CHostName_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(10)]
        HRESULT GetProxyConfigurationAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CProxyConfiguration_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(11)]
        HRESULT GetSortedEndpointPairs(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CEndpointPair_t *"
            )]
                IIterable<IntPtr>* destinationList,
            [NativeTypeName("ABI::Windows::Networking::HostNameSortOptions")]
                HostNameSortOptions sortOptions,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CEndpointPair_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(12)]
        HRESULT add_NetworkStatusChanged(
            [NativeTypeName(
                "ABI::Windows::Networking::Connectivity::INetworkStatusChangedEventHandler *"
            )]
                INetworkStatusChangedEventHandler networkStatusHandler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(13)]
        HRESULT remove_NetworkStatusChanged(EventRegistrationToken eventCookie);
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CConnectivity__CConnectionProfile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> GetConnectionProfiles;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::IConnectionProfile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IConnectionProfile*, int> GetInternetConnectionProfile;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CConnectivity__CLanIdentifier_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> GetLanIdentifiers;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CHostName_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> GetHostNames;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CConnectivity__CProxyConfiguration_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IAsyncOperation<IntPtr>**,
            int> GetProxyConfigurationAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CEndpointPair_t *, ABI::Windows::Networking::HostNameSortOptions, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CEndpointPair_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            HostNameSortOptions,
            IVectorView<IntPtr>**,
            int> GetSortedEndpointPairs;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::INetworkStatusChangedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            INetworkStatusChangedEventHandler,
            EventRegistrationToken*,
            int> add_NetworkStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_NetworkStatusChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "INetworkInformationStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INetworkInformationStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "INetworkInformationStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator INetworkInformationStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new INetworkInformationStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INetworkInformationStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "INetworkInformationStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(INetworkInformationStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INetworkInformationStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INetworkInformationStatics(Silk.NET.Windows.IUnknown value)
    {
        return new INetworkInformationStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INetworkInformationStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INetworkInformationStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INetworkInformationStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
