// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFCaptureSink2.xml' path='doc/member[@name="IMFCaptureSink2"]/*'/>
[Guid("F9E4219E-6197-4B5E-B888-BEE310AB2C59")]
[NativeTypeName("struct IMFCaptureSink2 : IMFCaptureSink")]
[NativeInheritance("IMFCaptureSink")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFCaptureSink2 : IMFCaptureSink2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCaptureSink2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCaptureSink2*, Guid*, void**, int> )(lpVtbl[0]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCaptureSink2*, uint> )(lpVtbl[1]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCaptureSink2*, uint> )(lpVtbl[2]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFCaptureSink.GetOutputMediaType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOutputMediaType([NativeTypeName("DWORD")] uint dwSinkStreamIndex, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFCaptureSink2*, uint, IMFMediaType**, int> )(lpVtbl[3]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, ppMediaType);
    }

    /// <inheritdoc cref = "IMFCaptureSink.GetService"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetService([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppUnknown)
    {
        return ((delegate* unmanaged<IMFCaptureSink2*, uint, Guid*, Guid*, IUnknown**, int> )(lpVtbl[4]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, rguidService, riid, ppUnknown);
    }

    /// <inheritdoc cref = "IMFCaptureSink.AddStream"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddStream([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType* pMediaType, IMFAttributes* pAttributes, [NativeTypeName("DWORD *")] uint* pdwSinkStreamIndex)
    {
        return ((delegate* unmanaged<IMFCaptureSink2*, uint, IMFMediaType*, IMFAttributes*, uint*, int> )(lpVtbl[5]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType, pAttributes, pdwSinkStreamIndex);
    }

    /// <inheritdoc cref = "IMFCaptureSink.Prepare"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Prepare()
    {
        return ((delegate* unmanaged<IMFCaptureSink2*, int> )(lpVtbl[6]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFCaptureSink.RemoveAllStreams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveAllStreams()
    {
        return ((delegate* unmanaged<IMFCaptureSink2*, int> )(lpVtbl[7]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCaptureSink2.xml' path='doc/member[@name="IMFCaptureSink2.SetOutputMediaType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetOutputMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType* pMediaType, IMFAttributes* pEncodingAttributes)
    {
        return ((delegate* unmanaged<IMFCaptureSink2*, uint, IMFMediaType*, IMFAttributes*, int> )(lpVtbl[8]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this), dwStreamIndex, pMediaType, pEncodingAttributes);
    }

    public interface Interface : IMFCaptureSink.Interface
    {
        [VtblIndex(8)]
        HRESULT SetOutputMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType* pMediaType, IMFAttributes* pEncodingAttributes);
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
        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType**, int> GetOutputMediaType;
        [NativeTypeName("HRESULT (DWORD, const GUID &, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, IUnknown**, int> GetService;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, IMFAttributes *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, IMFAttributes*, uint*, int> AddStream;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Prepare;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllStreams;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, IMFAttributes*, int> SetOutputMediaType;
    }
}