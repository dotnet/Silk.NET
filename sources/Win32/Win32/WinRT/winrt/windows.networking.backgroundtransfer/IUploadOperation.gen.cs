// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("3E5624E0-7389-434C-8B35-427FD36BBDAE")]
[NativeTypeName("struct IUploadOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUploadOperation : IUploadOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUploadOperation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUploadOperation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUploadOperation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUploadOperation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IUploadOperation, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUploadOperation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUploadOperation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourceFile(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile* value
    )
    {
        return ((delegate* unmanaged<IUploadOperation, IStorageFile*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Progress(
        [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundUploadProgress *")]
            BackgroundUploadProgress* value
    )
    {
        return (
            (delegate* unmanaged<IUploadOperation, BackgroundUploadProgress*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IUploadOperation,
                IAsyncOperationWithProgress<IntPtr, IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AttachAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IUploadOperation,
                IAsyncOperationWithProgress<IntPtr, IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourceFile(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile* value
        );

        [VtblIndex(7)]
        HRESULT get_Progress(
            [NativeTypeName(
                "ABI::Windows::Networking::BackgroundTransfer::BackgroundUploadProgress *"
            )]
                BackgroundUploadProgress* value
        );

        [VtblIndex(8)]
        HRESULT StartAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, IntPtr>** operation
        );

        [VtblIndex(9)]
        HRESULT AttachAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, IntPtr>** operation
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
            "HRESULT (ABI::Windows::Storage::IStorageFile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFile*, int> get_SourceFile;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundUploadProgress *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BackgroundUploadProgress*, int> get_Progress;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperationWithProgress<IntPtr, IntPtr>**,
            int> StartAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperationWithProgress<IntPtr, IntPtr>**,
            int> AttachAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUploadOperation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUploadOperation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUploadOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUploadOperation(Silk.NET.WinRT.IInspectable value)
    {
        return new IUploadOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUploadOperation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUploadOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IUploadOperation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUploadOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUploadOperation(Silk.NET.Windows.IUnknown value)
    {
        return new IUploadOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUploadOperation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUploadOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUploadOperation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
