// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFSensorActivitiesReportCallback.xml' path='doc/member[@name="IMFSensorActivitiesReportCallback"]/*'/>
[Guid("DE5072EE-DBE3-46DC-8A87-B6F631194751")]
[NativeTypeName("struct IMFSensorActivitiesReportCallback : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFSensorActivitiesReportCallback : IMFSensorActivitiesReportCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSensorActivitiesReportCallback));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSensorActivitiesReportCallback*, Guid*, void**, int> )(lpVtbl[0]))((IMFSensorActivitiesReportCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSensorActivitiesReportCallback*, uint> )(lpVtbl[1]))((IMFSensorActivitiesReportCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSensorActivitiesReportCallback*, uint> )(lpVtbl[2]))((IMFSensorActivitiesReportCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSensorActivitiesReportCallback.xml' path='doc/member[@name="IMFSensorActivitiesReportCallback.OnActivitiesReport"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnActivitiesReport(IMFSensorActivitiesReport* sensorActivitiesReport)
    {
        return ((delegate* unmanaged<IMFSensorActivitiesReportCallback*, IMFSensorActivitiesReport*, int> )(lpVtbl[3]))((IMFSensorActivitiesReportCallback*)Unsafe.AsPointer(ref this), sensorActivitiesReport);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnActivitiesReport(IMFSensorActivitiesReport* sensorActivitiesReport);
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
        public delegate* unmanaged<TSelf*, IMFSensorActivitiesReport*, int> OnActivitiesReport;
    }
}