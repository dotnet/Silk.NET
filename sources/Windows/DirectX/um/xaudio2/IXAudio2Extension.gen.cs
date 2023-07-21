// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IXAudio2Extension.xml' path='doc/member[@name="IXAudio2Extension"]/*' />
[Guid("84AC29BB-D619-44D2-B197-E4ACF7DF3ED6")]
[NativeTypeName("struct IXAudio2Extension : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXAudio2Extension : IXAudio2Extension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXAudio2Extension));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXAudio2Extension*, Guid*, void**, int>)(lpVtbl[0]))((IXAudio2Extension*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXAudio2Extension*, uint>)(lpVtbl[1]))((IXAudio2Extension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXAudio2Extension*, uint>)(lpVtbl[2]))((IXAudio2Extension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXAudio2Extension.xml' path='doc/member[@name="IXAudio2Extension.GetProcessingQuantum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetProcessingQuantum([NativeTypeName("UINT32 *")] uint* quantumNumerator, [NativeTypeName("UINT32 *")] uint* quantumDenominator)
    {
        ((delegate* unmanaged<IXAudio2Extension*, uint*, uint*, void>)(lpVtbl[3]))((IXAudio2Extension*)Unsafe.AsPointer(ref this), quantumNumerator, quantumDenominator);
    }

    /// <include file='IXAudio2Extension.xml' path='doc/member[@name="IXAudio2Extension.GetProcessor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetProcessor([NativeTypeName("XAUDIO2_PROCESSOR *")] uint* processor)
    {
        ((delegate* unmanaged<IXAudio2Extension*, uint*, void>)(lpVtbl[4]))((IXAudio2Extension*)Unsafe.AsPointer(ref this), processor);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void GetProcessingQuantum([NativeTypeName("UINT32 *")] uint* quantumNumerator, [NativeTypeName("UINT32 *")] uint* quantumDenominator);

        [VtblIndex(4)]
        void GetProcessor([NativeTypeName("XAUDIO2_PROCESSOR *")] uint* processor);
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

        [NativeTypeName("void (UINT32 *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, void> GetProcessingQuantum;

        [NativeTypeName("void (XAUDIO2_PROCESSOR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, void> GetProcessor;
    }
}
