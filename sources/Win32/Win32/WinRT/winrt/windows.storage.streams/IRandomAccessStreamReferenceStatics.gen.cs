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

[Guid("857309DC-3FBF-4E7D-986F-EF3B1A07A964")]
[NativeTypeName("struct IRandomAccessStreamReferenceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRandomAccessStreamReferenceStatics
    : IRandomAccessStreamReferenceStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRandomAccessStreamReferenceStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IRandomAccessStreamReferenceStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRandomAccessStreamReferenceStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRandomAccessStreamReferenceStatics, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IRandomAccessStreamReferenceStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IRandomAccessStreamReferenceStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IRandomAccessStreamReferenceStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromFile(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* streamReference
    )
    {
        return (
            (delegate* unmanaged<
                IRandomAccessStreamReferenceStatics,
                IStorageFile,
                IRandomAccessStreamReference*,
                int>)((*lpVtbl)[6])
        )(this, file, streamReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* streamReference
    )
    {
        return (
            (delegate* unmanaged<
                IRandomAccessStreamReferenceStatics,
                IUriRuntimeClass,
                IRandomAccessStreamReference*,
                int>)((*lpVtbl)[7])
        )(this, uri, streamReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* streamReference
    )
    {
        return (
            (delegate* unmanaged<
                IRandomAccessStreamReferenceStatics,
                IRandomAccessStream,
                IRandomAccessStreamReference*,
                int>)((*lpVtbl)[8])
        )(this, stream, streamReference);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromFile(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* streamReference
        );

        [VtblIndex(7)]
        HRESULT CreateFromUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* streamReference
        );

        [VtblIndex(8)]
        HRESULT CreateFromStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* streamReference
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
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IRandomAccessStreamReference*,
            int> CreateFromFile;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IRandomAccessStreamReference*,
            int> CreateFromUri;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStream,
            IRandomAccessStreamReference*,
            int> CreateFromStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRandomAccessStreamReferenceStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRandomAccessStreamReferenceStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRandomAccessStreamReferenceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRandomAccessStreamReferenceStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IRandomAccessStreamReferenceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRandomAccessStreamReferenceStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRandomAccessStreamReferenceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IRandomAccessStreamReferenceStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRandomAccessStreamReferenceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRandomAccessStreamReferenceStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IRandomAccessStreamReferenceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRandomAccessStreamReferenceStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRandomAccessStreamReferenceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IRandomAccessStreamReferenceStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
