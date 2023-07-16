// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='ILearningModelOperatorProviderNative.xml' path='doc/member[@name="ILearningModelOperatorProviderNative"]/*'/>
[Guid("1ADAA23A-EB67-41F3-AAD8-5D984E9BACD4")]
[NativeTypeName("struct ILearningModelOperatorProviderNative : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ILearningModelOperatorProviderNative : ILearningModelOperatorProviderNative.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILearningModelOperatorProviderNative));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILearningModelOperatorProviderNative*, Guid*, void**, int> )(lpVtbl[0]))((ILearningModelOperatorProviderNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILearningModelOperatorProviderNative*, uint> )(lpVtbl[1]))((ILearningModelOperatorProviderNative*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILearningModelOperatorProviderNative*, uint> )(lpVtbl[2]))((ILearningModelOperatorProviderNative*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILearningModelOperatorProviderNative.xml' path='doc/member[@name="ILearningModelOperatorProviderNative.GetRegistry"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRegistry(IMLOperatorRegistry** ppOperatorRegistry)
    {
        return ((delegate* unmanaged<ILearningModelOperatorProviderNative*, IMLOperatorRegistry**, int> )(lpVtbl[3]))((ILearningModelOperatorProviderNative*)Unsafe.AsPointer(ref this), ppOperatorRegistry);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRegistry(IMLOperatorRegistry** ppOperatorRegistry);
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
        [NativeTypeName("HRESULT (IMLOperatorRegistry **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMLOperatorRegistry**, int> GetRegistry;
    }
}