// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFSensorActivitiesReport.xml' path='doc/member[@name="IMFSensorActivitiesReport"]/*'/>
[Guid("683F7A5E-4A19-43CD-B1A9-DBF4AB3F7777")]
[NativeTypeName("struct IMFSensorActivitiesReport : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFSensorActivitiesReport : IMFSensorActivitiesReport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSensorActivitiesReport));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSensorActivitiesReport*, Guid*, void**, int> )(lpVtbl[0]))((IMFSensorActivitiesReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSensorActivitiesReport*, uint> )(lpVtbl[1]))((IMFSensorActivitiesReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSensorActivitiesReport*, uint> )(lpVtbl[2]))((IMFSensorActivitiesReport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSensorActivitiesReport.xml' path='doc/member[@name="IMFSensorActivitiesReport.GetCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount([NativeTypeName("ULONG *")] uint* pcCount)
    {
        return ((delegate* unmanaged<IMFSensorActivitiesReport*, uint*, int> )(lpVtbl[3]))((IMFSensorActivitiesReport*)Unsafe.AsPointer(ref this), pcCount);
    }

    /// <include file='IMFSensorActivitiesReport.xml' path='doc/member[@name="IMFSensorActivitiesReport.GetActivityReport"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetActivityReport([NativeTypeName("ULONG")] uint Index, IMFSensorActivityReport** sensorActivityReport)
    {
        return ((delegate* unmanaged<IMFSensorActivitiesReport*, uint, IMFSensorActivityReport**, int> )(lpVtbl[4]))((IMFSensorActivitiesReport*)Unsafe.AsPointer(ref this), Index, sensorActivityReport);
    }

    /// <include file='IMFSensorActivitiesReport.xml' path='doc/member[@name="IMFSensorActivitiesReport.GetActivityReportByDeviceName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetActivityReportByDeviceName([NativeTypeName("LPCWSTR")] ushort* SymbolicName, IMFSensorActivityReport** sensorActivityReport)
    {
        return ((delegate* unmanaged<IMFSensorActivitiesReport*, ushort*, IMFSensorActivityReport**, int> )(lpVtbl[5]))((IMFSensorActivitiesReport*)Unsafe.AsPointer(ref this), SymbolicName, sensorActivityReport);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount([NativeTypeName("ULONG *")] uint* pcCount);
        [VtblIndex(4)]
        HRESULT GetActivityReport([NativeTypeName("ULONG")] uint Index, IMFSensorActivityReport** sensorActivityReport);
        [VtblIndex(5)]
        HRESULT GetActivityReportByDeviceName([NativeTypeName("LPCWSTR")] ushort* SymbolicName, IMFSensorActivityReport** sensorActivityReport);
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
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;
        [NativeTypeName("HRESULT (ULONG, IMFSensorActivityReport **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFSensorActivityReport**, int> GetActivityReport;
        [NativeTypeName("HRESULT (LPCWSTR, IMFSensorActivityReport **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IMFSensorActivityReport**, int> GetActivityReportByDeviceName;
    }
}