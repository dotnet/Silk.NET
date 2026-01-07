// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class PlaneTests
    {
        // A test for Equals (Plane<float>)
        [Fact]
        public void PlaneEqualsTest1()
        {
            Plane<float> a = new Plane<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Plane<float> b = new Plane<float>(1.0f, 2.0f, 3.0f, 4.0f);

            // case 1: compare between same values
            bool expected = true;
            bool actual = a.Equals(b);
            Assert.Equal(expected, actual);

            // case 2: compare between different values
            b.Normal = new Vector3D<float>(10.0f, b.Normal.Y, b.Normal.Z);
            expected = false;
            actual = a.Equals(b);
            Assert.Equal(expected, actual);
        }

        // A test for Equals (object)
        [Fact]
        public void PlaneEqualsTest()
        {
            Plane<float> a = new Plane<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Plane<float> b = new Plane<float>(1.0f, 2.0f, 3.0f, 4.0f);

            // case 1: compare between same values
            object obj = b;

            bool expected = true;
            bool actual = a.Equals(obj);
            Assert.Equal(expected, actual);

            // case 2: compare between different values
            b.Normal = new Vector3D<float>(10.0f, b.Normal.Y, b.Normal.Z);

            obj = b;
            expected = false;
            actual = a.Equals(obj);
            Assert.Equal(expected, actual);

            // case 3: compare between different types.
            obj = new Quaternion<float>();
            expected = false;
            actual = a.Equals(obj);
            Assert.Equal(expected, actual);

            // case 3: compare against null.
            obj = null!;
            expected = false;
            actual = a.Equals(obj);
            Assert.Equal(expected, actual);
        }

        // A test for operator != (Plane<float>, Plane<float>)
        [Fact]
        public void PlaneInequalityTest()
        {
            Plane<float> a = new Plane<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Plane<float> b = new Plane<float>(1.0f, 2.0f, 3.0f, 4.0f);

            // case 1: compare between same values
            bool expected = false;
            bool actual = a != b;
            Assert.Equal(expected, actual);

            // case 2: compare between different values
            b.Normal = new Vector3D<float>(10.0f, b.Normal.Y, b.Normal.Z);
            expected = true;
            actual = a != b;
            Assert.Equal(expected, actual);
        }

        // A test for operator == (Plane<float>, Plane<float>)
        [Fact]
        public void PlaneEqualityTest()
        {
            Plane<float> a = new Plane<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Plane<float> b = new Plane<float>(1.0f, 2.0f, 3.0f, 4.0f);

            // case 1: compare between same values
            bool expected = true;
            bool actual = a == b;
            Assert.Equal(expected, actual);

            // case 2: compare between different values
            b.Normal = new Vector3D<float>(10.0f, b.Normal.Y, b.Normal.Z);
            expected = false;
            actual = a == b;
            Assert.Equal(expected, actual);
        }

        // A test for GetHashCode ()
        [Fact]
        public void PlaneGetHashCodeTest()
        {
            Plane<float> target = new Plane<float>(1.0f, 2.0f, 3.0f, 4.0f);

            int expected = HashCode.Combine(
                target.Normal.GetHashCode(),
                target.Distance.GetHashCode()
            );
            int actual = target.GetHashCode();
            Assert.Equal(expected, actual);
        }

        // A test for Plane<float> (float, float, float, float)
        [Fact]
        public void PlaneConstructorTest1()
        {
            float a = 1.0f,
                b = 2.0f,
                c = 3.0f,
                d = 4.0f;
            Plane<float> target = new Plane<float>(a, b, c, d);

            Assert.True(
                target.Normal.X == a
                    && target.Normal.Y == b
                    && target.Normal.Z == c
                    && target.Distance == d,
                "Plane<float>.cstor did not return the expected value."
            );
        }

        // A test for Plane<float>.CreateFromVertices
        [Fact]
        public void PlaneCreateFromVerticesTest()
        {
            Vector3D<float> point1 = new Vector3D<float>(0.0f, 1.0f, 1.0f);
            Vector3D<float> point2 = new Vector3D<float>(0.0f, 0.0f, 1.0f);
            Vector3D<float> point3 = new Vector3D<float>(1.0f, 0.0f, 1.0f);

            Plane<float> target = Plane.CreateFromVertices(point1, point2, point3);
            Plane<float> expected = new Plane<float>(new Vector3D<float>(0, 0, 1), -1.0f);
            Assert.Equal(target, expected);
        }

        // A test for Plane<float>.CreateFromVertices
        [Fact]
        public void PlaneCreateFromVerticesTest2()
        {
            Vector3D<float> point1 = new Vector3D<float>(0.0f, 0.0f, 1.0f);
            Vector3D<float> point2 = new Vector3D<float>(1.0f, 0.0f, 0.0f);
            Vector3D<float> point3 = new Vector3D<float>(1.0f, 1.0f, 0.0f);

            Plane<float> target = Plane.CreateFromVertices(point1, point2, point3);
            var invRoot2 = 1.0f / Scalar.Sqrt(2);

            Plane<float> expected = new Plane<float>(
                new Vector3D<float>(invRoot2, 0, invRoot2),
                -invRoot2
            );
            Assert.True(
                MathHelper.Equal(target, expected),
                "Plane<float>.cstor did not return the expected value."
            );
        }

        // A test for Plane<float> (Vector3D<float>f, float)
        [Fact]
        public void PlaneConstructorTest3()
        {
            Vector3D<float> normal = new Vector3D<float>(1, 2, 3);
            float d = 4;

            Plane<float> target = new Plane<float>(normal, d);
            Assert.True(
                target.Normal == normal && target.Distance == d,
                "Plane<float>.cstor did not return the expected value."
            );
        }

        // A test for Plane<float> (Vector4D<float>f)
        [Fact]
        public void PlaneConstructorTest()
        {
            Vector4D<float> value = new Vector4D<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Plane<float> target = new Plane<float>(value);

            Assert.True(
                target.Normal.X == value.X
                    && target.Normal.Y == value.Y
                    && target.Normal.Z == value.Z
                    && target.Distance == value.W,
                "Plane<float>.cstor did not return the expected value."
            );
        }

        [Fact]
        public void PlaneDotTest()
        {
            Plane<float> target = new Plane<float>(2, 3, 4, 5);
            Vector4D<float> value = new Vector4D<float>(5, 4, 3, 2);

            float expected = 10 + 12 + 12 + 10;
            float actual = Plane.Dot(target, value);
            Assert.True(
                MathHelper.Equal(expected, actual),
                "Plane<float>.Dot returns unexpected value."
            );
        }

        [Fact]
        public void PlaneDotCoordinateTest()
        {
            Plane<float> target = new Plane<float>(2, 3, 4, 5);
            Vector3D<float> value = new Vector3D<float>(5, 4, 3);

            float expected = 10 + 12 + 12 + 5;
            float actual = Plane.DotCoordinate(target, value);
            Assert.True(
                MathHelper.Equal(expected, actual),
                "Plane<float>.DotCoordinate returns unexpected value."
            );
        }

        [Fact]
        public void PlaneDotNormalTest()
        {
            Plane<float> target = new Plane<float>(2, 3, 4, 5);
            Vector3D<float> value = new Vector3D<float>(5, 4, 3);

            float expected = 10 + 12 + 12;
            float actual = Plane.DotNormal(target, value);
            Assert.True(
                MathHelper.Equal(expected, actual),
                "Plane<float>.DotCoordinate returns unexpected value."
            );
        }

        [Fact]
        public void PlaneNormalizeTest()
        {
            Plane<float> target = new Plane<float>(1, 2, 3, 4);

            float f = target.Normal.LengthSquared;
            float invF = 1.0f / (float)Scalar.Sqrt(f);
            Plane<float> expected = new Plane<float>(target.Normal * invF, target.Distance * invF);

            Plane<float> actual = Plane.Normalize(target);
            Assert.True(
                MathHelper.Equal(expected, actual),
                "Plane<float>.Normalize returns unexpected value."
            );

            // normalize, normalized normal.
            actual = Plane.Normalize(actual);
            Assert.True(
                MathHelper.Equal(expected, actual),
                "Plane<float>.Normalize returns unexpected value."
            );
        }

        [Fact]
        // Transform by matrix
        public void PlaneTransformTest1()
        {
            Plane<float> target = new Plane<float>(1, 2, 3, 4);
            target = Plane.Normalize(target);

            Matrix4X4<float> m =
                Matrix4X4.CreateRotationX(MathHelper.ToRadians(30.0f))
                * Matrix4X4.CreateRotationY(MathHelper.ToRadians(30.0f))
                * Matrix4X4.CreateRotationZ(MathHelper.ToRadians(30.0f));
            m.M41 = 10.0f;
            m.M42 = 20.0f;
            m.M43 = 30.0f;

            Plane<float> expected = new Plane<float>();
            Matrix4X4<float> inv;
            Matrix4X4.Invert(m, out inv);
            Matrix4X4<float> itm = Matrix4X4.Transpose(inv);
            float x = target.Normal.X,
                y = target.Normal.Y,
                z = target.Normal.Z,
                w = target.Distance;
            expected.Normal = new Vector3D<float>(
                x * itm.M11 + y * itm.M21 + z * itm.M31 + w * itm.M41,
                x * itm.M12 + y * itm.M22 + z * itm.M32 + w * itm.M42,
                x * itm.M13 + y * itm.M23 + z * itm.M33 + w * itm.M43
            );
            expected.Distance = x * itm.M14 + y * itm.M24 + z * itm.M34 + w * itm.M44;

            Plane<float> actual;
            actual = Plane.Transform(target, m);
            Assert.True(
                MathHelper.Equal(expected, actual),
                "Plane<float>.Transform did not return the expected value."
            );
        }

        [Fact]
        // Transform by quaternion
        public void PlaneTransformTest2()
        {
            Plane<float> target = new Plane<float>(1, 2, 3, 4);
            target = Plane.Normalize(target);

            Matrix4X4<float> m =
                Matrix4X4.CreateRotationX(MathHelper.ToRadians(30.0f))
                * Matrix4X4.CreateRotationY(MathHelper.ToRadians(30.0f))
                * Matrix4X4.CreateRotationZ(MathHelper.ToRadians(30.0f));
            Quaternion<float> q = Quaternion<float>.CreateFromRotationMatrix(m);

            Plane<float> expected = new Plane<float>();
            float x = target.Normal.X,
                y = target.Normal.Y,
                z = target.Normal.Z,
                w = target.Distance;
            expected.Normal = new Vector3D<float>(
                x * m.M11 + y * m.M21 + z * m.M31 + w * m.M41,
                x * m.M12 + y * m.M22 + z * m.M32 + w * m.M42,
                x * m.M13 + y * m.M23 + z * m.M33 + w * m.M43
            );
            expected.Distance = x * m.M14 + y * m.M24 + z * m.M34 + w * m.M44;

            Plane<float> actual;
            actual = Plane.Transform(target, q);
            Assert.True(
                MathHelper.Equal(expected, actual),
                "Plane<float>.Transform did not return the expected value."
            );
        }

        // A test for Plane<float> comparison involving NaN values
        [Fact]
        public void PlaneEqualsNanTest()
        {
            Plane<float> a = new Plane<float>(float.NaN, 0, 0, 0);
            Plane<float> b = new Plane<float>(0, float.NaN, 0, 0);
            Plane<float> c = new Plane<float>(0, 0, float.NaN, 0);
            Plane<float> d = new Plane<float>(0, 0, 0, float.NaN);

            Assert.False(a == new Plane<float>(0, 0, 0, 0));
            Assert.False(b == new Plane<float>(0, 0, 0, 0));
            Assert.False(c == new Plane<float>(0, 0, 0, 0));
            Assert.False(d == new Plane<float>(0, 0, 0, 0));

            Assert.True(a != new Plane<float>(0, 0, 0, 0));
            Assert.True(b != new Plane<float>(0, 0, 0, 0));
            Assert.True(c != new Plane<float>(0, 0, 0, 0));
            Assert.True(d != new Plane<float>(0, 0, 0, 0));

            Assert.False(a.Equals(new Plane<float>(0, 0, 0, 0)));
            Assert.False(b.Equals(new Plane<float>(0, 0, 0, 0)));
            Assert.False(c.Equals(new Plane<float>(0, 0, 0, 0)));
            Assert.False(d.Equals(new Plane<float>(0, 0, 0, 0)));

            // Counterintuitive result - IEEE rules for NaN comparison are weird!
            Assert.False(a.Equals(a));
            Assert.False(b.Equals(b));
            Assert.False(c.Equals(c));
            Assert.False(d.Equals(d));
        }

        // A test to make sure these types are blittable directly into GPU buffer memory layouts
        [Fact]
        public unsafe void PlaneSizeofTest()
        {
            Assert.Equal(16, sizeof(Plane<float>));
            Assert.Equal(32, sizeof(Plane_2x));
            Assert.Equal(20, sizeof(PlanePlusFloat));
            Assert.Equal(40, sizeof(PlanePlusFloat_2x));
        }

        [Fact]
        public void PlaneToStringTest()
        {
            Plane<float> target = new Plane<float>(1, 2, 3, 4);
            string expected = string.Format(
                CultureInfo.CurrentCulture,
                "{{Normal:{0:G} D:{1}}}",
                target.Normal,
                target.Distance
            );

            Assert.Equal(expected, target.ToString());
        }

        [StructLayout(LayoutKind.Sequential)]
        struct Plane_2x
        {
            private Plane<float> _a;
            private Plane<float> _b;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct PlanePlusFloat
        {
            private Plane<float> _v;
            private float _f;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct PlanePlusFloat_2x
        {
            private PlanePlusFloat _a;
            private PlanePlusFloat _b;
        }

        // A test to make sure the fields are laid out how we expect
        [Fact]
        public unsafe void PlaneFieldOffsetTest()
        {
            Plane<float> plane = new Plane<float>();

            float* basePtr = &plane.Normal.X; // Take address of first element
            Plane<float>* planePtr = &plane; // Take address of whole Plane<float>

            Assert.Equal(new IntPtr(basePtr), new IntPtr(planePtr));

            Assert.Equal(new IntPtr(basePtr + 0), new IntPtr(&plane.Normal));
            Assert.Equal(new IntPtr(basePtr + 3), new IntPtr(&plane.Distance));
        }
    }
}
