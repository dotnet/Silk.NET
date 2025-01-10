// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B94B40F3-FA00-40FD-98DC-9DE46697F1E7")]
[NativeTypeName("struct IWalletItemCustomProperty : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
)]
public unsafe partial struct IWalletItemCustomProperty
    : IWalletItemCustomProperty.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletItemCustomProperty));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWalletItemCustomProperty, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWalletItemCustomProperty, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWalletItemCustomProperty, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWalletItemCustomProperty, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWalletItemCustomProperty, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWalletItemCustomProperty, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IWalletItemCustomProperty, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_Name(HSTRING value)
    {
        return ((delegate* unmanaged<IWalletItemCustomProperty, HSTRING, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Value(HSTRING* value)
    {
        return ((delegate* unmanaged<IWalletItemCustomProperty, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_Value(HSTRING value)
    {
        return ((delegate* unmanaged<IWalletItemCustomProperty, HSTRING, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete(
        "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_AutoDetectLinks([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IWalletItemCustomProperty, byte*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete(
        "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_AutoDetectLinks([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IWalletItemCustomProperty, byte, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete(
        "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_DetailViewPosition(
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletDetailViewPosition *")]
            WalletDetailViewPosition* value
    )
    {
        return (
            (delegate* unmanaged<IWalletItemCustomProperty, WalletDetailViewPosition*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete(
        "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_DetailViewPosition(
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletDetailViewPosition")]
            WalletDetailViewPosition value
    )
    {
        return (
            (delegate* unmanaged<IWalletItemCustomProperty, WalletDetailViewPosition, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete(
        "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_SummaryViewPosition(
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletSummaryViewPosition *")]
            WalletSummaryViewPosition* value
    )
    {
        return (
            (delegate* unmanaged<IWalletItemCustomProperty, WalletSummaryViewPosition*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete(
        "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_SummaryViewPosition(
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletSummaryViewPosition")]
            WalletSummaryViewPosition value
    )
    {
        return (
            (delegate* unmanaged<IWalletItemCustomProperty, WalletSummaryViewPosition, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_Name(HSTRING value);

        [VtblIndex(8)]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_Value(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_Value(HSTRING value);

        [VtblIndex(10)]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_AutoDetectLinks([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_AutoDetectLinks([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_DetailViewPosition(
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletDetailViewPosition *")]
                WalletDetailViewPosition* value
        );

        [VtblIndex(13)]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_DetailViewPosition(
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletDetailViewPosition")]
                WalletDetailViewPosition value
        );

        [VtblIndex(14)]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_SummaryViewPosition(
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletSummaryViewPosition *")]
                WalletSummaryViewPosition* value
        );

        [VtblIndex(15)]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_SummaryViewPosition(
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletSummaryViewPosition")]
                WalletSummaryViewPosition value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Value;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Value;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_AutoDetectLinks;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte, int> put_AutoDetectLinks;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletDetailViewPosition *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, WalletDetailViewPosition*, int> get_DetailViewPosition;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletDetailViewPosition) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, WalletDetailViewPosition, int> put_DetailViewPosition;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletSummaryViewPosition *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, WalletSummaryViewPosition*, int> get_SummaryViewPosition;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletSummaryViewPosition) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, WalletSummaryViewPosition, int> put_SummaryViewPosition;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWalletItemCustomProperty"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWalletItemCustomProperty(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWalletItemCustomProperty"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWalletItemCustomProperty(Silk.NET.WinRT.IInspectable value)
    {
        return new IWalletItemCustomProperty(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletItemCustomProperty"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletItemCustomProperty"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWalletItemCustomProperty value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWalletItemCustomProperty"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWalletItemCustomProperty(Silk.NET.Windows.IUnknown value)
    {
        return new IWalletItemCustomProperty(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletItemCustomProperty"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletItemCustomProperty"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWalletItemCustomProperty value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
