// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpeechRecoResult2.xml' path='doc/member[@name="ISpeechRecoResult2"]/*'/>
[Guid("8E0A246D-D3C8-45DE-8657-04290C458C3C")]
[NativeTypeName("struct ISpeechRecoResult2 : ISpeechRecoResult")]
[NativeInheritance("ISpeechRecoResult")]
public unsafe partial struct ISpeechRecoResult2 : ISpeechRecoResult2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecoResult2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, Guid*, void**, int> )(lpVtbl[0]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, uint> )(lpVtbl[1]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, uint> )(lpVtbl[2]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, uint*, int> )(lpVtbl[3]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "ISpeechRecoResult.get_RecoContext"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RecoContext(ISpeechRecoContext** RecoContext)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, ISpeechRecoContext**, int> )(lpVtbl[7]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), RecoContext);
    }

    /// <inheritdoc cref = "ISpeechRecoResult.get_Times"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Times(ISpeechRecoResultTimes** Times)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, ISpeechRecoResultTimes**, int> )(lpVtbl[8]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), Times);
    }

    /// <inheritdoc cref = "ISpeechRecoResult.putref_AudioFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_AudioFormat(ISpeechAudioFormat* Format)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, ISpeechAudioFormat*, int> )(lpVtbl[9]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), Format);
    }

    /// <inheritdoc cref = "ISpeechRecoResult.get_AudioFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AudioFormat(ISpeechAudioFormat** Format)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, ISpeechAudioFormat**, int> )(lpVtbl[10]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), Format);
    }

    /// <inheritdoc cref = "ISpeechRecoResult.get_PhraseInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PhraseInfo(ISpeechPhraseInfo** PhraseInfo)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, ISpeechPhraseInfo**, int> )(lpVtbl[11]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), PhraseInfo);
    }

    /// <inheritdoc cref = "ISpeechRecoResult.Alternates"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Alternates([NativeTypeName("long")] int RequestCount, [NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, ISpeechPhraseAlternates** Alternates)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, int, int, int, ISpeechPhraseAlternates**, int> )(lpVtbl[12]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), RequestCount, StartElement, Elements, Alternates);
    }

    /// <inheritdoc cref = "ISpeechRecoResult.Audio"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Audio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, ISpeechMemoryStream** Stream)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, int, int, ISpeechMemoryStream**, int> )(lpVtbl[13]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), StartElement, Elements, Stream);
    }

    /// <inheritdoc cref = "ISpeechRecoResult.SpeakAudio"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SpeakAudio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, SpeechVoiceSpeakFlags Flags, [NativeTypeName("long *")] int* StreamNumber)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, int, int, SpeechVoiceSpeakFlags, int*, int> )(lpVtbl[14]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), StartElement, Elements, Flags, StreamNumber);
    }

    /// <inheritdoc cref = "ISpeechRecoResult.SaveToMemory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SaveToMemory(VARIANT* ResultBlock)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, VARIANT*, int> )(lpVtbl[15]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), ResultBlock);
    }

    /// <inheritdoc cref = "ISpeechRecoResult.DiscardResultInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT DiscardResultInfo(SpeechDiscardType ValueTypes)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, SpeechDiscardType, int> )(lpVtbl[16]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), ValueTypes);
    }

    /// <include file='ISpeechRecoResult2.xml' path='doc/member[@name="ISpeechRecoResult2.SetTextFeedback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetTextFeedback([NativeTypeName("BSTR")] ushort* Feedback, [NativeTypeName("VARIANT_BOOL")] short WasSuccessful)
    {
        return ((delegate* unmanaged<ISpeechRecoResult2*, ushort*, short, int> )(lpVtbl[17]))((ISpeechRecoResult2*)Unsafe.AsPointer(ref this), Feedback, WasSuccessful);
    }

    public interface Interface : ISpeechRecoResult.Interface
    {
        [VtblIndex(17)]
        HRESULT SetTextFeedback([NativeTypeName("BSTR")] ushort* Feedback, [NativeTypeName("VARIANT_BOOL")] short WasSuccessful);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (ISpeechRecoContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechRecoContext**, int> get_RecoContext;
        [NativeTypeName("HRESULT (ISpeechRecoResultTimes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechRecoResultTimes**, int> get_Times;
        [NativeTypeName("HRESULT (ISpeechAudioFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechAudioFormat*, int> putref_AudioFormat;
        [NativeTypeName("HRESULT (ISpeechAudioFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechAudioFormat**, int> get_AudioFormat;
        [NativeTypeName("HRESULT (ISpeechPhraseInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechPhraseInfo**, int> get_PhraseInfo;
        [NativeTypeName("HRESULT (long, long, long, ISpeechPhraseAlternates **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, ISpeechPhraseAlternates**, int> Alternates;
        [NativeTypeName("HRESULT (long, long, ISpeechMemoryStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, ISpeechMemoryStream**, int> Audio;
        [NativeTypeName("HRESULT (long, long, SpeechVoiceSpeakFlags, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, SpeechVoiceSpeakFlags, int*, int> SpeakAudio;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> SaveToMemory;
        [NativeTypeName("HRESULT (SpeechDiscardType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechDiscardType, int> DiscardResultInfo;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, int> SetTextFeedback;
    }
}