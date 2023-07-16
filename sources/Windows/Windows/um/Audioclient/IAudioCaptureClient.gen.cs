// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAudioCaptureClient.xml' path='doc/member[@name="IAudioCaptureClient"]/*'/>
[Guid("C8ADBD64-E71E-48A0-A4DE-185C395CD317")]
[NativeTypeName("struct IAudioCaptureClient : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioCaptureClient : IAudioCaptureClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioCaptureClient));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioCaptureClient*, Guid*, void**, int> )(lpVtbl[0]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioCaptureClient*, uint> )(lpVtbl[1]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioCaptureClient*, uint> )(lpVtbl[2]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioCaptureClient.xml' path='doc/member[@name="IAudioCaptureClient.GetBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(byte** ppData, [NativeTypeName("UINT32 *")] uint* pNumFramesToRead, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("UINT64 *")] ulong* pu64DevicePosition, [NativeTypeName("UINT64 *")] ulong* pu64QPCPosition)
    {
        return ((delegate* unmanaged<IAudioCaptureClient*, byte**, uint*, uint*, ulong*, ulong*, int> )(lpVtbl[3]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this), ppData, pNumFramesToRead, pdwFlags, pu64DevicePosition, pu64QPCPosition);
    }

    /// <include file='IAudioCaptureClient.xml' path='doc/member[@name="IAudioCaptureClient.ReleaseBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReleaseBuffer([NativeTypeName("UINT32")] uint NumFramesRead)
    {
        return ((delegate* unmanaged<IAudioCaptureClient*, uint, int> )(lpVtbl[4]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this), NumFramesRead);
    }

    /// <include file='IAudioCaptureClient.xml' path='doc/member[@name="IAudioCaptureClient.GetNextPacketSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetNextPacketSize([NativeTypeName("UINT32 *")] uint* pNumFramesInNextPacket)
    {
        return ((delegate* unmanaged<IAudioCaptureClient*, uint*, int> )(lpVtbl[5]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this), pNumFramesInNextPacket);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBuffer(byte** ppData, [NativeTypeName("UINT32 *")] uint* pNumFramesToRead, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("UINT64 *")] ulong* pu64DevicePosition, [NativeTypeName("UINT64 *")] ulong* pu64QPCPosition);
        [VtblIndex(4)]
        HRESULT ReleaseBuffer([NativeTypeName("UINT32")] uint NumFramesRead);
        [VtblIndex(5)]
        HRESULT GetNextPacketSize([NativeTypeName("UINT32 *")] uint* pNumFramesInNextPacket);
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
        [NativeTypeName("HRESULT (BYTE **, UINT32 *, DWORD *, UINT64 *, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, uint*, ulong*, ulong*, int> GetBuffer;
        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> ReleaseBuffer;
        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNextPacketSize;
    }
}