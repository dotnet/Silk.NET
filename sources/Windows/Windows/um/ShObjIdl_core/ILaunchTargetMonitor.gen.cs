// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ILaunchTargetMonitor.xml' path='doc/member[@name="ILaunchTargetMonitor"]/*'/>
[Guid("266FBC7E-490D-46ED-A96B-2274DB252003")]
[NativeTypeName("struct ILaunchTargetMonitor : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ILaunchTargetMonitor : ILaunchTargetMonitor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILaunchTargetMonitor));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILaunchTargetMonitor*, Guid*, void**, int> )(lpVtbl[0]))((ILaunchTargetMonitor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILaunchTargetMonitor*, uint> )(lpVtbl[1]))((ILaunchTargetMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILaunchTargetMonitor*, uint> )(lpVtbl[2]))((ILaunchTargetMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILaunchTargetMonitor.xml' path='doc/member[@name="ILaunchTargetMonitor.GetMonitor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetMonitor(HMONITOR* monitor)
    {
        return ((delegate* unmanaged<ILaunchTargetMonitor*, HMONITOR*, int> )(lpVtbl[3]))((ILaunchTargetMonitor*)Unsafe.AsPointer(ref this), monitor);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetMonitor(HMONITOR* monitor);
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
        [NativeTypeName("HRESULT (HMONITOR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMONITOR*, int> GetMonitor;
    }
}