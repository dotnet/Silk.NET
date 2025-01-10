// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BBF8E066-AAAA-49BE-9A4D-FD2A858EA27F")]
[NativeTypeName("struct ISpatialAudioClient : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpatialAudioClient : ISpatialAudioClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioClient));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioClient, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpatialAudioClient, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioClient, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStaticObjectPosition(AudioObjectType type, float* x, float* y, float* z)
    {
        return (
            (delegate* unmanaged<
                ISpatialAudioClient,
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
        return ((delegate* unmanaged<ISpatialAudioClient, AudioObjectType*, int>)((*lpVtbl)[4]))(
            this,
            mask
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMaxDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISpatialAudioClient, uint*, int>)((*lpVtbl)[5]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSupportedAudioObjectFormatEnumerator(IAudioFormatEnumerator* enumerator)
    {
        return (
            (delegate* unmanaged<ISpatialAudioClient, IAudioFormatEnumerator*, int>)((*lpVtbl)[6])
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
            (delegate* unmanaged<ISpatialAudioClient, WAVEFORMATEX*, uint*, int>)((*lpVtbl)[7])
        )(this, objectFormat, frameCountPerBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsAudioObjectFormatSupported(
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat
    )
    {
        return ((delegate* unmanaged<ISpatialAudioClient, WAVEFORMATEX*, int>)((*lpVtbl)[8]))(
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
        return ((delegate* unmanaged<ISpatialAudioClient, Guid*, PROPVARIANT*, int>)((*lpVtbl)[9]))(
            this,
            streamUuid,
            auxiliaryInfo
        );
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
            (delegate* unmanaged<ISpatialAudioClient, PROPVARIANT*, Guid*, void**, int>)(
                (*lpVtbl)[10]
            )
        )(this, activationParams, riid, stream);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStaticObjectPosition(AudioObjectType type, float* x, float* y, float* z);

        [VtblIndex(4)]
        HRESULT GetNativeStaticObjectTypeMask(AudioObjectType* mask);

        [VtblIndex(5)]
        HRESULT GetMaxDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(6)]
        HRESULT GetSupportedAudioObjectFormatEnumerator(IAudioFormatEnumerator* enumerator);

        [VtblIndex(7)]
        HRESULT GetMaxFrameCount(
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat,
            [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer
        );

        [VtblIndex(8)]
        HRESULT IsAudioObjectFormatSupported(
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat
        );

        [VtblIndex(9)]
        HRESULT IsSpatialAudioStreamAvailable(
            [NativeTypeName("const IID &")] Guid* streamUuid,
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* auxiliaryInfo
        );

        [VtblIndex(10)]
        HRESULT ActivateSpatialAudioStream(
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* activationParams,
            [NativeTypeName("const IID &")] Guid* riid,
            void** stream
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
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAudioClient"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAudioClient(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAudioClient"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAudioClient(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialAudioClient(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioClient"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioClient"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialAudioClient value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
