// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("28F54685-06FD-11D2-B27A-00A0C9223196")]
[NativeTypeName("struct IKsControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IKsControl : IKsControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKsControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKsControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IKsControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKsControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT KsProperty(
        [NativeTypeName("PKSPROPERTY")] KSIDENTIFIER* Property,
        [NativeTypeName("ULONG")] uint PropertyLength,
        void* PropertyData,
        [NativeTypeName("ULONG")] uint DataLength,
        [NativeTypeName("ULONG *")] uint* BytesReturned
    )
    {
        return (
            (delegate* unmanaged<IKsControl, KSIDENTIFIER*, uint, void*, uint, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, Property, PropertyLength, PropertyData, DataLength, BytesReturned);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT KsMethod(
        [NativeTypeName("PKSMETHOD")] KSIDENTIFIER* Method,
        [NativeTypeName("ULONG")] uint MethodLength,
        void* MethodData,
        [NativeTypeName("ULONG")] uint DataLength,
        [NativeTypeName("ULONG *")] uint* BytesReturned
    )
    {
        return (
            (delegate* unmanaged<IKsControl, KSIDENTIFIER*, uint, void*, uint, uint*, int>)(
                (*lpVtbl)[4]
            )
        )(this, Method, MethodLength, MethodData, DataLength, BytesReturned);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT KsEvent(
        [NativeTypeName("PKSEVENT")] KSIDENTIFIER* Event,
        [NativeTypeName("ULONG")] uint EventLength,
        void* EventData,
        [NativeTypeName("ULONG")] uint DataLength,
        [NativeTypeName("ULONG *")] uint* BytesReturned
    )
    {
        return (
            (delegate* unmanaged<IKsControl, KSIDENTIFIER*, uint, void*, uint, uint*, int>)(
                (*lpVtbl)[5]
            )
        )(this, Event, EventLength, EventData, DataLength, BytesReturned);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT KsProperty(
            [NativeTypeName("PKSPROPERTY")] KSIDENTIFIER* Property,
            [NativeTypeName("ULONG")] uint PropertyLength,
            void* PropertyData,
            [NativeTypeName("ULONG")] uint DataLength,
            [NativeTypeName("ULONG *")] uint* BytesReturned
        );

        [VtblIndex(4)]
        HRESULT KsMethod(
            [NativeTypeName("PKSMETHOD")] KSIDENTIFIER* Method,
            [NativeTypeName("ULONG")] uint MethodLength,
            void* MethodData,
            [NativeTypeName("ULONG")] uint DataLength,
            [NativeTypeName("ULONG *")] uint* BytesReturned
        );

        [VtblIndex(5)]
        HRESULT KsEvent(
            [NativeTypeName("PKSEVENT")] KSIDENTIFIER* Event,
            [NativeTypeName("ULONG")] uint EventLength,
            void* EventData,
            [NativeTypeName("ULONG")] uint DataLength,
            [NativeTypeName("ULONG *")] uint* BytesReturned
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

        [NativeTypeName(
            "HRESULT (PKSPROPERTY, ULONG, void *, ULONG, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, KSIDENTIFIER*, uint, void*, uint, uint*, int> KsProperty;

        [NativeTypeName(
            "HRESULT (PKSMETHOD, ULONG, void *, ULONG, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, KSIDENTIFIER*, uint, void*, uint, uint*, int> KsMethod;

        [NativeTypeName(
            "HRESULT (PKSEVENT, ULONG, void *, ULONG, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, KSIDENTIFIER*, uint, void*, uint, uint*, int> KsEvent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IKsControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IKsControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IKsControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IKsControl(Silk.NET.Windows.IUnknown value)
    {
        return new IKsControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKsControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IKsControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IKsControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
