// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C8ADBD64-E71E-48A0-A4DE-185C395CD317")]
[NativeTypeName("struct IAudioCaptureClient : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioCaptureClient : IAudioCaptureClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioCaptureClient));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioCaptureClient, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioCaptureClient, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioCaptureClient, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(
        byte** ppData,
        [NativeTypeName("UINT32 *")] uint* pNumFramesToRead,
        [NativeTypeName("DWORD *")] uint* pdwFlags,
        [NativeTypeName("UINT64 *")] ulong* pu64DevicePosition,
        [NativeTypeName("UINT64 *")] ulong* pu64QPCPosition
    )
    {
        return (
            (delegate* unmanaged<IAudioCaptureClient, byte**, uint*, uint*, ulong*, ulong*, int>)(
                (*lpVtbl)[3]
            )
        )(this, ppData, pNumFramesToRead, pdwFlags, pu64DevicePosition, pu64QPCPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReleaseBuffer([NativeTypeName("UINT32")] uint NumFramesRead)
    {
        return ((delegate* unmanaged<IAudioCaptureClient, uint, int>)((*lpVtbl)[4]))(
            this,
            NumFramesRead
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetNextPacketSize([NativeTypeName("UINT32 *")] uint* pNumFramesInNextPacket)
    {
        return ((delegate* unmanaged<IAudioCaptureClient, uint*, int>)((*lpVtbl)[5]))(
            this,
            pNumFramesInNextPacket
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBuffer(
            byte** ppData,
            [NativeTypeName("UINT32 *")] uint* pNumFramesToRead,
            [NativeTypeName("DWORD *")] uint* pdwFlags,
            [NativeTypeName("UINT64 *")] ulong* pu64DevicePosition,
            [NativeTypeName("UINT64 *")] ulong* pu64QPCPosition
        );

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

        [NativeTypeName(
            "HRESULT (BYTE **, UINT32 *, DWORD *, UINT64 *, UINT64 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte**, uint*, uint*, ulong*, ulong*, int> GetBuffer;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> ReleaseBuffer;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNextPacketSize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioCaptureClient"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioCaptureClient(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioCaptureClient"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioCaptureClient(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioCaptureClient(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioCaptureClient"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioCaptureClient"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioCaptureClient value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
