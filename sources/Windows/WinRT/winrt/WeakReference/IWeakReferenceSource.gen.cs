// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/WeakReference.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IWeakReferenceSource.xml' path='doc/member[@name="IWeakReferenceSource"]/*'/>
[Guid("00000038-0000-0000-C000-000000000046")]
[NativeTypeName("struct IWeakReferenceSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWeakReferenceSource : IWeakReferenceSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWeakReferenceSource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWeakReferenceSource*, Guid*, void**, int> )(lpVtbl[0]))((IWeakReferenceSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWeakReferenceSource*, uint> )(lpVtbl[1]))((IWeakReferenceSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWeakReferenceSource*, uint> )(lpVtbl[2]))((IWeakReferenceSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWeakReferenceSource.xml' path='doc/member[@name="IWeakReferenceSource.GetWeakReference"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWeakReference(IWeakReference** weakReference)
    {
        return ((delegate* unmanaged<IWeakReferenceSource*, IWeakReference**, int> )(lpVtbl[3]))((IWeakReferenceSource*)Unsafe.AsPointer(ref this), weakReference);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetWeakReference(IWeakReference** weakReference);
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
        [NativeTypeName("HRESULT (IWeakReference **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWeakReference**, int> GetWeakReference;
    }
}