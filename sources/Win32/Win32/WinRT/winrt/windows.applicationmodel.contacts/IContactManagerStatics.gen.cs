// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("81F21AC0-F661-4708-BA4F-D386BD0D622E")]
[NativeTypeName("struct IContactManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactManagerStatics : IContactManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactManagerStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactManagerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactManagerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContactManagerStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactManagerStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContactManagerStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowContactCard(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection
    )
    {
        return ((delegate* unmanaged<IContactManagerStatics, IContact, Rect, int>)((*lpVtbl)[6]))(
            this,
            contact,
            selection
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowContactCardWithPlacement(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement
    )
    {
        return (
            (delegate* unmanaged<IContactManagerStatics, IContact, Rect, Placement, int>)(
                (*lpVtbl)[7]
            )
        )(this, contact, selection, preferredPlacement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShowDelayLoadedContactCard(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Contacts::IContactCardDelayedDataLoader **"
        )]
            IContactCardDelayedDataLoader* dataLoader
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerStatics,
                IContact,
                Rect,
                Placement,
                IContactCardDelayedDataLoader*,
                int>)((*lpVtbl)[8])
        )(this, contact, selection, preferredPlacement, dataLoader);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ShowContactCard(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection
        );

        [VtblIndex(7)]
        HRESULT ShowContactCardWithPlacement(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement
        );

        [VtblIndex(8)]
        HRESULT ShowDelayLoadedContactCard(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::IContactCardDelayedDataLoader **"
            )]
                IContactCardDelayedDataLoader* dataLoader
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
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::Rect) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContact, Rect, int> ShowContactCard;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            Rect,
            Placement,
            int> ShowContactCardWithPlacement;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::ApplicationModel::Contacts::IContactCardDelayedDataLoader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            Rect,
            Placement,
            IContactCardDelayedDataLoader*,
            int> ShowDelayLoadedContactCard;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactManagerStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactManagerStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactManagerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IContactManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactManagerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
