// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfCandidateString.xml' path='doc/member[@name="ITfCandidateString"]/*'/>
[Guid("581F317E-FD9D-443F-B972-ED00467C5D40")]
[NativeTypeName("struct ITfCandidateString : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfCandidateString : ITfCandidateString.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCandidateString));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCandidateString*, Guid*, void**, int> )(lpVtbl[0]))((ITfCandidateString*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfCandidateString*, uint> )(lpVtbl[1]))((ITfCandidateString*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCandidateString*, uint> )(lpVtbl[2]))((ITfCandidateString*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfCandidateString.xml' path='doc/member[@name="ITfCandidateString.GetString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetString([NativeTypeName("BSTR *")] ushort** pbstr)
    {
        return ((delegate* unmanaged<ITfCandidateString*, ushort**, int> )(lpVtbl[3]))((ITfCandidateString*)Unsafe.AsPointer(ref this), pbstr);
    }

    /// <include file='ITfCandidateString.xml' path='doc/member[@name="ITfCandidateString.GetIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetIndex([NativeTypeName("ULONG *")] uint* pnIndex)
    {
        return ((delegate* unmanaged<ITfCandidateString*, uint*, int> )(lpVtbl[4]))((ITfCandidateString*)Unsafe.AsPointer(ref this), pnIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetString([NativeTypeName("BSTR *")] ushort** pbstr);
        [VtblIndex(4)]
        HRESULT GetIndex([NativeTypeName("ULONG *")] uint* pnIndex);
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
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetString;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetIndex;
    }
}