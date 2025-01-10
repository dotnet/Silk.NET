// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F740A62F-7C15-489E-8234-940A33D9272D")]
[NativeTypeName("struct ISpRecoContext : ISpEventSource")]
[NativeInheritance("ISpEventSource")]
public unsafe partial struct ISpRecoContext : ISpRecoContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRecoContext));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRecoContext, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpRecoContext, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRecoContext, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetNotifySink(ISpNotifySink pNotifySink)
    {
        return ((delegate* unmanaged<ISpRecoContext, ISpNotifySink, int>)((*lpVtbl)[3]))(
            this,
            pNotifySink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetNotifyWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam)
    {
        return (
            (delegate* unmanaged<ISpRecoContext, HWND, uint, WPARAM, LPARAM, int>)((*lpVtbl)[4])
        )(this, hWnd, Msg, wParam, lParam);
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
                ISpRecoContext,
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
            (delegate* unmanaged<ISpRecoContext, ISpNotifyCallback*, WPARAM, LPARAM, int>)(
                (*lpVtbl)[6]
            )
        )(this, pSpCallback, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetNotifyWin32Event()
    {
        return ((delegate* unmanaged<ISpRecoContext, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
    {
        return ((delegate* unmanaged<ISpRecoContext, uint, int>)((*lpVtbl)[8]))(
            this,
            dwMilliseconds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HANDLE GetNotifyEventHandle()
    {
        return ((HANDLE)(((delegate* unmanaged<ISpRecoContext, void*>)((*lpVtbl)[9]))(this)));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetInterest(
        [NativeTypeName("ULONGLONG")] ulong ullEventInterest,
        [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest
    )
    {
        return ((delegate* unmanaged<ISpRecoContext, ulong, ulong, int>)((*lpVtbl)[10]))(
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
        return ((delegate* unmanaged<ISpRecoContext, uint, SPEVENT*, uint*, int>)((*lpVtbl)[11]))(
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
        return ((delegate* unmanaged<ISpRecoContext, SPEVENTSOURCEINFO*, int>)((*lpVtbl)[12]))(
            this,
            pInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetRecognizer(ISpRecognizer* ppRecognizer)
    {
        return ((delegate* unmanaged<ISpRecoContext, ISpRecognizer*, int>)((*lpVtbl)[13]))(
            this,
            ppRecognizer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateGrammar(
        [NativeTypeName("ULONGLONG")] ulong ullGrammarId,
        ISpRecoGrammar* ppGrammar
    )
    {
        return ((delegate* unmanaged<ISpRecoContext, ulong, ISpRecoGrammar*, int>)((*lpVtbl)[14]))(
            this,
            ullGrammarId,
            ppGrammar
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetStatus(SPRECOCONTEXTSTATUS* pStatus)
    {
        return ((delegate* unmanaged<ISpRecoContext, SPRECOCONTEXTSTATUS*, int>)((*lpVtbl)[15]))(
            this,
            pStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetMaxAlternates([NativeTypeName("ULONG *")] uint* pcAlternates)
    {
        return ((delegate* unmanaged<ISpRecoContext, uint*, int>)((*lpVtbl)[16]))(
            this,
            pcAlternates
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetMaxAlternates([NativeTypeName("ULONG")] uint cAlternates)
    {
        return ((delegate* unmanaged<ISpRecoContext, uint, int>)((*lpVtbl)[17]))(this, cAlternates);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetAudioOptions(
        SPAUDIOOPTIONS Options,
        [NativeTypeName("const GUID *")] Guid* pAudioFormatId,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx
    )
    {
        return (
            (delegate* unmanaged<ISpRecoContext, SPAUDIOOPTIONS, Guid*, WAVEFORMATEX*, int>)(
                (*lpVtbl)[18]
            )
        )(this, Options, pAudioFormatId, pWaveFormatEx);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetAudioOptions(
        SPAUDIOOPTIONS* pOptions,
        Guid* pAudioFormatId,
        WAVEFORMATEX** ppCoMemWFEX
    )
    {
        return (
            (delegate* unmanaged<ISpRecoContext, SPAUDIOOPTIONS*, Guid*, WAVEFORMATEX**, int>)(
                (*lpVtbl)[19]
            )
        )(this, pOptions, pAudioFormatId, ppCoMemWFEX);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT DeserializeResult(
        [NativeTypeName("const SPSERIALIZEDRESULT *")] SPSERIALIZEDRESULT* pSerializedResult,
        ISpRecoResult* ppResult
    )
    {
        return (
            (delegate* unmanaged<ISpRecoContext, SPSERIALIZEDRESULT*, ISpRecoResult*, int>)(
                (*lpVtbl)[20]
            )
        )(this, pSerializedResult, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT Bookmark(
        SPBOOKMARKOPTIONS Options,
        [NativeTypeName("ULONGLONG")] ulong ullStreamPosition,
        LPARAM lparamEvent
    )
    {
        return (
            (delegate* unmanaged<ISpRecoContext, SPBOOKMARKOPTIONS, ulong, LPARAM, int>)(
                (*lpVtbl)[21]
            )
        )(this, Options, ullStreamPosition, lparamEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetAdaptationData(
        [NativeTypeName("LPCWSTR")] ushort* pAdaptationData,
        [NativeTypeName("const ULONG")] uint cch
    )
    {
        return ((delegate* unmanaged<ISpRecoContext, ushort*, uint, int>)((*lpVtbl)[22]))(
            this,
            pAdaptationData,
            cch
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Pause([NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<ISpRecoContext, uint, int>)((*lpVtbl)[23]))(this, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT Resume([NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<ISpRecoContext, uint, int>)((*lpVtbl)[24]))(this, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetVoice(ISpVoice pVoice, BOOL fAllowFormatChanges)
    {
        return ((delegate* unmanaged<ISpRecoContext, ISpVoice, BOOL, int>)((*lpVtbl)[25]))(
            this,
            pVoice,
            fAllowFormatChanges
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetVoice(ISpVoice* ppVoice)
    {
        return ((delegate* unmanaged<ISpRecoContext, ISpVoice*, int>)((*lpVtbl)[26]))(
            this,
            ppVoice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetVoicePurgeEvent([NativeTypeName("ULONGLONG")] ulong ullEventInterest)
    {
        return ((delegate* unmanaged<ISpRecoContext, ulong, int>)((*lpVtbl)[27]))(
            this,
            ullEventInterest
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetVoicePurgeEvent([NativeTypeName("ULONGLONG *")] ulong* pullEventInterest)
    {
        return ((delegate* unmanaged<ISpRecoContext, ulong*, int>)((*lpVtbl)[28]))(
            this,
            pullEventInterest
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetContextState(SPCONTEXTSTATE eContextState)
    {
        return ((delegate* unmanaged<ISpRecoContext, SPCONTEXTSTATE, int>)((*lpVtbl)[29]))(
            this,
            eContextState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetContextState(SPCONTEXTSTATE* peContextState)
    {
        return ((delegate* unmanaged<ISpRecoContext, SPCONTEXTSTATE*, int>)((*lpVtbl)[30]))(
            this,
            peContextState
        );
    }

    public interface Interface : ISpEventSource.Interface
    {
        [VtblIndex(13)]
        HRESULT GetRecognizer(ISpRecognizer* ppRecognizer);

        [VtblIndex(14)]
        HRESULT CreateGrammar(
            [NativeTypeName("ULONGLONG")] ulong ullGrammarId,
            ISpRecoGrammar* ppGrammar
        );

        [VtblIndex(15)]
        HRESULT GetStatus(SPRECOCONTEXTSTATUS* pStatus);

        [VtblIndex(16)]
        HRESULT GetMaxAlternates([NativeTypeName("ULONG *")] uint* pcAlternates);

        [VtblIndex(17)]
        HRESULT SetMaxAlternates([NativeTypeName("ULONG")] uint cAlternates);

        [VtblIndex(18)]
        HRESULT SetAudioOptions(
            SPAUDIOOPTIONS Options,
            [NativeTypeName("const GUID *")] Guid* pAudioFormatId,
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx
        );

        [VtblIndex(19)]
        HRESULT GetAudioOptions(
            SPAUDIOOPTIONS* pOptions,
            Guid* pAudioFormatId,
            WAVEFORMATEX** ppCoMemWFEX
        );

        [VtblIndex(20)]
        HRESULT DeserializeResult(
            [NativeTypeName("const SPSERIALIZEDRESULT *")] SPSERIALIZEDRESULT* pSerializedResult,
            ISpRecoResult* ppResult
        );

        [VtblIndex(21)]
        HRESULT Bookmark(
            SPBOOKMARKOPTIONS Options,
            [NativeTypeName("ULONGLONG")] ulong ullStreamPosition,
            LPARAM lparamEvent
        );

        [VtblIndex(22)]
        HRESULT SetAdaptationData(
            [NativeTypeName("LPCWSTR")] ushort* pAdaptationData,
            [NativeTypeName("const ULONG")] uint cch
        );

        [VtblIndex(23)]
        HRESULT Pause([NativeTypeName("DWORD")] uint dwReserved);

        [VtblIndex(24)]
        HRESULT Resume([NativeTypeName("DWORD")] uint dwReserved);

        [VtblIndex(25)]
        HRESULT SetVoice(ISpVoice pVoice, BOOL fAllowFormatChanges);

        [VtblIndex(26)]
        HRESULT GetVoice(ISpVoice* ppVoice);

        [VtblIndex(27)]
        HRESULT SetVoicePurgeEvent([NativeTypeName("ULONGLONG")] ulong ullEventInterest);

        [VtblIndex(28)]
        HRESULT GetVoicePurgeEvent([NativeTypeName("ULONGLONG *")] ulong* pullEventInterest);

        [VtblIndex(29)]
        HRESULT SetContextState(SPCONTEXTSTATE eContextState);

        [VtblIndex(30)]
        HRESULT GetContextState(SPCONTEXTSTATE* peContextState);
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

        [NativeTypeName("HRESULT (ISpRecognizer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpRecognizer*, int> GetRecognizer;

        [NativeTypeName("HRESULT (ULONGLONG, ISpRecoGrammar **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ISpRecoGrammar*, int> CreateGrammar;

        [NativeTypeName("HRESULT (SPRECOCONTEXTSTATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPRECOCONTEXTSTATUS*, int> GetStatus;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaxAlternates;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetMaxAlternates;

        [NativeTypeName(
            "HRESULT (SPAUDIOOPTIONS, const GUID *, const WAVEFORMATEX *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SPAUDIOOPTIONS,
            Guid*,
            WAVEFORMATEX*,
            int> SetAudioOptions;

        [NativeTypeName(
            "HRESULT (SPAUDIOOPTIONS *, GUID *, WAVEFORMATEX **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SPAUDIOOPTIONS*,
            Guid*,
            WAVEFORMATEX**,
            int> GetAudioOptions;

        [NativeTypeName(
            "HRESULT (const SPSERIALIZEDRESULT *, ISpRecoResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SPSERIALIZEDRESULT*,
            ISpRecoResult*,
            int> DeserializeResult;

        [NativeTypeName("HRESULT (SPBOOKMARKOPTIONS, ULONGLONG, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPBOOKMARKOPTIONS, ulong, LPARAM, int> Bookmark;

        [NativeTypeName("HRESULT (LPCWSTR, const ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetAdaptationData;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Pause;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Resume;

        [NativeTypeName("HRESULT (ISpVoice *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpVoice, BOOL, int> SetVoice;

        [NativeTypeName("HRESULT (ISpVoice **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpVoice*, int> GetVoice;

        [NativeTypeName("HRESULT (ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> SetVoicePurgeEvent;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetVoicePurgeEvent;

        [NativeTypeName("HRESULT (SPCONTEXTSTATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPCONTEXTSTATE, int> SetContextState;

        [NativeTypeName("HRESULT (SPCONTEXTSTATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPCONTEXTSTATE*, int> GetContextState;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpRecoContext"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpRecoContext(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpEventSource"/> to <see cref = "ISpRecoContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpEventSource"/> instance to be converted </param>
    public static explicit operator ISpRecoContext(Silk.NET.Windows.ISpEventSource value)
    {
        return new ISpRecoContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRecoContext"/> to <see cref = "Silk.NET.Windows.ISpEventSource"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRecoContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpEventSource(ISpRecoContext value)
    {
        return new Silk.NET.Windows.ISpEventSource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpNotifySource"/> to <see cref = "ISpRecoContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpNotifySource"/> instance to be converted </param>
    public static explicit operator ISpRecoContext(Silk.NET.Windows.ISpNotifySource value)
    {
        return new ISpRecoContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRecoContext"/> to <see cref = "Silk.NET.Windows.ISpNotifySource"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRecoContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpNotifySource(ISpRecoContext value)
    {
        return new Silk.NET.Windows.ISpNotifySource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpRecoContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpRecoContext(Silk.NET.Windows.IUnknown value)
    {
        return new ISpRecoContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRecoContext"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRecoContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpRecoContext value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
