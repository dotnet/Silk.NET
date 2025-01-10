// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("80118AAF-5944-4591-83C1-396647F54F2C")]
[NativeTypeName("struct IGeovisitMonitor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeovisitMonitor : IGeovisitMonitor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeovisitMonitor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGeovisitMonitor, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGeovisitMonitor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGeovisitMonitor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGeovisitMonitor, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGeovisitMonitor, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGeovisitMonitor, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MonitoringScope(
        [NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope *")]
            VisitMonitoringScope* value
    )
    {
        return ((delegate* unmanaged<IGeovisitMonitor, VisitMonitoringScope*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Start(
        [NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope")]
            VisitMonitoringScope value
    )
    {
        return ((delegate* unmanaged<IGeovisitMonitor, VisitMonitoringScope, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IGeovisitMonitor, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_VisitStateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeovisitMonitor_Windows__CDevices__CGeolocation__CGeovisitStateChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IGeovisitMonitor,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_VisitStateChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IGeovisitMonitor, EventRegistrationToken, int>)((*lpVtbl)[10])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MonitoringScope(
            [NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope *")]
                VisitMonitoringScope* value
        );

        [VtblIndex(7)]
        HRESULT Start(
            [NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope")]
                VisitMonitoringScope value
        );

        [VtblIndex(8)]
        HRESULT Stop();

        [VtblIndex(9)]
        HRESULT add_VisitStateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeovisitMonitor_Windows__CDevices__CGeolocation__CGeovisitStateChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(10)]
        HRESULT remove_VisitStateChanged(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Devices::Geolocation::VisitMonitoringScope *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VisitMonitoringScope*, int> get_MonitoringScope;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Geolocation::VisitMonitoringScope) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VisitMonitoringScope, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeovisitMonitor_Windows__CDevices__CGeolocation__CGeovisitStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_VisitStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_VisitStateChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGeovisitMonitor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGeovisitMonitor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGeovisitMonitor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGeovisitMonitor(Silk.NET.WinRT.IInspectable value)
    {
        return new IGeovisitMonitor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeovisitMonitor"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGeovisitMonitor"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGeovisitMonitor value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGeovisitMonitor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGeovisitMonitor(Silk.NET.Windows.IUnknown value)
    {
        return new IGeovisitMonitor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeovisitMonitor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGeovisitMonitor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGeovisitMonitor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
