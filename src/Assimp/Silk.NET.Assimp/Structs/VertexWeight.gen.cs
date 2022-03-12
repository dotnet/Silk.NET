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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiVertexWeight")]
    public unsafe partial struct VertexWeight
    {
        public VertexWeight
        (
            uint? mVertexId = null,
            float? mWeight = null
        ) : this()
        {
            if (mVertexId is not null)
            {
                MVertexId = mVertexId.Value;
            }

            if (mWeight is not null)
            {
                MWeight = mWeight.Value;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mVertexId")]
        public uint MVertexId;

        [NativeName("Type", "ai_real")]
        [NativeName("Type.Name", "ai_real")]
        [NativeName("Name", "mWeight")]
        public float MWeight;
    }
}
