// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class CubeTests
    {
        [Fact]
        public void ContainsCubeTest()
        {
            var parent = new Cube<float>(Vector3D<float>.Zero, new Vector3D<float>(10.0f, 10.0f, 10.0f));

            // Completely inside
            var inside = new Cube<float>(new Vector3D<float>(1.0f, 1.0f, 1.0f), new Vector3D<float>(5.0f, 5.0f, 5.0f));
            Assert.True(parent.Contains(inside));

            // Identical (touching boundaries)
            Assert.True(parent.Contains(parent));

            // Exceeds max X
            var exceedsX = new Cube<float>(new Vector3D<float>(1.0f, 1.0f, 1.0f), new Vector3D<float>(11.0f, 5.0f, 5.0f));
            Assert.False(parent.Contains(exceedsX));

            // Exceeds max Y
            var exceedsY = new Cube<float>(new Vector3D<float>(1.0f, 1.0f, 1.0f), new Vector3D<float>(5.0f, 11.0f, 5.0f));
            Assert.False(parent.Contains(exceedsY));

            // Exceeds max Z
            var exceedsZ = new Cube<float>(new Vector3D<float>(1.0f, 1.0f, 1.0f), new Vector3D<float>(5.0f, 5.0f, 11.0f));
            Assert.False(parent.Contains(exceedsZ));

            // Origin outside min Z
            var outsideMinZ = new Cube<float>(new Vector3D<float>(1.0f, 1.0f, -1.0f), new Vector3D<float>(5.0f, 5.0f, 5.0f));
            Assert.False(parent.Contains(outsideMinZ));
        }

        [Fact]
        public void ContainsPointTest()
        {
            var cube = new Cube<float>(Vector3D<float>.Zero, new Vector3D<float>(10.0f, 10.0f, 10.0f));

            Assert.True(cube.Contains(new Vector3D<float>(5.0f, 5.0f, 5.0f)));
            Assert.True(cube.Contains(Vector3D<float>.Zero));
            Assert.True(cube.Contains(new Vector3D<float>(10.0f, 10.0f, 10.0f)));

            Assert.False(cube.Contains(new Vector3D<float>(-1.0f, 5.0f, 5.0f)));
            Assert.False(cube.Contains(new Vector3D<float>(5.0f, -1.0f, 5.0f)));
            Assert.False(cube.Contains(new Vector3D<float>(5.0f, 5.0f, -1.0f)));
            Assert.False(cube.Contains(new Vector3D<float>(11.0f, 5.0f, 5.0f)));
            Assert.False(cube.Contains(new Vector3D<float>(5.0f, 11.0f, 5.0f)));
            Assert.False(cube.Contains(new Vector3D<float>(5.0f, 5.0f, 11.0f)));
        }
    }
}
