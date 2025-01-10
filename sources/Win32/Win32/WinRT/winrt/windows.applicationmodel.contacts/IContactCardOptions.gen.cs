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

[Guid("8C0A4F7E-6AB6-4F3F-BE72-817236EEEA5B")]
[NativeTypeName("struct IContactCardOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactCardOptions : IContactCardOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactCardOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactCardOptions, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactCardOptions, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactCardOptions, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContactCardOptions, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactCardOptions, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContactCardOptions, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_HeaderKind(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardHeaderKind *")]
            ContactCardHeaderKind* value
    )
    {
        return (
            (delegate* unmanaged<IContactCardOptions, ContactCardHeaderKind*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_HeaderKind(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardHeaderKind")]
            ContactCardHeaderKind value
    )
    {
        return (
            (delegate* unmanaged<IContactCardOptions, ContactCardHeaderKind, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InitialTabKind(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardTabKind *")]
            ContactCardTabKind* value
    )
    {
        return ((delegate* unmanaged<IContactCardOptions, ContactCardTabKind*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_InitialTabKind(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardTabKind")]
            ContactCardTabKind value
    )
    {
        return ((delegate* unmanaged<IContactCardOptions, ContactCardTabKind, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_HeaderKind(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardHeaderKind *")]
                ContactCardHeaderKind* value
        );

        [VtblIndex(7)]
        HRESULT put_HeaderKind(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardHeaderKind")]
                ContactCardHeaderKind value
        );

        [VtblIndex(8)]
        HRESULT get_InitialTabKind(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardTabKind *")]
                ContactCardTabKind* value
        );

        [VtblIndex(9)]
        HRESULT put_InitialTabKind(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardTabKind")]
                ContactCardTabKind value
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
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactCardHeaderKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactCardHeaderKind*, int> get_HeaderKind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactCardHeaderKind) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactCardHeaderKind, int> put_HeaderKind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactCardTabKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactCardTabKind*, int> get_InitialTabKind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactCardTabKind) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactCardTabKind, int> put_InitialTabKind;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactCardOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactCardOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactCardOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactCardOptions(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactCardOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactCardOptions"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactCardOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactCardOptions value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactCardOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactCardOptions(Silk.NET.Windows.IUnknown value)
    {
        return new IContactCardOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactCardOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactCardOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactCardOptions value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
