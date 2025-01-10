// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CAABE452-A66A-4BEE-A93E-E320463F6A53")]
[NativeTypeName("struct ISpatialAudioClient2 : ISpatialAudioClient")]
[NativeInheritance("ISpatialAudioClient")]
[SupportedOSPlatform("windows10.0.22000.0")]
public unsafe partial struct ISpatialAudioClient2 : ISpatialAudioClient2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioClient2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpatialAudioClient2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioClient2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStaticObjectPosition(AudioObjectType type, float* x, float* y, float* z)
    {
        return (
            (delegate* unmanaged<
                ISpatialAudioClient2,
                AudioObjectType,
                float*,
                float*,
                float*,
                int>)((*lpVtbl)[3])
        )(this, type, x, y, z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetNativeStaticObjectTypeMask(AudioObjectType* mask)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2, AudioObjectType*, int>)((*lpVtbl)[4]))(
            this,
            mask
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMaxDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2, uint*, int>)((*lpVtbl)[5]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSupportedAudioObjectFormatEnumerator(IAudioFormatEnumerator* enumerator)
    {
        return (
            (delegate* unmanaged<ISpatialAudioClient2, IAudioFormatEnumerator*, int>)((*lpVtbl)[6])
        )(this, enumerator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMaxFrameCount(
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat,
        [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer
    )
    {
        return (
            (delegate* unmanaged<ISpatialAudioClient2, WAVEFORMATEX*, uint*, int>)((*lpVtbl)[7])
        )(this, objectFormat, frameCountPerBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsAudioObjectFormatSupported(
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat
    )
    {
        return ((delegate* unmanaged<ISpatialAudioClient2, WAVEFORMATEX*, int>)((*lpVtbl)[8]))(
            this,
            objectFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsSpatialAudioStreamAvailable(
        [NativeTypeName("const IID &")] Guid* streamUuid,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* auxiliaryInfo
    )
    {
        return (
            (delegate* unmanaged<ISpatialAudioClient2, Guid*, PROPVARIANT*, int>)((*lpVtbl)[9])
        )(this, streamUuid, auxiliaryInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ActivateSpatialAudioStream(
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* activationParams,
        [NativeTypeName("const IID &")] Guid* riid,
        void** stream
    )
    {
        return (
            (delegate* unmanaged<ISpatialAudioClient2, PROPVARIANT*, Guid*, void**, int>)(
                (*lpVtbl)[10]
            )
        )(this, activationParams, riid, stream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsOffloadCapable(AUDIO_STREAM_CATEGORY category, BOOL* isOffloadCapable)
    {
        return (
            (delegate* unmanaged<ISpatialAudioClient2, AUDIO_STREAM_CATEGORY, BOOL*, int>)(
                (*lpVtbl)[11]
            )
        )(this, category, isOffloadCapable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMaxFrameCountForCategory(
        AUDIO_STREAM_CATEGORY category,
        BOOL offloadEnabled,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat,
        [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAudioClient2,
                AUDIO_STREAM_CATEGORY,
                BOOL,
                WAVEFORMATEX*,
                uint*,
                int>)((*lpVtbl)[12])
        )(this, category, offloadEnabled, objectFormat, frameCountPerBuffer);
    }

    public interface Interface : ISpatialAudioClient.Interface
    {
        [VtblIndex(11)]
        HRESULT IsOffloadCapable(AUDIO_STREAM_CATEGORY category, BOOL* isOffloadCapable);

        [VtblIndex(12)]
        HRESULT GetMaxFrameCountForCategory(
            AUDIO_STREAM_CATEGORY category,
            BOOL offloadEnabled,
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat,
            [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer
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

        [NativeTypeName(
            "HRESULT (AudioObjectType, float *, float *, float *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioObjectType,
            float*,
            float*,
            float*,
            int> GetStaticObjectPosition;

        [NativeTypeName("HRESULT (AudioObjectType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioObjectType*, int> GetNativeStaticObjectTypeMask;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaxDynamicObjectCount;

        [NativeTypeName("HRESULT (IAudioFormatEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAudioFormatEnumerator*,
            int> GetSupportedAudioObjectFormatEnumerator;

        [NativeTypeName("HRESULT (const WAVEFORMATEX *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WAVEFORMATEX*, uint*, int> GetMaxFrameCount;

        [NativeTypeName("HRESULT (const WAVEFORMATEX *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WAVEFORMATEX*, int> IsAudioObjectFormatSupported;

        [NativeTypeName("HRESULT (const IID &, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> IsSpatialAudioStreamAvailable;

        [NativeTypeName(
            "HRESULT (const PROPVARIANT *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PROPVARIANT*,
            Guid*,
            void**,
            int> ActivateSpatialAudioStream;

        [NativeTypeName("HRESULT (AUDIO_STREAM_CATEGORY, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AUDIO_STREAM_CATEGORY, BOOL*, int> IsOffloadCapable;

        [NativeTypeName(
            "HRESULT (AUDIO_STREAM_CATEGORY, BOOL, const WAVEFORMATEX *, UINT32 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AUDIO_STREAM_CATEGORY,
            BOOL,
            WAVEFORMATEX*,
            uint*,
            int> GetMaxFrameCountForCategory;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAudioClient2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAudioClient2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpatialAudioClient"/> to <see cref = "ISpatialAudioClient2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpatialAudioClient"/> instance to be converted </param>
    public static explicit operator ISpatialAudioClient2(Silk.NET.Windows.ISpatialAudioClient value)
    {
        return new ISpatialAudioClient2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioClient2"/> to <see cref = "Silk.NET.Windows.ISpatialAudioClient"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioClient2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpatialAudioClient(ISpatialAudioClient2 value)
    {
        return new Silk.NET.Windows.ISpatialAudioClient(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAudioClient2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAudioClient2(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialAudioClient2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioClient2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioClient2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialAudioClient2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
