// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFSinkWriterCallback2.xml' path='doc/member[@name="IMFSinkWriterCallback2"]/*'/>
[Guid("2456BD58-C067-4513-84FE-8D0C88FFDC61")]
[NativeTypeName("struct IMFSinkWriterCallback2 : IMFSinkWriterCallback")]
[NativeInheritance("IMFSinkWriterCallback")]
public unsafe partial struct IMFSinkWriterCallback2 : IMFSinkWriterCallback2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSinkWriterCallback2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2*, Guid*, void**, int> )(lpVtbl[0]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2*, uint> )(lpVtbl[1]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2*, uint> )(lpVtbl[2]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFSinkWriterCallback.OnFinalize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnFinalize(HRESULT hrStatus)
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2*, HRESULT, int> )(lpVtbl[3]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this), hrStatus);
    }

    /// <inheritdoc cref = "IMFSinkWriterCallback.OnMarker"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnMarker([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LPVOID")] void* pvContext)
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2*, uint, void*, int> )(lpVtbl[4]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this), dwStreamIndex, pvContext);
    }

    /// <include file='IMFSinkWriterCallback2.xml' path='doc/member[@name="IMFSinkWriterCallback2.OnTransformChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnTransformChange()
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2*, int> )(lpVtbl[5]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSinkWriterCallback2.xml' path='doc/member[@name="IMFSinkWriterCallback2.OnStreamError"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnStreamError([NativeTypeName("DWORD")] uint dwStreamIndex, HRESULT hrStatus)
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2*, uint, HRESULT, int> )(lpVtbl[6]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this), dwStreamIndex, hrStatus);
    }

    public interface Interface : IMFSinkWriterCallback.Interface
    {
        [VtblIndex(5)]
        HRESULT OnTransformChange();
        [VtblIndex(6)]
        HRESULT OnStreamError([NativeTypeName("DWORD")] uint dwStreamIndex, HRESULT hrStatus);
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
        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> OnFinalize;
        [NativeTypeName("HRESULT (DWORD, LPVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, int> OnMarker;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnTransformChange;
        [NativeTypeName("HRESULT (DWORD, HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HRESULT, int> OnStreamError;
    }
}