// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IEnumProgressItems.xml' path='doc/member[@name="IEnumProgressItems"]/*'/>
[Guid("2C941FD6-975B-59BE-A960-9A2A262853A5")]
[NativeTypeName("struct IEnumProgressItems : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumProgressItems : IEnumProgressItems.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumProgressItems));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumProgressItems*, Guid*, void**, int> )(lpVtbl[0]))((IEnumProgressItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumProgressItems*, uint> )(lpVtbl[1]))((IEnumProgressItems*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumProgressItems*, uint> )(lpVtbl[2]))((IEnumProgressItems*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumProgressItems.xml' path='doc/member[@name="IEnumProgressItems.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, IProgressItem** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IEnumProgressItems*, uint, IProgressItem**, uint*, int> )(lpVtbl[3]))((IEnumProgressItems*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IEnumProgressItems.xml' path='doc/member[@name="IEnumProgressItems.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IEnumProgressItems*, uint, int> )(lpVtbl[4]))((IEnumProgressItems*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IEnumProgressItems.xml' path='doc/member[@name="IEnumProgressItems.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumProgressItems*, int> )(lpVtbl[5]))((IEnumProgressItems*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumProgressItems.xml' path='doc/member[@name="IEnumProgressItems.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumProgressItems** ppEnum)
    {
        return ((delegate* unmanaged<IEnumProgressItems*, IEnumProgressItems**, int> )(lpVtbl[6]))((IEnumProgressItems*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, IProgressItem** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);
        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Clone(IEnumProgressItems** ppEnum);
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
        [NativeTypeName("HRESULT (ULONG, IProgressItem **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IProgressItem**, uint*, int> Next;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (IEnumProgressItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumProgressItems**, int> Clone;
    }
}