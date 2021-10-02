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
    [NativeName("Name", "_DXVAHD_BLT_STATE_OUTPUT_COLOR_SPACE_DATA")]
    public unsafe partial struct HDBltStateOutputColorSpaceData
    {
        public HDBltStateOutputColorSpaceData
        (
            HDBltStateOutputColorSpaceDataUnion? anonymous = null,
            uint? value = null,
            uint? usage = null,
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

            if (usage is not null)
            {
                Usage = usage.Value;
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


        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_dxvahd_L347_C5")]
        [NativeName("Name", "anonymous1")]
        public HDBltStateOutputColorSpaceDataUnion Anonymous;
#if NETSTANDARD2_1
        public ref uint Value
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Value;
        }
#else
        public uint Value
        {
            get => Anonymous.Value;
            set => Anonymous.Value = value;
        }
#endif

#if NETSTANDARD2_1
        public ref uint Usage
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Usage;
        }
#else
        public uint Usage
        {
            get => Anonymous.Usage;
            set => Anonymous.Usage = value;
        }
#endif

#if NETSTANDARD2_1
        public ref uint RGBRange
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.RGBRange;
        }
#else
        public uint RGBRange
        {
            get => Anonymous.RGBRange;
            set => Anonymous.RGBRange = value;
        }
#endif

#if NETSTANDARD2_1
        public ref uint YCbCrMatrix
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.YCbCrMatrix;
        }
#else
        public uint YCbCrMatrix
        {
            get => Anonymous.YCbCrMatrix;
            set => Anonymous.YCbCrMatrix = value;
        }
#endif

#if NETSTANDARD2_1
        public ref uint YCbCrXvYCC
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.YCbCrXvYCC;
        }
#else
        public uint YCbCrXvYCC
        {
            get => Anonymous.YCbCrXvYCC;
            set => Anonymous.YCbCrXvYCC = value;
        }
#endif

#if NETSTANDARD2_1
        public ref uint Reserved
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Reserved;
        }
#else
        public uint Reserved
        {
            get => Anonymous.Reserved;
            set => Anonymous.Reserved = value;
        }
#endif

    }
}
