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

[Guid("04363B0B-1AC0-4B99-88E7-ADA83E953D48")]
[NativeTypeName("struct ITileFlyoutUpdateManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITileFlyoutUpdateManagerStatics
    : ITileFlyoutUpdateManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITileFlyoutUpdateManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITileFlyoutUpdateManagerStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITileFlyoutUpdateManagerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITileFlyoutUpdateManagerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ITileFlyoutUpdateManagerStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ITileFlyoutUpdateManagerStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ITileFlyoutUpdateManagerStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateTileFlyoutUpdaterForApplication(
        [NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutUpdater **")]
            ITileFlyoutUpdater* result
    )
    {
        return (
            (delegate* unmanaged<ITileFlyoutUpdateManagerStatics, ITileFlyoutUpdater*, int>)(
                (*lpVtbl)[6]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateTileFlyoutUpdaterForApplicationWithId(
        HSTRING applicationId,
        [NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutUpdater **")]
            ITileFlyoutUpdater* result
    )
    {
        return (
            (delegate* unmanaged<
                ITileFlyoutUpdateManagerStatics,
                HSTRING,
                ITileFlyoutUpdater*,
                int>)((*lpVtbl)[7])
        )(this, applicationId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateTileFlyoutUpdaterForSecondaryTile(
        HSTRING tileId,
        [NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutUpdater **")]
            ITileFlyoutUpdater* result
    )
    {
        return (
            (delegate* unmanaged<
                ITileFlyoutUpdateManagerStatics,
                HSTRING,
                ITileFlyoutUpdater*,
                int>)((*lpVtbl)[8])
        )(this, tileId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetTemplateContent(
        [NativeTypeName("ABI::Windows::UI::Notifications::TileFlyoutTemplateType")]
            TileFlyoutTemplateType type,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument* result
    )
    {
        return (
            (delegate* unmanaged<
                ITileFlyoutUpdateManagerStatics,
                TileFlyoutTemplateType,
                IXmlDocument*,
                int>)((*lpVtbl)[9])
        )(this, type, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateTileFlyoutUpdaterForApplication(
            [NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutUpdater **")]
                ITileFlyoutUpdater* result
        );

        [VtblIndex(7)]
        HRESULT CreateTileFlyoutUpdaterForApplicationWithId(
            HSTRING applicationId,
            [NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutUpdater **")]
                ITileFlyoutUpdater* result
        );

        [VtblIndex(8)]
        HRESULT CreateTileFlyoutUpdaterForSecondaryTile(
            HSTRING tileId,
            [NativeTypeName("ABI::Windows::UI::Notifications::ITileFlyoutUpdater **")]
                ITileFlyoutUpdater* result
        );

        [VtblIndex(9)]
        HRESULT GetTemplateContent(
            [NativeTypeName("ABI::Windows::UI::Notifications::TileFlyoutTemplateType")]
                TileFlyoutTemplateType type,
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
            "HRESULT (ABI::Windows::UI::Notifications::ITileFlyoutUpdater **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITileFlyoutUpdater*,
            int> CreateTileFlyoutUpdaterForApplication;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::UI::Notifications::ITileFlyoutUpdater **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ITileFlyoutUpdater*,
            int> CreateTileFlyoutUpdaterForApplicationWithId;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::UI::Notifications::ITileFlyoutUpdater **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ITileFlyoutUpdater*,
            int> CreateTileFlyoutUpdaterForSecondaryTile;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Notifications::TileFlyoutTemplateType, ABI::Windows::Data::Xml::Dom::IXmlDocument **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            TileFlyoutTemplateType,
            IXmlDocument*,
            int> GetTemplateContent;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITileFlyoutUpdateManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITileFlyoutUpdateManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITileFlyoutUpdateManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITileFlyoutUpdateManagerStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ITileFlyoutUpdateManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITileFlyoutUpdateManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITileFlyoutUpdateManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ITileFlyoutUpdateManagerStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITileFlyoutUpdateManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITileFlyoutUpdateManagerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ITileFlyoutUpdateManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITileFlyoutUpdateManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITileFlyoutUpdateManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITileFlyoutUpdateManagerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
