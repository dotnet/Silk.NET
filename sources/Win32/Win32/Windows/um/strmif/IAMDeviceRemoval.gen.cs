// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F90A6130-B658-11D2-AE49-0000F8754B99")]
[NativeTypeName("struct IAMDeviceRemoval : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMDeviceRemoval : IAMDeviceRemoval.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMDeviceRemoval));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMDeviceRemoval, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMDeviceRemoval, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMDeviceRemoval, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DeviceInfo(
        [NativeTypeName("CLSID *")] Guid* pclsidInterfaceClass,
        [NativeTypeName("LPWSTR *")] ushort** pwszSymbolicLink
    )
    {
        return ((delegate* unmanaged<IAMDeviceRemoval, Guid*, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pclsidInterfaceClass,
            pwszSymbolicLink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Reassociate()
    {
        return ((delegate* unmanaged<IAMDeviceRemoval, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Disassociate()
    {
        return ((delegate* unmanaged<IAMDeviceRemoval, int>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DeviceInfo(
            [NativeTypeName("CLSID *")] Guid* pclsidInterfaceClass,
            [NativeTypeName("LPWSTR *")] ushort** pwszSymbolicLink
        );

        [VtblIndex(4)]
        HRESULT Reassociate();

        [VtblIndex(5)]
        HRESULT Disassociate();
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

        [NativeTypeName("HRESULT (CLSID *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, int> DeviceInfo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reassociate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Disassociate;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMDeviceRemoval"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMDeviceRemoval(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMDeviceRemoval"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMDeviceRemoval(Silk.NET.Windows.IUnknown value)
    {
        return new IAMDeviceRemoval(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMDeviceRemoval"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMDeviceRemoval"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMDeviceRemoval value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
