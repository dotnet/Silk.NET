// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DDD59578-D0E7-46E2-BE8C-1CE76AD147C0")]
[NativeTypeName("struct IMFFaceDetectionTransform : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFFaceDetectionTransform
    : IMFFaceDetectionTransform.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFFaceDetectionTransform));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFFaceDetectionTransform, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFFaceDetectionTransform, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFFaceDetectionTransform, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDetectionCallback(
        IMFFaceDetectionTransformCallback callback,
        void** callbackToken
    )
    {
        return (
            (delegate* unmanaged<
                IMFFaceDetectionTransform,
                IMFFaceDetectionTransformCallback,
                void**,
                int>)((*lpVtbl)[3])
        )(this, callback, callbackToken);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ClearDetectionCallback(void* callbackToken)
    {
        return ((delegate* unmanaged<IMFFaceDetectionTransform, void*, int>)((*lpVtbl)[4]))(
            this,
            callbackToken
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDetectionCallback(
            IMFFaceDetectionTransformCallback callback,
            void** callbackToken
        );

        [VtblIndex(4)]
        HRESULT ClearDetectionCallback(void* callbackToken);
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
            "HRESULT (IMFFaceDetectionTransformCallback *, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFFaceDetectionTransformCallback,
            void**,
            int> SetDetectionCallback;

        [NativeTypeName("HRESULT (void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int> ClearDetectionCallback;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFFaceDetectionTransform"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFFaceDetectionTransform(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFFaceDetectionTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFFaceDetectionTransform(Silk.NET.Windows.IUnknown value)
    {
        return new IMFFaceDetectionTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFFaceDetectionTransform"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFFaceDetectionTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFFaceDetectionTransform value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
