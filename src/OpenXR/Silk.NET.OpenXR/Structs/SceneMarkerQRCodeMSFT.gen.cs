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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSceneMarkerQRCodeMSFT")]
    public unsafe partial struct SceneMarkerQRCodeMSFT
    {
        public SceneMarkerQRCodeMSFT
        (
            SceneMarkerQRCodeSymbolTypeMSFT? symbolType = null,
            byte? version = null
        ) : this()
        {
            if (symbolType is not null)
            {
                SymbolType = symbolType.Value;
            }

            if (version is not null)
            {
                Version = version.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrSceneMarkerQRCodeSymbolTypeMSFT")]
        [NativeName("Type.Name", "XrSceneMarkerQRCodeSymbolTypeMSFT")]
        [NativeName("Name", "symbolType")]
        public SceneMarkerQRCodeSymbolTypeMSFT SymbolType;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "version")]
        public byte Version;
    }
}
