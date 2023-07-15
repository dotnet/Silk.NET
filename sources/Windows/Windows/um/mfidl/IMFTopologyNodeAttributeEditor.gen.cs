// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFTopologyNodeAttributeEditor.xml' path='doc/member[@name="IMFTopologyNodeAttributeEditor"]/*'/>
[Guid("676AA6DD-238A-410D-BB99-65668D01605A")]
[NativeTypeName("struct IMFTopologyNodeAttributeEditor : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTopologyNodeAttributeEditor : IMFTopologyNodeAttributeEditor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTopologyNodeAttributeEditor));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTopologyNodeAttributeEditor*, Guid*, void**, int> )(lpVtbl[0]))((IMFTopologyNodeAttributeEditor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTopologyNodeAttributeEditor*, uint> )(lpVtbl[1]))((IMFTopologyNodeAttributeEditor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTopologyNodeAttributeEditor*, uint> )(lpVtbl[2]))((IMFTopologyNodeAttributeEditor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTopologyNodeAttributeEditor.xml' path='doc/member[@name="IMFTopologyNodeAttributeEditor.UpdateNodeAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UpdateNodeAttributes([NativeTypeName("TOPOID")] ulong TopoId, [NativeTypeName("DWORD")] uint cUpdates, MFTOPONODE_ATTRIBUTE_UPDATE* pUpdates)
    {
        return ((delegate* unmanaged<IMFTopologyNodeAttributeEditor*, ulong, uint, MFTOPONODE_ATTRIBUTE_UPDATE*, int> )(lpVtbl[3]))((IMFTopologyNodeAttributeEditor*)Unsafe.AsPointer(ref this), TopoId, cUpdates, pUpdates);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT UpdateNodeAttributes([NativeTypeName("TOPOID")] ulong TopoId, [NativeTypeName("DWORD")] uint cUpdates, MFTOPONODE_ATTRIBUTE_UPDATE* pUpdates);
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
        [NativeTypeName("HRESULT (TOPOID, DWORD, MFTOPONODE_ATTRIBUTE_UPDATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, uint, MFTOPONODE_ATTRIBUTE_UPDATE*, int> UpdateNodeAttributes;
    }
}