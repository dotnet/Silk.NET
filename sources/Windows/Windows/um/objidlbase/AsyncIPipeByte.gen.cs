// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='AsyncIPipeByte.xml' path='doc/member[@name="AsyncIPipeByte"]/*'/>
[Guid("DB2F3ACB-2F86-11D1-8E04-00C04FB9989A")]
[NativeTypeName("struct AsyncIPipeByte : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct AsyncIPipeByte : AsyncIPipeByte.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_AsyncIPipeByte));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<AsyncIPipeByte*, Guid*, void**, int> )(lpVtbl[0]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<AsyncIPipeByte*, uint> )(lpVtbl[1]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<AsyncIPipeByte*, uint> )(lpVtbl[2]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this));
    }

    /// <include file='AsyncIPipeByte.xml' path='doc/member[@name="AsyncIPipeByte.Begin_Pull"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Begin_Pull([NativeTypeName("ULONG")] uint cRequest)
    {
        return ((delegate* unmanaged<AsyncIPipeByte*, uint, int> )(lpVtbl[3]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this), cRequest);
    }

    /// <include file='AsyncIPipeByte.xml' path='doc/member[@name="AsyncIPipeByte.Finish_Pull"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Finish_Pull(byte* buf, [NativeTypeName("ULONG *")] uint* pcReturned)
    {
        return ((delegate* unmanaged<AsyncIPipeByte*, byte*, uint*, int> )(lpVtbl[4]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this), buf, pcReturned);
    }

    /// <include file='AsyncIPipeByte.xml' path='doc/member[@name="AsyncIPipeByte.Begin_Push"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Begin_Push(byte* buf, [NativeTypeName("ULONG")] uint cSent)
    {
        return ((delegate* unmanaged<AsyncIPipeByte*, byte*, uint, int> )(lpVtbl[5]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this), buf, cSent);
    }

    /// <include file='AsyncIPipeByte.xml' path='doc/member[@name="AsyncIPipeByte.Finish_Push"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Finish_Push()
    {
        return ((delegate* unmanaged<AsyncIPipeByte*, int> )(lpVtbl[6]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Begin_Pull([NativeTypeName("ULONG")] uint cRequest);
        [VtblIndex(4)]
        HRESULT Finish_Pull(byte* buf, [NativeTypeName("ULONG *")] uint* pcReturned);
        [VtblIndex(5)]
        HRESULT Begin_Push(byte* buf, [NativeTypeName("ULONG")] uint cSent);
        [VtblIndex(6)]
        HRESULT Finish_Push();
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
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Begin_Pull;
        [NativeTypeName("HRESULT (BYTE *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint*, int> Finish_Pull;
        [NativeTypeName("HRESULT (BYTE *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> Begin_Push;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Finish_Push;
    }
}