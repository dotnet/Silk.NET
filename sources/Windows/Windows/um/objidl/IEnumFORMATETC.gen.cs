// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IEnumFORMATETC.xml' path='doc/member[@name="IEnumFORMATETC"]/*'/>
[Guid("00000103-0000-0000-C000-000000000046")]
[NativeTypeName("struct IEnumFORMATETC : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumFORMATETC : IEnumFORMATETC.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumFORMATETC));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumFORMATETC*, Guid*, void**, int> )(lpVtbl[0]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumFORMATETC*, uint> )(lpVtbl[1]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumFORMATETC*, uint> )(lpVtbl[2]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumFORMATETC.xml' path='doc/member[@name="IEnumFORMATETC.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, FORMATETC* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IEnumFORMATETC*, uint, FORMATETC*, uint*, int> )(lpVtbl[3]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IEnumFORMATETC.xml' path='doc/member[@name="IEnumFORMATETC.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IEnumFORMATETC*, uint, int> )(lpVtbl[4]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IEnumFORMATETC.xml' path='doc/member[@name="IEnumFORMATETC.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumFORMATETC*, int> )(lpVtbl[5]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumFORMATETC.xml' path='doc/member[@name="IEnumFORMATETC.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumFORMATETC** ppenum)
    {
        return ((delegate* unmanaged<IEnumFORMATETC*, IEnumFORMATETC**, int> )(lpVtbl[6]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, FORMATETC* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);
        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Clone(IEnumFORMATETC** ppenum);
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
        [NativeTypeName("HRESULT (ULONG, FORMATETC *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, FORMATETC*, uint*, int> Next;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (IEnumFORMATETC **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumFORMATETC**, int> Clone;
    }
}