// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFMediaSourceEx.xml' path='doc/member[@name="IMFMediaSourceEx"]/*'/>
[Guid("3C9B2EB9-86D5-4514-A394-F56664F9F0D8")]
[NativeTypeName("struct IMFMediaSourceEx : IMFMediaSource")]
[NativeInheritance("IMFMediaSource")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFMediaSourceEx : IMFMediaSourceEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaSourceEx));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, uint> )(lpVtbl[1]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, uint> )(lpVtbl[2]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFMediaEventGenerator.GetEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, uint, IMFMediaEvent**, int> )(lpVtbl[3]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
    }

    /// <inheritdoc cref = "IMFMediaEventGenerator.BeginGetEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, IMFAsyncCallback*, IUnknown*, int> )(lpVtbl[4]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pCallback, punkState);
    }

    /// <inheritdoc cref = "IMFMediaEventGenerator.EndGetEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, IMFAsyncResult*, IMFMediaEvent**, int> )(lpVtbl[5]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pResult, ppEvent);
    }

    /// <inheritdoc cref = "IMFMediaEventGenerator.QueueEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, uint, Guid*, HRESULT, PROPVARIANT*, int> )(lpVtbl[6]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
    }

    /// <inheritdoc cref = "IMFMediaSource.GetCharacteristics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, uint*, int> )(lpVtbl[7]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pdwCharacteristics);
    }

    /// <inheritdoc cref = "IMFMediaSource.CreatePresentationDescriptor"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreatePresentationDescriptor(IMFPresentationDescriptor** ppPresentationDescriptor)
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, IMFPresentationDescriptor**, int> )(lpVtbl[8]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), ppPresentationDescriptor);
    }

    /// <inheritdoc cref = "IMFMediaSource.Start"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Start(IMFPresentationDescriptor* pPresentationDescriptor, [NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition)
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int> )(lpVtbl[9]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pPresentationDescriptor, pguidTimeFormat, pvarStartPosition);
    }

    /// <inheritdoc cref = "IMFMediaSource.Stop"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, int> )(lpVtbl[10]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFMediaSource.Pause"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, int> )(lpVtbl[11]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFMediaSource.Shutdown"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, int> )(lpVtbl[12]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaSourceEx.xml' path='doc/member[@name="IMFMediaSourceEx.GetSourceAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetSourceAttributes(IMFAttributes** ppAttributes)
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, IMFAttributes**, int> )(lpVtbl[13]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), ppAttributes);
    }

    /// <include file='IMFMediaSourceEx.xml' path='doc/member[@name="IMFMediaSourceEx.GetStreamAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetStreamAttributes([NativeTypeName("DWORD")] uint dwStreamIdentifier, IMFAttributes** ppAttributes)
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, uint, IMFAttributes**, int> )(lpVtbl[14]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), dwStreamIdentifier, ppAttributes);
    }

    /// <include file='IMFMediaSourceEx.xml' path='doc/member[@name="IMFMediaSourceEx.SetD3DManager"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetD3DManager(IUnknown* pManager)
    {
        return ((delegate* unmanaged<IMFMediaSourceEx*, IUnknown*, int> )(lpVtbl[15]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pManager);
    }

    public interface Interface : IMFMediaSource.Interface
    {
        [VtblIndex(13)]
        HRESULT GetSourceAttributes(IMFAttributes** ppAttributes);
        [VtblIndex(14)]
        HRESULT GetStreamAttributes([NativeTypeName("DWORD")] uint dwStreamIdentifier, IMFAttributes** ppAttributes);
        [VtblIndex(15)]
        HRESULT SetD3DManager(IUnknown* pManager);
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
        [NativeTypeName("HRESULT (DWORD, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaEvent**, int> GetEvent;
        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback*, IUnknown*, int> BeginGetEvent;
        [NativeTypeName("HRESULT (IMFAsyncResult *, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, IMFMediaEvent**, int> EndGetEvent;
        [NativeTypeName("HRESULT (MediaEventType, const GUID &, HRESULT, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, HRESULT, PROPVARIANT*, int> QueueEvent;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCharacteristics;
        [NativeTypeName("HRESULT (IMFPresentationDescriptor **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationDescriptor**, int> CreatePresentationDescriptor;
        [NativeTypeName("HRESULT (IMFPresentationDescriptor *, const GUID *, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int> Start;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;
        [NativeTypeName("HRESULT (IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes**, int> GetSourceAttributes;
        [NativeTypeName("HRESULT (DWORD, IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFAttributes**, int> GetStreamAttributes;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetD3DManager;
    }
}