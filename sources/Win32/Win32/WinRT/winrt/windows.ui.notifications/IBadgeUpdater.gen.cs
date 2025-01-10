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

[Guid("B5FA1FD4-7562-4F6C-BFA3-1B6ED2E57F2F")]
[NativeTypeName("struct IBadgeUpdater : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBadgeUpdater : IBadgeUpdater.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBadgeUpdater));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBadgeUpdater, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBadgeUpdater, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBadgeUpdater, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBadgeUpdater, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBadgeUpdater, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBadgeUpdater, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Update(
        [NativeTypeName("ABI::Windows::UI::Notifications::IBadgeNotification *")]
            IBadgeNotification notification
    )
    {
        return ((delegate* unmanaged<IBadgeUpdater, IBadgeNotification, int>)((*lpVtbl)[6]))(
            this,
            notification
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<IBadgeUpdater, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartPeriodicUpdate(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass badgeContent,
        [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")]
            PeriodicUpdateRecurrence requestedInterval
    )
    {
        return (
            (delegate* unmanaged<IBadgeUpdater, IUriRuntimeClass, PeriodicUpdateRecurrence, int>)(
                (*lpVtbl)[8]
            )
        )(this, badgeContent, requestedInterval);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartPeriodicUpdateAtTime(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass badgeContent,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime,
        [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")]
            PeriodicUpdateRecurrence requestedInterval
    )
    {
        return (
            (delegate* unmanaged<
                IBadgeUpdater,
                IUriRuntimeClass,
                WinRTDateTime,
                PeriodicUpdateRecurrence,
                int>)((*lpVtbl)[9])
        )(this, badgeContent, startTime, requestedInterval);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StopPeriodicUpdate()
    {
        return ((delegate* unmanaged<IBadgeUpdater, int>)((*lpVtbl)[10]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Update(
            [NativeTypeName("ABI::Windows::UI::Notifications::IBadgeNotification *")]
                IBadgeNotification notification
        );

        [VtblIndex(7)]
        HRESULT Clear();

        [VtblIndex(8)]
        HRESULT StartPeriodicUpdate(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass badgeContent,
            [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")]
                PeriodicUpdateRecurrence requestedInterval
        );

        [VtblIndex(9)]
        HRESULT StartPeriodicUpdateAtTime(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass badgeContent,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime,
            [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")]
                PeriodicUpdateRecurrence requestedInterval
        );

        [VtblIndex(10)]
        HRESULT StopPeriodicUpdate();
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
            "HRESULT (ABI::Windows::UI::Notifications::IBadgeNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBadgeNotification, int> Update;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Clear;

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
    }

    /// <summary>Initializes a new instance of the <see cref = "IBadgeUpdater"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBadgeUpdater(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBadgeUpdater"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBadgeUpdater(Silk.NET.WinRT.IInspectable value)
    {
        return new IBadgeUpdater(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBadgeUpdater"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBadgeUpdater"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBadgeUpdater value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBadgeUpdater"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBadgeUpdater(Silk.NET.Windows.IUnknown value)
    {
        return new IBadgeUpdater(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBadgeUpdater"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBadgeUpdater"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBadgeUpdater value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
