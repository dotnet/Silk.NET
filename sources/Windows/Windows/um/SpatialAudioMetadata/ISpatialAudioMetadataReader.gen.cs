// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpatialAudioMetadataReader.xml' path='doc/member[@name="ISpatialAudioMetadataReader"]/*'/>
[Guid("B78E86A2-31D9-4C32-94D2-7DF40FC7EBEC")]
[NativeTypeName("struct ISpatialAudioMetadataReader : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioMetadataReader : ISpatialAudioMetadataReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioMetadataReader));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataReader*, Guid*, void**, int> )(lpVtbl[0]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataReader*, uint> )(lpVtbl[1]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataReader*, uint> )(lpVtbl[2]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpatialAudioMetadataReader.xml' path='doc/member[@name="ISpatialAudioMetadataReader.Open"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Open(ISpatialAudioMetadataItems* metadataItems)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataReader*, ISpatialAudioMetadataItems*, int> )(lpVtbl[3]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this), metadataItems);
    }

    /// <include file='ISpatialAudioMetadataReader.xml' path='doc/member[@name="ISpatialAudioMetadataReader.ReadNextItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReadNextItem([NativeTypeName("UINT8 *")] byte* commandCount, [NativeTypeName("UINT16 *")] ushort* frameOffset)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataReader*, byte*, ushort*, int> )(lpVtbl[4]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this), commandCount, frameOffset);
    }

    /// <include file='ISpatialAudioMetadataReader.xml' path='doc/member[@name="ISpatialAudioMetadataReader.ReadNextItemCommand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReadNextItemCommand(byte* commandID, void* valueBuffer, [NativeTypeName("UINT32")] uint maxValueBufferLength, [NativeTypeName("UINT32 *")] uint* valueBufferLength)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataReader*, byte*, void*, uint, uint*, int> )(lpVtbl[5]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this), commandID, valueBuffer, maxValueBufferLength, valueBufferLength);
    }

    /// <include file='ISpatialAudioMetadataReader.xml' path='doc/member[@name="ISpatialAudioMetadataReader.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataReader*, int> )(lpVtbl[6]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Open(ISpatialAudioMetadataItems* metadataItems);
        [VtblIndex(4)]
        HRESULT ReadNextItem([NativeTypeName("UINT8 *")] byte* commandCount, [NativeTypeName("UINT16 *")] ushort* frameOffset);
        [VtblIndex(5)]
        HRESULT ReadNextItemCommand(byte* commandID, void* valueBuffer, [NativeTypeName("UINT32")] uint maxValueBufferLength, [NativeTypeName("UINT32 *")] uint* valueBufferLength);
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
        public delegate* unmanaged<TSelf*, ISpatialAudioMetadataItems*, int> Open;
        [NativeTypeName("HRESULT (UINT8 *, UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, ushort*, int> ReadNextItem;
        [NativeTypeName("HRESULT (BYTE *, void *, UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, void*, uint, uint*, int> ReadNextItemCommand;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }
}