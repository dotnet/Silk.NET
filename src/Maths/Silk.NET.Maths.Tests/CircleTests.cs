// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class CircleTests
    {
        [Fact]
        public void ContainsCircleTest()
        {
            var parent = new Circle<float>(Vector2D<float>.Zero, 10.0f);

            // Concentric circle completely inside
            var insideConcentric = new Circle<float>(Vector2D<float>.Zero, 5.0f);
            Assert.True(parent.Contains(insideConcentric));

            // Smaller circle should not contain larger circle
            Assert.False(insideConcentric.Contains(parent));

            // Identical circle (touching boundaries)
            Assert.True(parent.Contains(parent));

            // Non-concentric circle completely inside
            var insideOffset = new Circle<float>(new Vector2D<float>(2.0f, 3.0f), 4.0f);
            Assert.True(parent.Contains(insideOffset));
            Assert.False(insideOffset.Contains(parent));

            // Circle tangent internally (distance = 6, radius = 4, distance + radius = 10)
            var tangentInternal = new Circle<float>(new Vector2D<float>(6.0f, 0.0f), 4.0f);
            Assert.True(parent.Contains(tangentInternal));
            Assert.False(tangentInternal.Contains(parent));

            // Intersecting circle partially outside
            var intersecting = new Circle<float>(new Vector2D<float>(8.0f, 0.0f), 4.0f);
            Assert.False(parent.Contains(intersecting));
            Assert.False(intersecting.Contains(parent));

            // Disjoint circle completely outside
            var disjoint = new Circle<float>(new Vector2D<float>(20.0f, 0.0f), 2.0f);
            Assert.False(parent.Contains(disjoint));
            Assert.False(disjoint.Contains(parent));
        }

        [Fact]
        public void ContainsPointTest()
        {
            var circle = new Circle<float>(Vector2D<float>.Zero, 5.0f);

            // Center
            Assert.True(circle.Contains(Vector2D<float>.Zero));

            // Inside
            Assert.True(circle.Contains(new Vector2D<float>(3.0f, 0.0f)));
            Assert.True(circle.Contains(new Vector2D<float>(0.0f, 4.0f)));

            // On edge
            Assert.True(circle.Contains(new Vector2D<float>(5.0f, 0.0f)));
            Assert.True(circle.Contains(new Vector2D<float>(0.0f, 5.0f)));
            Assert.True(circle.Contains(new Vector2D<float>(3.0f, 4.0f)));

            // Outside
            Assert.False(circle.Contains(new Vector2D<float>(5.1f, 0.0f)));
            Assert.False(circle.Contains(new Vector2D<float>(3.0f, 4.1f)));
            Assert.False(circle.Contains(new Vector2D<float>(-6.0f, 0.0f)));
        }
    }
}
