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

[Guid("75927B93-03F3-41EC-91D3-6E5BAC1B38E7")]
[NativeTypeName("struct IToastNotifier : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotifier : IToastNotifier.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotifier));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IToastNotifier, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IToastNotifier, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IToastNotifier, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IToastNotifier, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IToastNotifier, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IToastNotifier, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Show(
        [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")]
            IToastNotification notification
    )
    {
        return ((delegate* unmanaged<IToastNotifier, IToastNotification, int>)((*lpVtbl)[6]))(
            this,
            notification
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Hide(
        [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")]
            IToastNotification notification
    )
    {
        return ((delegate* unmanaged<IToastNotifier, IToastNotification, int>)((*lpVtbl)[7]))(
            this,
            notification
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Setting(
        [NativeTypeName("ABI::Windows::UI::Notifications::NotificationSetting *")]
            NotificationSetting* value
    )
    {
        return ((delegate* unmanaged<IToastNotifier, NotificationSetting*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddToSchedule(
        [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification *")]
            IScheduledToastNotification scheduledToast
    )
    {
        return (
            (delegate* unmanaged<IToastNotifier, IScheduledToastNotification, int>)((*lpVtbl)[9])
        )(this, scheduledToast);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RemoveFromSchedule(
        [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification *")]
            IScheduledToastNotification scheduledToast
    )
    {
        return (
            (delegate* unmanaged<IToastNotifier, IScheduledToastNotification, int>)((*lpVtbl)[10])
        )(this, scheduledToast);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetScheduledToastNotifications(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CScheduledToastNotification_t **"
        )]
            IVectorView<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IToastNotifier, IVectorView<IntPtr>**, int>)((*lpVtbl)[11]))(
            this,
            result
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Show(
            [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")]
                IToastNotification notification
        );

        [VtblIndex(7)]
        HRESULT Hide(
            [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")]
                IToastNotification notification
        );

        [VtblIndex(8)]
        HRESULT get_Setting(
            [NativeTypeName("ABI::Windows::UI::Notifications::NotificationSetting *")]
                NotificationSetting* value
        );

        [VtblIndex(9)]
        HRESULT AddToSchedule(
            [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification *")]
                IScheduledToastNotification scheduledToast
        );

        [VtblIndex(10)]
        HRESULT RemoveFromSchedule(
            [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledToastNotification *")]
                IScheduledToastNotification scheduledToast
        );

        [VtblIndex(11)]
        HRESULT GetScheduledToastNotifications(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CScheduledToastNotification_t **"
            )]
                IVectorView<IntPtr>** result
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
            "HRESULT (ABI::Windows::UI::Notifications::IToastNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IToastNotification, int> Show;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::IToastNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IToastNotification, int> Hide;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::NotificationSetting *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, NotificationSetting*, int> get_Setting;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::IScheduledToastNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IScheduledToastNotification, int> AddToSchedule;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::IScheduledToastNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IScheduledToastNotification, int> RemoveFromSchedule;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CScheduledToastNotification_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<IntPtr>**,
            int> GetScheduledToastNotifications;
    }

    /// <summary>Initializes a new instance of the <see cref = "IToastNotifier"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IToastNotifier(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IToastNotifier"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IToastNotifier(Silk.NET.WinRT.IInspectable value)
    {
        return new IToastNotifier(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IToastNotifier"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IToastNotifier"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IToastNotifier value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IToastNotifier"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IToastNotifier(Silk.NET.Windows.IUnknown value)
    {
        return new IToastNotifier(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IToastNotifier"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IToastNotifier"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IToastNotifier value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
