// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo"]/*' />
[Guid("A70EFE60-E2A3-11D0-A9BE-00AA0061BE93")]
[NativeTypeName("struct IDvdInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDvdInfo : IDvdInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDvdInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDvdInfo*, Guid*, void**, int>)(lpVtbl[0]))((IDvdInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDvdInfo*, uint>)(lpVtbl[1]))((IDvdInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDvdInfo*, uint>)(lpVtbl[2]))((IDvdInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetCurrentDomain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrentDomain(DVD_DOMAIN* pDomain)
    {
        return ((delegate* unmanaged<IDvdInfo*, DVD_DOMAIN*, int>)(lpVtbl[3]))((IDvdInfo*)Unsafe.AsPointer(ref this), pDomain);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetCurrentLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurrentLocation(DVD_PLAYBACK_LOCATION* pLocation)
    {
        return ((delegate* unmanaged<IDvdInfo*, DVD_PLAYBACK_LOCATION*, int>)(lpVtbl[4]))((IDvdInfo*)Unsafe.AsPointer(ref this), pLocation);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetTotalTitleTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTotalTitleTime([NativeTypeName("ULONG *")] uint* pulTotalTime)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint*, int>)(lpVtbl[5]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulTotalTime);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetCurrentButton"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentButton([NativeTypeName("ULONG *")] uint* pulButtonsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentButton)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint*, uint*, int>)(lpVtbl[6]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulButtonsAvailable, pulCurrentButton);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetCurrentAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentAngle([NativeTypeName("ULONG *")] uint* pulAnglesAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentAngle)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint*, uint*, int>)(lpVtbl[7]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulAnglesAvailable, pulCurrentAngle);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetCurrentAudio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCurrentAudio([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint*, uint*, int>)(lpVtbl[8]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulStreamsAvailable, pulCurrentStream);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetCurrentSubpicture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCurrentSubpicture([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream, BOOL* pIsDisabled)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint*, uint*, BOOL*, int>)(lpVtbl[9]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulStreamsAvailable, pulCurrentStream, pIsDisabled);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetCurrentUOPS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetCurrentUOPS([NativeTypeName("VALID_UOP_SOMTHING_OR_OTHER *")] uint* pUOP)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint*, int>)(lpVtbl[10]))((IDvdInfo*)Unsafe.AsPointer(ref this), pUOP);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetAllSPRMs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetAllSPRMs([NativeTypeName("SPRMARRAY *")] ushort** pRegisterArray)
    {
        return ((delegate* unmanaged<IDvdInfo*, ushort**, int>)(lpVtbl[11]))((IDvdInfo*)Unsafe.AsPointer(ref this), pRegisterArray);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetAllGPRMs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetAllGPRMs([NativeTypeName("GPRMARRAY *")] ushort** pRegisterArray)
    {
        return ((delegate* unmanaged<IDvdInfo*, ushort**, int>)(lpVtbl[12]))((IDvdInfo*)Unsafe.AsPointer(ref this), pRegisterArray);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetAudioLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetAudioLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint, uint*, int>)(lpVtbl[13]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulStream, pLanguage);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetSubpictureLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetSubpictureLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint, uint*, int>)(lpVtbl[14]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulStream, pLanguage);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetTitleAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetTitleAttributes([NativeTypeName("ULONG")] uint ulTitle, DVD_ATR* pATR)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint, DVD_ATR*, int>)(lpVtbl[15]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulTitle, pATR);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetVMGAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetVMGAttributes(DVD_ATR* pATR)
    {
        return ((delegate* unmanaged<IDvdInfo*, DVD_ATR*, int>)(lpVtbl[16]))((IDvdInfo*)Unsafe.AsPointer(ref this), pATR);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetCurrentVideoAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetCurrentVideoAttributes([NativeTypeName("DVD_VideoATR *")] byte** pATR)
    {
        return ((delegate* unmanaged<IDvdInfo*, byte**, int>)(lpVtbl[17]))((IDvdInfo*)Unsafe.AsPointer(ref this), pATR);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetCurrentAudioAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetCurrentAudioAttributes([NativeTypeName("DVD_AudioATR *")] byte** pATR)
    {
        return ((delegate* unmanaged<IDvdInfo*, byte**, int>)(lpVtbl[18]))((IDvdInfo*)Unsafe.AsPointer(ref this), pATR);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetCurrentSubpictureAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetCurrentSubpictureAttributes([NativeTypeName("DVD_SubpictureATR *")] byte** pATR)
    {
        return ((delegate* unmanaged<IDvdInfo*, byte**, int>)(lpVtbl[19]))((IDvdInfo*)Unsafe.AsPointer(ref this), pATR);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetCurrentVolumeInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetCurrentVolumeInfo([NativeTypeName("ULONG *")] uint* pulNumOfVol, [NativeTypeName("ULONG *")] uint* pulThisVolNum, DVD_DISC_SIDE* pSide, [NativeTypeName("ULONG *")] uint* pulNumOfTitles)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint*, uint*, DVD_DISC_SIDE*, uint*, int>)(lpVtbl[20]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulNumOfVol, pulThisVolNum, pSide, pulNumOfTitles);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetDVDTextInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetDVDTextInfo(byte* pTextManager, [NativeTypeName("ULONG")] uint ulBufSize, [NativeTypeName("ULONG *")] uint* pulActualSize)
    {
        return ((delegate* unmanaged<IDvdInfo*, byte*, uint, uint*, int>)(lpVtbl[21]))((IDvdInfo*)Unsafe.AsPointer(ref this), pTextManager, ulBufSize, pulActualSize);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetPlayerParentalLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetPlayerParentalLevel([NativeTypeName("ULONG *")] uint* pulParentalLevel, [NativeTypeName("ULONG *")] uint* pulCountryCode)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint*, uint*, int>)(lpVtbl[22]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulParentalLevel, pulCountryCode);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetNumberOfChapters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetNumberOfChapters([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulNumberOfChapters)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint, uint*, int>)(lpVtbl[23]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulTitle, pulNumberOfChapters);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetTitleParentalLevels"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetTitleParentalLevels([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulParentalLevels)
    {
        return ((delegate* unmanaged<IDvdInfo*, uint, uint*, int>)(lpVtbl[24]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulTitle, pulParentalLevels);
    }

    /// <include file='IDvdInfo.xml' path='doc/member[@name="IDvdInfo.GetRoot"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetRoot([NativeTypeName("LPSTR")] sbyte* pRoot, [NativeTypeName("ULONG")] uint ulBufSize, [NativeTypeName("ULONG *")] uint* pulActualSize)
    {
        return ((delegate* unmanaged<IDvdInfo*, sbyte*, uint, uint*, int>)(lpVtbl[25]))((IDvdInfo*)Unsafe.AsPointer(ref this), pRoot, ulBufSize, pulActualSize);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrentDomain(DVD_DOMAIN* pDomain);

        [VtblIndex(4)]
        HRESULT GetCurrentLocation(DVD_PLAYBACK_LOCATION* pLocation);

        [VtblIndex(5)]
        HRESULT GetTotalTitleTime([NativeTypeName("ULONG *")] uint* pulTotalTime);

        [VtblIndex(6)]
        HRESULT GetCurrentButton([NativeTypeName("ULONG *")] uint* pulButtonsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentButton);

        [VtblIndex(7)]
        HRESULT GetCurrentAngle([NativeTypeName("ULONG *")] uint* pulAnglesAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentAngle);

        [VtblIndex(8)]
        HRESULT GetCurrentAudio([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream);

        [VtblIndex(9)]
        HRESULT GetCurrentSubpicture([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream, BOOL* pIsDisabled);

        [VtblIndex(10)]
        HRESULT GetCurrentUOPS([NativeTypeName("VALID_UOP_SOMTHING_OR_OTHER *")] uint* pUOP);

        [VtblIndex(11)]
        HRESULT GetAllSPRMs([NativeTypeName("SPRMARRAY *")] ushort** pRegisterArray);

        [VtblIndex(12)]
        HRESULT GetAllGPRMs([NativeTypeName("GPRMARRAY *")] ushort** pRegisterArray);

        [VtblIndex(13)]
        HRESULT GetAudioLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage);

        [VtblIndex(14)]
        HRESULT GetSubpictureLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage);

        [VtblIndex(15)]
        HRESULT GetTitleAttributes([NativeTypeName("ULONG")] uint ulTitle, DVD_ATR* pATR);

        [VtblIndex(16)]
        HRESULT GetVMGAttributes(DVD_ATR* pATR);

        [VtblIndex(17)]
        HRESULT GetCurrentVideoAttributes([NativeTypeName("DVD_VideoATR *")] byte** pATR);

        [VtblIndex(18)]
        HRESULT GetCurrentAudioAttributes([NativeTypeName("DVD_AudioATR *")] byte** pATR);

        [VtblIndex(19)]
        HRESULT GetCurrentSubpictureAttributes([NativeTypeName("DVD_SubpictureATR *")] byte** pATR);

        [VtblIndex(20)]
        HRESULT GetCurrentVolumeInfo([NativeTypeName("ULONG *")] uint* pulNumOfVol, [NativeTypeName("ULONG *")] uint* pulThisVolNum, DVD_DISC_SIDE* pSide, [NativeTypeName("ULONG *")] uint* pulNumOfTitles);

        [VtblIndex(21)]
        HRESULT GetDVDTextInfo(byte* pTextManager, [NativeTypeName("ULONG")] uint ulBufSize, [NativeTypeName("ULONG *")] uint* pulActualSize);

        [VtblIndex(22)]
        HRESULT GetPlayerParentalLevel([NativeTypeName("ULONG *")] uint* pulParentalLevel, [NativeTypeName("ULONG *")] uint* pulCountryCode);

        [VtblIndex(23)]
        HRESULT GetNumberOfChapters([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulNumberOfChapters);

        [VtblIndex(24)]
        HRESULT GetTitleParentalLevels([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulParentalLevels);

        [VtblIndex(25)]
        HRESULT GetRoot([NativeTypeName("LPSTR")] sbyte* pRoot, [NativeTypeName("ULONG")] uint ulBufSize, [NativeTypeName("ULONG *")] uint* pulActualSize);
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

        [NativeTypeName("HRESULT (DVD_PLAYBACK_LOCATION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DVD_PLAYBACK_LOCATION*, int> GetCurrentLocation;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTotalTitleTime;

        [NativeTypeName("HRESULT (ULONG *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetCurrentButton;

        [NativeTypeName("HRESULT (ULONG *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetCurrentAngle;

        [NativeTypeName("HRESULT (ULONG *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetCurrentAudio;

        [NativeTypeName("HRESULT (ULONG *, ULONG *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, BOOL*, int> GetCurrentSubpicture;

        [NativeTypeName("HRESULT (VALID_UOP_SOMTHING_OR_OTHER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentUOPS;

        [NativeTypeName("HRESULT (SPRMARRAY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetAllSPRMs;

        [NativeTypeName("HRESULT (GPRMARRAY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetAllGPRMs;

        [NativeTypeName("HRESULT (ULONG, LCID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetAudioLanguage;

        [NativeTypeName("HRESULT (ULONG, LCID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetSubpictureLanguage;

        [NativeTypeName("HRESULT (ULONG, DVD_ATR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DVD_ATR*, int> GetTitleAttributes;

        [NativeTypeName("HRESULT (DVD_ATR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DVD_ATR*, int> GetVMGAttributes;

        [NativeTypeName("HRESULT (DVD_VideoATR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, int> GetCurrentVideoAttributes;

        [NativeTypeName("HRESULT (DVD_AudioATR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, int> GetCurrentAudioAttributes;

        [NativeTypeName("HRESULT (DVD_SubpictureATR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, int> GetCurrentSubpictureAttributes;

        [NativeTypeName("HRESULT (ULONG *, ULONG *, DVD_DISC_SIDE *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, DVD_DISC_SIDE*, uint*, int> GetCurrentVolumeInfo;

        [NativeTypeName("HRESULT (BYTE *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, uint*, int> GetDVDTextInfo;

        [NativeTypeName("HRESULT (ULONG *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetPlayerParentalLevel;

        [NativeTypeName("HRESULT (ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetNumberOfChapters;

        [NativeTypeName("HRESULT (ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetTitleParentalLevels;

        [NativeTypeName("HRESULT (LPSTR, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, uint, uint*, int> GetRoot;
    }
}
