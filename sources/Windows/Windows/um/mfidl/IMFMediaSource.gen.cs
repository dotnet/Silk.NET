// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFMediaSource.xml' path='doc/member[@name="IMFMediaSource"]/*'/>
[Guid("279A808D-AEC7-40C8-9C6B-A6B492C78A66")]
[NativeTypeName("struct IMFMediaSource : IMFMediaEventGenerator")]
[NativeInheritance("IMFMediaEventGenerator")]
public unsafe partial struct IMFMediaSource : IMFMediaSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaSource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSource*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaSource*, uint> )(lpVtbl[1]))((IMFMediaSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSource*, uint> )(lpVtbl[2]))((IMFMediaSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFMediaEventGenerator.GetEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaSource*, uint, IMFMediaEvent**, int> )(lpVtbl[3]))((IMFMediaSource*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
    }

    /// <inheritdoc cref = "IMFMediaEventGenerator.BeginGetEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFMediaSource*, IMFAsyncCallback*, IUnknown*, int> )(lpVtbl[4]))((IMFMediaSource*)Unsafe.AsPointer(ref this), pCallback, punkState);
    }

    /// <inheritdoc cref = "IMFMediaEventGenerator.EndGetEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaSource*, IMFAsyncResult*, IMFMediaEvent**, int> )(lpVtbl[5]))((IMFMediaSource*)Unsafe.AsPointer(ref this), pResult, ppEvent);
    }

    /// <inheritdoc cref = "IMFMediaEventGenerator.QueueEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
    {
        return ((delegate* unmanaged<IMFMediaSource*, uint, Guid*, HRESULT, PROPVARIANT*, int> )(lpVtbl[6]))((IMFMediaSource*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
    }

    /// <include file='IMFMediaSource.xml' path='doc/member[@name="IMFMediaSource.GetCharacteristics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IMFMediaSource*, uint*, int> )(lpVtbl[7]))((IMFMediaSource*)Unsafe.AsPointer(ref this), pdwCharacteristics);
    }

    /// <include file='IMFMediaSource.xml' path='doc/member[@name="IMFMediaSource.CreatePresentationDescriptor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreatePresentationDescriptor(IMFPresentationDescriptor** ppPresentationDescriptor)
    {
        return ((delegate* unmanaged<IMFMediaSource*, IMFPresentationDescriptor**, int> )(lpVtbl[8]))((IMFMediaSource*)Unsafe.AsPointer(ref this), ppPresentationDescriptor);
    }

    /// <include file='IMFMediaSource.xml' path='doc/member[@name="IMFMediaSource.Start"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Start(IMFPresentationDescriptor* pPresentationDescriptor, [NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition)
    {
        return ((delegate* unmanaged<IMFMediaSource*, IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int> )(lpVtbl[9]))((IMFMediaSource*)Unsafe.AsPointer(ref this), pPresentationDescriptor, pguidTimeFormat, pvarStartPosition);
    }

    /// <include file='IMFMediaSource.xml' path='doc/member[@name="IMFMediaSource.Stop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IMFMediaSource*, int> )(lpVtbl[10]))((IMFMediaSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaSource.xml' path='doc/member[@name="IMFMediaSource.Pause"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMFMediaSource*, int> )(lpVtbl[11]))((IMFMediaSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaSource.xml' path='doc/member[@name="IMFMediaSource.Shutdown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaSource*, int> )(lpVtbl[12]))((IMFMediaSource*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IMFMediaEventGenerator.Interface
    {
        [VtblIndex(7)]
        HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics);
        [VtblIndex(8)]
        HRESULT CreatePresentationDescriptor(IMFPresentationDescriptor** ppPresentationDescriptor);
        [VtblIndex(9)]
        HRESULT Start(IMFPresentationDescriptor* pPresentationDescriptor, [NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition);
        [VtblIndex(10)]
        HRESULT Stop();
        [VtblIndex(11)]
        HRESULT Pause();
        [VtblIndex(12)]
        HRESULT Shutdown();
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
    }
}