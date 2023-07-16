// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFVideoSampleAllocatorEx.xml' path='doc/member[@name="IMFVideoSampleAllocatorEx"]/*'/>
[Guid("545B3A48-3283-4F62-866F-A62D8F598F9F")]
[NativeTypeName("struct IMFVideoSampleAllocatorEx : IMFVideoSampleAllocator")]
[NativeInheritance("IMFVideoSampleAllocator")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFVideoSampleAllocatorEx : IMFVideoSampleAllocatorEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFVideoSampleAllocatorEx));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, Guid*, void**, int> )(lpVtbl[0]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, uint> )(lpVtbl[1]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, uint> )(lpVtbl[2]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFVideoSampleAllocator.SetDirectXManager"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDirectXManager(IUnknown* pManager)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, IUnknown*, int> )(lpVtbl[3]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), pManager);
    }

    /// <inheritdoc cref = "IMFVideoSampleAllocator.UninitializeSampleAllocator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UninitializeSampleAllocator()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, int> )(lpVtbl[4]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFVideoSampleAllocator.InitializeSampleAllocator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InitializeSampleAllocator([NativeTypeName("DWORD")] uint cRequestedFrames, IMFMediaType* pMediaType)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, uint, IMFMediaType*, int> )(lpVtbl[5]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), cRequestedFrames, pMediaType);
    }

    /// <inheritdoc cref = "IMFVideoSampleAllocator.AllocateSample"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AllocateSample(IMFSample** ppSample)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, IMFSample**, int> )(lpVtbl[6]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), ppSample);
    }

    /// <include file='IMFVideoSampleAllocatorEx.xml' path='doc/member[@name="IMFVideoSampleAllocatorEx.InitializeSampleAllocatorEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InitializeSampleAllocatorEx([NativeTypeName("DWORD")] uint cInitialSamples, [NativeTypeName("DWORD")] uint cMaximumSamples, IMFAttributes* pAttributes, IMFMediaType* pMediaType)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, uint, uint, IMFAttributes*, IMFMediaType*, int> )(lpVtbl[7]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), cInitialSamples, cMaximumSamples, pAttributes, pMediaType);
    }

    public interface Interface : IMFVideoSampleAllocator.Interface
    {
        [VtblIndex(7)]
        HRESULT InitializeSampleAllocatorEx([NativeTypeName("DWORD")] uint cInitialSamples, [NativeTypeName("DWORD")] uint cMaximumSamples, IMFAttributes* pAttributes, IMFMediaType* pMediaType);
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
        [NativeTypeName("HRESULT (DWORD, DWORD, IMFAttributes *, IMFMediaType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IMFAttributes*, IMFMediaType*, int> InitializeSampleAllocatorEx;
    }
}