// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4F62C8DA-9C53-4B22-93DF-927A862BBB03")]
[NativeTypeName("struct _IManipulationEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct _IManipulationEvents : _IManipulationEvents.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID__IManipulationEvents));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<_IManipulationEvents, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<_IManipulationEvents, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<_IManipulationEvents, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ManipulationStarted(float x, float y)
    {
        return ((delegate* unmanaged<_IManipulationEvents, float, float, int>)((*lpVtbl)[3]))(
            this,
            x,
            y
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ManipulationDelta(
        float x,
        float y,
        float translationDeltaX,
        float translationDeltaY,
        float scaleDelta,
        float expansionDelta,
        float rotationDelta,
        float cumulativeTranslationX,
        float cumulativeTranslationY,
        float cumulativeScale,
        float cumulativeExpansion,
        float cumulativeRotation
    )
    {
        return (
            (delegate* unmanaged<
                _IManipulationEvents,
                float,
                float,
                float,
                float,
                float,
                float,
                float,
                float,
                float,
                float,
                float,
                float,
                int>)((*lpVtbl)[4])
        )(
            this,
            x,
            y,
            translationDeltaX,
            translationDeltaY,
            scaleDelta,
            expansionDelta,
            rotationDelta,
            cumulativeTranslationX,
            cumulativeTranslationY,
            cumulativeScale,
            cumulativeExpansion,
            cumulativeRotation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ManipulationCompleted(
        float x,
        float y,
        float cumulativeTranslationX,
        float cumulativeTranslationY,
        float cumulativeScale,
        float cumulativeExpansion,
        float cumulativeRotation
    )
    {
        return (
            (delegate* unmanaged<
                _IManipulationEvents,
                float,
                float,
                float,
                float,
                float,
                float,
                float,
                int>)((*lpVtbl)[5])
        )(
            this,
            x,
            y,
            cumulativeTranslationX,
            cumulativeTranslationY,
            cumulativeScale,
            cumulativeExpansion,
            cumulativeRotation
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ManipulationStarted(float x, float y);

        [VtblIndex(4)]
        HRESULT ManipulationDelta(
            float x,
            float y,
            float translationDeltaX,
            float translationDeltaY,
            float scaleDelta,
            float expansionDelta,
            float rotationDelta,
            float cumulativeTranslationX,
            float cumulativeTranslationY,
            float cumulativeScale,
            float cumulativeExpansion,
            float cumulativeRotation
        );

        [VtblIndex(5)]
        HRESULT ManipulationCompleted(
            float x,
            float y,
            float cumulativeTranslationX,
            float cumulativeTranslationY,
            float cumulativeScale,
            float cumulativeExpansion,
            float cumulativeRotation
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

        [NativeTypeName("HRESULT (FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, int> ManipulationStarted;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            float,
            float,
            float,
            float,
            float,
            float,
            float,
            float,
            int> ManipulationDelta;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            float,
            float,
            float,
            int> ManipulationCompleted;
    }

    /// <summary>Initializes a new instance of the <see cref = "_IManipulationEvents"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public _IManipulationEvents(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "_IManipulationEvents"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator _IManipulationEvents(Silk.NET.Windows.IUnknown value)
    {
        return new _IManipulationEvents(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "_IManipulationEvents"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "_IManipulationEvents"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(_IManipulationEvents value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
