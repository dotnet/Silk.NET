// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IXAPOParameters.xml' path='doc/member[@name="IXAPOParameters"]/*'/>
[Guid("26D95C66-80F2-499A-AD54-5AE7F01C6D98")]
[NativeTypeName("struct IXAPOParameters : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXAPOParameters : IXAPOParameters.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXAPOParameters));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXAPOParameters*, Guid*, void**, int> )(lpVtbl[0]))((IXAPOParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXAPOParameters*, uint> )(lpVtbl[1]))((IXAPOParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXAPOParameters*, uint> )(lpVtbl[2]))((IXAPOParameters*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXAPOParameters.xml' path='doc/member[@name="IXAPOParameters.SetParameters"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetParameters([NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize)
    {
        ((delegate* unmanaged<IXAPOParameters*, void*, uint, void> )(lpVtbl[3]))((IXAPOParameters*)Unsafe.AsPointer(ref this), pParameters, ParameterByteSize);
    }

    /// <include file='IXAPOParameters.xml' path='doc/member[@name="IXAPOParameters.GetParameters"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetParameters(void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize)
    {
        ((delegate* unmanaged<IXAPOParameters*, void*, uint, void> )(lpVtbl[4]))((IXAPOParameters*)Unsafe.AsPointer(ref this), pParameters, ParameterByteSize);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void SetParameters([NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize);
        [VtblIndex(4)]
        void GetParameters(void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize);
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
        [NativeTypeName("void (const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, void> SetParameters;
        [NativeTypeName("void (void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, void> GetParameters;
    }
}