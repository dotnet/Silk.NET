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

[Guid("3286FFCB-617F-4CC5-AF6A-B3FDF29AD145")]
[NativeTypeName("struct IFileSavePicker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileSavePicker : IFileSavePicker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSavePicker));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSavePicker, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileSavePicker, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSavePicker, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFileSavePicker, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFileSavePicker, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFileSavePicker, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SettingsIdentifier(HSTRING* value)
    {
        return ((delegate* unmanaged<IFileSavePicker, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SettingsIdentifier(HSTRING value)
    {
        return ((delegate* unmanaged<IFileSavePicker, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SuggestedStartLocation(
        [NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId *")]
            PickerLocationId* value
    )
    {
        return ((delegate* unmanaged<IFileSavePicker, PickerLocationId*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SuggestedStartLocation(
        [NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId")] PickerLocationId value
    )
    {
        return ((delegate* unmanaged<IFileSavePicker, PickerLocationId, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CommitButtonText(HSTRING* value)
    {
        return ((delegate* unmanaged<IFileSavePicker, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CommitButtonText(HSTRING value)
    {
        return ((delegate* unmanaged<IFileSavePicker, HSTRING, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FileTypeChoices(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING___FIVector_1_HSTRING_t **"
        )]
            IMap<HSTRING, IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IFileSavePicker, IMap<HSTRING, IntPtr>**, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DefaultFileExtension(HSTRING* value)
    {
        return ((delegate* unmanaged<IFileSavePicker, HSTRING*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_DefaultFileExtension(HSTRING value)
    {
        return ((delegate* unmanaged<IFileSavePicker, HSTRING, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_SuggestedSaveFile(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile* value
    )
    {
        return ((delegate* unmanaged<IFileSavePicker, IStorageFile*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_SuggestedSaveFile(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile value
    )
    {
        return ((delegate* unmanaged<IFileSavePicker, IStorageFile, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SuggestedFileName(HSTRING* value)
    {
        return ((delegate* unmanaged<IFileSavePicker, HSTRING*, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_SuggestedFileName(HSTRING value)
    {
        return ((delegate* unmanaged<IFileSavePicker, HSTRING, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT PickSaveFileAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IFileSavePicker, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[19])
        )(this, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SettingsIdentifier(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_SettingsIdentifier(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_SuggestedStartLocation(
            [NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId *")]
                PickerLocationId* value
        );

        [VtblIndex(9)]
        HRESULT put_SuggestedStartLocation(
            [NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId")]
                PickerLocationId value
        );

        [VtblIndex(10)]
        HRESULT get_CommitButtonText(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_CommitButtonText(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_FileTypeChoices(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING___FIVector_1_HSTRING_t **"
            )]
                IMap<HSTRING, IntPtr>** value
        );

        [VtblIndex(13)]
        HRESULT get_DefaultFileExtension(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_DefaultFileExtension(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_SuggestedSaveFile(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile* value
        );

        [VtblIndex(16)]
        HRESULT put_SuggestedSaveFile(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile value
        );

        [VtblIndex(17)]
        HRESULT get_SuggestedFileName(HSTRING* value);

        [VtblIndex(18)]
        HRESULT put_SuggestedFileName(HSTRING value);

        [VtblIndex(19)]
        HRESULT PickSaveFileAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING___FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMap<HSTRING, IntPtr>**, int> get_FileTypeChoices;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DefaultFileExtension;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DefaultFileExtension;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFile*, int> get_SuggestedSaveFile;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStorageFile, int> put_SuggestedSaveFile;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SuggestedFileName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_SuggestedFileName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> PickSaveFileAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileSavePicker"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileSavePicker(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFileSavePicker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFileSavePicker(Silk.NET.WinRT.IInspectable value)
    {
        return new IFileSavePicker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSavePicker"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSavePicker"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFileSavePicker value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileSavePicker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileSavePicker(Silk.NET.Windows.IUnknown value)
    {
        return new IFileSavePicker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSavePicker"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSavePicker"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileSavePicker value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
