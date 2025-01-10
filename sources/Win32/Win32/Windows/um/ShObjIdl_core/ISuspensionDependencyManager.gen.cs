// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("52B83A42-2543-416A-81D9-C0DE7969C8B3")]
[NativeTypeName("struct ISuspensionDependencyManager : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ISuspensionDependencyManager
    : ISuspensionDependencyManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISuspensionDependencyManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISuspensionDependencyManager, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISuspensionDependencyManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISuspensionDependencyManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterAsChild(HANDLE processHandle)
    {
        return ((delegate* unmanaged<ISuspensionDependencyManager, HANDLE, int>)((*lpVtbl)[3]))(
            this,
            processHandle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GroupChildWithParent(HANDLE childProcessHandle)
    {
        return ((delegate* unmanaged<ISuspensionDependencyManager, HANDLE, int>)((*lpVtbl)[4]))(
            this,
            childProcessHandle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT UngroupChildFromParent(HANDLE childProcessHandle)
    {
        return ((delegate* unmanaged<ISuspensionDependencyManager, HANDLE, int>)((*lpVtbl)[5]))(
            this,
            childProcessHandle
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterAsChild(HANDLE processHandle);

        [VtblIndex(4)]
        HRESULT GroupChildWithParent(HANDLE childProcessHandle);

        [VtblIndex(5)]
        HRESULT UngroupChildFromParent(HANDLE childProcessHandle);
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

        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> RegisterAsChild;

        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> GroupChildWithParent;

        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> UngroupChildFromParent;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISuspensionDependencyManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISuspensionDependencyManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISuspensionDependencyManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISuspensionDependencyManager(Silk.NET.Windows.IUnknown value)
    {
        return new ISuspensionDependencyManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISuspensionDependencyManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISuspensionDependencyManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISuspensionDependencyManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
