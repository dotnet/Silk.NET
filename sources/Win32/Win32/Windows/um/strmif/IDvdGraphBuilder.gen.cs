// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FCC152B6-F372-11D0-8E00-00C04FD7C08B")]
[NativeTypeName("struct IDvdGraphBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDvdGraphBuilder : IDvdGraphBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDvdGraphBuilder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDvdGraphBuilder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDvdGraphBuilder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDvdGraphBuilder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFiltergraph(IGraphBuilder* ppGB)
    {
        return ((delegate* unmanaged<IDvdGraphBuilder, IGraphBuilder*, int>)((*lpVtbl)[3]))(
            this,
            ppGB
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDvdInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvIF)
    {
        return ((delegate* unmanaged<IDvdGraphBuilder, Guid*, void**, int>)((*lpVtbl)[4]))(
            this,
            riid,
            ppvIF
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RenderDvdVideoVolume(
        [NativeTypeName("LPCWSTR")] ushort* lpcwszPathName,
        [NativeTypeName("DWORD")] uint dwFlags,
        AM_DVD_RENDERSTATUS* pStatus
    )
    {
        return (
            (delegate* unmanaged<IDvdGraphBuilder, ushort*, uint, AM_DVD_RENDERSTATUS*, int>)(
                (*lpVtbl)[5]
            )
        )(this, lpcwszPathName, dwFlags, pStatus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFiltergraph(IGraphBuilder* ppGB);

        [VtblIndex(4)]
        HRESULT GetDvdInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvIF);

        [VtblIndex(5)]
        HRESULT RenderDvdVideoVolume(
            [NativeTypeName("LPCWSTR")] ushort* lpcwszPathName,
            [NativeTypeName("DWORD")] uint dwFlags,
            AM_DVD_RENDERSTATUS* pStatus
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

        [NativeTypeName("HRESULT (IGraphBuilder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IGraphBuilder*, int> GetFiltergraph;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDvdInterface;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, AM_DVD_RENDERSTATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            AM_DVD_RENDERSTATUS*,
            int> RenderDvdVideoVolume;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDvdGraphBuilder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDvdGraphBuilder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDvdGraphBuilder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDvdGraphBuilder(Silk.NET.Windows.IUnknown value)
    {
        return new IDvdGraphBuilder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDvdGraphBuilder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDvdGraphBuilder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDvdGraphBuilder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
