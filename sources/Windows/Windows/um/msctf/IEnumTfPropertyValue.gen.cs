// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IEnumTfPropertyValue.xml' path='doc/member[@name="IEnumTfPropertyValue"]/*'/>
[Guid("8ED8981B-7C10-4D7D-9FB3-AB72E9C75F72")]
[NativeTypeName("struct IEnumTfPropertyValue : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTfPropertyValue : IEnumTfPropertyValue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumTfPropertyValue));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumTfPropertyValue*, Guid*, void**, int> )(lpVtbl[0]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumTfPropertyValue*, uint> )(lpVtbl[1]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumTfPropertyValue*, uint> )(lpVtbl[2]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfPropertyValue.xml' path='doc/member[@name="IEnumTfPropertyValue.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumTfPropertyValue** ppEnum)
    {
        return ((delegate* unmanaged<IEnumTfPropertyValue*, IEnumTfPropertyValue**, int> )(lpVtbl[3]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IEnumTfPropertyValue.xml' path='doc/member[@name="IEnumTfPropertyValue.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, TF_PROPERTYVAL* rgValues, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumTfPropertyValue*, uint, TF_PROPERTYVAL*, uint*, int> )(lpVtbl[4]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this), ulCount, rgValues, pcFetched);
    }

    /// <include file='IEnumTfPropertyValue.xml' path='doc/member[@name="IEnumTfPropertyValue.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumTfPropertyValue*, int> )(lpVtbl[5]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfPropertyValue.xml' path='doc/member[@name="IEnumTfPropertyValue.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumTfPropertyValue*, uint, int> )(lpVtbl[6]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumTfPropertyValue** ppEnum);
        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, TF_PROPERTYVAL* rgValues, [NativeTypeName("ULONG *")] uint* pcFetched);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("ULONG")] uint ulCount);
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
        [NativeTypeName("HRESULT (IEnumTfPropertyValue **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfPropertyValue**, int> Clone;
        [NativeTypeName("HRESULT (ULONG, TF_PROPERTYVAL *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TF_PROPERTYVAL*, uint*, int> Next;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }
}