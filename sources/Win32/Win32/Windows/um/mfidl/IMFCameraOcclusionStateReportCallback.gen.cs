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

[Guid("6E5841C7-3889-4019-9035-783FB19B5948")]
[NativeTypeName("struct IMFCameraOcclusionStateReportCallback : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.22000.0")]
public unsafe partial struct IMFCameraOcclusionStateReportCallback
    : IMFCameraOcclusionStateReportCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCameraOcclusionStateReportCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFCameraOcclusionStateReportCallback, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateReportCallback, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateReportCallback, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnOcclusionStateReport(IMFCameraOcclusionStateReport occlusionStateReport)
    {
        return (
            (delegate* unmanaged<
                IMFCameraOcclusionStateReportCallback,
                IMFCameraOcclusionStateReport,
                int>)((*lpVtbl)[3])
        )(this, occlusionStateReport);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnOcclusionStateReport(IMFCameraOcclusionStateReport occlusionStateReport);
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
        public delegate* unmanaged<
            TSelf*,
            IMFCameraOcclusionStateReport,
            int> OnOcclusionStateReport;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFCameraOcclusionStateReportCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFCameraOcclusionStateReportCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFCameraOcclusionStateReportCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFCameraOcclusionStateReportCallback(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMFCameraOcclusionStateReportCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFCameraOcclusionStateReportCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFCameraOcclusionStateReportCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMFCameraOcclusionStateReportCallback value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
