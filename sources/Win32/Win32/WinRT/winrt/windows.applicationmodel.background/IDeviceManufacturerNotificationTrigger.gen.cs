// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("81278AB5-41AB-16DA-86C2-7F7BF0912F5B")]
[NativeTypeName("struct IDeviceManufacturerNotificationTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms"
)]
public unsafe partial struct IDeviceManufacturerNotificationTrigger
    : IDeviceManufacturerNotificationTrigger.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceManufacturerNotificationTrigger));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDeviceManufacturerNotificationTrigger, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeviceManufacturerNotificationTrigger, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceManufacturerNotificationTrigger, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IDeviceManufacturerNotificationTrigger, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IDeviceManufacturerNotificationTrigger, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IDeviceManufacturerNotificationTrigger, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms"
    )]
    public HRESULT get_TriggerQualifier(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IDeviceManufacturerNotificationTrigger, HSTRING*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms"
    )]
    public HRESULT get_OneShot([NativeTypeName("boolean *")] byte* oneShot)
    {
        return (
            (delegate* unmanaged<IDeviceManufacturerNotificationTrigger, byte*, int>)((*lpVtbl)[7])
        )(this, oneShot);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms"
        )]
        HRESULT get_TriggerQualifier(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete(
            "DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms"
        )]
        HRESULT get_OneShot([NativeTypeName("boolean *")] byte* oneShot);
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
        [Obsolete(
            "DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms"
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_TriggerQualifier;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms"
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_OneShot;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeviceManufacturerNotificationTrigger"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeviceManufacturerNotificationTrigger(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDeviceManufacturerNotificationTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDeviceManufacturerNotificationTrigger(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IDeviceManufacturerNotificationTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceManufacturerNotificationTrigger"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceManufacturerNotificationTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IDeviceManufacturerNotificationTrigger value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeviceManufacturerNotificationTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeviceManufacturerNotificationTrigger(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDeviceManufacturerNotificationTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceManufacturerNotificationTrigger"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceManufacturerNotificationTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDeviceManufacturerNotificationTrigger value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
