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

[Guid("421AF7F6-573E-4AD0-8FDA-2E57CEDB18C6")]
[NativeTypeName("struct IMFRelativePanelWatcher : IMFShutdown")]
[NativeInheritance("IMFShutdown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IMFRelativePanelWatcher
    : IMFRelativePanelWatcher.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFRelativePanelWatcher));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFRelativePanelWatcher, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFRelativePanelWatcher, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFRelativePanelWatcher, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFRelativePanelWatcher, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetShutdownStatus(MFSHUTDOWN_STATUS* pStatus)
    {
        return (
            (delegate* unmanaged<IMFRelativePanelWatcher, MFSHUTDOWN_STATUS*, int>)((*lpVtbl)[4])
        )(this, pStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BeginGetReport(IMFAsyncCallback pCallback, IUnknown pState)
    {
        return (
            (delegate* unmanaged<IMFRelativePanelWatcher, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[5]
            )
        )(this, pCallback, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EndGetReport(
        IMFAsyncResult pResult,
        IMFRelativePanelReport* ppRelativePanelReport
    )
    {
        return (
            (delegate* unmanaged<
                IMFRelativePanelWatcher,
                IMFAsyncResult,
                IMFRelativePanelReport*,
                int>)((*lpVtbl)[6])
        )(this, pResult, ppRelativePanelReport);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetReport(IMFRelativePanelReport* ppRelativePanelReport)
    {
        return (
            (delegate* unmanaged<IMFRelativePanelWatcher, IMFRelativePanelReport*, int>)(
                (*lpVtbl)[7]
            )
        )(this, ppRelativePanelReport);
    }

    public interface Interface : IMFShutdown.Interface
    {
        [VtblIndex(5)]
        HRESULT BeginGetReport(IMFAsyncCallback pCallback, IUnknown pState);

        [VtblIndex(6)]
        HRESULT EndGetReport(IMFAsyncResult pResult, IMFRelativePanelReport* ppRelativePanelReport);

        [VtblIndex(7)]
        HRESULT GetReport(IMFRelativePanelReport* ppRelativePanelReport);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;

        [NativeTypeName("HRESULT (MFSHUTDOWN_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFSHUTDOWN_STATUS*, int> GetShutdownStatus;

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback, IUnknown, int> BeginGetReport;

        [NativeTypeName(
            "HRESULT (IMFAsyncResult *, IMFRelativePanelReport **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncResult,
            IMFRelativePanelReport*,
            int> EndGetReport;

        [NativeTypeName("HRESULT (IMFRelativePanelReport **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFRelativePanelReport*, int> GetReport;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFRelativePanelWatcher"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFRelativePanelWatcher(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFShutdown"/> to <see cref = "IMFRelativePanelWatcher"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFShutdown"/> instance to be converted </param>
    public static explicit operator IMFRelativePanelWatcher(Silk.NET.Windows.IMFShutdown value)
    {
        return new IMFRelativePanelWatcher(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFRelativePanelWatcher"/> to <see cref = "Silk.NET.Windows.IMFShutdown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFRelativePanelWatcher"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFShutdown(IMFRelativePanelWatcher value)
    {
        return new Silk.NET.Windows.IMFShutdown(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFRelativePanelWatcher"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFRelativePanelWatcher(Silk.NET.Windows.IUnknown value)
    {
        return new IMFRelativePanelWatcher(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFRelativePanelWatcher"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFRelativePanelWatcher"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFRelativePanelWatcher value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
