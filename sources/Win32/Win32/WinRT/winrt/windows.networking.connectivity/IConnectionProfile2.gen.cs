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

[Guid("E2045145-4C9F-400C-9150-7EC7D6E2888A")]
[NativeTypeName("struct IConnectionProfile2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectionProfile2 : IConnectionProfile2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectionProfile2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IConnectionProfile2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IConnectionProfile2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IConnectionProfile2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IConnectionProfile2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IConnectionProfile2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IConnectionProfile2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsWwanConnectionProfile([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IConnectionProfile2, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsWlanConnectionProfile([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IConnectionProfile2, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_WwanConnectionProfileDetails(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::IWwanConnectionProfileDetails **")]
            IWwanConnectionProfileDetails* value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfile2, IWwanConnectionProfileDetails*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_WlanConnectionProfileDetails(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::IWlanConnectionProfileDetails **")]
            IWlanConnectionProfileDetails* value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfile2, IWlanConnectionProfileDetails*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ServiceProviderGuid(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t **")]
            IReference<Guid>** value
    )
    {
        return ((delegate* unmanaged<IConnectionProfile2, IReference<Guid>**, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSignalBars(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_byte_t **")]
            IReference<byte>** value
    )
    {
        return ((delegate* unmanaged<IConnectionProfile2, IReference<byte>**, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetDomainConnectivityLevel(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::DomainConnectivityLevel *")]
            DomainConnectivityLevel* value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfile2, DomainConnectivityLevel*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetNetworkUsageAsync(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime,
        [NativeTypeName("ABI::Windows::Networking::Connectivity::DataUsageGranularity")]
            DataUsageGranularity granularity,
        [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")]
            NetworkUsageStates states,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CNetworkUsage_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IConnectionProfile2,
                WinRTDateTime,
                WinRTDateTime,
                DataUsageGranularity,
                NetworkUsageStates,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[13])
        )(this, startTime, endTime, granularity, states, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetConnectivityIntervalsAsync(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime,
        [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")]
            NetworkUsageStates states,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CConnectivityInterval_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IConnectionProfile2,
                WinRTDateTime,
                WinRTDateTime,
                NetworkUsageStates,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[14])
        )(this, startTime, endTime, states, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsWwanConnectionProfile([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_IsWlanConnectionProfile([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_WwanConnectionProfileDetails(
            [NativeTypeName(
                "ABI::Windows::Networking::Connectivity::IWwanConnectionProfileDetails **"
            )]
                IWwanConnectionProfileDetails* value
        );

        [VtblIndex(9)]
        HRESULT get_WlanConnectionProfileDetails(
            [NativeTypeName(
                "ABI::Windows::Networking::Connectivity::IWlanConnectionProfileDetails **"
            )]
                IWlanConnectionProfileDetails* value
        );

        [VtblIndex(10)]
        HRESULT get_ServiceProviderGuid(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t **")]
                IReference<Guid>** value
        );

        [VtblIndex(11)]
        HRESULT GetSignalBars(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_byte_t **")]
                IReference<byte>** value
        );

        [VtblIndex(12)]
        HRESULT GetDomainConnectivityLevel(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::DomainConnectivityLevel *")]
                DomainConnectivityLevel* value
        );

        [VtblIndex(13)]
        HRESULT GetNetworkUsageAsync(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime,
            [NativeTypeName("ABI::Windows::Networking::Connectivity::DataUsageGranularity")]
                DataUsageGranularity granularity,
            [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")]
                NetworkUsageStates states,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CNetworkUsage_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(14)]
        HRESULT GetConnectivityIntervalsAsync(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime endTime,
            [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkUsageStates")]
                NetworkUsageStates states,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CConnectivityInterval_t **"
            )]
                IAsyncOperation<IntPtr>** value
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
        public delegate* unmanaged<TSelf*, byte*, int> get_IsWwanConnectionProfile;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsWlanConnectionProfile;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::IWwanConnectionProfileDetails **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWwanConnectionProfileDetails*,
            int> get_WwanConnectionProfileDetails;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::IWlanConnectionProfileDetails **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWlanConnectionProfileDetails*,
            int> get_WlanConnectionProfileDetails;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_GUID_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Guid>**, int> get_ServiceProviderGuid;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_byte_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<byte>**, int> GetSignalBars;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::DomainConnectivityLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DomainConnectivityLevel*,
            int> GetDomainConnectivityLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::DateTime, ABI::Windows::Networking::Connectivity::DataUsageGranularity, ABI::Windows::Networking::Connectivity::NetworkUsageStates, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CNetworkUsage_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WinRTDateTime,
            WinRTDateTime,
            DataUsageGranularity,
            NetworkUsageStates,
            IAsyncOperation<IntPtr>**,
            int> GetNetworkUsageAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::DateTime, ABI::Windows::Networking::Connectivity::NetworkUsageStates, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CConnectivity__CConnectivityInterval_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WinRTDateTime,
            WinRTDateTime,
            NetworkUsageStates,
            IAsyncOperation<IntPtr>**,
            int> GetConnectivityIntervalsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IConnectionProfile2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IConnectionProfile2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IConnectionProfile2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IConnectionProfile2(Silk.NET.WinRT.IInspectable value)
    {
        return new IConnectionProfile2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnectionProfile2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IConnectionProfile2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IConnectionProfile2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IConnectionProfile2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IConnectionProfile2(Silk.NET.Windows.IUnknown value)
    {
        return new IConnectionProfile2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnectionProfile2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IConnectionProfile2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IConnectionProfile2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
