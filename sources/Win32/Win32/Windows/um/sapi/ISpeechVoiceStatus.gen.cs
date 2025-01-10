// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8BE47B07-57F6-11D2-9EEE-00C04F797396")]
[NativeTypeName("struct ISpeechVoiceStatus : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechVoiceStatus : ISpeechVoiceStatus.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechVoiceStatus));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpeechVoiceStatus, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISpeechVoiceStatus, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<ISpeechVoiceStatus, Guid*, ushort**, uint, uint, int*, int>)(
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
                ISpeechVoiceStatus,
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
    public HRESULT get_CurrentStreamNumber([NativeTypeName("long *")] int* StreamNumber)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, int*, int>)((*lpVtbl)[7]))(
            this,
            StreamNumber
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LastStreamNumberQueued([NativeTypeName("long *")] int* StreamNumber)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, int*, int>)((*lpVtbl)[8]))(
            this,
            StreamNumber
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_LastHResult([NativeTypeName("long *")] int* HResult)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, int*, int>)((*lpVtbl)[9]))(this, HResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RunningState(SpeechRunState* State)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, SpeechRunState*, int>)((*lpVtbl)[10]))(
            this,
            State
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_InputWordPosition([NativeTypeName("long *")] int* Position)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, int*, int>)((*lpVtbl)[11]))(
            this,
            Position
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_InputWordLength([NativeTypeName("long *")] int* Length)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, int*, int>)((*lpVtbl)[12]))(this, Length);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_InputSentencePosition([NativeTypeName("long *")] int* Position)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, int*, int>)((*lpVtbl)[13]))(
            this,
            Position
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_InputSentenceLength([NativeTypeName("long *")] int* Length)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, int*, int>)((*lpVtbl)[14]))(this, Length);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_LastBookmark([NativeTypeName("BSTR *")] ushort** Bookmark)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, ushort**, int>)((*lpVtbl)[15]))(
            this,
            Bookmark
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_LastBookmarkId([NativeTypeName("long *")] int* BookmarkId)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, int*, int>)((*lpVtbl)[16]))(
            this,
            BookmarkId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_PhonemeId(short* PhoneId)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, short*, int>)((*lpVtbl)[17]))(
            this,
            PhoneId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_VisemeId(short* VisemeId)
    {
        return ((delegate* unmanaged<ISpeechVoiceStatus, short*, int>)((*lpVtbl)[18]))(
            this,
            VisemeId
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_CurrentStreamNumber([NativeTypeName("long *")] int* StreamNumber);

        [VtblIndex(8)]
        HRESULT get_LastStreamNumberQueued([NativeTypeName("long *")] int* StreamNumber);

        [VtblIndex(9)]
        HRESULT get_LastHResult([NativeTypeName("long *")] int* HResult);

        [VtblIndex(10)]
        HRESULT get_RunningState(SpeechRunState* State);

        [VtblIndex(11)]
        HRESULT get_InputWordPosition([NativeTypeName("long *")] int* Position);

        [VtblIndex(12)]
        HRESULT get_InputWordLength([NativeTypeName("long *")] int* Length);

        [VtblIndex(13)]
        HRESULT get_InputSentencePosition([NativeTypeName("long *")] int* Position);

        [VtblIndex(14)]
        HRESULT get_InputSentenceLength([NativeTypeName("long *")] int* Length);

        [VtblIndex(15)]
        HRESULT get_LastBookmark([NativeTypeName("BSTR *")] ushort** Bookmark);

        [VtblIndex(16)]
        HRESULT get_LastBookmarkId([NativeTypeName("long *")] int* BookmarkId);

        [VtblIndex(17)]
        HRESULT get_PhonemeId(short* PhoneId);

        [VtblIndex(18)]
        HRESULT get_VisemeId(short* VisemeId);
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
        public delegate* unmanaged<TSelf*, int*, int> get_CurrentStreamNumber;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastStreamNumberQueued;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastHResult;

        [NativeTypeName("HRESULT (SpeechRunState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechRunState*, int> get_RunningState;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_InputWordPosition;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_InputWordLength;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_InputSentencePosition;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_InputSentenceLength;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_LastBookmark;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastBookmarkId;

        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_PhonemeId;

        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_VisemeId;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechVoiceStatus"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechVoiceStatus(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechVoiceStatus"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechVoiceStatus(Silk.NET.Windows.IDispatch value)
    {
        return new ISpeechVoiceStatus(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechVoiceStatus"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechVoiceStatus"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISpeechVoiceStatus value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechVoiceStatus"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechVoiceStatus(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechVoiceStatus(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechVoiceStatus"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechVoiceStatus"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechVoiceStatus value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
