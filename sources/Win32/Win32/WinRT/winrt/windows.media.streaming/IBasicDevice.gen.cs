// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F4F26CBB-7962-48B7-80F7-C3A5D753BCB0")]
[NativeTypeName("struct IBasicDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBasicDevice : IBasicDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBasicDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBasicDevice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBasicDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBasicDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBasicDevice, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBasicDevice, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBasicDevice, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FriendlyName(HSTRING* value)
    {
        return ((delegate* unmanaged<IBasicDevice, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_FriendlyName(HSTRING value)
    {
        return ((delegate* unmanaged<IBasicDevice, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ManufacturerName(HSTRING* value)
    {
        return ((delegate* unmanaged<IBasicDevice, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ManufacturerUrl(HSTRING* value)
    {
        return ((delegate* unmanaged<IBasicDevice, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UniqueDeviceName(HSTRING* value)
    {
        return ((delegate* unmanaged<IBasicDevice, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ModelName(HSTRING* value)
    {
        return ((delegate* unmanaged<IBasicDevice, HSTRING*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ModelNumber(HSTRING* value)
    {
        return ((delegate* unmanaged<IBasicDevice, HSTRING*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ModelUrl(HSTRING* value)
    {
        return ((delegate* unmanaged<IBasicDevice, HSTRING*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged<IBasicDevice, HSTRING*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_SerialNumber(HSTRING* value)
    {
        return ((delegate* unmanaged<IBasicDevice, HSTRING*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_PresentationUrl(HSTRING* value)
    {
        return ((delegate* unmanaged<IBasicDevice, HSTRING*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_RemoteStreamingUrls(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IBasicDevice, IVector<HSTRING>**, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_PhysicalAddresses(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IBasicDevice, IVector<HSTRING>**, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_IpAddresses(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IBasicDevice, IVector<HSTRING>**, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_CanWakeDevices([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IBasicDevice, byte*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_DiscoveredOnCurrentNetwork([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IBasicDevice, byte*, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Type(
        [NativeTypeName("ABI::Windows::Media::Streaming::DeviceTypes *")] DeviceTypes* value
    )
    {
        return ((delegate* unmanaged<IBasicDevice, DeviceTypes*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Icons(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CIDeviceIcon_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IBasicDevice, IVector<IntPtr>**, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_ConnectionStatus(
        [NativeTypeName("ABI::Windows::Media::Streaming::ConnectionStatus *")]
            ConnectionStatus* value
    )
    {
        return ((delegate* unmanaged<IBasicDevice, ConnectionStatus*, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT add_ConnectionStatusChanged(
        [NativeTypeName("ABI::Windows::Media::Streaming::IConnectionStatusHandler *")]
            IConnectionStatusHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBasicDevice,
                IConnectionStatusHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[25])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT remove_ConnectionStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IBasicDevice, EventRegistrationToken, int>)((*lpVtbl)[26]))(
            this,
            token
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FriendlyName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_FriendlyName(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_ManufacturerName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_ManufacturerUrl(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_UniqueDeviceName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_ModelName(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_ModelNumber(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_ModelUrl(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_SerialNumber(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_PresentationUrl(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_RemoteStreamingUrls(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(18)]
        HRESULT get_PhysicalAddresses(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(19)]
        HRESULT get_IpAddresses(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(20)]
        HRESULT get_CanWakeDevices([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT get_DiscoveredOnCurrentNetwork([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(22)]
        HRESULT get_Type(
            [NativeTypeName("ABI::Windows::Media::Streaming::DeviceTypes *")] DeviceTypes* value
        );

        [VtblIndex(23)]
        HRESULT get_Icons(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CIDeviceIcon_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(24)]
        HRESULT get_ConnectionStatus(
            [NativeTypeName("ABI::Windows::Media::Streaming::ConnectionStatus *")]
                ConnectionStatus* value
        );

        [VtblIndex(25)]
        HRESULT add_ConnectionStatusChanged(
            [NativeTypeName("ABI::Windows::Media::Streaming::IConnectionStatusHandler *")]
                IConnectionStatusHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(26)]
        HRESULT remove_ConnectionStatusChanged(EventRegistrationToken token);
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ManufacturerName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ManufacturerUrl;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UniqueDeviceName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ModelName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ModelNumber;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ModelUrl;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SerialNumber;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PresentationUrl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_RemoteStreamingUrls;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_PhysicalAddresses;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_IpAddresses;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanWakeDevices;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_DiscoveredOnCurrentNetwork;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::DeviceTypes *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DeviceTypes*, int> get_Type;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CIDeviceIcon_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_Icons;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::ConnectionStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ConnectionStatus*, int> get_ConnectionStatus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::IConnectionStatusHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IConnectionStatusHandler,
            EventRegistrationToken*,
            int> add_ConnectionStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_ConnectionStatusChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBasicDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBasicDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBasicDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBasicDevice(Silk.NET.WinRT.IInspectable value)
    {
        return new IBasicDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBasicDevice"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBasicDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBasicDevice value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBasicDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBasicDevice(Silk.NET.Windows.IUnknown value)
    {
        return new IBasicDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBasicDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBasicDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBasicDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
