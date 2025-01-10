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

[Guid("C2C77CBA-1951-4685-8532-7E749ECF8EEB")]
[NativeTypeName("struct IProcessMemoryUsageReport : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProcessMemoryUsageReport
    : IProcessMemoryUsageReport.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProcessMemoryUsageReport));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IProcessMemoryUsageReport, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NonPagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, ulong*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PageFaultCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, uint*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PageFileSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, ulong*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, ulong*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PeakNonPagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, ulong*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PeakPageFileSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, ulong*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PeakPagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, ulong*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PeakVirtualMemorySizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, ulong*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PeakWorkingSetSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, ulong*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PrivatePageCount([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, ulong*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_VirtualMemorySizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, ulong*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_WorkingSetSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IProcessMemoryUsageReport, ulong*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NonPagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT get_PageFaultCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_PageFileSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(9)]
        HRESULT get_PagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(10)]
        HRESULT get_PeakNonPagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(11)]
        HRESULT get_PeakPageFileSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(12)]
        HRESULT get_PeakPagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(13)]
        HRESULT get_PeakVirtualMemorySizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(14)]
        HRESULT get_PeakWorkingSetSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(15)]
        HRESULT get_PrivatePageCount([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(16)]
        HRESULT get_VirtualMemorySizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(17)]
        HRESULT get_WorkingSetSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_NonPagedPoolSizeInBytes;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_PageFaultCount;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_PageFileSizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_PagedPoolSizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_PeakNonPagedPoolSizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_PeakPageFileSizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_PeakPagedPoolSizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_PeakVirtualMemorySizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_PeakWorkingSetSizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_PrivatePageCount;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_VirtualMemorySizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_WorkingSetSizeInBytes;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProcessMemoryUsageReport"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProcessMemoryUsageReport(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProcessMemoryUsageReport"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProcessMemoryUsageReport(Silk.NET.WinRT.IInspectable value)
    {
        return new IProcessMemoryUsageReport(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProcessMemoryUsageReport"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProcessMemoryUsageReport"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IProcessMemoryUsageReport value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProcessMemoryUsageReport"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProcessMemoryUsageReport(Silk.NET.Windows.IUnknown value)
    {
        return new IProcessMemoryUsageReport(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProcessMemoryUsageReport"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProcessMemoryUsageReport"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProcessMemoryUsageReport value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
