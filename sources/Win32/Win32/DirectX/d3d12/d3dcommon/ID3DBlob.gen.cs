// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <inheritdoc cref = "IDisposable.Dispose"></inheritdoc>

[Guid("8BA5FB08-5195-40E2-AC58-0D989C3A0102")]
[NativeTypeName("struct ID3D10Blob : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DBlob : ID3DBlob.Interface, IComVtbl<ID3DBlob>, IDisposable
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID);

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("LPVOID")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        Ptr GetBufferPointer();

        [VtblIndex(3)]
        [return: NativeTypeName("LPVOID")]
        void* GetBufferPointerRaw();

        [VtblIndex(4)]
        [return: NativeTypeName("SIZE_T")]
        nuint GetBufferSize();
    }

    /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob"]/*'/>

    [Guid("8BA5FB08-5195-40E2-AC58-0D989C3A0102")]
    [NativeTypeName("struct ID3D10Blob : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID);
        public void** lpVtbl;

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> Release;

            [NativeTypeName("LPVOID () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*> GetBufferPointer;

            [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, nuint> GetBufferSize;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3DBlob.Native*, uint>)(lpVtbl[1]))(
                (ID3DBlob.Native*)Unsafe.AsPointer(ref this)
            );
        }

        [VtblIndex(3)]
        [return: NativeTypeName("LPVOID")]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr GetBufferPointer() => (void*)GetBufferPointerRaw();

        /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob.GetBufferPointer"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("LPVOID")]
        public void* GetBufferPointerRaw()
        {
            return ((delegate* unmanaged<ID3DBlob.Native*, void*>)(lpVtbl[3]))(
                (ID3DBlob.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob.GetBufferSize"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("SIZE_T")]
        public nuint GetBufferSize()
        {
            return ((delegate* unmanaged<ID3DBlob.Native*, nuint>)(lpVtbl[4]))(
                (ID3DBlob.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3DBlob.Native*, Guid*, void**, HResult>)(lpVtbl[0]))(
                (ID3DBlob.Native*)Unsafe.AsPointer(ref this),
                riid,
                ppvObject
            );
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult QueryInterface(
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppvObject
        )
        {
            fixed (void** __dsl_ppvObject = ppvObject)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
            }
        }

        [VtblIndex(0)]
        [Transformed]
        public HResult QueryInterface<TCom>(out TCom ppvObject)
            where TCom : unmanaged, IComVtbl
        {
            ppvObject = default;
            return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
        }

        /// <inheritdoc cref = "IUnknown.Release"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3DBlob.Native*, uint>)(lpVtbl[2]))(
                (ID3DBlob.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3DBlob"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public ID3DBlob(Ptr3D vtbl) => LpVtbl = (ID3DBlob.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "ID3DBlob"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public ID3DBlob(Ptr<ID3DBlob.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "ID3DBlob.Native"/> to <see cref = "ID3DBlob"/>.</summary>
    /// <param name = "value">The <see cref = "ID3DBlob.Native"/> instance to be converted </param>

    public static implicit operator ID3DBlob(ID3DBlob.Native* value) =>
        new ID3DBlob((Ptr<Native>)value);

    /// <summary>casts <see cref = "ID3DBlob"/> to <see cref = "ID3DBlob.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DBlob"/> instance to be converted </param>

    public static implicit operator ID3DBlob.Native*(ID3DBlob value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3DBlob"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator ID3DBlob(Ptr3D value) => new ID3DBlob(value);

    /// <summary>casts <see cref = "ID3DBlob"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3DBlob"/> instance to be converted </param>

    public static implicit operator Ptr3D(ID3DBlob value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3DBlob"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator ID3DBlob(Ptr<ID3DBlob.Native> value) => new ID3DBlob(value);

    /// <summary>casts <see cref = "ID3DBlob"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3DBlob"/> instance to be converted </param>

    public static implicit operator Ptr<ID3DBlob.Native>(ID3DBlob value) =>
        (Ptr<ID3DBlob.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "ID3DBlob"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator ID3DBlob(void*** value) => new ID3DBlob((Ptr<Native>)value);

    /// <summary>casts <see cref = "ID3DBlob"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DBlob"/> instance to be converted </param>

    public static implicit operator void***(ID3DBlob value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3DBlob"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator ID3DBlob(nuint value) =>
        new ID3DBlob((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "ID3DBlob"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3DBlob"/> instance to be converted </param>

    public static implicit operator nuint(ID3DBlob value) => (nuint)value.LpVtbl;

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xFB,
                0xA5,
                0x8B,
                0x95,
                0x51,
                0xE2,
                0x40,
                0xAC,
                0x58,
                0x0D,
                0x98,
                0x9C,
                0x3A,
                0x01,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Core.IUnknown"/> to <see cref = "ID3DBlob"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Core.IUnknown"/> instance to be converted </param>

    public static explicit operator ID3DBlob(Silk.NET.Core.IUnknown value) =>
        new ID3DBlob((Ptr<ID3DBlob.Native>)value.LpVtbl);

    /// <summary>Upcasts <see cref = "ID3DBlob"/> to <see cref = "Silk.NET.Core.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3DBlob"/> instance to be converted </param>

    public static implicit operator Silk.NET.Core.IUnknown(ID3DBlob value) =>
        new Silk.NET.Core.IUnknown((Ptr<Silk.NET.Core.IUnknown.Native>)value.LpVtbl);

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    public void Dispose() => Release();

    /// <inheritdoc cref = "IComVtbl.GetAddressOf{TNativeInterface}()"></inheritdoc>

    public readonly Ptr2D<TNativeInterface> GetAddressOf<TNativeInterface>()
        where TNativeInterface : unmanaged =>
        (TNativeInterface**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));

    /// <inheritdoc cref = "IComVtbl.GetAddressOf()"></inheritdoc>

    public readonly Ptr2D GetAddressOf() => (void**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));

    [VtblIndex(3)]
    [return: NativeTypeName("LPVOID")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Ptr GetBufferPointer() => (void*)GetBufferPointerRaw();

    /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob.GetBufferPointer"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointerRaw() => LpVtbl->GetBufferPointerRaw();

    /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob.GetBufferSize"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize() => LpVtbl->GetBufferSize();

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) =>
        LpVtbl->QueryInterface(riid, ppvObject);

    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [VtblIndex(0)]
    [Transformed]
    public HResult QueryInterface<TCom>(out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
}
