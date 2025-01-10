// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0BFD1ADE-0421-4909-ACB7-7A7125416881")]
[NativeTypeName("struct IMFFaceDetectionTransformCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFFaceDetectionTransformCallback
    : IMFFaceDetectionTransformCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFFaceDetectionTransformCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFFaceDetectionTransformCallback, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFFaceDetectionTransformCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFFaceDetectionTransformCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnFaceDetectionResult(
        [NativeTypeName("ULONG")] uint countOfBounds,
        DetectedFaceBound* detectedFaceBounds
    )
    {
        (
            (delegate* unmanaged<
                IMFFaceDetectionTransformCallback,
                uint,
                DetectedFaceBound*,
                void>)((*lpVtbl)[3])
        )(this, countOfBounds, detectedFaceBounds);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void OnFaceDetectionResult(
            [NativeTypeName("ULONG")] uint countOfBounds,
            DetectedFaceBound* detectedFaceBounds
        );
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

        [NativeTypeName("void (ULONG, DetectedFaceBound *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DetectedFaceBound*, void> OnFaceDetectionResult;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFFaceDetectionTransformCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFFaceDetectionTransformCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFFaceDetectionTransformCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFFaceDetectionTransformCallback(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMFFaceDetectionTransformCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFFaceDetectionTransformCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFFaceDetectionTransformCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMFFaceDetectionTransformCallback value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
