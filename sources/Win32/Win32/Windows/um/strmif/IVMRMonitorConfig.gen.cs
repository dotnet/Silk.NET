// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9CF0B1B6-FBAA-4B7F-88CF-CF1F130A0DCE")]
[NativeTypeName("struct IVMRMonitorConfig : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRMonitorConfig : IVMRMonitorConfig.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRMonitorConfig));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRMonitorConfig, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVMRMonitorConfig, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRMonitorConfig, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMonitor([NativeTypeName("const VMRGUID *")] VMRGUID* pGUID)
    {
        return ((delegate* unmanaged<IVMRMonitorConfig, VMRGUID*, int>)((*lpVtbl)[3]))(this, pGUID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMonitor(VMRGUID* pGUID)
    {
        return ((delegate* unmanaged<IVMRMonitorConfig, VMRGUID*, int>)((*lpVtbl)[4]))(this, pGUID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDefaultMonitor([NativeTypeName("const VMRGUID *")] VMRGUID* pGUID)
    {
        return ((delegate* unmanaged<IVMRMonitorConfig, VMRGUID*, int>)((*lpVtbl)[5]))(this, pGUID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefaultMonitor(VMRGUID* pGUID)
    {
        return ((delegate* unmanaged<IVMRMonitorConfig, VMRGUID*, int>)((*lpVtbl)[6]))(this, pGUID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAvailableMonitors(
        VMRMONITORINFO* pInfo,
        [NativeTypeName("DWORD")] uint dwMaxInfoArraySize,
        [NativeTypeName("DWORD *")] uint* pdwNumDevices
    )
    {
        return (
            (delegate* unmanaged<IVMRMonitorConfig, VMRMONITORINFO*, uint, uint*, int>)(
                (*lpVtbl)[7]
            )
        )(this, pInfo, dwMaxInfoArraySize, pdwNumDevices);
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
        HRESULT GetAvailableMonitors(
            VMRMONITORINFO* pInfo,
            [NativeTypeName("DWORD")] uint dwMaxInfoArraySize,
            [NativeTypeName("DWORD *")] uint* pdwNumDevices
        );
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

    /// <summary>Initializes a new instance of the <see cref = "IVMRMonitorConfig"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVMRMonitorConfig(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVMRMonitorConfig"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVMRMonitorConfig(Silk.NET.Windows.IUnknown value)
    {
        return new IVMRMonitorConfig(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVMRMonitorConfig"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVMRMonitorConfig"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVMRMonitorConfig value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
