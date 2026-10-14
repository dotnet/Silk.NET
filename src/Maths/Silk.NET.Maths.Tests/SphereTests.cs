// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class SphereTests
    {
        [Fact]
        public void ContainsSphereTest()
        {
            var parent = new Sphere<float>(Vector3D<float>.Zero, 10.0f);

            // Concentric sphere completely inside
            var insideConcentric = new Sphere<float>(Vector3D<float>.Zero, 5.0f);
            Assert.True(parent.Contains(insideConcentric));

            // Smaller sphere should not contain larger sphere
            Assert.False(insideConcentric.Contains(parent));

            // Identical sphere (touching boundaries)
            Assert.True(parent.Contains(parent));

            // Non-concentric sphere completely inside
            var insideOffset = new Sphere<float>(new Vector3D<float>(2.0f, 2.0f, 2.0f), 4.0f);
            Assert.True(parent.Contains(insideOffset));
            Assert.False(insideOffset.Contains(parent));

            // Sphere tangent internally (distance = 6, radius = 4, distance + radius = 10)
            var tangentInternal = new Sphere<float>(new Vector3D<float>(0.0f, 0.0f, 6.0f), 4.0f);
            Assert.True(parent.Contains(tangentInternal));
            Assert.False(tangentInternal.Contains(parent));

            // Intersecting sphere partially outside
            var intersecting = new Sphere<float>(new Vector3D<float>(0.0f, 0.0f, 8.0f), 4.0f);
            Assert.False(parent.Contains(intersecting));
            Assert.False(intersecting.Contains(parent));

            // Disjoint sphere completely outside
            var disjoint = new Sphere<float>(new Vector3D<float>(20.0f, 0.0f, 0.0f), 2.0f);
            Assert.False(parent.Contains(disjoint));
            Assert.False(disjoint.Contains(parent));
        }

        [Fact]
        public void ContainsPointTest()
        {
            var sphere = new Sphere<float>(Vector3D<float>.Zero, 5.0f);

            // Center
            Assert.True(sphere.Contains(Vector3D<float>.Zero));

            // Inside
            Assert.True(sphere.Contains(new Vector3D<float>(1.0f, 2.0f, 2.0f)));

            // On edge (3^2 + 4^2 = 25)
            Assert.True(sphere.Contains(new Vector3D<float>(3.0f, 4.0f, 0.0f)));
            Assert.True(sphere.Contains(new Vector3D<float>(0.0f, 0.0f, 5.0f)));

            // Outside
            Assert.False(sphere.Contains(new Vector3D<float>(5.1f, 0.0f, 0.0f)));
            Assert.False(sphere.Contains(new Vector3D<float>(3.0f, 4.0f, 0.1f)));
            Assert.False(sphere.Contains(new Vector3D<float>(-6.0f, 0.0f, 0.0f)));
        }
    }
}
