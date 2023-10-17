// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class Vector2Tests
    {
        [Fact]
        public unsafe void Vector2MarshalSizeTest()
        {
            Assert.Equal(8, sizeof(Vector2D<float>));
        }

        [Fact]
        public void Vector2CopyToTest()
        {
            Vector2D<float> v1 = new Vector2D<float>(2.0f, 3.0f);

            float[] a = new float[3];
            float[] b = new float[2];

            Assert.Throws<NullReferenceException>(() => v1.CopyTo(null, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => v1.CopyTo(a, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => v1.CopyTo(a, a.Length));
            Assert.Throws<ArgumentException>(() => v1.CopyTo(a, 2));

            v1.CopyTo(a, 1);
            v1.CopyTo(b);
            Assert.Equal(0.0, a[0]);
            Assert.Equal(2.0, a[1]);
            Assert.Equal(3.0, a[2]);
            Assert.Equal(2.0, b[0]);
            Assert.Equal(3.0, b[1]);
        }

        [Fact]
        public void Vector2GetHashCodeTest()
        {
            Vector2D<float> v1 = new Vector2D<float>(2.0f, 3.0f);
            Vector2D<float> v2 = new Vector2D<float>(2.0f, 3.0f);
            Vector2D<float> v3 = new Vector2D<float>(3.0f, 2.0f);
            Assert.Equal(v1.GetHashCode(), v1.GetHashCode());
            Assert.Equal(v1.GetHashCode(), v2.GetHashCode());
            Assert.NotEqual(v1.GetHashCode(), v3.GetHashCode());
            Vector2D<float> v4 = new Vector2D<float>(0.0f, 0.0f);
            Vector2D<float> v6 = new Vector2D<float>(1.0f, 0.0f);
            Vector2D<float> v7 = new Vector2D<float>(0.0f, 1.0f);
            Vector2D<float> v8 = new Vector2D<float>(1.0f, 1.0f);
            Assert.NotEqual(v4.GetHashCode(), v6.GetHashCode());
            Assert.NotEqual(v4.GetHashCode(), v7.GetHashCode());
            Assert.NotEqual(v4.GetHashCode(), v8.GetHashCode());
            Assert.NotEqual(v7.GetHashCode(), v6.GetHashCode());
            Assert.NotEqual(v8.GetHashCode(), v6.GetHashCode());
            Assert.NotEqual(v8.GetHashCode(), v7.GetHashCode());
        }

        [Fact]
        public void Vector2ToStringTest()
        {
            string separator = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
            CultureInfo enUsCultureInfo = new CultureInfo("en-US");

            Vector2D<float> v1 = new Vector2D<float>(2.0f, 3.0f);

            string v1str = v1.ToString();
            string expectedv1 = string.Format(CultureInfo.CurrentCulture
                , "<{1:G}{0} {2:G}>"
                , new object[] { separator, 2, 3 });
            Assert.Equal(expectedv1, v1str);

            string v1strformatted = v1.ToString("c", CultureInfo.CurrentCulture);
            string expectedv1formatted = string.Format(CultureInfo.CurrentCulture
                , "<{1:c}{0} {2:c}>"
                , new object[] { separator, 2, 3 });
            Assert.Equal(expectedv1formatted, v1strformatted);

            string v2strformatted = v1.ToString("c", enUsCultureInfo);
            string expectedv2formatted = string.Format(enUsCultureInfo
                , "<{1:c}{0} {2:c}>"
                , new object[] { enUsCultureInfo.NumberFormat.NumberGroupSeparator, 2, 3 });
            Assert.Equal(expectedv2formatted, v2strformatted);

            string v3strformatted = v1.ToString("c");
            string expectedv3formatted = string.Format(CultureInfo.CurrentCulture
                , "<{1:c}{0} {2:c}>"
                , new object[] { separator, 2, 3 });
            Assert.Equal(expectedv3formatted, v3strformatted);
        }

        // A test for Distance (Vector2f, Vector2f)
        [Fact]
        public void Vector2DistanceTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> b = new Vector2D<float>(3.0f, 4.0f);

            float expected = (float)System.Math.Sqrt(8);
            float actual;

            actual = Vector2D.Distance(a, b);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Distance did not return the expected value.");
        }

        // A test for Distance (Vector2f, Vector2f)
        // Distance from the same point
        [Fact]
        public void Vector2DistanceTest2()
        {
            Vector2D<float> a = new Vector2D<float>(1.051f, 2.05f);
            Vector2D<float> b = new Vector2D<float>(1.051f, 2.05f);

            float actual = Vector2D.Distance(a, b);
            Assert.Equal(0.0f, actual);
        }

        // A test for DistanceSquared (Vector2f, Vector2f)
        [Fact]
        public void Vector2DistanceSquaredTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> b = new Vector2D<float>(3.0f, 4.0f);

            float expected = 8.0f;
            float actual;

            actual = Vector2D.DistanceSquared(a, b);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.DistanceSquared did not return the expected value.");
        }

        // A test for Dot (Vector2f, Vector2f)
        [Fact]
        public void Vector2DotTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> b = new Vector2D<float>(3.0f, 4.0f);

            float expected = 11.0f;
            float actual;

            actual = Vector2D.Dot(a, b);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Dot did not return the expected value.");
        }

        // A test for Dot (Vector2f, Vector2f)
        // Dot test for perpendicular vector
        [Fact]
        public void Vector2DotTest1()
        {
            Vector2D<float> a = new Vector2D<float>(1.55f, 1.55f);
            Vector2D<float> b = new Vector2D<float>(-1.55f, 1.55f);

            float expected = 0.0f;
            float actual = Vector2D.Dot(a, b);
            Assert.Equal(expected, actual);
        }

        // A test for Dot (Vector2f, Vector2f)
        // Dot test with specail float values
        [Fact]
        public void Vector2DotTest2()
        {
            Vector2D<float> a = new Vector2D<float>(float.MinValue, float.MinValue);
            Vector2D<float> b = new Vector2D<float>(float.MaxValue, float.MaxValue);

            float actual = Vector2D.Dot(a, b);
            Assert.True(float.IsNegativeInfinity(actual), "Vector2f.Dot did not return the expected value.");
        }

        // A test for Length ()
        [Fact]
        public void Vector2LengthTest()
        {
            Vector2D<float> a = new Vector2D<float>(2.0f, 4.0f);

            Vector2D<float> target = a;

            float expected = (float)System.Math.Sqrt(20);
            float actual;

            actual = target.Length;

            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Length did not return the expected value.");
        }

        // A test for Length ()
        // Length test where length is zero
        [Fact]
        public void Vector2LengthTest1()
        {
            Vector2D<float> target = new Vector2D<float>();
            target.X = 0.0f;
            target.Y = 0.0f;

            float expected = 0.0f;
            float actual;

            actual = target.Length;

            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Length did not return the expected value.");
        }

        // A test for LengthSquared ()
        [Fact]
        public void Vector2LengthSquaredTest()
        {
            Vector2D<float> a = new Vector2D<float>(2.0f, 4.0f);

            Vector2D<float> target = a;

            float expected = 20.0f;
            float actual;

            actual = target.LengthSquared;

            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.LengthSquared did not return the expected value.");
        }

        // A test for LengthSquared ()
        // LengthSquared test where the result is zero
        [Fact]
        public void Vector2LengthSquaredTest1()
        {
            Vector2D<float> a = new Vector2D<float>(0.0f, 0.0f);

            float expected = 0.0f;
            float actual = a.LengthSquared;

            Assert.Equal(expected, actual);
        }

        // A test for Min (Vector2f, Vector2f)
        [Fact]
        public void Vector2MinTest()
        {
            Vector2D<float> a = new Vector2D<float>(-1.0f, 4.0f);
            Vector2D<float> b = new Vector2D<float>(2.0f, 1.0f);

            Vector2D<float> expected = new Vector2D<float>(-1.0f, 1.0f);
            Vector2D<float> actual;
            actual = Vector2D.Min(a, b);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Min did not return the expected value.");
        }

        [Fact]
        public void Vector2MinMaxCodeCoverageTest()
        {
            Vector2D<float> min = new Vector2D<float>(0, 0);
            Vector2D<float> max = new Vector2D<float>(1, 1);
            Vector2D<float> actual;

            // Min.
            actual = Vector2D.Min(min, max);
            Assert.Equal(actual, min);

            actual = Vector2D.Min(max, min);
            Assert.Equal(actual, min);

            // Max.
            actual = Vector2D.Max(min, max);
            Assert.Equal(actual, max);

            actual = Vector2D.Max(max, min);
            Assert.Equal(actual, max);
        }

        // A test for Max (Vector2f, Vector2f)
        [Fact]
        public void Vector2MaxTest()
        {
            Vector2D<float> a = new Vector2D<float>(-1.0f, 4.0f);
            Vector2D<float> b = new Vector2D<float>(2.0f, 1.0f);

            Vector2D<float> expected = new Vector2D<float>(2.0f, 4.0f);
            Vector2D<float> actual;
            actual = Vector2D.Max(a, b);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Max did not return the expected value.");
        }

        // A test for Clamp (Vector2f, Vector2f, Vector2f)
        [Fact]
        public void Vector2ClampTest()
        {
            Vector2D<float> a = new Vector2D<float>(0.5f, 0.3f);
            Vector2D<float> min = new Vector2D<float>(0.0f, 0.1f);
            Vector2D<float> max = new Vector2D<float>(1.0f, 1.1f);

            // Normal case.
            // Case N1: specified value is in the range.
            Vector2D<float> expected = new Vector2D<float>(0.5f, 0.3f);
            Vector2D<float> actual = Vector2D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Clamp did not return the expected value.");
            // Normal case.
            // Case N2: specified value is bigger than max value.
            a = new Vector2D<float>(2.0f, 3.0f);
            expected = max;
            actual = Vector2D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Clamp did not return the expected value.");
            // Case N3: specified value is smaller than max value.
            a = new Vector2D<float>(-1.0f, -2.0f);
            expected = min;
            actual = Vector2D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Clamp did not return the expected value.");
            // Case N4: combination case.
            a = new Vector2D<float>(-2.0f, 4.0f);
            expected = new Vector2D<float>(min.X, max.Y);
            actual = Vector2D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Clamp did not return the expected value.");
            // User specified min value is bigger than max value.
            max = new Vector2D<float>(0.0f, 0.1f);
            min = new Vector2D<float>(1.0f, 1.1f);

            // Case W1: specified value is in the range.
            a = new Vector2D<float>(0.5f, 0.3f);
            expected = max;
            actual = Vector2D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Clamp did not return the expected value.");

            // Normal case.
            // Case W2: specified value is bigger than max and min value.
            a = new Vector2D<float>(2.0f, 3.0f);
            expected = max;
            actual = Vector2D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Clamp did not return the expected value.");

            // Case W3: specified value is smaller than min and max value.
            a = new Vector2D<float>(-1.0f, -2.0f);
            expected = max;
            actual = Vector2D.Clamp(a, min, max);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Clamp did not return the expected value.");
        }

        // A test for Lerp (Vector2f, Vector2f, float)
        [Fact]
        public void Vector2LerpTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> b = new Vector2D<float>(3.0f, 4.0f);

            float t = 0.5f;

            Vector2D<float> expected = new Vector2D<float>(2.0f, 3.0f);
            Vector2D<float> actual;
            actual = Vector2D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector2f, Vector2f, float)
        // Lerp test with factor zero
        [Fact]
        public void Vector2LerpTest1()
        {
            Vector2D<float> a = new Vector2D<float>(0.0f, 0.0f);
            Vector2D<float> b = new Vector2D<float>(3.18f, 4.25f);

            float t = 0.0f;
            Vector2D<float> expected = Vector2D<float>.Zero;
            Vector2D<float> actual = Vector2D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector2f, Vector2f, float)
        // Lerp test with factor one
        [Fact]
        public void Vector2LerpTest2()
        {
            Vector2D<float> a = new Vector2D<float>(0.0f, 0.0f);
            Vector2D<float> b = new Vector2D<float>(3.18f, 4.25f);

            float t = 1.0f;
            Vector2D<float> expected = new Vector2D<float>(3.18f, 4.25f);
            Vector2D<float> actual = Vector2D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector2f, Vector2f, float)
        // Lerp test with factor > 1
        [Fact]
        public void Vector2LerpTest3()
        {
            Vector2D<float> a = new Vector2D<float>(0.0f, 0.0f);
            Vector2D<float> b = new Vector2D<float>(3.18f, 4.25f);

            float t = 2.0f;
            Vector2D<float> expected = b * 2.0f;
            Vector2D<float> actual = Vector2D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector2f, Vector2f, float)
        // Lerp test with factor < 0
        [Fact]
        public void Vector2LerpTest4()
        {
            Vector2D<float> a = new Vector2D<float>(0.0f, 0.0f);
            Vector2D<float> b = new Vector2D<float>(3.18f, 4.25f);

            float t = -2.0f;
            Vector2D<float> expected = -(b * 2.0f);
            Vector2D<float> actual = Vector2D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector2f, Vector2f, float)
        // Lerp test with special float value
        [Fact]
        public void Vector2LerpTest5()
        {
            Vector2D<float> a = new Vector2D<float>(45.67f, 90.0f);
            Vector2D<float> b = new Vector2D<float>(float.PositiveInfinity, float.NegativeInfinity);

            float t = 0.408f;
            Vector2D<float> actual = Vector2D.Lerp(a, b, t);
            Assert.True(float.IsPositiveInfinity(actual.X), "Vector2f.Lerp did not return the expected value.");
            Assert.True(float.IsNegativeInfinity(actual.Y), "Vector2f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector2f, Vector2f, float)
        // Lerp test from the same point
        [Fact]
        public void Vector2LerpTest6()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> b = new Vector2D<float>(1.0f, 2.0f);

            float t = 0.5f;

            Vector2D<float> expected = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> actual = Vector2D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector2f, Vector2f, float)
        // Lerp test with values known to be innacurate with the old lerp impl
        [Fact]
        public void Vector2LerpTest7()
        {
            Vector2D<float> a = new Vector2D<float>(0.44728136f);
            Vector2D<float> b = new Vector2D<float>(0.46345946f);

            float t = 0.26402435f;

            Vector2D<float> expected = new Vector2D<float>(0.45155275f);
            Vector2D<float> actual = Vector2D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Lerp did not return the expected value.");
        }

        // A test for Lerp (Vector2f, Vector2f, float)
        // Lerp test with values known to be innacurate with the old lerp impl
        // (Old code incorrectly gets 0.33333588)
        [Fact]
        public void Vector2LerpTest8()
        {
            Vector2D<float> a = new Vector2D<float>(-100);
            Vector2D<float> b = new Vector2D<float>(0.33333334f);

            float t = 1f;

            Vector2D<float> expected = new Vector2D<float>(0.33333334f);
            Vector2D<float> actual = Vector2D.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Lerp did not return the expected value.");
        }
        
        // A test for Transform(Vector2f, Matrix4X4)
        [Fact]
        public void Vector2TransformTest()
        {
            Vector2D<float> v = new Vector2D<float>(1.0f, 2.0f);
            Matrix4X4<float> m =
                Matrix4X4.CreateRotationX<float>(MathHelper.ToRadians(30.0f)) *
                Matrix4X4.CreateRotationY<float>(MathHelper.ToRadians(30.0f)) *
                Matrix4X4.CreateRotationZ<float>(MathHelper.ToRadians(30.0f));
            m.M41 = 10.0f;
            m.M42 = 20.0f;
            m.M43 = 30.0f;

            Vector2D<float> expected = new Vector2D<float>(10.316987f, 22.183012f);
            Vector2D<float> actual;

            actual = Vector2D.Transform(v, m);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Transform did not return the expected value.");
        }

        // A test for Transform(Vector2f, Matrix3X2)
        [Fact]
        public void Vector2Transform3x2Test()
        {
            Vector2D<float> v = new Vector2D<float>(1.0f, 2.0f);
            Matrix3X2<float> m = Matrix3X2.CreateRotation<float>(MathHelper.ToRadians(30.0f));
            m.M31 = 10.0f;
            m.M32 = 20.0f;

            Vector2D<float> expected = new Vector2D<float>(9.866025f, 22.23205f);
            Vector2D<float> actual;

            actual = Vector2D.Transform(v, m);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Transform did not return the expected value.");
        }

        
        // A test for TransformNormal (Vector2f, Matrix4X4)
        [Fact]
        public void Vector2TransformNormalTest()
        {
            Vector2D<float> v = new Vector2D<float>(1.0f, 2.0f);
            Matrix4X4<float> m =
                Matrix4X4.CreateRotationX<float>(MathHelper.ToRadians(30.0f)) *
                Matrix4X4.CreateRotationY<float>(MathHelper.ToRadians(30.0f)) *
                Matrix4X4.CreateRotationZ<float>(MathHelper.ToRadians(30.0f));
            m.M41 = 10.0f;
            m.M42 = 20.0f;
            m.M43 = 30.0f;

            Vector2D<float> expected = new Vector2D<float>(0.3169873f, 2.18301272f);
            Vector2D<float> actual;

            actual = Vector2D.TransformNormal(v, m);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Tranform did not return the expected value.");
        }

        // A test for TransformNormal (Vector2f, Matrix3X2)
        [Fact]
        public void Vector2TransformNormal3x2Test()
        {
            Vector2D<float> v = new Vector2D<float>(1.0f, 2.0f);
            Matrix3X2<float> m = Matrix3X2.CreateRotation<float>(MathHelper.ToRadians(30.0f));
            m.M31 = 10.0f;
            m.M32 = 20.0f;

            Vector2D<float> expected = new Vector2D<float>(-0.133974612f, 2.232051f);
            Vector2D<float> actual;

            actual = Vector2D.TransformNormal(v, m);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Transform did not return the expected value.");
        }

        // A test for Transform (Vector2f, Quaternion)
        [Fact]
        public void Vector2TransformByQuaternionTest()
        {
            Vector2D<float> v = new Vector2D<float>(1.0f, 2.0f);

            Matrix4X4<float> m =
                Matrix4X4.CreateRotationX<float>(MathHelper.ToRadians(30.0f)) *
                Matrix4X4.CreateRotationY<float>(MathHelper.ToRadians(30.0f)) *
                Matrix4X4.CreateRotationZ<float>(MathHelper.ToRadians(30.0f));
            Quaternion<float> q = Quaternion<float>.CreateFromRotationMatrix(m);

            Vector2D<float> expected = Vector2D.Transform(v, m);
            Vector2D<float> actual = Vector2D.Transform(v, q);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Transform did not return the expected value.");
        }
        
        // A test for Transform (Vector2f, Quaternion)
        // Transform Vector2f with zero quaternion
        [Fact]
        public void Vector2TransformByQuaternionTest1()
        {
            Vector2D<float> v = new Vector2D<float>(1.0f, 2.0f);
            Quaternion<float> q = new Quaternion<float>();
            Vector2D<float> expected = v;

            Vector2D<float> actual = Vector2D.Transform(v, q);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Transform did not return the expected value.");
        }
        
        // A test for Transform (Vector2f, Quaternion)
        // Transform Vector2f with identity quaternion
        [Fact]
        public void Vector2TransformByQuaternionTest2()
        {
            Vector2D<float> v = new Vector2D<float>(1.0f, 2.0f);
            Quaternion<float> q = Quaternion<float>.Identity;
            Vector2D<float> expected = v;

            Vector2D<float> actual = Vector2D.Transform(v, q);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Transform did not return the expected value.");
        }

        // A test for Normalize (Vector2f)
        [Fact]
        public void Vector2NormalizeTest()
        {
            Vector2D<float> a = new Vector2D<float>(2.0f, 3.0f);
            Vector2D<float> expected = new Vector2D<float>(0.554700196225229122018341733457f, 0.8320502943378436830275126001855f);
            Vector2D<float> actual;

            actual = Vector2D.Normalize(a);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Normalize did not return the expected value.");
        }

        // A test for Normalize (Vector2f)
        // Normalize zero length vector
        [Fact]
        public void Vector2NormalizeTest1()
        {
            Vector2D<float> a = new Vector2D<float>(); // no parameter, default to 0.0f
            Vector2D<float> actual = Vector2D.Normalize(a);
            Assert.True(float.IsNaN(actual.X) && float.IsNaN(actual.Y), "Vector2f.Normalize did not return the expected value.");
        }

        // A test for Normalize (Vector2f)
        // Normalize infinite length vector
        [Fact]
        public void Vector2NormalizeTest2()
        {
            Vector2D<float> a = new Vector2D<float>(float.MaxValue, float.MaxValue);
            Vector2D<float> actual = Vector2D.Normalize(a);
            Vector2D<float> expected = new Vector2D<float>(0, 0);
            Assert.Equal(expected, actual);
        }

        // A test for operator - (Vector2f)
        [Fact]
        public void Vector2UnaryNegationTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);

            Vector2D<float> expected = new Vector2D<float>(-1.0f, -2.0f);
            Vector2D<float> actual;

            actual = -a;

            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.operator - did not return the expected value.");
        }



        // A test for operator - (Vector2f)
        // Negate test with special float value
        [Fact]
        public void Vector2UnaryNegationTest1()
        {
            Vector2D<float> a = new Vector2D<float>(float.PositiveInfinity, float.NegativeInfinity);

            Vector2D<float> actual = -a;

            Assert.True(float.IsNegativeInfinity(actual.X), "Vector2f.operator - did not return the expected value.");
            Assert.True(float.IsPositiveInfinity(actual.Y), "Vector2f.operator - did not return the expected value.");
        }

        // A test for operator - (Vector2f)
        // Negate test with special float value
        [Fact]
        public void Vector2UnaryNegationTest2()
        {
            Vector2D<float> a = new Vector2D<float>(float.NaN, 0.0f);
            Vector2D<float> actual = -a;

            Assert.True(float.IsNaN(actual.X), "Vector2f.operator - did not return the expected value.");
            Assert.True(float.Equals(0.0f, actual.Y), "Vector2f.operator - did not return the expected value.");
        }

        // A test for operator - (Vector2f, Vector2f)
        [Fact]
        public void Vector2SubtractionTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 3.0f);
            Vector2D<float> b = new Vector2D<float>(2.0f, 1.5f);

            Vector2D<float> expected = new Vector2D<float>(-1.0f, 1.5f);
            Vector2D<float> actual;

            actual = a - b;

            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.operator - did not return the expected value.");
        }

        // A test for operator * (Vector2f, float)
        [Fact]
        public void Vector2MultiplyOperatorTest()
        {
            Vector2D<float> a = new Vector2D<float>(2.0f, 3.0f);
            const float factor = 2.0f;

            Vector2D<float> expected = new Vector2D<float>(4.0f, 6.0f);
            Vector2D<float> actual;

            actual = a * factor;
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.operator * did not return the expected value.");
        }

        // A test for operator * (float, Vector2f)
        [Fact]
        public void Vector2MultiplyOperatorTest2()
        {
            Vector2D<float> a = new Vector2D<float>(2.0f, 3.0f);
            const float factor = 2.0f;

            Vector2D<float> expected = new Vector2D<float>(4.0f, 6.0f);
            Vector2D<float> actual;

            actual = factor * a;
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.operator * did not return the expected value.");
        }

        // A test for operator * (Vector2f, Vector2f)
        [Fact]
        public void Vector2MultiplyOperatorTest3()
        {
            Vector2D<float> a = new Vector2D<float>(2.0f, 3.0f);
            Vector2D<float> b = new Vector2D<float>(4.0f, 5.0f);

            Vector2D<float> expected = new Vector2D<float>(8.0f, 15.0f);
            Vector2D<float> actual;

            actual = a * b;

            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.operator * did not return the expected value.");
        }

        // A test for operator / (Vector2f, float)
        [Fact]
        public void Vector2DivisionTest()
        {
            Vector2D<float> a = new Vector2D<float>(2.0f, 3.0f);

            float div = 2.0f;

            Vector2D<float> expected = new Vector2D<float>(1.0f, 1.5f);
            Vector2D<float> actual;

            actual = a / div;

            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.operator / did not return the expected value.");
        }

        // A test for operator / (Vector2f, Vector2f)
        [Fact]
        public void Vector2DivisionTest1()
        {
            Vector2D<float> a = new Vector2D<float>(2.0f, 3.0f);
            Vector2D<float> b = new Vector2D<float>(4.0f, 5.0f);

            Vector2D<float> expected = new Vector2D<float>(2.0f / 4.0f, 3.0f / 5.0f);
            Vector2D<float> actual;

            actual = a / b;

            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.operator / did not return the expected value.");
        }

        // A test for operator / (Vector2f, float)
        // Divide by zero
        [Fact]
        public void Vector2DivisionTest2()
        {
            Vector2D<float> a = new Vector2D<float>(-2.0f, 3.0f);

            float div = 0.0f;

            Vector2D<float> actual = a / div;

            Assert.True(float.IsNegativeInfinity(actual.X), "Vector2f.operator / did not return the expected value.");
            Assert.True(float.IsPositiveInfinity(actual.Y), "Vector2f.operator / did not return the expected value.");
        }

        // A test for operator / (Vector2f, Vector2f)
        // Divide by zero
        [Fact]
        public void Vector2DivisionTest3()
        {
            Vector2D<float> a = new Vector2D<float>(0.047f, -3.0f);
            Vector2D<float> b = new Vector2D<float>();

            Vector2D<float> actual = a / b;

            Assert.True(float.IsInfinity(actual.X), "Vector2f.operator / did not return the expected value.");
            Assert.True(float.IsInfinity(actual.Y), "Vector2f.operator / did not return the expected value.");
        }

        // A test for operator + (Vector2f, Vector2f)
        [Fact]
        public void Vector2AdditionTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> b = new Vector2D<float>(3.0f, 4.0f);

            Vector2D<float> expected = new Vector2D<float>(4.0f, 6.0f);
            Vector2D<float> actual;

            actual = a + b;

            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.operator + did not return the expected value.");
        }

        // A test for Vector2f (float, float)
        [Fact]
        public void Vector2ConstructorTest()
        {
            float x = 1.0f;
            float y = 2.0f;

            Vector2D<float> target = new Vector2D<float>(x, y);
            Assert.True(MathHelper.Equal(target.X, x) && MathHelper.Equal(target.Y, y), "Vector2f(x,y) constructor did not return the expected value.");
        }

        // A test for Vector2f ()
        // Constructor with no parameter
        [Fact]
        public void Vector2ConstructorTest2()
        {
            Vector2D<float> target = new Vector2D<float>();
            Assert.Equal(0.0f, target.X);
            Assert.Equal(0.0f, target.Y);
        }

        // A test for Vector2f (float, float)
        // Constructor with special floating values
        [Fact]
        public void Vector2ConstructorTest3()
        {
            Vector2D<float> target = new Vector2D<float>(float.NaN, float.MaxValue);
            Assert.Equal(target.X, float.NaN);
            Assert.Equal(target.Y, float.MaxValue);
        }

        // A test for Vector2f (float)
        [Fact]
        public void Vector2ConstructorTest4()
        {
            float value = 1.0f;
            Vector2D<float> target = new Vector2D<float>(value);

            Vector2D<float> expected = new Vector2D<float>(value, value);
            Assert.Equal(expected, target);

            value = 2.0f;
            target = new Vector2D<float>(value);
            expected = new Vector2D<float>(value, value);
            Assert.Equal(expected, target);
        }

        // A test for Add (Vector2f, Vector2f)
        [Fact]
        public void Vector2AddTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> b = new Vector2D<float>(5.0f, 6.0f);

            Vector2D<float> expected = new Vector2D<float>(6.0f, 8.0f);
            Vector2D<float> actual;

            actual = Vector2D.Add(a, b);
            Assert.Equal(expected, actual);
        }

        // A test for Divide (Vector2f, float)
        [Fact]
        public void Vector2DivideTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            float div = 2.0f;
            Vector2D<float> expected = new Vector2D<float>(0.5f, 1.0f);
            Vector2D<float> actual;
            actual = Vector2D.Divide(a, div);
            Assert.Equal(expected, actual);
        }

        // A test for Divide (Vector2f, Vector2f)
        [Fact]
        public void Vector2DivideTest1()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 6.0f);
            Vector2D<float> b = new Vector2D<float>(5.0f, 2.0f);

            Vector2D<float> expected = new Vector2D<float>(1.0f / 5.0f, 6.0f / 2.0f);
            Vector2D<float> actual;

            actual = Vector2D.Divide(a, b);
            Assert.Equal(expected, actual);
        }

        // A test for Equals (object)
        [Fact]
        public void Vector2EqualsTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> b = new Vector2D<float>(1.0f, 2.0f);

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
            obj = null;
            expected = false;
            actual = a.Equals(obj);
            Assert.Equal(expected, actual);
        }

        // A test for Multiply (Vector2f, float)
        [Fact]
        public void Vector2MultiplyTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            const float factor = 2.0f;
            Vector2D<float> expected = new Vector2D<float>(2.0f, 4.0f);
            Vector2D<float> actual = Vector2D.Multiply(a, factor);
            Assert.Equal(expected, actual);
        }

        // A test for Multiply (float, Vector2f)
        [Fact]
        public void Vector2MultiplyTest2()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            const float factor = 2.0f;
            Vector2D<float> expected = new Vector2D<float>(2.0f, 4.0f);
            Vector2D<float> actual = Vector2D.Multiply(factor, a);
            Assert.Equal(expected, actual);
        }

        // A test for Multiply (Vector2f, Vector2f)
        [Fact]
        public void Vector2MultiplyTest3()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> b = new Vector2D<float>(5.0f, 6.0f);

            Vector2D<float> expected = new Vector2D<float>(5.0f, 12.0f);
            Vector2D<float> actual;

            actual = Vector2D.Multiply(a, b);
            Assert.Equal(expected, actual);
        }

        // A test for Negate (Vector2f)
        [Fact]
        public void Vector2NegateTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);

            Vector2D<float> expected = new Vector2D<float>(-1.0f, -2.0f);
            Vector2D<float> actual;

            actual = Vector2D.Negate(a);
            Assert.Equal(expected, actual);
        }

        // A test for operator != (Vector2f, Vector2f)
        [Fact]
        public void Vector2InequalityTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> b = new Vector2D<float>(1.0f, 2.0f);

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

        // A test for operator == (Vector2f, Vector2f)
        [Fact]
        public void Vector2EqualityTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> b = new Vector2D<float>(1.0f, 2.0f);

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

        // A test for Subtract (Vector2f, Vector2f)
        [Fact]
        public void Vector2SubtractTest()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 6.0f);
            Vector2D<float> b = new Vector2D<float>(5.0f, 2.0f);

            Vector2D<float> expected = new Vector2D<float>(-4.0f, 4.0f);
            Vector2D<float> actual;

            actual = Vector2D.Subtract(a, b);
            Assert.Equal(expected, actual);
        }

        // A test for UnitX
        [Fact]
        public void Vector2UnitXTest()
        {
            Vector2D<float> val = new Vector2D<float>(1.0f, 0.0f);
            Assert.Equal(val, Vector2D<float>.UnitX);
        }

        // A test for UnitY
        [Fact]
        public void Vector2UnitYTest()
        {
            Vector2D<float> val = new Vector2D<float>(0.0f, 1.0f);
            Assert.Equal(val, Vector2D<float>.UnitY);
        }

        // A test for One
        [Fact]
        public void Vector2OneTest()
        {
            Vector2D<float> val = new Vector2D<float>(1.0f, 1.0f);
            Assert.Equal(val, Vector2D<float>.One);
        }

        // A test for Zero
        [Fact]
        public void Vector2ZeroTest()
        {
            Vector2D<float> val = new Vector2D<float>(0.0f, 0.0f);
            Assert.Equal(val, Vector2D<float>.Zero);
        }

        // A test for Equals (Vector2f)
        [Fact]
        public void Vector2EqualsTest1()
        {
            Vector2D<float> a = new Vector2D<float>(1.0f, 2.0f);
            Vector2D<float> b = new Vector2D<float>(1.0f, 2.0f);

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

        // A test for Vector2f comparison involving NaN values
        [Fact]
        public void Vector2EqualsNanTest()
        {
            Vector2D<float> a = new Vector2D<float>(float.NaN, 0);
            Vector2D<float> b = new Vector2D<float>(0, float.NaN);

            Assert.False(a == Vector2D<float>.Zero);
            Assert.False(b == Vector2D<float>.Zero);

            Assert.True(a != Vector2D<float>.Zero);
            Assert.True(b != Vector2D<float>.Zero);

            Assert.False(a.Equals(Vector2D<float>.Zero));
            Assert.False(b.Equals(Vector2D<float>.Zero));

            // Counterintuitive result - IEEE rules for NaN comparison are weird!
            Assert.False(a.Equals(a));
            Assert.False(b.Equals(b));
        }

        // A test for Reflect (Vector2f, Vector2f)
        [Fact]
        public void Vector2ReflectTest()
        {
            Vector2D<float> a = Vector2D.Normalize(new Vector2D<float>(1.0f, 1.0f));

            // Reflect on XZ plane.
            Vector2D<float> n = new Vector2D<float>(0.0f, 1.0f);
            Vector2D<float> expected = new Vector2D<float>(a.X, -a.Y);
            Vector2D<float> actual = Vector2D.Reflect(a, n);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Reflect did not return the expected value.");

            // Reflect on XY plane.
            n = new Vector2D<float>(0.0f, 0.0f);
            expected = new Vector2D<float>(a.X, a.Y);
            actual = Vector2D.Reflect(a, n);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Reflect did not return the expected value.");

            // Reflect on YZ plane.
            n = new Vector2D<float>(1.0f, 0.0f);
            expected = new Vector2D<float>(-a.X, a.Y);
            actual = Vector2D.Reflect(a, n);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Reflect did not return the expected value.");
        }

        // A test for Reflect (Vector2f, Vector2f)
        // Reflection when normal and source are the same
        [Fact]
        public void Vector2ReflectTest1()
        {
            Vector2D<float> n = new Vector2D<float>(0.45f, 1.28f);
            n = Vector2D.Normalize(n);
            Vector2D<float> a = n;

            Vector2D<float> expected = -n;
            Vector2D<float> actual = Vector2D.Reflect(a, n);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Reflect did not return the expected value.");
        }

        // A test for Reflect (Vector2f, Vector2f)
        // Reflection when normal and source are negation
        [Fact]
        public void Vector2ReflectTest2()
        {
            Vector2D<float> n = new Vector2D<float>(0.45f, 1.28f);
            n = Vector2D.Normalize(n);
            Vector2D<float> a = -n;

            Vector2D<float> expected = n;
            Vector2D<float> actual = Vector2D.Reflect(a, n);
            Assert.True(MathHelper.Equal(expected, actual), "Vector2f.Reflect did not return the expected value.");
        }

        [Fact]
        public void Vector2AbsTest()
        {
            Vector2D<float> v1 = new Vector2D<float>(-2.5f, 2.0f);
            Vector2D<float> v3 = Vector2D.Abs(new Vector2D<float>(0.0f, float.NegativeInfinity));
            Vector2D<float> v = Vector2D.Abs(v1);
            Assert.Equal(2.5f, v.X);
            Assert.Equal(2.0f, v.Y);
            Assert.Equal(0.0f, v3.X);
            Assert.Equal(float.PositiveInfinity, v3.Y);
        }

        [Fact]
        public void Vector2SqrtTest()
        {
            Vector2D<float> v1 = new Vector2D<float>(-2.5f, 2.0f);
            Vector2D<float> v2 = new Vector2D<float>(5.5f, 4.5f);
            Assert.Equal(2, (int)Vector2D.SquareRoot(v2).X);
            Assert.Equal(2, (int)Vector2D.SquareRoot(v2).Y);
            Assert.Equal(float.NaN, Vector2D.SquareRoot(v1).X);
        }

        // A test to make sure these types are blittable directly into GPU buffer memory layouts
        [Fact]
        public unsafe void Vector2SizeofTest()
        {
            Assert.Equal(8, sizeof(Vector2D<float>));
            Assert.Equal(16, sizeof(Vector2_2x));
            Assert.Equal(12, sizeof(Vector2PlusFloat));
            Assert.Equal(24, sizeof(Vector2PlusFloat_2x));
        }

        [StructLayout(LayoutKind.Sequential)]
        struct Vector2_2x
        {
            private Vector2D<float> _a;
            private Vector2D<float> _b;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct Vector2PlusFloat
        {
            private Vector2D<float> _v;
            private float _f;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct Vector2PlusFloat_2x
        {
            private Vector2PlusFloat _a;
            private Vector2PlusFloat _b;
        }

        [Fact]
        public void SetFieldsTest()
        {
            Vector2D<float> v3 = new Vector2D<float>(4f, 5f);
            v3.X = 1.0f;
            v3.Y = 2.0f;
            Assert.Equal(1.0f, v3.X);
            Assert.Equal(2.0f, v3.Y);
            Vector2D<float> v4 = v3;
            v4.Y = 0.5f;
            Assert.Equal(1.0f, v4.X);
            Assert.Equal(0.5f, v4.Y);
            Assert.Equal(2.0f, v3.Y);
        }

        [Fact]
        public void EmbeddedVectorSetFields()
        {
            EmbeddedVectorObject evo = new EmbeddedVectorObject();
            evo.FieldVector.X = 5.0f;
            evo.FieldVector.Y = 5.0f;
            Assert.Equal(5.0f, evo.FieldVector.X);
            Assert.Equal(5.0f, evo.FieldVector.Y);
        }

        private class EmbeddedVectorObject
        {
            public Vector2D<float> FieldVector;
        }
    }
}
