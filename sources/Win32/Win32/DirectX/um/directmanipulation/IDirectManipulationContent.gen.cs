// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("B89962CB-3D89-442B-BB58-5098FA0F9F16")]
[NativeTypeName("struct IDirectManipulationContent : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDirectManipulationContent
    : IDirectManipulationContent.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationContent));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirectManipulationContent, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationContent, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationContent, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetContentRect(RECT* contentSize)
    {
        return ((delegate* unmanaged<IDirectManipulationContent, RECT*, int>)((*lpVtbl)[3]))(
            this,
            contentSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetContentRect([NativeTypeName("const RECT *")] RECT* contentSize)
    {
        return ((delegate* unmanaged<IDirectManipulationContent, RECT*, int>)((*lpVtbl)[4]))(
            this,
            contentSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetViewport([NativeTypeName("const IID &")] Guid* riid, void** @object)
    {
        return (
            (delegate* unmanaged<IDirectManipulationContent, Guid*, void**, int>)((*lpVtbl)[5])
        )(this, riid, @object);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetTag(
        [NativeTypeName("const IID &")] Guid* riid,
        void** @object,
        [NativeTypeName("UINT32 *")] uint* id
    )
    {
        return (
            (delegate* unmanaged<IDirectManipulationContent, Guid*, void**, uint*, int>)(
                (*lpVtbl)[6]
            )
        )(this, riid, @object, id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetTag(IUnknown @object, [NativeTypeName("UINT32")] uint id)
    {
        return (
            (delegate* unmanaged<IDirectManipulationContent, IUnknown, uint, int>)((*lpVtbl)[7])
        )(this, @object, id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetOutputTransform(float* matrix, [NativeTypeName("DWORD")] uint pointCount)
    {
        return ((delegate* unmanaged<IDirectManipulationContent, float*, uint, int>)((*lpVtbl)[8]))(
            this,
            matrix,
            pointCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetContentTransform(float* matrix, [NativeTypeName("DWORD")] uint pointCount)
    {
        return ((delegate* unmanaged<IDirectManipulationContent, float*, uint, int>)((*lpVtbl)[9]))(
            this,
            matrix,
            pointCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SyncContentTransform(
        [NativeTypeName("const float *")] float* matrix,
        [NativeTypeName("DWORD")] uint pointCount
    )
    {
        return (
            (delegate* unmanaged<IDirectManipulationContent, float*, uint, int>)((*lpVtbl)[10])
        )(this, matrix, pointCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetContentRect(RECT* contentSize);

        [VtblIndex(4)]
        HRESULT SetContentRect([NativeTypeName("const RECT *")] RECT* contentSize);

        [VtblIndex(5)]
        HRESULT GetViewport([NativeTypeName("const IID &")] Guid* riid, void** @object);

        [VtblIndex(6)]
        HRESULT GetTag(
            [NativeTypeName("const IID &")] Guid* riid,
            void** @object,
            [NativeTypeName("UINT32 *")] uint* id
        );

        [VtblIndex(7)]
        HRESULT SetTag(IUnknown @object, [NativeTypeName("UINT32")] uint id);

        [VtblIndex(8)]
        HRESULT GetOutputTransform(float* matrix, [NativeTypeName("DWORD")] uint pointCount);

        [VtblIndex(9)]
        HRESULT GetContentTransform(float* matrix, [NativeTypeName("DWORD")] uint pointCount);

        [VtblIndex(10)]
        HRESULT SyncContentTransform(
            [NativeTypeName("const float *")] float* matrix,
            [NativeTypeName("DWORD")] uint pointCount
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

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> GetContentRect;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetContentRect;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetViewport;

        [NativeTypeName("HRESULT (const IID &, void **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, uint*, int> GetTag;

        [NativeTypeName("HRESULT (IUnknown *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, uint, int> SetTag;

        [NativeTypeName("HRESULT (float *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, int> GetOutputTransform;

        [NativeTypeName("HRESULT (float *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, int> GetContentTransform;

        [NativeTypeName("HRESULT (const float *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, int> SyncContentTransform;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectManipulationContent"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectManipulationContent(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectManipulationContent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectManipulationContent(Silk.NET.Windows.IUnknown value)
    {
        return new IDirectManipulationContent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationContent"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationContent"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirectManipulationContent value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
