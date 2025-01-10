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

[Guid("A94A5847-348D-4A35-890E-8A1EF3798479")]
[NativeTypeName("struct IBackgroundDownloader2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundDownloader2 : IBackgroundDownloader2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundDownloader2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBackgroundDownloader2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBackgroundDownloader2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundDownloader2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBackgroundDownloader2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBackgroundDownloader2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBackgroundDownloader2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TransferGroup(
        [NativeTypeName(
            "ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup **"
        )]
            IBackgroundTransferGroup* value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundDownloader2, IBackgroundTransferGroup*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_TransferGroup(
        [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup *")]
            IBackgroundTransferGroup value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundDownloader2, IBackgroundTransferGroup, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SuccessToastNotification(
        [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification **")]
            IToastNotification* value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundDownloader2, IToastNotification*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SuccessToastNotification(
        [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")]
            IToastNotification value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundDownloader2, IToastNotification, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FailureToastNotification(
        [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification **")]
            IToastNotification* value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundDownloader2, IToastNotification*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_FailureToastNotification(
        [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")]
            IToastNotification value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundDownloader2, IToastNotification, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SuccessTileNotification(
        [NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification **")]
            ITileNotification* value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundDownloader2, ITileNotification*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_SuccessTileNotification(
        [NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification *")]
            ITileNotification value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundDownloader2, ITileNotification, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_FailureTileNotification(
        [NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification **")]
            ITileNotification* value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundDownloader2, ITileNotification*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_FailureTileNotification(
        [NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification *")]
            ITileNotification value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundDownloader2, ITileNotification, int>)((*lpVtbl)[15])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TransferGroup(
            [NativeTypeName(
                "ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup **"
            )]
                IBackgroundTransferGroup* value
        );

        [VtblIndex(7)]
        HRESULT put_TransferGroup(
            [NativeTypeName(
                "ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup *"
            )]
                IBackgroundTransferGroup value
        );

        [VtblIndex(8)]
        HRESULT get_SuccessToastNotification(
            [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification **")]
                IToastNotification* value
        );

        [VtblIndex(9)]
        HRESULT put_SuccessToastNotification(
            [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")]
                IToastNotification value
        );

        [VtblIndex(10)]
        HRESULT get_FailureToastNotification(
            [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification **")]
                IToastNotification* value
        );

        [VtblIndex(11)]
        HRESULT put_FailureToastNotification(
            [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")]
                IToastNotification value
        );

        [VtblIndex(12)]
        HRESULT get_SuccessTileNotification(
            [NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification **")]
                ITileNotification* value
        );

        [VtblIndex(13)]
        HRESULT put_SuccessTileNotification(
            [NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification *")]
                ITileNotification value
        );

        [VtblIndex(14)]
        HRESULT get_FailureTileNotification(
            [NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification **")]
                ITileNotification* value
        );

        [VtblIndex(15)]
        HRESULT put_FailureTileNotification(
            [NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification *")]
                ITileNotification value
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
            "HRESULT (ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBackgroundTransferGroup*, int> get_TransferGroup;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBackgroundTransferGroup, int> put_TransferGroup;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::IToastNotification **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IToastNotification*, int> get_SuccessToastNotification;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::IToastNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IToastNotification, int> put_SuccessToastNotification;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::IToastNotification **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IToastNotification*, int> get_FailureToastNotification;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::IToastNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IToastNotification, int> put_FailureToastNotification;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::ITileNotification **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITileNotification*, int> get_SuccessTileNotification;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::ITileNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITileNotification, int> put_SuccessTileNotification;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::ITileNotification **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITileNotification*, int> get_FailureTileNotification;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::ITileNotification *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITileNotification, int> put_FailureTileNotification;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundDownloader2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundDownloader2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundDownloader2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundDownloader2(Silk.NET.WinRT.IInspectable value)
    {
        return new IBackgroundDownloader2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundDownloader2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundDownloader2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBackgroundDownloader2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundDownloader2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundDownloader2(Silk.NET.Windows.IUnknown value)
    {
        return new IBackgroundDownloader2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundDownloader2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundDownloader2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBackgroundDownloader2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
