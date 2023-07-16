// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISequenceNumber.xml' path='doc/member[@name="ISequenceNumber"]/*'/>
[Guid("3050F6C1-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISequenceNumber : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISequenceNumber : ISequenceNumber.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISequenceNumber));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISequenceNumber*, Guid*, void**, int> )(lpVtbl[0]))((ISequenceNumber*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISequenceNumber*, uint> )(lpVtbl[1]))((ISequenceNumber*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISequenceNumber*, uint> )(lpVtbl[2]))((ISequenceNumber*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISequenceNumber.xml' path='doc/member[@name="ISequenceNumber.GetSequenceNumber"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSequenceNumber([NativeTypeName("long")] int nCurrent, [NativeTypeName("long *")] int* pnNew)
    {
        return ((delegate* unmanaged<ISequenceNumber*, int, int*, int> )(lpVtbl[3]))((ISequenceNumber*)Unsafe.AsPointer(ref this), nCurrent, pnNew);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSequenceNumber([NativeTypeName("long")] int nCurrent, [NativeTypeName("long *")] int* pnNew);
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
        [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> GetSequenceNumber;
    }
}