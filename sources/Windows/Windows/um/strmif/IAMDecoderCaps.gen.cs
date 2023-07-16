// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAMDecoderCaps.xml' path='doc/member[@name="IAMDecoderCaps"]/*'/>
[Guid("C0DFF467-D499-4986-972B-E1D9090FA941")]
[NativeTypeName("struct IAMDecoderCaps : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMDecoderCaps : IAMDecoderCaps.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMDecoderCaps));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMDecoderCaps*, Guid*, void**, int> )(lpVtbl[0]))((IAMDecoderCaps*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMDecoderCaps*, uint> )(lpVtbl[1]))((IAMDecoderCaps*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMDecoderCaps*, uint> )(lpVtbl[2]))((IAMDecoderCaps*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMDecoderCaps.xml' path='doc/member[@name="IAMDecoderCaps.GetDecoderCaps"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDecoderCaps([NativeTypeName("DWORD")] uint dwCapIndex, [NativeTypeName("DWORD *")] uint* lpdwCap)
    {
        return ((delegate* unmanaged<IAMDecoderCaps*, uint, uint*, int> )(lpVtbl[3]))((IAMDecoderCaps*)Unsafe.AsPointer(ref this), dwCapIndex, lpdwCap);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDecoderCaps([NativeTypeName("DWORD")] uint dwCapIndex, [NativeTypeName("DWORD *")] uint* lpdwCap);
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
        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetDecoderCaps;
    }
}