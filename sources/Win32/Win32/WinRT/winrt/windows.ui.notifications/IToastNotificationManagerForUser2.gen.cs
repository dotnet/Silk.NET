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

[Guid("679C64B7-81AB-42C2-8819-C958767753F4")]
[NativeTypeName("struct IToastNotificationManagerForUser2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotificationManagerForUser2
    : IToastNotificationManagerForUser2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotificationManagerForUser2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IToastNotificationManagerForUser2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IToastNotificationManagerForUser2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IToastNotificationManagerForUser2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IToastNotificationManagerForUser2, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IToastNotificationManagerForUser2, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IToastNotificationManagerForUser2, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetToastNotifierForToastCollectionIdAsync(
        HSTRING collectionId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastNotifier_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IToastNotificationManagerForUser2,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, collectionId, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetHistoryForToastCollectionIdAsync(
        HSTRING collectionId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastNotificationHistory_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IToastNotificationManagerForUser2,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, collectionId, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetToastCollectionManager(
        [NativeTypeName("ABI::Windows::UI::Notifications::IToastCollectionManager **")]
            IToastCollectionManager* result
    )
    {
        return (
            (delegate* unmanaged<IToastNotificationManagerForUser2, IToastCollectionManager*, int>)(
                (*lpVtbl)[8]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetToastCollectionManagerWithAppId(
        HSTRING appId,
        [NativeTypeName("ABI::Windows::UI::Notifications::IToastCollectionManager **")]
            IToastCollectionManager* result
    )
    {
        return (
            (delegate* unmanaged<
                IToastNotificationManagerForUser2,
                HSTRING,
                IToastCollectionManager*,
                int>)((*lpVtbl)[9])
        )(this, appId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetToastNotifierForToastCollectionIdAsync(
            HSTRING collectionId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastNotifier_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT GetHistoryForToastCollectionIdAsync(
            HSTRING collectionId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastNotificationHistory_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(8)]
        HRESULT GetToastCollectionManager(
            [NativeTypeName("ABI::Windows::UI::Notifications::IToastCollectionManager **")]
                IToastCollectionManager* result
        );

        [VtblIndex(9)]
        HRESULT GetToastCollectionManagerWithAppId(
            HSTRING appId,
            [NativeTypeName("ABI::Windows::UI::Notifications::IToastCollectionManager **")]
                IToastCollectionManager* result
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastNotifier_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetToastNotifierForToastCollectionIdAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastNotificationHistory_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetHistoryForToastCollectionIdAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::IToastCollectionManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IToastCollectionManager*, int> GetToastCollectionManager;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::UI::Notifications::IToastCollectionManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IToastCollectionManager*,
            int> GetToastCollectionManagerWithAppId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IToastNotificationManagerForUser2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IToastNotificationManagerForUser2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IToastNotificationManagerForUser2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IToastNotificationManagerForUser2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IToastNotificationManagerForUser2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IToastNotificationManagerForUser2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IToastNotificationManagerForUser2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IToastNotificationManagerForUser2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IToastNotificationManagerForUser2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IToastNotificationManagerForUser2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IToastNotificationManagerForUser2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IToastNotificationManagerForUser2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IToastNotificationManagerForUser2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IToastNotificationManagerForUser2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
