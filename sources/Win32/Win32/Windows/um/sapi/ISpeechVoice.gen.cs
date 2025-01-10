// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("269316D8-57BD-11D2-9EEE-00C04F797396")]
[NativeTypeName("struct ISpeechVoice : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechVoice : ISpeechVoice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechVoice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechVoice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpeechVoice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechVoice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechVoice, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechVoice, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<ISpeechVoice, Guid*, ushort**, uint, uint, int*, int>)(
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
                ISpeechVoice,
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
    public HRESULT get_Status(ISpeechVoiceStatus* Status)
    {
        return ((delegate* unmanaged<ISpeechVoice, ISpeechVoiceStatus*, int>)((*lpVtbl)[7]))(
            this,
            Status
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Voice(ISpeechObjectToken* Voice)
    {
        return ((delegate* unmanaged<ISpeechVoice, ISpeechObjectToken*, int>)((*lpVtbl)[8]))(
            this,
            Voice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_Voice(ISpeechObjectToken Voice)
    {
        return ((delegate* unmanaged<ISpeechVoice, ISpeechObjectToken, int>)((*lpVtbl)[9]))(
            this,
            Voice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AudioOutput(ISpeechObjectToken* AudioOutput)
    {
        return ((delegate* unmanaged<ISpeechVoice, ISpeechObjectToken*, int>)((*lpVtbl)[10]))(
            this,
            AudioOutput
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_AudioOutput(ISpeechObjectToken AudioOutput)
    {
        return ((delegate* unmanaged<ISpeechVoice, ISpeechObjectToken, int>)((*lpVtbl)[11]))(
            this,
            AudioOutput
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AudioOutputStream(ISpeechBaseStream* AudioOutputStream)
    {
        return ((delegate* unmanaged<ISpeechVoice, ISpeechBaseStream*, int>)((*lpVtbl)[12]))(
            this,
            AudioOutputStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_AudioOutputStream(ISpeechBaseStream AudioOutputStream)
    {
        return ((delegate* unmanaged<ISpeechVoice, ISpeechBaseStream, int>)((*lpVtbl)[13]))(
            this,
            AudioOutputStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Rate([NativeTypeName("long *")] int* Rate)
    {
        return ((delegate* unmanaged<ISpeechVoice, int*, int>)((*lpVtbl)[14]))(this, Rate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Rate([NativeTypeName("long")] int Rate)
    {
        return ((delegate* unmanaged<ISpeechVoice, int, int>)((*lpVtbl)[15]))(this, Rate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Volume([NativeTypeName("long *")] int* Volume)
    {
        return ((delegate* unmanaged<ISpeechVoice, int*, int>)((*lpVtbl)[16]))(this, Volume);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Volume([NativeTypeName("long")] int Volume)
    {
        return ((delegate* unmanaged<ISpeechVoice, int, int>)((*lpVtbl)[17]))(this, Volume);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_AllowAudioOutputFormatChangesOnNextSet(
        [NativeTypeName("VARIANT_BOOL")] short Allow
    )
    {
        return ((delegate* unmanaged<ISpeechVoice, short, int>)((*lpVtbl)[18]))(this, Allow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_AllowAudioOutputFormatChangesOnNextSet(
        [NativeTypeName("VARIANT_BOOL *")] short* Allow
    )
    {
        return ((delegate* unmanaged<ISpeechVoice, short*, int>)((*lpVtbl)[19]))(this, Allow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_EventInterests(SpeechVoiceEvents* EventInterestFlags)
    {
        return ((delegate* unmanaged<ISpeechVoice, SpeechVoiceEvents*, int>)((*lpVtbl)[20]))(
            this,
            EventInterestFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_EventInterests(SpeechVoiceEvents EventInterestFlags)
    {
        return ((delegate* unmanaged<ISpeechVoice, SpeechVoiceEvents, int>)((*lpVtbl)[21]))(
            this,
            EventInterestFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_Priority(SpeechVoicePriority Priority)
    {
        return ((delegate* unmanaged<ISpeechVoice, SpeechVoicePriority, int>)((*lpVtbl)[22]))(
            this,
            Priority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Priority(SpeechVoicePriority* Priority)
    {
        return ((delegate* unmanaged<ISpeechVoice, SpeechVoicePriority*, int>)((*lpVtbl)[23]))(
            this,
            Priority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_AlertBoundary(SpeechVoiceEvents Boundary)
    {
        return ((delegate* unmanaged<ISpeechVoice, SpeechVoiceEvents, int>)((*lpVtbl)[24]))(
            this,
            Boundary
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_AlertBoundary(SpeechVoiceEvents* Boundary)
    {
        return ((delegate* unmanaged<ISpeechVoice, SpeechVoiceEvents*, int>)((*lpVtbl)[25]))(
            this,
            Boundary
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_SynchronousSpeakTimeout([NativeTypeName("long")] int msTimeout)
    {
        return ((delegate* unmanaged<ISpeechVoice, int, int>)((*lpVtbl)[26]))(this, msTimeout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_SynchronousSpeakTimeout([NativeTypeName("long *")] int* msTimeout)
    {
        return ((delegate* unmanaged<ISpeechVoice, int*, int>)((*lpVtbl)[27]))(this, msTimeout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT Speak(
        [NativeTypeName("BSTR")] ushort* Text,
        SpeechVoiceSpeakFlags Flags,
        [NativeTypeName("long *")] int* StreamNumber
    )
    {
        return (
            (delegate* unmanaged<ISpeechVoice, ushort*, SpeechVoiceSpeakFlags, int*, int>)(
                (*lpVtbl)[28]
            )
        )(this, Text, Flags, StreamNumber);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SpeakStream(
        ISpeechBaseStream Stream,
        SpeechVoiceSpeakFlags Flags,
        [NativeTypeName("long *")] int* StreamNumber
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechVoice,
                ISpeechBaseStream,
                SpeechVoiceSpeakFlags,
                int*,
                int>)((*lpVtbl)[29])
        )(this, Stream, Flags, StreamNumber);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<ISpeechVoice, int>)((*lpVtbl)[30]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<ISpeechVoice, int>)((*lpVtbl)[31]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT Skip(
        [NativeTypeName("const BSTR")] ushort* Type,
        [NativeTypeName("long")] int NumItems,
        [NativeTypeName("long *")] int* NumSkipped
    )
    {
        return ((delegate* unmanaged<ISpeechVoice, ushort*, int, int*, int>)((*lpVtbl)[32]))(
            this,
            Type,
            NumItems,
            NumSkipped
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetVoices(
        [NativeTypeName("BSTR")] ushort* RequiredAttributes,
        [NativeTypeName("BSTR")] ushort* OptionalAttributes,
        ISpeechObjectTokens* ObjectTokens
    )
    {
        return (
            (delegate* unmanaged<ISpeechVoice, ushort*, ushort*, ISpeechObjectTokens*, int>)(
                (*lpVtbl)[33]
            )
        )(this, RequiredAttributes, OptionalAttributes, ObjectTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetAudioOutputs(
        [NativeTypeName("BSTR")] ushort* RequiredAttributes,
        [NativeTypeName("BSTR")] ushort* OptionalAttributes,
        ISpeechObjectTokens* ObjectTokens
    )
    {
        return (
            (delegate* unmanaged<ISpeechVoice, ushort*, ushort*, ISpeechObjectTokens*, int>)(
                (*lpVtbl)[34]
            )
        )(this, RequiredAttributes, OptionalAttributes, ObjectTokens);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT WaitUntilDone(
        [NativeTypeName("long")] int msTimeout,
        [NativeTypeName("VARIANT_BOOL *")] short* Done
    )
    {
        return ((delegate* unmanaged<ISpeechVoice, int, short*, int>)((*lpVtbl)[35]))(
            this,
            msTimeout,
            Done
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT SpeakCompleteEvent([NativeTypeName("long *")] int* Handle)
    {
        return ((delegate* unmanaged<ISpeechVoice, int*, int>)((*lpVtbl)[36]))(this, Handle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT IsUISupported(
        [NativeTypeName("const BSTR")] ushort* TypeOfUI,
        [NativeTypeName("const VARIANT *")] VARIANT* ExtraData,
        [NativeTypeName("VARIANT_BOOL *")] short* Supported
    )
    {
        return ((delegate* unmanaged<ISpeechVoice, ushort*, VARIANT*, short*, int>)((*lpVtbl)[37]))(
            this,
            TypeOfUI,
            ExtraData,
            Supported
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT DisplayUI(
        [NativeTypeName("long")] int hWndParent,
        [NativeTypeName("BSTR")] ushort* Title,
        [NativeTypeName("const BSTR")] ushort* TypeOfUI,
        [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null
    )
    {
        return (
            (delegate* unmanaged<ISpeechVoice, int, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[38])
        )(this, hWndParent, Title, TypeOfUI, ExtraData);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Status(ISpeechVoiceStatus* Status);

        [VtblIndex(8)]
        HRESULT get_Voice(ISpeechObjectToken* Voice);

        [VtblIndex(9)]
        HRESULT putref_Voice(ISpeechObjectToken Voice);

        [VtblIndex(10)]
        HRESULT get_AudioOutput(ISpeechObjectToken* AudioOutput);

        [VtblIndex(11)]
        HRESULT putref_AudioOutput(ISpeechObjectToken AudioOutput);

        [VtblIndex(12)]
        HRESULT get_AudioOutputStream(ISpeechBaseStream* AudioOutputStream);

        [VtblIndex(13)]
        HRESULT putref_AudioOutputStream(ISpeechBaseStream AudioOutputStream);

        [VtblIndex(14)]
        HRESULT get_Rate([NativeTypeName("long *")] int* Rate);

        [VtblIndex(15)]
        HRESULT put_Rate([NativeTypeName("long")] int Rate);

        [VtblIndex(16)]
        HRESULT get_Volume([NativeTypeName("long *")] int* Volume);

        [VtblIndex(17)]
        HRESULT put_Volume([NativeTypeName("long")] int Volume);

        [VtblIndex(18)]
        HRESULT put_AllowAudioOutputFormatChangesOnNextSet(
            [NativeTypeName("VARIANT_BOOL")] short Allow
        );

        [VtblIndex(19)]
        HRESULT get_AllowAudioOutputFormatChangesOnNextSet(
            [NativeTypeName("VARIANT_BOOL *")] short* Allow
        );

        [VtblIndex(20)]
        HRESULT get_EventInterests(SpeechVoiceEvents* EventInterestFlags);

        [VtblIndex(21)]
        HRESULT put_EventInterests(SpeechVoiceEvents EventInterestFlags);

        [VtblIndex(22)]
        HRESULT put_Priority(SpeechVoicePriority Priority);

        [VtblIndex(23)]
        HRESULT get_Priority(SpeechVoicePriority* Priority);

        [VtblIndex(24)]
        HRESULT put_AlertBoundary(SpeechVoiceEvents Boundary);

        [VtblIndex(25)]
        HRESULT get_AlertBoundary(SpeechVoiceEvents* Boundary);

        [VtblIndex(26)]
        HRESULT put_SynchronousSpeakTimeout([NativeTypeName("long")] int msTimeout);

        [VtblIndex(27)]
        HRESULT get_SynchronousSpeakTimeout([NativeTypeName("long *")] int* msTimeout);

        [VtblIndex(28)]
        HRESULT Speak(
            [NativeTypeName("BSTR")] ushort* Text,
            SpeechVoiceSpeakFlags Flags,
            [NativeTypeName("long *")] int* StreamNumber
        );

        [VtblIndex(29)]
        HRESULT SpeakStream(
            ISpeechBaseStream Stream,
            SpeechVoiceSpeakFlags Flags,
            [NativeTypeName("long *")] int* StreamNumber
        );

        [VtblIndex(30)]
        HRESULT Pause();

        [VtblIndex(31)]
        HRESULT Resume();

        [VtblIndex(32)]
        HRESULT Skip(
            [NativeTypeName("const BSTR")] ushort* Type,
            [NativeTypeName("long")] int NumItems,
            [NativeTypeName("long *")] int* NumSkipped
        );

        [VtblIndex(33)]
        HRESULT GetVoices(
            [NativeTypeName("BSTR")] ushort* RequiredAttributes,
            [NativeTypeName("BSTR")] ushort* OptionalAttributes,
            ISpeechObjectTokens* ObjectTokens
        );

        [VtblIndex(34)]
        HRESULT GetAudioOutputs(
            [NativeTypeName("BSTR")] ushort* RequiredAttributes,
            [NativeTypeName("BSTR")] ushort* OptionalAttributes,
            ISpeechObjectTokens* ObjectTokens
        );

        [VtblIndex(35)]
        HRESULT WaitUntilDone(
            [NativeTypeName("long")] int msTimeout,
            [NativeTypeName("VARIANT_BOOL *")] short* Done
        );

        [VtblIndex(36)]
        HRESULT SpeakCompleteEvent([NativeTypeName("long *")] int* Handle);

        [VtblIndex(37)]
        HRESULT IsUISupported(
            [NativeTypeName("const BSTR")] ushort* TypeOfUI,
            [NativeTypeName("const VARIANT *")] VARIANT* ExtraData,
            [NativeTypeName("VARIANT_BOOL *")] short* Supported
        );

        [VtblIndex(38)]
        HRESULT DisplayUI(
            [NativeTypeName("long")] int hWndParent,
            [NativeTypeName("BSTR")] ushort* Title,
            [NativeTypeName("const BSTR")] ushort* TypeOfUI,
            [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null
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

        [NativeTypeName("HRESULT (ISpeechVoiceStatus **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechVoiceStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ISpeechObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechObjectToken*, int> get_Voice;

        [NativeTypeName("HRESULT (ISpeechObjectToken *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechObjectToken, int> putref_Voice;

        [NativeTypeName("HRESULT (ISpeechObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechObjectToken*, int> get_AudioOutput;

        [NativeTypeName("HRESULT (ISpeechObjectToken *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechObjectToken, int> putref_AudioOutput;

        [NativeTypeName("HRESULT (ISpeechBaseStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechBaseStream*, int> get_AudioOutputStream;

        [NativeTypeName("HRESULT (ISpeechBaseStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechBaseStream, int> putref_AudioOutputStream;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Rate;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Rate;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Volume;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Volume;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_AllowAudioOutputFormatChangesOnNextSet;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_AllowAudioOutputFormatChangesOnNextSet;

        [NativeTypeName("HRESULT (SpeechVoiceEvents *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechVoiceEvents*, int> get_EventInterests;

        [NativeTypeName("HRESULT (SpeechVoiceEvents) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechVoiceEvents, int> put_EventInterests;

        [NativeTypeName("HRESULT (SpeechVoicePriority) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechVoicePriority, int> put_Priority;

        [NativeTypeName("HRESULT (SpeechVoicePriority *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechVoicePriority*, int> get_Priority;

        [NativeTypeName("HRESULT (SpeechVoiceEvents) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechVoiceEvents, int> put_AlertBoundary;

        [NativeTypeName("HRESULT (SpeechVoiceEvents *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechVoiceEvents*, int> get_AlertBoundary;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SynchronousSpeakTimeout;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SynchronousSpeakTimeout;

        [NativeTypeName("HRESULT (BSTR, SpeechVoiceSpeakFlags, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, SpeechVoiceSpeakFlags, int*, int> Speak;

        [NativeTypeName(
            "HRESULT (ISpeechBaseStream *, SpeechVoiceSpeakFlags, long *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpeechBaseStream,
            SpeechVoiceSpeakFlags,
            int*,
            int> SpeakStream;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Resume;

        [NativeTypeName("HRESULT (const BSTR, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, int> Skip;

        [NativeTypeName("HRESULT (BSTR, BSTR, ISpeechObjectTokens **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ISpeechObjectTokens*, int> GetVoices;

        [NativeTypeName("HRESULT (BSTR, BSTR, ISpeechObjectTokens **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ISpeechObjectTokens*,
            int> GetAudioOutputs;

        [NativeTypeName("HRESULT (long, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, short*, int> WaitUntilDone;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> SpeakCompleteEvent;

        [NativeTypeName(
            "HRESULT (const BSTR, const VARIANT *, VARIANT_BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, short*, int> IsUISupported;

        [NativeTypeName(
            "HRESULT (long, BSTR, const BSTR, const VARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, ushort*, ushort*, VARIANT*, int> DisplayUI;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechVoice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechVoice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechVoice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechVoice(Silk.NET.Windows.IDispatch value)
    {
        return new ISpeechVoice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechVoice"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechVoice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISpeechVoice value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechVoice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechVoice(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechVoice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechVoice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechVoice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechVoice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
