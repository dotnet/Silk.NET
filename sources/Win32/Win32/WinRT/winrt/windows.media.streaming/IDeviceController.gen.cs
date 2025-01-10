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

[Guid("4FEEB26D-50A7-402B-896A-BE95064D6BFF")]
[NativeTypeName("struct IDeviceController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceController : IDeviceController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceController));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeviceController, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDeviceController, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceController, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDeviceController, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDeviceController, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDeviceController, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CachedDevices(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CIBasicDevice_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IDeviceController, IVector<IntPtr>**, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddDevice(HSTRING uniqueDeviceName)
    {
        return ((delegate* unmanaged<IDeviceController, HSTRING, int>)((*lpVtbl)[7]))(
            this,
            uniqueDeviceName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveDevice(
        [NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice device
    )
    {
        return ((delegate* unmanaged<IDeviceController, IBasicDevice, int>)((*lpVtbl)[8]))(
            this,
            device
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_DeviceArrival(
        [NativeTypeName("ABI::Windows::Media::Streaming::IDeviceControllerFinderHandler *")]
            IDeviceControllerFinderHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceController,
                IDeviceControllerFinderHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_DeviceArrival(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IDeviceController, EventRegistrationToken, int>)((*lpVtbl)[10])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_DeviceDeparture(
        [NativeTypeName("ABI::Windows::Media::Streaming::IDeviceControllerFinderHandler *")]
            IDeviceControllerFinderHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceController,
                IDeviceControllerFinderHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_DeviceDeparture(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IDeviceController, EventRegistrationToken, int>)((*lpVtbl)[12])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CachedDevices(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CIBasicDevice_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT AddDevice(HSTRING uniqueDeviceName);

        [VtblIndex(8)]
        HRESULT RemoveDevice(
            [NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice device
        );

        [VtblIndex(9)]
        HRESULT add_DeviceArrival(
            [NativeTypeName("ABI::Windows::Media::Streaming::IDeviceControllerFinderHandler *")]
                IDeviceControllerFinderHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(10)]
        HRESULT remove_DeviceArrival(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_DeviceDeparture(
            [NativeTypeName("ABI::Windows::Media::Streaming::IDeviceControllerFinderHandler *")]
                IDeviceControllerFinderHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(12)]
        HRESULT remove_DeviceDeparture(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CIBasicDevice_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_CachedDevices;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> AddDevice;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::IBasicDevice *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBasicDevice, int> RemoveDevice;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::IDeviceControllerFinderHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDeviceControllerFinderHandler,
            EventRegistrationToken*,
            int> add_DeviceArrival;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_DeviceArrival;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::IDeviceControllerFinderHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDeviceControllerFinderHandler,
            EventRegistrationToken*,
            int> add_DeviceDeparture;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_DeviceDeparture;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeviceController"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeviceController(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDeviceController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDeviceController(Silk.NET.WinRT.IInspectable value)
    {
        return new IDeviceController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceController"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceController"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDeviceController value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeviceController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeviceController(Silk.NET.Windows.IUnknown value)
    {
        return new IDeviceController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceController"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceController"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeviceController value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
