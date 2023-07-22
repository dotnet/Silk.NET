// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Drawing;
using System.Numerics;

namespace SelfContainedTexturedCube;

public struct Cube
{
    public VertexPositionTexture[] Vertices => new[]
    {
        new VertexPositionTexture(new Vector3(-0.5f, 0.5f, -0.5f), new Vector2(0, 0)),
        new VertexPositionTexture(new Vector3(0.5f, 0.5f, -0.5f), new Vector2(1, 0)),
        new VertexPositionTexture(new Vector3(0.5f, 0.5f, 0.5f), new Vector2(1, 1)),
        new VertexPositionTexture(new Vector3(-0.5f, 0.5f, 0.5f), new Vector2(0, 1)),
        new VertexPositionTexture(new Vector3(-0.5f, -0.5f, 0.5f), new Vector2(0, 0)),
        new VertexPositionTexture(new Vector3(0.5f, -0.5f, 0.5f), new Vector2(1, 0)),

        new VertexPositionTexture(new Vector3(0.5f, -0.5f, -0.5f), new Vector2(1, 1)),
        new VertexPositionTexture(new Vector3(-0.5f, -0.5f, -0.5f), new Vector2(0, 1)),
        new VertexPositionTexture(new Vector3(-0.5f, 0.5f, -0.5f), new Vector2(0, 0)),
        new VertexPositionTexture(new Vector3(-0.5f, 0.5f, 0.5f), new Vector2(1, 0)),
        new VertexPositionTexture(new Vector3(-0.5f, -0.5f, 0.5f), new Vector2(1, 1)),
        new VertexPositionTexture(new Vector3(-0.5f, -0.5f, -0.5f), new Vector2(0, 1)),

        new VertexPositionTexture(new Vector3(0.5f, 0.5f, 0.5f), new Vector2(0, 0)),
        new VertexPositionTexture(new Vector3(0.5f, 0.5f, -0.5f), new Vector2(1, 0)),
        new VertexPositionTexture(new Vector3(0.5f, -0.5f, -0.5f), new Vector2(1, 1)),
        new VertexPositionTexture(new Vector3(0.5f, -0.5f, 0.5f), new Vector2(0, 1)),
        new VertexPositionTexture(new Vector3(0.5f, 0.5f, -0.5f), new Vector2(0, 0)),
        new VertexPositionTexture(new Vector3(-0.5f, 0.5f, -0.5f), new Vector2(1, 0)),

        new VertexPositionTexture(new Vector3(-0.5f, -0.5f, -0.5f), new Vector2(1, 1)),
        new VertexPositionTexture(new Vector3(0.5f, -0.5f, -0.5f), new Vector2(0, 1)),
        new VertexPositionTexture(new Vector3(-0.5f, 0.5f, 0.5f), new Vector2(0, 0)),
        new VertexPositionTexture(new Vector3(0.5f, 0.5f, 0.5f), new Vector2(1, 0)),
        new VertexPositionTexture(new Vector3(0.5f, -0.5f, 0.5f), new Vector2(1, 1)),
        new VertexPositionTexture(new Vector3(-0.5f, -0.5f, 0.5f), new Vector2(0, 1))
    };

    public uint[] Indices => new uint[]
    {
        0, 1, 2, 0, 2, 3,
        4, 5, 6, 4, 6, 7,
        8, 9, 10, 8, 10, 11,
        12, 13, 14, 12, 14, 15,
        16, 17, 18, 16, 18, 19,
        20, 21, 22, 20, 22, 23
    };
}
