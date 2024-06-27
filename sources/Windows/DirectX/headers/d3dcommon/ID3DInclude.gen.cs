// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude"]/*'/>
public unsafe partial struct ID3DInclude : ID3DInclude.Interface
{
    public void*** lpVtbl;

    /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Open"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT Open(
        D3D_INCLUDE_TYPE IncludeType,
        [NativeTypeName("LPCSTR")] sbyte* pFileName,
        [NativeTypeName("LPCVOID")] void* pParentData,
        [NativeTypeName("LPCVOID *")] void** ppData,
        uint* pBytes
    )
    {
        return (
            (delegate* unmanaged<
                ID3DInclude*,
                D3D_INCLUDE_TYPE,
                sbyte*,
                void*,
                void**,
                uint*,
                int>)(*lpVtbl[0])
        )(
            (ID3DInclude*)Unsafe.AsPointer(ref this),
            IncludeType,
            pFileName,
            pParentData,
            ppData,
            pBytes
        );
    }

    /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Close"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT Close([NativeTypeName("LPCVOID")] void* pData)
    {
        return ((delegate* unmanaged<ID3DInclude*, void*, int>)(*lpVtbl[1]))(
            (ID3DInclude*)Unsafe.AsPointer(ref this),
            pData
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT Open(
            D3D_INCLUDE_TYPE IncludeType,
            [NativeTypeName("LPCSTR")] sbyte* pFileName,
            [NativeTypeName("LPCVOID")] void* pParentData,
            [NativeTypeName("LPCVOID *")] void** ppData,
            uint* pBytes
        );

        [VtblIndex(1)]
        HRESULT Close([NativeTypeName("LPCVOID")] void* pData);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName(
            "HRESULT (D3D_INCLUDE_TYPE, LPCSTR, LPCVOID, LPCVOID *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D_INCLUDE_TYPE,
            sbyte*,
            void*,
            void**,
            uint*,
            int> Open;

        [NativeTypeName("HRESULT (LPCVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int> Close;
    }
}
