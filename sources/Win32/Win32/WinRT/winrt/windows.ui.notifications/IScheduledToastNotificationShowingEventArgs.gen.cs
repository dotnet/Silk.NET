// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6173F6B4-412A-5E2C-A6ED-A0209AEF9A09")]
[NativeTypeName("struct IScheduledToastNotificationShowingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IScheduledToastNotificationShowingEventArgs
    : IScheduledToastNotificationShowingEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IScheduledToastNotificationShowingEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IScheduledToastNotificationShowingEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IScheduledToastNotificationShowingEventArgs, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IScheduledToastNotificationShowingEventArgs, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IScheduledToastNotificationShowingEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IScheduledToastNotificationShowingEventArgs, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IScheduledToastNotificationShowingEventArgs, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Cancel([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<IScheduledToastNotificationShowingEventArgs, byte*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Cancel([NativeTypeName("boolean")] byte value)
    {
        return (
            (delegate* unmanaged<IScheduledToastNotificationShowingEventArgs, byte, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ScheduledToastNotification(
        [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification **")]
            IScheduledToastNotification* value
    )
    {
        return (
            (delegate* unmanaged<
                IScheduledToastNotificationShowingEventArgs,
                IScheduledToastNotification*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* result
    )
    {
        return (
            (delegate* unmanaged<IScheduledToastNotificationShowingEventArgs, IDeferral*, int>)(
                (*lpVtbl)[9]
            )
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Cancel([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_Cancel([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_ScheduledToastNotification(
            [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification **")]
                IScheduledToastNotification* value
        );

        [VtblIndex(9)]
        HRESULT GetDeferral(
            [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* result
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
        public delegate* unmanaged<TSelf*, byte*, int> get_Cancel;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_Cancel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::IScheduledToastNotification **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IScheduledToastNotification*,
            int> get_ScheduledToastNotification;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IScheduledToastNotificationShowingEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IScheduledToastNotificationShowingEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IScheduledToastNotificationShowingEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IScheduledToastNotificationShowingEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IScheduledToastNotificationShowingEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IScheduledToastNotificationShowingEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IScheduledToastNotificationShowingEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IScheduledToastNotificationShowingEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IScheduledToastNotificationShowingEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IScheduledToastNotificationShowingEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IScheduledToastNotificationShowingEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IScheduledToastNotificationShowingEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IScheduledToastNotificationShowingEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IScheduledToastNotificationShowingEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
