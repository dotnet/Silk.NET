// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IInitializeWithPropertyStore.xml' path='doc/member[@name="IInitializeWithPropertyStore"]/*'/>
[Guid("C3E12EB5-7D8D-44F8-B6DD-0E77B34D6DE4")]
[NativeTypeName("struct IInitializeWithPropertyStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInitializeWithPropertyStore : IInitializeWithPropertyStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInitializeWithPropertyStore));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInitializeWithPropertyStore*, Guid*, void**, int> )(lpVtbl[0]))((IInitializeWithPropertyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInitializeWithPropertyStore*, uint> )(lpVtbl[1]))((IInitializeWithPropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInitializeWithPropertyStore*, uint> )(lpVtbl[2]))((IInitializeWithPropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInitializeWithPropertyStore.xml' path='doc/member[@name="IInitializeWithPropertyStore.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(IPropertyStore* pps)
    {
        return ((delegate* unmanaged<IInitializeWithPropertyStore*, IPropertyStore*, int> )(lpVtbl[3]))((IInitializeWithPropertyStore*)Unsafe.AsPointer(ref this), pps);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(IPropertyStore* pps);
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
        [NativeTypeName("HRESULT (IPropertyStore *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStore*, int> Initialize;
    }
}