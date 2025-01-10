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

[Guid("71BA143C-598E-49D0-84EB-8FEBAEDCC195")]
[NativeTypeName("struct IConnectionProfile : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectionProfile : IConnectionProfile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectionProfile));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IConnectionProfile, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IConnectionProfile, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IConnectionProfile, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IConnectionProfile, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IConnectionProfile, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IConnectionProfile, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProfileName(HSTRING* value)
    {
        return ((delegate* unmanaged<IConnectionProfile, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetNetworkConnectivityLevel(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkConnectivityLevel *")]
            NetworkConnectivityLevel* value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfile, NetworkConnectivityLevel*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetNetworkNames(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
            IVectorView<HSTRING>** value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfile, IVectorView<HSTRING>**, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetConnectionCost(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::IConnectionCost **")]
            IConnectionCost* value
    )
    {
        return ((delegate* unmanaged<IConnectionProfile, IConnectionCost*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDataPlanStatus(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::IDataPlanStatus **")]
            IDataPlanStatus* value
    )
    {
        return ((delegate* unmanaged<IConnectionProfile, IDataPlanStatus*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_NetworkAdapter(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkAdapter **")]
            INetworkAdapter* value
    )
    {
        return ((delegate* unmanaged<IConnectionProfile, INetworkAdapter*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete(
        "GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync."
    )]
    public HRESULT GetLocalUsage(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime StartTime,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime EndTime,
        [NativeTypeName("ABI::Windows::Networking::Connectivity::IDataUsage **")] IDataUsage* value
    )
    {
        return (
            (delegate* unmanaged<
                IConnectionProfile,
                WinRTDateTime,
                WinRTDateTime,
                IDataUsage*,
                int>)((*lpVtbl)[12])
        )(this, StartTime, EndTime, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete(
        "GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync."
    )]
    public HRESULT GetLocalUsagePerRoamingStates(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime StartTime,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime EndTime,
        [NativeTypeName("ABI::Windows::Networking::Connectivity::RoamingStates")]
            RoamingStates States,
        [NativeTypeName("ABI::Windows::Networking::Connectivity::IDataUsage **")] IDataUsage* value
    )
    {
        return (
            (delegate* unmanaged<
                IConnectionProfile,
                WinRTDateTime,
                WinRTDateTime,
                RoamingStates,
                IDataUsage*,
                int>)((*lpVtbl)[13])
        )(this, StartTime, EndTime, States, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_NetworkSecuritySettings(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkSecuritySettings **")]
            INetworkSecuritySettings* value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfile, INetworkSecuritySettings*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProfileName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetNetworkConnectivityLevel(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkConnectivityLevel *")]
                NetworkConnectivityLevel* value
        );

        [VtblIndex(8)]
        HRESULT GetNetworkNames(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
                IVectorView<HSTRING>** value
        );

        [VtblIndex(9)]
        HRESULT GetConnectionCost(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::IConnectionCost **")]
                IConnectionCost* value
        );

        [VtblIndex(10)]
        HRESULT GetDataPlanStatus(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::IDataPlanStatus **")]
                IDataPlanStatus* value
        );

        [VtblIndex(11)]
        HRESULT get_NetworkAdapter(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkAdapter **")]
                INetworkAdapter* value
        );

        [VtblIndex(12)]
        [Obsolete(
            "GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync."
        )]
        HRESULT GetLocalUsage(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime StartTime,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime EndTime,
            [NativeTypeName("ABI::Windows::Networking::Connectivity::IDataUsage **")]
                IDataUsage* value
        );

        [VtblIndex(13)]
        [Obsolete(
            "GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync."
        )]
        HRESULT GetLocalUsagePerRoamingStates(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime StartTime,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime EndTime,
            [NativeTypeName("ABI::Windows::Networking::Connectivity::RoamingStates")]
                RoamingStates States,
            [NativeTypeName("ABI::Windows::Networking::Connectivity::IDataUsage **")]
                IDataUsage* value
        );

        [VtblIndex(14)]
        HRESULT get_NetworkSecuritySettings(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkSecuritySettings **")]
                INetworkSecuritySettings* value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ProfileName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::NetworkConnectivityLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            NetworkConnectivityLevel*,
            int> GetNetworkConnectivityLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<HSTRING>**, int> GetNetworkNames;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::IConnectionCost **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IConnectionCost*, int> GetConnectionCost;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::IDataPlanStatus **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDataPlanStatus*, int> GetDataPlanStatus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::INetworkAdapter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, INetworkAdapter*, int> get_NetworkAdapter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::DateTime, ABI::Windows::Networking::Connectivity::IDataUsage **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync."
        )]
        public delegate* unmanaged<
            TSelf*,
            WinRTDateTime,
            WinRTDateTime,
            IDataUsage*,
            int> GetLocalUsage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::DateTime, ABI::Windows::Networking::Connectivity::RoamingStates, ABI::Windows::Networking::Connectivity::IDataUsage **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync."
        )]
        public delegate* unmanaged<
            TSelf*,
            WinRTDateTime,
            WinRTDateTime,
            RoamingStates,
            IDataUsage*,
            int> GetLocalUsagePerRoamingStates;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::INetworkSecuritySettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            INetworkSecuritySettings*,
            int> get_NetworkSecuritySettings;
    }

    /// <summary>Initializes a new instance of the <see cref = "IConnectionProfile"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IConnectionProfile(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IConnectionProfile"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IConnectionProfile(Silk.NET.WinRT.IInspectable value)
    {
        return new IConnectionProfile(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnectionProfile"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IConnectionProfile"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IConnectionProfile value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IConnectionProfile"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IConnectionProfile(Silk.NET.Windows.IUnknown value)
    {
        return new IConnectionProfile(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnectionProfile"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IConnectionProfile"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IConnectionProfile value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
