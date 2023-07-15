// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IPinFlowControl.xml' path='doc/member[@name="IPinFlowControl"]/*'/>
[Guid("C56E9858-DBF3-4F6B-8119-384AF2060DEB")]
[NativeTypeName("struct IPinFlowControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPinFlowControl : IPinFlowControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPinFlowControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPinFlowControl*, Guid*, void**, int> )(lpVtbl[0]))((IPinFlowControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPinFlowControl*, uint> )(lpVtbl[1]))((IPinFlowControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPinFlowControl*, uint> )(lpVtbl[2]))((IPinFlowControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPinFlowControl.xml' path='doc/member[@name="IPinFlowControl.Block"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Block([NativeTypeName("DWORD")] uint dwBlockFlags, HANDLE hEvent)
    {
        return ((delegate* unmanaged<IPinFlowControl*, uint, HANDLE, int> )(lpVtbl[3]))((IPinFlowControl*)Unsafe.AsPointer(ref this), dwBlockFlags, hEvent);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Block([NativeTypeName("DWORD")] uint dwBlockFlags, HANDLE hEvent);
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
        [NativeTypeName("HRESULT (DWORD, HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HANDLE, int> Block;
    }
}