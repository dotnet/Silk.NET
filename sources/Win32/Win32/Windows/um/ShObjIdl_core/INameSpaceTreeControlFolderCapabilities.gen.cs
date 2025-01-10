// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E9701183-E6B3-4FF2-8568-813615FEC7BE")]
[NativeTypeName("struct INameSpaceTreeControlFolderCapabilities : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INameSpaceTreeControlFolderCapabilities
    : INameSpaceTreeControlFolderCapabilities.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INameSpaceTreeControlFolderCapabilities));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlFolderCapabilities, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INameSpaceTreeControlFolderCapabilities, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INameSpaceTreeControlFolderCapabilities, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFolderCapabilities(
        NSTCFOLDERCAPABILITIES nfcMask,
        NSTCFOLDERCAPABILITIES* pnfcValue
    )
    {
        return (
            (delegate* unmanaged<
                INameSpaceTreeControlFolderCapabilities,
                NSTCFOLDERCAPABILITIES,
                NSTCFOLDERCAPABILITIES*,
                int>)((*lpVtbl)[3])
        )(this, nfcMask, pnfcValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFolderCapabilities(
            NSTCFOLDERCAPABILITIES nfcMask,
            NSTCFOLDERCAPABILITIES* pnfcValue
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
            "HRESULT (NSTCFOLDERCAPABILITIES, NSTCFOLDERCAPABILITIES *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            NSTCFOLDERCAPABILITIES,
            NSTCFOLDERCAPABILITIES*,
            int> GetFolderCapabilities;
    }

    /// <summary>Initializes a new instance of the <see cref = "INameSpaceTreeControlFolderCapabilities"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INameSpaceTreeControlFolderCapabilities(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INameSpaceTreeControlFolderCapabilities"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INameSpaceTreeControlFolderCapabilities(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new INameSpaceTreeControlFolderCapabilities(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INameSpaceTreeControlFolderCapabilities"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INameSpaceTreeControlFolderCapabilities"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        INameSpaceTreeControlFolderCapabilities value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
