// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFSourceReaderCallback.xml' path='doc/member[@name="IMFSourceReaderCallback"]/*'/>
[Guid("DEEC8D99-FA1D-4D82-84C2-2C8969944867")]
[NativeTypeName("struct IMFSourceReaderCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSourceReaderCallback : IMFSourceReaderCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSourceReaderCallback));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSourceReaderCallback*, Guid*, void**, int> )(lpVtbl[0]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSourceReaderCallback*, uint> )(lpVtbl[1]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSourceReaderCallback*, uint> )(lpVtbl[2]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceReaderCallback.xml' path='doc/member[@name="IMFSourceReaderCallback.OnReadSample"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnReadSample(HRESULT hrStatus, [NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwStreamFlags, [NativeTypeName("LONGLONG")] long llTimestamp, IMFSample* pSample)
    {
        return ((delegate* unmanaged<IMFSourceReaderCallback*, HRESULT, uint, uint, long, IMFSample*, int> )(lpVtbl[3]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this), hrStatus, dwStreamIndex, dwStreamFlags, llTimestamp, pSample);
    }

    /// <include file='IMFSourceReaderCallback.xml' path='doc/member[@name="IMFSourceReaderCallback.OnFlush"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnFlush([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSourceReaderCallback*, uint, int> )(lpVtbl[4]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this), dwStreamIndex);
    }

    /// <include file='IMFSourceReaderCallback.xml' path='doc/member[@name="IMFSourceReaderCallback.OnEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnEvent([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaEvent* pEvent)
    {
        return ((delegate* unmanaged<IMFSourceReaderCallback*, uint, IMFMediaEvent*, int> )(lpVtbl[5]))((IMFSourceReaderCallback*)Unsafe.AsPointer(ref this), dwStreamIndex, pEvent);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnReadSample(HRESULT hrStatus, [NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwStreamFlags, [NativeTypeName("LONGLONG")] long llTimestamp, IMFSample* pSample);
        [VtblIndex(4)]
        HRESULT OnFlush([NativeTypeName("DWORD")] uint dwStreamIndex);
        [VtblIndex(5)]
        HRESULT OnEvent([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaEvent* pEvent);
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
        [NativeTypeName("HRESULT (HRESULT, DWORD, DWORD, LONGLONG, IMFSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, uint, uint, long, IMFSample*, int> OnReadSample;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnFlush;
        [NativeTypeName("HRESULT (DWORD, IMFMediaEvent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaEvent*, int> OnEvent;
    }
}