// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFCapturePhotoConfirmation.xml' path='doc/member[@name="IMFCapturePhotoConfirmation"]/*'/>
[Guid("19F68549-CA8A-4706-A4EF-481DBC95E12C")]
[NativeTypeName("struct IMFCapturePhotoConfirmation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFCapturePhotoConfirmation : IMFCapturePhotoConfirmation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCapturePhotoConfirmation));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCapturePhotoConfirmation*, Guid*, void**, int> )(lpVtbl[0]))((IMFCapturePhotoConfirmation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCapturePhotoConfirmation*, uint> )(lpVtbl[1]))((IMFCapturePhotoConfirmation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCapturePhotoConfirmation*, uint> )(lpVtbl[2]))((IMFCapturePhotoConfirmation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCapturePhotoConfirmation.xml' path='doc/member[@name="IMFCapturePhotoConfirmation.SetPhotoConfirmationCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPhotoConfirmationCallback(IMFAsyncCallback* pNotificationCallback)
    {
        return ((delegate* unmanaged<IMFCapturePhotoConfirmation*, IMFAsyncCallback*, int> )(lpVtbl[3]))((IMFCapturePhotoConfirmation*)Unsafe.AsPointer(ref this), pNotificationCallback);
    }

    /// <include file='IMFCapturePhotoConfirmation.xml' path='doc/member[@name="IMFCapturePhotoConfirmation.SetPixelFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPixelFormat(Guid subtype)
    {
        return ((delegate* unmanaged<IMFCapturePhotoConfirmation*, Guid, int> )(lpVtbl[4]))((IMFCapturePhotoConfirmation*)Unsafe.AsPointer(ref this), subtype);
    }

    /// <include file='IMFCapturePhotoConfirmation.xml' path='doc/member[@name="IMFCapturePhotoConfirmation.GetPixelFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPixelFormat(Guid* subtype)
    {
        return ((delegate* unmanaged<IMFCapturePhotoConfirmation*, Guid*, int> )(lpVtbl[5]))((IMFCapturePhotoConfirmation*)Unsafe.AsPointer(ref this), subtype);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetPhotoConfirmationCallback(IMFAsyncCallback* pNotificationCallback);
        [VtblIndex(4)]
        HRESULT SetPixelFormat(Guid subtype);
        [VtblIndex(5)]
        HRESULT GetPixelFormat(Guid* subtype);
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
        [NativeTypeName("HRESULT (IMFAsyncCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback*, int> SetPhotoConfirmationCallback;
        [NativeTypeName("HRESULT (GUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> SetPixelFormat;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetPixelFormat;
    }
}