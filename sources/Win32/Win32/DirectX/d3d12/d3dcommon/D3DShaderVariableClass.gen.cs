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

/// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS"]/*'/>
public enum D3DShaderVariableClass
{
    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_SCALAR"]/*'/>

    DSvcScalar = 0,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_VECTOR"]/*'/>

    DSvcVector = (DSvcScalar + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_MATRIX_ROWS"]/*'/>

    DSvcMatrixRows = (DSvcVector + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_MATRIX_COLUMNS"]/*'/>

    DSvcMatrixColumns = (DSvcMatrixRows + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_OBJECT"]/*'/>

    DSvcObject = (DSvcMatrixColumns + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_STRUCT"]/*'/>

    DSvcStruct = (DSvcObject + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_INTERFACE_CLASS"]/*'/>

    DSvcInterfaceClass = (DSvcStruct + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_INTERFACE_POINTER"]/*'/>

    DSvcInterfacePointer = (DSvcInterfaceClass + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_SCALAR"]/*'/>

    D10SvcScalar = DSvcScalar,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_VECTOR"]/*'/>

    D10SvcVector = DSvcVector,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_MATRIX_ROWS"]/*'/>

    D10SvcMatrixRows = DSvcMatrixRows,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_MATRIX_COLUMNS"]/*'/>

    D10SvcMatrixColumns = DSvcMatrixColumns,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_OBJECT"]/*'/>

    D10SvcObject = DSvcObject,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_STRUCT"]/*'/>

    D10SvcStruct = DSvcStruct,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D11_SVC_INTERFACE_CLASS"]/*'/>

    D11SvcInterfaceClass = DSvcInterfaceClass,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D11_SVC_INTERFACE_POINTER"]/*'/>

    D11SvcInterfacePointer = DSvcInterfacePointer,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_FORCE_DWORD"]/*'/>

    DSvcForceDword = 0x7fffffff,
}
