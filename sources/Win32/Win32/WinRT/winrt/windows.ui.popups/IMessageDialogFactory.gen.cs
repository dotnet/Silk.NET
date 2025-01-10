// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2D161777-A66F-4EA5-BB87-793FFA4941F2")]
[NativeTypeName("struct IMessageDialogFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMessageDialogFactory : IMessageDialogFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMessageDialogFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMessageDialogFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMessageDialogFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMessageDialogFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMessageDialogFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMessageDialogFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMessageDialogFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        HSTRING content,
        [NativeTypeName("ABI::Windows::UI::Popups::IMessageDialog **")]
            IMessageDialog* messageDialog
    )
    {
        return (
            (delegate* unmanaged<IMessageDialogFactory, HSTRING, IMessageDialog*, int>)(
                (*lpVtbl)[6]
            )
        )(this, content, messageDialog);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithTitle(
        HSTRING content,
        HSTRING title,
        [NativeTypeName("ABI::Windows::UI::Popups::IMessageDialog **")]
            IMessageDialog* messageDialog
    )
    {
        return (
            (delegate* unmanaged<IMessageDialogFactory, HSTRING, HSTRING, IMessageDialog*, int>)(
                (*lpVtbl)[7]
            )
        )(this, content, title, messageDialog);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            HSTRING content,
            [NativeTypeName("ABI::Windows::UI::Popups::IMessageDialog **")]
                IMessageDialog* messageDialog
        );

        [VtblIndex(7)]
        HRESULT CreateWithTitle(
            HSTRING content,
            HSTRING title,
            [NativeTypeName("ABI::Windows::UI::Popups::IMessageDialog **")]
                IMessageDialog* messageDialog
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
            "HRESULT (HSTRING, ABI::Windows::UI::Popups::IMessageDialog **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IMessageDialog*, int> Create;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::UI::Popups::IMessageDialog **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, IMessageDialog*, int> CreateWithTitle;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMessageDialogFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMessageDialogFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMessageDialogFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMessageDialogFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IMessageDialogFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMessageDialogFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMessageDialogFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMessageDialogFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMessageDialogFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMessageDialogFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IMessageDialogFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMessageDialogFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMessageDialogFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMessageDialogFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
