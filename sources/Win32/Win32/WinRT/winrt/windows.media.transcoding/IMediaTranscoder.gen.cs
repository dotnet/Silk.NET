// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.transcoding.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("190C99D2-A0AA-4D34-86BC-EED1B12C2F5B")]
[NativeTypeName("struct IMediaTranscoder : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaTranscoder : IMediaTranscoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaTranscoder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaTranscoder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaTranscoder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaTranscoder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaTranscoder, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaTranscoder, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaTranscoder, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_TrimStartTime(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IMediaTranscoder, TimeSpan, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TrimStartTime(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IMediaTranscoder, TimeSpan*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_TrimStopTime(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IMediaTranscoder, TimeSpan, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TrimStopTime(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IMediaTranscoder, TimeSpan*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_AlwaysReencode([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IMediaTranscoder, byte, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_AlwaysReencode([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaTranscoder, byte*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_HardwareAccelerationEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IMediaTranscoder, byte, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_HardwareAccelerationEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaTranscoder, byte*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT AddAudioEffect(HSTRING activatableClassId)
    {
        return ((delegate* unmanaged<IMediaTranscoder, HSTRING, int>)((*lpVtbl)[14]))(
            this,
            activatableClassId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT AddAudioEffectWithSettings(
        HSTRING activatableClassId,
        [NativeTypeName("boolean")] byte effectRequired,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet configuration
    )
    {
        return (
            (delegate* unmanaged<IMediaTranscoder, HSTRING, byte, IPropertySet, int>)((*lpVtbl)[15])
        )(this, activatableClassId, effectRequired, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AddVideoEffect(HSTRING activatableClassId)
    {
        return ((delegate* unmanaged<IMediaTranscoder, HSTRING, int>)((*lpVtbl)[16]))(
            this,
            activatableClassId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AddVideoEffectWithSettings(
        HSTRING activatableClassId,
        [NativeTypeName("boolean")] byte effectRequired,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet configuration
    )
    {
        return (
            (delegate* unmanaged<IMediaTranscoder, HSTRING, byte, IPropertySet, int>)((*lpVtbl)[17])
        )(this, activatableClassId, effectRequired, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ClearEffects()
    {
        return ((delegate* unmanaged<IMediaTranscoder, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT PrepareFileTranscodeAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile source,
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile destination,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile profile,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaTranscoder,
                IStorageFile,
                IStorageFile,
                IMediaEncodingProfile,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[19])
        )(this, source, destination, profile, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT PrepareStreamTranscodeAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream source,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream destination,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile profile,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaTranscoder,
                IRandomAccessStream,
                IRandomAccessStream,
                IMediaEncodingProfile,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[20])
        )(this, source, destination, profile, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_TrimStartTime(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
        );

        [VtblIndex(7)]
        HRESULT get_TrimStartTime(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(8)]
        HRESULT put_TrimStopTime(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
        );

        [VtblIndex(9)]
        HRESULT get_TrimStopTime(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(10)]
        HRESULT put_AlwaysReencode([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_AlwaysReencode([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_HardwareAccelerationEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT get_HardwareAccelerationEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT AddAudioEffect(HSTRING activatableClassId);

        [VtblIndex(15)]
        HRESULT AddAudioEffectWithSettings(
            HSTRING activatableClassId,
            [NativeTypeName("boolean")] byte effectRequired,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet configuration
        );

        [VtblIndex(16)]
        HRESULT AddVideoEffect(HSTRING activatableClassId);

        [VtblIndex(17)]
        HRESULT AddVideoEffectWithSettings(
            HSTRING activatableClassId,
            [NativeTypeName("boolean")] byte effectRequired,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet configuration
        );

        [VtblIndex(18)]
        HRESULT ClearEffects();

        [VtblIndex(19)]
        HRESULT PrepareFileTranscodeAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile source,
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile destination,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile profile,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(20)]
        HRESULT PrepareStreamTranscodeAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream source,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream destination,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile profile,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **"
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_TrimStartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_TrimStartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_TrimStopTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_TrimStopTime;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AlwaysReencode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AlwaysReencode;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_HardwareAccelerationEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_HardwareAccelerationEnabled;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> AddAudioEffect;

        [NativeTypeName(
            "HRESULT (HSTRING, boolean, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            byte,
            IPropertySet,
            int> AddAudioEffectWithSettings;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> AddVideoEffect;

        [NativeTypeName(
            "HRESULT (HSTRING, boolean, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            byte,
            IPropertySet,
            int> AddVideoEffectWithSettings;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearEffects;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IStorageFile,
            IMediaEncodingProfile,
            IAsyncOperation<IntPtr>**,
            int> PrepareFileTranscodeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStream,
            IRandomAccessStream,
            IMediaEncodingProfile,
            IAsyncOperation<IntPtr>**,
            int> PrepareStreamTranscodeAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaTranscoder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaTranscoder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaTranscoder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaTranscoder(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaTranscoder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaTranscoder"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaTranscoder"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaTranscoder value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaTranscoder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaTranscoder(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaTranscoder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaTranscoder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaTranscoder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaTranscoder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
