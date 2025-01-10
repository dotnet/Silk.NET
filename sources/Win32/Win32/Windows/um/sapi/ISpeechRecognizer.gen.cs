// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2D5F1C0C-BD75-4B08-9478-3B11FEA2586C")]
[NativeTypeName("struct ISpeechRecognizer : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechRecognizer : ISpeechRecognizer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecognizer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpeechRecognizer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechRecognizer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
        )(this, iTInfo, lcid, ppTInfo);
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
            (delegate* unmanaged<ISpeechRecognizer, Guid*, ushort**, uint, uint, int*, int>)(
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
                ISpeechRecognizer,
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
    public HRESULT putref_Recognizer(ISpeechObjectToken Recognizer)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, ISpeechObjectToken, int>)((*lpVtbl)[7]))(
            this,
            Recognizer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Recognizer(ISpeechObjectToken* Recognizer)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, ISpeechObjectToken*, int>)((*lpVtbl)[8]))(
            this,
            Recognizer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AllowAudioInputFormatChangesOnNextSet(
        [NativeTypeName("VARIANT_BOOL")] short Allow
    )
    {
        return ((delegate* unmanaged<ISpeechRecognizer, short, int>)((*lpVtbl)[9]))(this, Allow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AllowAudioInputFormatChangesOnNextSet(
        [NativeTypeName("VARIANT_BOOL *")] short* Allow
    )
    {
        return ((delegate* unmanaged<ISpeechRecognizer, short*, int>)((*lpVtbl)[10]))(this, Allow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_AudioInput(ISpeechObjectToken AudioInput = default)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, ISpeechObjectToken, int>)((*lpVtbl)[11]))(
            this,
            AudioInput
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AudioInput(ISpeechObjectToken* AudioInput)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, ISpeechObjectToken*, int>)((*lpVtbl)[12]))(
            this,
            AudioInput
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_AudioInputStream(ISpeechBaseStream AudioInputStream = default)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, ISpeechBaseStream, int>)((*lpVtbl)[13]))(
            this,
            AudioInputStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_AudioInputStream(ISpeechBaseStream* AudioInputStream)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, ISpeechBaseStream*, int>)((*lpVtbl)[14]))(
            this,
            AudioInputStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsShared([NativeTypeName("VARIANT_BOOL *")] short* Shared)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, short*, int>)((*lpVtbl)[15]))(this, Shared);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_State(SpeechRecognizerState State)
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, SpeechRecognizerState, int>)((*lpVtbl)[16])
        )(this, State);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_State(SpeechRecognizerState* State)
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, SpeechRecognizerState*, int>)((*lpVtbl)[17])
        )(this, State);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Status(ISpeechRecognizerStatus* Status)
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, ISpeechRecognizerStatus*, int>)((*lpVtbl)[18])
        )(this, Status);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT putref_Profile(ISpeechObjectToken Profile = default)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, ISpeechObjectToken, int>)((*lpVtbl)[19]))(
            this,
            Profile
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Profile(ISpeechObjectToken* Profile)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, ISpeechObjectToken*, int>)((*lpVtbl)[20]))(
            this,
            Profile
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT EmulateRecognition(
        VARIANT TextElements,
        VARIANT* ElementDisplayAttributes = null,
        [NativeTypeName("long")] int LanguageId = 0
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, VARIANT, VARIANT*, int, int>)((*lpVtbl)[21])
        )(this, TextElements, ElementDisplayAttributes, LanguageId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateRecoContext(ISpeechRecoContext* NewContext)
    {
        return ((delegate* unmanaged<ISpeechRecognizer, ISpeechRecoContext*, int>)((*lpVtbl)[22]))(
            this,
            NewContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetFormat(SpeechFormatType Type, ISpeechAudioFormat* Format)
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, SpeechFormatType, ISpeechAudioFormat*, int>)(
                (*lpVtbl)[23]
            )
        )(this, Type, Format);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetPropertyNumber(
        [NativeTypeName("const BSTR")] ushort* Name,
        [NativeTypeName("long")] int Value,
        [NativeTypeName("VARIANT_BOOL *")] short* Supported
    )
    {
        return ((delegate* unmanaged<ISpeechRecognizer, ushort*, int, short*, int>)((*lpVtbl)[24]))(
            this,
            Name,
            Value,
            Supported
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetPropertyNumber(
        [NativeTypeName("const BSTR")] ushort* Name,
        [NativeTypeName("long *")] int* Value,
        [NativeTypeName("VARIANT_BOOL *")] short* Supported
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, ushort*, int*, short*, int>)((*lpVtbl)[25])
        )(this, Name, Value, Supported);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetPropertyString(
        [NativeTypeName("const BSTR")] ushort* Name,
        [NativeTypeName("const BSTR")] ushort* Value,
        [NativeTypeName("VARIANT_BOOL *")] short* Supported
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, ushort*, ushort*, short*, int>)((*lpVtbl)[26])
        )(this, Name, Value, Supported);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetPropertyString(
        [NativeTypeName("const BSTR")] ushort* Name,
        [NativeTypeName("BSTR *")] ushort** Value,
        [NativeTypeName("VARIANT_BOOL *")] short* Supported
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, ushort*, ushort**, short*, int>)((*lpVtbl)[27])
        )(this, Name, Value, Supported);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT IsUISupported(
        [NativeTypeName("const BSTR")] ushort* TypeOfUI,
        [NativeTypeName("const VARIANT *")] VARIANT* ExtraData,
        [NativeTypeName("VARIANT_BOOL *")] short* Supported
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, ushort*, VARIANT*, short*, int>)((*lpVtbl)[28])
        )(this, TypeOfUI, ExtraData, Supported);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT DisplayUI(
        [NativeTypeName("long")] int hWndParent,
        [NativeTypeName("BSTR")] ushort* Title,
        [NativeTypeName("const BSTR")] ushort* TypeOfUI,
        [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, int, ushort*, ushort*, VARIANT*, int>)(
                (*lpVtbl)[29]
            )
        )(this, hWndParent, Title, TypeOfUI, ExtraData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetRecognizers(
        [NativeTypeName("BSTR")] ushort* RequiredAttributes,
        [NativeTypeName("BSTR")] ushort* OptionalAttributes,
        ISpeechObjectTokens* ObjectTokens
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, ushort*, ushort*, ISpeechObjectTokens*, int>)(
                (*lpVtbl)[30]
            )
        )(this, RequiredAttributes, OptionalAttributes, ObjectTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetAudioInputs(
        [NativeTypeName("BSTR")] ushort* RequiredAttributes,
        [NativeTypeName("BSTR")] ushort* OptionalAttributes,
        ISpeechObjectTokens* ObjectTokens
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, ushort*, ushort*, ISpeechObjectTokens*, int>)(
                (*lpVtbl)[31]
            )
        )(this, RequiredAttributes, OptionalAttributes, ObjectTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetProfiles(
        [NativeTypeName("BSTR")] ushort* RequiredAttributes,
        [NativeTypeName("BSTR")] ushort* OptionalAttributes,
        ISpeechObjectTokens* ObjectTokens
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognizer, ushort*, ushort*, ISpeechObjectTokens*, int>)(
                (*lpVtbl)[32]
            )
        )(this, RequiredAttributes, OptionalAttributes, ObjectTokens);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_Recognizer(ISpeechObjectToken Recognizer);

        [VtblIndex(8)]
        HRESULT get_Recognizer(ISpeechObjectToken* Recognizer);

        [VtblIndex(9)]
        HRESULT put_AllowAudioInputFormatChangesOnNextSet(
            [NativeTypeName("VARIANT_BOOL")] short Allow
        );

        [VtblIndex(10)]
        HRESULT get_AllowAudioInputFormatChangesOnNextSet(
            [NativeTypeName("VARIANT_BOOL *")] short* Allow
        );

        [VtblIndex(11)]
        HRESULT putref_AudioInput(ISpeechObjectToken AudioInput = default);

        [VtblIndex(12)]
        HRESULT get_AudioInput(ISpeechObjectToken* AudioInput);

        [VtblIndex(13)]
        HRESULT putref_AudioInputStream(ISpeechBaseStream AudioInputStream = default);

        [VtblIndex(14)]
        HRESULT get_AudioInputStream(ISpeechBaseStream* AudioInputStream);

        [VtblIndex(15)]
        HRESULT get_IsShared([NativeTypeName("VARIANT_BOOL *")] short* Shared);

        [VtblIndex(16)]
        HRESULT put_State(SpeechRecognizerState State);

        [VtblIndex(17)]
        HRESULT get_State(SpeechRecognizerState* State);

        [VtblIndex(18)]
        HRESULT get_Status(ISpeechRecognizerStatus* Status);

        [VtblIndex(19)]
        HRESULT putref_Profile(ISpeechObjectToken Profile = default);

        [VtblIndex(20)]
        HRESULT get_Profile(ISpeechObjectToken* Profile);

        [VtblIndex(21)]
        HRESULT EmulateRecognition(
            VARIANT TextElements,
            VARIANT* ElementDisplayAttributes = null,
            [NativeTypeName("long")] int LanguageId = 0
        );

        [VtblIndex(22)]
        HRESULT CreateRecoContext(ISpeechRecoContext* NewContext);

        [VtblIndex(23)]
        HRESULT GetFormat(SpeechFormatType Type, ISpeechAudioFormat* Format);

        [VtblIndex(24)]
        HRESULT SetPropertyNumber(
            [NativeTypeName("const BSTR")] ushort* Name,
            [NativeTypeName("long")] int Value,
            [NativeTypeName("VARIANT_BOOL *")] short* Supported
        );

        [VtblIndex(25)]
        HRESULT GetPropertyNumber(
            [NativeTypeName("const BSTR")] ushort* Name,
            [NativeTypeName("long *")] int* Value,
            [NativeTypeName("VARIANT_BOOL *")] short* Supported
        );

        [VtblIndex(26)]
        HRESULT SetPropertyString(
            [NativeTypeName("const BSTR")] ushort* Name,
            [NativeTypeName("const BSTR")] ushort* Value,
            [NativeTypeName("VARIANT_BOOL *")] short* Supported
        );

        [VtblIndex(27)]
        HRESULT GetPropertyString(
            [NativeTypeName("const BSTR")] ushort* Name,
            [NativeTypeName("BSTR *")] ushort** Value,
            [NativeTypeName("VARIANT_BOOL *")] short* Supported
        );

        [VtblIndex(28)]
        HRESULT IsUISupported(
            [NativeTypeName("const BSTR")] ushort* TypeOfUI,
            [NativeTypeName("const VARIANT *")] VARIANT* ExtraData,
            [NativeTypeName("VARIANT_BOOL *")] short* Supported
        );

        [VtblIndex(29)]
        HRESULT DisplayUI(
            [NativeTypeName("long")] int hWndParent,
            [NativeTypeName("BSTR")] ushort* Title,
            [NativeTypeName("const BSTR")] ushort* TypeOfUI,
            [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null
        );

        [VtblIndex(30)]
        HRESULT GetRecognizers(
            [NativeTypeName("BSTR")] ushort* RequiredAttributes,
            [NativeTypeName("BSTR")] ushort* OptionalAttributes,
            ISpeechObjectTokens* ObjectTokens
        );

        [VtblIndex(31)]
        HRESULT GetAudioInputs(
            [NativeTypeName("BSTR")] ushort* RequiredAttributes,
            [NativeTypeName("BSTR")] ushort* OptionalAttributes,
            ISpeechObjectTokens* ObjectTokens
        );

        [VtblIndex(32)]
        HRESULT GetProfiles(
            [NativeTypeName("BSTR")] ushort* RequiredAttributes,
            [NativeTypeName("BSTR")] ushort* OptionalAttributes,
            ISpeechObjectTokens* ObjectTokens
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

        [NativeTypeName("HRESULT (ISpeechObjectToken *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechObjectToken, int> putref_Recognizer;

        [NativeTypeName("HRESULT (ISpeechObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechObjectToken*, int> get_Recognizer;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_AllowAudioInputFormatChangesOnNextSet;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_AllowAudioInputFormatChangesOnNextSet;

        [NativeTypeName("HRESULT (ISpeechObjectToken *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechObjectToken, int> putref_AudioInput;

        [NativeTypeName("HRESULT (ISpeechObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechObjectToken*, int> get_AudioInput;

        [NativeTypeName("HRESULT (ISpeechBaseStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechBaseStream, int> putref_AudioInputStream;

        [NativeTypeName("HRESULT (ISpeechBaseStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechBaseStream*, int> get_AudioInputStream;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsShared;

        [NativeTypeName("HRESULT (SpeechRecognizerState) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechRecognizerState, int> put_State;

        [NativeTypeName("HRESULT (SpeechRecognizerState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechRecognizerState*, int> get_State;

        [NativeTypeName("HRESULT (ISpeechRecognizerStatus **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechRecognizerStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ISpeechObjectToken *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechObjectToken, int> putref_Profile;

        [NativeTypeName("HRESULT (ISpeechObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechObjectToken*, int> get_Profile;

        [NativeTypeName("HRESULT (VARIANT, VARIANT *, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT*, int, int> EmulateRecognition;

        [NativeTypeName("HRESULT (ISpeechRecoContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechRecoContext*, int> CreateRecoContext;

        [NativeTypeName(
            "HRESULT (SpeechFormatType, ISpeechAudioFormat **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SpeechFormatType, ISpeechAudioFormat*, int> GetFormat;

        [NativeTypeName("HRESULT (const BSTR, long, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, short*, int> SetPropertyNumber;

        [NativeTypeName("HRESULT (const BSTR, long *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int*, short*, int> GetPropertyNumber;

        [NativeTypeName(
            "HRESULT (const BSTR, const BSTR, VARIANT_BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, short*, int> SetPropertyString;

        [NativeTypeName("HRESULT (const BSTR, BSTR *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, short*, int> GetPropertyString;

        [NativeTypeName(
            "HRESULT (const BSTR, const VARIANT *, VARIANT_BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, short*, int> IsUISupported;

        [NativeTypeName(
            "HRESULT (long, BSTR, const BSTR, const VARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, ushort*, ushort*, VARIANT*, int> DisplayUI;

        [NativeTypeName("HRESULT (BSTR, BSTR, ISpeechObjectTokens **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ISpeechObjectTokens*,
            int> GetRecognizers;

        [NativeTypeName("HRESULT (BSTR, BSTR, ISpeechObjectTokens **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ISpeechObjectTokens*,
            int> GetAudioInputs;

        [NativeTypeName("HRESULT (BSTR, BSTR, ISpeechObjectTokens **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ISpeechObjectTokens*, int> GetProfiles;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechRecognizer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechRecognizer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechRecognizer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechRecognizer(Silk.NET.Windows.IDispatch value)
    {
        return new ISpeechRecognizer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechRecognizer"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechRecognizer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISpeechRecognizer value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechRecognizer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechRecognizer(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechRecognizer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechRecognizer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechRecognizer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechRecognizer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
