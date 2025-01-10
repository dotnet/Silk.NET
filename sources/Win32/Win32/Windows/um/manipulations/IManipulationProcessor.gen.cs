// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A22AC519-8300-48A0-BEF4-F1BE8737DBA4")]
[NativeTypeName("struct IManipulationProcessor : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IManipulationProcessor : IManipulationProcessor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IManipulationProcessor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IManipulationProcessor, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IManipulationProcessor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IManipulationProcessor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_SupportedManipulations(MANIPULATION_PROCESSOR_MANIPULATIONS* manipulations)
    {
        return (
            (delegate* unmanaged<
                IManipulationProcessor,
                MANIPULATION_PROCESSOR_MANIPULATIONS*,
                int>)((*lpVtbl)[3])
        )(this, manipulations);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_SupportedManipulations(MANIPULATION_PROCESSOR_MANIPULATIONS manipulations)
    {
        return (
            (delegate* unmanaged<
                IManipulationProcessor,
                MANIPULATION_PROCESSOR_MANIPULATIONS,
                int>)((*lpVtbl)[4])
        )(this, manipulations);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_PivotPointX(float* pivotPointX)
    {
        return ((delegate* unmanaged<IManipulationProcessor, float*, int>)((*lpVtbl)[5]))(
            this,
            pivotPointX
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_PivotPointX(float pivotPointX)
    {
        return ((delegate* unmanaged<IManipulationProcessor, float, int>)((*lpVtbl)[6]))(
            this,
            pivotPointX
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PivotPointY(float* pivotPointY)
    {
        return ((delegate* unmanaged<IManipulationProcessor, float*, int>)((*lpVtbl)[7]))(
            this,
            pivotPointY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_PivotPointY(float pivotPointY)
    {
        return ((delegate* unmanaged<IManipulationProcessor, float, int>)((*lpVtbl)[8]))(
            this,
            pivotPointY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PivotRadius(float* pivotRadius)
    {
        return ((delegate* unmanaged<IManipulationProcessor, float*, int>)((*lpVtbl)[9]))(
            this,
            pivotRadius
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_PivotRadius(float pivotRadius)
    {
        return ((delegate* unmanaged<IManipulationProcessor, float, int>)((*lpVtbl)[10]))(
            this,
            pivotRadius
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CompleteManipulation()
    {
        return ((delegate* unmanaged<IManipulationProcessor, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ProcessDown(
        [NativeTypeName("MANIPULATOR_ID")] uint manipulatorId,
        float x,
        float y
    )
    {
        return (
            (delegate* unmanaged<IManipulationProcessor, uint, float, float, int>)((*lpVtbl)[12])
        )(this, manipulatorId, x, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ProcessMove(
        [NativeTypeName("MANIPULATOR_ID")] uint manipulatorId,
        float x,
        float y
    )
    {
        return (
            (delegate* unmanaged<IManipulationProcessor, uint, float, float, int>)((*lpVtbl)[13])
        )(this, manipulatorId, x, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ProcessUp(
        [NativeTypeName("MANIPULATOR_ID")] uint manipulatorId,
        float x,
        float y
    )
    {
        return (
            (delegate* unmanaged<IManipulationProcessor, uint, float, float, int>)((*lpVtbl)[14])
        )(this, manipulatorId, x, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ProcessDownWithTime(
        [NativeTypeName("MANIPULATOR_ID")] uint manipulatorId,
        float x,
        float y,
        [NativeTypeName("DWORD")] uint timestamp
    )
    {
        return (
            (delegate* unmanaged<IManipulationProcessor, uint, float, float, uint, int>)(
                (*lpVtbl)[15]
            )
        )(this, manipulatorId, x, y, timestamp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ProcessMoveWithTime(
        [NativeTypeName("MANIPULATOR_ID")] uint manipulatorId,
        float x,
        float y,
        [NativeTypeName("DWORD")] uint timestamp
    )
    {
        return (
            (delegate* unmanaged<IManipulationProcessor, uint, float, float, uint, int>)(
                (*lpVtbl)[16]
            )
        )(this, manipulatorId, x, y, timestamp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ProcessUpWithTime(
        [NativeTypeName("MANIPULATOR_ID")] uint manipulatorId,
        float x,
        float y,
        [NativeTypeName("DWORD")] uint timestamp
    )
    {
        return (
            (delegate* unmanaged<IManipulationProcessor, uint, float, float, uint, int>)(
                (*lpVtbl)[17]
            )
        )(this, manipulatorId, x, y, timestamp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetVelocityX(float* velocityX)
    {
        return ((delegate* unmanaged<IManipulationProcessor, float*, int>)((*lpVtbl)[18]))(
            this,
            velocityX
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetVelocityY(float* velocityY)
    {
        return ((delegate* unmanaged<IManipulationProcessor, float*, int>)((*lpVtbl)[19]))(
            this,
            velocityY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetExpansionVelocity(float* expansionVelocity)
    {
        return ((delegate* unmanaged<IManipulationProcessor, float*, int>)((*lpVtbl)[20]))(
            this,
            expansionVelocity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetAngularVelocity(float* angularVelocity)
    {
        return ((delegate* unmanaged<IManipulationProcessor, float*, int>)((*lpVtbl)[21]))(
            this,
            angularVelocity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_MinimumScaleRotateRadius(float* minRadius)
    {
        return ((delegate* unmanaged<IManipulationProcessor, float*, int>)((*lpVtbl)[22]))(
            this,
            minRadius
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_MinimumScaleRotateRadius(float minRadius)
    {
        return ((delegate* unmanaged<IManipulationProcessor, float, int>)((*lpVtbl)[23]))(
            this,
            minRadius
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_SupportedManipulations(MANIPULATION_PROCESSOR_MANIPULATIONS* manipulations);

        [VtblIndex(4)]
        HRESULT put_SupportedManipulations(MANIPULATION_PROCESSOR_MANIPULATIONS manipulations);

        [VtblIndex(5)]
        HRESULT get_PivotPointX(float* pivotPointX);

        [VtblIndex(6)]
        HRESULT put_PivotPointX(float pivotPointX);

        [VtblIndex(7)]
        HRESULT get_PivotPointY(float* pivotPointY);

        [VtblIndex(8)]
        HRESULT put_PivotPointY(float pivotPointY);

        [VtblIndex(9)]
        HRESULT get_PivotRadius(float* pivotRadius);

        [VtblIndex(10)]
        HRESULT put_PivotRadius(float pivotRadius);

        [VtblIndex(11)]
        HRESULT CompleteManipulation();

        [VtblIndex(12)]
        HRESULT ProcessDown(
            [NativeTypeName("MANIPULATOR_ID")] uint manipulatorId,
            float x,
            float y
        );

        [VtblIndex(13)]
        HRESULT ProcessMove(
            [NativeTypeName("MANIPULATOR_ID")] uint manipulatorId,
            float x,
            float y
        );

        [VtblIndex(14)]
        HRESULT ProcessUp([NativeTypeName("MANIPULATOR_ID")] uint manipulatorId, float x, float y);

        [VtblIndex(15)]
        HRESULT ProcessDownWithTime(
            [NativeTypeName("MANIPULATOR_ID")] uint manipulatorId,
            float x,
            float y,
            [NativeTypeName("DWORD")] uint timestamp
        );

        [VtblIndex(16)]
        HRESULT ProcessMoveWithTime(
            [NativeTypeName("MANIPULATOR_ID")] uint manipulatorId,
            float x,
            float y,
            [NativeTypeName("DWORD")] uint timestamp
        );

        [VtblIndex(17)]
        HRESULT ProcessUpWithTime(
            [NativeTypeName("MANIPULATOR_ID")] uint manipulatorId,
            float x,
            float y,
            [NativeTypeName("DWORD")] uint timestamp
        );

        [VtblIndex(18)]
        HRESULT GetVelocityX(float* velocityX);

        [VtblIndex(19)]
        HRESULT GetVelocityY(float* velocityY);

        [VtblIndex(20)]
        HRESULT GetExpansionVelocity(float* expansionVelocity);

        [VtblIndex(21)]
        HRESULT GetAngularVelocity(float* angularVelocity);

        [VtblIndex(22)]
        HRESULT get_MinimumScaleRotateRadius(float* minRadius);

        [VtblIndex(23)]
        HRESULT put_MinimumScaleRotateRadius(float minRadius);
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
            "HRESULT (MANIPULATION_PROCESSOR_MANIPULATIONS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MANIPULATION_PROCESSOR_MANIPULATIONS*,
            int> get_SupportedManipulations;

        [NativeTypeName("HRESULT (MANIPULATION_PROCESSOR_MANIPULATIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            MANIPULATION_PROCESSOR_MANIPULATIONS,
            int> put_SupportedManipulations;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_PivotPointX;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_PivotPointX;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_PivotPointY;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_PivotPointY;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_PivotRadius;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_PivotRadius;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CompleteManipulation;

        [NativeTypeName("HRESULT (MANIPULATOR_ID, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, float, int> ProcessDown;

        [NativeTypeName("HRESULT (MANIPULATOR_ID, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, float, int> ProcessMove;

        [NativeTypeName("HRESULT (MANIPULATOR_ID, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, float, int> ProcessUp;

        [NativeTypeName("HRESULT (MANIPULATOR_ID, FLOAT, FLOAT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, float, uint, int> ProcessDownWithTime;

        [NativeTypeName("HRESULT (MANIPULATOR_ID, FLOAT, FLOAT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, float, uint, int> ProcessMoveWithTime;

        [NativeTypeName("HRESULT (MANIPULATOR_ID, FLOAT, FLOAT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, float, uint, int> ProcessUpWithTime;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetVelocityX;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetVelocityY;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetExpansionVelocity;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetAngularVelocity;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_MinimumScaleRotateRadius;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_MinimumScaleRotateRadius;
    }

    /// <summary>Initializes a new instance of the <see cref = "IManipulationProcessor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IManipulationProcessor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IManipulationProcessor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IManipulationProcessor(Silk.NET.Windows.IUnknown value)
    {
        return new IManipulationProcessor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IManipulationProcessor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IManipulationProcessor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IManipulationProcessor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
