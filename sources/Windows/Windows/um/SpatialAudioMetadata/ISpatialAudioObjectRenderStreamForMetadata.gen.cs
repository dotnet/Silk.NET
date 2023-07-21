// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISpatialAudioObjectRenderStreamForMetadata.xml' path='doc/member[@name="ISpatialAudioObjectRenderStreamForMetadata"]/*' />
[Guid("BBC9C907-48D5-4A2E-A0C7-F7F0D67C1FB1")]
[NativeTypeName("struct ISpatialAudioObjectRenderStreamForMetadata : ISpatialAudioObjectRenderStreamBase")]
[NativeInheritance("ISpatialAudioObjectRenderStreamBase")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioObjectRenderStreamForMetadata : ISpatialAudioObjectRenderStreamForMetadata.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioObjectRenderStreamForMetadata));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, uint>)(lpVtbl[1]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, uint>)(lpVtbl[2]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.GetAvailableDynamicObjectCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.GetService" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetService([NativeTypeName("const IID &")] Guid* riid, void** service)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, Guid*, void**, int>)(lpVtbl[4]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this), riid, service);
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.Start" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, int>)(lpVtbl[5]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.Stop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, int>)(lpVtbl[6]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.Reset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, int>)(lpVtbl[7]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.BeginUpdatingAudioObjects" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BeginUpdatingAudioObjects([NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, uint*, uint*, int>)(lpVtbl[8]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this), availableDynamicObjectCount, frameCountPerBuffer);
    }

    /// <inheritdoc cref="ISpatialAudioObjectRenderStreamBase.EndUpdatingAudioObjects" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EndUpdatingAudioObjects()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, int>)(lpVtbl[9]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpatialAudioObjectRenderStreamForMetadata.xml' path='doc/member[@name="ISpatialAudioObjectRenderStreamForMetadata.ActivateSpatialAudioObjectForMetadataCommands"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ActivateSpatialAudioObjectForMetadataCommands(AudioObjectType type, ISpatialAudioObjectForMetadataCommands** audioObject)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, AudioObjectType, ISpatialAudioObjectForMetadataCommands**, int>)(lpVtbl[10]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this), type, audioObject);
    }

    /// <include file='ISpatialAudioObjectRenderStreamForMetadata.xml' path='doc/member[@name="ISpatialAudioObjectRenderStreamForMetadata.ActivateSpatialAudioObjectForMetadataItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ActivateSpatialAudioObjectForMetadataItems(AudioObjectType type, ISpatialAudioObjectForMetadataItems** audioObject)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, AudioObjectType, ISpatialAudioObjectForMetadataItems**, int>)(lpVtbl[11]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this), type, audioObject);
    }

    public interface Interface : ISpatialAudioObjectRenderStreamBase.Interface
    {
        [VtblIndex(10)]
        HRESULT ActivateSpatialAudioObjectForMetadataCommands(AudioObjectType type, ISpatialAudioObjectForMetadataCommands** audioObject);

        [VtblIndex(11)]
        HRESULT ActivateSpatialAudioObjectForMetadataItems(AudioObjectType type, ISpatialAudioObjectForMetadataItems** audioObject);
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

        [NativeTypeName("HRESULT (AudioObjectType, ISpatialAudioObjectForMetadataCommands **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioObjectType, ISpatialAudioObjectForMetadataCommands**, int> ActivateSpatialAudioObjectForMetadataCommands;

        [NativeTypeName("HRESULT (AudioObjectType, ISpatialAudioObjectForMetadataItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioObjectType, ISpatialAudioObjectForMetadataItems**, int> ActivateSpatialAudioObjectForMetadataItems;
    }
}
