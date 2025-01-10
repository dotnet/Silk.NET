// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("27CAC6C4-88F2-41F2-8817-0C95E59F1E6E")]
[NativeTypeName("struct ISpRecoResult2 : ISpRecoResult")]
[NativeInheritance("ISpRecoResult")]
public unsafe partial struct ISpRecoResult2 : ISpRecoResult2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRecoResult2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRecoResult2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpRecoResult2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRecoResult2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPhrase(SPPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpRecoResult2, SPPHRASE**, int>)((*lpVtbl)[3]))(
            this,
            ppCoMemPhrase
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpRecoResult2, SPSERIALIZEDPHRASE**, int>)((*lpVtbl)[4]))(
            this,
            ppCoMemPhrase
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetText(
        [NativeTypeName("ULONG")] uint ulStart,
        [NativeTypeName("ULONG")] uint ulCount,
        BOOL fUseTextReplacements,
        [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText,
        byte* pbDisplayAttributes
    )
    {
        return (
            (delegate* unmanaged<ISpRecoResult2, uint, uint, BOOL, ushort**, byte*, int>)(
                (*lpVtbl)[5]
            )
        )(this, ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Discard([NativeTypeName("DWORD")] uint dwValueTypes)
    {
        return ((delegate* unmanaged<ISpRecoResult2, uint, int>)((*lpVtbl)[6]))(this, dwValueTypes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetResultTimes(SPRECORESULTTIMES* pTimes)
    {
        return ((delegate* unmanaged<ISpRecoResult2, SPRECORESULTTIMES*, int>)((*lpVtbl)[7]))(
            this,
            pTimes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAlternates(
        [NativeTypeName("ULONG")] uint ulStartElement,
        [NativeTypeName("ULONG")] uint cElements,
        [NativeTypeName("ULONG")] uint ulRequestCount,
        ISpPhraseAlt* ppPhrases,
        [NativeTypeName("ULONG *")] uint* pcPhrasesReturned
    )
    {
        return (
            (delegate* unmanaged<ISpRecoResult2, uint, uint, uint, ISpPhraseAlt*, uint*, int>)(
                (*lpVtbl)[8]
            )
        )(this, ulStartElement, cElements, ulRequestCount, ppPhrases, pcPhrasesReturned);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAudio(
        [NativeTypeName("ULONG")] uint ulStartElement,
        [NativeTypeName("ULONG")] uint cElements,
        ISpStreamFormat* ppStream
    )
    {
        return (
            (delegate* unmanaged<ISpRecoResult2, uint, uint, ISpStreamFormat*, int>)((*lpVtbl)[9])
        )(this, ulStartElement, cElements, ppStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SpeakAudio(
        [NativeTypeName("ULONG")] uint ulStartElement,
        [NativeTypeName("ULONG")] uint cElements,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("ULONG *")] uint* pulStreamNumber
    )
    {
        return ((delegate* unmanaged<ISpRecoResult2, uint, uint, uint, uint*, int>)((*lpVtbl)[10]))(
            this,
            ulStartElement,
            cElements,
            dwFlags,
            pulStreamNumber
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Serialize(SPSERIALIZEDRESULT** ppCoMemSerializedResult)
    {
        return ((delegate* unmanaged<ISpRecoResult2, SPSERIALIZEDRESULT**, int>)((*lpVtbl)[11]))(
            this,
            ppCoMemSerializedResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ScaleAudio(
        [NativeTypeName("const GUID *")] Guid* pAudioFormatId,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx
    )
    {
        return ((delegate* unmanaged<ISpRecoResult2, Guid*, WAVEFORMATEX*, int>)((*lpVtbl)[12]))(
            this,
            pAudioFormatId,
            pWaveFormatEx
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetRecoContext(ISpRecoContext* ppRecoContext)
    {
        return ((delegate* unmanaged<ISpRecoResult2, ISpRecoContext*, int>)((*lpVtbl)[13]))(
            this,
            ppRecoContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CommitAlternate(ISpPhraseAlt pPhraseAlt, ISpRecoResult* ppNewResult)
    {
        return (
            (delegate* unmanaged<ISpRecoResult2, ISpPhraseAlt, ISpRecoResult*, int>)((*lpVtbl)[14])
        )(this, pPhraseAlt, ppNewResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CommitText(
        [NativeTypeName("ULONG")] uint ulStartElement,
        [NativeTypeName("ULONG")] uint cElements,
        [NativeTypeName("LPCWSTR")] ushort* pszCorrectedData,
        [NativeTypeName("DWORD")] uint eCommitFlags
    )
    {
        return (
            (delegate* unmanaged<ISpRecoResult2, uint, uint, ushort*, uint, int>)((*lpVtbl)[15])
        )(this, ulStartElement, cElements, pszCorrectedData, eCommitFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetTextFeedback(
        [NativeTypeName("LPCWSTR")] ushort* pszFeedback,
        BOOL fSuccessful
    )
    {
        return ((delegate* unmanaged<ISpRecoResult2, ushort*, BOOL, int>)((*lpVtbl)[16]))(
            this,
            pszFeedback,
            fSuccessful
        );
    }

    public interface Interface : ISpRecoResult.Interface
    {
        [VtblIndex(14)]
        HRESULT CommitAlternate(ISpPhraseAlt pPhraseAlt, ISpRecoResult* ppNewResult);

        [VtblIndex(15)]
        HRESULT CommitText(
            [NativeTypeName("ULONG")] uint ulStartElement,
            [NativeTypeName("ULONG")] uint cElements,
            [NativeTypeName("LPCWSTR")] ushort* pszCorrectedData,
            [NativeTypeName("DWORD")] uint eCommitFlags
        );

        [VtblIndex(16)]
        HRESULT SetTextFeedback([NativeTypeName("LPCWSTR")] ushort* pszFeedback, BOOL fSuccessful);
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

        [NativeTypeName("HRESULT (SPPHRASE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPPHRASE**, int> GetPhrase;

        [NativeTypeName("HRESULT (SPSERIALIZEDPHRASE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSERIALIZEDPHRASE**, int> GetSerializedPhrase;

        [NativeTypeName("HRESULT (ULONG, ULONG, BOOL, LPWSTR *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, BOOL, ushort**, byte*, int> GetText;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Discard;

        [NativeTypeName("HRESULT (SPRECORESULTTIMES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPRECORESULTTIMES*, int> GetResultTimes;

        [NativeTypeName(
            "HRESULT (ULONG, ULONG, ULONG, ISpPhraseAlt **, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            ISpPhraseAlt*,
            uint*,
            int> GetAlternates;

        [NativeTypeName("HRESULT (ULONG, ULONG, ISpStreamFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ISpStreamFormat*, int> GetAudio;

        [NativeTypeName("HRESULT (ULONG, ULONG, DWORD, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, uint*, int> SpeakAudio;

        [NativeTypeName("HRESULT (SPSERIALIZEDRESULT **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSERIALIZEDRESULT**, int> Serialize;

        [NativeTypeName("HRESULT (const GUID *, const WAVEFORMATEX *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, WAVEFORMATEX*, int> ScaleAudio;

        [NativeTypeName("HRESULT (ISpRecoContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpRecoContext*, int> GetRecoContext;

        [NativeTypeName("HRESULT (ISpPhraseAlt *, ISpRecoResult **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpPhraseAlt, ISpRecoResult*, int> CommitAlternate;

        [NativeTypeName("HRESULT (ULONG, ULONG, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ushort*, uint, int> CommitText;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL, int> SetTextFeedback;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpRecoResult2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpRecoResult2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpRecoResult"/> to <see cref = "ISpRecoResult2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpRecoResult"/> instance to be converted </param>
    public static explicit operator ISpRecoResult2(Silk.NET.Windows.ISpRecoResult value)
    {
        return new ISpRecoResult2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRecoResult2"/> to <see cref = "Silk.NET.Windows.ISpRecoResult"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRecoResult2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpRecoResult(ISpRecoResult2 value)
    {
        return new Silk.NET.Windows.ISpRecoResult(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpPhrase"/> to <see cref = "ISpRecoResult2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpPhrase"/> instance to be converted </param>
    public static explicit operator ISpRecoResult2(Silk.NET.Windows.ISpPhrase value)
    {
        return new ISpRecoResult2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRecoResult2"/> to <see cref = "Silk.NET.Windows.ISpPhrase"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRecoResult2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpPhrase(ISpRecoResult2 value)
    {
        return new Silk.NET.Windows.ISpPhrase(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpRecoResult2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpRecoResult2(Silk.NET.Windows.IUnknown value)
    {
        return new ISpRecoResult2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRecoResult2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRecoResult2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpRecoResult2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
