// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFVideoCaptureSampleAllocator.xml' path='doc/member[@name="IMFVideoCaptureSampleAllocator"]/*'/>
[Guid("725B77C7-CA9F-4FE5-9D72-9946BF9B3C70")]
[NativeTypeName("struct IMFVideoCaptureSampleAllocator : IMFVideoSampleAllocator")]
[NativeInheritance("IMFVideoSampleAllocator")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IMFVideoCaptureSampleAllocator : IMFVideoCaptureSampleAllocator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFVideoCaptureSampleAllocator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFVideoCaptureSampleAllocator*, Guid*, void**, int> )(lpVtbl[0]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFVideoCaptureSampleAllocator*, uint> )(lpVtbl[1]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoCaptureSampleAllocator*, uint> )(lpVtbl[2]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFVideoSampleAllocator.SetDirectXManager"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDirectXManager(IUnknown* pManager)
    {
        return ((delegate* unmanaged<IMFVideoCaptureSampleAllocator*, IUnknown*, int> )(lpVtbl[3]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this), pManager);
    }

    /// <inheritdoc cref = "IMFVideoSampleAllocator.UninitializeSampleAllocator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UninitializeSampleAllocator()
    {
        return ((delegate* unmanaged<IMFVideoCaptureSampleAllocator*, int> )(lpVtbl[4]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFVideoSampleAllocator.InitializeSampleAllocator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InitializeSampleAllocator([NativeTypeName("DWORD")] uint cRequestedFrames, IMFMediaType* pMediaType)
    {
        return ((delegate* unmanaged<IMFVideoCaptureSampleAllocator*, uint, IMFMediaType*, int> )(lpVtbl[5]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this), cRequestedFrames, pMediaType);
    }

    /// <inheritdoc cref = "IMFVideoSampleAllocator.AllocateSample"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AllocateSample(IMFSample** ppSample)
    {
        return ((delegate* unmanaged<IMFVideoCaptureSampleAllocator*, IMFSample**, int> )(lpVtbl[6]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this), ppSample);
    }

    /// <include file='IMFVideoCaptureSampleAllocator.xml' path='doc/member[@name="IMFVideoCaptureSampleAllocator.InitializeCaptureSampleAllocator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InitializeCaptureSampleAllocator([NativeTypeName("DWORD")] uint cbSampleSize, [NativeTypeName("DWORD")] uint cbCaptureMetadataSize, [NativeTypeName("DWORD")] uint cbAlignment, [NativeTypeName("DWORD")] uint cMinimumSamples, IMFAttributes* pAttributes, IMFMediaType* pMediaType)
    {
        return ((delegate* unmanaged<IMFVideoCaptureSampleAllocator*, uint, uint, uint, uint, IMFAttributes*, IMFMediaType*, int> )(lpVtbl[7]))((IMFVideoCaptureSampleAllocator*)Unsafe.AsPointer(ref this), cbSampleSize, cbCaptureMetadataSize, cbAlignment, cMinimumSamples, pAttributes, pMediaType);
    }

    public interface Interface : IMFVideoSampleAllocator.Interface
    {
        [VtblIndex(7)]
        HRESULT InitializeCaptureSampleAllocator([NativeTypeName("DWORD")] uint cbSampleSize, [NativeTypeName("DWORD")] uint cbCaptureMetadataSize, [NativeTypeName("DWORD")] uint cbAlignment, [NativeTypeName("DWORD")] uint cMinimumSamples, IMFAttributes* pAttributes, IMFMediaType* pMediaType);
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
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetDirectXManager;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UninitializeSampleAllocator;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, int> InitializeSampleAllocator;
        [NativeTypeName("HRESULT (IMFSample **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSample**, int> AllocateSample;
        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, DWORD, IMFAttributes *, IMFMediaType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, uint, IMFAttributes*, IMFMediaType*, int> InitializeCaptureSampleAllocator;
    }
}