// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E3BC42CD-4E5C-11D3-9144-00104BA11C5E")]
[NativeTypeName("struct IRedbookDiscMaster : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRedbookDiscMaster : IRedbookDiscMaster.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRedbookDiscMaster));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRedbookDiscMaster, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRedbookDiscMaster, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTotalAudioTracks([NativeTypeName("long *")] int* pnTracks)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster, int*, int>)((*lpVtbl)[3]))(this, pnTracks);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTotalAudioBlocks([NativeTypeName("long *")] int* pnBlocks)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster, int*, int>)((*lpVtbl)[4]))(this, pnBlocks);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetUsedAudioBlocks([NativeTypeName("long *")] int* pnBlocks)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster, int*, int>)((*lpVtbl)[5]))(this, pnBlocks);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAvailableAudioTrackBlocks([NativeTypeName("long *")] int* pnBlocks)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster, int*, int>)((*lpVtbl)[6]))(this, pnBlocks);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAudioBlockSize([NativeTypeName("long *")] int* pnBlockBytes)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster, int*, int>)((*lpVtbl)[7]))(
            this,
            pnBlockBytes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateAudioTrack([NativeTypeName("long")] int nBlocks)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster, int, int>)((*lpVtbl)[8]))(this, nBlocks);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddAudioTrackBlocks(byte* pby, [NativeTypeName("long")] int cb)
    {
        return ((delegate* unmanaged<IRedbookDiscMaster, byte*, int, int>)((*lpVtbl)[9]))(
            this,
            pby,
            cb
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CloseAudioTrack()
    {
        return ((delegate* unmanaged<IRedbookDiscMaster, int>)((*lpVtbl)[10]))(this);
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

    /// <summary>Initializes a new instance of the <see cref = "IRedbookDiscMaster"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRedbookDiscMaster(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRedbookDiscMaster"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRedbookDiscMaster(Silk.NET.Windows.IUnknown value)
    {
        return new IRedbookDiscMaster(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRedbookDiscMaster"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRedbookDiscMaster"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRedbookDiscMaster value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
