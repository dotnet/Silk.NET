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

namespace Silk.NET.SPIRV.Reflect
{
    [NativeName("Name", "Matrix")]
    public unsafe partial struct Matrix
    {
        public Matrix
        (
            uint? columnCount = null,
            uint? rowCount = null,
            uint? stride = null
        ) : this()
        {
            if (columnCount is not null)
            {
                ColumnCount = columnCount.Value;
            }

            if (rowCount is not null)
            {
                RowCount = rowCount.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "column_count")]
        public uint ColumnCount;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "row_count")]
        public uint RowCount;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stride")]
        public uint Stride;
    }
}
