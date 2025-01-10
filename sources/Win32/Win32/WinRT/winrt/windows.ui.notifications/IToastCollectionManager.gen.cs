// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2A1821FE-179D-49BC-B79D-A527920D3665")]
[NativeTypeName("struct IToastCollectionManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastCollectionManager
    : IToastCollectionManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastCollectionManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IToastCollectionManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IToastCollectionManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IToastCollectionManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IToastCollectionManager, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IToastCollectionManager, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IToastCollectionManager, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SaveToastCollectionAsync(
        [NativeTypeName("ABI::Windows::UI::Notifications::IToastCollection *")]
            IToastCollection collection,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IToastCollectionManager, IToastCollection, IAsyncAction*, int>)(
                (*lpVtbl)[6]
            )
        )(this, collection, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindAllToastCollectionsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CUI__CNotifications__CToastCollection_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IToastCollectionManager, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetToastCollectionAsync(
        HSTRING collectionId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastCollection_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IToastCollectionManager, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, collectionId, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveToastCollectionAsync(
        HSTRING collectionId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IToastCollectionManager, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[9]
            )
        )(this, collectionId, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RemoveAllToastCollectionsAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IToastCollectionManager, IAsyncAction*, int>)((*lpVtbl)[10]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* value)
    {
        return ((delegate* unmanaged<IToastCollectionManager, IUser*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AppId(HSTRING* value)
    {
        return ((delegate* unmanaged<IToastCollectionManager, HSTRING*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SaveToastCollectionAsync(
            [NativeTypeName("ABI::Windows::UI::Notifications::IToastCollection *")]
                IToastCollection collection,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(7)]
        HRESULT FindAllToastCollectionsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CUI__CNotifications__CToastCollection_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(8)]
        HRESULT GetToastCollectionAsync(
            HSTRING collectionId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastCollection_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(9)]
        HRESULT RemoveToastCollectionAsync(
            HSTRING collectionId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(10)]
        HRESULT RemoveAllToastCollectionsAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(11)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* value);

        [VtblIndex(12)]
        HRESULT get_AppId(HSTRING* value);
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
            "HRESULT (ABI::Windows::UI::Notifications::IToastCollection *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IToastCollection,
            IAsyncAction*,
            int> SaveToastCollectionAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CUI__CNotifications__CToastCollection_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> FindAllToastCollectionsAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastCollection_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetToastCollectionAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> RemoveToastCollectionAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> RemoveAllToastCollectionsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUser*, int> get_User;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AppId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IToastCollectionManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IToastCollectionManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IToastCollectionManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IToastCollectionManager(Silk.NET.WinRT.IInspectable value)
    {
        return new IToastCollectionManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IToastCollectionManager"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IToastCollectionManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IToastCollectionManager value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IToastCollectionManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IToastCollectionManager(Silk.NET.Windows.IUnknown value)
    {
        return new IToastCollectionManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IToastCollectionManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IToastCollectionManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IToastCollectionManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
