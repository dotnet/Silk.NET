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

/// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude"]/*'/>
public unsafe partial struct ID3DInclude : ID3DInclude.Interface
{
    public void** LpVtbl;

    public interface Interface
    {
        [VtblIndex(1)]
        HResult Close([NativeTypeName("LPCVOID")] void* pData);

        [VtblIndex(1)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult Close([NativeTypeName("LPCVOID")] Ref pData);

        [VtblIndex(0)]
        HResult Open(
            D3DIncludeType IncludeType,
            [NativeTypeName("LPCSTR")] sbyte* pFileName,
            [NativeTypeName("LPCVOID")] void* pParentData,
            [NativeTypeName("LPCVOID *")] void** ppData,
            uint* pBytes
        );

        [VtblIndex(0)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult Open(
            D3DIncludeType IncludeType,
            [NativeTypeName("LPCSTR")] Ref<sbyte> pFileName,
            [NativeTypeName("LPCVOID")] Ref pParentData,
            [NativeTypeName("LPCVOID *")] Ref2D ppData,
            Ref<uint> pBytes
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName(
            "HRESULT (D3D_INCLUDE_TYPE, LPCSTR, LPCVOID, LPCVOID *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DIncludeType,
            sbyte*,
            void*,
            void**,
            uint*,
            HResult> Open;

        [NativeTypeName("HRESULT (LPCVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, HResult> Close;
    }

    /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Close"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HResult Close([NativeTypeName("LPCVOID")] void* pData)
    {
        return ((delegate* unmanaged<ID3DInclude*, void*, HResult>)(LpVtbl[1]))(
            (ID3DInclude*)Unsafe.AsPointer(ref this),
            pData
        );
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
    public HResult Open(
        D3DIncludeType IncludeType,
        [NativeTypeName("LPCSTR")] sbyte* pFileName,
        [NativeTypeName("LPCVOID")] void* pParentData,
        [NativeTypeName("LPCVOID *")] void** ppData,
        uint* pBytes
    )
    {
        return (
            (delegate* unmanaged<
                ID3DInclude*,
                D3DIncludeType,
                sbyte*,
                void*,
                void**,
                uint*,
                HResult>)(LpVtbl[0])
        )(
            (ID3DInclude*)Unsafe.AsPointer(ref this),
            IncludeType,
            pFileName,
            pParentData,
            ppData,
            pBytes
        );
    }

    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Open(
        D3DIncludeType IncludeType,
        [NativeTypeName("LPCSTR")] Ref<sbyte> pFileName,
        [NativeTypeName("LPCVOID")] Ref pParentData,
        [NativeTypeName("LPCVOID *")] Ref2D ppData,
        Ref<uint> pBytes
    )
    {
        fixed (uint* __dsl_pBytes = pBytes)
        fixed (void** __dsl_ppData = ppData)
        fixed (void* __dsl_pParentData = pParentData)
        fixed (sbyte* __dsl_pFileName = pFileName)
        {
            return (HResult)Open(
                IncludeType,
                __dsl_pFileName,
                __dsl_pParentData,
                __dsl_ppData,
                __dsl_pBytes
            );
        }
    }
}
