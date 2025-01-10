// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
using static Silk.NET.Windows.SpeechPartOfSpeech;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3DA7627A-C7AE-4B23-8708-638C50362C25")]
[NativeTypeName("struct ISpeechLexicon : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechLexicon : ISpeechLexicon.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechLexicon));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechLexicon, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpeechLexicon, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechLexicon, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechLexicon, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechLexicon, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<ISpeechLexicon, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechLexicon,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_GenerationId([NativeTypeName("long *")] int* GenerationId)
    {
        return ((delegate* unmanaged<ISpeechLexicon, int*, int>)((*lpVtbl)[7]))(this, GenerationId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWords(
        SpeechLexiconType Flags,
        [NativeTypeName("long *")] int* GenerationID,
        ISpeechLexiconWords* Words
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechLexicon,
                SpeechLexiconType,
                int*,
                ISpeechLexiconWords*,
                int>)((*lpVtbl)[8])
        )(this, Flags, GenerationID, Words);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddPronunciation(
        [NativeTypeName("BSTR")] ushort* bstrWord,
        [NativeTypeName("SpeechLanguageId")] int LangId,
        SpeechPartOfSpeech PartOfSpeech = SPSUnknown,
        [NativeTypeName("BSTR")] ushort* bstrPronunciation = null
    )
    {
        return (
            (delegate* unmanaged<ISpeechLexicon, ushort*, int, SpeechPartOfSpeech, ushort*, int>)(
                (*lpVtbl)[9]
            )
        )(this, bstrWord, LangId, PartOfSpeech, bstrPronunciation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddPronunciationByPhoneIds(
        [NativeTypeName("BSTR")] ushort* bstrWord,
        [NativeTypeName("SpeechLanguageId")] int LangId,
        SpeechPartOfSpeech PartOfSpeech = SPSUnknown,
        VARIANT* PhoneIds = null
    )
    {
        return (
            (delegate* unmanaged<ISpeechLexicon, ushort*, int, SpeechPartOfSpeech, VARIANT*, int>)(
                (*lpVtbl)[10]
            )
        )(this, bstrWord, LangId, PartOfSpeech, PhoneIds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RemovePronunciation(
        [NativeTypeName("BSTR")] ushort* bstrWord,
        [NativeTypeName("SpeechLanguageId")] int LangId,
        SpeechPartOfSpeech PartOfSpeech = SPSUnknown,
        [NativeTypeName("BSTR")] ushort* bstrPronunciation = null
    )
    {
        return (
            (delegate* unmanaged<ISpeechLexicon, ushort*, int, SpeechPartOfSpeech, ushort*, int>)(
                (*lpVtbl)[11]
            )
        )(this, bstrWord, LangId, PartOfSpeech, bstrPronunciation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemovePronunciationByPhoneIds(
        [NativeTypeName("BSTR")] ushort* bstrWord,
        [NativeTypeName("SpeechLanguageId")] int LangId,
        SpeechPartOfSpeech PartOfSpeech = SPSUnknown,
        VARIANT* PhoneIds = null
    )
    {
        return (
            (delegate* unmanaged<ISpeechLexicon, ushort*, int, SpeechPartOfSpeech, VARIANT*, int>)(
                (*lpVtbl)[12]
            )
        )(this, bstrWord, LangId, PartOfSpeech, PhoneIds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetPronunciations(
        [NativeTypeName("BSTR")] ushort* bstrWord,
        [NativeTypeName("SpeechLanguageId")] int LangId,
        SpeechLexiconType TypeFlags,
        ISpeechLexiconPronunciations* ppPronunciations
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechLexicon,
                ushort*,
                int,
                SpeechLexiconType,
                ISpeechLexiconPronunciations*,
                int>)((*lpVtbl)[13])
        )(this, bstrWord, LangId, TypeFlags, ppPronunciations);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetGenerationChange(
        [NativeTypeName("long *")] int* GenerationID,
        ISpeechLexiconWords* ppWords
    )
    {
        return (
            (delegate* unmanaged<ISpeechLexicon, int*, ISpeechLexiconWords*, int>)((*lpVtbl)[14])
        )(this, GenerationID, ppWords);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_GenerationId([NativeTypeName("long *")] int* GenerationId);

        [VtblIndex(8)]
        HRESULT GetWords(
            SpeechLexiconType Flags,
            [NativeTypeName("long *")] int* GenerationID,
            ISpeechLexiconWords* Words
        );

        [VtblIndex(9)]
        HRESULT AddPronunciation(
            [NativeTypeName("BSTR")] ushort* bstrWord,
            [NativeTypeName("SpeechLanguageId")] int LangId,
            SpeechPartOfSpeech PartOfSpeech = SPSUnknown,
            [NativeTypeName("BSTR")] ushort* bstrPronunciation = null
        );

        [VtblIndex(10)]
        HRESULT AddPronunciationByPhoneIds(
            [NativeTypeName("BSTR")] ushort* bstrWord,
            [NativeTypeName("SpeechLanguageId")] int LangId,
            SpeechPartOfSpeech PartOfSpeech = SPSUnknown,
            VARIANT* PhoneIds = null
        );

        [VtblIndex(11)]
        HRESULT RemovePronunciation(
            [NativeTypeName("BSTR")] ushort* bstrWord,
            [NativeTypeName("SpeechLanguageId")] int LangId,
            SpeechPartOfSpeech PartOfSpeech = SPSUnknown,
            [NativeTypeName("BSTR")] ushort* bstrPronunciation = null
        );

        [VtblIndex(12)]
        HRESULT RemovePronunciationByPhoneIds(
            [NativeTypeName("BSTR")] ushort* bstrWord,
            [NativeTypeName("SpeechLanguageId")] int LangId,
            SpeechPartOfSpeech PartOfSpeech = SPSUnknown,
            VARIANT* PhoneIds = null
        );

        [VtblIndex(13)]
        HRESULT GetPronunciations(
            [NativeTypeName("BSTR")] ushort* bstrWord,
            [NativeTypeName("SpeechLanguageId")] int LangId,
            SpeechLexiconType TypeFlags,
            ISpeechLexiconPronunciations* ppPronunciations
        );

        [VtblIndex(14)]
        HRESULT GetGenerationChange(
            [NativeTypeName("long *")] int* GenerationID,
            ISpeechLexiconWords* ppWords
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_GenerationId;

        [NativeTypeName(
            "HRESULT (SpeechLexiconType, long *, ISpeechLexiconWords **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SpeechLexiconType,
            int*,
            ISpeechLexiconWords*,
            int> GetWords;

        [NativeTypeName(
            "HRESULT (BSTR, SpeechLanguageId, SpeechPartOfSpeech, BSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            SpeechPartOfSpeech,
            ushort*,
            int> AddPronunciation;

        [NativeTypeName(
            "HRESULT (BSTR, SpeechLanguageId, SpeechPartOfSpeech, VARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            SpeechPartOfSpeech,
            VARIANT*,
            int> AddPronunciationByPhoneIds;

        [NativeTypeName(
            "HRESULT (BSTR, SpeechLanguageId, SpeechPartOfSpeech, BSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            SpeechPartOfSpeech,
            ushort*,
            int> RemovePronunciation;

        [NativeTypeName(
            "HRESULT (BSTR, SpeechLanguageId, SpeechPartOfSpeech, VARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            SpeechPartOfSpeech,
            VARIANT*,
            int> RemovePronunciationByPhoneIds;

        [NativeTypeName(
            "HRESULT (BSTR, SpeechLanguageId, SpeechLexiconType, ISpeechLexiconPronunciations **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            SpeechLexiconType,
            ISpeechLexiconPronunciations*,
            int> GetPronunciations;

        [NativeTypeName("HRESULT (long *, ISpeechLexiconWords **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, ISpeechLexiconWords*, int> GetGenerationChange;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechLexicon"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechLexicon(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechLexicon"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechLexicon(Silk.NET.Windows.IDispatch value)
    {
        return new ISpeechLexicon(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechLexicon"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechLexicon"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISpeechLexicon value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechLexicon"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechLexicon(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechLexicon(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechLexicon"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechLexicon"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechLexicon value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
