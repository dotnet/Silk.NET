// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IPipeByte.xml' path='doc/member[@name="IPipeByte"]/*'/>
[Guid("DB2F3ACA-2F86-11D1-8E04-00C04FB9989A")]
[NativeTypeName("struct IPipeByte : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPipeByte : IPipeByte.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPipeByte));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPipeByte*, Guid*, void**, int> )(lpVtbl[0]))((IPipeByte*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPipeByte*, uint> )(lpVtbl[1]))((IPipeByte*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPipeByte*, uint> )(lpVtbl[2]))((IPipeByte*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPipeByte.xml' path='doc/member[@name="IPipeByte.Pull"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Pull(byte* buf, [NativeTypeName("ULONG")] uint cRequest, [NativeTypeName("ULONG *")] uint* pcReturned)
    {
        return ((delegate* unmanaged<IPipeByte*, byte*, uint, uint*, int> )(lpVtbl[3]))((IPipeByte*)Unsafe.AsPointer(ref this), buf, cRequest, pcReturned);
    }

    /// <include file='IPipeByte.xml' path='doc/member[@name="IPipeByte.Push"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Push(byte* buf, [NativeTypeName("ULONG")] uint cSent)
    {
        return ((delegate* unmanaged<IPipeByte*, byte*, uint, int> )(lpVtbl[4]))((IPipeByte*)Unsafe.AsPointer(ref this), buf, cSent);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Pull(byte* buf, [NativeTypeName("ULONG")] uint cRequest, [NativeTypeName("ULONG *")] uint* pcReturned);
        [VtblIndex(4)]
        HRESULT Push(byte* buf, [NativeTypeName("ULONG")] uint cSent);
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
        [NativeTypeName("HRESULT (BYTE *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, uint*, int> Pull;
        [NativeTypeName("HRESULT (BYTE *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> Push;
    }
}