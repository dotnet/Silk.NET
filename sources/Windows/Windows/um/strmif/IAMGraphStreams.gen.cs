// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAMGraphStreams.xml' path='doc/member[@name="IAMGraphStreams"]/*'/>
[Guid("632105FA-072E-11D3-8AF9-00C04FB6BD3D")]
[NativeTypeName("struct IAMGraphStreams : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMGraphStreams : IAMGraphStreams.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMGraphStreams));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMGraphStreams*, Guid*, void**, int> )(lpVtbl[0]))((IAMGraphStreams*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMGraphStreams*, uint> )(lpVtbl[1]))((IAMGraphStreams*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMGraphStreams*, uint> )(lpVtbl[2]))((IAMGraphStreams*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMGraphStreams.xml' path='doc/member[@name="IAMGraphStreams.FindUpstreamInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FindUpstreamInterface(IPin* pPin, [NativeTypeName("const IID &")] Guid* riid, void** ppvInterface, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IAMGraphStreams*, IPin*, Guid*, void**, uint, int> )(lpVtbl[3]))((IAMGraphStreams*)Unsafe.AsPointer(ref this), pPin, riid, ppvInterface, dwFlags);
    }

    /// <include file='IAMGraphStreams.xml' path='doc/member[@name="IAMGraphStreams.SyncUsingStreamOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SyncUsingStreamOffset(BOOL bUseStreamOffset)
    {
        return ((delegate* unmanaged<IAMGraphStreams*, BOOL, int> )(lpVtbl[4]))((IAMGraphStreams*)Unsafe.AsPointer(ref this), bUseStreamOffset);
    }

    /// <include file='IAMGraphStreams.xml' path='doc/member[@name="IAMGraphStreams.SetMaxGraphLatency"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMaxGraphLatency([NativeTypeName("REFERENCE_TIME")] long rtMaxGraphLatency)
    {
        return ((delegate* unmanaged<IAMGraphStreams*, long, int> )(lpVtbl[5]))((IAMGraphStreams*)Unsafe.AsPointer(ref this), rtMaxGraphLatency);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FindUpstreamInterface(IPin* pPin, [NativeTypeName("const IID &")] Guid* riid, void** ppvInterface, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(4)]
        HRESULT SyncUsingStreamOffset(BOOL bUseStreamOffset);
        [VtblIndex(5)]
        HRESULT SetMaxGraphLatency([NativeTypeName("REFERENCE_TIME")] long rtMaxGraphLatency);
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
        [NativeTypeName("HRESULT (IPin *, const IID &, void **, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, Guid*, void**, uint, int> FindUpstreamInterface;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SyncUsingStreamOffset;
        [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> SetMaxGraphLatency;
    }
}