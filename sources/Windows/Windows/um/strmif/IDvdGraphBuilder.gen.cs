// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IDvdGraphBuilder.xml' path='doc/member[@name="IDvdGraphBuilder"]/*'/>
[Guid("FCC152B6-F372-11D0-8E00-00C04FD7C08B")]
[NativeTypeName("struct IDvdGraphBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDvdGraphBuilder : IDvdGraphBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDvdGraphBuilder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDvdGraphBuilder*, Guid*, void**, int> )(lpVtbl[0]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDvdGraphBuilder*, uint> )(lpVtbl[1]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDvdGraphBuilder*, uint> )(lpVtbl[2]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdGraphBuilder.xml' path='doc/member[@name="IDvdGraphBuilder.GetFiltergraph"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFiltergraph(IGraphBuilder** ppGB)
    {
        return ((delegate* unmanaged<IDvdGraphBuilder*, IGraphBuilder**, int> )(lpVtbl[3]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this), ppGB);
    }

    /// <include file='IDvdGraphBuilder.xml' path='doc/member[@name="IDvdGraphBuilder.GetDvdInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDvdInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvIF)
    {
        return ((delegate* unmanaged<IDvdGraphBuilder*, Guid*, void**, int> )(lpVtbl[4]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this), riid, ppvIF);
    }

    /// <include file='IDvdGraphBuilder.xml' path='doc/member[@name="IDvdGraphBuilder.RenderDvdVideoVolume"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RenderDvdVideoVolume([NativeTypeName("LPCWSTR")] ushort* lpcwszPathName, [NativeTypeName("DWORD")] uint dwFlags, AM_DVD_RENDERSTATUS* pStatus)
    {
        return ((delegate* unmanaged<IDvdGraphBuilder*, ushort*, uint, AM_DVD_RENDERSTATUS*, int> )(lpVtbl[5]))((IDvdGraphBuilder*)Unsafe.AsPointer(ref this), lpcwszPathName, dwFlags, pStatus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFiltergraph(IGraphBuilder** ppGB);
        [VtblIndex(4)]
        HRESULT GetDvdInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvIF);
        [VtblIndex(5)]
        HRESULT RenderDvdVideoVolume([NativeTypeName("LPCWSTR")] ushort* lpcwszPathName, [NativeTypeName("DWORD")] uint dwFlags, AM_DVD_RENDERSTATUS* pStatus);
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
        public delegate* unmanaged<TSelf*, IGraphBuilder**, int> GetFiltergraph;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDvdInterface;
        [NativeTypeName("HRESULT (LPCWSTR, DWORD, AM_DVD_RENDERSTATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, AM_DVD_RENDERSTATUS*, int> RenderDvdVideoVolume;
    }
}