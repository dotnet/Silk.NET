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

[Guid("0E09FD91-42F8-4055-90A0-896F96738936")]
[NativeTypeName("struct IContactPicker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactPicker : IContactPicker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactPicker));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactPicker, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactPicker, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactPicker, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContactPicker, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactPicker, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContactPicker, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CommitButtonText(HSTRING* value)
    {
        return ((delegate* unmanaged<IContactPicker, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CommitButtonText(HSTRING value)
    {
        return ((delegate* unmanaged<IContactPicker, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SelectionMode(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode *")]
            ContactSelectionMode* value
    )
    {
        return ((delegate* unmanaged<IContactPicker, ContactSelectionMode*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SelectionMode(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode")]
            ContactSelectionMode value
    )
    {
        return ((delegate* unmanaged<IContactPicker, ContactSelectionMode, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DesiredFields(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IContactPicker, IVector<HSTRING>**, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT PickSingleContactAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactInformation_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IContactPicker, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[11])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PickMultipleContactsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactInformation_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IContactPicker, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[12])
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CommitButtonText(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_CommitButtonText(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_SelectionMode(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode *")]
                ContactSelectionMode* value
        );

        [VtblIndex(9)]
        HRESULT put_SelectionMode(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode")]
                ContactSelectionMode value
        );

        [VtblIndex(10)]
        HRESULT get_DesiredFields(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(11)]
        HRESULT PickSingleContactAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactInformation_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(12)]
        HRESULT PickMultipleContactsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactInformation_t **"
            )]
                IAsyncOperation<IntPtr>** result
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_CommitButtonText;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_CommitButtonText;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactSelectionMode*, int> get_SelectionMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactSelectionMode, int> put_SelectionMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_DesiredFields;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactInformation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> PickSingleContactAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactInformation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> PickMultipleContactsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactPicker"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactPicker(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactPicker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactPicker(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactPicker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactPicker"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactPicker"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactPicker value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactPicker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactPicker(Silk.NET.Windows.IUnknown value)
    {
        return new IContactPicker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactPicker"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactPicker"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactPicker value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
