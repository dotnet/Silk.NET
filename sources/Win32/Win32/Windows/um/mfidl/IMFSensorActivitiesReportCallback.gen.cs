// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DE5072EE-DBE3-46DC-8A87-B6F631194751")]
[NativeTypeName("struct IMFSensorActivitiesReportCallback : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFSensorActivitiesReportCallback
    : IMFSensorActivitiesReportCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSensorActivitiesReportCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFSensorActivitiesReportCallback, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSensorActivitiesReportCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSensorActivitiesReportCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnActivitiesReport(IMFSensorActivitiesReport sensorActivitiesReport)
    {
        return (
            (delegate* unmanaged<
                IMFSensorActivitiesReportCallback,
                IMFSensorActivitiesReport,
                int>)((*lpVtbl)[3])
        )(this, sensorActivitiesReport);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnActivitiesReport(IMFSensorActivitiesReport sensorActivitiesReport);
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

        [NativeTypeName("HRESULT (IMFSensorActivitiesReport *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSensorActivitiesReport, int> OnActivitiesReport;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSensorActivitiesReportCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSensorActivitiesReportCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSensorActivitiesReportCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSensorActivitiesReportCallback(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMFSensorActivitiesReportCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSensorActivitiesReportCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSensorActivitiesReportCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMFSensorActivitiesReportCallback value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
