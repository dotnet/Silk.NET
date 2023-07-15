// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFPMediaPlayerCallback.xml' path='doc/member[@name="IMFPMediaPlayerCallback"]/*'/>
[Guid("766C8FFB-5FDB-4FEA-A28D-B912996F51BD")]
[NativeTypeName("struct IMFPMediaPlayerCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFPMediaPlayerCallback : IMFPMediaPlayerCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFPMediaPlayerCallback));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFPMediaPlayerCallback*, Guid*, void**, int> )(lpVtbl[0]))((IMFPMediaPlayerCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFPMediaPlayerCallback*, uint> )(lpVtbl[1]))((IMFPMediaPlayerCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFPMediaPlayerCallback*, uint> )(lpVtbl[2]))((IMFPMediaPlayerCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFPMediaPlayerCallback.xml' path='doc/member[@name="IMFPMediaPlayerCallback.OnMediaPlayerEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnMediaPlayerEvent(MFP_EVENT_HEADER* pEventHeader)
    {
        ((delegate* unmanaged<IMFPMediaPlayerCallback*, MFP_EVENT_HEADER*, void> )(lpVtbl[3]))((IMFPMediaPlayerCallback*)Unsafe.AsPointer(ref this), pEventHeader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void OnMediaPlayerEvent(MFP_EVENT_HEADER* pEventHeader);
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
        [NativeTypeName("void (MFP_EVENT_HEADER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFP_EVENT_HEADER*, void> OnMediaPlayerEvent;
    }
}