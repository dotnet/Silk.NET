// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IInternetThreadSwitch.xml' path='doc/member[@name="IInternetThreadSwitch"]/*'/>
[Guid("79EAC9E8-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetThreadSwitch : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetThreadSwitch : IInternetThreadSwitch.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetThreadSwitch));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetThreadSwitch*, Guid*, void**, int> )(lpVtbl[0]))((IInternetThreadSwitch*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInternetThreadSwitch*, uint> )(lpVtbl[1]))((IInternetThreadSwitch*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetThreadSwitch*, uint> )(lpVtbl[2]))((IInternetThreadSwitch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInternetThreadSwitch.xml' path='doc/member[@name="IInternetThreadSwitch.Prepare"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Prepare()
    {
        return ((delegate* unmanaged<IInternetThreadSwitch*, int> )(lpVtbl[3]))((IInternetThreadSwitch*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInternetThreadSwitch.xml' path='doc/member[@name="IInternetThreadSwitch.Continue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Continue()
    {
        return ((delegate* unmanaged<IInternetThreadSwitch*, int> )(lpVtbl[4]))((IInternetThreadSwitch*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Prepare();
        [VtblIndex(4)]
        HRESULT Continue();
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
        public delegate* unmanaged<TSelf*, int> Prepare;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Continue;
    }
}