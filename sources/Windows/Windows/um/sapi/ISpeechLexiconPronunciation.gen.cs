// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISpeechLexiconPronunciation.xml' path='doc/member[@name="ISpeechLexiconPronunciation"]/*'/>
[Guid("95252C5D-9E43-4F4A-9899-48EE73352F9F")]
[NativeTypeName("struct ISpeechLexiconPronunciation : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechLexiconPronunciation : ISpeechLexiconPronunciation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechLexiconPronunciation));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechLexiconPronunciation*, Guid*, void**, int> )(lpVtbl[0]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechLexiconPronunciation*, uint> )(lpVtbl[1]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechLexiconPronunciation*, uint> )(lpVtbl[2]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechLexiconPronunciation*, uint*, int> )(lpVtbl[3]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechLexiconPronunciation*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechLexiconPronunciation*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechLexiconPronunciation*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechLexiconPronunciation.xml' path='doc/member[@name="ISpeechLexiconPronunciation.get_Type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Type(SpeechLexiconType* LexiconType)
    {
        return ((delegate* unmanaged<ISpeechLexiconPronunciation*, SpeechLexiconType*, int> )(lpVtbl[7]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), LexiconType);
    }

    /// <include file='ISpeechLexiconPronunciation.xml' path='doc/member[@name="ISpeechLexiconPronunciation.get_LangId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LangId([NativeTypeName("SpeechLanguageId *")] int* LangId)
    {
        return ((delegate* unmanaged<ISpeechLexiconPronunciation*, int*, int> )(lpVtbl[8]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), LangId);
    }

    /// <include file='ISpeechLexiconPronunciation.xml' path='doc/member[@name="ISpeechLexiconPronunciation.get_PartOfSpeech"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PartOfSpeech(SpeechPartOfSpeech* PartOfSpeech)
    {
        return ((delegate* unmanaged<ISpeechLexiconPronunciation*, SpeechPartOfSpeech*, int> )(lpVtbl[9]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), PartOfSpeech);
    }

    /// <include file='ISpeechLexiconPronunciation.xml' path='doc/member[@name="ISpeechLexiconPronunciation.get_PhoneIds"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PhoneIds(VARIANT* PhoneIds)
    {
        return ((delegate* unmanaged<ISpeechLexiconPronunciation*, VARIANT*, int> )(lpVtbl[10]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), PhoneIds);
    }

    /// <include file='ISpeechLexiconPronunciation.xml' path='doc/member[@name="ISpeechLexiconPronunciation.get_Symbolic"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Symbolic([NativeTypeName("BSTR *")] ushort** Symbolic)
    {
        return ((delegate* unmanaged<ISpeechLexiconPronunciation*, ushort**, int> )(lpVtbl[11]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), Symbolic);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Type(SpeechLexiconType* LexiconType);
        [VtblIndex(8)]
        HRESULT get_LangId([NativeTypeName("SpeechLanguageId *")] int* LangId);
        [VtblIndex(9)]
        HRESULT get_PartOfSpeech(SpeechPartOfSpeech* PartOfSpeech);
        [VtblIndex(10)]
        HRESULT get_PhoneIds(VARIANT* PhoneIds);
        [VtblIndex(11)]
        HRESULT get_Symbolic([NativeTypeName("BSTR *")] ushort** Symbolic);
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
        [NativeTypeName("HRESULT (SpeechLexiconType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechLexiconType*, int> get_Type;
        [NativeTypeName("HRESULT (SpeechLanguageId *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LangId;
        [NativeTypeName("HRESULT (SpeechPartOfSpeech *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechPartOfSpeech*, int> get_PartOfSpeech;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_PhoneIds;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Symbolic;
    }
}