// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpRecoResult.xml' path='doc/member[@name="ISpRecoResult"]/*'/>
[Guid("20B053BE-E235-43CD-9A2A-8D17A48B7842")]
[NativeTypeName("struct ISpRecoResult : ISpPhrase")]
[NativeInheritance("ISpPhrase")]
public unsafe partial struct ISpRecoResult : ISpRecoResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRecoResult));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRecoResult*, Guid*, void**, int> )(lpVtbl[0]))((ISpRecoResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpRecoResult*, uint> )(lpVtbl[1]))((ISpRecoResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRecoResult*, uint> )(lpVtbl[2]))((ISpRecoResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISpPhrase.GetPhrase"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPhrase(SPPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpRecoResult*, SPPHRASE**, int> )(lpVtbl[3]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
    }

    /// <inheritdoc cref = "ISpPhrase.GetSerializedPhrase"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpRecoResult*, SPSERIALIZEDPHRASE**, int> )(lpVtbl[4]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
    }

    /// <inheritdoc cref = "ISpPhrase.GetText"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetText([NativeTypeName("ULONG")] uint ulStart, [NativeTypeName("ULONG")] uint ulCount, BOOL fUseTextReplacements, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText, byte* pbDisplayAttributes)
    {
        return ((delegate* unmanaged<ISpRecoResult*, uint, uint, BOOL, ushort**, byte*, int> )(lpVtbl[5]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
    }

    /// <inheritdoc cref = "ISpPhrase.Discard"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Discard([NativeTypeName("DWORD")] uint dwValueTypes)
    {
        return ((delegate* unmanaged<ISpRecoResult*, uint, int> )(lpVtbl[6]))((ISpRecoResult*)Unsafe.AsPointer(ref this), dwValueTypes);
    }

    /// <include file='ISpRecoResult.xml' path='doc/member[@name="ISpRecoResult.GetResultTimes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetResultTimes(SPRECORESULTTIMES* pTimes)
    {
        return ((delegate* unmanaged<ISpRecoResult*, SPRECORESULTTIMES*, int> )(lpVtbl[7]))((ISpRecoResult*)Unsafe.AsPointer(ref this), pTimes);
    }

    /// <include file='ISpRecoResult.xml' path='doc/member[@name="ISpRecoResult.GetAlternates"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAlternates([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("ULONG")] uint ulRequestCount, ISpPhraseAlt** ppPhrases, [NativeTypeName("ULONG *")] uint* pcPhrasesReturned)
    {
        return ((delegate* unmanaged<ISpRecoResult*, uint, uint, uint, ISpPhraseAlt**, uint*, int> )(lpVtbl[8]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ulStartElement, cElements, ulRequestCount, ppPhrases, pcPhrasesReturned);
    }

    /// <include file='ISpRecoResult.xml' path='doc/member[@name="ISpRecoResult.GetAudio"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, ISpStreamFormat** ppStream)
    {
        return ((delegate* unmanaged<ISpRecoResult*, uint, uint, ISpStreamFormat**, int> )(lpVtbl[9]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ulStartElement, cElements, ppStream);
    }

    /// <include file='ISpRecoResult.xml' path='doc/member[@name="ISpRecoResult.SpeakAudio"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SpeakAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber)
    {
        return ((delegate* unmanaged<ISpRecoResult*, uint, uint, uint, uint*, int> )(lpVtbl[10]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ulStartElement, cElements, dwFlags, pulStreamNumber);
    }

    /// <include file='ISpRecoResult.xml' path='doc/member[@name="ISpRecoResult.Serialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Serialize(SPSERIALIZEDRESULT** ppCoMemSerializedResult)
    {
        return ((delegate* unmanaged<ISpRecoResult*, SPSERIALIZEDRESULT**, int> )(lpVtbl[11]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ppCoMemSerializedResult);
    }

    /// <include file='ISpRecoResult.xml' path='doc/member[@name="ISpRecoResult.ScaleAudio"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ScaleAudio([NativeTypeName("const GUID *")] Guid* pAudioFormatId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
    {
        return ((delegate* unmanaged<ISpRecoResult*, Guid*, WAVEFORMATEX*, int> )(lpVtbl[12]))((ISpRecoResult*)Unsafe.AsPointer(ref this), pAudioFormatId, pWaveFormatEx);
    }

    /// <include file='ISpRecoResult.xml' path='doc/member[@name="ISpRecoResult.GetRecoContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetRecoContext(ISpRecoContext** ppRecoContext)
    {
        return ((delegate* unmanaged<ISpRecoResult*, ISpRecoContext**, int> )(lpVtbl[13]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ppRecoContext);
    }

    public interface Interface : ISpPhrase.Interface
    {
        [VtblIndex(7)]
        HRESULT GetResultTimes(SPRECORESULTTIMES* pTimes);
        [VtblIndex(8)]
        HRESULT GetAlternates([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("ULONG")] uint ulRequestCount, ISpPhraseAlt** ppPhrases, [NativeTypeName("ULONG *")] uint* pcPhrasesReturned);
        [VtblIndex(9)]
        HRESULT GetAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, ISpStreamFormat** ppStream);
        [VtblIndex(10)]
        HRESULT SpeakAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber);
        [VtblIndex(11)]
        HRESULT Serialize(SPSERIALIZEDRESULT** ppCoMemSerializedResult);
        [VtblIndex(12)]
        HRESULT ScaleAudio([NativeTypeName("const GUID *")] Guid* pAudioFormatId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx);
        [VtblIndex(13)]
        HRESULT GetRecoContext(ISpRecoContext** ppRecoContext);
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
        [NativeTypeName("HRESULT (ULONG, ULONG, ULONG, ISpPhraseAlt **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, ISpPhraseAlt**, uint*, int> GetAlternates;
        [NativeTypeName("HRESULT (ULONG, ULONG, ISpStreamFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ISpStreamFormat**, int> GetAudio;
        [NativeTypeName("HRESULT (ULONG, ULONG, DWORD, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, uint*, int> SpeakAudio;
        [NativeTypeName("HRESULT (SPSERIALIZEDRESULT **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSERIALIZEDRESULT**, int> Serialize;
        [NativeTypeName("HRESULT (const GUID *, const WAVEFORMATEX *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, WAVEFORMATEX*, int> ScaleAudio;
        [NativeTypeName("HRESULT (ISpRecoContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpRecoContext**, int> GetRecoContext;
    }
}