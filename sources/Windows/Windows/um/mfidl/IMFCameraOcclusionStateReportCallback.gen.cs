// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFCameraOcclusionStateReportCallback.xml' path='doc/member[@name="IMFCameraOcclusionStateReportCallback"]/*' />
[Guid("6E5841C7-3889-4019-9035-783FB19B5948")]
[NativeTypeName("struct IMFCameraOcclusionStateReportCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFCameraOcclusionStateReportCallback : IMFCameraOcclusionStateReportCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCameraOcclusionStateReportCallback));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateReportCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFCameraOcclusionStateReportCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateReportCallback*, uint>)(lpVtbl[1]))((IMFCameraOcclusionStateReportCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateReportCallback*, uint>)(lpVtbl[2]))((IMFCameraOcclusionStateReportCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCameraOcclusionStateReportCallback.xml' path='doc/member[@name="IMFCameraOcclusionStateReportCallback.OnOcclusionStateReport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnOcclusionStateReport(IMFCameraOcclusionStateReport* occlusionStateReport)
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateReportCallback*, IMFCameraOcclusionStateReport*, int>)(lpVtbl[3]))((IMFCameraOcclusionStateReportCallback*)Unsafe.AsPointer(ref this), occlusionStateReport);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnOcclusionStateReport(IMFCameraOcclusionStateReport* occlusionStateReport);
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

        [NativeTypeName("HRESULT (IMFCameraOcclusionStateReport *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFCameraOcclusionStateReport*, int> OnOcclusionStateReport;
    }
}
