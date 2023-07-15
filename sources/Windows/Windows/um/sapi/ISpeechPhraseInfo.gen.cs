// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo"]/*'/>
[Guid("961559CF-4E67-4662-8BF0-D93F1FCD61B3")]
[NativeTypeName("struct ISpeechPhraseInfo : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechPhraseInfo : ISpeechPhraseInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechPhraseInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, Guid*, void**, int> )(lpVtbl[0]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, uint> )(lpVtbl[1]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, uint> )(lpVtbl[2]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, uint*, int> )(lpVtbl[3]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_LanguageId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LanguageId([NativeTypeName("long *")] int* LanguageId)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, int*, int> )(lpVtbl[7]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), LanguageId);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_GrammarId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_GrammarId(VARIANT* GrammarId)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, VARIANT*, int> )(lpVtbl[8]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), GrammarId);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_StartTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_StartTime(VARIANT* StartTime)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, VARIANT*, int> )(lpVtbl[9]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), StartTime);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_AudioStreamPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AudioStreamPosition(VARIANT* AudioStreamPosition)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, VARIANT*, int> )(lpVtbl[10]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), AudioStreamPosition);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_AudioSizeBytes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_AudioSizeBytes([NativeTypeName("long *")] int* pAudioSizeBytes)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, int*, int> )(lpVtbl[11]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), pAudioSizeBytes);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_RetainedSizeBytes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RetainedSizeBytes([NativeTypeName("long *")] int* RetainedSizeBytes)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, int*, int> )(lpVtbl[12]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), RetainedSizeBytes);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_AudioSizeTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AudioSizeTime([NativeTypeName("long *")] int* AudioSizeTime)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, int*, int> )(lpVtbl[13]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), AudioSizeTime);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_Rule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Rule(ISpeechPhraseRule** Rule)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, ISpeechPhraseRule**, int> )(lpVtbl[14]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), Rule);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_Properties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Properties(ISpeechPhraseProperties** Properties)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, ISpeechPhraseProperties**, int> )(lpVtbl[15]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), Properties);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_Elements"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Elements(ISpeechPhraseElements** Elements)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, ISpeechPhraseElements**, int> )(lpVtbl[16]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), Elements);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_Replacements"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Replacements(ISpeechPhraseReplacements** Replacements)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, ISpeechPhraseReplacements**, int> )(lpVtbl[17]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), Replacements);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_EngineId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_EngineId([NativeTypeName("BSTR *")] ushort** EngineIdGuid)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, ushort**, int> )(lpVtbl[18]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), EngineIdGuid);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.get_EnginePrivateData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_EnginePrivateData(VARIANT* PrivateData)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, VARIANT*, int> )(lpVtbl[19]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), PrivateData);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.SaveToMemory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SaveToMemory(VARIANT* PhraseBlock)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, VARIANT*, int> )(lpVtbl[20]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), PhraseBlock);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.GetText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetText([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, [NativeTypeName("VARIANT_BOOL")] short UseReplacements, [NativeTypeName("BSTR *")] ushort** Text)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, int, int, short, ushort**, int> )(lpVtbl[21]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), StartElement, Elements, UseReplacements, Text);
    }

    /// <include file='ISpeechPhraseInfo.xml' path='doc/member[@name="ISpeechPhraseInfo.GetDisplayAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetDisplayAttributes([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, [NativeTypeName("VARIANT_BOOL")] short UseReplacements, SpeechDisplayAttributes* DisplayAttributes)
    {
        return ((delegate* unmanaged<ISpeechPhraseInfo*, int, int, short, SpeechDisplayAttributes*, int> )(lpVtbl[22]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), StartElement, Elements, UseReplacements, DisplayAttributes);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_LanguageId([NativeTypeName("long *")] int* LanguageId);
        [VtblIndex(8)]
        HRESULT get_GrammarId(VARIANT* GrammarId);
        [VtblIndex(9)]
        HRESULT get_StartTime(VARIANT* StartTime);
        [VtblIndex(10)]
        HRESULT get_AudioStreamPosition(VARIANT* AudioStreamPosition);
        [VtblIndex(11)]
        HRESULT get_AudioSizeBytes([NativeTypeName("long *")] int* pAudioSizeBytes);
        [VtblIndex(12)]
        HRESULT get_RetainedSizeBytes([NativeTypeName("long *")] int* RetainedSizeBytes);
        [VtblIndex(13)]
        HRESULT get_AudioSizeTime([NativeTypeName("long *")] int* AudioSizeTime);
        [VtblIndex(14)]
        HRESULT get_Rule(ISpeechPhraseRule** Rule);
        [VtblIndex(15)]
        HRESULT get_Properties(ISpeechPhraseProperties** Properties);
        [VtblIndex(16)]
        HRESULT get_Elements(ISpeechPhraseElements** Elements);
        [VtblIndex(17)]
        HRESULT get_Replacements(ISpeechPhraseReplacements** Replacements);
        [VtblIndex(18)]
        HRESULT get_EngineId([NativeTypeName("BSTR *")] ushort** EngineIdGuid);
        [VtblIndex(19)]
        HRESULT get_EnginePrivateData(VARIANT* PrivateData);
        [VtblIndex(20)]
        HRESULT SaveToMemory(VARIANT* PhraseBlock);
        [VtblIndex(21)]
        HRESULT GetText([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, [NativeTypeName("VARIANT_BOOL")] short UseReplacements, [NativeTypeName("BSTR *")] ushort** Text);
        [VtblIndex(22)]
        HRESULT GetDisplayAttributes([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, [NativeTypeName("VARIANT_BOOL")] short UseReplacements, SpeechDisplayAttributes* DisplayAttributes);
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
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LanguageId;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_GrammarId;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_StartTime;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_AudioStreamPosition;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_AudioSizeBytes;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_RetainedSizeBytes;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_AudioSizeTime;
        [NativeTypeName("HRESULT (ISpeechPhraseRule **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechPhraseRule**, int> get_Rule;
        [NativeTypeName("HRESULT (ISpeechPhraseProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechPhraseProperties**, int> get_Properties;
        [NativeTypeName("HRESULT (ISpeechPhraseElements **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechPhraseElements**, int> get_Elements;
        [NativeTypeName("HRESULT (ISpeechPhraseReplacements **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechPhraseReplacements**, int> get_Replacements;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_EngineId;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_EnginePrivateData;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> SaveToMemory;
        [NativeTypeName("HRESULT (long, long, VARIANT_BOOL, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, short, ushort**, int> GetText;
        [NativeTypeName("HRESULT (long, long, VARIANT_BOOL, SpeechDisplayAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, short, SpeechDisplayAttributes*, int> GetDisplayAttributes;
    }
}