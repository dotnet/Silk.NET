// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFBufferListNotify.xml' path='doc/member[@name="IMFBufferListNotify"]/*'/>
[Guid("24CD47F7-81D8-4785-ADB2-AF697A963CD2")]
[NativeTypeName("struct IMFBufferListNotify : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFBufferListNotify : IMFBufferListNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFBufferListNotify));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFBufferListNotify*, Guid*, void**, int> )(lpVtbl[0]))((IMFBufferListNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFBufferListNotify*, uint> )(lpVtbl[1]))((IMFBufferListNotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFBufferListNotify*, uint> )(lpVtbl[2]))((IMFBufferListNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFBufferListNotify.xml' path='doc/member[@name="IMFBufferListNotify.OnAddSourceBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnAddSourceBuffer()
    {
        ((delegate* unmanaged<IMFBufferListNotify*, void> )(lpVtbl[3]))((IMFBufferListNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFBufferListNotify.xml' path='doc/member[@name="IMFBufferListNotify.OnRemoveSourceBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void OnRemoveSourceBuffer()
    {
        ((delegate* unmanaged<IMFBufferListNotify*, void> )(lpVtbl[4]))((IMFBufferListNotify*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void OnAddSourceBuffer();
        [VtblIndex(4)]
        void OnRemoveSourceBuffer();
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
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> OnAddSourceBuffer;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> OnRemoveSourceBuffer;
    }
}