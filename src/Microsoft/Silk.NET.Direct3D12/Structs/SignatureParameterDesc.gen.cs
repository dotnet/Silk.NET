// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "_D3D12_SIGNATURE_PARAMETER_DESC")]
    public unsafe partial struct SignatureParameterDesc
    {
        public SignatureParameterDesc
        (
            byte* semanticName = default,
            uint semanticIndex = default,
            uint register = default,
            Silk.NET.Core.Native.Name systemValueType = default,
            Silk.NET.Core.Native.RegisterComponentType componentType = default,
            byte mask = default,
            byte readWriteMask = default,
            uint stream = default,
            Silk.NET.Core.Native.MinPrecision minPrecision = default
        )
        {
            SemanticName = semanticName;
            SemanticIndex = semanticIndex;
            Register = register;
            SystemValueType = systemValueType;
            ComponentType = componentType;
            Mask = mask;
            ReadWriteMask = readWriteMask;
            Stream = stream;
            MinPrecision = minPrecision;
        }


        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "SemanticName")]
        public byte* SemanticName;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SemanticIndex")]
        public uint SemanticIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Register")]
        public uint Register;

        [NativeName("Type", "D3D_NAME")]
        [NativeName("Type.Name", "D3D_NAME")]
        [NativeName("Name", "SystemValueType")]
        public Silk.NET.Core.Native.Name SystemValueType;

        [NativeName("Type", "D3D_REGISTER_COMPONENT_TYPE")]
        [NativeName("Type.Name", "D3D_REGISTER_COMPONENT_TYPE")]
        [NativeName("Name", "ComponentType")]
        public Silk.NET.Core.Native.RegisterComponentType ComponentType;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "Mask")]
        public byte Mask;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "ReadWriteMask")]
        public byte ReadWriteMask;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Stream")]
        public uint Stream;

        [NativeName("Type", "D3D_MIN_PRECISION")]
        [NativeName("Type.Name", "D3D_MIN_PRECISION")]
        [NativeName("Name", "MinPrecision")]
        public Silk.NET.Core.Native.MinPrecision MinPrecision;
    }
}
