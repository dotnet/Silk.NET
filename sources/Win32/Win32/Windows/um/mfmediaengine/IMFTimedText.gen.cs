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

[Guid("1F2A94C9-A3DF-430D-9D0F-ACD85DDC29AF")]
[NativeTypeName("struct IMFTimedText : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFTimedText : IMFTimedText.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedText));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedText, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFTimedText, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedText, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterNotifications(IMFTimedTextNotify notify)
    {
        return ((delegate* unmanaged<IMFTimedText, IMFTimedTextNotify, int>)((*lpVtbl)[3]))(
            this,
            notify
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SelectTrack([NativeTypeName("DWORD")] uint trackId, BOOL selected)
    {
        return ((delegate* unmanaged<IMFTimedText, uint, BOOL, int>)((*lpVtbl)[4]))(
            this,
            trackId,
            selected
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddDataSource(
        IMFByteStream byteStream,
        [NativeTypeName("LPCWSTR")] ushort* label,
        [NativeTypeName("LPCWSTR")] ushort* language,
        MF_TIMED_TEXT_TRACK_KIND kind,
        BOOL isDefault,
        [NativeTypeName("DWORD *")] uint* trackId
    )
    {
        return (
            (delegate* unmanaged<
                IMFTimedText,
                IMFByteStream,
                ushort*,
                ushort*,
                MF_TIMED_TEXT_TRACK_KIND,
                BOOL,
                uint*,
                int>)((*lpVtbl)[5])
        )(this, byteStream, label, language, kind, isDefault, trackId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddDataSourceFromUrl(
        [NativeTypeName("LPCWSTR")] ushort* url,
        [NativeTypeName("LPCWSTR")] ushort* label,
        [NativeTypeName("LPCWSTR")] ushort* language,
        MF_TIMED_TEXT_TRACK_KIND kind,
        BOOL isDefault,
        [NativeTypeName("DWORD *")] uint* trackId
    )
    {
        return (
            (delegate* unmanaged<
                IMFTimedText,
                ushort*,
                ushort*,
                ushort*,
                MF_TIMED_TEXT_TRACK_KIND,
                BOOL,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, url, label, language, kind, isDefault, trackId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddTrack(
        [NativeTypeName("LPCWSTR")] ushort* label,
        [NativeTypeName("LPCWSTR")] ushort* language,
        MF_TIMED_TEXT_TRACK_KIND kind,
        IMFTimedTextTrack* track
    )
    {
        return (
            (delegate* unmanaged<
                IMFTimedText,
                ushort*,
                ushort*,
                MF_TIMED_TEXT_TRACK_KIND,
                IMFTimedTextTrack*,
                int>)((*lpVtbl)[7])
        )(this, label, language, kind, track);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveTrack(IMFTimedTextTrack track)
    {
        return ((delegate* unmanaged<IMFTimedText, IMFTimedTextTrack, int>)((*lpVtbl)[8]))(
            this,
            track
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCueTimeOffset(double* offset)
    {
        return ((delegate* unmanaged<IMFTimedText, double*, int>)((*lpVtbl)[9]))(this, offset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetCueTimeOffset(double offset)
    {
        return ((delegate* unmanaged<IMFTimedText, double, int>)((*lpVtbl)[10]))(this, offset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetTracks(IMFTimedTextTrackList* tracks)
    {
        return ((delegate* unmanaged<IMFTimedText, IMFTimedTextTrackList*, int>)((*lpVtbl)[11]))(
            this,
            tracks
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetActiveTracks(IMFTimedTextTrackList* activeTracks)
    {
        return ((delegate* unmanaged<IMFTimedText, IMFTimedTextTrackList*, int>)((*lpVtbl)[12]))(
            this,
            activeTracks
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetTextTracks(IMFTimedTextTrackList* textTracks)
    {
        return ((delegate* unmanaged<IMFTimedText, IMFTimedTextTrackList*, int>)((*lpVtbl)[13]))(
            this,
            textTracks
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetMetadataTracks(IMFTimedTextTrackList* metadataTracks)
    {
        return ((delegate* unmanaged<IMFTimedText, IMFTimedTextTrackList*, int>)((*lpVtbl)[14]))(
            this,
            metadataTracks
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetInBandEnabled(BOOL enabled)
    {
        return ((delegate* unmanaged<IMFTimedText, BOOL, int>)((*lpVtbl)[15]))(this, enabled);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public BOOL IsInBandEnabled()
    {
        return ((delegate* unmanaged<IMFTimedText, int>)((*lpVtbl)[16]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterNotifications(IMFTimedTextNotify notify);

        [VtblIndex(4)]
        HRESULT SelectTrack([NativeTypeName("DWORD")] uint trackId, BOOL selected);

        [VtblIndex(5)]
        HRESULT AddDataSource(
            IMFByteStream byteStream,
            [NativeTypeName("LPCWSTR")] ushort* label,
            [NativeTypeName("LPCWSTR")] ushort* language,
            MF_TIMED_TEXT_TRACK_KIND kind,
            BOOL isDefault,
            [NativeTypeName("DWORD *")] uint* trackId
        );

        [VtblIndex(6)]
        HRESULT AddDataSourceFromUrl(
            [NativeTypeName("LPCWSTR")] ushort* url,
            [NativeTypeName("LPCWSTR")] ushort* label,
            [NativeTypeName("LPCWSTR")] ushort* language,
            MF_TIMED_TEXT_TRACK_KIND kind,
            BOOL isDefault,
            [NativeTypeName("DWORD *")] uint* trackId
        );

        [VtblIndex(7)]
        HRESULT AddTrack(
            [NativeTypeName("LPCWSTR")] ushort* label,
            [NativeTypeName("LPCWSTR")] ushort* language,
            MF_TIMED_TEXT_TRACK_KIND kind,
            IMFTimedTextTrack* track
        );

        [VtblIndex(8)]
        HRESULT RemoveTrack(IMFTimedTextTrack track);

        [VtblIndex(9)]
        HRESULT GetCueTimeOffset(double* offset);

        [VtblIndex(10)]
        HRESULT SetCueTimeOffset(double offset);

        [VtblIndex(11)]
        HRESULT GetTracks(IMFTimedTextTrackList* tracks);

        [VtblIndex(12)]
        HRESULT GetActiveTracks(IMFTimedTextTrackList* activeTracks);

        [VtblIndex(13)]
        HRESULT GetTextTracks(IMFTimedTextTrackList* textTracks);

        [VtblIndex(14)]
        HRESULT GetMetadataTracks(IMFTimedTextTrackList* metadataTracks);

        [VtblIndex(15)]
        HRESULT SetInBandEnabled(BOOL enabled);

        [VtblIndex(16)]
        BOOL IsInBandEnabled();
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

        [NativeTypeName("HRESULT (IMFTimedTextNotify *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextNotify, int> RegisterNotifications;

        [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, int> SelectTrack;

        [NativeTypeName(
            "HRESULT (IMFByteStream *, LPCWSTR, LPCWSTR, MF_TIMED_TEXT_TRACK_KIND, BOOL, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFByteStream,
            ushort*,
            ushort*,
            MF_TIMED_TEXT_TRACK_KIND,
            BOOL,
            uint*,
            int> AddDataSource;

        [NativeTypeName(
            "HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, MF_TIMED_TEXT_TRACK_KIND, BOOL, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            MF_TIMED_TEXT_TRACK_KIND,
            BOOL,
            uint*,
            int> AddDataSourceFromUrl;

        [NativeTypeName(
            "HRESULT (LPCWSTR, LPCWSTR, MF_TIMED_TEXT_TRACK_KIND, IMFTimedTextTrack **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            MF_TIMED_TEXT_TRACK_KIND,
            IMFTimedTextTrack*,
            int> AddTrack;

        [NativeTypeName("HRESULT (IMFTimedTextTrack *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextTrack, int> RemoveTrack;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetCueTimeOffset;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetCueTimeOffset;

        [NativeTypeName("HRESULT (IMFTimedTextTrackList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextTrackList*, int> GetTracks;

        [NativeTypeName("HRESULT (IMFTimedTextTrackList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextTrackList*, int> GetActiveTracks;

        [NativeTypeName("HRESULT (IMFTimedTextTrackList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextTrackList*, int> GetTextTracks;

        [NativeTypeName("HRESULT (IMFTimedTextTrackList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextTrackList*, int> GetMetadataTracks;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetInBandEnabled;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsInBandEnabled;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTimedText"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTimedText(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTimedText"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTimedText(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTimedText(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTimedText"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTimedText"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTimedText value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
