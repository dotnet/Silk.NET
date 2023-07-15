// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IGetServiceIds.xml' path='doc/member[@name="IGetServiceIds"]/*'/>
[Guid("4A073526-6103-4E21-B7BC-F519D1524E5D")]
[NativeTypeName("struct IGetServiceIds : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGetServiceIds : IGetServiceIds.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGetServiceIds));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGetServiceIds*, Guid*, void**, int> )(lpVtbl[0]))((IGetServiceIds*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGetServiceIds*, uint> )(lpVtbl[1]))((IGetServiceIds*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGetServiceIds*, uint> )(lpVtbl[2]))((IGetServiceIds*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGetServiceIds.xml' path='doc/member[@name="IGetServiceIds.GetServiceIds"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetServiceIds([NativeTypeName("ULONG *")] uint* serviceIdCount, Guid** serviceIds)
    {
        return ((delegate* unmanaged<IGetServiceIds*, uint*, Guid**, int> )(lpVtbl[3]))((IGetServiceIds*)Unsafe.AsPointer(ref this), serviceIdCount, serviceIds);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetServiceIds([NativeTypeName("ULONG *")] uint* serviceIdCount, Guid** serviceIds);
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
        [NativeTypeName("HRESULT (ULONG *, GUID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetServiceIds;
    }
}