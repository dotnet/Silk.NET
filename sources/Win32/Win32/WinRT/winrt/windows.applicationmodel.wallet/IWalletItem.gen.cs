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

[Guid("20B54BE8-118D-4EC4-996C-B963E7BD3E74")]
[NativeTypeName("struct IWalletItem : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
)]
public unsafe partial struct IWalletItem : IWalletItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletItem));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWalletItem, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWalletItem, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWalletItem, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWalletItem, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWalletItem, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWalletItem, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IWalletItem, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged<IWalletItem, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<IWalletItem, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_IsAcknowledged([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IWalletItem, byte*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_IsAcknowledged([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IWalletItem, byte, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_IssuerDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IWalletItem, HSTRING*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_IssuerDisplayName(HSTRING value)
    {
        return ((delegate* unmanaged<IWalletItem, HSTRING, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_LastUpdated(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return ((delegate* unmanaged<IWalletItem, IReference<DateTime>**, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_LastUpdated(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return ((delegate* unmanaged<IWalletItem, IReference<DateTime>*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Kind(
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletItemKind *")]
            WalletItemKind* value
    )
    {
        return ((delegate* unmanaged<IWalletItem, WalletItemKind*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Barcode(
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **")]
            IWalletBarcode* value
    )
    {
        return ((delegate* unmanaged<IWalletItem, IWalletBarcode*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_Barcode(
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode *")]
            IWalletBarcode value
    )
    {
        return ((delegate* unmanaged<IWalletItem, IWalletBarcode, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_ExpirationDate(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return ((delegate* unmanaged<IWalletItem, IReference<DateTime>**, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_ExpirationDate(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return ((delegate* unmanaged<IWalletItem, IReference<DateTime>*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Logo159x159(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference*, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_Logo159x159(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference, int>)((*lpVtbl)[21])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Logo336x336(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference*, int>)((*lpVtbl)[22])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_Logo336x336(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference, int>)((*lpVtbl)[23])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Logo99x99(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference*, int>)((*lpVtbl)[24])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_Logo99x99(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference, int>)((*lpVtbl)[25])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_DisplayMessage(HSTRING* value)
    {
        return ((delegate* unmanaged<IWalletItem, HSTRING*, int>)((*lpVtbl)[26]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_DisplayMessage(HSTRING value)
    {
        return ((delegate* unmanaged<IWalletItem, HSTRING, int>)((*lpVtbl)[27]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_IsDisplayMessageLaunchable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IWalletItem, byte*, int>)((*lpVtbl)[28]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_IsDisplayMessageLaunchable([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IWalletItem, byte, int>)((*lpVtbl)[29]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_LogoText(HSTRING* value)
    {
        return ((delegate* unmanaged<IWalletItem, HSTRING*, int>)((*lpVtbl)[30]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_LogoText(HSTRING value)
    {
        return ((delegate* unmanaged<IWalletItem, HSTRING, int>)((*lpVtbl)[31]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_HeaderColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IWalletItem, Color*, int>)((*lpVtbl)[32]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_HeaderColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<IWalletItem, Color, int>)((*lpVtbl)[33]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_BodyColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IWalletItem, Color*, int>)((*lpVtbl)[34]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_BodyColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<IWalletItem, Color, int>)((*lpVtbl)[35]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_HeaderFontColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IWalletItem, Color*, int>)((*lpVtbl)[36]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_HeaderFontColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<IWalletItem, Color, int>)((*lpVtbl)[37]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_BodyFontColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IWalletItem, Color*, int>)((*lpVtbl)[38]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_BodyFontColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<IWalletItem, Color, int>)((*lpVtbl)[39]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_HeaderBackgroundImage(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference*, int>)((*lpVtbl)[40])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_HeaderBackgroundImage(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference, int>)((*lpVtbl)[41])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_BodyBackgroundImage(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference*, int>)((*lpVtbl)[42])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_BodyBackgroundImage(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference, int>)((*lpVtbl)[43])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_LogoImage(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference*, int>)((*lpVtbl)[44])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_LogoImage(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference, int>)((*lpVtbl)[45])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_PromotionalImage(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference*, int>)((*lpVtbl)[46])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_PromotionalImage(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference value
    )
    {
        return (
            (delegate* unmanaged<IWalletItem, IRandomAccessStreamReference, int>)((*lpVtbl)[47])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_RelevantDate(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return ((delegate* unmanaged<IWalletItem, IReference<DateTime>**, int>)((*lpVtbl)[48]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_RelevantDate(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return ((delegate* unmanaged<IWalletItem, IReference<DateTime>*, int>)((*lpVtbl)[49]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_RelevantDateDisplayMessage(HSTRING* value)
    {
        return ((delegate* unmanaged<IWalletItem, HSTRING*, int>)((*lpVtbl)[50]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_RelevantDateDisplayMessage(HSTRING value)
    {
        return ((delegate* unmanaged<IWalletItem, HSTRING, int>)((*lpVtbl)[51]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_TransactionHistory(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletTransaction_t **"
        )]
            IMap<HSTRING, IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IWalletItem, IMap<HSTRING, IntPtr>**, int>)((*lpVtbl)[52]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_RelevantLocations(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletRelevantLocation_t **"
        )]
            IMap<HSTRING, IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IWalletItem, IMap<HSTRING, IntPtr>**, int>)((*lpVtbl)[53]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_IsMoreTransactionHistoryLaunchable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IWalletItem, byte*, int>)((*lpVtbl)[54]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_IsMoreTransactionHistoryLaunchable([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IWalletItem, byte, int>)((*lpVtbl)[55]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_DisplayProperties(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletItemCustomProperty_t **"
        )]
            IMap<HSTRING, IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IWalletItem, IMap<HSTRING, IntPtr>**, int>)((*lpVtbl)[56]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    [Obsolete(
        "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Verbs(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletVerb_t **"
        )]
            IMap<HSTRING, IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IWalletItem, IMap<HSTRING, IntPtr>**, int>)((*lpVtbl)[57]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(8)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_IsAcknowledged([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_IsAcknowledged([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_IssuerDisplayName(HSTRING* value);

        [VtblIndex(12)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_IssuerDisplayName(HSTRING value);

        [VtblIndex(13)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_LastUpdated(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(14)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_LastUpdated(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(15)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_Kind(
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletItemKind *")]
                WalletItemKind* value
        );

        [VtblIndex(16)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_Barcode(
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **")]
                IWalletBarcode* value
        );

        [VtblIndex(17)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_Barcode(
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode *")]
                IWalletBarcode value
        );

        [VtblIndex(18)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_ExpirationDate(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(19)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_ExpirationDate(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(20)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_Logo159x159(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* value
        );

        [VtblIndex(21)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_Logo159x159(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference value
        );

        [VtblIndex(22)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_Logo336x336(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* value
        );

        [VtblIndex(23)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_Logo336x336(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference value
        );

        [VtblIndex(24)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_Logo99x99(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* value
        );

        [VtblIndex(25)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_Logo99x99(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference value
        );

        [VtblIndex(26)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_DisplayMessage(HSTRING* value);

        [VtblIndex(27)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_DisplayMessage(HSTRING value);

        [VtblIndex(28)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_IsDisplayMessageLaunchable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(29)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_IsDisplayMessageLaunchable([NativeTypeName("boolean")] byte value);

        [VtblIndex(30)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_LogoText(HSTRING* value);

        [VtblIndex(31)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_LogoText(HSTRING value);

        [VtblIndex(32)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_HeaderColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(33)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_HeaderColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(34)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_BodyColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(35)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_BodyColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(36)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_HeaderFontColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(37)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_HeaderFontColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(38)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_BodyFontColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(39)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_BodyFontColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(40)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_HeaderBackgroundImage(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* value
        );

        [VtblIndex(41)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_HeaderBackgroundImage(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference value
        );

        [VtblIndex(42)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_BodyBackgroundImage(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* value
        );

        [VtblIndex(43)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_BodyBackgroundImage(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference value
        );

        [VtblIndex(44)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_LogoImage(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* value
        );

        [VtblIndex(45)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_LogoImage(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference value
        );

        [VtblIndex(46)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_PromotionalImage(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* value
        );

        [VtblIndex(47)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_PromotionalImage(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference value
        );

        [VtblIndex(48)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_RelevantDate(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(49)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_RelevantDate(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(50)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_RelevantDateDisplayMessage(HSTRING* value);

        [VtblIndex(51)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_RelevantDateDisplayMessage(HSTRING value);

        [VtblIndex(52)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_TransactionHistory(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletTransaction_t **"
            )]
                IMap<HSTRING, IntPtr>** value
        );

        [VtblIndex(53)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_RelevantLocations(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletRelevantLocation_t **"
            )]
                IMap<HSTRING, IntPtr>** value
        );

        [VtblIndex(54)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_IsMoreTransactionHistoryLaunchable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(55)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_IsMoreTransactionHistoryLaunchable([NativeTypeName("boolean")] byte value);

        [VtblIndex(56)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_DisplayProperties(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletItemCustomProperty_t **"
            )]
                IMap<HSTRING, IntPtr>** value
        );

        [VtblIndex(57)]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_Verbs(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletVerb_t **"
            )]
                IMap<HSTRING, IntPtr>** value
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
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsAcknowledged;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte, int> put_IsAcknowledged;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_IssuerDisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_IssuerDisplayName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_LastUpdated;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_LastUpdated;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletItemKind *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, WalletItemKind*, int> get_Kind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IWalletBarcode*, int> get_Barcode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Wallet::IWalletBarcode *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IWalletBarcode, int> put_Barcode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_ExpirationDate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_ExpirationDate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference*, int> get_Logo159x159;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference, int> put_Logo159x159;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference*, int> get_Logo336x336;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference, int> put_Logo336x336;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference*, int> get_Logo99x99;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference, int> put_Logo99x99;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayMessage;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DisplayMessage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsDisplayMessageLaunchable;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte, int> put_IsDisplayMessageLaunchable;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_LogoText;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_LogoText;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Color*, int> get_HeaderColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Color, int> put_HeaderColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Color*, int> get_BodyColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Color, int> put_BodyColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Color*, int> get_HeaderFontColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Color, int> put_HeaderFontColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Color*, int> get_BodyFontColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Color, int> put_BodyFontColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStreamReference*,
            int> get_HeaderBackgroundImage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStreamReference,
            int> put_HeaderBackgroundImage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStreamReference*,
            int> get_BodyBackgroundImage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStreamReference,
            int> put_BodyBackgroundImage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference*, int> get_LogoImage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference, int> put_LogoImage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference*, int> get_PromotionalImage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference, int> put_PromotionalImage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_RelevantDate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_RelevantDate;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RelevantDateDisplayMessage;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_RelevantDateDisplayMessage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletTransaction_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IMap<HSTRING, IntPtr>**, int> get_TransactionHistory;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletRelevantLocation_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IMap<HSTRING, IntPtr>**, int> get_RelevantLocations;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsMoreTransactionHistoryLaunchable;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte, int> put_IsMoreTransactionHistoryLaunchable;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletItemCustomProperty_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IMap<HSTRING, IntPtr>**, int> get_DisplayProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CApplicationModel__CWallet__CWalletVerb_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItem is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IMap<HSTRING, IntPtr>**, int> get_Verbs;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWalletItem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWalletItem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWalletItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWalletItem(Silk.NET.WinRT.IInspectable value)
    {
        return new IWalletItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletItem"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWalletItem value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWalletItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWalletItem(Silk.NET.Windows.IUnknown value)
    {
        return new IWalletItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletItem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWalletItem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
