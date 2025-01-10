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

[Guid("30117161-ED9C-469E-BBFD-306C95EA7108")]
[NativeTypeName("struct IWalletBarcodeFactory : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN."
)]
public unsafe partial struct IWalletBarcodeFactory : IWalletBarcodeFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletBarcodeFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWalletBarcodeFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWalletBarcodeFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWalletBarcodeFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWalletBarcodeFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWalletBarcodeFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWalletBarcodeFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT CreateWalletBarcode(
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletBarcodeSymbology")]
            WalletBarcodeSymbology symbology,
        HSTRING value,
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **")]
            IWalletBarcode* barcode
    )
    {
        return (
            (delegate* unmanaged<
                IWalletBarcodeFactory,
                WalletBarcodeSymbology,
                HSTRING,
                IWalletBarcode*,
                int>)((*lpVtbl)[6])
        )(this, symbology, value, barcode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT CreateCustomWalletBarcode(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference streamToBarcodeImage,
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **")]
            IWalletBarcode* barcode
    )
    {
        return (
            (delegate* unmanaged<
                IWalletBarcodeFactory,
                IRandomAccessStreamReference,
                IWalletBarcode*,
                int>)((*lpVtbl)[7])
        )(this, streamToBarcodeImage, barcode);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT CreateWalletBarcode(
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletBarcodeSymbology")]
                WalletBarcodeSymbology symbology,
            HSTRING value,
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **")]
                IWalletBarcode* barcode
        );

        [VtblIndex(7)]
        [Obsolete(
            "IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT CreateCustomWalletBarcode(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference streamToBarcodeImage,
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **")]
                IWalletBarcode* barcode
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
            "HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletBarcodeSymbology, HSTRING, ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            WalletBarcodeSymbology,
            HSTRING,
            IWalletBarcode*,
            int> CreateWalletBarcode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStreamReference,
            IWalletBarcode*,
            int> CreateCustomWalletBarcode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWalletBarcodeFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWalletBarcodeFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWalletBarcodeFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWalletBarcodeFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IWalletBarcodeFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletBarcodeFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletBarcodeFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWalletBarcodeFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWalletBarcodeFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWalletBarcodeFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IWalletBarcodeFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletBarcodeFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletBarcodeFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWalletBarcodeFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
