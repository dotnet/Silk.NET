// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("977A8B8C-3885-40F3-8851-42CD2BD568BB")]
[NativeTypeName("struct IDataPlanStatus : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataPlanStatus : IDataPlanStatus.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataPlanStatus));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataPlanStatus, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDataPlanStatus, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataPlanStatus, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDataPlanStatus, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDataPlanStatus, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDataPlanStatus, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DataPlanUsage(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::IDataPlanUsage **")]
            IDataPlanUsage* value
    )
    {
        return ((delegate* unmanaged<IDataPlanStatus, IDataPlanUsage*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DataLimitInMegabytes(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return ((delegate* unmanaged<IDataPlanStatus, IReference<uint>**, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InboundBitsPerSecond(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
            IReference<ulong>** value
    )
    {
        return ((delegate* unmanaged<IDataPlanStatus, IReference<ulong>**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_OutboundBitsPerSecond(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
            IReference<ulong>** value
    )
    {
        return ((delegate* unmanaged<IDataPlanStatus, IReference<ulong>**, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_NextBillingCycle(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return ((delegate* unmanaged<IDataPlanStatus, IReference<DateTime>**, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MaxTransferSizeInMegabytes(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return ((delegate* unmanaged<IDataPlanStatus, IReference<uint>**, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DataPlanUsage(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::IDataPlanUsage **")]
                IDataPlanUsage* value
        );

        [VtblIndex(7)]
        HRESULT get_DataLimitInMegabytes(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(8)]
        HRESULT get_InboundBitsPerSecond(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
                IReference<ulong>** value
        );

        [VtblIndex(9)]
        HRESULT get_OutboundBitsPerSecond(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
                IReference<ulong>** value
        );

        [VtblIndex(10)]
        HRESULT get_NextBillingCycle(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(11)]
        HRESULT get_MaxTransferSizeInMegabytes(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::IDataPlanUsage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDataPlanUsage*, int> get_DataPlanUsage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_DataLimitInMegabytes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ulong>**, int> get_InboundBitsPerSecond;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ulong>**, int> get_OutboundBitsPerSecond;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_NextBillingCycle;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_MaxTransferSizeInMegabytes;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataPlanStatus"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataPlanStatus(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDataPlanStatus"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDataPlanStatus(Silk.NET.WinRT.IInspectable value)
    {
        return new IDataPlanStatus(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataPlanStatus"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDataPlanStatus"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDataPlanStatus value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataPlanStatus"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataPlanStatus(Silk.NET.Windows.IUnknown value)
    {
        return new IDataPlanStatus(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataPlanStatus"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataPlanStatus"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataPlanStatus value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
