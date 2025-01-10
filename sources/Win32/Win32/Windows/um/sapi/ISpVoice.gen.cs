// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6C44DF74-72B9-4992-A1EC-EF996E0422D4")]
[NativeTypeName("struct ISpVoice : ISpEventSource")]
[NativeInheritance("ISpEventSource")]
public unsafe partial struct ISpVoice : ISpVoice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpVoice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpVoice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpVoice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpVoice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetNotifySink(ISpNotifySink pNotifySink)
    {
        return ((delegate* unmanaged<ISpVoice, ISpNotifySink, int>)((*lpVtbl)[3]))(
            this,
            pNotifySink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetNotifyWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<ISpVoice, HWND, uint, WPARAM, LPARAM, int>)((*lpVtbl)[4]))(
            this,
            hWnd,
            Msg,
            wParam,
            lParam
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetNotifyCallbackFunction(
        [NativeTypeName("SPNOTIFYCALLBACK *")]
            delegate* unmanaged<WPARAM, LPARAM, void> pfnCallback,
        WPARAM wParam,
        LPARAM lParam
    )
    {
        return (
            (delegate* unmanaged<
                ISpVoice,
                delegate* unmanaged<WPARAM, LPARAM, void>,
                WPARAM,
                LPARAM,
                int>)((*lpVtbl)[5])
        )(this, pfnCallback, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetNotifyCallbackInterface(
        ISpNotifyCallback* pSpCallback,
        WPARAM wParam,
        LPARAM lParam
    )
    {
        return (
            (delegate* unmanaged<ISpVoice, ISpNotifyCallback*, WPARAM, LPARAM, int>)((*lpVtbl)[6])
        )(this, pSpCallback, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetNotifyWin32Event()
    {
        return ((delegate* unmanaged<ISpVoice, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
    {
        return ((delegate* unmanaged<ISpVoice, uint, int>)((*lpVtbl)[8]))(this, dwMilliseconds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HANDLE GetNotifyEventHandle()
    {
        return ((HANDLE)(((delegate* unmanaged<ISpVoice, void*>)((*lpVtbl)[9]))(this)));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetInterest(
        [NativeTypeName("ULONGLONG")] ulong ullEventInterest,
        [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest
    )
    {
        return ((delegate* unmanaged<ISpVoice, ulong, ulong, int>)((*lpVtbl)[10]))(
            this,
            ullEventInterest,
            ullQueuedInterest
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetEvents(
        [NativeTypeName("ULONG")] uint ulCount,
        SPEVENT* pEventArray,
        [NativeTypeName("ULONG *")] uint* pulFetched
    )
    {
        return ((delegate* unmanaged<ISpVoice, uint, SPEVENT*, uint*, int>)((*lpVtbl)[11]))(
            this,
            ulCount,
            pEventArray,
            pulFetched
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetInfo(SPEVENTSOURCEINFO* pInfo)
    {
        return ((delegate* unmanaged<ISpVoice, SPEVENTSOURCEINFO*, int>)((*lpVtbl)[12]))(
            this,
            pInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetOutput(IUnknown pUnkOutput, BOOL fAllowFormatChanges)
    {
        return ((delegate* unmanaged<ISpVoice, IUnknown, BOOL, int>)((*lpVtbl)[13]))(
            this,
            pUnkOutput,
            fAllowFormatChanges
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetOutputObjectToken(ISpObjectToken* ppObjectToken)
    {
        return ((delegate* unmanaged<ISpVoice, ISpObjectToken*, int>)((*lpVtbl)[14]))(
            this,
            ppObjectToken
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetOutputStream(ISpStreamFormat* ppStream)
    {
        return ((delegate* unmanaged<ISpVoice, ISpStreamFormat*, int>)((*lpVtbl)[15]))(
            this,
            ppStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<ISpVoice, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<ISpVoice, int>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetVoice(ISpObjectToken pToken)
    {
        return ((delegate* unmanaged<ISpVoice, ISpObjectToken, int>)((*lpVtbl)[18]))(this, pToken);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetVoice(ISpObjectToken* ppToken)
    {
        return ((delegate* unmanaged<ISpVoice, ISpObjectToken*, int>)((*lpVtbl)[19]))(
            this,
            ppToken
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT Speak(
        [NativeTypeName("LPCWSTR")] ushort* pwcs,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("ULONG *")] uint* pulStreamNumber
    )
    {
        return ((delegate* unmanaged<ISpVoice, ushort*, uint, uint*, int>)((*lpVtbl)[20]))(
            this,
            pwcs,
            dwFlags,
            pulStreamNumber
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SpeakStream(
        IStream pStream,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("ULONG *")] uint* pulStreamNumber
    )
    {
        return ((delegate* unmanaged<ISpVoice, IStream, uint, uint*, int>)((*lpVtbl)[21]))(
            this,
            pStream,
            dwFlags,
            pulStreamNumber
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetStatus(
        SPVOICESTATUS* pStatus,
        [NativeTypeName("LPWSTR *")] ushort** ppszLastBookmark
    )
    {
        return ((delegate* unmanaged<ISpVoice, SPVOICESTATUS*, ushort**, int>)((*lpVtbl)[22]))(
            this,
            pStatus,
            ppszLastBookmark
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Skip(
        [NativeTypeName("LPCWSTR")] ushort* pItemType,
        [NativeTypeName("long")] int lNumItems,
        [NativeTypeName("ULONG *")] uint* pulNumSkipped
    )
    {
        return ((delegate* unmanaged<ISpVoice, ushort*, int, uint*, int>)((*lpVtbl)[23]))(
            this,
            pItemType,
            lNumItems,
            pulNumSkipped
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetPriority(SPVPRIORITY ePriority)
    {
        return ((delegate* unmanaged<ISpVoice, SPVPRIORITY, int>)((*lpVtbl)[24]))(this, ePriority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetPriority(SPVPRIORITY* pePriority)
    {
        return ((delegate* unmanaged<ISpVoice, SPVPRIORITY*, int>)((*lpVtbl)[25]))(
            this,
            pePriority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetAlertBoundary(SPEVENTENUM eBoundary)
    {
        return ((delegate* unmanaged<ISpVoice, SPEVENTENUM, int>)((*lpVtbl)[26]))(this, eBoundary);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetAlertBoundary(SPEVENTENUM* peBoundary)
    {
        return ((delegate* unmanaged<ISpVoice, SPEVENTENUM*, int>)((*lpVtbl)[27]))(
            this,
            peBoundary
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetRate([NativeTypeName("long")] int RateAdjust)
    {
        return ((delegate* unmanaged<ISpVoice, int, int>)((*lpVtbl)[28]))(this, RateAdjust);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetRate([NativeTypeName("long *")] int* pRateAdjust)
    {
        return ((delegate* unmanaged<ISpVoice, int*, int>)((*lpVtbl)[29]))(this, pRateAdjust);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetVolume(ushort usVolume)
    {
        return ((delegate* unmanaged<ISpVoice, ushort, int>)((*lpVtbl)[30]))(this, usVolume);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetVolume(ushort* pusVolume)
    {
        return ((delegate* unmanaged<ISpVoice, ushort*, int>)((*lpVtbl)[31]))(this, pusVolume);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT WaitUntilDone([NativeTypeName("ULONG")] uint msTimeout)
    {
        return ((delegate* unmanaged<ISpVoice, uint, int>)((*lpVtbl)[32]))(this, msTimeout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SetSyncSpeakTimeout([NativeTypeName("ULONG")] uint msTimeout)
    {
        return ((delegate* unmanaged<ISpVoice, uint, int>)((*lpVtbl)[33]))(this, msTimeout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetSyncSpeakTimeout([NativeTypeName("ULONG *")] uint* pmsTimeout)
    {
        return ((delegate* unmanaged<ISpVoice, uint*, int>)((*lpVtbl)[34]))(this, pmsTimeout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HANDLE SpeakCompleteEvent()
    {
        return ((HANDLE)(((delegate* unmanaged<ISpVoice, void*>)((*lpVtbl)[35]))(this)));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT IsUISupported(
        [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI,
        void* pvExtraData,
        [NativeTypeName("ULONG")] uint cbExtraData,
        BOOL* pfSupported
    )
    {
        return ((delegate* unmanaged<ISpVoice, ushort*, void*, uint, BOOL*, int>)((*lpVtbl)[36]))(
            this,
            pszTypeOfUI,
            pvExtraData,
            cbExtraData,
            pfSupported
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT DisplayUI(
        HWND hwndParent,
        [NativeTypeName("LPCWSTR")] ushort* pszTitle,
        [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI,
        void* pvExtraData,
        [NativeTypeName("ULONG")] uint cbExtraData
    )
    {
        return (
            (delegate* unmanaged<ISpVoice, HWND, ushort*, ushort*, void*, uint, int>)((*lpVtbl)[37])
        )(this, hwndParent, pszTitle, pszTypeOfUI, pvExtraData, cbExtraData);
    }

    public interface Interface : ISpEventSource.Interface
    {
        [VtblIndex(13)]
        HRESULT SetOutput(IUnknown pUnkOutput, BOOL fAllowFormatChanges);

        [VtblIndex(14)]
        HRESULT GetOutputObjectToken(ISpObjectToken* ppObjectToken);

        [VtblIndex(15)]
        HRESULT GetOutputStream(ISpStreamFormat* ppStream);

        [VtblIndex(16)]
        HRESULT Pause();

        [VtblIndex(17)]
        HRESULT Resume();

        [VtblIndex(18)]
        HRESULT SetVoice(ISpObjectToken pToken);

        [VtblIndex(19)]
        HRESULT GetVoice(ISpObjectToken* ppToken);

        [VtblIndex(20)]
        HRESULT Speak(
            [NativeTypeName("LPCWSTR")] ushort* pwcs,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("ULONG *")] uint* pulStreamNumber
        );

        [VtblIndex(21)]
        HRESULT SpeakStream(
            IStream pStream,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("ULONG *")] uint* pulStreamNumber
        );

        [VtblIndex(22)]
        HRESULT GetStatus(
            SPVOICESTATUS* pStatus,
            [NativeTypeName("LPWSTR *")] ushort** ppszLastBookmark
        );

        [VtblIndex(23)]
        HRESULT Skip(
            [NativeTypeName("LPCWSTR")] ushort* pItemType,
            [NativeTypeName("long")] int lNumItems,
            [NativeTypeName("ULONG *")] uint* pulNumSkipped
        );

        [VtblIndex(24)]
        HRESULT SetPriority(SPVPRIORITY ePriority);

        [VtblIndex(25)]
        HRESULT GetPriority(SPVPRIORITY* pePriority);

        [VtblIndex(26)]
        HRESULT SetAlertBoundary(SPEVENTENUM eBoundary);

        [VtblIndex(27)]
        HRESULT GetAlertBoundary(SPEVENTENUM* peBoundary);

        [VtblIndex(28)]
        HRESULT SetRate([NativeTypeName("long")] int RateAdjust);

        [VtblIndex(29)]
        HRESULT GetRate([NativeTypeName("long *")] int* pRateAdjust);

        [VtblIndex(30)]
        HRESULT SetVolume(ushort usVolume);

        [VtblIndex(31)]
        HRESULT GetVolume(ushort* pusVolume);

        [VtblIndex(32)]
        HRESULT WaitUntilDone([NativeTypeName("ULONG")] uint msTimeout);

        [VtblIndex(33)]
        HRESULT SetSyncSpeakTimeout([NativeTypeName("ULONG")] uint msTimeout);

        [VtblIndex(34)]
        HRESULT GetSyncSpeakTimeout([NativeTypeName("ULONG *")] uint* pmsTimeout);

        [VtblIndex(35)]
        HANDLE SpeakCompleteEvent();

        [VtblIndex(36)]
        HRESULT IsUISupported(
            [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI,
            void* pvExtraData,
            [NativeTypeName("ULONG")] uint cbExtraData,
            BOOL* pfSupported
        );

        [VtblIndex(37)]
        HRESULT DisplayUI(
            HWND hwndParent,
            [NativeTypeName("LPCWSTR")] ushort* pszTitle,
            [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI,
            void* pvExtraData,
            [NativeTypeName("ULONG")] uint cbExtraData
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

        [NativeTypeName("HRESULT (ISpNotifySink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpNotifySink, int> SetNotifySink;

        [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, WPARAM, LPARAM, int> SetNotifyWindowMessage;

        [NativeTypeName("HRESULT (SPNOTIFYCALLBACK *, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            delegate* unmanaged<WPARAM, LPARAM, void>,
            WPARAM,
            LPARAM,
            int> SetNotifyCallbackFunction;

        [NativeTypeName("HRESULT (ISpNotifyCallback *, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ISpNotifyCallback*,
            WPARAM,
            LPARAM,
            int> SetNotifyCallbackInterface;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetNotifyWin32Event;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> WaitForNotifyEvent;

        [NativeTypeName("HANDLE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetNotifyEventHandle;

        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong, int> SetInterest;

        [NativeTypeName("HRESULT (ULONG, SPEVENT *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SPEVENT*, uint*, int> GetEvents;

        [NativeTypeName("HRESULT (SPEVENTSOURCEINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPEVENTSOURCEINFO*, int> GetInfo;

        [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, BOOL, int> SetOutput;

        [NativeTypeName("HRESULT (ISpObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpObjectToken*, int> GetOutputObjectToken;

        [NativeTypeName("HRESULT (ISpStreamFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpStreamFormat*, int> GetOutputStream;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Resume;

        [NativeTypeName("HRESULT (ISpObjectToken *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpObjectToken, int> SetVoice;

        [NativeTypeName("HRESULT (ISpObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpObjectToken*, int> GetVoice;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint*, int> Speak;

        [NativeTypeName("HRESULT (IStream *, DWORD, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, uint, uint*, int> SpeakStream;

        [NativeTypeName("HRESULT (SPVOICESTATUS *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPVOICESTATUS*, ushort**, int> GetStatus;

        [NativeTypeName("HRESULT (LPCWSTR, long, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, uint*, int> Skip;

        [NativeTypeName("HRESULT (SPVPRIORITY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPVPRIORITY, int> SetPriority;

        [NativeTypeName("HRESULT (SPVPRIORITY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPVPRIORITY*, int> GetPriority;

        [NativeTypeName("HRESULT (SPEVENTENUM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPEVENTENUM, int> SetAlertBoundary;

        [NativeTypeName("HRESULT (SPEVENTENUM *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPEVENTENUM*, int> GetAlertBoundary;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetRate;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetRate;

        [NativeTypeName("HRESULT (USHORT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> SetVolume;

        [NativeTypeName("HRESULT (USHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetVolume;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> WaitUntilDone;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetSyncSpeakTimeout;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSyncSpeakTimeout;

        [NativeTypeName("HANDLE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> SpeakCompleteEvent;

        [NativeTypeName("HRESULT (LPCWSTR, void *, ULONG, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, void*, uint, BOOL*, int> IsUISupported;

        [NativeTypeName("HRESULT (HWND, LPCWSTR, LPCWSTR, void *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, ushort*, ushort*, void*, uint, int> DisplayUI;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpVoice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpVoice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpEventSource"/> to <see cref = "ISpVoice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpEventSource"/> instance to be converted </param>
    public static explicit operator ISpVoice(Silk.NET.Windows.ISpEventSource value)
    {
        return new ISpVoice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpVoice"/> to <see cref = "Silk.NET.Windows.ISpEventSource"/>.</summary>
    /// <param name = "value">The <see cref = "ISpVoice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpEventSource(ISpVoice value)
    {
        return new Silk.NET.Windows.ISpEventSource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpNotifySource"/> to <see cref = "ISpVoice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpNotifySource"/> instance to be converted </param>
    public static explicit operator ISpVoice(Silk.NET.Windows.ISpNotifySource value)
    {
        return new ISpVoice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpVoice"/> to <see cref = "Silk.NET.Windows.ISpNotifySource"/>.</summary>
    /// <param name = "value">The <see cref = "ISpVoice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpNotifySource(ISpVoice value)
    {
        return new Silk.NET.Windows.ISpNotifySource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpVoice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpVoice(Silk.NET.Windows.IUnknown value)
    {
        return new ISpVoice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpVoice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpVoice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpVoice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
