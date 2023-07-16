// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IKsJackDescription.xml' path='doc/member[@name="IKsJackDescription"]/*'/>
[Guid("4509F757-2D46-4637-8E62-CE7DB944F57B")]
[NativeTypeName("struct IKsJackDescription : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IKsJackDescription : IKsJackDescription.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKsJackDescription));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKsJackDescription*, Guid*, void**, int> )(lpVtbl[0]))((IKsJackDescription*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IKsJackDescription*, uint> )(lpVtbl[1]))((IKsJackDescription*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKsJackDescription*, uint> )(lpVtbl[2]))((IKsJackDescription*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IKsJackDescription.xml' path='doc/member[@name="IKsJackDescription.GetJackCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetJackCount(uint* pcJacks)
    {
        return ((delegate* unmanaged<IKsJackDescription*, uint*, int> )(lpVtbl[3]))((IKsJackDescription*)Unsafe.AsPointer(ref this), pcJacks);
    }

    /// <include file='IKsJackDescription.xml' path='doc/member[@name="IKsJackDescription.GetJackDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetJackDescription(uint nJack, KSJACK_DESCRIPTION* pDescription)
    {
        return ((delegate* unmanaged<IKsJackDescription*, uint, KSJACK_DESCRIPTION*, int> )(lpVtbl[4]))((IKsJackDescription*)Unsafe.AsPointer(ref this), nJack, pDescription);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetJackCount(uint* pcJacks);
        [VtblIndex(4)]
        HRESULT GetJackDescription(uint nJack, KSJACK_DESCRIPTION* pDescription);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetJackCount;
        [NativeTypeName("HRESULT (UINT, KSJACK_DESCRIPTION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, KSJACK_DESCRIPTION*, int> GetJackDescription;
    }
}