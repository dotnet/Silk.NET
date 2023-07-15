// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpatialAudioObjectForMetadataCommands.xml' path='doc/member[@name="ISpatialAudioObjectForMetadataCommands"]/*'/>
[Guid("0DF2C94B-F5F9-472D-AF6B-C46E0AC9CD05")]
[NativeTypeName("struct ISpatialAudioObjectForMetadataCommands : ISpatialAudioObjectBase")]
[NativeInheritance("ISpatialAudioObjectBase")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioObjectForMetadataCommands : ISpatialAudioObjectForMetadataCommands.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioObjectForMetadataCommands));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, Guid*, void**, int> )(lpVtbl[0]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, uint> )(lpVtbl[1]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, uint> )(lpVtbl[2]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISpatialAudioObjectBase.GetBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, byte**, uint*, int> )(lpVtbl[3]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), buffer, bufferLength);
    }

    /// <inheritdoc cref = "ISpatialAudioObjectBase.SetEndOfStream"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, uint, int> )(lpVtbl[4]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), frameCount);
    }

    /// <inheritdoc cref = "ISpatialAudioObjectBase.IsActive"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsActive(BOOL* isActive)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, BOOL*, int> )(lpVtbl[5]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), isActive);
    }

    /// <inheritdoc cref = "ISpatialAudioObjectBase.GetAudioObjectType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAudioObjectType(AudioObjectType* audioObjectType)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, AudioObjectType*, int> )(lpVtbl[6]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), audioObjectType);
    }

    /// <include file='ISpatialAudioObjectForMetadataCommands.xml' path='doc/member[@name="ISpatialAudioObjectForMetadataCommands.WriteNextMetadataCommand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT WriteNextMetadataCommand(byte commandID, void* valueBuffer, [NativeTypeName("UINT32")] uint valueBufferLength)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, byte, void*, uint, int> )(lpVtbl[7]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), commandID, valueBuffer, valueBufferLength);
    }

    public interface Interface : ISpatialAudioObjectBase.Interface
    {
        [VtblIndex(7)]
        HRESULT WriteNextMetadataCommand(byte commandID, void* valueBuffer, [NativeTypeName("UINT32")] uint valueBufferLength);
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
        [NativeTypeName("HRESULT (BYTE **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetBuffer;
        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetEndOfStream;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsActive;
        [NativeTypeName("HRESULT (AudioObjectType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioObjectType*, int> GetAudioObjectType;
        [NativeTypeName("HRESULT (BYTE, void *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, void*, uint, int> WriteNextMetadataCommand;
    }
}