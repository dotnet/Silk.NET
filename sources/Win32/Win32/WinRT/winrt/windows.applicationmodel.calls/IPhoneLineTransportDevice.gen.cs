// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("EFA8F889-CFFA-59F4-97E4-74705B7DC490")]
[NativeTypeName("struct IPhoneLineTransportDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneLineTransportDevice
    : IPhoneLineTransportDevice.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneLineTransportDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPhoneLineTransportDevice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPhoneLineTransportDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPhoneLineTransportDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPhoneLineTransportDevice, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPhoneLineTransportDevice, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPhoneLineTransportDevice, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged<IPhoneLineTransportDevice, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Transport(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineTransport *")]
            PhoneLineTransport* value
    )
    {
        return (
            (delegate* unmanaged<IPhoneLineTransportDevice, PhoneLineTransport*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestAccessAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **"
        )]
            IAsyncOperation<DeviceAccessStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneLineTransportDevice,
                IAsyncOperation<DeviceAccessStatus>**,
                int>)((*lpVtbl)[8])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RegisterApp()
    {
        return ((delegate* unmanaged<IPhoneLineTransportDevice, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RegisterAppForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser user)
    {
        return ((delegate* unmanaged<IPhoneLineTransportDevice, IUser, int>)((*lpVtbl)[10]))(
            this,
            user
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnregisterApp()
    {
        return ((delegate* unmanaged<IPhoneLineTransportDevice, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT UnregisterAppForUser(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user
    )
    {
        return ((delegate* unmanaged<IPhoneLineTransportDevice, IUser, int>)((*lpVtbl)[12]))(
            this,
            user
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsRegistered([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IPhoneLineTransportDevice, byte*, int>)((*lpVtbl)[13]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Connect([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IPhoneLineTransportDevice, byte*, int>)((*lpVtbl)[14]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ConnectAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<IPhoneLineTransportDevice, IAsyncOperation<byte>**, int>)(
                (*lpVtbl)[15]
            )
        )(this, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Transport(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineTransport *")]
                PhoneLineTransport* value
        );

        [VtblIndex(8)]
        HRESULT RequestAccessAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **"
            )]
                IAsyncOperation<DeviceAccessStatus>** operation
        );

        [VtblIndex(9)]
        HRESULT RegisterApp();

        [VtblIndex(10)]
        HRESULT RegisterAppForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser user);

        [VtblIndex(11)]
        HRESULT UnregisterApp();

        [VtblIndex(12)]
        HRESULT UnregisterAppForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser user);

        [VtblIndex(13)]
        HRESULT IsRegistered([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(14)]
        HRESULT Connect([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(15)]
        HRESULT ConnectAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneLineTransport *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneLineTransport*, int> get_Transport;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<DeviceAccessStatus>**,
            int> RequestAccessAsync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RegisterApp;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUser, int> RegisterAppForUser;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnregisterApp;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUser, int> UnregisterAppForUser;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> IsRegistered;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> Connect;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<byte>**, int> ConnectAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPhoneLineTransportDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPhoneLineTransportDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPhoneLineTransportDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPhoneLineTransportDevice(Silk.NET.WinRT.IInspectable value)
    {
        return new IPhoneLineTransportDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneLineTransportDevice"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneLineTransportDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPhoneLineTransportDevice value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPhoneLineTransportDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPhoneLineTransportDevice(Silk.NET.Windows.IUnknown value)
    {
        return new IPhoneLineTransportDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneLineTransportDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneLineTransportDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPhoneLineTransportDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
