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

[Guid("33F59B01-5325-43AB-9AB3-BDAE440E4121")]
[NativeTypeName("struct IMessageDialog : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMessageDialog : IMessageDialog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMessageDialog));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMessageDialog, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMessageDialog, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMessageDialog, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMessageDialog, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMessageDialog, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMessageDialog, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged<IMessageDialog, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged<IMessageDialog, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Commands(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IMessageDialog, IVector<IntPtr>**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IMessageDialog, uint*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IMessageDialog, uint, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CancelCommandIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IMessageDialog, uint*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_CancelCommandIndex([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IMessageDialog, uint, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Content(HSTRING* value)
    {
        return ((delegate* unmanaged<IMessageDialog, HSTRING*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Content(HSTRING value)
    {
        return ((delegate* unmanaged<IMessageDialog, HSTRING, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ShowAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **"
        )]
            IAsyncOperation<IntPtr>** messageDialogAsyncOperation
    )
    {
        return (
            (delegate* unmanaged<IMessageDialog, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[15])
        )(this, messageDialogAsyncOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Options(
        [NativeTypeName("ABI::Windows::UI::Popups::MessageDialogOptions *")]
            MessageDialogOptions* value
    )
    {
        return ((delegate* unmanaged<IMessageDialog, MessageDialogOptions*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Options(
        [NativeTypeName("ABI::Windows::UI::Popups::MessageDialogOptions")]
            MessageDialogOptions value
    )
    {
        return ((delegate* unmanaged<IMessageDialog, MessageDialogOptions, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Commands(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(9)]
        HRESULT get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value);

        [VtblIndex(11)]
        HRESULT get_CancelCommandIndex([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_CancelCommandIndex([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_Content(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_Content(HSTRING value);

        [VtblIndex(15)]
        HRESULT ShowAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **"
            )]
                IAsyncOperation<IntPtr>** messageDialogAsyncOperation
        );

        [VtblIndex(16)]
        HRESULT get_Options(
            [NativeTypeName("ABI::Windows::UI::Popups::MessageDialogOptions *")]
                MessageDialogOptions* value
        );

        [VtblIndex(17)]
        HRESULT put_Options(
            [NativeTypeName("ABI::Windows::UI::Popups::MessageDialogOptions")]
                MessageDialogOptions value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_Commands;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_DefaultCommandIndex;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_DefaultCommandIndex;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CancelCommandIndex;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_CancelCommandIndex;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Content;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Content;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> ShowAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Popups::MessageDialogOptions *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MessageDialogOptions*, int> get_Options;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Popups::MessageDialogOptions) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MessageDialogOptions, int> put_Options;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMessageDialog"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMessageDialog(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMessageDialog"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMessageDialog(Silk.NET.WinRT.IInspectable value)
    {
        return new IMessageDialog(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMessageDialog"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMessageDialog"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMessageDialog value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMessageDialog"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMessageDialog(Silk.NET.Windows.IUnknown value)
    {
        return new IMessageDialog(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMessageDialog"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMessageDialog"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMessageDialog value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
