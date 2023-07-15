// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IVMRMonitorConfig.xml' path='doc/member[@name="IVMRMonitorConfig"]/*'/>
[Guid("9CF0B1B6-FBAA-4B7F-88CF-CF1F130A0DCE")]
[NativeTypeName("struct IVMRMonitorConfig : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRMonitorConfig : IVMRMonitorConfig.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRMonitorConfig));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRMonitorConfig*, Guid*, void**, int> )(lpVtbl[0]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVMRMonitorConfig*, uint> )(lpVtbl[1]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRMonitorConfig*, uint> )(lpVtbl[2]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVMRMonitorConfig.xml' path='doc/member[@name="IVMRMonitorConfig.SetMonitor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMonitor([NativeTypeName("const VMRGUID *")] VMRGUID* pGUID)
    {
        return ((delegate* unmanaged<IVMRMonitorConfig*, VMRGUID*, int> )(lpVtbl[3]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pGUID);
    }

    /// <include file='IVMRMonitorConfig.xml' path='doc/member[@name="IVMRMonitorConfig.GetMonitor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMonitor(VMRGUID* pGUID)
    {
        return ((delegate* unmanaged<IVMRMonitorConfig*, VMRGUID*, int> )(lpVtbl[4]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pGUID);
    }

    /// <include file='IVMRMonitorConfig.xml' path='doc/member[@name="IVMRMonitorConfig.SetDefaultMonitor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDefaultMonitor([NativeTypeName("const VMRGUID *")] VMRGUID* pGUID)
    {
        return ((delegate* unmanaged<IVMRMonitorConfig*, VMRGUID*, int> )(lpVtbl[5]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pGUID);
    }

    /// <include file='IVMRMonitorConfig.xml' path='doc/member[@name="IVMRMonitorConfig.GetDefaultMonitor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefaultMonitor(VMRGUID* pGUID)
    {
        return ((delegate* unmanaged<IVMRMonitorConfig*, VMRGUID*, int> )(lpVtbl[6]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pGUID);
    }

    /// <include file='IVMRMonitorConfig.xml' path='doc/member[@name="IVMRMonitorConfig.GetAvailableMonitors"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAvailableMonitors(VMRMONITORINFO* pInfo, [NativeTypeName("DWORD")] uint dwMaxInfoArraySize, [NativeTypeName("DWORD *")] uint* pdwNumDevices)
    {
        return ((delegate* unmanaged<IVMRMonitorConfig*, VMRMONITORINFO*, uint, uint*, int> )(lpVtbl[7]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pInfo, dwMaxInfoArraySize, pdwNumDevices);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMonitor([NativeTypeName("const VMRGUID *")] VMRGUID* pGUID);
        [VtblIndex(4)]
        HRESULT GetMonitor(VMRGUID* pGUID);
        [VtblIndex(5)]
        HRESULT SetDefaultMonitor([NativeTypeName("const VMRGUID *")] VMRGUID* pGUID);
        [VtblIndex(6)]
        HRESULT GetDefaultMonitor(VMRGUID* pGUID);
        [VtblIndex(7)]
        HRESULT GetAvailableMonitors(VMRMONITORINFO* pInfo, [NativeTypeName("DWORD")] uint dwMaxInfoArraySize, [NativeTypeName("DWORD *")] uint* pdwNumDevices);
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
        [NativeTypeName("HRESULT (const VMRGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VMRGUID*, int> SetMonitor;
        [NativeTypeName("HRESULT (VMRGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VMRGUID*, int> GetMonitor;
        [NativeTypeName("HRESULT (const VMRGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VMRGUID*, int> SetDefaultMonitor;
        [NativeTypeName("HRESULT (VMRGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VMRGUID*, int> GetDefaultMonitor;
        [NativeTypeName("HRESULT (VMRMONITORINFO *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VMRMONITORINFO*, uint, uint*, int> GetAvailableMonitors;
    }
}