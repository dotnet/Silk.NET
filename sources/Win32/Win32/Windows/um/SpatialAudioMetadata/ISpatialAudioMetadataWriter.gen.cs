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

[Guid("1B17CA01-2955-444D-A430-537DC589A844")]
[NativeTypeName("struct ISpatialAudioMetadataWriter : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioMetadataWriter
    : ISpatialAudioMetadataWriter.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioMetadataWriter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpatialAudioMetadataWriter, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataWriter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataWriter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Open(ISpatialAudioMetadataItems metadataItems)
    {
        return (
            (delegate* unmanaged<ISpatialAudioMetadataWriter, ISpatialAudioMetadataItems, int>)(
                (*lpVtbl)[3]
            )
        )(this, metadataItems);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WriteNextItem([NativeTypeName("UINT16")] ushort frameOffset)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataWriter, ushort, int>)((*lpVtbl)[4]))(
            this,
            frameOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT WriteNextItemCommand(
        byte commandID,
        [NativeTypeName("const void *")] void* valueBuffer,
        [NativeTypeName("UINT32")] uint valueBufferLength
    )
    {
        return (
            (delegate* unmanaged<ISpatialAudioMetadataWriter, byte, void*, uint, int>)((*lpVtbl)[5])
        )(this, commandID, valueBuffer, valueBufferLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataWriter, int>)((*lpVtbl)[6]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Open(ISpatialAudioMetadataItems metadataItems);

        [VtblIndex(4)]
        HRESULT WriteNextItem([NativeTypeName("UINT16")] ushort frameOffset);

        [VtblIndex(5)]
        HRESULT WriteNextItemCommand(
            byte commandID,
            [NativeTypeName("const void *")] void* valueBuffer,
            [NativeTypeName("UINT32")] uint valueBufferLength
        );

        [VtblIndex(6)]
        HRESULT Close();
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

        [NativeTypeName("HRESULT (ISpatialAudioMetadataItems *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpatialAudioMetadataItems, int> Open;

        [NativeTypeName("HRESULT (UINT16) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> WriteNextItem;

        [NativeTypeName("HRESULT (BYTE, const void *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, void*, uint, int> WriteNextItemCommand;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAudioMetadataWriter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAudioMetadataWriter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAudioMetadataWriter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAudioMetadataWriter(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialAudioMetadataWriter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioMetadataWriter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioMetadataWriter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialAudioMetadataWriter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
