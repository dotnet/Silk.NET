// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFMediaEngineExtension.xml' path='doc/member[@name="IMFMediaEngineExtension"]/*'/>
[Guid("2F69D622-20B5-41E9-AFDF-89CED1DDA04E")]
[NativeTypeName("struct IMFMediaEngineExtension : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFMediaEngineExtension : IMFMediaEngineExtension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineExtension));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineExtension*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineExtension*, uint> )(lpVtbl[1]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineExtension*, uint> )(lpVtbl[2]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineExtension.xml' path='doc/member[@name="IMFMediaEngineExtension.CanPlayType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CanPlayType(BOOL AudioOnly, [NativeTypeName("BSTR")] ushort* MimeType, MF_MEDIA_ENGINE_CANPLAY* pAnswer)
    {
        return ((delegate* unmanaged<IMFMediaEngineExtension*, BOOL, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int> )(lpVtbl[3]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), AudioOnly, MimeType, pAnswer);
    }

    /// <include file='IMFMediaEngineExtension.xml' path='doc/member[@name="IMFMediaEngineExtension.BeginCreateObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginCreateObject([NativeTypeName("BSTR")] ushort* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFMediaEngineExtension*, ushort*, IMFByteStream*, MF_OBJECT_TYPE, IUnknown**, IMFAsyncCallback*, IUnknown*, int> )(lpVtbl[4]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkState);
    }

    /// <include file='IMFMediaEngineExtension.xml' path='doc/member[@name="IMFMediaEngineExtension.CancelObjectCreation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CancelObjectCreation(IUnknown* pIUnknownCancelCookie)
    {
        return ((delegate* unmanaged<IMFMediaEngineExtension*, IUnknown*, int> )(lpVtbl[5]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), pIUnknownCancelCookie);
    }

    /// <include file='IMFMediaEngineExtension.xml' path='doc/member[@name="IMFMediaEngineExtension.EndCreateObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EndCreateObject(IMFAsyncResult* pResult, IUnknown** ppObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineExtension*, IMFAsyncResult*, IUnknown**, int> )(lpVtbl[6]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), pResult, ppObject);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CanPlayType(BOOL AudioOnly, [NativeTypeName("BSTR")] ushort* MimeType, MF_MEDIA_ENGINE_CANPLAY* pAnswer);
        [VtblIndex(4)]
        HRESULT BeginCreateObject([NativeTypeName("BSTR")] ushort* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, IUnknown* punkState);
        [VtblIndex(5)]
        HRESULT CancelObjectCreation(IUnknown* pIUnknownCancelCookie);
        [VtblIndex(6)]
        HRESULT EndCreateObject(IMFAsyncResult* pResult, IUnknown** ppObject);
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
        [NativeTypeName("HRESULT (BOOL, BSTR, MF_MEDIA_ENGINE_CANPLAY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int> CanPlayType;
        [NativeTypeName("HRESULT (BSTR, IMFByteStream *, MF_OBJECT_TYPE, IUnknown **, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IMFByteStream*, MF_OBJECT_TYPE, IUnknown**, IMFAsyncCallback*, IUnknown*, int> BeginCreateObject;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> CancelObjectCreation;
        [NativeTypeName("HRESULT (IMFAsyncResult *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, IUnknown**, int> EndCreateObject;
    }
}