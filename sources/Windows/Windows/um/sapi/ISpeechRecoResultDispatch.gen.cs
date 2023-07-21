// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch"]/*' />
[Guid("6D60EB64-ACED-40A6-BBF3-4E557F71DEE2")]
[NativeTypeName("struct ISpeechRecoResultDispatch : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechRecoResultDispatch : ISpeechRecoResultDispatch.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecoResultDispatch));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint>)(lpVtbl[1]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint>)(lpVtbl[2]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint*, int>)(lpVtbl[3]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.get_RecoContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RecoContext(ISpeechRecoContext** RecoContext)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechRecoContext**, int>)(lpVtbl[7]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), RecoContext);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.get_Times"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Times(ISpeechRecoResultTimes** Times)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechRecoResultTimes**, int>)(lpVtbl[8]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Times);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.putref_AudioFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_AudioFormat(ISpeechAudioFormat* Format)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechAudioFormat*, int>)(lpVtbl[9]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Format);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.get_AudioFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AudioFormat(ISpeechAudioFormat** Format)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechAudioFormat**, int>)(lpVtbl[10]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Format);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.get_PhraseInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PhraseInfo(ISpeechPhraseInfo** PhraseInfo)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechPhraseInfo**, int>)(lpVtbl[11]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), PhraseInfo);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.Alternates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Alternates([NativeTypeName("long")] int RequestCount, [NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, ISpeechPhraseAlternates** Alternates)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, int, ISpeechPhraseAlternates**, int>)(lpVtbl[12]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), RequestCount, StartElement, Elements, Alternates);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.Audio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Audio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, ISpeechMemoryStream** Stream)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, ISpeechMemoryStream**, int>)(lpVtbl[13]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), StartElement, Elements, Stream);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.SpeakAudio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SpeakAudio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, SpeechVoiceSpeakFlags Flags, [NativeTypeName("long *")] int* StreamNumber)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, SpeechVoiceSpeakFlags, int*, int>)(lpVtbl[14]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), StartElement, Elements, Flags, StreamNumber);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.SaveToMemory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SaveToMemory(VARIANT* ResultBlock)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, VARIANT*, int>)(lpVtbl[15]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), ResultBlock);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.DiscardResultInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT DiscardResultInfo(SpeechDiscardType ValueTypes)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, SpeechDiscardType, int>)(lpVtbl[16]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), ValueTypes);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.GetXMLResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetXMLResult(SPXMLRESULTOPTIONS Options, [NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, SPXMLRESULTOPTIONS, ushort**, int>)(lpVtbl[17]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Options, pResult);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.GetXMLErrorInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetXMLErrorInfo([NativeTypeName("long *")] int* LineNumber, [NativeTypeName("BSTR *")] ushort** ScriptLine, [NativeTypeName("BSTR *")] ushort** Source, [NativeTypeName("BSTR *")] ushort** Description, HRESULT* ResultCode, [NativeTypeName("VARIANT_BOOL *")] short* IsError)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int*, ushort**, ushort**, ushort**, HRESULT*, short*, int>)(lpVtbl[18]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), LineNumber, ScriptLine, Source, Description, ResultCode, IsError);
    }

    /// <include file='ISpeechRecoResultDispatch.xml' path='doc/member[@name="ISpeechRecoResultDispatch.SetTextFeedback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetTextFeedback([NativeTypeName("BSTR")] ushort* Feedback, [NativeTypeName("VARIANT_BOOL")] short WasSuccessful)
    {
        return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ushort*, short, int>)(lpVtbl[19]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Feedback, WasSuccessful);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_RecoContext(ISpeechRecoContext** RecoContext);

        [VtblIndex(8)]
        HRESULT get_Times(ISpeechRecoResultTimes** Times);

        [VtblIndex(9)]
        HRESULT putref_AudioFormat(ISpeechAudioFormat* Format);

        [VtblIndex(10)]
        HRESULT get_AudioFormat(ISpeechAudioFormat** Format);

        [VtblIndex(11)]
        HRESULT get_PhraseInfo(ISpeechPhraseInfo** PhraseInfo);

        [VtblIndex(12)]
        HRESULT Alternates([NativeTypeName("long")] int RequestCount, [NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, ISpeechPhraseAlternates** Alternates);

        [VtblIndex(13)]
        HRESULT Audio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, ISpeechMemoryStream** Stream);

        [VtblIndex(14)]
        HRESULT SpeakAudio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, SpeechVoiceSpeakFlags Flags, [NativeTypeName("long *")] int* StreamNumber);

        [VtblIndex(15)]
        HRESULT SaveToMemory(VARIANT* ResultBlock);

        [VtblIndex(16)]
        HRESULT DiscardResultInfo(SpeechDiscardType ValueTypes);

        [VtblIndex(17)]
        HRESULT GetXMLResult(SPXMLRESULTOPTIONS Options, [NativeTypeName("BSTR *")] ushort** pResult);

        [VtblIndex(18)]
        HRESULT GetXMLErrorInfo([NativeTypeName("long *")] int* LineNumber, [NativeTypeName("BSTR *")] ushort** ScriptLine, [NativeTypeName("BSTR *")] ushort** Source, [NativeTypeName("BSTR *")] ushort** Description, HRESULT* ResultCode, [NativeTypeName("VARIANT_BOOL *")] short* IsError);

        [VtblIndex(19)]
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

        [NativeTypeName("HRESULT (SPXMLRESULTOPTIONS, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPXMLRESULTOPTIONS, ushort**, int> GetXMLResult;

        [NativeTypeName("HRESULT (long *, BSTR *, BSTR *, BSTR *, HRESULT *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, ushort**, ushort**, ushort**, HRESULT*, short*, int> GetXMLErrorInfo;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, int> SetTextFeedback;
    }
}
