// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            byte* semanticName = null,
            uint? semanticIndex = null,
            uint? register = null,
            Silk.NET.Core.Native.D3DName? systemValueType = null,
            Silk.NET.Core.Native.D3DRegisterComponentType? componentType = null,
            byte? mask = null,
            byte? readWriteMask = null,
            uint? stream = null,
            Silk.NET.Core.Native.D3DMinPrecision? minPrecision = null
        ) : this()
        {
            if (semanticName is not null)
            {
                SemanticName = semanticName;
            }

            if (semanticIndex is not null)
            {
                SemanticIndex = semanticIndex.Value;
            }

            if (register is not null)
            {
                Register = register.Value;
            }

            if (systemValueType is not null)
            {
                SystemValueType = systemValueType.Value;
            }

            if (componentType is not null)
            {
                ComponentType = componentType.Value;
            }

            if (mask is not null)
            {
                Mask = mask.Value;
            }

            if (readWriteMask is not null)
            {
                ReadWriteMask = readWriteMask.Value;
            }

            if (stream is not null)
            {
                Stream = stream.Value;
            }

            if (minPrecision is not null)
            {
                MinPrecision = minPrecision.Value;
            }
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
        public Silk.NET.Core.Native.D3DName SystemValueType;

        [NativeName("Type", "D3D_REGISTER_COMPONENT_TYPE")]
        [NativeName("Type.Name", "D3D_REGISTER_COMPONENT_TYPE")]
        [NativeName("Name", "ComponentType")]
        public Silk.NET.Core.Native.D3DRegisterComponentType ComponentType;

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
        public Silk.NET.Core.Native.D3DMinPrecision MinPrecision;
    }
}
