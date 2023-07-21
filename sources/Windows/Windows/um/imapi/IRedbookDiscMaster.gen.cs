// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IRedbookDiscMaster.xml' path='doc/member[@name="IRedbookDiscMaster"]/*' />
[Guid("E3BC42CD-4E5C-11D3-9144-00104BA11C5E")]
[NativeTypeName("struct IRedbookDiscMaster : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRedbookDiscMaster : IRedbookDiscMaster.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRedbookDiscMaster));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster*, Guid*, void**, int>)(lpVtbl[0]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRedbookDiscMaster*, uint>)(lpVtbl[1]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRedbookDiscMaster*, uint>)(lpVtbl[2]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRedbookDiscMaster.xml' path='doc/member[@name="IRedbookDiscMaster.GetTotalAudioTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTotalAudioTracks([NativeTypeName("long *")] int* pnTracks)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster*, int*, int>)(lpVtbl[3]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), pnTracks);
    }

    /// <include file='IRedbookDiscMaster.xml' path='doc/member[@name="IRedbookDiscMaster.GetTotalAudioBlocks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTotalAudioBlocks([NativeTypeName("long *")] int* pnBlocks)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster*, int*, int>)(lpVtbl[4]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), pnBlocks);
    }

    /// <include file='IRedbookDiscMaster.xml' path='doc/member[@name="IRedbookDiscMaster.GetUsedAudioBlocks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetUsedAudioBlocks([NativeTypeName("long *")] int* pnBlocks)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster*, int*, int>)(lpVtbl[5]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), pnBlocks);
    }

    /// <include file='IRedbookDiscMaster.xml' path='doc/member[@name="IRedbookDiscMaster.GetAvailableAudioTrackBlocks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAvailableAudioTrackBlocks([NativeTypeName("long *")] int* pnBlocks)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster*, int*, int>)(lpVtbl[6]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), pnBlocks);
    }

    /// <include file='IRedbookDiscMaster.xml' path='doc/member[@name="IRedbookDiscMaster.GetAudioBlockSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAudioBlockSize([NativeTypeName("long *")] int* pnBlockBytes)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster*, int*, int>)(lpVtbl[7]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), pnBlockBytes);
    }

    /// <include file='IRedbookDiscMaster.xml' path='doc/member[@name="IRedbookDiscMaster.CreateAudioTrack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateAudioTrack([NativeTypeName("long")] int nBlocks)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster*, int, int>)(lpVtbl[8]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), nBlocks);
    }

    /// <include file='IRedbookDiscMaster.xml' path='doc/member[@name="IRedbookDiscMaster.AddAudioTrackBlocks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddAudioTrackBlocks(byte* pby, [NativeTypeName("long")] int cb)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster*, byte*, int, int>)(lpVtbl[9]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), pby, cb);
    }

    /// <include file='IRedbookDiscMaster.xml' path='doc/member[@name="IRedbookDiscMaster.CloseAudioTrack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CloseAudioTrack()
    {
        return ((delegate* unmanaged<IRedbookDiscMaster*, int>)(lpVtbl[10]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTotalAudioTracks([NativeTypeName("long *")] int* pnTracks);

        [VtblIndex(4)]
        HRESULT GetTotalAudioBlocks([NativeTypeName("long *")] int* pnBlocks);

        [VtblIndex(5)]
        HRESULT GetUsedAudioBlocks([NativeTypeName("long *")] int* pnBlocks);

        [VtblIndex(6)]
        HRESULT GetAvailableAudioTrackBlocks([NativeTypeName("long *")] int* pnBlocks);

        [VtblIndex(7)]
        HRESULT GetAudioBlockSize([NativeTypeName("long *")] int* pnBlockBytes);

        [VtblIndex(8)]
        HRESULT CreateAudioTrack([NativeTypeName("long")] int nBlocks);

        [VtblIndex(9)]
        HRESULT AddAudioTrackBlocks(byte* pby, [NativeTypeName("long")] int cb);

        [VtblIndex(10)]
        HRESULT CloseAudioTrack();
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetTotalAudioTracks;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetTotalAudioBlocks;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetUsedAudioBlocks;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetAvailableAudioTrackBlocks;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetAudioBlockSize;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> CreateAudioTrack;

        [NativeTypeName("HRESULT (byte *, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int, int> AddAudioTrackBlocks;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CloseAudioTrack;
    }
}
