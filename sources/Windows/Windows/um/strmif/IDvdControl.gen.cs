// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl"]/*' />
[Guid("A70EFE61-E2A3-11D0-A9BE-00AA0061BE93")]
[NativeTypeName("struct IDvdControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDvdControl : IDvdControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDvdControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDvdControl*, Guid*, void**, int>)(lpVtbl[0]))((IDvdControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDvdControl*, uint>)(lpVtbl[1]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDvdControl*, uint>)(lpVtbl[2]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.TitlePlay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT TitlePlay([NativeTypeName("ULONG")] uint ulTitle)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[3]))((IDvdControl*)Unsafe.AsPointer(ref this), ulTitle);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.ChapterPlay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ChapterPlay([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG")] uint ulChapter)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, uint, int>)(lpVtbl[4]))((IDvdControl*)Unsafe.AsPointer(ref this), ulTitle, ulChapter);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.TimePlay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TimePlay([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG")] uint bcdTime)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, uint, int>)(lpVtbl[5]))((IDvdControl*)Unsafe.AsPointer(ref this), ulTitle, bcdTime);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.StopForResume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StopForResume()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[6]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.GoUp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GoUp()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[7]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.TimeSearch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TimeSearch([NativeTypeName("ULONG")] uint bcdTime)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[8]))((IDvdControl*)Unsafe.AsPointer(ref this), bcdTime);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.ChapterSearch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ChapterSearch([NativeTypeName("ULONG")] uint ulChapter)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[9]))((IDvdControl*)Unsafe.AsPointer(ref this), ulChapter);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.PrevPGSearch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT PrevPGSearch()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[10]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.TopPGSearch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TopPGSearch()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[11]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.NextPGSearch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT NextPGSearch()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[12]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.ForwardScan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ForwardScan(double dwSpeed)
    {
        return ((delegate* unmanaged<IDvdControl*, double, int>)(lpVtbl[13]))((IDvdControl*)Unsafe.AsPointer(ref this), dwSpeed);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.BackwardScan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT BackwardScan(double dwSpeed)
    {
        return ((delegate* unmanaged<IDvdControl*, double, int>)(lpVtbl[14]))((IDvdControl*)Unsafe.AsPointer(ref this), dwSpeed);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.MenuCall"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT MenuCall(DVD_MENU_ID MenuID)
    {
        return ((delegate* unmanaged<IDvdControl*, DVD_MENU_ID, int>)(lpVtbl[15]))((IDvdControl*)Unsafe.AsPointer(ref this), MenuID);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.Resume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[16]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.UpperButtonSelect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT UpperButtonSelect()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[17]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.LowerButtonSelect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT LowerButtonSelect()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[18]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.LeftButtonSelect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT LeftButtonSelect()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[19]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.RightButtonSelect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT RightButtonSelect()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[20]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.ButtonActivate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ButtonActivate()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[21]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.ButtonSelectAndActivate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ButtonSelectAndActivate([NativeTypeName("ULONG")] uint ulButton)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[22]))((IDvdControl*)Unsafe.AsPointer(ref this), ulButton);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.StillOff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT StillOff()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[23]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.PauseOn"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT PauseOn()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[24]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.PauseOff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PauseOff()
    {
        return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[25]))((IDvdControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.MenuLanguageSelect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT MenuLanguageSelect([NativeTypeName("LCID")] uint Language)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[26]))((IDvdControl*)Unsafe.AsPointer(ref this), Language);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.AudioStreamChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT AudioStreamChange([NativeTypeName("ULONG")] uint ulAudio)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[27]))((IDvdControl*)Unsafe.AsPointer(ref this), ulAudio);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.SubpictureStreamChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SubpictureStreamChange([NativeTypeName("ULONG")] uint ulSubPicture, BOOL bDisplay)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, BOOL, int>)(lpVtbl[28]))((IDvdControl*)Unsafe.AsPointer(ref this), ulSubPicture, bDisplay);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.AngleChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT AngleChange([NativeTypeName("ULONG")] uint ulAngle)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[29]))((IDvdControl*)Unsafe.AsPointer(ref this), ulAngle);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.ParentalLevelSelect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT ParentalLevelSelect([NativeTypeName("ULONG")] uint ulParentalLevel)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[30]))((IDvdControl*)Unsafe.AsPointer(ref this), ulParentalLevel);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.ParentalCountrySelect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT ParentalCountrySelect([NativeTypeName("WORD")] ushort wCountry)
    {
        return ((delegate* unmanaged<IDvdControl*, ushort, int>)(lpVtbl[31]))((IDvdControl*)Unsafe.AsPointer(ref this), wCountry);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.KaraokeAudioPresentationModeChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT KaraokeAudioPresentationModeChange([NativeTypeName("ULONG")] uint ulMode)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[32]))((IDvdControl*)Unsafe.AsPointer(ref this), ulMode);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.VideoModePreferrence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT VideoModePreferrence([NativeTypeName("ULONG")] uint ulPreferredDisplayMode)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[33]))((IDvdControl*)Unsafe.AsPointer(ref this), ulPreferredDisplayMode);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.SetRoot"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT SetRoot([NativeTypeName("LPCWSTR")] ushort* pszPath)
    {
        return ((delegate* unmanaged<IDvdControl*, ushort*, int>)(lpVtbl[34]))((IDvdControl*)Unsafe.AsPointer(ref this), pszPath);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.MouseActivate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT MouseActivate(POINT point)
    {
        return ((delegate* unmanaged<IDvdControl*, POINT, int>)(lpVtbl[35]))((IDvdControl*)Unsafe.AsPointer(ref this), point);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.MouseSelect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT MouseSelect(POINT point)
    {
        return ((delegate* unmanaged<IDvdControl*, POINT, int>)(lpVtbl[36]))((IDvdControl*)Unsafe.AsPointer(ref this), point);
    }

    /// <include file='IDvdControl.xml' path='doc/member[@name="IDvdControl.ChapterPlayAutoStop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT ChapterPlayAutoStop([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG")] uint ulChapter, [NativeTypeName("ULONG")] uint ulChaptersToPlay)
    {
        return ((delegate* unmanaged<IDvdControl*, uint, uint, uint, int>)(lpVtbl[37]))((IDvdControl*)Unsafe.AsPointer(ref this), ulTitle, ulChapter, ulChaptersToPlay);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT TitlePlay([NativeTypeName("ULONG")] uint ulTitle);

        [VtblIndex(4)]
        HRESULT ChapterPlay([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG")] uint ulChapter);

        [VtblIndex(5)]
        HRESULT TimePlay([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG")] uint bcdTime);

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
        HRESULT ChapterPlayAutoStop([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG")] uint ulChapter, [NativeTypeName("ULONG")] uint ulChaptersToPlay);
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
}
