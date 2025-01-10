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

[Guid("204C7CC8-BD2D-4E8D-A4B3-455EC337388A")]
[NativeTypeName("struct IConnectionProfileFilter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectionProfileFilter
    : IConnectionProfileFilter.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectionProfileFilter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IConnectionProfileFilter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IConnectionProfileFilter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IConnectionProfileFilter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IConnectionProfileFilter, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IConnectionProfileFilter, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IConnectionProfileFilter, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_IsConnected([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IConnectionProfileFilter, byte, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsConnected([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IConnectionProfileFilter, byte*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IsWwanConnectionProfile([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IConnectionProfileFilter, byte, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsWwanConnectionProfile([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IConnectionProfileFilter, byte*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_IsWlanConnectionProfile([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IConnectionProfileFilter, byte, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsWlanConnectionProfile([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IConnectionProfileFilter, byte*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_NetworkCostType(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkCostType")]
            NetworkCostType value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfileFilter, NetworkCostType, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_NetworkCostType(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkCostType *")]
            NetworkCostType* value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfileFilter, NetworkCostType*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_ServiceProviderGuid(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t *")]
            IReference<Guid>* value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfileFilter, IReference<Guid>*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ServiceProviderGuid(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t **")]
            IReference<Guid>** value
    )
    {
        return (
            (delegate* unmanaged<IConnectionProfileFilter, IReference<Guid>**, int>)((*lpVtbl)[15])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_IsConnected([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_IsConnected([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_IsWwanConnectionProfile([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_IsWwanConnectionProfile([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_IsWlanConnectionProfile([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_IsWlanConnectionProfile([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_NetworkCostType(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkCostType")]
                NetworkCostType value
        );

        [VtblIndex(13)]
        HRESULT get_NetworkCostType(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkCostType *")]
                NetworkCostType* value
        );

        [VtblIndex(14)]
        HRESULT put_ServiceProviderGuid(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t *")]
                IReference<Guid>* value
        );

        [VtblIndex(15)]
        HRESULT get_ServiceProviderGuid(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t **")]
                IReference<Guid>** value
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsConnected;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsConnected;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsWwanConnectionProfile;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsWwanConnectionProfile;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsWlanConnectionProfile;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsWlanConnectionProfile;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::NetworkCostType) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, NetworkCostType, int> put_NetworkCostType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::NetworkCostType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, NetworkCostType*, int> get_NetworkCostType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_GUID_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Guid>*, int> put_ServiceProviderGuid;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_GUID_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Guid>**, int> get_ServiceProviderGuid;
    }

    /// <summary>Initializes a new instance of the <see cref = "IConnectionProfileFilter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IConnectionProfileFilter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IConnectionProfileFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IConnectionProfileFilter(Silk.NET.WinRT.IInspectable value)
    {
        return new IConnectionProfileFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnectionProfileFilter"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IConnectionProfileFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IConnectionProfileFilter value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IConnectionProfileFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IConnectionProfileFilter(Silk.NET.Windows.IUnknown value)
    {
        return new IConnectionProfileFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnectionProfileFilter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IConnectionProfileFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IConnectionProfileFilter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
