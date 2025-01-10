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

[Guid("DC222CF4-2772-4C1D-AA2C-C9F743ADE8D1")]
[NativeTypeName("struct IApplicationData3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationData3 : IApplicationData3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationData3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationData3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IApplicationData3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationData3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IApplicationData3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IApplicationData3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IApplicationData3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPublisherCacheFolder(
        HSTRING folderName,
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationData3, HSTRING, IStorageFolder*, int>)((*lpVtbl)[6])
        )(this, folderName, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ClearPublisherCacheFolderAsync(
        HSTRING folderName,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* clearOperation
    )
    {
        return (
            (delegate* unmanaged<IApplicationData3, HSTRING, IAsyncAction*, int>)((*lpVtbl)[7])
        )(this, folderName, clearOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SharedLocalFolder(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IApplicationData3, IStorageFolder*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetPublisherCacheFolder(
            HSTRING folderName,
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(7)]
        HRESULT ClearPublisherCacheFolderAsync(
            HSTRING folderName,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* clearOperation
        );

        [VtblIndex(8)]
        HRESULT get_SharedLocalFolder(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
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
            "HRESULT (HSTRING, ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IStorageFolder*, int> GetPublisherCacheFolder;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncAction*,
            int> ClearPublisherCacheFolderAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_SharedLocalFolder;
    }

    /// <summary>Initializes a new instance of the <see cref = "IApplicationData3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IApplicationData3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IApplicationData3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IApplicationData3(Silk.NET.WinRT.IInspectable value)
    {
        return new IApplicationData3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationData3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationData3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IApplicationData3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IApplicationData3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IApplicationData3(Silk.NET.Windows.IUnknown value)
    {
        return new IApplicationData3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationData3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationData3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IApplicationData3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
