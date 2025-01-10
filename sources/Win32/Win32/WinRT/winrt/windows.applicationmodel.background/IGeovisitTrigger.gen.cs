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

[Guid("4818EDAA-04E1-4127-9A4C-19351B8A80A4")]
[NativeTypeName("struct IGeovisitTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeovisitTrigger : IGeovisitTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeovisitTrigger));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGeovisitTrigger, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGeovisitTrigger, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGeovisitTrigger, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGeovisitTrigger, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGeovisitTrigger, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGeovisitTrigger, TrustLevel*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IGeovisitTrigger, VisitMonitoringScope*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MonitoringScope(
        [NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope")]
            VisitMonitoringScope value
    )
    {
        return ((delegate* unmanaged<IGeovisitTrigger, VisitMonitoringScope, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MonitoringScope(
            [NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope *")]
                VisitMonitoringScope* value
        );

        [VtblIndex(7)]
        HRESULT put_MonitoringScope(
            [NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope")]
                VisitMonitoringScope value
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
            "HRESULT (ABI::Windows::Devices::Geolocation::VisitMonitoringScope *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VisitMonitoringScope*, int> get_MonitoringScope;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Geolocation::VisitMonitoringScope) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VisitMonitoringScope, int> put_MonitoringScope;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGeovisitTrigger"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGeovisitTrigger(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGeovisitTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGeovisitTrigger(Silk.NET.WinRT.IInspectable value)
    {
        return new IGeovisitTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeovisitTrigger"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGeovisitTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGeovisitTrigger value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGeovisitTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGeovisitTrigger(Silk.NET.Windows.IUnknown value)
    {
        return new IGeovisitTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeovisitTrigger"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGeovisitTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGeovisitTrigger value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
