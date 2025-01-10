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

[Guid("8744436C-5CF9-4683-BDCA-A1FDEBF8DBCE")]
[NativeTypeName("struct IFullContactCardOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFullContactCardOptions
    : IFullContactCardOptions.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFullContactCardOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFullContactCardOptions, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFullContactCardOptions, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFullContactCardOptions, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFullContactCardOptions, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFullContactCardOptions, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFullContactCardOptions, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DesiredRemainingView(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference *")]
            ViewSizePreference* value
    )
    {
        return (
            (delegate* unmanaged<IFullContactCardOptions, ViewSizePreference*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DesiredRemainingView(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")]
            ViewSizePreference value
    )
    {
        return (
            (delegate* unmanaged<IFullContactCardOptions, ViewSizePreference, int>)((*lpVtbl)[7])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DesiredRemainingView(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference *")]
                ViewSizePreference* value
        );

        [VtblIndex(7)]
        HRESULT put_DesiredRemainingView(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")]
                ViewSizePreference value
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
            "HRESULT (ABI::Windows::UI::ViewManagement::ViewSizePreference *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ViewSizePreference*, int> get_DesiredRemainingView;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::ViewManagement::ViewSizePreference) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ViewSizePreference, int> put_DesiredRemainingView;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFullContactCardOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFullContactCardOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFullContactCardOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFullContactCardOptions(Silk.NET.WinRT.IInspectable value)
    {
        return new IFullContactCardOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFullContactCardOptions"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFullContactCardOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFullContactCardOptions value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFullContactCardOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFullContactCardOptions(Silk.NET.Windows.IUnknown value)
    {
        return new IFullContactCardOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFullContactCardOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFullContactCardOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFullContactCardOptions value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
