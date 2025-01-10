// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("23FF334C-442C-445F-BCCC-EDC438AA11E2")]
[NativeTypeName("struct IMFTimedTextTrackList : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFTimedTextTrackList : IMFTimedTextTrackList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextTrackList));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextTrackList, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFTimedTextTrackList, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextTrackList, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint GetLength()
    {
        return ((delegate* unmanaged<IMFTimedTextTrackList, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTrack([NativeTypeName("DWORD")] uint index, IMFTimedTextTrack* track)
    {
        return (
            (delegate* unmanaged<IMFTimedTextTrackList, uint, IMFTimedTextTrack*, int>)(
                (*lpVtbl)[4]
            )
        )(this, index, track);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrackById([NativeTypeName("DWORD")] uint trackId, IMFTimedTextTrack* track)
    {
        return (
            (delegate* unmanaged<IMFTimedTextTrackList, uint, IMFTimedTextTrack*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trackId, track);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint GetLength();

        [VtblIndex(4)]
        HRESULT GetTrack([NativeTypeName("DWORD")] uint index, IMFTimedTextTrack* track);

        [VtblIndex(5)]
        HRESULT GetTrackById([NativeTypeName("DWORD")] uint trackId, IMFTimedTextTrack* track);
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

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetLength;

        [NativeTypeName("HRESULT (DWORD, IMFTimedTextTrack **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFTimedTextTrack*, int> GetTrack;

        [NativeTypeName("HRESULT (DWORD, IMFTimedTextTrack **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFTimedTextTrack*, int> GetTrackById;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTimedTextTrackList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTimedTextTrackList(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTimedTextTrackList"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTimedTextTrackList(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTimedTextTrackList(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTimedTextTrackList"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTimedTextTrackList"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTimedTextTrackList value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
