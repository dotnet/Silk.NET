// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISpatialAudioObjectRenderStream.xml' path='doc/member[@name="ISpatialAudioObjectRenderStream"]/*' />
[Guid("BAB5F473-B423-477B-85F5-B5A332A04153")]
[NativeTypeName("struct ISpatialAudioObjectRenderStream : ISpatialAudioObjectRenderStreamBase")]
[NativeInheritance("ISpatialAudioObjectRenderStreamBase")]
public unsafe partial struct ISpatialAudioObjectRenderStream : ISpatialAudioObjectRenderStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioObjectRenderStream));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, uint>)(lpVtbl[1]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, uint>)(lpVtbl[2]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.GetAvailableDynamicObjectCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.GetService" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetService([NativeTypeName("const IID &")] Guid* riid, void** service)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, Guid*, void**, int>)(lpVtbl[4]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), riid, service);
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.Start" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, int>)(lpVtbl[5]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.Stop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, int>)(lpVtbl[6]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.Reset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, int>)(lpVtbl[7]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.BeginUpdatingAudioObjects" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BeginUpdatingAudioObjects([NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, uint*, uint*, int>)(lpVtbl[8]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), availableDynamicObjectCount, frameCountPerBuffer);
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.EndUpdatingAudioObjects" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EndUpdatingAudioObjects()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, int>)(lpVtbl[9]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpatialAudioObjectRenderStream.xml' path='doc/member[@name="ISpatialAudioObjectRenderStream.ActivateSpatialAudioObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ActivateSpatialAudioObject(AudioObjectType type, ISpatialAudioObject** audioObject)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, AudioObjectType, ISpatialAudioObject**, int>)(lpVtbl[10]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), type, audioObject);
    }

    public interface Interface : ISpatialAudioObjectRenderStreamBase.Interface
    {
        [VtblIndex(10)]
        HRESULT ActivateSpatialAudioObject(AudioObjectType type, ISpatialAudioObject** audioObject);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetAvailableDynamicObjectCount;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetService;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (UINT32 *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> BeginUpdatingAudioObjects;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndUpdatingAudioObjects;

        [NativeTypeName("HRESULT (AudioObjectType, ISpatialAudioObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioObjectType, ISpatialAudioObject**, int> ActivateSpatialAudioObject;
    }
}
