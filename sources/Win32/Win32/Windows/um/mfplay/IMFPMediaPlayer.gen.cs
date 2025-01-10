// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A714590A-58AF-430A-85BF-44F5EC838D85")]
[NativeTypeName("struct IMFPMediaPlayer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFPMediaPlayer : IMFPMediaPlayer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFPMediaPlayer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFPMediaPlayer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Play()
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FrameStep()
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPosition(
        [NativeTypeName("const GUID &")] Guid* guidPositionType,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvPositionValue
    )
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, Guid*, PROPVARIANT*, int>)((*lpVtbl)[7]))(
            this,
            guidPositionType,
            pvPositionValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPosition(
        [NativeTypeName("const GUID &")] Guid* guidPositionType,
        PROPVARIANT* pvPositionValue
    )
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, Guid*, PROPVARIANT*, int>)((*lpVtbl)[8]))(
            this,
            guidPositionType,
            pvPositionValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDuration(
        [NativeTypeName("const GUID &")] Guid* guidPositionType,
        PROPVARIANT* pvDurationValue
    )
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, Guid*, PROPVARIANT*, int>)((*lpVtbl)[9]))(
            this,
            guidPositionType,
            pvDurationValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetRate(float flRate)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, float, int>)((*lpVtbl)[10]))(this, flRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetRate(float* pflRate)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, float*, int>)((*lpVtbl)[11]))(this, pflRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetSupportedRates(
        BOOL fForwardDirection,
        float* pflSlowestRate,
        float* pflFastestRate
    )
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, BOOL, float*, float*, int>)((*lpVtbl)[12]))(
            this,
            fForwardDirection,
            pflSlowestRate,
            pflFastestRate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetState(MFP_MEDIAPLAYER_STATE* peState)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, MFP_MEDIAPLAYER_STATE*, int>)((*lpVtbl)[13]))(
            this,
            peState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateMediaItemFromURL(
        [NativeTypeName("LPCWSTR")] ushort* pwszURL,
        BOOL fSync,
        [NativeTypeName("DWORD_PTR")] nuint dwUserData,
        IMFPMediaItem* ppMediaItem
    )
    {
        return (
            (delegate* unmanaged<IMFPMediaPlayer, ushort*, BOOL, nuint, IMFPMediaItem*, int>)(
                (*lpVtbl)[14]
            )
        )(this, pwszURL, fSync, dwUserData, ppMediaItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateMediaItemFromObject(
        IUnknown pIUnknownObj,
        BOOL fSync,
        [NativeTypeName("DWORD_PTR")] nuint dwUserData,
        IMFPMediaItem* ppMediaItem
    )
    {
        return (
            (delegate* unmanaged<IMFPMediaPlayer, IUnknown, BOOL, nuint, IMFPMediaItem*, int>)(
                (*lpVtbl)[15]
            )
        )(this, pIUnknownObj, fSync, dwUserData, ppMediaItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetMediaItem(IMFPMediaItem pIMFPMediaItem)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, IMFPMediaItem, int>)((*lpVtbl)[16]))(
            this,
            pIMFPMediaItem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ClearMediaItem()
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, int>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetMediaItem(IMFPMediaItem* ppIMFPMediaItem)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, IMFPMediaItem*, int>)((*lpVtbl)[18]))(
            this,
            ppIMFPMediaItem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetVolume(float* pflVolume)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, float*, int>)((*lpVtbl)[19]))(
            this,
            pflVolume
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetVolume(float flVolume)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, float, int>)((*lpVtbl)[20]))(this, flVolume);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetBalance(float* pflBalance)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, float*, int>)((*lpVtbl)[21]))(
            this,
            pflBalance
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetBalance(float flBalance)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, float, int>)((*lpVtbl)[22]))(this, flBalance);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetMute(BOOL* pfMute)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, BOOL*, int>)((*lpVtbl)[23]))(this, pfMute);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetMute(BOOL fMute)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, BOOL, int>)((*lpVtbl)[24]))(this, fMute);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetNativeVideoSize(SIZE* pszVideo, SIZE* pszARVideo)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, SIZE*, SIZE*, int>)((*lpVtbl)[25]))(
            this,
            pszVideo,
            pszARVideo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetIdealVideoSize(SIZE* pszMin, SIZE* pszMax)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, SIZE*, SIZE*, int>)((*lpVtbl)[26]))(
            this,
            pszMin,
            pszMax
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetVideoSourceRect(
        [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pnrcSource
    )
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, MFVideoNormalizedRect*, int>)((*lpVtbl)[27]))(
            this,
            pnrcSource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetVideoSourceRect(MFVideoNormalizedRect* pnrcSource)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, MFVideoNormalizedRect*, int>)((*lpVtbl)[28]))(
            this,
            pnrcSource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetAspectRatioMode([NativeTypeName("DWORD")] uint dwAspectRatioMode)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, uint, int>)((*lpVtbl)[29]))(
            this,
            dwAspectRatioMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetAspectRatioMode([NativeTypeName("DWORD *")] uint* pdwAspectRatioMode)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, uint*, int>)((*lpVtbl)[30]))(
            this,
            pdwAspectRatioMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetVideoWindow(HWND* phwndVideo)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, HWND*, int>)((*lpVtbl)[31]))(
            this,
            phwndVideo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT UpdateVideo()
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, int>)((*lpVtbl)[32]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SetBorderColor(COLORREF Clr)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, COLORREF, int>)((*lpVtbl)[33]))(this, Clr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetBorderColor(COLORREF* pClr)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, COLORREF*, int>)((*lpVtbl)[34]))(this, pClr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT InsertEffect(IUnknown pEffect, BOOL fOptional)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, IUnknown, BOOL, int>)((*lpVtbl)[35]))(
            this,
            pEffect,
            fOptional
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT RemoveEffect(IUnknown pEffect)
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, IUnknown, int>)((*lpVtbl)[36]))(
            this,
            pEffect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT RemoveAllEffects()
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, int>)((*lpVtbl)[37]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFPMediaPlayer, int>)((*lpVtbl)[38]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Play();

        [VtblIndex(4)]
        HRESULT Pause();

        [VtblIndex(5)]
        HRESULT Stop();

        [VtblIndex(6)]
        HRESULT FrameStep();

        [VtblIndex(7)]
        HRESULT SetPosition(
            [NativeTypeName("const GUID &")] Guid* guidPositionType,
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvPositionValue
        );

        [VtblIndex(8)]
        HRESULT GetPosition(
            [NativeTypeName("const GUID &")] Guid* guidPositionType,
            PROPVARIANT* pvPositionValue
        );

        [VtblIndex(9)]
        HRESULT GetDuration(
            [NativeTypeName("const GUID &")] Guid* guidPositionType,
            PROPVARIANT* pvDurationValue
        );

        [VtblIndex(10)]
        HRESULT SetRate(float flRate);

        [VtblIndex(11)]
        HRESULT GetRate(float* pflRate);

        [VtblIndex(12)]
        HRESULT GetSupportedRates(
            BOOL fForwardDirection,
            float* pflSlowestRate,
            float* pflFastestRate
        );

        [VtblIndex(13)]
        HRESULT GetState(MFP_MEDIAPLAYER_STATE* peState);

        [VtblIndex(14)]
        HRESULT CreateMediaItemFromURL(
            [NativeTypeName("LPCWSTR")] ushort* pwszURL,
            BOOL fSync,
            [NativeTypeName("DWORD_PTR")] nuint dwUserData,
            IMFPMediaItem* ppMediaItem
        );

        [VtblIndex(15)]
        HRESULT CreateMediaItemFromObject(
            IUnknown pIUnknownObj,
            BOOL fSync,
            [NativeTypeName("DWORD_PTR")] nuint dwUserData,
            IMFPMediaItem* ppMediaItem
        );

        [VtblIndex(16)]
        HRESULT SetMediaItem(IMFPMediaItem pIMFPMediaItem);

        [VtblIndex(17)]
        HRESULT ClearMediaItem();

        [VtblIndex(18)]
        HRESULT GetMediaItem(IMFPMediaItem* ppIMFPMediaItem);

        [VtblIndex(19)]
        HRESULT GetVolume(float* pflVolume);

        [VtblIndex(20)]
        HRESULT SetVolume(float flVolume);

        [VtblIndex(21)]
        HRESULT GetBalance(float* pflBalance);

        [VtblIndex(22)]
        HRESULT SetBalance(float flBalance);

        [VtblIndex(23)]
        HRESULT GetMute(BOOL* pfMute);

        [VtblIndex(24)]
        HRESULT SetMute(BOOL fMute);

        [VtblIndex(25)]
        HRESULT GetNativeVideoSize(SIZE* pszVideo, SIZE* pszARVideo);

        [VtblIndex(26)]
        HRESULT GetIdealVideoSize(SIZE* pszMin, SIZE* pszMax);

        [VtblIndex(27)]
        HRESULT SetVideoSourceRect(
            [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pnrcSource
        );

        [VtblIndex(28)]
        HRESULT GetVideoSourceRect(MFVideoNormalizedRect* pnrcSource);

        [VtblIndex(29)]
        HRESULT SetAspectRatioMode([NativeTypeName("DWORD")] uint dwAspectRatioMode);

        [VtblIndex(30)]
        HRESULT GetAspectRatioMode([NativeTypeName("DWORD *")] uint* pdwAspectRatioMode);

        [VtblIndex(31)]
        HRESULT GetVideoWindow(HWND* phwndVideo);

        [VtblIndex(32)]
        HRESULT UpdateVideo();

        [VtblIndex(33)]
        HRESULT SetBorderColor(COLORREF Clr);

        [VtblIndex(34)]
        HRESULT GetBorderColor(COLORREF* pClr);

        [VtblIndex(35)]
        HRESULT InsertEffect(IUnknown pEffect, BOOL fOptional);

        [VtblIndex(36)]
        HRESULT RemoveEffect(IUnknown pEffect);

        [VtblIndex(37)]
        HRESULT RemoveAllEffects();

        [VtblIndex(38)]
        HRESULT Shutdown();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Play;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FrameStep;

        [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> SetPosition;

        [NativeTypeName("HRESULT (const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> GetPosition;

        [NativeTypeName("HRESULT (const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> GetDuration;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetRate;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetRate;

        [NativeTypeName("HRESULT (BOOL, float *, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, float*, float*, int> GetSupportedRates;

        [NativeTypeName("HRESULT (MFP_MEDIAPLAYER_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFP_MEDIAPLAYER_STATE*, int> GetState;

        [NativeTypeName(
            "HRESULT (LPCWSTR, BOOL, DWORD_PTR, IMFPMediaItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            BOOL,
            nuint,
            IMFPMediaItem*,
            int> CreateMediaItemFromURL;

        [NativeTypeName(
            "HRESULT (IUnknown *, BOOL, DWORD_PTR, IMFPMediaItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            BOOL,
            nuint,
            IMFPMediaItem*,
            int> CreateMediaItemFromObject;

        [NativeTypeName("HRESULT (IMFPMediaItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPMediaItem, int> SetMediaItem;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearMediaItem;

        [NativeTypeName("HRESULT (IMFPMediaItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPMediaItem*, int> GetMediaItem;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetVolume;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetVolume;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetBalance;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBalance;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetMute;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetMute;

        [NativeTypeName("HRESULT (SIZE *, SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, SIZE*, int> GetNativeVideoSize;

        [NativeTypeName("HRESULT (SIZE *, SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, SIZE*, int> GetIdealVideoSize;

        [NativeTypeName("HRESULT (const MFVideoNormalizedRect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFVideoNormalizedRect*, int> SetVideoSourceRect;

        [NativeTypeName("HRESULT (MFVideoNormalizedRect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFVideoNormalizedRect*, int> GetVideoSourceRect;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetAspectRatioMode;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetAspectRatioMode;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetVideoWindow;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UpdateVideo;

        [NativeTypeName("HRESULT (COLORREF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF, int> SetBorderColor;

        [NativeTypeName("HRESULT (COLORREF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF*, int> GetBorderColor;

        [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, BOOL, int> InsertEffect;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> RemoveEffect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllEffects;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFPMediaPlayer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFPMediaPlayer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFPMediaPlayer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFPMediaPlayer(Silk.NET.Windows.IUnknown value)
    {
        return new IMFPMediaPlayer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFPMediaPlayer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFPMediaPlayer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFPMediaPlayer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
