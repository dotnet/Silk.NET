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

[Guid("B913F77A-E807-49F4-845E-7B8BDCFE8EE7")]
[NativeTypeName("struct IAppResourceGroupInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppResourceGroupInfo : IAppResourceGroupInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppResourceGroupInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppResourceGroupInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppResourceGroupInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppResourceGroupInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppResourceGroupInfo, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppResourceGroupInfo, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppResourceGroupInfo, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InstanceId(Guid* value)
    {
        return ((delegate* unmanaged<IAppResourceGroupInfo, Guid*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsShared([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppResourceGroupInfo, byte*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBackgroundTaskReports(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppResourceGroupBackgroundTaskReport_t **"
        )]
            IVector<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IAppResourceGroupInfo, IVector<IntPtr>**, int>)((*lpVtbl)[8]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetMemoryReport(
        [NativeTypeName("ABI::Windows::System::IAppResourceGroupMemoryReport **")]
            IAppResourceGroupMemoryReport* result
    )
    {
        return (
            (delegate* unmanaged<IAppResourceGroupInfo, IAppResourceGroupMemoryReport*, int>)(
                (*lpVtbl)[9]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetProcessDiagnosticInfos(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CDiagnostics__CProcessDiagnosticInfo_t **"
        )]
            IVector<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IAppResourceGroupInfo, IVector<IntPtr>**, int>)((*lpVtbl)[10])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStateReport(
        [NativeTypeName("ABI::Windows::System::IAppResourceGroupStateReport **")]
            IAppResourceGroupStateReport* result
    )
    {
        return (
            (delegate* unmanaged<IAppResourceGroupInfo, IAppResourceGroupStateReport*, int>)(
                (*lpVtbl)[11]
            )
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InstanceId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_IsShared([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT GetBackgroundTaskReports(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppResourceGroupBackgroundTaskReport_t **"
            )]
                IVector<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT GetMemoryReport(
            [NativeTypeName("ABI::Windows::System::IAppResourceGroupMemoryReport **")]
                IAppResourceGroupMemoryReport* result
        );

        [VtblIndex(10)]
        HRESULT GetProcessDiagnosticInfos(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CDiagnostics__CProcessDiagnosticInfo_t **"
            )]
                IVector<IntPtr>** result
        );

        [VtblIndex(11)]
        HRESULT GetStateReport(
            [NativeTypeName("ABI::Windows::System::IAppResourceGroupStateReport **")]
                IAppResourceGroupStateReport* result
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_InstanceId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsShared;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppResourceGroupBackgroundTaskReport_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> GetBackgroundTaskReports;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IAppResourceGroupMemoryReport **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppResourceGroupMemoryReport*, int> GetMemoryReport;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CDiagnostics__CProcessDiagnosticInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> GetProcessDiagnosticInfos;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IAppResourceGroupStateReport **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppResourceGroupStateReport*, int> GetStateReport;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppResourceGroupInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppResourceGroupInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppResourceGroupInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppResourceGroupInfo(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppResourceGroupInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppResourceGroupInfo"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppResourceGroupInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppResourceGroupInfo value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppResourceGroupInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppResourceGroupInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IAppResourceGroupInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppResourceGroupInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppResourceGroupInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppResourceGroupInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
