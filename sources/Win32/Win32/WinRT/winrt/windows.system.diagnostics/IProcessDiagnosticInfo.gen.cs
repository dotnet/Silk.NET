// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E830B04B-300E-4EE6-A0AB-5B5F5231B434")]
[NativeTypeName("struct IProcessDiagnosticInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProcessDiagnosticInfo : IProcessDiagnosticInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProcessDiagnosticInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProcessDiagnosticInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IProcessDiagnosticInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProcessDiagnosticInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IProcessDiagnosticInfo, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IProcessDiagnosticInfo, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IProcessDiagnosticInfo, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProcessId([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IProcessDiagnosticInfo, uint*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExecutableFileName(HSTRING* value)
    {
        return ((delegate* unmanaged<IProcessDiagnosticInfo, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Parent(
        [NativeTypeName("ABI::Windows::System::Diagnostics::IProcessDiagnosticInfo **")]
            IProcessDiagnosticInfo* value
    )
    {
        return (
            (delegate* unmanaged<IProcessDiagnosticInfo, IProcessDiagnosticInfo*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ProcessStartTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IProcessDiagnosticInfo, WinRTDateTime*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DiskUsage(
        [NativeTypeName("ABI::Windows::System::Diagnostics::IProcessDiskUsage **")]
            IProcessDiskUsage* value
    )
    {
        return (
            (delegate* unmanaged<IProcessDiagnosticInfo, IProcessDiskUsage*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MemoryUsage(
        [NativeTypeName("ABI::Windows::System::Diagnostics::IProcessMemoryUsage **")]
            IProcessMemoryUsage* value
    )
    {
        return (
            (delegate* unmanaged<IProcessDiagnosticInfo, IProcessMemoryUsage*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CpuUsage(
        [NativeTypeName("ABI::Windows::System::Diagnostics::IProcessCpuUsage **")]
            IProcessCpuUsage* value
    )
    {
        return (
            (delegate* unmanaged<IProcessDiagnosticInfo, IProcessCpuUsage*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProcessId([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_ExecutableFileName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Parent(
            [NativeTypeName("ABI::Windows::System::Diagnostics::IProcessDiagnosticInfo **")]
                IProcessDiagnosticInfo* value
        );

        [VtblIndex(9)]
        HRESULT get_ProcessStartTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(10)]
        HRESULT get_DiskUsage(
            [NativeTypeName("ABI::Windows::System::Diagnostics::IProcessDiskUsage **")]
                IProcessDiskUsage* value
        );

        [VtblIndex(11)]
        HRESULT get_MemoryUsage(
            [NativeTypeName("ABI::Windows::System::Diagnostics::IProcessMemoryUsage **")]
                IProcessMemoryUsage* value
        );

        [VtblIndex(12)]
        HRESULT get_CpuUsage(
            [NativeTypeName("ABI::Windows::System::Diagnostics::IProcessCpuUsage **")]
                IProcessCpuUsage* value
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ProcessId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ExecutableFileName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::Diagnostics::IProcessDiagnosticInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IProcessDiagnosticInfo*, int> get_Parent;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_ProcessStartTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::Diagnostics::IProcessDiskUsage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IProcessDiskUsage*, int> get_DiskUsage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::Diagnostics::IProcessMemoryUsage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IProcessMemoryUsage*, int> get_MemoryUsage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::Diagnostics::IProcessCpuUsage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IProcessCpuUsage*, int> get_CpuUsage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProcessDiagnosticInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProcessDiagnosticInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProcessDiagnosticInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProcessDiagnosticInfo(Silk.NET.WinRT.IInspectable value)
    {
        return new IProcessDiagnosticInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProcessDiagnosticInfo"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProcessDiagnosticInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IProcessDiagnosticInfo value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProcessDiagnosticInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProcessDiagnosticInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IProcessDiagnosticInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProcessDiagnosticInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProcessDiagnosticInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProcessDiagnosticInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
