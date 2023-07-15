// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpatialAudioClient2.xml' path='doc/member[@name="ISpatialAudioClient2"]/*'/>
[Guid("CAABE452-A66A-4BEE-A93E-E320463F6A53")]
[NativeTypeName("struct ISpatialAudioClient2 : ISpatialAudioClient")]
[NativeInheritance("ISpatialAudioClient")]
public unsafe partial struct ISpatialAudioClient2 : ISpatialAudioClient2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioClient2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, Guid*, void**, int> )(lpVtbl[0]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, uint> )(lpVtbl[1]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, uint> )(lpVtbl[2]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISpatialAudioClient.GetStaticObjectPosition"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStaticObjectPosition(AudioObjectType type, float* x, float* y, float* z)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, AudioObjectType, float*, float*, float*, int> )(lpVtbl[3]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this), type, x, y, z);
    }

    /// <inheritdoc cref = "ISpatialAudioClient.GetNativeStaticObjectTypeMask"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetNativeStaticObjectTypeMask(AudioObjectType* mask)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, AudioObjectType*, int> )(lpVtbl[4]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this), mask);
    }

    /// <inheritdoc cref = "ISpatialAudioClient.GetMaxDynamicObjectCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMaxDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, uint*, int> )(lpVtbl[5]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "ISpatialAudioClient.GetSupportedAudioObjectFormatEnumerator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSupportedAudioObjectFormatEnumerator(IAudioFormatEnumerator** enumerator)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, IAudioFormatEnumerator**, int> )(lpVtbl[6]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this), enumerator);
    }

    /// <inheritdoc cref = "ISpatialAudioClient.GetMaxFrameCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMaxFrameCount([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, WAVEFORMATEX*, uint*, int> )(lpVtbl[7]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this), objectFormat, frameCountPerBuffer);
    }

    /// <inheritdoc cref = "ISpatialAudioClient.IsAudioObjectFormatSupported"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsAudioObjectFormatSupported([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, WAVEFORMATEX*, int> )(lpVtbl[8]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this), objectFormat);
    }

    /// <inheritdoc cref = "ISpatialAudioClient.IsSpatialAudioStreamAvailable"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsSpatialAudioStreamAvailable([NativeTypeName("const IID &")] Guid* streamUuid, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* auxiliaryInfo)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, Guid*, PROPVARIANT*, int> )(lpVtbl[9]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this), streamUuid, auxiliaryInfo);
    }

    /// <inheritdoc cref = "ISpatialAudioClient.ActivateSpatialAudioStream"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ActivateSpatialAudioStream([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* activationParams, [NativeTypeName("const IID &")] Guid* riid, void** stream)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, PROPVARIANT*, Guid*, void**, int> )(lpVtbl[10]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this), activationParams, riid, stream);
    }

    /// <include file='ISpatialAudioClient2.xml' path='doc/member[@name="ISpatialAudioClient2.IsOffloadCapable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsOffloadCapable(AUDIO_STREAM_CATEGORY category, BOOL* isOffloadCapable)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, AUDIO_STREAM_CATEGORY, BOOL*, int> )(lpVtbl[11]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this), category, isOffloadCapable);
    }

    /// <include file='ISpatialAudioClient2.xml' path='doc/member[@name="ISpatialAudioClient2.GetMaxFrameCountForCategory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMaxFrameCountForCategory(AUDIO_STREAM_CATEGORY category, BOOL offloadEnabled, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
    {
        return ((delegate* unmanaged<ISpatialAudioClient2*, AUDIO_STREAM_CATEGORY, BOOL, WAVEFORMATEX*, uint*, int> )(lpVtbl[12]))((ISpatialAudioClient2*)Unsafe.AsPointer(ref this), category, offloadEnabled, objectFormat, frameCountPerBuffer);
    }

    public interface Interface : ISpatialAudioClient.Interface
    {
        [VtblIndex(11)]
        HRESULT IsOffloadCapable(AUDIO_STREAM_CATEGORY category, BOOL* isOffloadCapable);
        [VtblIndex(12)]
        HRESULT GetMaxFrameCountForCategory(AUDIO_STREAM_CATEGORY category, BOOL offloadEnabled, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer);
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
        [NativeTypeName("HRESULT (AudioObjectType, float *, float *, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioObjectType, float*, float*, float*, int> GetStaticObjectPosition;
        [NativeTypeName("HRESULT (AudioObjectType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioObjectType*, int> GetNativeStaticObjectTypeMask;
        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaxDynamicObjectCount;
        [NativeTypeName("HRESULT (IAudioFormatEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAudioFormatEnumerator**, int> GetSupportedAudioObjectFormatEnumerator;
        [NativeTypeName("HRESULT (const WAVEFORMATEX *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WAVEFORMATEX*, uint*, int> GetMaxFrameCount;
        [NativeTypeName("HRESULT (const WAVEFORMATEX *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WAVEFORMATEX*, int> IsAudioObjectFormatSupported;
        [NativeTypeName("HRESULT (const IID &, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> IsSpatialAudioStreamAvailable;
        [NativeTypeName("HRESULT (const PROPVARIANT *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, Guid*, void**, int> ActivateSpatialAudioStream;
        [NativeTypeName("HRESULT (AUDIO_STREAM_CATEGORY, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AUDIO_STREAM_CATEGORY, BOOL*, int> IsOffloadCapable;
        [NativeTypeName("HRESULT (AUDIO_STREAM_CATEGORY, BOOL, const WAVEFORMATEX *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AUDIO_STREAM_CATEGORY, BOOL, WAVEFORMATEX*, uint*, int> GetMaxFrameCountForCategory;
    }
}