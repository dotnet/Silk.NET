// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpatialAudioMetadataCopier.xml' path='doc/member[@name="ISpatialAudioMetadataCopier"]/*'/>
[Guid("D224B233-E251-4FD0-9CA2-D5ECF9A68404")]
[NativeTypeName("struct ISpatialAudioMetadataCopier : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioMetadataCopier : ISpatialAudioMetadataCopier.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioMetadataCopier));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, Guid*, void**, int> )(lpVtbl[0]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, uint> )(lpVtbl[1]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, uint> )(lpVtbl[2]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpatialAudioMetadataCopier.xml' path='doc/member[@name="ISpatialAudioMetadataCopier.Open"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Open(ISpatialAudioMetadataItems* metadataItems)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, ISpatialAudioMetadataItems*, int> )(lpVtbl[3]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this), metadataItems);
    }

    /// <include file='ISpatialAudioMetadataCopier.xml' path='doc/member[@name="ISpatialAudioMetadataCopier.CopyMetadataForFrames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CopyMetadataForFrames([NativeTypeName("UINT16")] ushort copyFrameCount, SpatialAudioMetadataCopyMode copyMode, ISpatialAudioMetadataItems* dstMetadataItems, [NativeTypeName("UINT16 *")] ushort* itemsCopied)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, ushort, SpatialAudioMetadataCopyMode, ISpatialAudioMetadataItems*, ushort*, int> )(lpVtbl[4]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this), copyFrameCount, copyMode, dstMetadataItems, itemsCopied);
    }

    /// <include file='ISpatialAudioMetadataCopier.xml' path='doc/member[@name="ISpatialAudioMetadataCopier.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, int> )(lpVtbl[5]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Open(ISpatialAudioMetadataItems* metadataItems);
        [VtblIndex(4)]
        HRESULT CopyMetadataForFrames([NativeTypeName("UINT16")] ushort copyFrameCount, SpatialAudioMetadataCopyMode copyMode, ISpatialAudioMetadataItems* dstMetadataItems, [NativeTypeName("UINT16 *")] ushort* itemsCopied);
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
        public delegate* unmanaged<TSelf*, ISpatialAudioMetadataItems*, int> Open;
        [NativeTypeName("HRESULT (UINT16, SpatialAudioMetadataCopyMode, ISpatialAudioMetadataItems *, UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, SpatialAudioMetadataCopyMode, ISpatialAudioMetadataItems*, ushort*, int> CopyMetadataForFrames;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }
}