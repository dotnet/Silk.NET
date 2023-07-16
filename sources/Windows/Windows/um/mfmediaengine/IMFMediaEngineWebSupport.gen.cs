// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFMediaEngineWebSupport.xml' path='doc/member[@name="IMFMediaEngineWebSupport"]/*'/>
[Guid("BA2743A1-07E0-48EF-84B6-9A2ED023CA6C")]
[NativeTypeName("struct IMFMediaEngineWebSupport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaEngineWebSupport : IMFMediaEngineWebSupport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineWebSupport));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineWebSupport*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaEngineWebSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineWebSupport*, uint> )(lpVtbl[1]))((IMFMediaEngineWebSupport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineWebSupport*, uint> )(lpVtbl[2]))((IMFMediaEngineWebSupport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineWebSupport.xml' path='doc/member[@name="IMFMediaEngineWebSupport.ShouldDelayTheLoadEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL ShouldDelayTheLoadEvent()
    {
        return ((delegate* unmanaged<IMFMediaEngineWebSupport*, int> )(lpVtbl[3]))((IMFMediaEngineWebSupport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineWebSupport.xml' path='doc/member[@name="IMFMediaEngineWebSupport.ConnectWebAudio"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ConnectWebAudio([NativeTypeName("DWORD")] uint dwSampleRate, IAudioSourceProvider** ppSourceProvider)
    {
        return ((delegate* unmanaged<IMFMediaEngineWebSupport*, uint, IAudioSourceProvider**, int> )(lpVtbl[4]))((IMFMediaEngineWebSupport*)Unsafe.AsPointer(ref this), dwSampleRate, ppSourceProvider);
    }

    /// <include file='IMFMediaEngineWebSupport.xml' path='doc/member[@name="IMFMediaEngineWebSupport.DisconnectWebAudio"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DisconnectWebAudio()
    {
        return ((delegate* unmanaged<IMFMediaEngineWebSupport*, int> )(lpVtbl[5]))((IMFMediaEngineWebSupport*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        BOOL ShouldDelayTheLoadEvent();
        [VtblIndex(4)]
        HRESULT ConnectWebAudio([NativeTypeName("DWORD")] uint dwSampleRate, IAudioSourceProvider** ppSourceProvider);
        [VtblIndex(5)]
        HRESULT DisconnectWebAudio();
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
        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ShouldDelayTheLoadEvent;
        [NativeTypeName("HRESULT (DWORD, IAudioSourceProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IAudioSourceProvider**, int> ConnectWebAudio;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DisconnectWebAudio;
    }
}