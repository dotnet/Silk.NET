// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2C8C06B1-7DB1-4C51-A225-7FAE2D49E431")]
[NativeTypeName("struct IAppResourceGroupMemoryReport : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppResourceGroupMemoryReport
    : IAppResourceGroupMemoryReport.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppResourceGroupMemoryReport));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppResourceGroupMemoryReport, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppResourceGroupMemoryReport, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppResourceGroupMemoryReport, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAppResourceGroupMemoryReport, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppResourceGroupMemoryReport, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAppResourceGroupMemoryReport, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CommitUsageLimit([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IAppResourceGroupMemoryReport, ulong*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CommitUsageLevel(
        [NativeTypeName("ABI::Windows::System::AppMemoryUsageLevel *")] AppMemoryUsageLevel* value
    )
    {
        return (
            (delegate* unmanaged<IAppResourceGroupMemoryReport, AppMemoryUsageLevel*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PrivateCommitUsage([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IAppResourceGroupMemoryReport, ulong*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TotalCommitUsage([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IAppResourceGroupMemoryReport, ulong*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CommitUsageLimit([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT get_CommitUsageLevel(
            [NativeTypeName("ABI::Windows::System::AppMemoryUsageLevel *")]
                AppMemoryUsageLevel* value
        );

        [VtblIndex(8)]
        HRESULT get_PrivateCommitUsage([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(9)]
        HRESULT get_TotalCommitUsage([NativeTypeName("UINT64 *")] ulong* value);
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
        public delegate* unmanaged<TSelf*, ulong*, int> get_CommitUsageLimit;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::AppMemoryUsageLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppMemoryUsageLevel*, int> get_CommitUsageLevel;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_PrivateCommitUsage;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_TotalCommitUsage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppResourceGroupMemoryReport"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppResourceGroupMemoryReport(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppResourceGroupMemoryReport"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppResourceGroupMemoryReport(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppResourceGroupMemoryReport(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppResourceGroupMemoryReport"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppResourceGroupMemoryReport"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppResourceGroupMemoryReport value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppResourceGroupMemoryReport"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppResourceGroupMemoryReport(Silk.NET.Windows.IUnknown value)
    {
        return new IAppResourceGroupMemoryReport(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppResourceGroupMemoryReport"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppResourceGroupMemoryReport"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppResourceGroupMemoryReport value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
