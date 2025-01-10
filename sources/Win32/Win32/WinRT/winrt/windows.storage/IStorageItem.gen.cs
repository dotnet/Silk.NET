// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("4207A996-CA2F-42F7-BDE8-8B10457A7F30")]
[NativeTypeName("struct IStorageItem : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageItem : IStorageItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageItem));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageItem, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStorageItem, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageItem, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStorageItem, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStorageItem, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStorageItem, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RenameAsyncOverloadDefaultOptions(
        HSTRING desiredName,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IStorageItem, HSTRING, IAsyncAction*, int>)((*lpVtbl)[6]))(
            this,
            desiredName,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RenameAsync(
        HSTRING desiredName,
        [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption option,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IStorageItem, HSTRING, NameCollisionOption, IAsyncAction*, int>)(
                (*lpVtbl)[7]
            )
        )(this, desiredName, option, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteAsyncOverloadDefaultOptions(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IStorageItem, IAsyncAction*, int>)((*lpVtbl)[8]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DeleteAsync(
        [NativeTypeName("ABI::Windows::Storage::StorageDeleteOption")] StorageDeleteOption option,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IStorageItem, StorageDeleteOption, IAsyncAction*, int>)(
                (*lpVtbl)[9]
            )
        )(this, option, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetBasicPropertiesAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CBasicProperties_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return ((delegate* unmanaged<IStorageItem, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[10]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IStorageItem, HSTRING*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Path(HSTRING* value)
    {
        return ((delegate* unmanaged<IStorageItem, HSTRING*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Attributes(
        [NativeTypeName("ABI::Windows::Storage::FileAttributes *")] FileAttributes* value
    )
    {
        return ((delegate* unmanaged<IStorageItem, FileAttributes*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DateCreated(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IStorageItem, WinRTDateTime*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsOfType(
        [NativeTypeName("ABI::Windows::Storage::StorageItemTypes")] StorageItemTypes type,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IStorageItem, StorageItemTypes, byte*, int>)((*lpVtbl)[15]))(
            this,
            type,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RenameAsyncOverloadDefaultOptions(
            HSTRING desiredName,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(7)]
        HRESULT RenameAsync(
            HSTRING desiredName,
            [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")]
                NameCollisionOption option,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(8)]
        HRESULT DeleteAsyncOverloadDefaultOptions(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(9)]
        HRESULT DeleteAsync(
            [NativeTypeName("ABI::Windows::Storage::StorageDeleteOption")]
                StorageDeleteOption option,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(10)]
        HRESULT GetBasicPropertiesAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CBasicProperties_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(11)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Path(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Attributes(
            [NativeTypeName("ABI::Windows::Storage::FileAttributes *")] FileAttributes* value
        );

        [VtblIndex(14)]
        HRESULT get_DateCreated(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(15)]
        HRESULT IsOfType(
            [NativeTypeName("ABI::Windows::Storage::StorageItemTypes")] StorageItemTypes type,
            [NativeTypeName("boolean *")] byte* value
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncAction*,
            int> RenameAsyncOverloadDefaultOptions;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::NameCollisionOption, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            NameCollisionOption,
            IAsyncAction*,
            int> RenameAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> DeleteAsyncOverloadDefaultOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::StorageDeleteOption, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageDeleteOption, IAsyncAction*, int> DeleteAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CBasicProperties_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetBasicPropertiesAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Path;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::FileAttributes *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FileAttributes*, int> get_Attributes;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_DateCreated;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::StorageItemTypes, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageItemTypes, byte*, int> IsOfType;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageItem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageItem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageItem(Silk.NET.WinRT.IInspectable value)
    {
        return new IStorageItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageItem"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStorageItem value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageItem(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageItem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageItem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
