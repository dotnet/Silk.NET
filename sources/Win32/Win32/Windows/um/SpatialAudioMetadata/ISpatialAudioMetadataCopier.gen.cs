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

[Guid("D224B233-E251-4FD0-9CA2-D5ECF9A68404")]
[NativeTypeName("struct ISpatialAudioMetadataCopier : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioMetadataCopier
    : ISpatialAudioMetadataCopier.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioMetadataCopier));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpatialAudioMetadataCopier, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataCopier, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataCopier, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Open(ISpatialAudioMetadataItems metadataItems)
    {
        return (
            (delegate* unmanaged<ISpatialAudioMetadataCopier, ISpatialAudioMetadataItems, int>)(
                (*lpVtbl)[3]
            )
        )(this, metadataItems);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CopyMetadataForFrames(
        [NativeTypeName("UINT16")] ushort copyFrameCount,
        SpatialAudioMetadataCopyMode copyMode,
        ISpatialAudioMetadataItems dstMetadataItems,
        [NativeTypeName("UINT16 *")] ushort* itemsCopied
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAudioMetadataCopier,
                ushort,
                SpatialAudioMetadataCopyMode,
                ISpatialAudioMetadataItems,
                ushort*,
                int>)((*lpVtbl)[4])
        )(this, copyFrameCount, copyMode, dstMetadataItems, itemsCopied);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataCopier, int>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Open(ISpatialAudioMetadataItems metadataItems);

        [VtblIndex(4)]
        HRESULT CopyMetadataForFrames(
            [NativeTypeName("UINT16")] ushort copyFrameCount,
            SpatialAudioMetadataCopyMode copyMode,
            ISpatialAudioMetadataItems dstMetadataItems,
            [NativeTypeName("UINT16 *")] ushort* itemsCopied
        );

        [VtblIndex(5)]
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

        [NativeTypeName(
            "HRESULT (UINT16, SpatialAudioMetadataCopyMode, ISpatialAudioMetadataItems *, UINT16 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort,
            SpatialAudioMetadataCopyMode,
            ISpatialAudioMetadataItems,
            ushort*,
            int> CopyMetadataForFrames;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAudioMetadataCopier"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAudioMetadataCopier(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAudioMetadataCopier"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAudioMetadataCopier(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialAudioMetadataCopier(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioMetadataCopier"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioMetadataCopier"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialAudioMetadataCopier value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
