// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpatialAudioMetadataClient.xml' path='doc/member[@name="ISpatialAudioMetadataClient"]/*'/>
[Guid("777D4A3B-F6FF-4A26-85DC-68D7CDEDA1D4")]
[NativeTypeName("struct ISpatialAudioMetadataClient : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioMetadataClient : ISpatialAudioMetadataClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioMetadataClient));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataClient*, Guid*, void**, int> )(lpVtbl[0]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataClient*, uint> )(lpVtbl[1]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataClient*, uint> )(lpVtbl[2]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpatialAudioMetadataClient.xml' path='doc/member[@name="ISpatialAudioMetadataClient.ActivateSpatialAudioMetadataItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ActivateSpatialAudioMetadataItems([NativeTypeName("UINT16")] ushort maxItemCount, [NativeTypeName("UINT16")] ushort frameCount, ISpatialAudioMetadataItemsBuffer** metadataItemsBuffer, ISpatialAudioMetadataItems** metadataItems)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataClient*, ushort, ushort, ISpatialAudioMetadataItemsBuffer**, ISpatialAudioMetadataItems**, int> )(lpVtbl[3]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), maxItemCount, frameCount, metadataItemsBuffer, metadataItems);
    }

    /// <include file='ISpatialAudioMetadataClient.xml' path='doc/member[@name="ISpatialAudioMetadataClient.GetSpatialAudioMetadataItemsBufferLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSpatialAudioMetadataItemsBufferLength([NativeTypeName("UINT16")] ushort maxItemCount, [NativeTypeName("UINT32 *")] uint* bufferLength)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataClient*, ushort, uint*, int> )(lpVtbl[4]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), maxItemCount, bufferLength);
    }

    /// <include file='ISpatialAudioMetadataClient.xml' path='doc/member[@name="ISpatialAudioMetadataClient.ActivateSpatialAudioMetadataWriter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ActivateSpatialAudioMetadataWriter(SpatialAudioMetadataWriterOverflowMode overflowMode, ISpatialAudioMetadataWriter** metadataWriter)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataClient*, SpatialAudioMetadataWriterOverflowMode, ISpatialAudioMetadataWriter**, int> )(lpVtbl[5]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), overflowMode, metadataWriter);
    }

    /// <include file='ISpatialAudioMetadataClient.xml' path='doc/member[@name="ISpatialAudioMetadataClient.ActivateSpatialAudioMetadataCopier"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ActivateSpatialAudioMetadataCopier(ISpatialAudioMetadataCopier** metadataCopier)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataClient*, ISpatialAudioMetadataCopier**, int> )(lpVtbl[6]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), metadataCopier);
    }

    /// <include file='ISpatialAudioMetadataClient.xml' path='doc/member[@name="ISpatialAudioMetadataClient.ActivateSpatialAudioMetadataReader"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ActivateSpatialAudioMetadataReader(ISpatialAudioMetadataReader** metadataReader)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataClient*, ISpatialAudioMetadataReader**, int> )(lpVtbl[7]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), metadataReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ActivateSpatialAudioMetadataItems([NativeTypeName("UINT16")] ushort maxItemCount, [NativeTypeName("UINT16")] ushort frameCount, ISpatialAudioMetadataItemsBuffer** metadataItemsBuffer, ISpatialAudioMetadataItems** metadataItems);
        [VtblIndex(4)]
        HRESULT GetSpatialAudioMetadataItemsBufferLength([NativeTypeName("UINT16")] ushort maxItemCount, [NativeTypeName("UINT32 *")] uint* bufferLength);
        [VtblIndex(5)]
        HRESULT ActivateSpatialAudioMetadataWriter(SpatialAudioMetadataWriterOverflowMode overflowMode, ISpatialAudioMetadataWriter** metadataWriter);
        [VtblIndex(6)]
        HRESULT ActivateSpatialAudioMetadataCopier(ISpatialAudioMetadataCopier** metadataCopier);
        [VtblIndex(7)]
        HRESULT ActivateSpatialAudioMetadataReader(ISpatialAudioMetadataReader** metadataReader);
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
        [NativeTypeName("HRESULT (UINT16, UINT16, ISpatialAudioMetadataItemsBuffer **, ISpatialAudioMetadataItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, ushort, ISpatialAudioMetadataItemsBuffer**, ISpatialAudioMetadataItems**, int> ActivateSpatialAudioMetadataItems;
        [NativeTypeName("HRESULT (UINT16, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, uint*, int> GetSpatialAudioMetadataItemsBufferLength;
        [NativeTypeName("HRESULT (SpatialAudioMetadataWriterOverflowMode, ISpatialAudioMetadataWriter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpatialAudioMetadataWriterOverflowMode, ISpatialAudioMetadataWriter**, int> ActivateSpatialAudioMetadataWriter;
        [NativeTypeName("HRESULT (ISpatialAudioMetadataCopier **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpatialAudioMetadataCopier**, int> ActivateSpatialAudioMetadataCopier;
        [NativeTypeName("HRESULT (ISpatialAudioMetadataReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpatialAudioMetadataReader**, int> ActivateSpatialAudioMetadataReader;
    }
}