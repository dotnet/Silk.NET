// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.InteropServices;

namespace SelfContainedTexturedCube;

[StructLayout(LayoutKind.Sequential)]
public struct VertexPositionTexture
{
    public Vector3 Position;
    public Vector2 TexCoord;

    public VertexPositionTexture(Vector3 position, Vector2 texCoord)
    {
        Position = position;
        TexCoord = texCoord;
    }

    // sizeof(Vector3) + sizeof(Vector2)
    public const uint SizeInBytes = 20;
}
