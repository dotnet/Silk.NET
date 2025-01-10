// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D9B1C0D7-D018-42A8-A559-CB4D9E97E664")]
[NativeTypeName("struct IBackgroundAudioTrackStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundAudioTrackStatics
    : IBackgroundAudioTrackStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundAudioTrackStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBackgroundAudioTrackStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBackgroundAudioTrackStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundAudioTrackStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBackgroundAudioTrackStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBackgroundAudioTrackStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBackgroundAudioTrackStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromEmbeddedAudioTrack(
        [NativeTypeName("ABI::Windows::Media::Editing::IEmbeddedAudioTrack *")]
            IEmbeddedAudioTrack embeddedAudioTrack,
        [NativeTypeName("ABI::Windows::Media::Editing::IBackgroundAudioTrack **")]
            IBackgroundAudioTrack* value
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundAudioTrackStatics,
                IEmbeddedAudioTrack,
                IBackgroundAudioTrack*,
                int>)((*lpVtbl)[6])
        )(this, embeddedAudioTrack, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromFileAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CEditing__CBackgroundAudioTrack_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundAudioTrackStatics,
                IStorageFile,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, file, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromEmbeddedAudioTrack(
            [NativeTypeName("ABI::Windows::Media::Editing::IEmbeddedAudioTrack *")]
                IEmbeddedAudioTrack embeddedAudioTrack,
            [NativeTypeName("ABI::Windows::Media::Editing::IBackgroundAudioTrack **")]
                IBackgroundAudioTrack* value
        );

        [VtblIndex(7)]
        HRESULT CreateFromFileAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CEditing__CBackgroundAudioTrack_t **"
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
            "HRESULT (ABI::Windows::Media::Editing::IEmbeddedAudioTrack *, ABI::Windows::Media::Editing::IBackgroundAudioTrack **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEmbeddedAudioTrack,
            IBackgroundAudioTrack*,
            int> CreateFromEmbeddedAudioTrack;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CEditing__CBackgroundAudioTrack_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncOperation<IntPtr>**,
            int> CreateFromFileAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundAudioTrackStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundAudioTrackStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundAudioTrackStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundAudioTrackStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IBackgroundAudioTrackStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundAudioTrackStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundAudioTrackStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBackgroundAudioTrackStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundAudioTrackStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundAudioTrackStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IBackgroundAudioTrackStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundAudioTrackStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundAudioTrackStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBackgroundAudioTrackStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
