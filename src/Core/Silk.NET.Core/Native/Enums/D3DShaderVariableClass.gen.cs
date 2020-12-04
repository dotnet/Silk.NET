// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "_D3D_SHADER_VARIABLE_CLASS")]
    public enum D3DShaderVariableClass
    {
        [NativeName("Name", "D3D_SVC_SCALAR")]
        D3DSvcScalar = 0x0,
        [NativeName("Name", "D3D_SVC_VECTOR")]
        D3DSvcVector = 0x1,
        [NativeName("Name", "D3D_SVC_MATRIX_ROWS")]
        D3DSvcMatrixRows = 0x2,
        [NativeName("Name", "D3D_SVC_MATRIX_COLUMNS")]
        D3DSvcMatrixColumns = 0x3,
        [NativeName("Name", "D3D_SVC_OBJECT")]
        D3DSvcObject = 0x4,
        [NativeName("Name", "D3D_SVC_STRUCT")]
        D3DSvcStruct = 0x5,
        [NativeName("Name", "D3D_SVC_INTERFACE_CLASS")]
        D3DSvcInterfaceClass = 0x6,
        [NativeName("Name", "D3D_SVC_INTERFACE_POINTER")]
        D3DSvcInterfacePointer = 0x7,
        [NativeName("Name", "D3D10_SVC_SCALAR")]
        D3D10SvcScalar = 0x0,
        [NativeName("Name", "D3D10_SVC_VECTOR")]
        D3D10SvcVector = 0x1,
        [NativeName("Name", "D3D10_SVC_MATRIX_ROWS")]
        D3D10SvcMatrixRows = 0x2,
        [NativeName("Name", "D3D10_SVC_MATRIX_COLUMNS")]
        D3D10SvcMatrixColumns = 0x3,
        [NativeName("Name", "D3D10_SVC_OBJECT")]
        D3D10SvcObject = 0x4,
        [NativeName("Name", "D3D10_SVC_STRUCT")]
        D3D10SvcStruct = 0x5,
        [NativeName("Name", "D3D11_SVC_INTERFACE_CLASS")]
        D3D11SvcInterfaceClass = 0x6,
        [NativeName("Name", "D3D11_SVC_INTERFACE_POINTER")]
        D3D11SvcInterfacePointer = 0x7,
        [NativeName("Name", "D3D_SVC_FORCE_DWORD")]
        D3DSvcForceDword = 0x7FFFFFFF,
    }
}
