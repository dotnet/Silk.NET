// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='INameSpaceTreeControlFolderCapabilities.xml' path='doc/member[@name="INameSpaceTreeControlFolderCapabilities"]/*'/>
[Guid("E9701183-E6B3-4FF2-8568-813615FEC7BE")]
[NativeTypeName("struct INameSpaceTreeControlFolderCapabilities : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INameSpaceTreeControlFolderCapabilities : INameSpaceTreeControlFolderCapabilities.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INameSpaceTreeControlFolderCapabilities));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlFolderCapabilities*, Guid*, void**, int> )(lpVtbl[0]))((INameSpaceTreeControlFolderCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INameSpaceTreeControlFolderCapabilities*, uint> )(lpVtbl[1]))((INameSpaceTreeControlFolderCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INameSpaceTreeControlFolderCapabilities*, uint> )(lpVtbl[2]))((INameSpaceTreeControlFolderCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INameSpaceTreeControlFolderCapabilities.xml' path='doc/member[@name="INameSpaceTreeControlFolderCapabilities.GetFolderCapabilities"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFolderCapabilities(NSTCFOLDERCAPABILITIES nfcMask, NSTCFOLDERCAPABILITIES* pnfcValue)
    {
        return ((delegate* unmanaged<INameSpaceTreeControlFolderCapabilities*, NSTCFOLDERCAPABILITIES, NSTCFOLDERCAPABILITIES*, int> )(lpVtbl[3]))((INameSpaceTreeControlFolderCapabilities*)Unsafe.AsPointer(ref this), nfcMask, pnfcValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFolderCapabilities(NSTCFOLDERCAPABILITIES nfcMask, NSTCFOLDERCAPABILITIES* pnfcValue);
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
        [NativeTypeName("HRESULT (NSTCFOLDERCAPABILITIES, NSTCFOLDERCAPABILITIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, NSTCFOLDERCAPABILITIES, NSTCFOLDERCAPABILITIES*, int> GetFolderCapabilities;
    }
}