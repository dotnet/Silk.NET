// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IEnumTfCandidates.xml' path='doc/member[@name="IEnumTfCandidates"]/*'/>
[Guid("DEFB1926-6C80-4CE8-87D4-D6B72B812BDE")]
[NativeTypeName("struct IEnumTfCandidates : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTfCandidates : IEnumTfCandidates.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumTfCandidates));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumTfCandidates*, Guid*, void**, int> )(lpVtbl[0]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumTfCandidates*, uint> )(lpVtbl[1]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumTfCandidates*, uint> )(lpVtbl[2]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfCandidates.xml' path='doc/member[@name="IEnumTfCandidates.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumTfCandidates** ppEnum)
    {
        return ((delegate* unmanaged<IEnumTfCandidates*, IEnumTfCandidates**, int> )(lpVtbl[3]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IEnumTfCandidates.xml' path='doc/member[@name="IEnumTfCandidates.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfCandidateString** ppCand, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumTfCandidates*, uint, ITfCandidateString**, uint*, int> )(lpVtbl[4]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this), ulCount, ppCand, pcFetched);
    }

    /// <include file='IEnumTfCandidates.xml' path='doc/member[@name="IEnumTfCandidates.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumTfCandidates*, int> )(lpVtbl[5]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfCandidates.xml' path='doc/member[@name="IEnumTfCandidates.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumTfCandidates*, uint, int> )(lpVtbl[6]))((IEnumTfCandidates*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumTfCandidates** ppEnum);
        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfCandidateString** ppCand, [NativeTypeName("ULONG *")] uint* pcFetched);
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
        [NativeTypeName("HRESULT (IEnumTfCandidates **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfCandidates**, int> Clone;
        [NativeTypeName("HRESULT (ULONG, ITfCandidateString **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfCandidateString**, uint*, int> Next;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }
}