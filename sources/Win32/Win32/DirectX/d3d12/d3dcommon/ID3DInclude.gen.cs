// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;
using System.Diagnostics;
using Silk.NET.Win32;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Silk.NET.WinRT;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude"]/*'/>
public unsafe partial struct ID3DInclude : ID3DInclude.Interface
{
    public Native* LpVtbl;
    public interface Interface
    {
        [VtblIndex(1)]
        HResult Close([NativeTypeName("LPCVOID")] void* pData);
        [VtblIndex(1)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult Close([NativeTypeName("LPCVOID")] Ref pData);
        [VtblIndex(0)]
        HResult Open(D3DIncludeType IncludeType, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("LPCVOID")] void* pParentData, [NativeTypeName("LPCVOID *")] void** ppData, uint* pBytes);
        [VtblIndex(0)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult Open(D3DIncludeType IncludeType, [NativeTypeName("LPCSTR")] Ref<sbyte> pFileName, [NativeTypeName("LPCVOID")] Ref pParentData, [NativeTypeName("LPCVOID *")] Ref2D ppData, Ref<uint> pBytes);
    }

    /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude"]/*'/>
    public unsafe partial struct Native : Interface
    {
        public void** lpVtbl;
        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (D3D_INCLUDE_TYPE, LPCSTR, LPCVOID, LPCVOID *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DIncludeType, sbyte*, void*, void**, uint*, HResult> Open;
            [NativeTypeName("HRESULT (LPCVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, HResult> Close;
        }

        /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Close"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public HResult Close([NativeTypeName("LPCVOID")] void* pData)
        {
            return ((delegate* unmanaged<ID3DInclude.Native*, void*, HResult> )(lpVtbl[1]))((ID3DInclude.Native*)Unsafe.AsPointer(ref this), pData);
        }

        [VtblIndex(1)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Close([NativeTypeName("LPCVOID")] Ref pData)
        {
            fixed (void* __dsl_pData = pData)
            {
                return (HResult)Close(__dsl_pData);
            }
        }

        /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Open"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult Open(D3DIncludeType IncludeType, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("LPCVOID")] void* pParentData, [NativeTypeName("LPCVOID *")] void** ppData, uint* pBytes)
        {
            return ((delegate* unmanaged<ID3DInclude.Native*, D3DIncludeType, sbyte*, void*, void**, uint*, HResult> )(lpVtbl[0]))((ID3DInclude.Native*)Unsafe.AsPointer(ref this), IncludeType, pFileName, pParentData, ppData, pBytes);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Open(D3DIncludeType IncludeType, [NativeTypeName("LPCSTR")] Ref<sbyte> pFileName, [NativeTypeName("LPCVOID")] Ref pParentData, [NativeTypeName("LPCVOID *")] Ref2D ppData, Ref<uint> pBytes)
        {
            fixed (uint* __dsl_pBytes = pBytes)
            fixed (void** __dsl_ppData = ppData)
            fixed (void* __dsl_pParentData = pParentData)
            fixed (sbyte* __dsl_pFileName = pFileName)
            {
                return (HResult)Open(IncludeType, __dsl_pFileName, __dsl_pParentData, __dsl_ppData, __dsl_pBytes);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3DInclude"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3DInclude(Ptr3D vtbl) => LpVtbl = (ID3DInclude.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3DInclude"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3DInclude(Ptr<ID3DInclude.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3DInclude.Native"/> to <see cref = "ID3DInclude"/>.</summary>
    /// <param name = "value">The <see cref = "ID3DInclude.Native"/> instance to be converted </param>
    public static implicit operator ID3DInclude(ID3DInclude.Native* value) => new ID3DInclude((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3DInclude"/> to <see cref = "ID3DInclude.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DInclude"/> instance to be converted </param>
    public static implicit operator ID3DInclude.Native*(ID3DInclude value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3DInclude"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3DInclude(Ptr3D value) => new ID3DInclude(value);
    /// <summary>casts <see cref = "ID3DInclude"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3DInclude"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3DInclude value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3DInclude"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3DInclude(Ptr<ID3DInclude.Native> value) => new ID3DInclude(value);
    /// <summary>casts <see cref = "ID3DInclude"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3DInclude"/> instance to be converted </param>
    public static implicit operator Ptr<ID3DInclude.Native>(ID3DInclude value) => (Ptr<ID3DInclude.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3DInclude"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3DInclude(void*** value) => new ID3DInclude((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3DInclude"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DInclude"/> instance to be converted </param>
    public static implicit operator void***(ID3DInclude value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3DInclude"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3DInclude(nuint value) => new ID3DInclude((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3DInclude"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3DInclude"/> instance to be converted </param>
    public static implicit operator nuint(ID3DInclude value) => (nuint)value.LpVtbl;
    /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HResult Close([NativeTypeName("LPCVOID")] void* pData) => LpVtbl->Close(pData);
    [VtblIndex(1)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Close([NativeTypeName("LPCVOID")] Ref pData)
    {
        fixed (void* __dsl_pData = pData)
        {
            return (HResult)Close(__dsl_pData);
        }
    }

    /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Open"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult Open(D3DIncludeType IncludeType, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("LPCVOID")] void* pParentData, [NativeTypeName("LPCVOID *")] void** ppData, uint* pBytes) => LpVtbl->Open(IncludeType, pFileName, pParentData, ppData, pBytes);
    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Open(D3DIncludeType IncludeType, [NativeTypeName("LPCSTR")] Ref<sbyte> pFileName, [NativeTypeName("LPCVOID")] Ref pParentData, [NativeTypeName("LPCVOID *")] Ref2D ppData, Ref<uint> pBytes)
    {
        fixed (uint* __dsl_pBytes = pBytes)
        fixed (void** __dsl_ppData = ppData)
        fixed (void* __dsl_pParentData = pParentData)
        fixed (sbyte* __dsl_pFileName = pFileName)
        {
            return (HResult)Open(IncludeType, __dsl_pFileName, __dsl_pParentData, __dsl_ppData, __dsl_pBytes);
        }
    }
}