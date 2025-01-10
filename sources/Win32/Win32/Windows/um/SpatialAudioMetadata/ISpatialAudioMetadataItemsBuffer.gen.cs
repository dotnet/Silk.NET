// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("42640A16-E1BD-42D9-9FF6-031AB71A2DBA")]
[NativeTypeName("struct ISpatialAudioMetadataItemsBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioMetadataItemsBuffer
    : ISpatialAudioMetadataItemsBuffer.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioMetadataItemsBuffer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpatialAudioMetadataItemsBuffer, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AttachToBuffer(byte* buffer, [NativeTypeName("UINT32")] uint bufferLength)
    {
        return (
            (delegate* unmanaged<ISpatialAudioMetadataItemsBuffer, byte*, uint, int>)((*lpVtbl)[3])
        )(this, buffer, bufferLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AttachToPopulatedBuffer(
        byte* buffer,
        [NativeTypeName("UINT32")] uint bufferLength
    )
    {
        return (
            (delegate* unmanaged<ISpatialAudioMetadataItemsBuffer, byte*, uint, int>)((*lpVtbl)[4])
        )(this, buffer, bufferLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DetachBuffer()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer, int>)((*lpVtbl)[5]))(this);
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

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAudioMetadataItemsBuffer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAudioMetadataItemsBuffer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAudioMetadataItemsBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAudioMetadataItemsBuffer(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISpatialAudioMetadataItemsBuffer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioMetadataItemsBuffer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioMetadataItemsBuffer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISpatialAudioMetadataItemsBuffer value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
