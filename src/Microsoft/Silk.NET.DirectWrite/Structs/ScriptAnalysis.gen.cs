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
    [NativeName("Name", "DWRITE_SCRIPT_ANALYSIS")]
    public unsafe partial struct ScriptAnalysis
    {
        public ScriptAnalysis
        (
            ushort? script = null,
            ScriptShapes? shapes = null
        ) : this()
        {
            if (script is not null)
            {
                Script = script.Value;
            }

            if (shapes is not null)
            {
                Shapes = shapes.Value;
            }
        }


        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "script")]
        public ushort Script;

        [NativeName("Type", "DWRITE_SCRIPT_SHAPES")]
        [NativeName("Type.Name", "DWRITE_SCRIPT_SHAPES")]
        [NativeName("Name", "shapes")]
        public ScriptShapes Shapes;
    }
}
