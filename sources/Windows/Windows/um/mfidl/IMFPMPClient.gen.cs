// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFPMPClient.xml' path='doc/member[@name="IMFPMPClient"]/*'/>
[Guid("6C4E655D-EAD8-4421-B6B9-54DCDBBDF820")]
[NativeTypeName("struct IMFPMPClient : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFPMPClient : IMFPMPClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFPMPClient));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFPMPClient*, Guid*, void**, int> )(lpVtbl[0]))((IMFPMPClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFPMPClient*, uint> )(lpVtbl[1]))((IMFPMPClient*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFPMPClient*, uint> )(lpVtbl[2]))((IMFPMPClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFPMPClient.xml' path='doc/member[@name="IMFPMPClient.SetPMPHost"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPMPHost(IMFPMPHost* pPMPHost)
    {
        return ((delegate* unmanaged<IMFPMPClient*, IMFPMPHost*, int> )(lpVtbl[3]))((IMFPMPClient*)Unsafe.AsPointer(ref this), pPMPHost);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetPMPHost(IMFPMPHost* pPMPHost);
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
        [NativeTypeName("HRESULT (IMFPMPHost *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPMPHost*, int> SetPMPHost;
    }
}