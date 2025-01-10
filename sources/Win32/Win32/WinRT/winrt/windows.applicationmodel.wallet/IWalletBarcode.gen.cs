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

[Guid("4F857B29-DE80-4EA4-A1CD-81CD084DAC27")]
[NativeTypeName("struct IWalletBarcode : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN."
)]
public unsafe partial struct IWalletBarcode : IWalletBarcode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletBarcode));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWalletBarcode, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWalletBarcode, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWalletBarcode, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWalletBarcode, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWalletBarcode, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWalletBarcode, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Symbology(
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletBarcodeSymbology *")]
            WalletBarcodeSymbology* value
    )
    {
        return ((delegate* unmanaged<IWalletBarcode, WalletBarcodeSymbology*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Value(HSTRING* value)
    {
        return ((delegate* unmanaged<IWalletBarcode, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT GetImageAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IWalletBarcode, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[8])
        )(this, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_Symbology(
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletBarcodeSymbology *")]
                WalletBarcodeSymbology* value
        );

        [VtblIndex(7)]
        [Obsolete(
            "IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_Value(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete(
            "IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT GetImageAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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
            "HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletBarcodeSymbology *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, WalletBarcodeSymbology*, int> get_Symbology;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Value;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetImageAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWalletBarcode"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWalletBarcode(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWalletBarcode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWalletBarcode(Silk.NET.WinRT.IInspectable value)
    {
        return new IWalletBarcode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletBarcode"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletBarcode"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWalletBarcode value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWalletBarcode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWalletBarcode(Silk.NET.Windows.IUnknown value)
    {
        return new IWalletBarcode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletBarcode"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletBarcode"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWalletBarcode value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
