// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IActiveIMMMessagePumpOwner.xml' path='doc/member[@name="IActiveIMMMessagePumpOwner"]/*'/>
[Guid("B5CF2CFA-8AEB-11D1-9364-0060B067B86E")]
[NativeTypeName("struct IActiveIMMMessagePumpOwner : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IActiveIMMMessagePumpOwner : IActiveIMMMessagePumpOwner.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActiveIMMMessagePumpOwner));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, Guid*, void**, int> )(lpVtbl[0]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, uint> )(lpVtbl[1]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, uint> )(lpVtbl[2]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IActiveIMMMessagePumpOwner.xml' path='doc/member[@name="IActiveIMMMessagePumpOwner.Start"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, int> )(lpVtbl[3]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IActiveIMMMessagePumpOwner.xml' path='doc/member[@name="IActiveIMMMessagePumpOwner.End"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT End()
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, int> )(lpVtbl[4]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IActiveIMMMessagePumpOwner.xml' path='doc/member[@name="IActiveIMMMessagePumpOwner.OnTranslateMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnTranslateMessage([NativeTypeName("const MSG *")] MSG* pMsg)
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, MSG*, int> )(lpVtbl[5]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this), pMsg);
    }

    /// <include file='IActiveIMMMessagePumpOwner.xml' path='doc/member[@name="IActiveIMMMessagePumpOwner.Pause"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Pause([NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, uint*, int> )(lpVtbl[6]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this), pdwCookie);
    }

    /// <include file='IActiveIMMMessagePumpOwner.xml' path='doc/member[@name="IActiveIMMMessagePumpOwner.Resume"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Resume([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, uint, int> )(lpVtbl[7]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this), dwCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Start();
        [VtblIndex(4)]
        HRESULT End();
        [VtblIndex(5)]
        HRESULT OnTranslateMessage([NativeTypeName("const MSG *")] MSG* pMsg);
        [VtblIndex(6)]
        HRESULT Pause([NativeTypeName("DWORD *")] uint* pdwCookie);
        [VtblIndex(7)]
        HRESULT Resume([NativeTypeName("DWORD")] uint dwCookie);
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> End;
        [NativeTypeName("HRESULT (const MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> OnTranslateMessage;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> Pause;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Resume;
    }
}