// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/comcat.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IEnumCATEGORYINFO.xml' path='doc/member[@name="IEnumCATEGORYINFO"]/*'/>
[Guid("0002E011-0000-0000-C000-000000000046")]
[NativeTypeName("struct IEnumCATEGORYINFO : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumCATEGORYINFO : IEnumCATEGORYINFO.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumCATEGORYINFO));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumCATEGORYINFO*, Guid*, void**, int> )(lpVtbl[0]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumCATEGORYINFO*, uint> )(lpVtbl[1]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumCATEGORYINFO*, uint> )(lpVtbl[2]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumCATEGORYINFO.xml' path='doc/member[@name="IEnumCATEGORYINFO.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, CATEGORYINFO* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IEnumCATEGORYINFO*, uint, CATEGORYINFO*, uint*, int> )(lpVtbl[3]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IEnumCATEGORYINFO.xml' path='doc/member[@name="IEnumCATEGORYINFO.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IEnumCATEGORYINFO*, uint, int> )(lpVtbl[4]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IEnumCATEGORYINFO.xml' path='doc/member[@name="IEnumCATEGORYINFO.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumCATEGORYINFO*, int> )(lpVtbl[5]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumCATEGORYINFO.xml' path='doc/member[@name="IEnumCATEGORYINFO.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumCATEGORYINFO** ppenum)
    {
        return ((delegate* unmanaged<IEnumCATEGORYINFO*, IEnumCATEGORYINFO**, int> )(lpVtbl[6]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, CATEGORYINFO* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);
        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Clone(IEnumCATEGORYINFO** ppenum);
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
        [NativeTypeName("HRESULT (ULONG, CATEGORYINFO *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, CATEGORYINFO*, uint*, int> Next;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (IEnumCATEGORYINFO **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumCATEGORYINFO**, int> Clone;
    }
}