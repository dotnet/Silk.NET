// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("524CEDCF-6E29-4CE5-9573-6B753DB66C3A")]
[NativeTypeName("struct IRandomAccessStreamStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRandomAccessStreamStatics
    : IRandomAccessStreamStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRandomAccessStreamStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IRandomAccessStreamStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRandomAccessStreamStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRandomAccessStreamStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IRandomAccessStreamStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRandomAccessStreamStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRandomAccessStreamStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CopyAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream source,
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
            IOutputStream destination,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **"
        )]
            IAsyncOperationWithProgress<ulong, ulong>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IRandomAccessStreamStatics,
                IInputStream,
                IOutputStream,
                IAsyncOperationWithProgress<ulong, ulong>**,
                int>)((*lpVtbl)[6])
        )(this, source, destination, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopySizeAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream source,
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
            IOutputStream destination,
        [NativeTypeName("UINT64")] ulong bytesToCopy,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **"
        )]
            IAsyncOperationWithProgress<ulong, ulong>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IRandomAccessStreamStatics,
                IInputStream,
                IOutputStream,
                ulong,
                IAsyncOperationWithProgress<ulong, ulong>**,
                int>)((*lpVtbl)[7])
        )(this, source, destination, bytesToCopy, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CopyAndCloseAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream source,
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
            IOutputStream destination,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **"
        )]
            IAsyncOperationWithProgress<ulong, ulong>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IRandomAccessStreamStatics,
                IInputStream,
                IOutputStream,
                IAsyncOperationWithProgress<ulong, ulong>**,
                int>)((*lpVtbl)[8])
        )(this, source, destination, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CopyAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream source,
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
                IOutputStream destination,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **"
            )]
                IAsyncOperationWithProgress<ulong, ulong>** operation
        );

        [VtblIndex(7)]
        HRESULT CopySizeAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream source,
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
                IOutputStream destination,
            [NativeTypeName("UINT64")] ulong bytesToCopy,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **"
            )]
                IAsyncOperationWithProgress<ulong, ulong>** operation
        );

        [VtblIndex(8)]
        HRESULT CopyAndCloseAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream source,
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
                IOutputStream destination,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **"
            )]
                IAsyncOperationWithProgress<ulong, ulong>** operation
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
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInputStream,
            IOutputStream,
            IAsyncOperationWithProgress<ulong, ulong>**,
            int> CopyAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Storage::Streams::IOutputStream *, UINT64, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInputStream,
            IOutputStream,
            ulong,
            IAsyncOperationWithProgress<ulong, ulong>**,
            int> CopySizeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInputStream,
            IOutputStream,
            IAsyncOperationWithProgress<ulong, ulong>**,
            int> CopyAndCloseAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRandomAccessStreamStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRandomAccessStreamStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRandomAccessStreamStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRandomAccessStreamStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IRandomAccessStreamStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRandomAccessStreamStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRandomAccessStreamStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRandomAccessStreamStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRandomAccessStreamStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRandomAccessStreamStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IRandomAccessStreamStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRandomAccessStreamStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRandomAccessStreamStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRandomAccessStreamStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
