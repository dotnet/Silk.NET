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

[Guid("0942A48B-1D91-44EC-9243-C1E821C29A20")]
[NativeTypeName("struct ITileUpdater : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITileUpdater : ITileUpdater.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITileUpdater));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITileUpdater, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITileUpdater, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITileUpdater, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITileUpdater, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITileUpdater, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITileUpdater, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Update(
        [NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification *")]
            ITileNotification notification
    )
    {
        return ((delegate* unmanaged<ITileUpdater, ITileNotification, int>)((*lpVtbl)[6]))(
            this,
            notification
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<ITileUpdater, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnableNotificationQueue([NativeTypeName("boolean")] byte enable)
    {
        return ((delegate* unmanaged<ITileUpdater, byte, int>)((*lpVtbl)[8]))(this, enable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Setting(
        [NativeTypeName("ABI::Windows::UI::Notifications::NotificationSetting *")]
            NotificationSetting* value
    )
    {
        return ((delegate* unmanaged<ITileUpdater, NotificationSetting*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddToSchedule(
        [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledTileNotification *")]
            IScheduledTileNotification scheduledTile
    )
    {
        return (
            (delegate* unmanaged<ITileUpdater, IScheduledTileNotification, int>)((*lpVtbl)[10])
        )(this, scheduledTile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RemoveFromSchedule(
        [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledTileNotification *")]
            IScheduledTileNotification scheduledTile
    )
    {
        return (
            (delegate* unmanaged<ITileUpdater, IScheduledTileNotification, int>)((*lpVtbl)[11])
        )(this, scheduledTile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetScheduledTileNotifications(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CScheduledTileNotification_t **"
        )]
            IVectorView<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<ITileUpdater, IVectorView<IntPtr>**, int>)((*lpVtbl)[12]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT StartPeriodicUpdate(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass tileContent,
        [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")]
            PeriodicUpdateRecurrence requestedInterval
    )
    {
        return (
            (delegate* unmanaged<ITileUpdater, IUriRuntimeClass, PeriodicUpdateRecurrence, int>)(
                (*lpVtbl)[13]
            )
        )(this, tileContent, requestedInterval);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT StartPeriodicUpdateAtTime(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass tileContent,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime,
        [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")]
            PeriodicUpdateRecurrence requestedInterval
    )
    {
        return (
            (delegate* unmanaged<
                ITileUpdater,
                IUriRuntimeClass,
                WinRTDateTime,
                PeriodicUpdateRecurrence,
                int>)((*lpVtbl)[14])
        )(this, tileContent, startTime, requestedInterval);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT StopPeriodicUpdate()
    {
        return ((delegate* unmanaged<ITileUpdater, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT StartPeriodicUpdateBatch(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *"
        )]
            IIterable<IntPtr>* tileContents,
        [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")]
            PeriodicUpdateRecurrence requestedInterval
    )
    {
        return (
            (delegate* unmanaged<ITileUpdater, IIterable<IntPtr>*, PeriodicUpdateRecurrence, int>)(
                (*lpVtbl)[16]
            )
        )(this, tileContents, requestedInterval);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT StartPeriodicUpdateBatchAtTime(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *"
        )]
            IIterable<IntPtr>* tileContents,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime,
        [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")]
            PeriodicUpdateRecurrence requestedInterval
    )
    {
        return (
            (delegate* unmanaged<
                ITileUpdater,
                IIterable<IntPtr>*,
                WinRTDateTime,
                PeriodicUpdateRecurrence,
                int>)((*lpVtbl)[17])
        )(this, tileContents, startTime, requestedInterval);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Update(
            [NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification *")]
                ITileNotification notification
        );

        [VtblIndex(7)]
        HRESULT Clear();

        [VtblIndex(8)]
        HRESULT EnableNotificationQueue([NativeTypeName("boolean")] byte enable);

        [VtblIndex(9)]
        HRESULT get_Setting(
            [NativeTypeName("ABI::Windows::UI::Notifications::NotificationSetting *")]
                NotificationSetting* value
        );

        [VtblIndex(10)]
        HRESULT AddToSchedule(
            [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledTileNotification *")]
                IScheduledTileNotification scheduledTile
        );

        [VtblIndex(11)]
        HRESULT RemoveFromSchedule(
            [NativeTypeName("ABI::Windows::UI::Notifications::IScheduledTileNotification *")]
                IScheduledTileNotification scheduledTile
        );

        [VtblIndex(12)]
        HRESULT GetScheduledTileNotifications(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CScheduledTileNotification_t **"
            )]
                IVectorView<IntPtr>** result
        );

        [VtblIndex(13)]
        HRESULT StartPeriodicUpdate(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass tileContent,
            [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")]
                PeriodicUpdateRecurrence requestedInterval
        );

        [VtblIndex(14)]
        HRESULT StartPeriodicUpdateAtTime(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass tileContent,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime,
            [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")]
                PeriodicUpdateRecurrence requestedInterval
        );

        [VtblIndex(15)]
        HRESULT StopPeriodicUpdate();

        [VtblIndex(16)]
        HRESULT StartPeriodicUpdateBatch(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *"
            )]
                IIterable<IntPtr>* tileContents,
            [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")]
                PeriodicUpdateRecurrence requestedInterval
        );

        [VtblIndex(17)]
        HRESULT StartPeriodicUpdateBatchAtTime(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *"
            )]
                IIterable<IntPtr>* tileContents,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime,
            [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")]
                PeriodicUpdateRecurrence requestedInterval
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
            "HRESULT (ABI::Windows::UI::Notifications::ITileNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITileNotification, int> Update;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> EnableNotificationQueue;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::NotificationSetting *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, NotificationSetting*, int> get_Setting;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::IScheduledTileNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IScheduledTileNotification, int> AddToSchedule;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::IScheduledTileNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IScheduledTileNotification, int> RemoveFromSchedule;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CScheduledTileNotification_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<IntPtr>**,
            int> GetScheduledTileNotifications;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            PeriodicUpdateRecurrence,
            int> StartPeriodicUpdate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::DateTime, ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            WinRTDateTime,
            PeriodicUpdateRecurrence,
            int> StartPeriodicUpdateAtTime;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopPeriodicUpdate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *, ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            PeriodicUpdateRecurrence,
            int> StartPeriodicUpdateBatch;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *, ABI::Windows::Foundation::DateTime, ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            WinRTDateTime,
            PeriodicUpdateRecurrence,
            int> StartPeriodicUpdateBatchAtTime;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITileUpdater"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITileUpdater(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITileUpdater"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITileUpdater(Silk.NET.WinRT.IInspectable value)
    {
        return new ITileUpdater(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITileUpdater"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITileUpdater"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITileUpdater value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITileUpdater"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITileUpdater(Silk.NET.Windows.IUnknown value)
    {
        return new ITileUpdater(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITileUpdater"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITileUpdater"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITileUpdater value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
