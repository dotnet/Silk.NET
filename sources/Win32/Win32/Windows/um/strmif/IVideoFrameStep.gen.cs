// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E46A9787-2B71-444D-A4B5-1FAB7B708D6A")]
[NativeTypeName("struct IVideoFrameStep : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVideoFrameStep : IVideoFrameStep.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoFrameStep));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVideoFrameStep, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVideoFrameStep, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoFrameStep, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Step([NativeTypeName("DWORD")] uint dwFrames, IUnknown pStepObject)
    {
        return ((delegate* unmanaged<IVideoFrameStep, uint, IUnknown, int>)((*lpVtbl)[3]))(
            this,
            dwFrames,
            pStepObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CanStep([NativeTypeName("long")] int bMultiple, IUnknown pStepObject)
    {
        return ((delegate* unmanaged<IVideoFrameStep, int, IUnknown, int>)((*lpVtbl)[4]))(
            this,
            bMultiple,
            pStepObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CancelStep()
    {
        return ((delegate* unmanaged<IVideoFrameStep, int>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Step([NativeTypeName("DWORD")] uint dwFrames, IUnknown pStepObject);

        [VtblIndex(4)]
        HRESULT CanStep([NativeTypeName("long")] int bMultiple, IUnknown pStepObject);

        [VtblIndex(5)]
        HRESULT CancelStep();
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

        [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown, int> Step;

        [NativeTypeName("HRESULT (long, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IUnknown, int> CanStep;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CancelStep;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVideoFrameStep"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVideoFrameStep(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVideoFrameStep"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVideoFrameStep(Silk.NET.Windows.IUnknown value)
    {
        return new IVideoFrameStep(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoFrameStep"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoFrameStep"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVideoFrameStep value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
