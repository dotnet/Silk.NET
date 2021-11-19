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

namespace Silk.NET.DXVA
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_dxvahd_L400_C5")]
    public unsafe partial struct HDStreamStateInputColorSpaceDataUnion
    {
        public HDStreamStateInputColorSpaceDataUnion
        (
            HDStreamStateInputColorSpaceDataUnionUnion? anonymous = null,
            uint? value = null,
            uint? type = null,
            uint? rGBRange = null,
            uint? yCbCrMatrix = null,
            uint? yCbCrXvYCC = null,
            uint? reserved = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (rGBRange is not null)
            {
                RGBRange = rGBRange.Value;
            }

            if (yCbCrMatrix is not null)
            {
                YCbCrMatrix = yCbCrMatrix.Value;
            }

            if (yCbCrXvYCC is not null)
            {
                YCbCrXvYCC = yCbCrXvYCC.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_dxvahd_L402_C9")]
        [NativeName("Name", "anonymous1")]
        public HDStreamStateInputColorSpaceDataUnionUnion Anonymous;

        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Value")]
        public uint Value;
        public uint Type
        {
            get => Anonymous.Type;
            set => Anonymous.Type = value;
        }

        public uint RGBRange
        {
            get => Anonymous.RGBRange;
            set => Anonymous.RGBRange = value;
        }

        public uint YCbCrMatrix
        {
            get => Anonymous.YCbCrMatrix;
            set => Anonymous.YCbCrMatrix = value;
        }

        public uint YCbCrXvYCC
        {
            get => Anonymous.YCbCrXvYCC;
            set => Anonymous.YCbCrXvYCC = value;
        }

        public uint Reserved
        {
            get => Anonymous.Reserved;
            set => Anonymous.Reserved = value;
        }

    }
}
