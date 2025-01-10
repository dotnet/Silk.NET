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

[Guid("18B21AA9-E184-4FF0-9F5E-F882D03771B3")]
[NativeTypeName("struct IExecuteCommandApplicationHostEnvironment : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IExecuteCommandApplicationHostEnvironment
    : IExecuteCommandApplicationHostEnvironment.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExecuteCommandApplicationHostEnvironment));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IExecuteCommandApplicationHostEnvironment, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IExecuteCommandApplicationHostEnvironment, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IExecuteCommandApplicationHostEnvironment, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetValue(AHE_TYPE* pahe)
    {
        return (
            (delegate* unmanaged<IExecuteCommandApplicationHostEnvironment, AHE_TYPE*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pahe);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetValue(AHE_TYPE* pahe);
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

        [NativeTypeName("HRESULT (AHE_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AHE_TYPE*, int> GetValue;
    }

    /// <summary>Initializes a new instance of the <see cref = "IExecuteCommandApplicationHostEnvironment"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IExecuteCommandApplicationHostEnvironment(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IExecuteCommandApplicationHostEnvironment"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IExecuteCommandApplicationHostEnvironment(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IExecuteCommandApplicationHostEnvironment(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IExecuteCommandApplicationHostEnvironment"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IExecuteCommandApplicationHostEnvironment"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IExecuteCommandApplicationHostEnvironment value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
