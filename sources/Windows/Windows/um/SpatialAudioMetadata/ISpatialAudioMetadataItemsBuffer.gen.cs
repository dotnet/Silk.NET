// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISpatialAudioMetadataItemsBuffer.xml' path='doc/member[@name="ISpatialAudioMetadataItemsBuffer"]/*' />
[Guid("42640A16-E1BD-42D9-9FF6-031AB71A2DBA")]
[NativeTypeName("struct ISpatialAudioMetadataItemsBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioMetadataItemsBuffer : ISpatialAudioMetadataItemsBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioMetadataItemsBuffer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpatialAudioMetadataItemsBuffer.xml' path='doc/member[@name="ISpatialAudioMetadataItemsBuffer.AttachToBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AttachToBuffer(byte* buffer, [NativeTypeName("UINT32")] uint bufferLength)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer*, byte*, uint, int>)(lpVtbl[3]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this), buffer, bufferLength);
    }

    /// <include file='ISpatialAudioMetadataItemsBuffer.xml' path='doc/member[@name="ISpatialAudioMetadataItemsBuffer.AttachToPopulatedBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AttachToPopulatedBuffer(byte* buffer, [NativeTypeName("UINT32")] uint bufferLength)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer*, byte*, uint, int>)(lpVtbl[4]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this), buffer, bufferLength);
    }

    /// <include file='ISpatialAudioMetadataItemsBuffer.xml' path='doc/member[@name="ISpatialAudioMetadataItemsBuffer.DetachBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DetachBuffer()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer*, int>)(lpVtbl[5]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AttachToBuffer(byte* buffer, [NativeTypeName("UINT32")] uint bufferLength);

        [VtblIndex(4)]
        HRESULT AttachToPopulatedBuffer(byte* buffer, [NativeTypeName("UINT32")] uint bufferLength);

        [VtblIndex(5)]
        HRESULT DetachBuffer();
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

        [NativeTypeName("HRESULT (BYTE *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> AttachToBuffer;

        [NativeTypeName("HRESULT (BYTE *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> AttachToPopulatedBuffer;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DetachBuffer;
    }
}
