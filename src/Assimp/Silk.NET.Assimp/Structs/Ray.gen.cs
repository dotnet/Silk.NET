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
    [NativeName("Name", "aiRay")]
    public unsafe partial struct Ray
    {
        public Ray
        (
            System.Numerics.Vector3? pos = null,
            System.Numerics.Vector3? dir = null
        ) : this()
        {
            if (pos is not null)
            {
                Pos = pos.Value;
            }

            if (dir is not null)
            {
                Dir = dir.Value;
            }
        }


        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "pos")]
        public System.Numerics.Vector3 Pos;

        [NativeName("Type", "aiVector3D")]
        [NativeName("Type.Name", "aiVector3D")]
        [NativeName("Name", "dir")]
        public System.Numerics.Vector3 Dir;
    }
}
