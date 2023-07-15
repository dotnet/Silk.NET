// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFRemoteDesktopPlugin.xml' path='doc/member[@name="IMFRemoteDesktopPlugin"]/*'/>
[Guid("1CDE6309-CAE0-4940-907E-C1EC9C3D1D4A")]
[NativeTypeName("struct IMFRemoteDesktopPlugin : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFRemoteDesktopPlugin : IMFRemoteDesktopPlugin.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFRemoteDesktopPlugin));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFRemoteDesktopPlugin*, Guid*, void**, int> )(lpVtbl[0]))((IMFRemoteDesktopPlugin*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFRemoteDesktopPlugin*, uint> )(lpVtbl[1]))((IMFRemoteDesktopPlugin*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFRemoteDesktopPlugin*, uint> )(lpVtbl[2]))((IMFRemoteDesktopPlugin*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFRemoteDesktopPlugin.xml' path='doc/member[@name="IMFRemoteDesktopPlugin.UpdateTopology"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UpdateTopology(IMFTopology* pTopology)
    {
        return ((delegate* unmanaged<IMFRemoteDesktopPlugin*, IMFTopology*, int> )(lpVtbl[3]))((IMFRemoteDesktopPlugin*)Unsafe.AsPointer(ref this), pTopology);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT UpdateTopology(IMFTopology* pTopology);
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
        public delegate* unmanaged<TSelf*, IMFTopology*, int> UpdateTopology;
    }
}