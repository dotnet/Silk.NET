// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFTopoLoader.xml' path='doc/member[@name="IMFTopoLoader"]/*' />
[Guid("DE9A6157-F660-4643-B56A-DF9F7998C7CD")]
[NativeTypeName("struct IMFTopoLoader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTopoLoader : IMFTopoLoader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTopoLoader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTopoLoader*, Guid*, void**, int>)(lpVtbl[0]))((IMFTopoLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTopoLoader*, uint>)(lpVtbl[1]))((IMFTopoLoader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTopoLoader*, uint>)(lpVtbl[2]))((IMFTopoLoader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTopoLoader.xml' path='doc/member[@name="IMFTopoLoader.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(IMFTopology* pInputTopo, IMFTopology** ppOutputTopo, IMFTopology* pCurrentTopo)
    {
        return ((delegate* unmanaged<IMFTopoLoader*, IMFTopology*, IMFTopology**, IMFTopology*, int>)(lpVtbl[3]))((IMFTopoLoader*)Unsafe.AsPointer(ref this), pInputTopo, ppOutputTopo, pCurrentTopo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Load(IMFTopology* pInputTopo, IMFTopology** ppOutputTopo, IMFTopology* pCurrentTopo);
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

        [NativeTypeName("HRESULT (IMFTopology *, IMFTopology **, IMFTopology *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTopology*, IMFTopology**, IMFTopology*, int> Load;
    }
}
