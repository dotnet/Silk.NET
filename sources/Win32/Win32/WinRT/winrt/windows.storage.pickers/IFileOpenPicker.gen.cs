// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.pickers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2CA8278A-12C5-4C5F-8977-94547793C241")]
[NativeTypeName("struct IFileOpenPicker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileOpenPicker : IFileOpenPicker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileOpenPicker));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileOpenPicker, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileOpenPicker, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileOpenPicker, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFileOpenPicker, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFileOpenPicker, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFileOpenPicker, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ViewMode(
        [NativeTypeName("ABI::Windows::Storage::Pickers::PickerViewMode *")] PickerViewMode* value
    )
    {
        return ((delegate* unmanaged<IFileOpenPicker, PickerViewMode*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ViewMode(
        [NativeTypeName("ABI::Windows::Storage::Pickers::PickerViewMode")] PickerViewMode value
    )
    {
        return ((delegate* unmanaged<IFileOpenPicker, PickerViewMode, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SettingsIdentifier(HSTRING* value)
    {
        return ((delegate* unmanaged<IFileOpenPicker, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SettingsIdentifier(HSTRING value)
    {
        return ((delegate* unmanaged<IFileOpenPicker, HSTRING, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SuggestedStartLocation(
        [NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId *")]
            PickerLocationId* value
    )
    {
        return ((delegate* unmanaged<IFileOpenPicker, PickerLocationId*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SuggestedStartLocation(
        [NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId")] PickerLocationId value
    )
    {
        return ((delegate* unmanaged<IFileOpenPicker, PickerLocationId, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CommitButtonText(HSTRING* value)
    {
        return ((delegate* unmanaged<IFileOpenPicker, HSTRING*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CommitButtonText(HSTRING value)
    {
        return ((delegate* unmanaged<IFileOpenPicker, HSTRING, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_FileTypeFilter(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IFileOpenPicker, IVector<HSTRING>**, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT PickSingleFileAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IFileOpenPicker, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[15])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT PickMultipleFilesAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IFileOpenPicker, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[16])
        )(this, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ViewMode(
            [NativeTypeName("ABI::Windows::Storage::Pickers::PickerViewMode *")]
                PickerViewMode* value
        );

        [VtblIndex(7)]
        HRESULT put_ViewMode(
            [NativeTypeName("ABI::Windows::Storage::Pickers::PickerViewMode")] PickerViewMode value
        );

        [VtblIndex(8)]
        HRESULT get_SettingsIdentifier(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_SettingsIdentifier(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_SuggestedStartLocation(
            [NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId *")]
                PickerLocationId* value
        );

        [VtblIndex(11)]
        HRESULT put_SuggestedStartLocation(
            [NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId")]
                PickerLocationId value
        );

        [VtblIndex(12)]
        HRESULT get_CommitButtonText(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_CommitButtonText(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_FileTypeFilter(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(15)]
        HRESULT PickSingleFileAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(16)]
        HRESULT PickMultipleFilesAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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
            "HRESULT (ABI::Windows::Storage::Pickers::PickerViewMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PickerViewMode*, int> get_ViewMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Pickers::PickerViewMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PickerViewMode, int> put_ViewMode;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SettingsIdentifier;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_SettingsIdentifier;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Pickers::PickerLocationId *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PickerLocationId*, int> get_SuggestedStartLocation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Pickers::PickerLocationId) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PickerLocationId, int> put_SuggestedStartLocation;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_CommitButtonText;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_CommitButtonText;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_FileTypeFilter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> PickSingleFileAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> PickMultipleFilesAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileOpenPicker"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileOpenPicker(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFileOpenPicker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFileOpenPicker(Silk.NET.WinRT.IInspectable value)
    {
        return new IFileOpenPicker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileOpenPicker"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFileOpenPicker"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFileOpenPicker value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileOpenPicker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileOpenPicker(Silk.NET.Windows.IUnknown value)
    {
        return new IFileOpenPicker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileOpenPicker"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileOpenPicker"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileOpenPicker value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
