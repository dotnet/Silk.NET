// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("10DF43C8-1DBE-11D3-8B34-006097DF5BD4")]
[NativeTypeName("struct IBrowserFrameOptions : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBrowserFrameOptions : IBrowserFrameOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBrowserFrameOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBrowserFrameOptions, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBrowserFrameOptions, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBrowserFrameOptions, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFrameOptions(
        [NativeTypeName("BROWSERFRAMEOPTIONS")] uint dwMask,
        [NativeTypeName("BROWSERFRAMEOPTIONS *")] uint* pdwOptions
    )
    {
        return ((delegate* unmanaged<IBrowserFrameOptions, uint, uint*, int>)((*lpVtbl)[3]))(
            this,
            dwMask,
            pdwOptions
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFrameOptions(
            [NativeTypeName("BROWSERFRAMEOPTIONS")] uint dwMask,
            [NativeTypeName("BROWSERFRAMEOPTIONS *")] uint* pdwOptions
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

        [NativeTypeName(
            "HRESULT (BROWSERFRAMEOPTIONS, BROWSERFRAMEOPTIONS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetFrameOptions;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBrowserFrameOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBrowserFrameOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBrowserFrameOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBrowserFrameOptions(Silk.NET.Windows.IUnknown value)
    {
        return new IBrowserFrameOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBrowserFrameOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBrowserFrameOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBrowserFrameOptions value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
