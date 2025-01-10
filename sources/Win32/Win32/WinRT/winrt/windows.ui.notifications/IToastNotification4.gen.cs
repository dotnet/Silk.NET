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

[Guid("15154935-28EA-4727-88E9-C58680E2D118")]
[NativeTypeName("struct IToastNotification4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotification4 : IToastNotification4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotification4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IToastNotification4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IToastNotification4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IToastNotification4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IToastNotification4, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IToastNotification4, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IToastNotification4, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Data(
        [NativeTypeName("ABI::Windows::UI::Notifications::INotificationData **")]
            INotificationData* value
    )
    {
        return ((delegate* unmanaged<IToastNotification4, INotificationData*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Data(
        [NativeTypeName("ABI::Windows::UI::Notifications::INotificationData *")]
            INotificationData value
    )
    {
        return ((delegate* unmanaged<IToastNotification4, INotificationData, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Priority(
        [NativeTypeName("ABI::Windows::UI::Notifications::ToastNotificationPriority *")]
            ToastNotificationPriority* value
    )
    {
        return (
            (delegate* unmanaged<IToastNotification4, ToastNotificationPriority*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Priority(
        [NativeTypeName("ABI::Windows::UI::Notifications::ToastNotificationPriority")]
            ToastNotificationPriority value
    )
    {
        return (
            (delegate* unmanaged<IToastNotification4, ToastNotificationPriority, int>)((*lpVtbl)[9])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Data(
            [NativeTypeName("ABI::Windows::UI::Notifications::INotificationData **")]
                INotificationData* value
        );

        [VtblIndex(7)]
        HRESULT put_Data(
            [NativeTypeName("ABI::Windows::UI::Notifications::INotificationData *")]
                INotificationData value
        );

        [VtblIndex(8)]
        HRESULT get_Priority(
            [NativeTypeName("ABI::Windows::UI::Notifications::ToastNotificationPriority *")]
                ToastNotificationPriority* value
        );

        [VtblIndex(9)]
        HRESULT put_Priority(
            [NativeTypeName("ABI::Windows::UI::Notifications::ToastNotificationPriority")]
                ToastNotificationPriority value
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
            "HRESULT (ABI::Windows::UI::Notifications::INotificationData **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, INotificationData*, int> get_Data;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::INotificationData *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, INotificationData, int> put_Data;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::ToastNotificationPriority *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ToastNotificationPriority*, int> get_Priority;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::ToastNotificationPriority) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ToastNotificationPriority, int> put_Priority;
    }

    /// <summary>Initializes a new instance of the <see cref = "IToastNotification4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IToastNotification4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IToastNotification4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IToastNotification4(Silk.NET.WinRT.IInspectable value)
    {
        return new IToastNotification4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IToastNotification4"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IToastNotification4"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IToastNotification4 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IToastNotification4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IToastNotification4(Silk.NET.Windows.IUnknown value)
    {
        return new IToastNotification4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IToastNotification4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IToastNotification4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IToastNotification4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
