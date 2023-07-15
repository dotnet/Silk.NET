// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/WeakReference.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IWeakReference.xml' path='doc/member[@name="IWeakReference"]/*'/>
[Guid("00000037-0000-0000-C000-000000000046")]
[NativeTypeName("struct IWeakReference : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWeakReference : IWeakReference.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWeakReference));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWeakReference*, Guid*, void**, int> )(lpVtbl[0]))((IWeakReference*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWeakReference*, uint> )(lpVtbl[1]))((IWeakReference*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWeakReference*, uint> )(lpVtbl[2]))((IWeakReference*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWeakReference.xml' path='doc/member[@name="IWeakReference.Resolve"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Resolve([NativeTypeName("const IID &")] Guid* riid, IInspectable** objectReference)
    {
        return ((delegate* unmanaged<IWeakReference*, Guid*, IInspectable**, int> )(lpVtbl[3]))((IWeakReference*)Unsafe.AsPointer(ref this), riid, objectReference);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Resolve([NativeTypeName("const IID &")] Guid* riid, IInspectable** objectReference);
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
        [NativeTypeName("HRESULT (const IID &, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IInspectable**, int> Resolve;
    }
}