// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class Vector3Tests
    {
        [Fact]
        public unsafe void Vector3MarshalSizeTest()
        {
            Assert.Equal(12, sizeof(Vector3D<float>));
        }

        [Fact]
        public void Vector3CopyToTest()
        {
            Vector3D<float> v1 = new Vector3D<float>(2.0f, 3.0f, 3.3f);

            float[] a = new float[4];
            float[] b = new float[3];

            Assert.Throws<NullReferenceException>(() => v1.CopyTo(null, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => v1.CopyTo(a, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => v1.CopyTo(a, a.Length));
            Assert.Throws<ArgumentException>(() => v1.CopyTo(a, a.Length - 2));

            v1.CopyTo(a, 1);
            v1.CopyTo(b);
            Assert.Equal(0.0f, a[0]);
            Assert.Equal(2.0f, a[1]);
            Assert.Equal(3.0f, a[2]);
            Assert.Equal(3.3f, a[3]);
            Assert.Equal(2.0f, b[0]);
            Assert.Equal(3.0f, b[1]);
            Assert.Equal(3.3f, b[2]);
        }

        [Fact]
        public void Vector3GetHashCodeTest()
        {
            Vector3D<float> v1 = new Vector3D<float>(2.0f, 3.0f, 3.3f);
            Vector3D<float> v2 = new Vector3D<float>(2.0f, 3.0f, 3.3f);
            Vector3D<float> v3 = new Vector3D<float>(2.0f, 3.0f, 3.3f);
            Vector3D<float> v5 = new Vector3D<float>(3.0f, 2.0f, 3.3f);
            Assert.Equal(v1.GetHashCode(), v1.GetHashCode());
            Assert.Equal(v1.GetHashCode(), v2.GetHashCode());
            Assert.NotEqual(v1.GetHashCode(), v5.GetHashCode());
            Assert.Equal(v1.GetHashCode(), v3.GetHashCode());
            Vector3D<float> v4 = new Vector3D<float>(0.0f, 0.0f, 0.0f);
            Vector3D<float> v6 = new Vector3D<float>(1.0f, 0.0f, 0.0f);
            Vector3D<float> v7 = new Vector3D<float>(0.0f, 1.0f, 0.0f);
            Vector3D<float> v8 = new Vector3D<float>(1.0f, 1.0f, 1.0f);
            Vector3D<float> v9 = new Vector3D<float>(1.0f, 1.0f, 0.0f);
            Assert.NotEqual(v4.GetHashCode(), v6.GetHashCode());
            Assert.NotEqual(v4.GetHashCode(), v7.GetHashCode());
            Assert.NotEqual(v4.GetHashCode(), v8.GetHashCode());
            Assert.NotEqual(v7.GetHashCode(), v6.GetHashCode());
            Assert.NotEqual(v8.GetHashCode(), v6.GetHashCode());
            Assert.NotEqual(v8.GetHashCode(), v9.GetHashCode());
            Assert.NotEqual(v7.GetHashCode(), v9.GetHashCode());
        }

        [Fact]
        public void Vector3ToStringTest()
        {
            string separator = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
            CultureInfo enUsCultureInfo = new CultureInfo("en-US");

            Vector3D<float> v1 = new Vector3D<float>(2.0f, 3.0f, 3.3f);
            string v1str = v1.ToString();
            string expectedv1 = string.Format(CultureInfo.CurrentCulture
                , "<{1:G}{0} {2:G}{0} {3:G}>"
                , separator, 2, 3, 3.3);
            Assert.Equal(expectedv1, v1str);

            string v1strformatted = v1.ToString("c", CultureInfo.CurrentCulture);
            string expectedv1formatted = string.Format(CultureInfo.CurrentCulture
                , "<{1:c}{0} {2:c}{0} {3:c}>"
                , separator, 2, 3, 3.3);
            Assert.Equal(expectedv1formatted, v1strformatted);

            string v2strformatted = v1.ToString("c", enUsCultureInfo);
            string expectedv2formatted = string.Format(enUsCultureInfo
                , "<{1:c}{0} {2:c}{0} {3:c}>"
                , enUsCultureInfo.NumberFormat.NumberGroupSeparator, 2, 3, 3.3);
            Assert.Equal(expectedv2formatted, v2strformatted);

            string v3strformatted = v1.ToString("c");
            string expectedv3formatted = string.Format(CultureInfo.CurrentCulture
                , "<{1:c}{0} {2:c}{0} {3:c}>"
                , separator, 2, 3, 3.3);
            Assert.Equal(expectedv3formatted, v3strformatted);
        }

        // A test for Cross (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3CrossTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 0.0f, 0.0f);
            Vector3D<float> b = new Vector3D<float>(0.0f, 1.0f, 0.0f);

            Vector3D<float> expected = new Vector3D<float>(0.0f, 0.0f, 1.0f);
            Vector3D<float> actual;

            actual = Vector3D.Cross(a, b);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Cross did not return the expected value.");
        }

        // A test for Cross (Vector3D<float>f, Vector3D<float>f)
        // Cross test of the same vector
        [Fact]
        public void Vector3CrossTest1()
        {
            Vector3D<float> a = new Vector3D<float>(0.0f, 1.0f, 0.0f);
            Vector3D<float> b = new Vector3D<float>(0.0f, 1.0f, 0.0f);

            Vector3D<float> expected = new Vector3D<float>(0.0f, 0.0f, 0.0f);
            Vector3D<float> actual = Vector3D.Cross(a, b);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Cross did not return the expected value.");
        }

        // A test for Distance (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3DistanceTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(4.0f, 5.0f, 6.0f);

            float expected = (float)System.Math.Sqrt(27);
            float actual;

            actual = Vector3D.Distance(a, b);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Distance did not return the expected value.");
        }

        // A test for Distance (Vector3D<float>f, Vector3D<float>f)
        // Distance from the same point
        [Fact]
        public void Vector3DistanceTest1()
        {
            Vector3D<float> a = new Vector3D<float>(1.051f, 2.05f, 3.478f);
            Vector3D<float> b = new Vector3D<float>(new Vector2D<float>(1.051f, 0.0f), 1);
            b.Y = 2.05f;
            b.Z = 3.478f;

            float actual = Vector3D.Distance(a, b);
            Assert.Equal(0.0f, actual);
        }

        // A test for DistanceSquared (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3DistanceSquaredTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(4.0f, 5.0f, 6.0f);

            float expected = 27.0f;
            float actual;

            actual = Vector3D.DistanceSquared(a, b);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.DistanceSquared did not return the expected value.");
        }

        // A test for Dot (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3DotTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(4.0f, 5.0f, 6.0f);

            float expected = 32.0f;
            float actual;

            actual = Vector3D.Dot(a, b);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Dot did not return the expected value.");
        }

        // A test for Dot (Vector3D<float>f, Vector3D<float>f)
        // Dot test for perpendicular vector
        [Fact]
        public void Vector3DotTest1()
        {
            Vector3D<float> a = new Vector3D<float>(1.55f, 1.55f, 1);
            Vector3D<float> b = new Vector3D<float>(2.5f, 3, 1.5f);
            Vector3D<float> c = Vector3D.Cross(a, b);

            float expected = 0.0f;
            float actual1 = Vector3D.Dot(a, c);
            float actual2 = Vector3D.Dot(b, c);
            Assert.True(MathHelper.Equal(expected, actual1), "Vector3D<float>f.Dot did not return the expected value.");
            Assert.True(MathHelper.Equal(expected, actual2), "Vector3D<float>f.Dot did not return the expected value.");
        }

        // A test for Length ()
        [Fact]
        public void Vector3LengthTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);

            float z = 3.0f;

            Vector3D<float> target = new Vector3D<float>(a, z);

            float expected = (float)System.Math.Sqrt(14.0f);
            float actual;

            actual = target.Length;
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Length did not return the expected value.");
        }

        // A test for Length ()
        // Length test where length is zero
        [Fact]
        public void Vector3LengthTest1()
        {
            Vector3D<float> target = new Vector3D<float>();

            float expected = 0.0f;
            float actual = target.Length;
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Length did not return the expected value.");
        }

        // A test for LengthSquared ()
        [Fact]
        public void Vector3LengthSquaredTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);

            float z = 3.0f;

            Vector3D<float> target = new Vector3D<float>(a, z);

            float expected = 14.0f;
            float actual;

            actual = target.LengthSquared;
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.LengthSquared did not return the expected value.");
        }

        // A test for Min (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3MinTest()
        {
            Vector3D<float> a = new Vector3D<float>(-1.0f, 4.0f, -3.0f);
            Vector3D<float> b = new Vector3D<float>(2.0f, 1.0f, -1.0f);

            Vector3D<float> expected = new Vector3D<float>(-1.0f, 1.0f, -3.0f);
            Vector3D<float> actual;
            actual = Vector3D.Min(a, b);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Min did not return the expected value.");
        }

        // A test for Max (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3MaxTest()
        {
            Vector3D<float> a = new Vector3D<float>(-1.0f, 4.0f, -3.0f);
            Vector3D<float> b = new Vector3D<float>(2.0f, 1.0f, -1.0f);

            Vector3D<float> expected = new Vector3D<float>(2.0f, 4.0f, -1.0f);
            Vector3D<float> actual;
            actual = Vector3D.Max(a, b);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>.Max did not return the expected value.");
        }

        [Fact]
        public void Vector3MinMaxCodeCoverageTest()
        {
            Vector3D<float> min = Vector3D<float>.Zero;
            Vector3D<float> max = Vector3D<float>.One;
            Vector3D<float> actual;

            // Min.
            actual = Vector3D.Min(min, max);
            Assert.Equal(actual, min);

            actual = Vector3D.Min(max, min);
            Assert.Equal(actual, min);

            // Max.
            actual = Vector3D.Max(min, max);
            Assert.Equal(actual, max);

            actual = Vector3D.Max(max, min);
            Assert.Equal(actual, max);
        }

        // A test for Lerp (Vector3D<float>f, Vector3D<float>f, float)
        [Fact]
        public void Vector3LerpTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(4.0f, 5.0f, 6.0f);

            float t = 0.5f;

            Vector3D<float> expected = new Vector3D<float>(2.5f, 3.5f, 4.5f);
            Vector3D<float> actual;

            actual = Vector3D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector3D<float>f, Vector3D<float>f, float)
        // Lerp test with factor zero
        [Fact]
        public void Vector3LerpTest1()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(4.0f, 5.0f, 6.0f);

            float t = 0.0f;
            Vector3D<float> expected = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> actual = Vector3D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector3D<float>f, Vector3D<float>f, float)
        // Lerp test with factor one
        [Fact]
        public void Vector3LerpTest2()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(4.0f, 5.0f, 6.0f);

            float t = 1.0f;
            Vector3D<float> expected = new Vector3D<float>(4.0f, 5.0f, 6.0f);
            Vector3D<float> actual = Vector3D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector3D<float>f, Vector3D<float>f, float)
        // Lerp test with factor > 1
        [Fact]
        public void Vector3LerpTest3()
        {
            Vector3D<float> a = new Vector3D<float>(0.0f, 0.0f, 0.0f);
            Vector3D<float> b = new Vector3D<float>(4.0f, 5.0f, 6.0f);

            float t = 2.0f;
            Vector3D<float> expected = new Vector3D<float>(8.0f, 10.0f, 12.0f);
            Vector3D<float> actual = Vector3D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector3D<float>f, Vector3D<float>f, float)
        // Lerp test with factor < 0
        [Fact]
        public void Vector3LerpTest4()
        {
            Vector3D<float> a = new Vector3D<float>(0.0f, 0.0f, 0.0f);
            Vector3D<float> b = new Vector3D<float>(4.0f, 5.0f, 6.0f);

            float t = -2.0f;
            Vector3D<float> expected = new Vector3D<float>(-8.0f, -10.0f, -12.0f);
            Vector3D<float> actual = Vector3D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector3D<float>f, Vector3D<float>f, float)
        // Lerp test with special float value
        [Fact]
        public void Vector3LerpTest5()
        {
            Vector3D<float> a = new Vector3D<float>(45.67f, 90.0f, 0f);
            Vector3D<float> b = new Vector3D<float>(float.PositiveInfinity, float.NegativeInfinity, 0);

            float t = 0.408f;
            Vector3D<float> actual = Vector3D.Lerp(a, b, t);
            Assert.True(float.IsPositiveInfinity(actual.X), "Vector3D<float>f.Lerp did not return the expected value.");
            Assert.True(float.IsNegativeInfinity(actual.Y), "Vector3D<float>f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector3D<float>f, Vector3D<float>f, float)
        // Lerp test from the same point
        [Fact]
        public void Vector3LerpTest6()
        {
            Vector3D<float> a = new Vector3D<float>(1.68f, 2.34f, 5.43f);
            Vector3D<float> b = a;

            float t = 0.18f;
            Vector3D<float> expected = new Vector3D<float>(1.68f, 2.34f, 5.43f);
            Vector3D<float> actual = Vector3D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector3D<float>f, Vector3D<float>f, float)
        // Lerp test with values known to be innacurate with the old lerp impl
        [Fact]
        public void Vector3LerpTest7()
        {
            Vector3D<float> a = new Vector3D<float>(0.44728136f);
            Vector3D<float> b = new Vector3D<float>(0.46345946f);

            float t = 0.26402435f;

            Vector3D<float> expected = new Vector3D<float>(0.45155275f);
            Vector3D<float> actual = Vector3D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector3D<float>f, Vector3D<float>f, float)
        // Lerp test with values known to be innacurate with the old lerp impl
        // (Old code incorrectly gets 0.33333588)
        [Fact]
        public void Vector3LerpTest8()
        {
            Vector3D<float> a = new Vector3D<float>(-100);
            Vector3D<float> b = new Vector3D<float>(0.33333334f);

            float t = 1f;

            Vector3D<float> expected = new Vector3D<float>(0.33333334f);
            Vector3D<float> actual = Vector3D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Lerp did not return the expected value.");
        }

        // A test for Reflect (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3ReflectTest()
        {
            Vector3D<float> a = Vector3D.Normalize(new Vector3D<float>(1.0f, 1.0f, 1.0f));

            // Reflect on XZ plane.
            Vector3D<float> n = new Vector3D<float>(0.0f, 1.0f, 0.0f);
            Vector3D<float> expected = new Vector3D<float>(a.X, -a.Y, a.Z);
            Vector3D<float> actual = Vector3D.Reflect(a, n);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Reflect did not return the expected value.");

            // Reflect on XY plane.
            n = new Vector3D<float>(0.0f, 0.0f, 1.0f);
            expected = new Vector3D<float>(a.X, a.Y, -a.Z);
            actual = Vector3D.Reflect(a, n);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Reflect did not return the expected value.");

            // Reflect on YZ plane.
            n = new Vector3D<float>(1.0f, 0.0f, 0.0f);
            expected = new Vector3D<float>(-a.X, a.Y, a.Z);
            actual = Vector3D.Reflect(a, n);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Reflect did not return the expected value.");
        }

        // A test for Reflect (Vector3D<float>f, Vector3D<float>f)
        // Reflection when normal and source are the same
        [Fact]
        public void Vector3ReflectTest1()
        {
            Vector3D<float> n = new Vector3D<float>(0.45f, 1.28f, 0.86f);
            n = Vector3D.Normalize(n);
            Vector3D<float> a = n;

            Vector3D<float> expected = -n;
            Vector3D<float> actual = Vector3D.Reflect(a, n);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Reflect did not return the expected value.");
        }

        // A test for Reflect (Vector3D<float>f, Vector3D<float>f)
        // Reflection when normal and source are negation
        [Fact]
        public void Vector3ReflectTest2()
        {
            Vector3D<float> n = new Vector3D<float>(0.45f, 1.28f, 0.86f);
            n = Vector3D.Normalize(n);
            Vector3D<float> a = -n;

            Vector3D<float> expected = n;
            Vector3D<float> actual = Vector3D.Reflect(a, n);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Reflect did not return the expected value.");
        }

        // A test for Reflect (Vector3D<float>f, Vector3D<float>f)
        // Reflection when normal and source are perpendicular (a dot n = 0)
        [Fact]
        public void Vector3ReflectTest3()
        {
            Vector3D<float> n = new Vector3D<float>(0.45f, 1.28f, 0.86f);
            Vector3D<float> temp = new Vector3D<float>(1.28f, 0.45f, 0.01f);
            // find a perpendicular vector of n
            Vector3D<float> a = Vector3D.Cross(temp, n);

            Vector3D<float> expected = a;
            Vector3D<float> actual = Vector3D.Reflect(a, n);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Reflect did not return the expected value.");
        }

        // A test for Transform(Vector3D<float>f, Matrix4X4)
        [Fact]
        public void Vector3TransformTest()
        {
            Vector3D<float> v = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Matrix4X4<float> m =
                Matrix4X4.CreateRotationX<float>(MathHelper.ToRadians(30.0f)) *
                Matrix4X4.CreateRotationY<float>(MathHelper.ToRadians(30.0f)) *
                Matrix4X4.CreateRotationZ<float>(MathHelper.ToRadians(30.0f));
            m.M41 = 10.0f;
            m.M42 = 20.0f;
            m.M43 = 30.0f;

            Vector3D<float> expected = new Vector3D<float>(12.191987f, 21.533493f, 32.616024f);
            Vector3D<float> actual;

            actual = Vector3D.Transform(v, m);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Transform did not return the expected value.");
        }

        // A test for Clamp (Vector3D<float>f, Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3ClampTest()
        {
            Vector3D<float> a = new Vector3D<float>(0.5f, 0.3f, 0.33f);
            Vector3D<float> min = new Vector3D<float>(0.0f, 0.1f, 0.13f);
            Vector3D<float> max = new Vector3D<float>(1.0f, 1.1f, 1.13f);

            // Normal case.
            // Case N1: specified value is in the range.
            Vector3D<float> expected = new Vector3D<float>(0.5f, 0.3f, 0.33f);
            Vector3D<float> actual = Vector3D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Clamp did not return the expected value.");

            // Normal case.
            // Case N2: specified value is bigger than max value.
            a = new Vector3D<float>(2.0f, 3.0f, 4.0f);
            expected = max;
            actual = Vector3D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Clamp did not return the expected value.");

            // Case N3: specified value is smaller than max value.
            a = new Vector3D<float>(-2.0f, -3.0f, -4.0f);
            expected = min;
            actual = Vector3D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Clamp did not return the expected value.");

            // Case N4: combination case.
            a = new Vector3D<float>(-2.0f, 0.5f, 4.0f);
            expected = new Vector3D<float>(min.X, a.Y, max.Z);
            actual = Vector3D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Clamp did not return the expected value.");

            // User specified min value is bigger than max value.
            max = new Vector3D<float>(0.0f, 0.1f, 0.13f);
            min = new Vector3D<float>(1.0f, 1.1f, 1.13f);

            // Case W1: specified value is in the range.
            a = new Vector3D<float>(0.5f, 0.3f, 0.33f);
            expected = max;
            actual = Vector3D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Clamp did not return the expected value.");

            // Normal case.
            // Case W2: specified value is bigger than max and min value.
            a = new Vector3D<float>(2.0f, 3.0f, 4.0f);
            expected = max;
            actual = Vector3D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Clamp did not return the expected value.");

            // Case W3: specified value is smaller than min and max value.
            a = new Vector3D<float>(-2.0f, -3.0f, -4.0f);
            expected = max;
            actual = Vector3D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Clamp did not return the expected value.");
        }

        // A test for TransformNormal (Vector3D<float>f, Matrix4X4)
        [Fact]
        public void Vector3TransformNormalTest()
        {
            Vector3D<float> v = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Matrix4X4<float> m =
                Matrix4X4.CreateRotationX<float>(MathHelper.ToRadians(30.0f)) *
                Matrix4X4.CreateRotationY<float>(MathHelper.ToRadians(30.0f)) *
                Matrix4X4.CreateRotationZ<float>(MathHelper.ToRadians(30.0f));
            m.M41 = 10.0f;
            m.M42 = 20.0f;
            m.M43 = 30.0f;

            Vector3D<float> expected = new Vector3D<float>(2.19198728f, 1.53349364f, 2.61602545f);
            Vector3D<float> actual;

            actual = Vector3D.TransformNormal(v, m);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.TransformNormal did not return the expected value.");
        }

        // A test for Transform (Vector3D<float>f, Quaternion)
        [Fact]
        public void Vector3TransformByQuaternionTest()
        {
            Vector3D<float> v = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            Matrix4X4<float> m =
                Matrix4X4.CreateRotationX<float>(MathHelper.ToRadians(30.0f)) *
                Matrix4X4.CreateRotationY<float>(MathHelper.ToRadians(30.0f)) *
                Matrix4X4.CreateRotationZ<float>(MathHelper.ToRadians(30.0f));
            Quaternion<float> q = Quaternion<float>.CreateFromRotationMatrix(m);

            Vector3D<float> expected = Vector3D.Transform(v, m);
            Vector3D<float> actual = Vector3D.Transform(v, q);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Transform did not return the expected value.");
        }

        // A test for Transform (Vector3D<float>f, Quaternion)
        // Transform Vector3D<float> with zero quaternion
        [Fact]
        public void Vector3TransformByQuaternionTest1()
        {
            Vector3D<float> v = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Quaternion<float> q = new Quaternion<float>();
            Vector3D<float> expected = v;

            Vector3D<float> actual = Vector3D.Transform(v, q);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Transform did not return the expected value.");
        }

        // A test for Transform (Vector3D<float>f, Quaternion)
        // Transform Vector3D<float> with identity quaternion
        [Fact]
        public void Vector3TransformByQuaternionTest2()
        {
            Vector3D<float> v = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Quaternion<float> q = Quaternion<float>.Identity;
            Vector3D<float> expected = v;

            Vector3D<float> actual = Vector3D.Transform(v, q);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Transform did not return the expected value.");
        }

        // A test for Normalize (Vector3D<float>f)
        [Fact]
        public void Vector3NormalizeTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            Vector3D<float> expected = new Vector3D<float>(
                0.26726124191242438468455348087975f,
                0.53452248382484876936910696175951f,
                0.80178372573727315405366044263926f);
            Vector3D<float> actual;

            actual = Vector3D.Normalize(a);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Normalize did not return the expected value.");
        }

        // A test for Normalize (Vector3D<float>f)
        // Normalize vector of length one
        [Fact]
        public void Vector3NormalizeTest1()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 0.0f, 0.0f);

            Vector3D<float> expected = new Vector3D<float>(1.0f, 0.0f, 0.0f);
            Vector3D<float> actual = Vector3D.Normalize(a);
            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.Normalize did not return the expected value.");
        }

        // A test for Normalize (Vector3D<float>f)
        // Normalize vector of length zero
        [Fact]
        public void Vector3NormalizeTest2()
        {
            Vector3D<float> a = new Vector3D<float>(0.0f, 0.0f, 0.0f);

            Vector3D<float> expected = new Vector3D<float>(0.0f, 0.0f, 0.0f);
            Vector3D<float> actual = Vector3D.Normalize(a);
            Assert.True(float.IsNaN(actual.X) && float.IsNaN(actual.Y) && float.IsNaN(actual.Z), "Vector3D<float>f.Normalize did not return the expected value.");
        }

        // A test for operator - (Vector3D<float>f)
        [Fact]
        public void Vector3UnaryNegationTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            Vector3D<float> expected = new Vector3D<float>(-1.0f, -2.0f, -3.0f);
            Vector3D<float> actual;

            actual = -a;

            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.operator - did not return the expected value.");
        }

        [Fact]
        public void Vector3UnaryNegationTest1()
        {
            Vector3D<float> a = -new Vector3D<float>(float.NaN, float.PositiveInfinity, float.NegativeInfinity);
            Vector3D<float> b = -new Vector3D<float>(0.0f, 0.0f, 0.0f);
            Assert.Equal(float.NaN, a.X);
            Assert.Equal(float.NegativeInfinity, a.Y);
            Assert.Equal(float.PositiveInfinity, a.Z);
            Assert.Equal(0.0f, b.X);
            Assert.Equal(0.0f, b.Y);
            Assert.Equal(0.0f, b.Z);
        }

        // A test for operator - (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3SubtractionTest()
        {
            Vector3D<float> a = new Vector3D<float>(4.0f, 2.0f, 3.0f);

            Vector3D<float> b = new Vector3D<float>(1.0f, 5.0f, 7.0f);

            Vector3D<float> expected = new Vector3D<float>(3.0f, -3.0f, -4.0f);
            Vector3D<float> actual;

            actual = a - b;

            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.operator - did not return the expected value.");
        }

        // A test for operator * (Vector3D<float>f, float)
        [Fact]
        public void Vector3MultiplyOperatorTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            float factor = 2.0f;

            Vector3D<float> expected = new Vector3D<float>(2.0f, 4.0f, 6.0f);
            Vector3D<float> actual;

            actual = a * factor;

            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.operator * did not return the expected value.");
        }

        // A test for operator * (float, Vector3D<float>f)
        [Fact]
        public void Vector3MultiplyOperatorTest2()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            const float factor = 2.0f;

            Vector3D<float> expected = new Vector3D<float>(2.0f, 4.0f, 6.0f);
            Vector3D<float> actual;

            actual = factor * a;

            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.operator * did not return the expected value.");
        }

        // A test for operator * (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3MultiplyOperatorTest3()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            Vector3D<float> b = new Vector3D<float>(4.0f, 5.0f, 6.0f);

            Vector3D<float> expected = new Vector3D<float>(4.0f, 10.0f, 18.0f);
            Vector3D<float> actual;

            actual = a * b;

            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.operator * did not return the expected value.");
        }

        // A test for operator / (Vector3D<float>f, float)
        [Fact]
        public void Vector3DivisionTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            float div = 2.0f;

            Vector3D<float> expected = new Vector3D<float>(0.5f, 1.0f, 1.5f);
            Vector3D<float> actual;

            actual = a / div;

            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.operator / did not return the expected value.");
        }

        // A test for operator / (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3DivisionTest1()
        {
            Vector3D<float> a = new Vector3D<float>(4.0f, 2.0f, 3.0f);

            Vector3D<float> b = new Vector3D<float>(1.0f, 5.0f, 6.0f);

            Vector3D<float> expected = new Vector3D<float>(4.0f, 0.4f, 0.5f);
            Vector3D<float> actual;

            actual = a / b;

            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.operator / did not return the expected value.");
        }

        // A test for operator / (Vector3D<float>f, Vector3D<float>f)
        // Divide by zero
        [Fact]
        public void Vector3DivisionTest2()
        {
            Vector3D<float> a = new Vector3D<float>(-2.0f, 3.0f, float.MaxValue);

            float div = 0.0f;

            Vector3D<float> actual = a / div;

            Assert.True(float.IsNegativeInfinity(actual.X), "Vector3D<float>f.operator / did not return the expected value.");
            Assert.True(float.IsPositiveInfinity(actual.Y), "Vector3D<float>f.operator / did not return the expected value.");
            Assert.True(float.IsPositiveInfinity(actual.Z), "Vector3D<float>f.operator / did not return the expected value.");
        }

        // A test for operator / (Vector3D<float>f, Vector3D<float>f)
        // Divide by zero
        [Fact]
        public void Vector3DivisionTest3()
        {
            Vector3D<float> a = new Vector3D<float>(0.047f, -3.0f, float.NegativeInfinity);
            Vector3D<float> b = new Vector3D<float>();

            Vector3D<float> actual = a / b;

            Assert.True(float.IsPositiveInfinity(actual.X), "Vector3D<float>f.operator / did not return the expected value.");
            Assert.True(float.IsNegativeInfinity(actual.Y), "Vector3D<float>f.operator / did not return the expected value.");
            Assert.True(float.IsNegativeInfinity(actual.Z), "Vector3D<float>f.operator / did not return the expected value.");
        }

        // A test for operator + (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3AdditionTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(4.0f, 5.0f, 6.0f);

            Vector3D<float> expected = new Vector3D<float>(5.0f, 7.0f, 9.0f);
            Vector3D<float> actual;

            actual = a + b;

            Assert.True(MathHelper.Equal(expected, actual), "Vector3D<float>f.operator + did not return the expected value.");
        }

        // A test for Vector3D<float>f (float, float, float)
        [Fact]
        public void Vector3ConstructorTest()
        {
            float x = 1.0f;
            float y = 2.0f;
            float z = 3.0f;

            Vector3D<float> target = new Vector3D<float>(x, y, z);
            Assert.True(MathHelper.Equal(target.X, x) && MathHelper.Equal(target.Y, y) && MathHelper.Equal(target.Z, z), "Vector3D<float>f.constructor (x,y,z) did not return the expected value.");
        }

        // A test for Vector3D<float>f (Vector2f, float)
        [Fact]
        public void Vector3ConstructorTest1()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);

            float z = 3.0f;

            Vector3D<float> target = new Vector3D<float>(a, z);
            Assert.True(MathHelper.Equal(target.X, a.X) && MathHelper.Equal(target.Y, a.Y) && MathHelper.Equal(target.Z, z), "Vector3D<float>f.constructor (Vector2f,z) did not return the expected value.");
        }

        // A test for Vector3D<float>f ()
        // Constructor with no parameter
        [Fact]
        public void Vector3ConstructorTest3()
        {
            Vector3D<float> a = new Vector3D<float>();

            Assert.Equal(0.0f, a.X);
            Assert.Equal(0.0f, a.Y);
            Assert.Equal(0.0f, a.Z);
        }

        // A test for Vector2f (float, float)
        // Constructor with special floating values
        [Fact]
        public void Vector3ConstructorTest4()
        {
            Vector3D<float> target = new Vector3D<float>(float.NaN, float.MaxValue, float.PositiveInfinity);

            Assert.True(float.IsNaN(target.X), "Vector3D<float>f.constructor (Vector3D<float>f) did not return the expected value.");
            Assert.True(float.Equals(float.MaxValue, target.Y), "Vector3D<float>f.constructor (Vector3D<float>f) did not return the expected value.");
            Assert.True(float.IsPositiveInfinity(target.Z), "Vector3D<float>f.constructor (Vector3D<float>f) did not return the expected value.");
        }

        // A test for Add (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3AddTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(5.0f, 6.0f, 7.0f);

            Vector3D<float> expected = new Vector3D<float>(6.0f, 8.0f, 10.0f);
            Vector3D<float> actual;

            actual = Vector3D.Add(a, b);
            Assert.Equal(expected, actual);
        }

        // A test for Divide (Vector3D<float>f, float)
        [Fact]
        public void Vector3DivideTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            float div = 2.0f;
            Vector3D<float> expected = new Vector3D<float>(0.5f, 1.0f, 1.5f);
            Vector3D<float> actual;
            actual = Vector3D.Divide(a, div);
            Assert.Equal(expected, actual);
        }

        // A test for Divide (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3DivideTest1()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 6.0f, 7.0f);
            Vector3D<float> b = new Vector3D<float>(5.0f, 2.0f, 3.0f);

            Vector3D<float> expected = new Vector3D<float>(1.0f / 5.0f, 6.0f / 2.0f, 7.0f / 3.0f);
            Vector3D<float> actual;

            actual = Vector3D.Divide(a, b);
            Assert.Equal(expected, actual);
        }

        // A test for Equals (object)
        [Fact]
        public void Vector3EqualsTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            // case 1: compare between same values
            object obj = b;

            bool expected = true;
            bool actual = a.Equals(obj);
            Assert.Equal(expected, actual);

            // case 2: compare between different values
            b.X = 10.0f;
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

        // A test for Multiply (Vector3D<float>f, float)
        [Fact]
        public void Vector3MultiplyTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            const float factor = 2.0f;
            Vector3D<float> expected = new Vector3D<float>(2.0f, 4.0f, 6.0f);
            Vector3D<float> actual = Vector3D.Multiply(a, factor);
            Assert.Equal(expected, actual);
        }

        // A test for Multiply (float, Vector3D<float>f)
        [Fact]
        public static void Vector3MultiplyTest2()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            const float factor = 2.0f;
            Vector3D<float> expected = new Vector3D<float>(2.0f, 4.0f, 6.0f);
            Vector3D<float> actual = Vector3D.Multiply(factor, a);
            Assert.Equal(expected, actual);
        }

        // A test for Multiply (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3MultiplyTest3()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(5.0f, 6.0f, 7.0f);

            Vector3D<float> expected = new Vector3D<float>(5.0f, 12.0f, 21.0f);
            Vector3D<float> actual;

            actual = Vector3D.Multiply(a, b);
            Assert.Equal(expected, actual);
        }

        // A test for Negate (Vector3D<float>f)
        [Fact]
        public void Vector3NegateTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            Vector3D<float> expected = new Vector3D<float>(-1.0f, -2.0f, -3.0f);
            Vector3D<float> actual;

            actual = Vector3D.Negate(a);
            Assert.Equal(expected, actual);
        }

        // A test for operator != (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3InequalityTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            // case 1: compare between same values
            bool expected = false;
            bool actual = a != b;
            Assert.Equal(expected, actual);

            // case 2: compare between different values
            b.X = 10.0f;
            expected = true;
            actual = a != b;
            Assert.Equal(expected, actual);
        }

        // A test for operator == (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3EqualityTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            // case 1: compare between same values
            bool expected = true;
            bool actual = a == b;
            Assert.Equal(expected, actual);

            // case 2: compare between different values
            b.X = 10.0f;
            expected = false;
            actual = a == b;
            Assert.Equal(expected, actual);
        }

        // A test for Subtract (Vector3D<float>f, Vector3D<float>f)
        [Fact]
        public void Vector3SubtractTest()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 6.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(5.0f, 2.0f, 3.0f);

            Vector3D<float> expected = new Vector3D<float>(-4.0f, 4.0f, 0.0f);
            Vector3D<float> actual;

            actual = Vector3D.Subtract(a, b);
            Assert.Equal(expected, actual);
        }

        // A test for One
        [Fact]
        public void Vector3OneTest()
        {
            Vector3D<float> val = new Vector3D<float>(1.0f, 1.0f, 1.0f);
            Assert.Equal(val, Vector3D<float>.One);
        }

        // A test for UnitX
        [Fact]
        public void Vector3UnitXTest()
        {
            Vector3D<float> val = new Vector3D<float>(1.0f, 0.0f, 0.0f);
            Assert.Equal(val, Vector3D<float>.UnitX);
        }

        // A test for UnitY
        [Fact]
        public void Vector3UnitYTest()
        {
            Vector3D<float> val = new Vector3D<float>(0.0f, 1.0f, 0.0f);
            Assert.Equal(val, Vector3D<float>.UnitY);
        }

        // A test for UnitZ
        [Fact]
        public void Vector3UnitZTest()
        {
            Vector3D<float> val = new Vector3D<float>(0.0f, 0.0f, 1.0f);
            Assert.Equal(val, Vector3D<float>.UnitZ);
        }

        // A test for Zero
        [Fact]
        public void Vector3ZeroTest()
        {
            Vector3D<float> val = new Vector3D<float>(0.0f, 0.0f, 0.0f);
            Assert.Equal(val, Vector3D<float>.Zero);
        }

        // A test for Equals (Vector3D<float>f)
        [Fact]
        public void Vector3EqualsTest1()
        {
            Vector3D<float> a = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            Vector3D<float> b = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            // case 1: compare between same values
            bool expected = true;
            bool actual = a.Equals(b);
            Assert.Equal(expected, actual);

            // case 2: compare between different values
            b.X = 10.0f;
            expected = false;
            actual = a.Equals(b);
            Assert.Equal(expected, actual);
        }

        // A test for Vector3D<float>f (float)
        [Fact]
        public void Vector3ConstructorTest5()
        {
            float value = 1.0f;
            Vector3D<float> target = new Vector3D<float>(value);

            Vector3D<float> expected = new Vector3D<float>(value, value, value);
            Assert.Equal(expected, target);

            value = 2.0f;
            target = new Vector3D<float>(value);
            expected = new Vector3D<float>(value, value, value);
            Assert.Equal(expected, target);
        }

        // A test for Vector3D<float>f comparison involving NaN values
        [Fact]
        public void Vector3EqualsNanTest()
        {
            Vector3D<float> a = new Vector3D<float>(float.NaN, 0, 0);
            Vector3D<float> b = new Vector3D<float>(0, float.NaN, 0);
            Vector3D<float> c = new Vector3D<float>(0, 0, float.NaN);

            Assert.False(a == Vector3D<float>.Zero);
            Assert.False(b == Vector3D<float>.Zero);
            Assert.False(c == Vector3D<float>.Zero);

            Assert.True(a != Vector3D<float>.Zero);
            Assert.True(b != Vector3D<float>.Zero);
            Assert.True(c != Vector3D<float>.Zero);

            Assert.False(a.Equals(Vector3D<float>.Zero));
            Assert.False(b.Equals(Vector3D<float>.Zero));
            Assert.False(c.Equals(Vector3D<float>.Zero));

            // Counterintuitive result - IEEE rules for NaN comparison are weird!
            Assert.False(a.Equals(a));
            Assert.False(b.Equals(b));
            Assert.False(c.Equals(c));
        }

        [Fact]
        public void Vector3AbsTest()
        {
            Vector3D<float> v1 = new Vector3D<float>(-2.5f, 2.0f, 0.5f);
            Vector3D<float> v3 = Vector3D.Abs(new Vector3D<float>(0.0f, float.NegativeInfinity, float.NaN));
            Vector3D<float> v = Vector3D.Abs(v1);
            Assert.Equal(2.5f, v.X);
            Assert.Equal(2.0f, v.Y);
            Assert.Equal(0.5f, v.Z);
            Assert.Equal(0.0f, v3.X);
            Assert.Equal(float.PositiveInfinity, v3.Y);
            Assert.Equal(float.NaN, v3.Z);
        }

        [Fact]
        public void Vector3SqrtTest()
        {
            Vector3D<float> a = new Vector3D<float>(-2.5f, 2.0f, 0.5f);
            Vector3D<float> b = new Vector3D<float>(5.5f, 4.5f, 16.5f);
            Assert.Equal(2, (int)Vector3D.SquareRoot(b).X);
            Assert.Equal(2, (int)Vector3D.SquareRoot(b).Y);
            Assert.Equal(4, (int)Vector3D.SquareRoot(b).Z);
            Assert.Equal(float.NaN, Vector3D.SquareRoot(a).X);
        }

        // A test to make sure these types are blittable directly into GPU buffer memory layouts
        [Fact]
        public unsafe void Vector3SizeofTest()
        {
            Assert.Equal(12, sizeof(Vector3D<float>));
            Assert.Equal(24, sizeof(Vector3_2x));
            Assert.Equal(16, sizeof(Vector3PlusFloat));
            Assert.Equal(32, sizeof(Vector3PlusFloat_2x));
        }

        [StructLayout(LayoutKind.Sequential)]
        struct Vector3_2x
        {
            private Vector3D<float> _a;
            private Vector3D<float> _b;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct Vector3PlusFloat
        {
            private Vector3D<float> _v;
            private float _f;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct Vector3PlusFloat_2x
        {
            private Vector3PlusFloat _a;
            private Vector3PlusFloat _b;
        }

        [Fact]
        public void SetFieldsTest()
        {
            Vector3D<float> v3 = new Vector3D<float>(4f, 5f, 6f);
            v3.X = 1.0f;
            v3.Y = 2.0f;
            v3.Z = 3.0f;
            Assert.Equal(1.0f, v3.X);
            Assert.Equal(2.0f, v3.Y);
            Assert.Equal(3.0f, v3.Z);
            Vector3D<float> v4 = v3;
            v4.Y = 0.5f;
            v4.Z = 2.2f;
            Assert.Equal(1.0f, v4.X);
            Assert.Equal(0.5f, v4.Y);
            Assert.Equal(2.2f, v4.Z);
            Assert.Equal(2.0f, v3.Y);

            Vector3D<float> before = new Vector3D<float>(1f, 2f, 3f);
            Vector3D<float> after = before;
            after.X = 500.0f;
            Assert.NotEqual(before, after);
        }

        [Fact]
        public void EmbeddedVectorSetFields()
        {
            EmbeddedVectorObject evo = new EmbeddedVectorObject();
            evo.FieldVector.X = 5.0f;
            evo.FieldVector.Y = 5.0f;
            evo.FieldVector.Z = 5.0f;
            Assert.Equal(5.0f, evo.FieldVector.X);
            Assert.Equal(5.0f, evo.FieldVector.Y);
            Assert.Equal(5.0f, evo.FieldVector.Z);
        }

        private class EmbeddedVectorObject
        {
            public Vector3D<float> FieldVector;
        }
    }
}
