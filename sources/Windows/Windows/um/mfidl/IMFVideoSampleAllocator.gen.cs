// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFVideoSampleAllocator.xml' path='doc/member[@name="IMFVideoSampleAllocator"]/*'/>
[Guid("86CBC910-E533-4751-8E3B-F19B5B806A03")]
[NativeTypeName("struct IMFVideoSampleAllocator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFVideoSampleAllocator : IMFVideoSampleAllocator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFVideoSampleAllocator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocator*, Guid*, void**, int> )(lpVtbl[0]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocator*, uint> )(lpVtbl[1]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocator*, uint> )(lpVtbl[2]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFVideoSampleAllocator.xml' path='doc/member[@name="IMFVideoSampleAllocator.SetDirectXManager"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDirectXManager(IUnknown* pManager)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocator*, IUnknown*, int> )(lpVtbl[3]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this), pManager);
    }

    /// <include file='IMFVideoSampleAllocator.xml' path='doc/member[@name="IMFVideoSampleAllocator.UninitializeSampleAllocator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UninitializeSampleAllocator()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocator*, int> )(lpVtbl[4]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFVideoSampleAllocator.xml' path='doc/member[@name="IMFVideoSampleAllocator.InitializeSampleAllocator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InitializeSampleAllocator([NativeTypeName("DWORD")] uint cRequestedFrames, IMFMediaType* pMediaType)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocator*, uint, IMFMediaType*, int> )(lpVtbl[5]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this), cRequestedFrames, pMediaType);
    }

    /// <include file='IMFVideoSampleAllocator.xml' path='doc/member[@name="IMFVideoSampleAllocator.AllocateSample"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AllocateSample(IMFSample** ppSample)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocator*, IMFSample**, int> )(lpVtbl[6]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this), ppSample);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDirectXManager(IUnknown* pManager);
        [VtblIndex(4)]
        HRESULT UninitializeSampleAllocator();
        [VtblIndex(5)]
        HRESULT InitializeSampleAllocator([NativeTypeName("DWORD")] uint cRequestedFrames, IMFMediaType* pMediaType);
        [VtblIndex(6)]
        HRESULT AllocateSample(IMFSample** ppSample);
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
    }
}