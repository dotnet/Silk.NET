// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpeechLexiconWord.xml' path='doc/member[@name="ISpeechLexiconWord"]/*'/>
[Guid("4E5B933C-C9BE-48ED-8842-1EE51BB1D4FF")]
[NativeTypeName("struct ISpeechLexiconWord : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechLexiconWord : ISpeechLexiconWord.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechLexiconWord));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechLexiconWord*, Guid*, void**, int> )(lpVtbl[0]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechLexiconWord*, uint> )(lpVtbl[1]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechLexiconWord*, uint> )(lpVtbl[2]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechLexiconWord*, uint*, int> )(lpVtbl[3]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechLexiconWord*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechLexiconWord*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechLexiconWord*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechLexiconWord.xml' path='doc/member[@name="ISpeechLexiconWord.get_LangId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LangId([NativeTypeName("SpeechLanguageId *")] int* LangId)
    {
        return ((delegate* unmanaged<ISpeechLexiconWord*, int*, int> )(lpVtbl[7]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), LangId);
    }

    /// <include file='ISpeechLexiconWord.xml' path='doc/member[@name="ISpeechLexiconWord.get_Type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Type(SpeechWordType* WordType)
    {
        return ((delegate* unmanaged<ISpeechLexiconWord*, SpeechWordType*, int> )(lpVtbl[8]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), WordType);
    }

    /// <include file='ISpeechLexiconWord.xml' path='doc/member[@name="ISpeechLexiconWord.get_Word"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Word([NativeTypeName("BSTR *")] ushort** Word)
    {
        return ((delegate* unmanaged<ISpeechLexiconWord*, ushort**, int> )(lpVtbl[9]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), Word);
    }

    /// <include file='ISpeechLexiconWord.xml' path='doc/member[@name="ISpeechLexiconWord.get_Pronunciations"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Pronunciations(ISpeechLexiconPronunciations** Pronunciations)
    {
        return ((delegate* unmanaged<ISpeechLexiconWord*, ISpeechLexiconPronunciations**, int> )(lpVtbl[10]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), Pronunciations);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_LangId([NativeTypeName("SpeechLanguageId *")] int* LangId);
        [VtblIndex(8)]
        HRESULT get_Type(SpeechWordType* WordType);
        [VtblIndex(9)]
        HRESULT get_Word([NativeTypeName("BSTR *")] ushort** Word);
        [VtblIndex(10)]
        HRESULT get_Pronunciations(ISpeechLexiconPronunciations** Pronunciations);
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
        [NativeTypeName("HRESULT (SpeechLanguageId *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LangId;
        [NativeTypeName("HRESULT (SpeechWordType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechWordType*, int> get_Type;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Word;
        [NativeTypeName("HRESULT (ISpeechLexiconPronunciations **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechLexiconPronunciations**, int> get_Pronunciations;
    }
}