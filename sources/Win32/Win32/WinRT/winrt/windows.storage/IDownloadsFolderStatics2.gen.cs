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

[Guid("E93045BD-8EF8-4F8E-8D15-AC0E265F390D")]
[NativeTypeName("struct IDownloadsFolderStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDownloadsFolderStatics2
    : IDownloadsFolderStatics2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDownloadsFolderStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDownloadsFolderStatics2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDownloadsFolderStatics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDownloadsFolderStatics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDownloadsFolderStatics2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDownloadsFolderStatics2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDownloadsFolderStatics2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFileForUserAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        HSTRING desiredName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IDownloadsFolderStatics2,
                IUser,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, user, desiredName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFolderForUserAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        HSTRING desiredName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IDownloadsFolderStatics2,
                IUser,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, user, desiredName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFileForUserWithCollisionOptionAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        HSTRING desiredName,
        [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")]
            CreationCollisionOption option,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IDownloadsFolderStatics2,
                IUser,
                HSTRING,
                CreationCollisionOption,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, user, desiredName, option, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFolderForUserWithCollisionOptionAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        HSTRING desiredName,
        [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")]
            CreationCollisionOption option,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IDownloadsFolderStatics2,
                IUser,
                HSTRING,
                CreationCollisionOption,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, user, desiredName, option, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFileForUserAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            HSTRING desiredName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT CreateFolderForUserAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            HSTRING desiredName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(8)]
        HRESULT CreateFileForUserWithCollisionOptionAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            HSTRING desiredName,
            [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")]
                CreationCollisionOption option,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(9)]
        HRESULT CreateFolderForUserWithCollisionOptionAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            HSTRING desiredName,
            [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")]
                CreationCollisionOption option,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **"
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
            "HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateFileForUserAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateFolderForUserAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Storage::CreationCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            HSTRING,
            CreationCollisionOption,
            IAsyncOperation<IntPtr>**,
            int> CreateFileForUserWithCollisionOptionAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Storage::CreationCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            HSTRING,
            CreationCollisionOption,
            IAsyncOperation<IntPtr>**,
            int> CreateFolderForUserWithCollisionOptionAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDownloadsFolderStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDownloadsFolderStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDownloadsFolderStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDownloadsFolderStatics2(Silk.NET.WinRT.IInspectable value)
    {
        return new IDownloadsFolderStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDownloadsFolderStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDownloadsFolderStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDownloadsFolderStatics2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDownloadsFolderStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDownloadsFolderStatics2(Silk.NET.Windows.IUnknown value)
    {
        return new IDownloadsFolderStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDownloadsFolderStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDownloadsFolderStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDownloadsFolderStatics2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
