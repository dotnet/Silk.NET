// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2"]/*' />
[Guid("34151510-EEC0-11D2-8201-00A0C9D74842")]
[NativeTypeName("struct IDvdInfo2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDvdInfo2 : IDvdInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDvdInfo2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDvdInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IDvdInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint>)(lpVtbl[1]))((IDvdInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint>)(lpVtbl[2]))((IDvdInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetCurrentDomain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrentDomain(DVD_DOMAIN* pDomain)
    {
        return ((delegate* unmanaged<IDvdInfo2*, DVD_DOMAIN*, int>)(lpVtbl[3]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pDomain);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetCurrentLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurrentLocation(DVD_PLAYBACK_LOCATION2* pLocation)
    {
        return ((delegate* unmanaged<IDvdInfo2*, DVD_PLAYBACK_LOCATION2*, int>)(lpVtbl[4]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLocation);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetTotalTitleTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTotalTitleTime(DVD_HMSF_TIMECODE* pTotalTime, [NativeTypeName("ULONG *")] uint* ulTimeCodeFlags)
    {
        return ((delegate* unmanaged<IDvdInfo2*, DVD_HMSF_TIMECODE*, uint*, int>)(lpVtbl[5]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pTotalTime, ulTimeCodeFlags);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetCurrentButton"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentButton([NativeTypeName("ULONG *")] uint* pulButtonsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentButton)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint*, uint*, int>)(lpVtbl[6]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulButtonsAvailable, pulCurrentButton);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetCurrentAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentAngle([NativeTypeName("ULONG *")] uint* pulAnglesAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentAngle)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint*, uint*, int>)(lpVtbl[7]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulAnglesAvailable, pulCurrentAngle);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetCurrentAudio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCurrentAudio([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint*, uint*, int>)(lpVtbl[8]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulStreamsAvailable, pulCurrentStream);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetCurrentSubpicture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCurrentSubpicture([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream, BOOL* pbIsDisabled)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint*, uint*, BOOL*, int>)(lpVtbl[9]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulStreamsAvailable, pulCurrentStream, pbIsDisabled);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetCurrentUOPS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetCurrentUOPS([NativeTypeName("ULONG *")] uint* pulUOPs)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint*, int>)(lpVtbl[10]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulUOPs);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetAllSPRMs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetAllSPRMs([NativeTypeName("SPRMARRAY *")] ushort** pRegisterArray)
    {
        return ((delegate* unmanaged<IDvdInfo2*, ushort**, int>)(lpVtbl[11]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pRegisterArray);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetAllGPRMs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetAllGPRMs([NativeTypeName("GPRMARRAY *")] ushort** pRegisterArray)
    {
        return ((delegate* unmanaged<IDvdInfo2*, ushort**, int>)(lpVtbl[12]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pRegisterArray);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetAudioLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetAudioLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, uint*, int>)(lpVtbl[13]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pLanguage);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetSubpictureLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetSubpictureLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, uint*, int>)(lpVtbl[14]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pLanguage);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetTitleAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetTitleAttributes([NativeTypeName("ULONG")] uint ulTitle, DVD_MenuAttributes* pMenu, DVD_TitleAttributes* pTitle)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, DVD_MenuAttributes*, DVD_TitleAttributes*, int>)(lpVtbl[15]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulTitle, pMenu, pTitle);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetVMGAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetVMGAttributes(DVD_MenuAttributes* pATR)
    {
        return ((delegate* unmanaged<IDvdInfo2*, DVD_MenuAttributes*, int>)(lpVtbl[16]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pATR);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetCurrentVideoAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetCurrentVideoAttributes(DVD_VideoAttributes* pATR)
    {
        return ((delegate* unmanaged<IDvdInfo2*, DVD_VideoAttributes*, int>)(lpVtbl[17]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pATR);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetAudioAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetAudioAttributes([NativeTypeName("ULONG")] uint ulStream, DVD_AudioAttributes* pATR)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, DVD_AudioAttributes*, int>)(lpVtbl[18]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pATR);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetKaraokeAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetKaraokeAttributes([NativeTypeName("ULONG")] uint ulStream, DVD_KaraokeAttributes* pAttributes)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, DVD_KaraokeAttributes*, int>)(lpVtbl[19]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pAttributes);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetSubpictureAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetSubpictureAttributes([NativeTypeName("ULONG")] uint ulStream, DVD_SubpictureAttributes* pATR)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, DVD_SubpictureAttributes*, int>)(lpVtbl[20]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pATR);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetDVDVolumeInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetDVDVolumeInfo([NativeTypeName("ULONG *")] uint* pulNumOfVolumes, [NativeTypeName("ULONG *")] uint* pulVolume, DVD_DISC_SIDE* pSide, [NativeTypeName("ULONG *")] uint* pulNumOfTitles)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint*, uint*, DVD_DISC_SIDE*, uint*, int>)(lpVtbl[21]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulNumOfVolumes, pulVolume, pSide, pulNumOfTitles);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetDVDTextNumberOfLanguages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetDVDTextNumberOfLanguages([NativeTypeName("ULONG *")] uint* pulNumOfLangs)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint*, int>)(lpVtbl[22]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulNumOfLangs);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetDVDTextLanguageInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetDVDTextLanguageInfo([NativeTypeName("ULONG")] uint ulLangIndex, [NativeTypeName("ULONG *")] uint* pulNumOfStrings, [NativeTypeName("LCID *")] uint* pLangCode, [NativeTypeName("enum DVD_TextCharSet *")] DVD_TextCharSet* pbCharacterSet)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, uint*, uint*, DVD_TextCharSet*, int>)(lpVtbl[23]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulLangIndex, pulNumOfStrings, pLangCode, pbCharacterSet);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetDVDTextStringAsNative"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetDVDTextStringAsNative([NativeTypeName("ULONG")] uint ulLangIndex, [NativeTypeName("ULONG")] uint ulStringIndex, byte* pbBuffer, [NativeTypeName("ULONG")] uint ulMaxBufferSize, [NativeTypeName("ULONG *")] uint* pulActualSize, [NativeTypeName("enum DVD_TextStringType *")] DVD_TextStringType* pType)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, uint, byte*, uint, uint*, DVD_TextStringType*, int>)(lpVtbl[24]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulLangIndex, ulStringIndex, pbBuffer, ulMaxBufferSize, pulActualSize, pType);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetDVDTextStringAsUnicode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetDVDTextStringAsUnicode([NativeTypeName("ULONG")] uint ulLangIndex, [NativeTypeName("ULONG")] uint ulStringIndex, [NativeTypeName("WCHAR *")] ushort* pchwBuffer, [NativeTypeName("ULONG")] uint ulMaxBufferSize, [NativeTypeName("ULONG *")] uint* pulActualSize, [NativeTypeName("enum DVD_TextStringType *")] DVD_TextStringType* pType)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, uint, ushort*, uint, uint*, DVD_TextStringType*, int>)(lpVtbl[25]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulLangIndex, ulStringIndex, pchwBuffer, ulMaxBufferSize, pulActualSize, pType);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetPlayerParentalLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetPlayerParentalLevel([NativeTypeName("ULONG *")] uint* pulParentalLevel, [NativeTypeName("BYTE[2]")] byte* pbCountryCode)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint*, byte*, int>)(lpVtbl[26]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulParentalLevel, pbCountryCode);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetNumberOfChapters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetNumberOfChapters([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulNumOfChapters)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, uint*, int>)(lpVtbl[27]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulTitle, pulNumOfChapters);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetTitleParentalLevels"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetTitleParentalLevels([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulParentalLevels)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, uint*, int>)(lpVtbl[28]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulTitle, pulParentalLevels);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetDVDDirectory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetDVDDirectory([NativeTypeName("LPWSTR")] ushort* pszwPath, [NativeTypeName("ULONG")] uint ulMaxSize, [NativeTypeName("ULONG *")] uint* pulActualSize)
    {
        return ((delegate* unmanaged<IDvdInfo2*, ushort*, uint, uint*, int>)(lpVtbl[29]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pszwPath, ulMaxSize, pulActualSize);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.IsAudioStreamEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT IsAudioStreamEnabled([NativeTypeName("ULONG")] uint ulStreamNum, BOOL* pbEnabled)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, BOOL*, int>)(lpVtbl[30]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStreamNum, pbEnabled);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetDiscID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetDiscID([NativeTypeName("LPCWSTR")] ushort* pszwPath, [NativeTypeName("ULONGLONG *")] ulong* pullDiscID)
    {
        return ((delegate* unmanaged<IDvdInfo2*, ushort*, ulong*, int>)(lpVtbl[31]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pszwPath, pullDiscID);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetState(IDvdState** pStateData)
    {
        return ((delegate* unmanaged<IDvdInfo2*, IDvdState**, int>)(lpVtbl[32]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pStateData);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetMenuLanguages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetMenuLanguages([NativeTypeName("LCID *")] uint* pLanguages, [NativeTypeName("ULONG")] uint ulMaxLanguages, [NativeTypeName("ULONG *")] uint* pulActualLanguages)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint*, uint, uint*, int>)(lpVtbl[33]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLanguages, ulMaxLanguages, pulActualLanguages);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetButtonAtPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetButtonAtPosition(POINT point, [NativeTypeName("ULONG *")] uint* pulButtonIndex)
    {
        return ((delegate* unmanaged<IDvdInfo2*, POINT, uint*, int>)(lpVtbl[34]))((IDvdInfo2*)Unsafe.AsPointer(ref this), point, pulButtonIndex);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetCmdFromEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetCmdFromEvent([NativeTypeName("LONG_PTR")] nint lParam1, IDvdCmd** pCmdObj)
    {
        return ((delegate* unmanaged<IDvdInfo2*, nint, IDvdCmd**, int>)(lpVtbl[35]))((IDvdInfo2*)Unsafe.AsPointer(ref this), lParam1, pCmdObj);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetDefaultMenuLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetDefaultMenuLanguage([NativeTypeName("LCID *")] uint* pLanguage)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint*, int>)(lpVtbl[36]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLanguage);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetDefaultAudioLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT GetDefaultAudioLanguage([NativeTypeName("LCID *")] uint* pLanguage, DVD_AUDIO_LANG_EXT* pAudioExtension)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint*, DVD_AUDIO_LANG_EXT*, int>)(lpVtbl[37]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLanguage, pAudioExtension);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetDefaultSubpictureLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT GetDefaultSubpictureLanguage([NativeTypeName("LCID *")] uint* pLanguage, DVD_SUBPICTURE_LANG_EXT* pSubpictureExtension)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint*, DVD_SUBPICTURE_LANG_EXT*, int>)(lpVtbl[38]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLanguage, pSubpictureExtension);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetDecoderCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT GetDecoderCaps(DVD_DECODER_CAPS* pCaps)
    {
        return ((delegate* unmanaged<IDvdInfo2*, DVD_DECODER_CAPS*, int>)(lpVtbl[39]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pCaps);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.GetButtonRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetButtonRect([NativeTypeName("ULONG")] uint ulButton, RECT* pRect)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, RECT*, int>)(lpVtbl[40]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulButton, pRect);
    }

    /// <include file='IDvdInfo2.xml' path='doc/member[@name="IDvdInfo2.IsSubpictureStreamEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT IsSubpictureStreamEnabled([NativeTypeName("ULONG")] uint ulStreamNum, BOOL* pbEnabled)
    {
        return ((delegate* unmanaged<IDvdInfo2*, uint, BOOL*, int>)(lpVtbl[41]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStreamNum, pbEnabled);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrentDomain(DVD_DOMAIN* pDomain);

        [VtblIndex(4)]
        HRESULT GetCurrentLocation(DVD_PLAYBACK_LOCATION2* pLocation);

        [VtblIndex(5)]
        HRESULT GetTotalTitleTime(DVD_HMSF_TIMECODE* pTotalTime, [NativeTypeName("ULONG *")] uint* ulTimeCodeFlags);

        [VtblIndex(6)]
        HRESULT GetCurrentButton([NativeTypeName("ULONG *")] uint* pulButtonsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentButton);

        [VtblIndex(7)]
        HRESULT GetCurrentAngle([NativeTypeName("ULONG *")] uint* pulAnglesAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentAngle);

        [VtblIndex(8)]
        HRESULT GetCurrentAudio([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream);

        [VtblIndex(9)]
        HRESULT GetCurrentSubpicture([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream, BOOL* pbIsDisabled);

        [VtblIndex(10)]
        HRESULT GetCurrentUOPS([NativeTypeName("ULONG *")] uint* pulUOPs);

        [VtblIndex(11)]
        HRESULT GetAllSPRMs([NativeTypeName("SPRMARRAY *")] ushort** pRegisterArray);

        [VtblIndex(12)]
        HRESULT GetAllGPRMs([NativeTypeName("GPRMARRAY *")] ushort** pRegisterArray);

        [VtblIndex(13)]
        HRESULT GetAudioLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage);

        [VtblIndex(14)]
        HRESULT GetSubpictureLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage);

        [VtblIndex(15)]
        HRESULT GetTitleAttributes([NativeTypeName("ULONG")] uint ulTitle, DVD_MenuAttributes* pMenu, DVD_TitleAttributes* pTitle);

        [VtblIndex(16)]
        HRESULT GetVMGAttributes(DVD_MenuAttributes* pATR);

        [VtblIndex(17)]
        HRESULT GetCurrentVideoAttributes(DVD_VideoAttributes* pATR);

        [VtblIndex(18)]
        HRESULT GetAudioAttributes([NativeTypeName("ULONG")] uint ulStream, DVD_AudioAttributes* pATR);

        [VtblIndex(19)]
        HRESULT GetKaraokeAttributes([NativeTypeName("ULONG")] uint ulStream, DVD_KaraokeAttributes* pAttributes);

        [VtblIndex(20)]
        HRESULT GetSubpictureAttributes([NativeTypeName("ULONG")] uint ulStream, DVD_SubpictureAttributes* pATR);

        [VtblIndex(21)]
        HRESULT GetDVDVolumeInfo([NativeTypeName("ULONG *")] uint* pulNumOfVolumes, [NativeTypeName("ULONG *")] uint* pulVolume, DVD_DISC_SIDE* pSide, [NativeTypeName("ULONG *")] uint* pulNumOfTitles);

        [VtblIndex(22)]
        HRESULT GetDVDTextNumberOfLanguages([NativeTypeName("ULONG *")] uint* pulNumOfLangs);

        [VtblIndex(23)]
        HRESULT GetDVDTextLanguageInfo([NativeTypeName("ULONG")] uint ulLangIndex, [NativeTypeName("ULONG *")] uint* pulNumOfStrings, [NativeTypeName("LCID *")] uint* pLangCode, [NativeTypeName("enum DVD_TextCharSet *")] DVD_TextCharSet* pbCharacterSet);

        [VtblIndex(24)]
        HRESULT GetDVDTextStringAsNative([NativeTypeName("ULONG")] uint ulLangIndex, [NativeTypeName("ULONG")] uint ulStringIndex, byte* pbBuffer, [NativeTypeName("ULONG")] uint ulMaxBufferSize, [NativeTypeName("ULONG *")] uint* pulActualSize, [NativeTypeName("enum DVD_TextStringType *")] DVD_TextStringType* pType);

        [VtblIndex(25)]
        HRESULT GetDVDTextStringAsUnicode([NativeTypeName("ULONG")] uint ulLangIndex, [NativeTypeName("ULONG")] uint ulStringIndex, [NativeTypeName("WCHAR *")] ushort* pchwBuffer, [NativeTypeName("ULONG")] uint ulMaxBufferSize, [NativeTypeName("ULONG *")] uint* pulActualSize, [NativeTypeName("enum DVD_TextStringType *")] DVD_TextStringType* pType);

        [VtblIndex(26)]
        HRESULT GetPlayerParentalLevel([NativeTypeName("ULONG *")] uint* pulParentalLevel, [NativeTypeName("BYTE[2]")] byte* pbCountryCode);

        [VtblIndex(27)]
        HRESULT GetNumberOfChapters([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulNumOfChapters);

        [VtblIndex(28)]
        HRESULT GetTitleParentalLevels([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulParentalLevels);

        [VtblIndex(29)]
        HRESULT GetDVDDirectory([NativeTypeName("LPWSTR")] ushort* pszwPath, [NativeTypeName("ULONG")] uint ulMaxSize, [NativeTypeName("ULONG *")] uint* pulActualSize);

        [VtblIndex(30)]
        HRESULT IsAudioStreamEnabled([NativeTypeName("ULONG")] uint ulStreamNum, BOOL* pbEnabled);

        [VtblIndex(31)]
        HRESULT GetDiscID([NativeTypeName("LPCWSTR")] ushort* pszwPath, [NativeTypeName("ULONGLONG *")] ulong* pullDiscID);

        [VtblIndex(32)]
        HRESULT GetState(IDvdState** pStateData);

        [VtblIndex(33)]
        HRESULT GetMenuLanguages([NativeTypeName("LCID *")] uint* pLanguages, [NativeTypeName("ULONG")] uint ulMaxLanguages, [NativeTypeName("ULONG *")] uint* pulActualLanguages);

        [VtblIndex(34)]
        HRESULT GetButtonAtPosition(POINT point, [NativeTypeName("ULONG *")] uint* pulButtonIndex);

        [VtblIndex(35)]
        HRESULT GetCmdFromEvent([NativeTypeName("LONG_PTR")] nint lParam1, IDvdCmd** pCmdObj);

        [VtblIndex(36)]
        HRESULT GetDefaultMenuLanguage([NativeTypeName("LCID *")] uint* pLanguage);

        [VtblIndex(37)]
        HRESULT GetDefaultAudioLanguage([NativeTypeName("LCID *")] uint* pLanguage, DVD_AUDIO_LANG_EXT* pAudioExtension);

        [VtblIndex(38)]
        HRESULT GetDefaultSubpictureLanguage([NativeTypeName("LCID *")] uint* pLanguage, DVD_SUBPICTURE_LANG_EXT* pSubpictureExtension);

        [VtblIndex(39)]
        HRESULT GetDecoderCaps(DVD_DECODER_CAPS* pCaps);

        [VtblIndex(40)]
        HRESULT GetButtonRect([NativeTypeName("ULONG")] uint ulButton, RECT* pRect);

        [VtblIndex(41)]
        HRESULT IsSubpictureStreamEnabled([NativeTypeName("ULONG")] uint ulStreamNum, BOOL* pbEnabled);
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

        [NativeTypeName("HRESULT (DVD_DOMAIN *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DVD_DOMAIN*, int> GetCurrentDomain;

        [NativeTypeName("HRESULT (DVD_PLAYBACK_LOCATION2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DVD_PLAYBACK_LOCATION2*, int> GetCurrentLocation;

        [NativeTypeName("HRESULT (DVD_HMSF_TIMECODE *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DVD_HMSF_TIMECODE*, uint*, int> GetTotalTitleTime;

        [NativeTypeName("HRESULT (ULONG *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetCurrentButton;

        [NativeTypeName("HRESULT (ULONG *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetCurrentAngle;

        [NativeTypeName("HRESULT (ULONG *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetCurrentAudio;

        [NativeTypeName("HRESULT (ULONG *, ULONG *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, BOOL*, int> GetCurrentSubpicture;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentUOPS;

        [NativeTypeName("HRESULT (SPRMARRAY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetAllSPRMs;

        [NativeTypeName("HRESULT (GPRMARRAY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetAllGPRMs;

        [NativeTypeName("HRESULT (ULONG, LCID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetAudioLanguage;

        [NativeTypeName("HRESULT (ULONG, LCID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetSubpictureLanguage;

        [NativeTypeName("HRESULT (ULONG, DVD_MenuAttributes *, DVD_TitleAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DVD_MenuAttributes*, DVD_TitleAttributes*, int> GetTitleAttributes;

        [NativeTypeName("HRESULT (DVD_MenuAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DVD_MenuAttributes*, int> GetVMGAttributes;

        [NativeTypeName("HRESULT (DVD_VideoAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DVD_VideoAttributes*, int> GetCurrentVideoAttributes;

        [NativeTypeName("HRESULT (ULONG, DVD_AudioAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DVD_AudioAttributes*, int> GetAudioAttributes;

        [NativeTypeName("HRESULT (ULONG, DVD_KaraokeAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DVD_KaraokeAttributes*, int> GetKaraokeAttributes;

        [NativeTypeName("HRESULT (ULONG, DVD_SubpictureAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DVD_SubpictureAttributes*, int> GetSubpictureAttributes;

        [NativeTypeName("HRESULT (ULONG *, ULONG *, DVD_DISC_SIDE *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, DVD_DISC_SIDE*, uint*, int> GetDVDVolumeInfo;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDVDTextNumberOfLanguages;

        [NativeTypeName("HRESULT (ULONG, ULONG *, LCID *, enum DVD_TextCharSet *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint*, DVD_TextCharSet*, int> GetDVDTextLanguageInfo;

        [NativeTypeName("HRESULT (ULONG, ULONG, BYTE *, ULONG, ULONG *, enum DVD_TextStringType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint, uint*, DVD_TextStringType*, int> GetDVDTextStringAsNative;

        [NativeTypeName("HRESULT (ULONG, ULONG, WCHAR *, ULONG, ULONG *, enum DVD_TextStringType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ushort*, uint, uint*, DVD_TextStringType*, int> GetDVDTextStringAsUnicode;

        [NativeTypeName("HRESULT (ULONG *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, byte*, int> GetPlayerParentalLevel;

        [NativeTypeName("HRESULT (ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetNumberOfChapters;

        [NativeTypeName("HRESULT (ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetTitleParentalLevels;

        [NativeTypeName("HRESULT (LPWSTR, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint*, int> GetDVDDirectory;

        [NativeTypeName("HRESULT (ULONG, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> IsAudioStreamEnabled;

        [NativeTypeName("HRESULT (LPCWSTR, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ulong*, int> GetDiscID;

        [NativeTypeName("HRESULT (IDvdState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDvdState**, int> GetState;

        [NativeTypeName("HRESULT (LCID *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint, uint*, int> GetMenuLanguages;

        [NativeTypeName("HRESULT (POINT, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, uint*, int> GetButtonAtPosition;

        [NativeTypeName("HRESULT (LONG_PTR, IDvdCmd **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nint, IDvdCmd**, int> GetCmdFromEvent;

        [NativeTypeName("HRESULT (LCID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDefaultMenuLanguage;

        [NativeTypeName("HRESULT (LCID *, DVD_AUDIO_LANG_EXT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, DVD_AUDIO_LANG_EXT*, int> GetDefaultAudioLanguage;

        [NativeTypeName("HRESULT (LCID *, DVD_SUBPICTURE_LANG_EXT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, DVD_SUBPICTURE_LANG_EXT*, int> GetDefaultSubpictureLanguage;

        [NativeTypeName("HRESULT (DVD_DECODER_CAPS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DVD_DECODER_CAPS*, int> GetDecoderCaps;

        [NativeTypeName("HRESULT (ULONG, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, RECT*, int> GetButtonRect;

        [NativeTypeName("HRESULT (ULONG, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> IsSubpictureStreamEnabled;
    }
}
