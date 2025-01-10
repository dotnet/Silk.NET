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

[Guid("2A9DA250-C769-458C-AFE8-FEB8D4D3B2EF")]
[NativeTypeName("struct IBackgroundTransferBase : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTransferBase
    : IBackgroundTransferBase.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTransferBase));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBackgroundTransferBase, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBackgroundTransferBase, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundTransferBase, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBackgroundTransferBase, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBackgroundTransferBase, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBackgroundTransferBase, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetRequestHeader(HSTRING headerName, HSTRING headerValue)
    {
        return (
            (delegate* unmanaged<IBackgroundTransferBase, HSTRING, HSTRING, int>)((*lpVtbl)[6])
        )(this, headerName, headerValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ServerCredential(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
            IPasswordCredential* credential
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferBase, IPasswordCredential*, int>)((*lpVtbl)[7])
        )(this, credential);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ServerCredential(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
            IPasswordCredential credential
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferBase, IPasswordCredential, int>)((*lpVtbl)[8])
        )(this, credential);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ProxyCredential(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
            IPasswordCredential* credential
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferBase, IPasswordCredential*, int>)((*lpVtbl)[9])
        )(this, credential);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ProxyCredential(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
            IPasswordCredential credential
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferBase, IPasswordCredential, int>)((*lpVtbl)[10])
        )(this, credential);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Method(HSTRING* value)
    {
        return ((delegate* unmanaged<IBackgroundTransferBase, HSTRING*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Method(HSTRING value)
    {
        return ((delegate* unmanaged<IBackgroundTransferBase, HSTRING, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete(
        "Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup."
    )]
    public HRESULT get_Group(HSTRING* value)
    {
        return ((delegate* unmanaged<IBackgroundTransferBase, HSTRING*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete(
        "Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup."
    )]
    public HRESULT put_Group(HSTRING value)
    {
        return ((delegate* unmanaged<IBackgroundTransferBase, HSTRING, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_CostPolicy(
        [NativeTypeName(
            "ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy *"
        )]
            BackgroundTransferCostPolicy* value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferBase, BackgroundTransferCostPolicy*, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_CostPolicy(
        [NativeTypeName(
            "ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy"
        )]
            BackgroundTransferCostPolicy value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferBase, BackgroundTransferCostPolicy, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetRequestHeader(HSTRING headerName, HSTRING headerValue);

        [VtblIndex(7)]
        HRESULT get_ServerCredential(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
                IPasswordCredential* credential
        );

        [VtblIndex(8)]
        HRESULT put_ServerCredential(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
                IPasswordCredential credential
        );

        [VtblIndex(9)]
        HRESULT get_ProxyCredential(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
                IPasswordCredential* credential
        );

        [VtblIndex(10)]
        HRESULT put_ProxyCredential(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
                IPasswordCredential credential
        );

        [VtblIndex(11)]
        HRESULT get_Method(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_Method(HSTRING value);

        [VtblIndex(13)]
        [Obsolete(
            "Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup."
        )]
        HRESULT get_Group(HSTRING* value);

        [VtblIndex(14)]
        [Obsolete(
            "Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup."
        )]
        HRESULT put_Group(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_CostPolicy(
            [NativeTypeName(
                "ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy *"
            )]
                BackgroundTransferCostPolicy* value
        );

        [VtblIndex(16)]
        HRESULT put_CostPolicy(
            [NativeTypeName(
                "ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy"
            )]
                BackgroundTransferCostPolicy value
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, int> SetRequestHeader;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential*, int> get_ServerCredential;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential, int> put_ServerCredential;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential*, int> get_ProxyCredential;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential, int> put_ProxyCredential;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Method;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Method;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Group;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Group;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BackgroundTransferCostPolicy*, int> get_CostPolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BackgroundTransferCostPolicy, int> put_CostPolicy;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundTransferBase"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundTransferBase(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundTransferBase"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundTransferBase(Silk.NET.WinRT.IInspectable value)
    {
        return new IBackgroundTransferBase(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTransferBase"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTransferBase"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBackgroundTransferBase value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundTransferBase"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundTransferBase(Silk.NET.Windows.IUnknown value)
    {
        return new IBackgroundTransferBase(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTransferBase"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTransferBase"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBackgroundTransferBase value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
