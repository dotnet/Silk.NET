// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IActivationFilter.xml' path='doc/member[@name="IActivationFilter"]/*'/>
[Guid("00000017-0000-0000-C000-000000000046")]
[NativeTypeName("struct IActivationFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IActivationFilter : IActivationFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActivationFilter));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActivationFilter*, Guid*, void**, int> )(lpVtbl[0]))((IActivationFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IActivationFilter*, uint> )(lpVtbl[1]))((IActivationFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActivationFilter*, uint> )(lpVtbl[2]))((IActivationFilter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IActivationFilter.xml' path='doc/member[@name="IActivationFilter.HandleActivation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT HandleActivation([NativeTypeName("DWORD")] uint dwActivationType, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("CLSID *")] Guid* pReplacementClsId)
    {
        return ((delegate* unmanaged<IActivationFilter*, uint, Guid*, Guid*, int> )(lpVtbl[3]))((IActivationFilter*)Unsafe.AsPointer(ref this), dwActivationType, rclsid, pReplacementClsId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT HandleActivation([NativeTypeName("DWORD")] uint dwActivationType, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("CLSID *")] Guid* pReplacementClsId);
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
        [NativeTypeName("HRESULT (DWORD, const IID &, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, int> HandleActivation;
    }
}