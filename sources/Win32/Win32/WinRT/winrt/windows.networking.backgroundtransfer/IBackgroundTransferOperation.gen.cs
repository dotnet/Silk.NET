// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("DED06846-90CA-44FB-8FB1-124154C0D539")]
[NativeTypeName("struct IBackgroundTransferOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTransferOperation
    : IBackgroundTransferOperation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTransferOperation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBackgroundTransferOperation, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBackgroundTransferOperation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundTransferOperation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferOperation, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBackgroundTransferOperation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBackgroundTransferOperation, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Guid(Guid* value)
    {
        return ((delegate* unmanaged<IBackgroundTransferOperation, Guid*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RequestedUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferOperation, IUriRuntimeClass*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Method(HSTRING* value)
    {
        return ((delegate* unmanaged<IBackgroundTransferOperation, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup."
    )]
    public HRESULT get_Group(HSTRING* value)
    {
        return ((delegate* unmanaged<IBackgroundTransferOperation, HSTRING*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CostPolicy(
        [NativeTypeName(
            "ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy *"
        )]
            BackgroundTransferCostPolicy* value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferOperation, BackgroundTransferCostPolicy*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CostPolicy(
        [NativeTypeName(
            "ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy"
        )]
            BackgroundTransferCostPolicy value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferOperation, BackgroundTransferCostPolicy, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetResultStreamAt(
        [NativeTypeName("UINT64")] ulong position,
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream* value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferOperation, ulong, IInputStream*, int>)(
                (*lpVtbl)[12]
            )
        )(this, position, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetResponseInformation(
        [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IResponseInformation **")]
            IResponseInformation* value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferOperation, IResponseInformation*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Guid(Guid* value);

        [VtblIndex(7)]
        HRESULT get_RequestedUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(8)]
        HRESULT get_Method(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete(
            "Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup."
        )]
        HRESULT get_Group(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_CostPolicy(
            [NativeTypeName(
                "ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy *"
            )]
                BackgroundTransferCostPolicy* value
        );

        [VtblIndex(11)]
        HRESULT put_CostPolicy(
            [NativeTypeName(
                "ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy"
            )]
                BackgroundTransferCostPolicy value
        );

        [VtblIndex(12)]
        HRESULT GetResultStreamAt(
            [NativeTypeName("UINT64")] ulong position,
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream* value
        );

        [VtblIndex(13)]
        HRESULT GetResponseInformation(
            [NativeTypeName(
                "ABI::Windows::Networking::BackgroundTransfer::IResponseInformation **"
            )]
                IResponseInformation* value
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
        public delegate* unmanaged<TSelf*, Guid*, int> get_Guid;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_RequestedUri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Method;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Group;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BackgroundTransferCostPolicy*, int> get_CostPolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BackgroundTransferCostPolicy, int> put_CostPolicy;

        [NativeTypeName(
            "HRESULT (UINT64, ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ulong, IInputStream*, int> GetResultStreamAt;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::BackgroundTransfer::IResponseInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IResponseInformation*, int> GetResponseInformation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundTransferOperation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundTransferOperation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundTransferOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundTransferOperation(Silk.NET.WinRT.IInspectable value)
    {
        return new IBackgroundTransferOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTransferOperation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTransferOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBackgroundTransferOperation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundTransferOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundTransferOperation(Silk.NET.Windows.IUnknown value)
    {
        return new IBackgroundTransferOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTransferOperation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTransferOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBackgroundTransferOperation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
