// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack"]/*'/>
[Guid("8822C32D-654E-4233-BF21-D7F2E67D30D4")]
[NativeTypeName("struct IMFTimedTextTrack : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFTimedTextTrack : IMFTimedTextTrack.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextTrack));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, Guid*, void**, int> )(lpVtbl[0]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, uint> )(lpVtbl[1]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, uint> )(lpVtbl[2]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.GetId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint GetId()
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, uint> )(lpVtbl[3]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.GetLabel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLabel([NativeTypeName("LPWSTR *")] ushort** label)
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, ushort**, int> )(lpVtbl[4]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), label);
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.SetLabel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetLabel([NativeTypeName("LPCWSTR")] ushort* label)
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, ushort*, int> )(lpVtbl[5]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), label);
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.GetLanguage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetLanguage([NativeTypeName("LPWSTR *")] ushort** language)
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, ushort**, int> )(lpVtbl[6]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), language);
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.GetTrackKind"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public MF_TIMED_TEXT_TRACK_KIND GetTrackKind()
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, MF_TIMED_TEXT_TRACK_KIND> )(lpVtbl[7]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.IsInBand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public BOOL IsInBand()
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, int> )(lpVtbl[8]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.GetInBandMetadataTrackDispatchType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetInBandMetadataTrackDispatchType([NativeTypeName("LPWSTR *")] ushort** dispatchType)
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, ushort**, int> )(lpVtbl[9]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), dispatchType);
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.IsActive"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public BOOL IsActive()
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, int> )(lpVtbl[10]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.GetErrorCode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public MF_TIMED_TEXT_ERROR_CODE GetErrorCode()
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, MF_TIMED_TEXT_ERROR_CODE> )(lpVtbl[11]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.GetExtendedErrorCode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetExtendedErrorCode()
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, int> )(lpVtbl[12]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.GetDataFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDataFormat(Guid* format)
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, Guid*, int> )(lpVtbl[13]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), format);
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.GetReadyState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public MF_TIMED_TEXT_TRACK_READY_STATE GetReadyState()
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, MF_TIMED_TEXT_TRACK_READY_STATE> )(lpVtbl[14]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextTrack.xml' path='doc/member[@name="IMFTimedTextTrack.GetCueList"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetCueList(IMFTimedTextCueList** cues)
    {
        return ((delegate* unmanaged<IMFTimedTextTrack*, IMFTimedTextCueList**, int> )(lpVtbl[15]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), cues);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint GetId();
        [VtblIndex(4)]
        HRESULT GetLabel([NativeTypeName("LPWSTR *")] ushort** label);
        [VtblIndex(5)]
        HRESULT SetLabel([NativeTypeName("LPCWSTR")] ushort* label);
        [VtblIndex(6)]
        HRESULT GetLanguage([NativeTypeName("LPWSTR *")] ushort** language);
        [VtblIndex(7)]
        MF_TIMED_TEXT_TRACK_KIND GetTrackKind();
        [VtblIndex(8)]
        BOOL IsInBand();
        [VtblIndex(9)]
        HRESULT GetInBandMetadataTrackDispatchType([NativeTypeName("LPWSTR *")] ushort** dispatchType);
        [VtblIndex(10)]
        BOOL IsActive();
        [VtblIndex(11)]
        MF_TIMED_TEXT_ERROR_CODE GetErrorCode();
        [VtblIndex(12)]
        HRESULT GetExtendedErrorCode();
        [VtblIndex(13)]
        HRESULT GetDataFormat(Guid* format);
        [VtblIndex(14)]
        MF_TIMED_TEXT_TRACK_READY_STATE GetReadyState();
        [VtblIndex(15)]
        HRESULT GetCueList(IMFTimedTextCueList** cues);
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
        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetId;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetLabel;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetLabel;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetLanguage;
        [NativeTypeName("MF_TIMED_TEXT_TRACK_KIND () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_TRACK_KIND> GetTrackKind;
        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsInBand;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetInBandMetadataTrackDispatchType;
        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsActive;
        [NativeTypeName("MF_TIMED_TEXT_ERROR_CODE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_ERROR_CODE> GetErrorCode;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetExtendedErrorCode;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetDataFormat;
        [NativeTypeName("MF_TIMED_TEXT_TRACK_READY_STATE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_TRACK_READY_STATE> GetReadyState;
        [NativeTypeName("HRESULT (IMFTimedTextCueList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextCueList**, int> GetCueList;
    }
}