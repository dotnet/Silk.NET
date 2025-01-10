// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CD24EED5-5FEA-4742-A320-6254C920E78B")]
[NativeTypeName("struct IDiaSessionEx : IDiaSession")]
[NativeInheritance("IDiaSession")]
public unsafe partial struct IDiaSessionEx : IDiaSessionEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaSessionEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaSessionEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaSessionEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaSessionEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_loadAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSessionEx, ulong*, int>)((*lpVtbl)[3]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_loadAddress([NativeTypeName("ULONGLONG")] ulong NewVal)
    {
        return ((delegate* unmanaged<IDiaSessionEx, ulong, int>)((*lpVtbl)[4]))(this, NewVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_globalScope(IDiaSymbol* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSessionEx, IDiaSymbol*, int>)((*lpVtbl)[5]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT getEnumTables(IDiaEnumTables* ppEnumTables)
    {
        return ((delegate* unmanaged<IDiaSessionEx, IDiaEnumTables*, int>)((*lpVtbl)[6]))(
            this,
            ppEnumTables
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT getSymbolsByAddr(IDiaEnumSymbolsByAddr* ppEnumbyAddr)
    {
        return ((delegate* unmanaged<IDiaSessionEx, IDiaEnumSymbolsByAddr*, int>)((*lpVtbl)[7]))(
            this,
            ppEnumbyAddr
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT findChildren(
        IDiaSymbol parent,
        [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag,
        [NativeTypeName("LPCOLESTR")] ushort* name,
        [NativeTypeName("DWORD")] uint compareFlags,
        IDiaEnumSymbols* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDiaSessionEx,
                IDiaSymbol,
                SymTagEnum,
                ushort*,
                uint,
                IDiaEnumSymbols*,
                int>)((*lpVtbl)[8])
        )(this, parent, symtag, name, compareFlags, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT findChildrenEx(
        IDiaSymbol parent,
        [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag,
        [NativeTypeName("LPCOLESTR")] ushort* name,
        [NativeTypeName("DWORD")] uint compareFlags,
        IDiaEnumSymbols* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDiaSessionEx,
                IDiaSymbol,
                SymTagEnum,
                ushort*,
                uint,
                IDiaEnumSymbols*,
                int>)((*lpVtbl)[9])
        )(this, parent, symtag, name, compareFlags, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT findChildrenExByAddr(
        IDiaSymbol parent,
        [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag,
        [NativeTypeName("LPCOLESTR")] ushort* name,
        [NativeTypeName("DWORD")] uint compareFlags,
        [NativeTypeName("DWORD")] uint isect,
        [NativeTypeName("DWORD")] uint offset,
        IDiaEnumSymbols* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDiaSessionEx,
                IDiaSymbol,
                SymTagEnum,
                ushort*,
                uint,
                uint,
                uint,
                IDiaEnumSymbols*,
                int>)((*lpVtbl)[10])
        )(this, parent, symtag, name, compareFlags, isect, offset, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT findChildrenExByVA(
        IDiaSymbol parent,
        [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag,
        [NativeTypeName("LPCOLESTR")] ushort* name,
        [NativeTypeName("DWORD")] uint compareFlags,
        [NativeTypeName("ULONGLONG")] ulong va,
        IDiaEnumSymbols* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDiaSessionEx,
                IDiaSymbol,
                SymTagEnum,
                ushort*,
                uint,
                ulong,
                IDiaEnumSymbols*,
                int>)((*lpVtbl)[11])
        )(this, parent, symtag, name, compareFlags, va, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT findChildrenExByRVA(
        IDiaSymbol parent,
        [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag,
        [NativeTypeName("LPCOLESTR")] ushort* name,
        [NativeTypeName("DWORD")] uint compareFlags,
        [NativeTypeName("DWORD")] uint rva,
        IDiaEnumSymbols* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDiaSessionEx,
                IDiaSymbol,
                SymTagEnum,
                ushort*,
                uint,
                uint,
                IDiaEnumSymbols*,
                int>)((*lpVtbl)[12])
        )(this, parent, symtag, name, compareFlags, rva, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT findSymbolByAddr(
        [NativeTypeName("DWORD")] uint isect,
        [NativeTypeName("DWORD")] uint offset,
        [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag,
        IDiaSymbol* ppSymbol
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, uint, uint, SymTagEnum, IDiaSymbol*, int>)(
                (*lpVtbl)[13]
            )
        )(this, isect, offset, symtag, ppSymbol);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT findSymbolByRVA(
        [NativeTypeName("DWORD")] uint rva,
        [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag,
        IDiaSymbol* ppSymbol
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, uint, SymTagEnum, IDiaSymbol*, int>)((*lpVtbl)[14])
        )(this, rva, symtag, ppSymbol);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT findSymbolByVA(
        [NativeTypeName("ULONGLONG")] ulong va,
        [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag,
        IDiaSymbol* ppSymbol
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, ulong, SymTagEnum, IDiaSymbol*, int>)((*lpVtbl)[15])
        )(this, va, symtag, ppSymbol);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT findSymbolByToken(
        [NativeTypeName("ULONG")] uint token,
        [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag,
        IDiaSymbol* ppSymbol
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, uint, SymTagEnum, IDiaSymbol*, int>)((*lpVtbl)[16])
        )(this, token, symtag, ppSymbol);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT symsAreEquiv(IDiaSymbol symbolA, IDiaSymbol symbolB)
    {
        return ((delegate* unmanaged<IDiaSessionEx, IDiaSymbol, IDiaSymbol, int>)((*lpVtbl)[17]))(
            this,
            symbolA,
            symbolB
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT symbolById([NativeTypeName("DWORD")] uint id, IDiaSymbol* ppSymbol)
    {
        return ((delegate* unmanaged<IDiaSessionEx, uint, IDiaSymbol*, int>)((*lpVtbl)[18]))(
            this,
            id,
            ppSymbol
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT findSymbolByRVAEx(
        [NativeTypeName("DWORD")] uint rva,
        [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag,
        IDiaSymbol* ppSymbol,
        [NativeTypeName("long *")] int* displacement
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, uint, SymTagEnum, IDiaSymbol*, int*, int>)(
                (*lpVtbl)[19]
            )
        )(this, rva, symtag, ppSymbol, displacement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT findSymbolByVAEx(
        [NativeTypeName("ULONGLONG")] ulong va,
        [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag,
        IDiaSymbol* ppSymbol,
        [NativeTypeName("long *")] int* displacement
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, ulong, SymTagEnum, IDiaSymbol*, int*, int>)(
                (*lpVtbl)[20]
            )
        )(this, va, symtag, ppSymbol, displacement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT findFile(
        IDiaSymbol pCompiland,
        [NativeTypeName("LPCOLESTR")] ushort* name,
        [NativeTypeName("DWORD")] uint compareFlags,
        IDiaEnumSourceFiles* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDiaSessionEx,
                IDiaSymbol,
                ushort*,
                uint,
                IDiaEnumSourceFiles*,
                int>)((*lpVtbl)[21])
        )(this, pCompiland, name, compareFlags, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT findFileById([NativeTypeName("DWORD")] uint uniqueId, IDiaSourceFile* ppResult)
    {
        return ((delegate* unmanaged<IDiaSessionEx, uint, IDiaSourceFile*, int>)((*lpVtbl)[22]))(
            this,
            uniqueId,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT findLines(
        IDiaSymbol compiland,
        IDiaSourceFile file,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDiaSessionEx,
                IDiaSymbol,
                IDiaSourceFile,
                IDiaEnumLineNumbers*,
                int>)((*lpVtbl)[23])
        )(this, compiland, file, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT findLinesByAddr(
        [NativeTypeName("DWORD")] uint seg,
        [NativeTypeName("DWORD")] uint offset,
        [NativeTypeName("DWORD")] uint length,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, uint, uint, uint, IDiaEnumLineNumbers*, int>)(
                (*lpVtbl)[24]
            )
        )(this, seg, offset, length, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT findLinesByRVA(
        [NativeTypeName("DWORD")] uint rva,
        [NativeTypeName("DWORD")] uint length,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, uint, uint, IDiaEnumLineNumbers*, int>)(
                (*lpVtbl)[25]
            )
        )(this, rva, length, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT findLinesByVA(
        [NativeTypeName("ULONGLONG")] ulong va,
        [NativeTypeName("DWORD")] uint length,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, ulong, uint, IDiaEnumLineNumbers*, int>)(
                (*lpVtbl)[26]
            )
        )(this, va, length, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT findLinesByLinenum(
        IDiaSymbol compiland,
        IDiaSourceFile file,
        [NativeTypeName("DWORD")] uint linenum,
        [NativeTypeName("DWORD")] uint column,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDiaSessionEx,
                IDiaSymbol,
                IDiaSourceFile,
                uint,
                uint,
                IDiaEnumLineNumbers*,
                int>)((*lpVtbl)[27])
        )(this, compiland, file, linenum, column, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT findInjectedSource(
        [NativeTypeName("LPCOLESTR")] ushort* srcFile,
        IDiaEnumInjectedSources* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, ushort*, IDiaEnumInjectedSources*, int>)(
                (*lpVtbl)[28]
            )
        )(this, srcFile, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT getEnumDebugStreams(IDiaEnumDebugStreams* ppEnumDebugStreams)
    {
        return ((delegate* unmanaged<IDiaSessionEx, IDiaEnumDebugStreams*, int>)((*lpVtbl)[29]))(
            this,
            ppEnumDebugStreams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT findInlineFramesByAddr(
        IDiaSymbol parent,
        [NativeTypeName("DWORD")] uint isect,
        [NativeTypeName("DWORD")] uint offset,
        IDiaEnumSymbols* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, IDiaSymbol, uint, uint, IDiaEnumSymbols*, int>)(
                (*lpVtbl)[30]
            )
        )(this, parent, isect, offset, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT findInlineFramesByRVA(
        IDiaSymbol parent,
        [NativeTypeName("DWORD")] uint rva,
        IDiaEnumSymbols* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, IDiaSymbol, uint, IDiaEnumSymbols*, int>)(
                (*lpVtbl)[31]
            )
        )(this, parent, rva, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT findInlineFramesByVA(
        IDiaSymbol parent,
        [NativeTypeName("ULONGLONG")] ulong va,
        IDiaEnumSymbols* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, IDiaSymbol, ulong, IDiaEnumSymbols*, int>)(
                (*lpVtbl)[32]
            )
        )(this, parent, va, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT findInlineeLines(IDiaSymbol parent, IDiaEnumLineNumbers* ppResult)
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, IDiaSymbol, IDiaEnumLineNumbers*, int>)(
                (*lpVtbl)[33]
            )
        )(this, parent, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT findInlineeLinesByAddr(
        IDiaSymbol parent,
        [NativeTypeName("DWORD")] uint isect,
        [NativeTypeName("DWORD")] uint offset,
        [NativeTypeName("DWORD")] uint length,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDiaSessionEx,
                IDiaSymbol,
                uint,
                uint,
                uint,
                IDiaEnumLineNumbers*,
                int>)((*lpVtbl)[34])
        )(this, parent, isect, offset, length, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT findInlineeLinesByRVA(
        IDiaSymbol parent,
        [NativeTypeName("DWORD")] uint rva,
        [NativeTypeName("DWORD")] uint length,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, IDiaSymbol, uint, uint, IDiaEnumLineNumbers*, int>)(
                (*lpVtbl)[35]
            )
        )(this, parent, rva, length, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT findInlineeLinesByVA(
        IDiaSymbol parent,
        [NativeTypeName("ULONGLONG")] ulong va,
        [NativeTypeName("DWORD")] uint length,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDiaSessionEx,
                IDiaSymbol,
                ulong,
                uint,
                IDiaEnumLineNumbers*,
                int>)((*lpVtbl)[36])
        )(this, parent, va, length, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT findInlineeLinesByLinenum(
        IDiaSymbol compiland,
        IDiaSourceFile file,
        [NativeTypeName("DWORD")] uint linenum,
        [NativeTypeName("DWORD")] uint column,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDiaSessionEx,
                IDiaSymbol,
                IDiaSourceFile,
                uint,
                uint,
                IDiaEnumLineNumbers*,
                int>)((*lpVtbl)[37])
        )(this, compiland, file, linenum, column, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT findInlineesByName(
        [NativeTypeName("LPCOLESTR")] ushort* name,
        [NativeTypeName("DWORD")] uint option,
        IDiaEnumSymbols* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, ushort*, uint, IDiaEnumSymbols*, int>)(
                (*lpVtbl)[38]
            )
        )(this, name, option, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT findAcceleratorInlineeLinesByLinenum(
        IDiaSymbol parent,
        IDiaSourceFile file,
        [NativeTypeName("DWORD")] uint linenum,
        [NativeTypeName("DWORD")] uint column,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IDiaSessionEx,
                IDiaSymbol,
                IDiaSourceFile,
                uint,
                uint,
                IDiaEnumLineNumbers*,
                int>)((*lpVtbl)[39])
        )(this, parent, file, linenum, column, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT findSymbolsForAcceleratorPointerTag(
        IDiaSymbol parent,
        [NativeTypeName("DWORD")] uint tagValue,
        IDiaEnumSymbols* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, IDiaSymbol, uint, IDiaEnumSymbols*, int>)(
                (*lpVtbl)[40]
            )
        )(this, parent, tagValue, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT findSymbolsByRVAForAcceleratorPointerTag(
        IDiaSymbol parent,
        [NativeTypeName("DWORD")] uint tagValue,
        [NativeTypeName("DWORD")] uint rva,
        IDiaEnumSymbols* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, IDiaSymbol, uint, uint, IDiaEnumSymbols*, int>)(
                (*lpVtbl)[41]
            )
        )(this, parent, tagValue, rva, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT findAcceleratorInlineesByName(
        [NativeTypeName("LPCOLESTR")] ushort* name,
        [NativeTypeName("DWORD")] uint option,
        IDiaEnumSymbols* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, ushort*, uint, IDiaEnumSymbols*, int>)(
                (*lpVtbl)[42]
            )
        )(this, name, option, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT addressForVA(
        [NativeTypeName("ULONGLONG")] ulong va,
        [NativeTypeName("DWORD *")] uint* pISect,
        [NativeTypeName("DWORD *")] uint* pOffset
    )
    {
        return ((delegate* unmanaged<IDiaSessionEx, ulong, uint*, uint*, int>)((*lpVtbl)[43]))(
            this,
            va,
            pISect,
            pOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT addressForRVA(
        [NativeTypeName("DWORD")] uint rva,
        [NativeTypeName("DWORD *")] uint* pISect,
        [NativeTypeName("DWORD *")] uint* pOffset
    )
    {
        return ((delegate* unmanaged<IDiaSessionEx, uint, uint*, uint*, int>)((*lpVtbl)[44]))(
            this,
            rva,
            pISect,
            pOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT findILOffsetsByAddr(
        [NativeTypeName("DWORD")] uint isect,
        [NativeTypeName("DWORD")] uint offset,
        [NativeTypeName("DWORD")] uint length,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, uint, uint, uint, IDiaEnumLineNumbers*, int>)(
                (*lpVtbl)[45]
            )
        )(this, isect, offset, length, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT findILOffsetsByRVA(
        [NativeTypeName("DWORD")] uint rva,
        [NativeTypeName("DWORD")] uint length,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, uint, uint, IDiaEnumLineNumbers*, int>)(
                (*lpVtbl)[46]
            )
        )(this, rva, length, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT findILOffsetsByVA(
        [NativeTypeName("ULONGLONG")] ulong va,
        [NativeTypeName("DWORD")] uint length,
        IDiaEnumLineNumbers* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, ulong, uint, IDiaEnumLineNumbers*, int>)(
                (*lpVtbl)[47]
            )
        )(this, va, length, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT findInputAssemblyFiles(IDiaEnumInputAssemblyFiles* ppResult)
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, IDiaEnumInputAssemblyFiles*, int>)((*lpVtbl)[48])
        )(this, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT findInputAssembly(
        [NativeTypeName("DWORD")] uint index,
        IDiaInputAssemblyFile* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, uint, IDiaInputAssemblyFile*, int>)((*lpVtbl)[49])
        )(this, index, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT findInputAssemblyById(
        [NativeTypeName("DWORD")] uint uniqueId,
        IDiaInputAssemblyFile* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, uint, IDiaInputAssemblyFile*, int>)((*lpVtbl)[50])
        )(this, uniqueId, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT getFuncMDTokenMapSize([NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged<IDiaSessionEx, uint*, int>)((*lpVtbl)[51]))(this, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT getFuncMDTokenMap(
        [NativeTypeName("DWORD")] uint cb,
        [NativeTypeName("DWORD *")] uint* pcb,
        byte* pb
    )
    {
        return ((delegate* unmanaged<IDiaSessionEx, uint, uint*, byte*, int>)((*lpVtbl)[52]))(
            this,
            cb,
            pcb,
            pb
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT getTypeMDTokenMapSize([NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged<IDiaSessionEx, uint*, int>)((*lpVtbl)[53]))(this, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT getTypeMDTokenMap(
        [NativeTypeName("DWORD")] uint cb,
        [NativeTypeName("DWORD *")] uint* pcb,
        byte* pb
    )
    {
        return ((delegate* unmanaged<IDiaSessionEx, uint, uint*, byte*, int>)((*lpVtbl)[54]))(
            this,
            cb,
            pcb,
            pb
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT getNumberOfFunctionFragments_VA(
        [NativeTypeName("ULONGLONG")] ulong vaFunc,
        [NativeTypeName("DWORD")] uint cbFunc,
        [NativeTypeName("DWORD *")] uint* pNumFragments
    )
    {
        return ((delegate* unmanaged<IDiaSessionEx, ulong, uint, uint*, int>)((*lpVtbl)[55]))(
            this,
            vaFunc,
            cbFunc,
            pNumFragments
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT getNumberOfFunctionFragments_RVA(
        [NativeTypeName("DWORD")] uint rvaFunc,
        [NativeTypeName("DWORD")] uint cbFunc,
        [NativeTypeName("DWORD *")] uint* pNumFragments
    )
    {
        return ((delegate* unmanaged<IDiaSessionEx, uint, uint, uint*, int>)((*lpVtbl)[56]))(
            this,
            rvaFunc,
            cbFunc,
            pNumFragments
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT getFunctionFragments_VA(
        [NativeTypeName("ULONGLONG")] ulong vaFunc,
        [NativeTypeName("DWORD")] uint cbFunc,
        [NativeTypeName("DWORD")] uint cFragments,
        [NativeTypeName("ULONGLONG *")] ulong* pVaFragment,
        [NativeTypeName("DWORD *")] uint* pLenFragment
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, ulong, uint, uint, ulong*, uint*, int>)(
                (*lpVtbl)[57]
            )
        )(this, vaFunc, cbFunc, cFragments, pVaFragment, pLenFragment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT getFunctionFragments_RVA(
        [NativeTypeName("DWORD")] uint rvaFunc,
        [NativeTypeName("DWORD")] uint cbFunc,
        [NativeTypeName("DWORD")] uint cFragments,
        [NativeTypeName("DWORD *")] uint* pRvaFragment,
        [NativeTypeName("DWORD *")] uint* pLenFragment
    )
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, uint, uint, uint, uint*, uint*, int>)((*lpVtbl)[58])
        )(this, rvaFunc, cbFunc, cFragments, pRvaFragment, pLenFragment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT getExports(IDiaEnumSymbols* ppResult)
    {
        return ((delegate* unmanaged<IDiaSessionEx, IDiaEnumSymbols*, int>)((*lpVtbl)[59]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT getHeapAllocationSites(IDiaEnumSymbols* ppResult)
    {
        return ((delegate* unmanaged<IDiaSessionEx, IDiaEnumSymbols*, int>)((*lpVtbl)[60]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT findInputAssemblyFile(IDiaSymbol pSymbol, IDiaInputAssemblyFile* ppResult)
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, IDiaSymbol, IDiaInputAssemblyFile*, int>)(
                (*lpVtbl)[61]
            )
        )(this, pSymbol, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT isFastLinkPDB(BOOL* pfFastLinkPDB)
    {
        return ((delegate* unmanaged<IDiaSessionEx, BOOL*, int>)((*lpVtbl)[62]))(
            this,
            pfFastLinkPDB
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT isPortablePDB(BOOL* pfPortablePDB)
    {
        return ((delegate* unmanaged<IDiaSessionEx, BOOL*, int>)((*lpVtbl)[63]))(
            this,
            pfPortablePDB
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT getSourceLinkInfo(IDiaSymbol parent, IDiaEnumSourceLink* ppenum)
    {
        return (
            (delegate* unmanaged<IDiaSessionEx, IDiaSymbol, IDiaEnumSourceLink*, int>)(
                (*lpVtbl)[64]
            )
        )(this, parent, ppenum);
    }

    public interface Interface : IDiaSession.Interface
    {
        [VtblIndex(62)]
        HRESULT isFastLinkPDB(BOOL* pfFastLinkPDB);

        [VtblIndex(63)]
        HRESULT isPortablePDB(BOOL* pfPortablePDB);

        [VtblIndex(64)]
        HRESULT getSourceLinkInfo(IDiaSymbol parent, IDiaEnumSourceLink* ppenum);
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

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_loadAddress;

        [NativeTypeName("HRESULT (ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> put_loadAddress;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaSymbol*, int> get_globalScope;

        [NativeTypeName("HRESULT (IDiaEnumTables **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumTables*, int> getEnumTables;

        [NativeTypeName("HRESULT (IDiaEnumSymbolsByAddr **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumSymbolsByAddr*, int> getSymbolsByAddr;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, enum SymTagEnum, LPCOLESTR, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            SymTagEnum,
            ushort*,
            uint,
            IDiaEnumSymbols*,
            int> findChildren;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, enum SymTagEnum, LPCOLESTR, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            SymTagEnum,
            ushort*,
            uint,
            IDiaEnumSymbols*,
            int> findChildrenEx;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, enum SymTagEnum, LPCOLESTR, DWORD, DWORD, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            SymTagEnum,
            ushort*,
            uint,
            uint,
            uint,
            IDiaEnumSymbols*,
            int> findChildrenExByAddr;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, enum SymTagEnum, LPCOLESTR, DWORD, ULONGLONG, IDiaEnumSymbols **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            SymTagEnum,
            ushort*,
            uint,
            ulong,
            IDiaEnumSymbols*,
            int> findChildrenExByVA;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, enum SymTagEnum, LPCOLESTR, DWORD, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            SymTagEnum,
            ushort*,
            uint,
            uint,
            IDiaEnumSymbols*,
            int> findChildrenExByRVA;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, enum SymTagEnum, IDiaSymbol **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            SymTagEnum,
            IDiaSymbol*,
            int> findSymbolByAddr;

        [NativeTypeName("HRESULT (DWORD, enum SymTagEnum, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SymTagEnum, IDiaSymbol*, int> findSymbolByRVA;

        [NativeTypeName(
            "HRESULT (ULONGLONG, enum SymTagEnum, IDiaSymbol **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ulong, SymTagEnum, IDiaSymbol*, int> findSymbolByVA;

        [NativeTypeName("HRESULT (ULONG, enum SymTagEnum, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SymTagEnum, IDiaSymbol*, int> findSymbolByToken;

        [NativeTypeName("HRESULT (IDiaSymbol *, IDiaSymbol *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaSymbol, IDiaSymbol, int> symsAreEquiv;

        [NativeTypeName("HRESULT (DWORD, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaSymbol*, int> symbolById;

        [NativeTypeName(
            "HRESULT (DWORD, enum SymTagEnum, IDiaSymbol **, long *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            SymTagEnum,
            IDiaSymbol*,
            int*,
            int> findSymbolByRVAEx;

        [NativeTypeName(
            "HRESULT (ULONGLONG, enum SymTagEnum, IDiaSymbol **, long *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ulong,
            SymTagEnum,
            IDiaSymbol*,
            int*,
            int> findSymbolByVAEx;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, LPCOLESTR, DWORD, IDiaEnumSourceFiles **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            ushort*,
            uint,
            IDiaEnumSourceFiles*,
            int> findFile;

        [NativeTypeName("HRESULT (DWORD, IDiaSourceFile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaSourceFile*, int> findFileById;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, IDiaSourceFile *, IDiaEnumLineNumbers **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            IDiaSourceFile,
            IDiaEnumLineNumbers*,
            int> findLines;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            IDiaEnumLineNumbers*,
            int> findLinesByAddr;

        [NativeTypeName("HRESULT (DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IDiaEnumLineNumbers*, int> findLinesByRVA;

        [NativeTypeName(
            "HRESULT (ULONGLONG, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ulong, uint, IDiaEnumLineNumbers*, int> findLinesByVA;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, IDiaSourceFile *, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            IDiaSourceFile,
            uint,
            uint,
            IDiaEnumLineNumbers*,
            int> findLinesByLinenum;

        [NativeTypeName("HRESULT (LPCOLESTR, IDiaEnumInjectedSources **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IDiaEnumInjectedSources*,
            int> findInjectedSource;

        [NativeTypeName("HRESULT (IDiaEnumDebugStreams **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumDebugStreams*, int> getEnumDebugStreams;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, DWORD, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            uint,
            uint,
            IDiaEnumSymbols*,
            int> findInlineFramesByAddr;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            uint,
            IDiaEnumSymbols*,
            int> findInlineFramesByRVA;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, ULONGLONG, IDiaEnumSymbols **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            ulong,
            IDiaEnumSymbols*,
            int> findInlineFramesByVA;

        [NativeTypeName("HRESULT (IDiaSymbol *, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaSymbol, IDiaEnumLineNumbers*, int> findInlineeLines;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, DWORD, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            uint,
            uint,
            uint,
            IDiaEnumLineNumbers*,
            int> findInlineeLinesByAddr;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            uint,
            uint,
            IDiaEnumLineNumbers*,
            int> findInlineeLinesByRVA;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, ULONGLONG, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            ulong,
            uint,
            IDiaEnumLineNumbers*,
            int> findInlineeLinesByVA;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, IDiaSourceFile *, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            IDiaSourceFile,
            uint,
            uint,
            IDiaEnumLineNumbers*,
            int> findInlineeLinesByLinenum;

        [NativeTypeName("HRESULT (LPCOLESTR, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, IDiaEnumSymbols*, int> findInlineesByName;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, IDiaSourceFile *, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            IDiaSourceFile,
            uint,
            uint,
            IDiaEnumLineNumbers*,
            int> findAcceleratorInlineeLinesByLinenum;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            uint,
            IDiaEnumSymbols*,
            int> findSymbolsForAcceleratorPointerTag;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, DWORD, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            uint,
            uint,
            IDiaEnumSymbols*,
            int> findSymbolsByRVAForAcceleratorPointerTag;

        [NativeTypeName("HRESULT (LPCOLESTR, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            IDiaEnumSymbols*,
            int> findAcceleratorInlineesByName;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, uint*, uint*, int> addressForVA;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint*, int> addressForRVA;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            IDiaEnumLineNumbers*,
            int> findILOffsetsByAddr;

        [NativeTypeName("HRESULT (DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            IDiaEnumLineNumbers*,
            int> findILOffsetsByRVA;

        [NativeTypeName(
            "HRESULT (ULONGLONG, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ulong,
            uint,
            IDiaEnumLineNumbers*,
            int> findILOffsetsByVA;

        [NativeTypeName("HRESULT (IDiaEnumInputAssemblyFiles **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumInputAssemblyFiles*, int> findInputAssemblyFiles;

        [NativeTypeName("HRESULT (DWORD, IDiaInputAssemblyFile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaInputAssemblyFile*, int> findInputAssembly;

        [NativeTypeName("HRESULT (DWORD, IDiaInputAssemblyFile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaInputAssemblyFile*, int> findInputAssemblyById;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> getFuncMDTokenMapSize;

        [NativeTypeName("HRESULT (DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, byte*, int> getFuncMDTokenMap;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> getTypeMDTokenMapSize;

        [NativeTypeName("HRESULT (DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, byte*, int> getTypeMDTokenMap;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, uint, uint*, int> getNumberOfFunctionFragments_VA;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint*, int> getNumberOfFunctionFragments_RVA;

        [NativeTypeName(
            "HRESULT (ULONGLONG, DWORD, DWORD, ULONGLONG *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ulong,
            uint,
            uint,
            ulong*,
            uint*,
            int> getFunctionFragments_VA;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            uint*,
            uint*,
            int> getFunctionFragments_RVA;

        [NativeTypeName("HRESULT (IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumSymbols*, int> getExports;

        [NativeTypeName("HRESULT (IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumSymbols*, int> getHeapAllocationSites;

        [NativeTypeName(
            "HRESULT (IDiaSymbol *, IDiaInputAssemblyFile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaSymbol,
            IDiaInputAssemblyFile*,
            int> findInputAssemblyFile;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> isFastLinkPDB;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> isPortablePDB;

        [NativeTypeName("HRESULT (IDiaSymbol *, IDiaEnumSourceLink **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaSymbol, IDiaEnumSourceLink*, int> getSourceLinkInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaSessionEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaSessionEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDiaSession"/> to <see cref = "IDiaSessionEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDiaSession"/> instance to be converted </param>
    public static explicit operator IDiaSessionEx(Silk.NET.Windows.IDiaSession value)
    {
        return new IDiaSessionEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaSessionEx"/> to <see cref = "Silk.NET.Windows.IDiaSession"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaSessionEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDiaSession(IDiaSessionEx value)
    {
        return new Silk.NET.Windows.IDiaSession(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaSessionEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaSessionEx(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaSessionEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaSessionEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaSessionEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaSessionEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
