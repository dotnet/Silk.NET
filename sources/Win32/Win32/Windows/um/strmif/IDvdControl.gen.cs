// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A70EFE61-E2A3-11D0-A9BE-00AA0061BE93")]
[NativeTypeName("struct IDvdControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDvdControl : IDvdControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDvdControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDvdControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDvdControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDvdControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT TitlePlay([NativeTypeName("ULONG")] uint ulTitle)
    {
        return ((delegate* unmanaged<IDvdControl, uint, int>)((*lpVtbl)[3]))(this, ulTitle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ChapterPlay(
        [NativeTypeName("ULONG")] uint ulTitle,
        [NativeTypeName("ULONG")] uint ulChapter
    )
    {
        return ((delegate* unmanaged<IDvdControl, uint, uint, int>)((*lpVtbl)[4]))(
            this,
            ulTitle,
            ulChapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TimePlay(
        [NativeTypeName("ULONG")] uint ulTitle,
        [NativeTypeName("ULONG")] uint bcdTime
    )
    {
        return ((delegate* unmanaged<IDvdControl, uint, uint, int>)((*lpVtbl)[5]))(
            this,
            ulTitle,
            bcdTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StopForResume()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GoUp()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TimeSearch([NativeTypeName("ULONG")] uint bcdTime)
    {
        return ((delegate* unmanaged<IDvdControl, uint, int>)((*lpVtbl)[8]))(this, bcdTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ChapterSearch([NativeTypeName("ULONG")] uint ulChapter)
    {
        return ((delegate* unmanaged<IDvdControl, uint, int>)((*lpVtbl)[9]))(this, ulChapter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT PrevPGSearch()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TopPGSearch()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT NextPGSearch()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ForwardScan(double dwSpeed)
    {
        return ((delegate* unmanaged<IDvdControl, double, int>)((*lpVtbl)[13]))(this, dwSpeed);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT BackwardScan(double dwSpeed)
    {
        return ((delegate* unmanaged<IDvdControl, double, int>)((*lpVtbl)[14]))(this, dwSpeed);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT MenuCall(DVD_MENU_ID MenuID)
    {
        return ((delegate* unmanaged<IDvdControl, DVD_MENU_ID, int>)((*lpVtbl)[15]))(this, MenuID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT UpperButtonSelect()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT LowerButtonSelect()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT LeftButtonSelect()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[19]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT RightButtonSelect()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[20]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ButtonActivate()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[21]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ButtonSelectAndActivate([NativeTypeName("ULONG")] uint ulButton)
    {
        return ((delegate* unmanaged<IDvdControl, uint, int>)((*lpVtbl)[22]))(this, ulButton);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT StillOff()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[23]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT PauseOn()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[24]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PauseOff()
    {
        return ((delegate* unmanaged<IDvdControl, int>)((*lpVtbl)[25]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT MenuLanguageSelect([NativeTypeName("LCID")] uint Language)
    {
        return ((delegate* unmanaged<IDvdControl, uint, int>)((*lpVtbl)[26]))(this, Language);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT AudioStreamChange([NativeTypeName("ULONG")] uint ulAudio)
    {
        return ((delegate* unmanaged<IDvdControl, uint, int>)((*lpVtbl)[27]))(this, ulAudio);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SubpictureStreamChange(
        [NativeTypeName("ULONG")] uint ulSubPicture,
        BOOL bDisplay
    )
    {
        return ((delegate* unmanaged<IDvdControl, uint, BOOL, int>)((*lpVtbl)[28]))(
            this,
            ulSubPicture,
            bDisplay
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT AngleChange([NativeTypeName("ULONG")] uint ulAngle)
    {
        return ((delegate* unmanaged<IDvdControl, uint, int>)((*lpVtbl)[29]))(this, ulAngle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT ParentalLevelSelect([NativeTypeName("ULONG")] uint ulParentalLevel)
    {
        return ((delegate* unmanaged<IDvdControl, uint, int>)((*lpVtbl)[30]))(
            this,
            ulParentalLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT ParentalCountrySelect([NativeTypeName("WORD")] ushort wCountry)
    {
        return ((delegate* unmanaged<IDvdControl, ushort, int>)((*lpVtbl)[31]))(this, wCountry);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT KaraokeAudioPresentationModeChange([NativeTypeName("ULONG")] uint ulMode)
    {
        return ((delegate* unmanaged<IDvdControl, uint, int>)((*lpVtbl)[32]))(this, ulMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT VideoModePreferrence([NativeTypeName("ULONG")] uint ulPreferredDisplayMode)
    {
        return ((delegate* unmanaged<IDvdControl, uint, int>)((*lpVtbl)[33]))(
            this,
            ulPreferredDisplayMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT SetRoot([NativeTypeName("LPCWSTR")] ushort* pszPath)
    {
        return ((delegate* unmanaged<IDvdControl, ushort*, int>)((*lpVtbl)[34]))(this, pszPath);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT MouseActivate(POINT point)
    {
        return ((delegate* unmanaged<IDvdControl, POINT, int>)((*lpVtbl)[35]))(this, point);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT MouseSelect(POINT point)
    {
        return ((delegate* unmanaged<IDvdControl, POINT, int>)((*lpVtbl)[36]))(this, point);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT ChapterPlayAutoStop(
        [NativeTypeName("ULONG")] uint ulTitle,
        [NativeTypeName("ULONG")] uint ulChapter,
        [NativeTypeName("ULONG")] uint ulChaptersToPlay
    )
    {
        return ((delegate* unmanaged<IDvdControl, uint, uint, uint, int>)((*lpVtbl)[37]))(
            this,
            ulTitle,
            ulChapter,
            ulChaptersToPlay
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT TitlePlay([NativeTypeName("ULONG")] uint ulTitle);

        [VtblIndex(4)]
        HRESULT ChapterPlay(
            [NativeTypeName("ULONG")] uint ulTitle,
            [NativeTypeName("ULONG")] uint ulChapter
        );

        [VtblIndex(5)]
        HRESULT TimePlay(
            [NativeTypeName("ULONG")] uint ulTitle,
            [NativeTypeName("ULONG")] uint bcdTime
        );

        [VtblIndex(6)]
        HRESULT StopForResume();

        [VtblIndex(7)]
        HRESULT GoUp();

        [VtblIndex(8)]
        HRESULT TimeSearch([NativeTypeName("ULONG")] uint bcdTime);

        [VtblIndex(9)]
        HRESULT ChapterSearch([NativeTypeName("ULONG")] uint ulChapter);

        [VtblIndex(10)]
        HRESULT PrevPGSearch();

        [VtblIndex(11)]
        HRESULT TopPGSearch();

        [VtblIndex(12)]
        HRESULT NextPGSearch();

        [VtblIndex(13)]
        HRESULT ForwardScan(double dwSpeed);

        [VtblIndex(14)]
        HRESULT BackwardScan(double dwSpeed);

        [VtblIndex(15)]
        HRESULT MenuCall(DVD_MENU_ID MenuID);

        [VtblIndex(16)]
        HRESULT Resume();

        [VtblIndex(17)]
        HRESULT UpperButtonSelect();

        [VtblIndex(18)]
        HRESULT LowerButtonSelect();

        [VtblIndex(19)]
        HRESULT LeftButtonSelect();

        [VtblIndex(20)]
        HRESULT RightButtonSelect();

        [VtblIndex(21)]
        HRESULT ButtonActivate();

        [VtblIndex(22)]
        HRESULT ButtonSelectAndActivate([NativeTypeName("ULONG")] uint ulButton);

        [VtblIndex(23)]
        HRESULT StillOff();

        [VtblIndex(24)]
        HRESULT PauseOn();

        [VtblIndex(25)]
        HRESULT PauseOff();

        [VtblIndex(26)]
        HRESULT MenuLanguageSelect([NativeTypeName("LCID")] uint Language);

        [VtblIndex(27)]
        HRESULT AudioStreamChange([NativeTypeName("ULONG")] uint ulAudio);

        [VtblIndex(28)]
        HRESULT SubpictureStreamChange([NativeTypeName("ULONG")] uint ulSubPicture, BOOL bDisplay);

        [VtblIndex(29)]
        HRESULT AngleChange([NativeTypeName("ULONG")] uint ulAngle);

        [VtblIndex(30)]
        HRESULT ParentalLevelSelect([NativeTypeName("ULONG")] uint ulParentalLevel);

        [VtblIndex(31)]
        HRESULT ParentalCountrySelect([NativeTypeName("WORD")] ushort wCountry);

        [VtblIndex(32)]
        HRESULT KaraokeAudioPresentationModeChange([NativeTypeName("ULONG")] uint ulMode);

        [VtblIndex(33)]
        HRESULT VideoModePreferrence([NativeTypeName("ULONG")] uint ulPreferredDisplayMode);

        [VtblIndex(34)]
        HRESULT SetRoot([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [VtblIndex(35)]
        HRESULT MouseActivate(POINT point);

        [VtblIndex(36)]
        HRESULT MouseSelect(POINT point);

        [VtblIndex(37)]
        HRESULT ChapterPlayAutoStop(
            [NativeTypeName("ULONG")] uint ulTitle,
            [NativeTypeName("ULONG")] uint ulChapter,
            [NativeTypeName("ULONG")] uint ulChaptersToPlay
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

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> TitlePlay;

        [NativeTypeName("HRESULT (ULONG, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> ChapterPlay;

        [NativeTypeName("HRESULT (ULONG, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> TimePlay;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopForResume;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GoUp;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> TimeSearch;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> ChapterSearch;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PrevPGSearch;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> TopPGSearch;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NextPGSearch;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> ForwardScan;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> BackwardScan;

        [NativeTypeName("HRESULT (DVD_MENU_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DVD_MENU_ID, int> MenuCall;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Resume;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UpperButtonSelect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LowerButtonSelect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LeftButtonSelect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RightButtonSelect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ButtonActivate;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> ButtonSelectAndActivate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StillOff;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PauseOn;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PauseOff;

        [NativeTypeName("HRESULT (LCID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> MenuLanguageSelect;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> AudioStreamChange;

        [NativeTypeName("HRESULT (ULONG, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, int> SubpictureStreamChange;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> AngleChange;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> ParentalLevelSelect;

        [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> ParentalCountrySelect;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> KaraokeAudioPresentationModeChange;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> VideoModePreferrence;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetRoot;

        [NativeTypeName("HRESULT (POINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, int> MouseActivate;

        [NativeTypeName("HRESULT (POINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, int> MouseSelect;

        [NativeTypeName("HRESULT (ULONG, ULONG, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> ChapterPlayAutoStop;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDvdControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDvdControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDvdControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDvdControl(Silk.NET.Windows.IUnknown value)
    {
        return new IDvdControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDvdControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDvdControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDvdControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
