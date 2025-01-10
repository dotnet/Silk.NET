// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("33BC7430-EEC0-11D2-8201-00A0C9D74842")]
[NativeTypeName("struct IDvdControl2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDvdControl2 : IDvdControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDvdControl2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDvdControl2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDvdControl2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDvdControl2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT PlayTitle(
        [NativeTypeName("ULONG")] uint ulTitle,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return ((delegate* unmanaged<IDvdControl2, uint, uint, IDvdCmd*, int>)((*lpVtbl)[3]))(
            this,
            ulTitle,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PlayChapterInTitle(
        [NativeTypeName("ULONG")] uint ulTitle,
        [NativeTypeName("ULONG")] uint ulChapter,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return ((delegate* unmanaged<IDvdControl2, uint, uint, uint, IDvdCmd*, int>)((*lpVtbl)[4]))(
            this,
            ulTitle,
            ulChapter,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT PlayAtTimeInTitle(
        [NativeTypeName("ULONG")] uint ulTitle,
        DVD_HMSF_TIMECODE* pStartTime,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return (
            (delegate* unmanaged<IDvdControl2, uint, DVD_HMSF_TIMECODE*, uint, IDvdCmd*, int>)(
                (*lpVtbl)[5]
            )
        )(this, ulTitle, pStartTime, dwFlags, ppCmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IDvdControl2, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReturnFromSubmenu([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd* ppCmd)
    {
        return ((delegate* unmanaged<IDvdControl2, uint, IDvdCmd*, int>)((*lpVtbl)[7]))(
            this,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PlayAtTime(
        DVD_HMSF_TIMECODE* pTime,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return (
            (delegate* unmanaged<IDvdControl2, DVD_HMSF_TIMECODE*, uint, IDvdCmd*, int>)(
                (*lpVtbl)[8]
            )
        )(this, pTime, dwFlags, ppCmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PlayChapter(
        [NativeTypeName("ULONG")] uint ulChapter,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return ((delegate* unmanaged<IDvdControl2, uint, uint, IDvdCmd*, int>)((*lpVtbl)[9]))(
            this,
            ulChapter,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT PlayPrevChapter([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd* ppCmd)
    {
        return ((delegate* unmanaged<IDvdControl2, uint, IDvdCmd*, int>)((*lpVtbl)[10]))(
            this,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ReplayChapter([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd* ppCmd)
    {
        return ((delegate* unmanaged<IDvdControl2, uint, IDvdCmd*, int>)((*lpVtbl)[11]))(
            this,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PlayNextChapter([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd* ppCmd)
    {
        return ((delegate* unmanaged<IDvdControl2, uint, IDvdCmd*, int>)((*lpVtbl)[12]))(
            this,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT PlayForwards(
        double dSpeed,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return ((delegate* unmanaged<IDvdControl2, double, uint, IDvdCmd*, int>)((*lpVtbl)[13]))(
            this,
            dSpeed,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT PlayBackwards(
        double dSpeed,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return ((delegate* unmanaged<IDvdControl2, double, uint, IDvdCmd*, int>)((*lpVtbl)[14]))(
            this,
            dSpeed,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ShowMenu(
        DVD_MENU_ID MenuID,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return (
            (delegate* unmanaged<IDvdControl2, DVD_MENU_ID, uint, IDvdCmd*, int>)((*lpVtbl)[15])
        )(this, MenuID, dwFlags, ppCmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Resume([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd* ppCmd)
    {
        return ((delegate* unmanaged<IDvdControl2, uint, IDvdCmd*, int>)((*lpVtbl)[16]))(
            this,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SelectRelativeButton(DVD_RELATIVE_BUTTON buttonDir)
    {
        return ((delegate* unmanaged<IDvdControl2, DVD_RELATIVE_BUTTON, int>)((*lpVtbl)[17]))(
            this,
            buttonDir
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ActivateButton()
    {
        return ((delegate* unmanaged<IDvdControl2, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SelectButton([NativeTypeName("ULONG")] uint ulButton)
    {
        return ((delegate* unmanaged<IDvdControl2, uint, int>)((*lpVtbl)[19]))(this, ulButton);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SelectAndActivateButton([NativeTypeName("ULONG")] uint ulButton)
    {
        return ((delegate* unmanaged<IDvdControl2, uint, int>)((*lpVtbl)[20]))(this, ulButton);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT StillOff()
    {
        return ((delegate* unmanaged<IDvdControl2, int>)((*lpVtbl)[21]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT Pause(BOOL bState)
    {
        return ((delegate* unmanaged<IDvdControl2, BOOL, int>)((*lpVtbl)[22]))(this, bState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SelectAudioStream(
        [NativeTypeName("ULONG")] uint ulAudio,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return ((delegate* unmanaged<IDvdControl2, uint, uint, IDvdCmd*, int>)((*lpVtbl)[23]))(
            this,
            ulAudio,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SelectSubpictureStream(
        [NativeTypeName("ULONG")] uint ulSubPicture,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return ((delegate* unmanaged<IDvdControl2, uint, uint, IDvdCmd*, int>)((*lpVtbl)[24]))(
            this,
            ulSubPicture,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetSubpictureState(
        BOOL bState,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return ((delegate* unmanaged<IDvdControl2, BOOL, uint, IDvdCmd*, int>)((*lpVtbl)[25]))(
            this,
            bState,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SelectAngle(
        [NativeTypeName("ULONG")] uint ulAngle,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return ((delegate* unmanaged<IDvdControl2, uint, uint, IDvdCmd*, int>)((*lpVtbl)[26]))(
            this,
            ulAngle,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SelectParentalLevel([NativeTypeName("ULONG")] uint ulParentalLevel)
    {
        return ((delegate* unmanaged<IDvdControl2, uint, int>)((*lpVtbl)[27]))(
            this,
            ulParentalLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SelectParentalCountry([NativeTypeName("BYTE[2]")] byte* bCountry)
    {
        return ((delegate* unmanaged<IDvdControl2, byte*, int>)((*lpVtbl)[28]))(this, bCountry);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SelectKaraokeAudioPresentationMode([NativeTypeName("ULONG")] uint ulMode)
    {
        return ((delegate* unmanaged<IDvdControl2, uint, int>)((*lpVtbl)[29]))(this, ulMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SelectVideoModePreference([NativeTypeName("ULONG")] uint ulPreferredDisplayMode)
    {
        return ((delegate* unmanaged<IDvdControl2, uint, int>)((*lpVtbl)[30]))(
            this,
            ulPreferredDisplayMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetDVDDirectory([NativeTypeName("LPCWSTR")] ushort* pszwPath)
    {
        return ((delegate* unmanaged<IDvdControl2, ushort*, int>)((*lpVtbl)[31]))(this, pszwPath);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT ActivateAtPosition(POINT point)
    {
        return ((delegate* unmanaged<IDvdControl2, POINT, int>)((*lpVtbl)[32]))(this, point);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SelectAtPosition(POINT point)
    {
        return ((delegate* unmanaged<IDvdControl2, POINT, int>)((*lpVtbl)[33]))(this, point);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT PlayChaptersAutoStop(
        [NativeTypeName("ULONG")] uint ulTitle,
        [NativeTypeName("ULONG")] uint ulChapter,
        [NativeTypeName("ULONG")] uint ulChaptersToPlay,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return (
            (delegate* unmanaged<IDvdControl2, uint, uint, uint, uint, IDvdCmd*, int>)(
                (*lpVtbl)[34]
            )
        )(this, ulTitle, ulChapter, ulChaptersToPlay, dwFlags, ppCmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT AcceptParentalLevelChange(BOOL bAccept)
    {
        return ((delegate* unmanaged<IDvdControl2, BOOL, int>)((*lpVtbl)[35]))(this, bAccept);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT SetOption(DVD_OPTION_FLAG flag, BOOL fState)
    {
        return ((delegate* unmanaged<IDvdControl2, DVD_OPTION_FLAG, BOOL, int>)((*lpVtbl)[36]))(
            this,
            flag,
            fState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetState(
        IDvdState pState,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return ((delegate* unmanaged<IDvdControl2, IDvdState, uint, IDvdCmd*, int>)((*lpVtbl)[37]))(
            this,
            pState,
            dwFlags,
            ppCmd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT PlayPeriodInTitleAutoStop(
        [NativeTypeName("ULONG")] uint ulTitle,
        DVD_HMSF_TIMECODE* pStartTime,
        DVD_HMSF_TIMECODE* pEndTime,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return (
            (delegate* unmanaged<
                IDvdControl2,
                uint,
                DVD_HMSF_TIMECODE*,
                DVD_HMSF_TIMECODE*,
                uint,
                IDvdCmd*,
                int>)((*lpVtbl)[38])
        )(this, ulTitle, pStartTime, pEndTime, dwFlags, ppCmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT SetGPRM(
        [NativeTypeName("ULONG")] uint ulIndex,
        [NativeTypeName("WORD")] ushort wValue,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDvdCmd* ppCmd
    )
    {
        return (
            (delegate* unmanaged<IDvdControl2, uint, ushort, uint, IDvdCmd*, int>)((*lpVtbl)[39])
        )(this, ulIndex, wValue, dwFlags, ppCmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT SelectDefaultMenuLanguage([NativeTypeName("LCID")] uint Language)
    {
        return ((delegate* unmanaged<IDvdControl2, uint, int>)((*lpVtbl)[40]))(this, Language);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT SelectDefaultAudioLanguage(
        [NativeTypeName("LCID")] uint Language,
        DVD_AUDIO_LANG_EXT audioExtension
    )
    {
        return ((delegate* unmanaged<IDvdControl2, uint, DVD_AUDIO_LANG_EXT, int>)((*lpVtbl)[41]))(
            this,
            Language,
            audioExtension
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT SelectDefaultSubpictureLanguage(
        [NativeTypeName("LCID")] uint Language,
        DVD_SUBPICTURE_LANG_EXT subpictureExtension
    )
    {
        return (
            (delegate* unmanaged<IDvdControl2, uint, DVD_SUBPICTURE_LANG_EXT, int>)((*lpVtbl)[42])
        )(this, Language, subpictureExtension);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT PlayTitle(
            [NativeTypeName("ULONG")] uint ulTitle,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(4)]
        HRESULT PlayChapterInTitle(
            [NativeTypeName("ULONG")] uint ulTitle,
            [NativeTypeName("ULONG")] uint ulChapter,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(5)]
        HRESULT PlayAtTimeInTitle(
            [NativeTypeName("ULONG")] uint ulTitle,
            DVD_HMSF_TIMECODE* pStartTime,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(6)]
        HRESULT Stop();

        [VtblIndex(7)]
        HRESULT ReturnFromSubmenu([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd* ppCmd);

        [VtblIndex(8)]
        HRESULT PlayAtTime(
            DVD_HMSF_TIMECODE* pTime,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(9)]
        HRESULT PlayChapter(
            [NativeTypeName("ULONG")] uint ulChapter,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(10)]
        HRESULT PlayPrevChapter([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd* ppCmd);

        [VtblIndex(11)]
        HRESULT ReplayChapter([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd* ppCmd);

        [VtblIndex(12)]
        HRESULT PlayNextChapter([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd* ppCmd);

        [VtblIndex(13)]
        HRESULT PlayForwards(double dSpeed, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd* ppCmd);

        [VtblIndex(14)]
        HRESULT PlayBackwards(
            double dSpeed,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(15)]
        HRESULT ShowMenu(
            DVD_MENU_ID MenuID,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(16)]
        HRESULT Resume([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd* ppCmd);

        [VtblIndex(17)]
        HRESULT SelectRelativeButton(DVD_RELATIVE_BUTTON buttonDir);

        [VtblIndex(18)]
        HRESULT ActivateButton();

        [VtblIndex(19)]
        HRESULT SelectButton([NativeTypeName("ULONG")] uint ulButton);

        [VtblIndex(20)]
        HRESULT SelectAndActivateButton([NativeTypeName("ULONG")] uint ulButton);

        [VtblIndex(21)]
        HRESULT StillOff();

        [VtblIndex(22)]
        HRESULT Pause(BOOL bState);

        [VtblIndex(23)]
        HRESULT SelectAudioStream(
            [NativeTypeName("ULONG")] uint ulAudio,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(24)]
        HRESULT SelectSubpictureStream(
            [NativeTypeName("ULONG")] uint ulSubPicture,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(25)]
        HRESULT SetSubpictureState(
            BOOL bState,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(26)]
        HRESULT SelectAngle(
            [NativeTypeName("ULONG")] uint ulAngle,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(27)]
        HRESULT SelectParentalLevel([NativeTypeName("ULONG")] uint ulParentalLevel);

        [VtblIndex(28)]
        HRESULT SelectParentalCountry([NativeTypeName("BYTE[2]")] byte* bCountry);

        [VtblIndex(29)]
        HRESULT SelectKaraokeAudioPresentationMode([NativeTypeName("ULONG")] uint ulMode);

        [VtblIndex(30)]
        HRESULT SelectVideoModePreference([NativeTypeName("ULONG")] uint ulPreferredDisplayMode);

        [VtblIndex(31)]
        HRESULT SetDVDDirectory([NativeTypeName("LPCWSTR")] ushort* pszwPath);

        [VtblIndex(32)]
        HRESULT ActivateAtPosition(POINT point);

        [VtblIndex(33)]
        HRESULT SelectAtPosition(POINT point);

        [VtblIndex(34)]
        HRESULT PlayChaptersAutoStop(
            [NativeTypeName("ULONG")] uint ulTitle,
            [NativeTypeName("ULONG")] uint ulChapter,
            [NativeTypeName("ULONG")] uint ulChaptersToPlay,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(35)]
        HRESULT AcceptParentalLevelChange(BOOL bAccept);

        [VtblIndex(36)]
        HRESULT SetOption(DVD_OPTION_FLAG flag, BOOL fState);

        [VtblIndex(37)]
        HRESULT SetState(IDvdState pState, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd* ppCmd);

        [VtblIndex(38)]
        HRESULT PlayPeriodInTitleAutoStop(
            [NativeTypeName("ULONG")] uint ulTitle,
            DVD_HMSF_TIMECODE* pStartTime,
            DVD_HMSF_TIMECODE* pEndTime,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(39)]
        HRESULT SetGPRM(
            [NativeTypeName("ULONG")] uint ulIndex,
            [NativeTypeName("WORD")] ushort wValue,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDvdCmd* ppCmd
        );

        [VtblIndex(40)]
        HRESULT SelectDefaultMenuLanguage([NativeTypeName("LCID")] uint Language);

        [VtblIndex(41)]
        HRESULT SelectDefaultAudioLanguage(
            [NativeTypeName("LCID")] uint Language,
            DVD_AUDIO_LANG_EXT audioExtension
        );

        [VtblIndex(42)]
        HRESULT SelectDefaultSubpictureLanguage(
            [NativeTypeName("LCID")] uint Language,
            DVD_SUBPICTURE_LANG_EXT subpictureExtension
        );
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

        [NativeTypeName("HRESULT (ULONG, DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IDvdCmd*, int> PlayTitle;

        [NativeTypeName("HRESULT (ULONG, ULONG, DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, IDvdCmd*, int> PlayChapterInTitle;

        [NativeTypeName(
            "HRESULT (ULONG, DVD_HMSF_TIMECODE *, DWORD, IDvdCmd **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DVD_HMSF_TIMECODE*,
            uint,
            IDvdCmd*,
            int> PlayAtTimeInTitle;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDvdCmd*, int> ReturnFromSubmenu;

        [NativeTypeName(
            "HRESULT (DVD_HMSF_TIMECODE *, DWORD, IDvdCmd **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DVD_HMSF_TIMECODE*, uint, IDvdCmd*, int> PlayAtTime;

        [NativeTypeName("HRESULT (ULONG, DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IDvdCmd*, int> PlayChapter;

        [NativeTypeName("HRESULT (DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDvdCmd*, int> PlayPrevChapter;

        [NativeTypeName("HRESULT (DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDvdCmd*, int> ReplayChapter;

        [NativeTypeName("HRESULT (DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDvdCmd*, int> PlayNextChapter;

        [NativeTypeName("HRESULT (double, DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, uint, IDvdCmd*, int> PlayForwards;

        [NativeTypeName("HRESULT (double, DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, uint, IDvdCmd*, int> PlayBackwards;

        [NativeTypeName("HRESULT (DVD_MENU_ID, DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DVD_MENU_ID, uint, IDvdCmd*, int> ShowMenu;

        [NativeTypeName("HRESULT (DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDvdCmd*, int> Resume;

        [NativeTypeName("HRESULT (DVD_RELATIVE_BUTTON) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DVD_RELATIVE_BUTTON, int> SelectRelativeButton;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ActivateButton;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SelectButton;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SelectAndActivateButton;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StillOff;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Pause;

        [NativeTypeName("HRESULT (ULONG, DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IDvdCmd*, int> SelectAudioStream;

        [NativeTypeName("HRESULT (ULONG, DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IDvdCmd*, int> SelectSubpictureStream;

        [NativeTypeName("HRESULT (BOOL, DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, uint, IDvdCmd*, int> SetSubpictureState;

        [NativeTypeName("HRESULT (ULONG, DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IDvdCmd*, int> SelectAngle;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SelectParentalLevel;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> SelectParentalCountry;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SelectKaraokeAudioPresentationMode;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SelectVideoModePreference;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDVDDirectory;

        [NativeTypeName("HRESULT (POINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, int> ActivateAtPosition;

        [NativeTypeName("HRESULT (POINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, int> SelectAtPosition;

        [NativeTypeName(
            "HRESULT (ULONG, ULONG, ULONG, DWORD, IDvdCmd **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            uint,
            IDvdCmd*,
            int> PlayChaptersAutoStop;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> AcceptParentalLevelChange;

        [NativeTypeName("HRESULT (DVD_OPTION_FLAG, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DVD_OPTION_FLAG, BOOL, int> SetOption;

        [NativeTypeName("HRESULT (IDvdState *, DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDvdState, uint, IDvdCmd*, int> SetState;

        [NativeTypeName(
            "HRESULT (ULONG, DVD_HMSF_TIMECODE *, DVD_HMSF_TIMECODE *, DWORD, IDvdCmd **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DVD_HMSF_TIMECODE*,
            DVD_HMSF_TIMECODE*,
            uint,
            IDvdCmd*,
            int> PlayPeriodInTitleAutoStop;

        [NativeTypeName("HRESULT (ULONG, WORD, DWORD, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort, uint, IDvdCmd*, int> SetGPRM;

        [NativeTypeName("HRESULT (LCID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SelectDefaultMenuLanguage;

        [NativeTypeName("HRESULT (LCID, DVD_AUDIO_LANG_EXT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DVD_AUDIO_LANG_EXT,
            int> SelectDefaultAudioLanguage;

        [NativeTypeName("HRESULT (LCID, DVD_SUBPICTURE_LANG_EXT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DVD_SUBPICTURE_LANG_EXT,
            int> SelectDefaultSubpictureLanguage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDvdControl2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDvdControl2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDvdControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDvdControl2(Silk.NET.Windows.IUnknown value)
    {
        return new IDvdControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDvdControl2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDvdControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDvdControl2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
