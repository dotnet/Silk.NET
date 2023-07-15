// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFSinkWriterEncoderConfig.xml' path='doc/member[@name="IMFSinkWriterEncoderConfig"]/*'/>
[Guid("17C3779E-3CDE-4EDE-8C60-3899F5F53AD6")]
[NativeTypeName("struct IMFSinkWriterEncoderConfig : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFSinkWriterEncoderConfig : IMFSinkWriterEncoderConfig.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSinkWriterEncoderConfig));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSinkWriterEncoderConfig*, Guid*, void**, int> )(lpVtbl[0]))((IMFSinkWriterEncoderConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSinkWriterEncoderConfig*, uint> )(lpVtbl[1]))((IMFSinkWriterEncoderConfig*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSinkWriterEncoderConfig*, uint> )(lpVtbl[2]))((IMFSinkWriterEncoderConfig*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSinkWriterEncoderConfig.xml' path='doc/member[@name="IMFSinkWriterEncoderConfig.SetTargetMediaType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetTargetMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType* pTargetMediaType, IMFAttributes* pEncodingParameters)
    {
        return ((delegate* unmanaged<IMFSinkWriterEncoderConfig*, uint, IMFMediaType*, IMFAttributes*, int> )(lpVtbl[3]))((IMFSinkWriterEncoderConfig*)Unsafe.AsPointer(ref this), dwStreamIndex, pTargetMediaType, pEncodingParameters);
    }

    /// <include file='IMFSinkWriterEncoderConfig.xml' path='doc/member[@name="IMFSinkWriterEncoderConfig.PlaceEncodingParameters"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PlaceEncodingParameters([NativeTypeName("DWORD")] uint dwStreamIndex, IMFAttributes* pEncodingParameters)
    {
        return ((delegate* unmanaged<IMFSinkWriterEncoderConfig*, uint, IMFAttributes*, int> )(lpVtbl[4]))((IMFSinkWriterEncoderConfig*)Unsafe.AsPointer(ref this), dwStreamIndex, pEncodingParameters);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetTargetMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType* pTargetMediaType, IMFAttributes* pEncodingParameters);
        [VtblIndex(4)]
        HRESULT PlaceEncodingParameters([NativeTypeName("DWORD")] uint dwStreamIndex, IMFAttributes* pEncodingParameters);
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
        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, IMFAttributes*, int> SetTargetMediaType;
        [NativeTypeName("HRESULT (DWORD, IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFAttributes*, int> PlaceEncodingParameters;
    }
}