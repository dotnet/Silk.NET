// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DE9A6157-F660-4643-B56A-DF9F7998C7CD")]
[NativeTypeName("struct IMFTopoLoader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTopoLoader : IMFTopoLoader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTopoLoader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTopoLoader, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFTopoLoader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTopoLoader, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(IMFTopology pInputTopo, IMFTopology* ppOutputTopo, IMFTopology pCurrentTopo)
    {
        return (
            (delegate* unmanaged<IMFTopoLoader, IMFTopology, IMFTopology*, IMFTopology, int>)(
                (*lpVtbl)[3]
            )
        )(this, pInputTopo, ppOutputTopo, pCurrentTopo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Load(IMFTopology pInputTopo, IMFTopology* ppOutputTopo, IMFTopology pCurrentTopo);
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
            "HRESULT (IMFTopology *, IMFTopology **, IMFTopology *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMFTopology, IMFTopology*, IMFTopology, int> Load;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTopoLoader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTopoLoader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTopoLoader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTopoLoader(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTopoLoader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTopoLoader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTopoLoader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTopoLoader value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
