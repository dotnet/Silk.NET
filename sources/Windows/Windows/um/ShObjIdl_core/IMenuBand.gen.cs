// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMenuBand.xml' path='doc/member[@name="IMenuBand"]/*'/>
[Guid("568804CD-CBD7-11D0-9816-00C04FD91972")]
[NativeTypeName("struct IMenuBand : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMenuBand : IMenuBand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMenuBand));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMenuBand*, Guid*, void**, int> )(lpVtbl[0]))((IMenuBand*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMenuBand*, uint> )(lpVtbl[1]))((IMenuBand*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMenuBand*, uint> )(lpVtbl[2]))((IMenuBand*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMenuBand.xml' path='doc/member[@name="IMenuBand.IsMenuMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsMenuMessage(MSG* pmsg)
    {
        return ((delegate* unmanaged<IMenuBand*, MSG*, int> )(lpVtbl[3]))((IMenuBand*)Unsafe.AsPointer(ref this), pmsg);
    }

    /// <include file='IMenuBand.xml' path='doc/member[@name="IMenuBand.TranslateMenuMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TranslateMenuMessage(MSG* pmsg, LRESULT* plRet)
    {
        return ((delegate* unmanaged<IMenuBand*, MSG*, LRESULT*, int> )(lpVtbl[4]))((IMenuBand*)Unsafe.AsPointer(ref this), pmsg, plRet);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsMenuMessage(MSG* pmsg);
        [VtblIndex(4)]
        HRESULT TranslateMenuMessage(MSG* pmsg, LRESULT* plRet);
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
        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> IsMenuMessage;
        [NativeTypeName("HRESULT (MSG *, LRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, LRESULT*, int> TranslateMenuMessage;
    }
}