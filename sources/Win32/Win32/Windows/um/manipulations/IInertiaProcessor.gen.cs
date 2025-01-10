// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("18B00C6D-C5EE-41B1-90A9-9D4A929095AD")]
[NativeTypeName("struct IInertiaProcessor : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInertiaProcessor : IInertiaProcessor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInertiaProcessor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInertiaProcessor, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInertiaProcessor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInertiaProcessor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_InitialOriginX(float* x)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[3]))(this, x);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_InitialOriginX(float x)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[4]))(this, x);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_InitialOriginY(float* y)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[5]))(this, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_InitialOriginY(float y)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[6]))(this, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_InitialVelocityX(float* x)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[7]))(this, x);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_InitialVelocityX(float x)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[8]))(this, x);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_InitialVelocityY(float* y)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[9]))(this, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_InitialVelocityY(float y)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[10]))(this, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_InitialAngularVelocity(float* velocity)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[11]))(
            this,
            velocity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_InitialAngularVelocity(float velocity)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[12]))(
            this,
            velocity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_InitialExpansionVelocity(float* velocity)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[13]))(
            this,
            velocity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_InitialExpansionVelocity(float velocity)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[14]))(
            this,
            velocity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_InitialRadius(float* radius)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[15]))(this, radius);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_InitialRadius(float radius)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[16]))(this, radius);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_BoundaryLeft(float* left)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[17]))(this, left);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_BoundaryLeft(float left)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[18]))(this, left);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_BoundaryTop(float* top)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[19]))(this, top);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_BoundaryTop(float top)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[20]))(this, top);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_BoundaryRight(float* right)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[21]))(this, right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_BoundaryRight(float right)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[22]))(this, right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_BoundaryBottom(float* bottom)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[23]))(this, bottom);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_BoundaryBottom(float bottom)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[24]))(this, bottom);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_ElasticMarginLeft(float* left)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[25]))(this, left);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_ElasticMarginLeft(float left)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[26]))(this, left);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_ElasticMarginTop(float* top)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[27]))(this, top);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_ElasticMarginTop(float top)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[28]))(this, top);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_ElasticMarginRight(float* right)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[29]))(this, right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_ElasticMarginRight(float right)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[30]))(this, right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_ElasticMarginBottom(float* bottom)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[31]))(this, bottom);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_ElasticMarginBottom(float bottom)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[32]))(this, bottom);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_DesiredDisplacement(float* displacement)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[33]))(
            this,
            displacement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_DesiredDisplacement(float displacement)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[34]))(
            this,
            displacement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_DesiredRotation(float* rotation)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[35]))(
            this,
            rotation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_DesiredRotation(float rotation)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[36]))(
            this,
            rotation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_DesiredExpansion(float* expansion)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[37]))(
            this,
            expansion
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_DesiredExpansion(float expansion)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[38]))(
            this,
            expansion
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_DesiredDeceleration(float* deceleration)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[39]))(
            this,
            deceleration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_DesiredDeceleration(float deceleration)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[40]))(
            this,
            deceleration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_DesiredAngularDeceleration(float* deceleration)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[41]))(
            this,
            deceleration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_DesiredAngularDeceleration(float deceleration)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[42]))(
            this,
            deceleration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_DesiredExpansionDeceleration(float* deceleration)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float*, int>)((*lpVtbl)[43]))(
            this,
            deceleration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_DesiredExpansionDeceleration(float deceleration)
    {
        return ((delegate* unmanaged<IInertiaProcessor, float, int>)((*lpVtbl)[44]))(
            this,
            deceleration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_InitialTimestamp([NativeTypeName("DWORD *")] uint* timestamp)
    {
        return ((delegate* unmanaged<IInertiaProcessor, uint*, int>)((*lpVtbl)[45]))(
            this,
            timestamp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT put_InitialTimestamp([NativeTypeName("DWORD")] uint timestamp)
    {
        return ((delegate* unmanaged<IInertiaProcessor, uint, int>)((*lpVtbl)[46]))(
            this,
            timestamp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IInertiaProcessor, int>)((*lpVtbl)[47]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT Process(BOOL* completed)
    {
        return ((delegate* unmanaged<IInertiaProcessor, BOOL*, int>)((*lpVtbl)[48]))(
            this,
            completed
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT ProcessTime([NativeTypeName("DWORD")] uint timestamp, BOOL* completed)
    {
        return ((delegate* unmanaged<IInertiaProcessor, uint, BOOL*, int>)((*lpVtbl)[49]))(
            this,
            timestamp,
            completed
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT Complete()
    {
        return ((delegate* unmanaged<IInertiaProcessor, int>)((*lpVtbl)[50]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT CompleteTime([NativeTypeName("DWORD")] uint timestamp)
    {
        return ((delegate* unmanaged<IInertiaProcessor, uint, int>)((*lpVtbl)[51]))(
            this,
            timestamp
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_InitialOriginX(float* x);

        [VtblIndex(4)]
        HRESULT put_InitialOriginX(float x);

        [VtblIndex(5)]
        HRESULT get_InitialOriginY(float* y);

        [VtblIndex(6)]
        HRESULT put_InitialOriginY(float y);

        [VtblIndex(7)]
        HRESULT get_InitialVelocityX(float* x);

        [VtblIndex(8)]
        HRESULT put_InitialVelocityX(float x);

        [VtblIndex(9)]
        HRESULT get_InitialVelocityY(float* y);

        [VtblIndex(10)]
        HRESULT put_InitialVelocityY(float y);

        [VtblIndex(11)]
        HRESULT get_InitialAngularVelocity(float* velocity);

        [VtblIndex(12)]
        HRESULT put_InitialAngularVelocity(float velocity);

        [VtblIndex(13)]
        HRESULT get_InitialExpansionVelocity(float* velocity);

        [VtblIndex(14)]
        HRESULT put_InitialExpansionVelocity(float velocity);

        [VtblIndex(15)]
        HRESULT get_InitialRadius(float* radius);

        [VtblIndex(16)]
        HRESULT put_InitialRadius(float radius);

        [VtblIndex(17)]
        HRESULT get_BoundaryLeft(float* left);

        [VtblIndex(18)]
        HRESULT put_BoundaryLeft(float left);

        [VtblIndex(19)]
        HRESULT get_BoundaryTop(float* top);

        [VtblIndex(20)]
        HRESULT put_BoundaryTop(float top);

        [VtblIndex(21)]
        HRESULT get_BoundaryRight(float* right);

        [VtblIndex(22)]
        HRESULT put_BoundaryRight(float right);

        [VtblIndex(23)]
        HRESULT get_BoundaryBottom(float* bottom);

        [VtblIndex(24)]
        HRESULT put_BoundaryBottom(float bottom);

        [VtblIndex(25)]
        HRESULT get_ElasticMarginLeft(float* left);

        [VtblIndex(26)]
        HRESULT put_ElasticMarginLeft(float left);

        [VtblIndex(27)]
        HRESULT get_ElasticMarginTop(float* top);

        [VtblIndex(28)]
        HRESULT put_ElasticMarginTop(float top);

        [VtblIndex(29)]
        HRESULT get_ElasticMarginRight(float* right);

        [VtblIndex(30)]
        HRESULT put_ElasticMarginRight(float right);

        [VtblIndex(31)]
        HRESULT get_ElasticMarginBottom(float* bottom);

        [VtblIndex(32)]
        HRESULT put_ElasticMarginBottom(float bottom);

        [VtblIndex(33)]
        HRESULT get_DesiredDisplacement(float* displacement);

        [VtblIndex(34)]
        HRESULT put_DesiredDisplacement(float displacement);

        [VtblIndex(35)]
        HRESULT get_DesiredRotation(float* rotation);

        [VtblIndex(36)]
        HRESULT put_DesiredRotation(float rotation);

        [VtblIndex(37)]
        HRESULT get_DesiredExpansion(float* expansion);

        [VtblIndex(38)]
        HRESULT put_DesiredExpansion(float expansion);

        [VtblIndex(39)]
        HRESULT get_DesiredDeceleration(float* deceleration);

        [VtblIndex(40)]
        HRESULT put_DesiredDeceleration(float deceleration);

        [VtblIndex(41)]
        HRESULT get_DesiredAngularDeceleration(float* deceleration);

        [VtblIndex(42)]
        HRESULT put_DesiredAngularDeceleration(float deceleration);

        [VtblIndex(43)]
        HRESULT get_DesiredExpansionDeceleration(float* deceleration);

        [VtblIndex(44)]
        HRESULT put_DesiredExpansionDeceleration(float deceleration);

        [VtblIndex(45)]
        HRESULT get_InitialTimestamp([NativeTypeName("DWORD *")] uint* timestamp);

        [VtblIndex(46)]
        HRESULT put_InitialTimestamp([NativeTypeName("DWORD")] uint timestamp);

        [VtblIndex(47)]
        HRESULT Reset();

        [VtblIndex(48)]
        HRESULT Process(BOOL* completed);

        [VtblIndex(49)]
        HRESULT ProcessTime([NativeTypeName("DWORD")] uint timestamp, BOOL* completed);

        [VtblIndex(50)]
        HRESULT Complete();

        [VtblIndex(51)]
        HRESULT CompleteTime([NativeTypeName("DWORD")] uint timestamp);
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_InitialOriginX;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_InitialOriginX;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_InitialOriginY;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_InitialOriginY;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_InitialVelocityX;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_InitialVelocityX;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_InitialVelocityY;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_InitialVelocityY;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_InitialAngularVelocity;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_InitialAngularVelocity;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_InitialExpansionVelocity;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_InitialExpansionVelocity;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_InitialRadius;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_InitialRadius;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_BoundaryLeft;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_BoundaryLeft;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_BoundaryTop;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_BoundaryTop;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_BoundaryRight;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_BoundaryRight;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_BoundaryBottom;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_BoundaryBottom;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_ElasticMarginLeft;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_ElasticMarginLeft;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_ElasticMarginTop;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_ElasticMarginTop;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_ElasticMarginRight;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_ElasticMarginRight;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_ElasticMarginBottom;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_ElasticMarginBottom;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_DesiredDisplacement;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_DesiredDisplacement;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_DesiredRotation;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_DesiredRotation;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_DesiredExpansion;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_DesiredExpansion;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_DesiredDeceleration;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_DesiredDeceleration;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_DesiredAngularDeceleration;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_DesiredAngularDeceleration;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_DesiredExpansionDeceleration;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_DesiredExpansionDeceleration;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_InitialTimestamp;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_InitialTimestamp;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> Process;

        [NativeTypeName("HRESULT (DWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> ProcessTime;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Complete;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> CompleteTime;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInertiaProcessor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInertiaProcessor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInertiaProcessor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInertiaProcessor(Silk.NET.Windows.IUnknown value)
    {
        return new IInertiaProcessor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInertiaProcessor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInertiaProcessor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInertiaProcessor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
