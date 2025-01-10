// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("84AC29BB-D619-44D2-B197-E4ACF7DF3ED6")]
[NativeTypeName("struct IXAudio2Extension : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXAudio2Extension : IXAudio2Extension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXAudio2Extension));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXAudio2Extension, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXAudio2Extension, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXAudio2Extension, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetProcessingQuantum(
        [NativeTypeName("UINT32 *")] uint* quantumNumerator,
        [NativeTypeName("UINT32 *")] uint* quantumDenominator
    )
    {
        ((delegate* unmanaged<IXAudio2Extension, uint*, uint*, void>)((*lpVtbl)[3]))(
            this,
            quantumNumerator,
            quantumDenominator
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetProcessor([NativeTypeName("XAUDIO2_PROCESSOR *")] uint* processor)
    {
        ((delegate* unmanaged<IXAudio2Extension, uint*, void>)((*lpVtbl)[4]))(this, processor);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void GetProcessingQuantum(
            [NativeTypeName("UINT32 *")] uint* quantumNumerator,
            [NativeTypeName("UINT32 *")] uint* quantumDenominator
        );

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

        [NativeTypeName(
            "void (UINT32 *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, uint*, void> GetProcessingQuantum;

        [NativeTypeName(
            "void (XAUDIO2_PROCESSOR *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, void> GetProcessor;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXAudio2Extension"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXAudio2Extension(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXAudio2Extension"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXAudio2Extension(Silk.NET.Windows.IUnknown value)
    {
        return new IXAudio2Extension(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXAudio2Extension"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXAudio2Extension"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXAudio2Extension value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
