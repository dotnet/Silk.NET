// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EDE80B5C-BAD6-4623-B537-65586C9F8DFD")]
[NativeTypeName("struct IVMRAspectRatioControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRAspectRatioControl : IVMRAspectRatioControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRAspectRatioControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRAspectRatioControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVMRAspectRatioControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRAspectRatioControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAspectRatioMode([NativeTypeName("LPDWORD")] uint* lpdwARMode)
    {
        return ((delegate* unmanaged<IVMRAspectRatioControl, uint*, int>)((*lpVtbl)[3]))(
            this,
            lpdwARMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetAspectRatioMode([NativeTypeName("DWORD")] uint dwARMode)
    {
        return ((delegate* unmanaged<IVMRAspectRatioControl, uint, int>)((*lpVtbl)[4]))(
            this,
            dwARMode
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAspectRatioMode([NativeTypeName("LPDWORD")] uint* lpdwARMode);

        [VtblIndex(4)]
        HRESULT SetAspectRatioMode([NativeTypeName("DWORD")] uint dwARMode);
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

        [NativeTypeName("HRESULT (LPDWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetAspectRatioMode;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetAspectRatioMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVMRAspectRatioControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVMRAspectRatioControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVMRAspectRatioControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVMRAspectRatioControl(Silk.NET.Windows.IUnknown value)
    {
        return new IVMRAspectRatioControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVMRAspectRatioControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVMRAspectRatioControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVMRAspectRatioControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
