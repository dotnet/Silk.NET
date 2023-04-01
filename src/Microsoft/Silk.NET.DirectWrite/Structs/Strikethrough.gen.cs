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

namespace Silk.NET.DirectWrite
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "DWRITE_STRIKETHROUGH")]
    public unsafe partial struct Strikethrough
    {
        public Strikethrough
        (
            float? width = null,
            float? thickness = null,
            float? offset = null,
            ReadingDirection? readingDirection = null,
            FlowDirection? flowDirection = null,
            char* localeName = null,
            MeasuringMode? measuringMode = null
        ) : this()
        {
            if (width is not null)
            {
                Width = width.Value;
            }

            if (thickness is not null)
            {
                Thickness = thickness.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (readingDirection is not null)
            {
                ReadingDirection = readingDirection.Value;
            }

            if (flowDirection is not null)
            {
                FlowDirection = flowDirection.Value;
            }

            if (localeName is not null)
            {
                LocaleName = localeName;
            }

            if (measuringMode is not null)
            {
                MeasuringMode = measuringMode.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "width")]
        public float Width;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "thickness")]
        public float Thickness;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "offset")]
        public float Offset;

        [NativeName("Type", "DWRITE_READING_DIRECTION")]
        [NativeName("Type.Name", "DWRITE_READING_DIRECTION")]
        [NativeName("Name", "readingDirection")]
        public ReadingDirection ReadingDirection;

        [NativeName("Type", "DWRITE_FLOW_DIRECTION")]
        [NativeName("Type.Name", "DWRITE_FLOW_DIRECTION")]
        [NativeName("Name", "flowDirection")]
        public FlowDirection FlowDirection;

        [NativeName("Type", "const WCHAR *")]
        [NativeName("Type.Name", "const WCHAR *")]
        [NativeName("Name", "localeName")]
        public char* LocaleName;

        [NativeName("Type", "DWRITE_MEASURING_MODE")]
        [NativeName("Type.Name", "DWRITE_MEASURING_MODE")]
        [NativeName("Name", "measuringMode")]
        public MeasuringMode MeasuringMode;
    }
}
