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

[Guid("50AC103F-D235-4598-BBEF-98FE4D1A3AD4")]
[NativeTypeName("struct IToastNotificationManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotificationManagerStatics
    : IToastNotificationManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotificationManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IToastNotificationManagerStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IToastNotificationManagerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IToastNotificationManagerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IToastNotificationManagerStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IToastNotificationManagerStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IToastNotificationManagerStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateToastNotifier(
        [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotifier **")]
            IToastNotifier* result
    )
    {
        return (
            (delegate* unmanaged<IToastNotificationManagerStatics, IToastNotifier*, int>)(
                (*lpVtbl)[6]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateToastNotifierWithId(
        HSTRING applicationId,
        [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotifier **")]
            IToastNotifier* result
    )
    {
        return (
            (delegate* unmanaged<IToastNotificationManagerStatics, HSTRING, IToastNotifier*, int>)(
                (*lpVtbl)[7]
            )
        )(this, applicationId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTemplateContent(
        [NativeTypeName("ABI::Windows::UI::Notifications::ToastTemplateType")]
            ToastTemplateType type,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument* result
    )
    {
        return (
            (delegate* unmanaged<
                IToastNotificationManagerStatics,
                ToastTemplateType,
                IXmlDocument*,
                int>)((*lpVtbl)[8])
        )(this, type, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateToastNotifier(
            [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotifier **")]
                IToastNotifier* result
        );

        [VtblIndex(7)]
        HRESULT CreateToastNotifierWithId(
            HSTRING applicationId,
            [NativeTypeName("ABI::Windows::UI::Notifications::IToastNotifier **")]
                IToastNotifier* result
        );

        [VtblIndex(8)]
        HRESULT GetTemplateContent(
            [NativeTypeName("ABI::Windows::UI::Notifications::ToastTemplateType")]
                ToastTemplateType type,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument* result
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
            "HRESULT (ABI::Windows::UI::Notifications::IToastNotifier **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IToastNotifier*, int> CreateToastNotifier;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::UI::Notifications::IToastNotifier **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IToastNotifier*, int> CreateToastNotifierWithId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::ToastTemplateType, ABI::Windows::Data::Xml::Dom::IXmlDocument **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ToastTemplateType,
            IXmlDocument*,
            int> GetTemplateContent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IToastNotificationManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IToastNotificationManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IToastNotificationManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IToastNotificationManagerStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IToastNotificationManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IToastNotificationManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IToastNotificationManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IToastNotificationManagerStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IToastNotificationManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IToastNotificationManagerStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IToastNotificationManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IToastNotificationManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IToastNotificationManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IToastNotificationManagerStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
