// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IClassActivator.xml' path='doc/member[@name="IClassActivator"]/*'/>
[Guid("00000140-0000-0000-C000-000000000046")]
[NativeTypeName("struct IClassActivator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IClassActivator : IClassActivator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IClassActivator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IClassActivator*, Guid*, void**, int> )(lpVtbl[0]))((IClassActivator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IClassActivator*, uint> )(lpVtbl[1]))((IClassActivator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IClassActivator*, uint> )(lpVtbl[2]))((IClassActivator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IClassActivator.xml' path='doc/member[@name="IClassActivator.GetClassObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwClassContext, [NativeTypeName("LCID")] uint locale, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IClassActivator*, Guid*, uint, uint, Guid*, void**, int> )(lpVtbl[3]))((IClassActivator*)Unsafe.AsPointer(ref this), rclsid, dwClassContext, locale, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwClassContext, [NativeTypeName("LCID")] uint locale, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
        [NativeTypeName("HRESULT (const IID &, DWORD, LCID, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, uint, Guid*, void**, int> GetClassObject;
    }
}