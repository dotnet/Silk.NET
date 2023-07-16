// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHomeGroup.xml' path='doc/member[@name="IHomeGroup"]/*'/>
[Guid("7A3BD1D9-35A9-4FB3-A467-F48CAC35E2D0")]
[NativeTypeName("struct IHomeGroup : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHomeGroup : IHomeGroup.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHomeGroup));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHomeGroup*, Guid*, void**, int> )(lpVtbl[0]))((IHomeGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHomeGroup*, uint> )(lpVtbl[1]))((IHomeGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHomeGroup*, uint> )(lpVtbl[2]))((IHomeGroup*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHomeGroup.xml' path='doc/member[@name="IHomeGroup.IsMember"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsMember(BOOL* member)
    {
        return ((delegate* unmanaged<IHomeGroup*, BOOL*, int> )(lpVtbl[3]))((IHomeGroup*)Unsafe.AsPointer(ref this), member);
    }

    /// <include file='IHomeGroup.xml' path='doc/member[@name="IHomeGroup.ShowSharingWizard"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ShowSharingWizard(HWND owner, HOMEGROUPSHARINGCHOICES* sharingchoices)
    {
        return ((delegate* unmanaged<IHomeGroup*, HWND, HOMEGROUPSHARINGCHOICES*, int> )(lpVtbl[4]))((IHomeGroup*)Unsafe.AsPointer(ref this), owner, sharingchoices);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsMember(BOOL* member);
        [VtblIndex(4)]
        HRESULT ShowSharingWizard(HWND owner, HOMEGROUPSHARINGCHOICES* sharingchoices);
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
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsMember;
        [NativeTypeName("HRESULT (HWND, HOMEGROUPSHARINGCHOICES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HOMEGROUPSHARINGCHOICES*, int> ShowSharingWizard;
    }
}