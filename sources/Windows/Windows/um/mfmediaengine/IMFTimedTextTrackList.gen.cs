// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFTimedTextTrackList.xml' path='doc/member[@name="IMFTimedTextTrackList"]/*'/>
[Guid("23FF334C-442C-445F-BCCC-EDC438AA11E2")]
[NativeTypeName("struct IMFTimedTextTrackList : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFTimedTextTrackList : IMFTimedTextTrackList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextTrackList));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextTrackList*, Guid*, void**, int> )(lpVtbl[0]))((IMFTimedTextTrackList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTimedTextTrackList*, uint> )(lpVtbl[1]))((IMFTimedTextTrackList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextTrackList*, uint> )(lpVtbl[2]))((IMFTimedTextTrackList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextTrackList.xml' path='doc/member[@name="IMFTimedTextTrackList.GetLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint GetLength()
    {
        return ((delegate* unmanaged<IMFTimedTextTrackList*, uint> )(lpVtbl[3]))((IMFTimedTextTrackList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextTrackList.xml' path='doc/member[@name="IMFTimedTextTrackList.GetTrack"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTrack([NativeTypeName("DWORD")] uint index, IMFTimedTextTrack** track)
    {
        return ((delegate* unmanaged<IMFTimedTextTrackList*, uint, IMFTimedTextTrack**, int> )(lpVtbl[4]))((IMFTimedTextTrackList*)Unsafe.AsPointer(ref this), index, track);
    }

    /// <include file='IMFTimedTextTrackList.xml' path='doc/member[@name="IMFTimedTextTrackList.GetTrackById"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrackById([NativeTypeName("DWORD")] uint trackId, IMFTimedTextTrack** track)
    {
        return ((delegate* unmanaged<IMFTimedTextTrackList*, uint, IMFTimedTextTrack**, int> )(lpVtbl[5]))((IMFTimedTextTrackList*)Unsafe.AsPointer(ref this), trackId, track);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint GetLength();
        [VtblIndex(4)]
        HRESULT GetTrack([NativeTypeName("DWORD")] uint index, IMFTimedTextTrack** track);
        [VtblIndex(5)]
        HRESULT GetTrackById([NativeTypeName("DWORD")] uint trackId, IMFTimedTextTrack** track);
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
        public delegate* unmanaged<TSelf*, uint, IMFTimedTextTrack**, int> GetTrack;
        [NativeTypeName("HRESULT (DWORD, IMFTimedTextTrack **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFTimedTextTrack**, int> GetTrackById;
    }
}