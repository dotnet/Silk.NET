// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("8A4CD4A1-ED85-4E0F-BD68-8A6862E4636D")]
[NativeTypeName("struct IStreamSelectorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSelectorStatics : IStreamSelectorStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamSelectorStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStreamSelectorStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStreamSelectorStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStreamSelectorStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStreamSelectorStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStreamSelectorStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStreamSelectorStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SelectBestStreamAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile storageFile,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet selectorProperties,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IStreamSelectorStatics,
                IStorageFile,
                IPropertySet,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, storageFile, selectorProperties, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetStreamPropertiesAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile storageFile,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet selectorProperties,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___F__CIPropertySet_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IStreamSelectorStatics,
                IStorageFile,
                IPropertySet,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, storageFile, selectorProperties, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SelectBestStreamFromStreamAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet selectorProperties,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IStreamSelectorStatics,
                IRandomAccessStream,
                IPropertySet,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, stream, selectorProperties, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetStreamPropertiesFromStreamAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet selectorProperties,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___F__CIPropertySet_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IStreamSelectorStatics,
                IRandomAccessStream,
                IPropertySet,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, stream, selectorProperties, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SelectBestStreamAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile storageFile,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet selectorProperties,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT GetStreamPropertiesAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile storageFile,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet selectorProperties,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___F__CIPropertySet_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(8)]
        HRESULT SelectBestStreamFromStreamAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet selectorProperties,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(9)]
        HRESULT GetStreamPropertiesFromStreamAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet selectorProperties,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___F__CIPropertySet_t **"
            )]
                IAsyncOperation<IntPtr>** value
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
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IPropertySet,
            IAsyncOperation<IntPtr>**,
            int> SelectBestStreamAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___F__CIPropertySet_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IPropertySet,
            IAsyncOperation<IntPtr>**,
            int> GetStreamPropertiesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStream,
            IPropertySet,
            IAsyncOperation<IntPtr>**,
            int> SelectBestStreamFromStreamAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___F__CIPropertySet_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStream,
            IPropertySet,
            IAsyncOperation<IntPtr>**,
            int> GetStreamPropertiesFromStreamAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStreamSelectorStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStreamSelectorStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStreamSelectorStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStreamSelectorStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IStreamSelectorStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamSelectorStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamSelectorStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStreamSelectorStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStreamSelectorStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStreamSelectorStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IStreamSelectorStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamSelectorStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamSelectorStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStreamSelectorStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
