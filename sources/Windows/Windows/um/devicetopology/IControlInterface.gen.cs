// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IControlInterface.xml' path='doc/member[@name="IControlInterface"]/*'/>
[Guid("45D37C3F-5140-444A-AE24-400789F3CBF3")]
[NativeTypeName("struct IControlInterface : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IControlInterface : IControlInterface.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IControlInterface));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IControlInterface*, Guid*, void**, int> )(lpVtbl[0]))((IControlInterface*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IControlInterface*, uint> )(lpVtbl[1]))((IControlInterface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IControlInterface*, uint> )(lpVtbl[2]))((IControlInterface*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IControlInterface.xml' path='doc/member[@name="IControlInterface.GetName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppwstrName)
    {
        return ((delegate* unmanaged<IControlInterface*, ushort**, int> )(lpVtbl[3]))((IControlInterface*)Unsafe.AsPointer(ref this), ppwstrName);
    }

    /// <include file='IControlInterface.xml' path='doc/member[@name="IControlInterface.GetIID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetIID(Guid* pIID)
    {
        return ((delegate* unmanaged<IControlInterface*, Guid*, int> )(lpVtbl[4]))((IControlInterface*)Unsafe.AsPointer(ref this), pIID);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppwstrName);
        [VtblIndex(4)]
        HRESULT GetIID(Guid* pIID);
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
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetIID;
    }
}