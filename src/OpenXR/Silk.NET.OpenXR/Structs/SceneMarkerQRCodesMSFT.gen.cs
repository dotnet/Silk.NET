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
    [NativeName("Name", "XrSceneMarkerQRCodesMSFT")]
    public unsafe partial struct SceneMarkerQRCodesMSFT
    {
        public SceneMarkerQRCodesMSFT
        (
            StructureType? type = StructureType.TypeSceneMarkerQRCodesMsft,
            void* next = null,
            uint? qrCodeCapacityInput = null,
            SceneMarkerQRCodeMSFT* qrCodes = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (qrCodeCapacityInput is not null)
            {
                QrCodeCapacityInput = qrCodeCapacityInput.Value;
            }

            if (qrCodes is not null)
            {
                QrCodes = qrCodes;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "qrCodeCapacityInput")]
        public uint QrCodeCapacityInput;
/// <summary></summary>
        [NativeName("Type", "XrSceneMarkerQRCodeMSFT*")]
        [NativeName("Type.Name", "XrSceneMarkerQRCodeMSFT")]
        [NativeName("Name", "qrCodes")]
        public SceneMarkerQRCodeMSFT* QrCodes;
    }
}
