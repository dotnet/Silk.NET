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

[Guid("7160484B-6D49-48F8-91A9-40A1D0F13EF4")]
[NativeTypeName("struct IWalletItemStore : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
)]
public unsafe partial struct IWalletItemStore : IWalletItemStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletItemStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWalletItemStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWalletItemStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWalletItemStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWalletItemStore, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWalletItemStore, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWalletItemStore, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT AddAsync(
        HSTRING id,
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItem *")] IWalletItem item,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IWalletItemStore, HSTRING, IWalletItem, IAsyncAction*, int>)(
                (*lpVtbl)[6]
            )
        )(this, id, item, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT ClearAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IWalletItemStore, IAsyncAction*, int>)((*lpVtbl)[7]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT GetWalletItemAsync(
        HSTRING id,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CWallet__CWalletItem_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IWalletItemStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, id, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT GetItemsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CWallet__CWalletItem_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IWalletItemStore, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[9])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete(
        "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT GetItemsWithKindAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletItemKind")]
            WalletItemKind kind,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CWallet__CWalletItem_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IWalletItemStore, WalletItemKind, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, kind, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete(
        "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT ImportItemAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference stream,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CWallet__CWalletItem_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IWalletItemStore,
                IRandomAccessStreamReference,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, stream, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete(
        "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT DeleteAsync(
        HSTRING id,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IWalletItemStore, HSTRING, IAsyncAction*, int>)((*lpVtbl)[12])
        )(this, id, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete(
        "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT ShowAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IWalletItemStore, IAsyncAction*, int>)((*lpVtbl)[13]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete(
        "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT ShowItemAsync(
        HSTRING id,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IWalletItemStore, HSTRING, IAsyncAction*, int>)((*lpVtbl)[14])
        )(this, id, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete(
        "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT UpdateAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItem *")] IWalletItem item,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IWalletItemStore, IWalletItem, IAsyncAction*, int>)((*lpVtbl)[15])
        )(this, item, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT AddAsync(
            HSTRING id,
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItem *")]
                IWalletItem item,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(7)]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT ClearAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(8)]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT GetWalletItemAsync(
            HSTRING id,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CWallet__CWalletItem_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(9)]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT GetItemsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CWallet__CWalletItem_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(10)]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT GetItemsWithKindAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletItemKind")]
                WalletItemKind kind,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CWallet__CWalletItem_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(11)]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT ImportItemAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference stream,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CWallet__CWalletItem_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(12)]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT DeleteAsync(
            HSTRING id,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(13)]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT ShowAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(14)]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT ShowItemAsync(
            HSTRING id,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(15)]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT UpdateAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItem *")]
                IWalletItem item,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
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
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Wallet::IWalletItem *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IWalletItem, IAsyncAction*, int> AddAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> ClearAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CWallet__CWalletItem_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetWalletItemAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CWallet__CWalletItem_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetItemsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletItemKind, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CWallet__CWalletItem_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            WalletItemKind,
            IAsyncOperation<IntPtr>**,
            int> GetItemsWithKindAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CWallet__CWalletItem_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStreamReference,
            IAsyncOperation<IntPtr>**,
            int> ImportItemAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> DeleteAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> ShowAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> ShowItemAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Wallet::IWalletItem *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IWalletItem, IAsyncAction*, int> UpdateAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWalletItemStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWalletItemStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWalletItemStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWalletItemStore(Silk.NET.WinRT.IInspectable value)
    {
        return new IWalletItemStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletItemStore"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletItemStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWalletItemStore value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWalletItemStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWalletItemStore(Silk.NET.Windows.IUnknown value)
    {
        return new IWalletItemStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletItemStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletItemStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWalletItemStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
