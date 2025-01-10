// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1CDE6309-CAE0-4940-907E-C1EC9C3D1D4A")]
[NativeTypeName("struct IMFRemoteDesktopPlugin : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFRemoteDesktopPlugin : IMFRemoteDesktopPlugin.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFRemoteDesktopPlugin));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFRemoteDesktopPlugin, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFRemoteDesktopPlugin, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFRemoteDesktopPlugin, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UpdateTopology(IMFTopology pTopology)
    {
        return ((delegate* unmanaged<IMFRemoteDesktopPlugin, IMFTopology, int>)((*lpVtbl)[3]))(
            this,
            pTopology
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT UpdateTopology(IMFTopology pTopology);
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

        [NativeTypeName("HRESULT (IMFTopology *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTopology, int> UpdateTopology;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFRemoteDesktopPlugin"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFRemoteDesktopPlugin(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFRemoteDesktopPlugin"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFRemoteDesktopPlugin(Silk.NET.Windows.IUnknown value)
    {
        return new IMFRemoteDesktopPlugin(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFRemoteDesktopPlugin"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFRemoteDesktopPlugin"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFRemoteDesktopPlugin value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
