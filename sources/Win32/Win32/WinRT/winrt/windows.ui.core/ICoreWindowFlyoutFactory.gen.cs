// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("DEC4C6C4-93E8-4F7C-BE27-CEFAA1AF68A7")]
[NativeTypeName("struct ICoreWindowFlyoutFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreWindowFlyoutFactory
    : ICoreWindowFlyoutFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreWindowFlyoutFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoreWindowFlyoutFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICoreWindowFlyoutFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreWindowFlyoutFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICoreWindowFlyoutFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICoreWindowFlyoutFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICoreWindowFlyoutFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point position,
        [NativeTypeName("ABI::Windows::UI::Core::ICoreWindowFlyout **")]
            ICoreWindowFlyout* coreWindowFlyout
    )
    {
        return (
            (delegate* unmanaged<ICoreWindowFlyoutFactory, Point, ICoreWindowFlyout*, int>)(
                (*lpVtbl)[6]
            )
        )(this, position, coreWindowFlyout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithTitle(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point position,
        HSTRING title,
        [NativeTypeName("ABI::Windows::UI::Core::ICoreWindowFlyout **")]
            ICoreWindowFlyout* coreWindowFlyout
    )
    {
        return (
            (delegate* unmanaged<
                ICoreWindowFlyoutFactory,
                Point,
                HSTRING,
                ICoreWindowFlyout*,
                int>)((*lpVtbl)[7])
        )(this, position, title, coreWindowFlyout);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point position,
            [NativeTypeName("ABI::Windows::UI::Core::ICoreWindowFlyout **")]
                ICoreWindowFlyout* coreWindowFlyout
        );

        [VtblIndex(7)]
        HRESULT CreateWithTitle(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point position,
            HSTRING title,
            [NativeTypeName("ABI::Windows::UI::Core::ICoreWindowFlyout **")]
                ICoreWindowFlyout* coreWindowFlyout
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
            "HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::UI::Core::ICoreWindowFlyout **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Point, ICoreWindowFlyout*, int> Create;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Point, HSTRING, ABI::Windows::UI::Core::ICoreWindowFlyout **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Point, HSTRING, ICoreWindowFlyout*, int> CreateWithTitle;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreWindowFlyoutFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreWindowFlyoutFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreWindowFlyoutFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreWindowFlyoutFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new ICoreWindowFlyoutFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreWindowFlyoutFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreWindowFlyoutFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICoreWindowFlyoutFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreWindowFlyoutFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreWindowFlyoutFactory(Silk.NET.Windows.IUnknown value)
    {
        return new ICoreWindowFlyoutFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreWindowFlyoutFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreWindowFlyoutFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICoreWindowFlyoutFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
