// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFTranscodeProfile.xml' path='doc/member[@name="IMFTranscodeProfile"]/*'/>
[Guid("4ADFDBA3-7AB0-4953-A62B-461E7FF3DA1E")]
[NativeTypeName("struct IMFTranscodeProfile : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTranscodeProfile : IMFTranscodeProfile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTranscodeProfile));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTranscodeProfile*, Guid*, void**, int> )(lpVtbl[0]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTranscodeProfile*, uint> )(lpVtbl[1]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTranscodeProfile*, uint> )(lpVtbl[2]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTranscodeProfile.xml' path='doc/member[@name="IMFTranscodeProfile.SetAudioAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAudioAttributes(IMFAttributes* pAttrs)
    {
        return ((delegate* unmanaged<IMFTranscodeProfile*, IMFAttributes*, int> )(lpVtbl[3]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), pAttrs);
    }

    /// <include file='IMFTranscodeProfile.xml' path='doc/member[@name="IMFTranscodeProfile.GetAudioAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAudioAttributes(IMFAttributes** ppAttrs)
    {
        return ((delegate* unmanaged<IMFTranscodeProfile*, IMFAttributes**, int> )(lpVtbl[4]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), ppAttrs);
    }

    /// <include file='IMFTranscodeProfile.xml' path='doc/member[@name="IMFTranscodeProfile.SetVideoAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetVideoAttributes(IMFAttributes* pAttrs)
    {
        return ((delegate* unmanaged<IMFTranscodeProfile*, IMFAttributes*, int> )(lpVtbl[5]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), pAttrs);
    }

    /// <include file='IMFTranscodeProfile.xml' path='doc/member[@name="IMFTranscodeProfile.GetVideoAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetVideoAttributes(IMFAttributes** ppAttrs)
    {
        return ((delegate* unmanaged<IMFTranscodeProfile*, IMFAttributes**, int> )(lpVtbl[6]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), ppAttrs);
    }

    /// <include file='IMFTranscodeProfile.xml' path='doc/member[@name="IMFTranscodeProfile.SetContainerAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetContainerAttributes(IMFAttributes* pAttrs)
    {
        return ((delegate* unmanaged<IMFTranscodeProfile*, IMFAttributes*, int> )(lpVtbl[7]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), pAttrs);
    }

    /// <include file='IMFTranscodeProfile.xml' path='doc/member[@name="IMFTranscodeProfile.GetContainerAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetContainerAttributes(IMFAttributes** ppAttrs)
    {
        return ((delegate* unmanaged<IMFTranscodeProfile*, IMFAttributes**, int> )(lpVtbl[8]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), ppAttrs);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAudioAttributes(IMFAttributes* pAttrs);
        [VtblIndex(4)]
        HRESULT GetAudioAttributes(IMFAttributes** ppAttrs);
        [VtblIndex(5)]
        HRESULT SetVideoAttributes(IMFAttributes* pAttrs);
        [VtblIndex(6)]
        HRESULT GetVideoAttributes(IMFAttributes** ppAttrs);
        [VtblIndex(7)]
        HRESULT SetContainerAttributes(IMFAttributes* pAttrs);
        [VtblIndex(8)]
        HRESULT GetContainerAttributes(IMFAttributes** ppAttrs);
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
        [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, int> SetAudioAttributes;
        [NativeTypeName("HRESULT (IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes**, int> GetAudioAttributes;
        [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, int> SetVideoAttributes;
        [NativeTypeName("HRESULT (IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes**, int> GetVideoAttributes;
        [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, int> SetContainerAttributes;
        [NativeTypeName("HRESULT (IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes**, int> GetContainerAttributes;
    }
}