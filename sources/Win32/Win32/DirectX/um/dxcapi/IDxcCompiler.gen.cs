// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("8C210BF3-011F-4422-8D70-6F9ACB8DB617")]
[NativeTypeName("struct IDxcCompiler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcCompiler : IDxcCompiler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcCompiler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcCompiler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcCompiler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcCompiler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Compile(
        IDxcBlob pSource,
        [NativeTypeName("LPCWSTR")] ushort* pSourceName,
        [NativeTypeName("LPCWSTR")] ushort* pEntryPoint,
        [NativeTypeName("LPCWSTR")] ushort* pTargetProfile,
        [NativeTypeName("LPCWSTR *")] ushort** pArguments,
        [NativeTypeName("UINT32")] uint argCount,
        [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines,
        [NativeTypeName("UINT32")] uint defineCount,
        IDxcIncludeHandler pIncludeHandler,
        IDxcOperationResult* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDxcCompiler,
                IDxcBlob,
                ushort*,
                ushort*,
                ushort*,
                ushort**,
                uint,
                DxcDefine*,
                uint,
                IDxcIncludeHandler,
                IDxcOperationResult*,
                int>)((*lpVtbl)[3])
        )(
            this,
            pSource,
            pSourceName,
            pEntryPoint,
            pTargetProfile,
            pArguments,
            argCount,
            pDefines,
            defineCount,
            pIncludeHandler,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Preprocess(
        IDxcBlob pSource,
        [NativeTypeName("LPCWSTR")] ushort* pSourceName,
        [NativeTypeName("LPCWSTR *")] ushort** pArguments,
        [NativeTypeName("UINT32")] uint argCount,
        [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines,
        [NativeTypeName("UINT32")] uint defineCount,
        IDxcIncludeHandler pIncludeHandler,
        IDxcOperationResult* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDxcCompiler,
                IDxcBlob,
                ushort*,
                ushort**,
                uint,
                DxcDefine*,
                uint,
                IDxcIncludeHandler,
                IDxcOperationResult*,
                int>)((*lpVtbl)[4])
        )(
            this,
            pSource,
            pSourceName,
            pArguments,
            argCount,
            pDefines,
            defineCount,
            pIncludeHandler,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Disassemble(IDxcBlob pSource, IDxcBlobEncoding* ppDisassembly)
    {
        return (
            (delegate* unmanaged<IDxcCompiler, IDxcBlob, IDxcBlobEncoding*, int>)((*lpVtbl)[5])
        )(this, pSource, ppDisassembly);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Compile(
            IDxcBlob pSource,
            [NativeTypeName("LPCWSTR")] ushort* pSourceName,
            [NativeTypeName("LPCWSTR")] ushort* pEntryPoint,
            [NativeTypeName("LPCWSTR")] ushort* pTargetProfile,
            [NativeTypeName("LPCWSTR *")] ushort** pArguments,
            [NativeTypeName("UINT32")] uint argCount,
            [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines,
            [NativeTypeName("UINT32")] uint defineCount,
            IDxcIncludeHandler pIncludeHandler,
            IDxcOperationResult* ppResult
        );

        [VtblIndex(4)]
        HRESULT Preprocess(
            IDxcBlob pSource,
            [NativeTypeName("LPCWSTR")] ushort* pSourceName,
            [NativeTypeName("LPCWSTR *")] ushort** pArguments,
            [NativeTypeName("UINT32")] uint argCount,
            [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines,
            [NativeTypeName("UINT32")] uint defineCount,
            IDxcIncludeHandler pIncludeHandler,
            IDxcOperationResult* ppResult
        );

        [VtblIndex(5)]
        HRESULT Disassemble(IDxcBlob pSource, IDxcBlobEncoding* ppDisassembly);
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
            "HRESULT (IDxcBlob *, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcIncludeHandler *, IDxcOperationResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDxcBlob,
            ushort*,
            ushort*,
            ushort*,
            ushort**,
            uint,
            DxcDefine*,
            uint,
            IDxcIncludeHandler,
            IDxcOperationResult*,
            int> Compile;

        [NativeTypeName(
            "HRESULT (IDxcBlob *, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcIncludeHandler *, IDxcOperationResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDxcBlob,
            ushort*,
            ushort**,
            uint,
            DxcDefine*,
            uint,
            IDxcIncludeHandler,
            IDxcOperationResult*,
            int> Preprocess;

        [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobEncoding **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob, IDxcBlobEncoding*, int> Disassemble;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcCompiler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcCompiler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcCompiler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcCompiler(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcCompiler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcCompiler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcCompiler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcCompiler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
