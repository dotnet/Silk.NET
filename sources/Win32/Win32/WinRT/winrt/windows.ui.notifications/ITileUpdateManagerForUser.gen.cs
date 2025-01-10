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

[Guid("55141348-2EE2-4E2D-9CC1-216A20DECC9F")]
[NativeTypeName("struct ITileUpdateManagerForUser : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITileUpdateManagerForUser
    : ITileUpdateManagerForUser.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITileUpdateManagerForUser));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITileUpdateManagerForUser, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITileUpdateManagerForUser, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITileUpdateManagerForUser, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITileUpdateManagerForUser, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITileUpdateManagerForUser, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITileUpdateManagerForUser, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateTileUpdaterForApplication(
        [NativeTypeName("ABI::Windows::UI::Notifications::ITileUpdater **")] ITileUpdater* result
    )
    {
        return ((delegate* unmanaged<ITileUpdateManagerForUser, ITileUpdater*, int>)((*lpVtbl)[6]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateTileUpdaterForApplicationWithId(
        HSTRING applicationId,
        [NativeTypeName("ABI::Windows::UI::Notifications::ITileUpdater **")] ITileUpdater* result
    )
    {
        return (
            (delegate* unmanaged<ITileUpdateManagerForUser, HSTRING, ITileUpdater*, int>)(
                (*lpVtbl)[7]
            )
        )(this, applicationId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateTileUpdaterForSecondaryTile(
        HSTRING tileId,
        [NativeTypeName("ABI::Windows::UI::Notifications::ITileUpdater **")] ITileUpdater* result
    )
    {
        return (
            (delegate* unmanaged<ITileUpdateManagerForUser, HSTRING, ITileUpdater*, int>)(
                (*lpVtbl)[8]
            )
        )(this, tileId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* value)
    {
        return ((delegate* unmanaged<ITileUpdateManagerForUser, IUser*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateTileUpdaterForApplication(
            [NativeTypeName("ABI::Windows::UI::Notifications::ITileUpdater **")]
                ITileUpdater* result
        );

        [VtblIndex(7)]
        HRESULT CreateTileUpdaterForApplicationWithId(
            HSTRING applicationId,
            [NativeTypeName("ABI::Windows::UI::Notifications::ITileUpdater **")]
                ITileUpdater* result
        );

        [VtblIndex(8)]
        HRESULT CreateTileUpdaterForSecondaryTile(
            HSTRING tileId,
            [NativeTypeName("ABI::Windows::UI::Notifications::ITileUpdater **")]
                ITileUpdater* result
        );

        [VtblIndex(9)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* value);
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
            "HRESULT (ABI::Windows::UI::Notifications::ITileUpdater **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITileUpdater*, int> CreateTileUpdaterForApplication;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::UI::Notifications::ITileUpdater **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ITileUpdater*,
            int> CreateTileUpdaterForApplicationWithId;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::UI::Notifications::ITileUpdater **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ITileUpdater*,
            int> CreateTileUpdaterForSecondaryTile;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUser*, int> get_User;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITileUpdateManagerForUser"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITileUpdateManagerForUser(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITileUpdateManagerForUser"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITileUpdateManagerForUser(Silk.NET.WinRT.IInspectable value)
    {
        return new ITileUpdateManagerForUser(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITileUpdateManagerForUser"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITileUpdateManagerForUser"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITileUpdateManagerForUser value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITileUpdateManagerForUser"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITileUpdateManagerForUser(Silk.NET.Windows.IUnknown value)
    {
        return new ITileUpdateManagerForUser(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITileUpdateManagerForUser"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITileUpdateManagerForUser"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITileUpdateManagerForUser value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
