// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFMuxStreamSampleManager.xml' path='doc/member[@name="IMFMuxStreamSampleManager"]/*'/>
[Guid("74ABBC19-B1CC-4E41-BB8B-9D9B86A8F6CA")]
[NativeTypeName("struct IMFMuxStreamSampleManager : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFMuxStreamSampleManager : IMFMuxStreamSampleManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMuxStreamSampleManager));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMuxStreamSampleManager*, Guid*, void**, int> )(lpVtbl[0]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMuxStreamSampleManager*, uint> )(lpVtbl[1]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMuxStreamSampleManager*, uint> )(lpVtbl[2]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMuxStreamSampleManager.xml' path='doc/member[@name="IMFMuxStreamSampleManager.GetStreamCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount)
    {
        return ((delegate* unmanaged<IMFMuxStreamSampleManager*, uint*, int> )(lpVtbl[3]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this), pdwMuxStreamCount);
    }

    /// <include file='IMFMuxStreamSampleManager.xml' path='doc/member[@name="IMFMuxStreamSampleManager.GetSample"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSample([NativeTypeName("DWORD")] uint dwMuxStreamIndex, IMFSample** ppSample)
    {
        return ((delegate* unmanaged<IMFMuxStreamSampleManager*, uint, IMFSample**, int> )(lpVtbl[4]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this), dwMuxStreamIndex, ppSample);
    }

    /// <include file='IMFMuxStreamSampleManager.xml' path='doc/member[@name="IMFMuxStreamSampleManager.GetStreamConfiguration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("ULONGLONG")]
    public ulong GetStreamConfiguration()
    {
        return ((delegate* unmanaged<IMFMuxStreamSampleManager*, ulong> )(lpVtbl[5]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount);
        [VtblIndex(4)]
        HRESULT GetSample([NativeTypeName("DWORD")] uint dwMuxStreamIndex, IMFSample** ppSample);
        [VtblIndex(5)]
        [return: NativeTypeName("ULONGLONG")]
        ulong GetStreamConfiguration();
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
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetStreamCount;
        [NativeTypeName("HRESULT (DWORD, IMFSample **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFSample**, int> GetSample;
        [NativeTypeName("ULONGLONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetStreamConfiguration;
    }
}