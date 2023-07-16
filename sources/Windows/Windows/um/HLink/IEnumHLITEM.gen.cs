// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IEnumHLITEM.xml' path='doc/member[@name="IEnumHLITEM"]/*'/>
[Guid("79EAC9C6-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IEnumHLITEM : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumHLITEM : IEnumHLITEM.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumHLITEM));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumHLITEM*, Guid*, void**, int> )(lpVtbl[0]))((IEnumHLITEM*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumHLITEM*, uint> )(lpVtbl[1]))((IEnumHLITEM*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumHLITEM*, uint> )(lpVtbl[2]))((IEnumHLITEM*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumHLITEM.xml' path='doc/member[@name="IEnumHLITEM.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, HLITEM* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IEnumHLITEM*, uint, HLITEM*, uint*, int> )(lpVtbl[3]))((IEnumHLITEM*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IEnumHLITEM.xml' path='doc/member[@name="IEnumHLITEM.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IEnumHLITEM*, uint, int> )(lpVtbl[4]))((IEnumHLITEM*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IEnumHLITEM.xml' path='doc/member[@name="IEnumHLITEM.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumHLITEM*, int> )(lpVtbl[5]))((IEnumHLITEM*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumHLITEM.xml' path='doc/member[@name="IEnumHLITEM.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumHLITEM** ppienumhlitem)
    {
        return ((delegate* unmanaged<IEnumHLITEM*, IEnumHLITEM**, int> )(lpVtbl[6]))((IEnumHLITEM*)Unsafe.AsPointer(ref this), ppienumhlitem);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, HLITEM* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);
        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Clone(IEnumHLITEM** ppienumhlitem);
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
        [NativeTypeName("HRESULT (ULONG, HLITEM *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HLITEM*, uint*, int> Next;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (IEnumHLITEM **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumHLITEM**, int> Clone;
    }
}