// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AE39362B-45A8-4074-9B9E-CCF49AA2D0B6")]
[NativeTypeName("struct ISpXMLRecoResult : ISpRecoResult")]
[NativeInheritance("ISpRecoResult")]
public unsafe partial struct ISpXMLRecoResult : ISpXMLRecoResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpXMLRecoResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpXMLRecoResult, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpXMLRecoResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpXMLRecoResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPhrase(SPPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpXMLRecoResult, SPPHRASE**, int>)((*lpVtbl)[3]))(
            this,
            ppCoMemPhrase
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpXMLRecoResult, SPSERIALIZEDPHRASE**, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<ISpXMLRecoResult, uint, uint, BOOL, ushort**, byte*, int>)(
                (*lpVtbl)[5]
            )
        )(this, ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Discard([NativeTypeName("DWORD")] uint dwValueTypes)
    {
        return ((delegate* unmanaged<ISpXMLRecoResult, uint, int>)((*lpVtbl)[6]))(
            this,
            dwValueTypes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetResultTimes(SPRECORESULTTIMES* pTimes)
    {
        return ((delegate* unmanaged<ISpXMLRecoResult, SPRECORESULTTIMES*, int>)((*lpVtbl)[7]))(
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
            (delegate* unmanaged<ISpXMLRecoResult, uint, uint, uint, ISpPhraseAlt*, uint*, int>)(
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
            (delegate* unmanaged<ISpXMLRecoResult, uint, uint, ISpStreamFormat*, int>)((*lpVtbl)[9])
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
        return (
            (delegate* unmanaged<ISpXMLRecoResult, uint, uint, uint, uint*, int>)((*lpVtbl)[10])
        )(this, ulStartElement, cElements, dwFlags, pulStreamNumber);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Serialize(SPSERIALIZEDRESULT** ppCoMemSerializedResult)
    {
        return ((delegate* unmanaged<ISpXMLRecoResult, SPSERIALIZEDRESULT**, int>)((*lpVtbl)[11]))(
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
        return ((delegate* unmanaged<ISpXMLRecoResult, Guid*, WAVEFORMATEX*, int>)((*lpVtbl)[12]))(
            this,
            pAudioFormatId,
            pWaveFormatEx
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetRecoContext(ISpRecoContext* ppRecoContext)
    {
        return ((delegate* unmanaged<ISpXMLRecoResult, ISpRecoContext*, int>)((*lpVtbl)[13]))(
            this,
            ppRecoContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetXMLResult(
        [NativeTypeName("LPWSTR *")] ushort** ppszCoMemXMLResult,
        SPXMLRESULTOPTIONS Options
    )
    {
        return (
            (delegate* unmanaged<ISpXMLRecoResult, ushort**, SPXMLRESULTOPTIONS, int>)(
                (*lpVtbl)[14]
            )
        )(this, ppszCoMemXMLResult, Options);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetXMLErrorInfo(SPSEMANTICERRORINFO* pSemanticErrorInfo)
    {
        return ((delegate* unmanaged<ISpXMLRecoResult, SPSEMANTICERRORINFO*, int>)((*lpVtbl)[15]))(
            this,
            pSemanticErrorInfo
        );
    }

    public interface Interface : ISpRecoResult.Interface
    {
        [VtblIndex(14)]
        HRESULT GetXMLResult(
            [NativeTypeName("LPWSTR *")] ushort** ppszCoMemXMLResult,
            SPXMLRESULTOPTIONS Options
        );

        [VtblIndex(15)]
        HRESULT GetXMLErrorInfo(SPSEMANTICERRORINFO* pSemanticErrorInfo);
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

        [NativeTypeName("HRESULT (LPWSTR *, SPXMLRESULTOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, SPXMLRESULTOPTIONS, int> GetXMLResult;

        [NativeTypeName("HRESULT (SPSEMANTICERRORINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSEMANTICERRORINFO*, int> GetXMLErrorInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpXMLRecoResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpXMLRecoResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpRecoResult"/> to <see cref = "ISpXMLRecoResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpRecoResult"/> instance to be converted </param>
    public static explicit operator ISpXMLRecoResult(Silk.NET.Windows.ISpRecoResult value)
    {
        return new ISpXMLRecoResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpXMLRecoResult"/> to <see cref = "Silk.NET.Windows.ISpRecoResult"/>.</summary>
    /// <param name = "value">The <see cref = "ISpXMLRecoResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpRecoResult(ISpXMLRecoResult value)
    {
        return new Silk.NET.Windows.ISpRecoResult(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpPhrase"/> to <see cref = "ISpXMLRecoResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpPhrase"/> instance to be converted </param>
    public static explicit operator ISpXMLRecoResult(Silk.NET.Windows.ISpPhrase value)
    {
        return new ISpXMLRecoResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpXMLRecoResult"/> to <see cref = "Silk.NET.Windows.ISpPhrase"/>.</summary>
    /// <param name = "value">The <see cref = "ISpXMLRecoResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpPhrase(ISpXMLRecoResult value)
    {
        return new Silk.NET.Windows.ISpPhrase(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpXMLRecoResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpXMLRecoResult(Silk.NET.Windows.IUnknown value)
    {
        return new ISpXMLRecoResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpXMLRecoResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpXMLRecoResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpXMLRecoResult value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
