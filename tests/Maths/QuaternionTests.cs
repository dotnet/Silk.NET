// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class QuaternionTests
    {
        // A test for Dot (Quaternion<float>, Quaternion<float>)
        [Fact]
        public void QuaternionDotTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(5.0f, 6.0f, 7.0f, 8.0f);

            float expected = 70.0f;
            float actual;

            actual = Quaternion<float>.Dot(a, b);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Dot did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Length ()
        [Fact]
        public void QuaternionLengthTest()
        {
            Vector3D<float> v = new Vector3D<float>(1.0f, 2.0f, 3.0f);

            float w = 4.0f;

            Quaternion<float> target = new Quaternion<float>(v, w);

            float expected = 5.477226f;
            float actual;

            actual = target.Length();

            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Length did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for LengthSquared ()
        [Fact]
        public void QuaternionLengthSquaredTest()
        {
            Vector3D<float> v = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            float w = 4.0f;

            Quaternion<float> target = new Quaternion<float>(v, w);

            float expected = 30.0f;
            float actual;

            actual = target.LengthSquared();

            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.LengthSquared did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Lerp (Quaternion<float>, Quaternion<float>, float)
        [Fact]
        public void QuaternionLerpTest()
        {
            Vector3D<float> axis = Vector3D.Normalize(new Vector3D<float>(1.0f, 2.0f, 3.0f));
            Quaternion<float> a = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(10.0f));
            Quaternion<float> b = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(30.0f));

            float t = 0.5f;

            Quaternion<float> expected = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(20.0f));
            Quaternion<float> actual;

            actual = Quaternion<float>.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Lerp did not return the expected value: expected {expected} actual {actual}");

            // Case a and b are same.
            expected = a;
            actual = Quaternion<float>.Lerp(a, a, t);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Lerp did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Lerp (Quaternion<float>, Quaternion<float>, float)
        // Lerp test when t = 0
        [Fact]
        public void QuaternionLerpTest1()
        {
            Vector3D<float> axis = Vector3D.Normalize(new Vector3D<float>(1.0f, 2.0f, 3.0f));
            Quaternion<float> a = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(10.0f));
            Quaternion<float> b = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(30.0f));

            float t = 0.0f;

            Quaternion<float> expected = new Quaternion<float>(a.X, a.Y, a.Z, a.W);
            Quaternion<float> actual = Quaternion<float>.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Lerp did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Lerp (Quaternion<float>, Quaternion<float>, float)
        // Lerp test when t = 1
        [Fact]
        public void QuaternionLerpTest2()
        {
            Vector3D<float> axis = Vector3D.Normalize(new Vector3D<float>(1.0f, 2.0f, 3.0f));
            Quaternion<float> a = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(10.0f));
            Quaternion<float> b = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(30.0f));

            float t = 1.0f;

            Quaternion<float> expected = new Quaternion<float>(b.X, b.Y, b.Z, b.W);
            Quaternion<float> actual = Quaternion<float>.Lerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Lerp did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Lerp (Quaternion<float>, Quaternion<float>, float)
        // Lerp test when the two Quaternion<float>s are more than 90 degree (dot product <0)
        [Fact]
        public void QuaternionLerpTest3()
        {
            Vector3D<float> axis = Vector3D.Normalize(new Vector3D<float>(1.0f, 2.0f, 3.0f));
            Quaternion<float> a = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(10.0f));
            Quaternion<float> b = Quaternion<float>.Negate(a);

            float t = 1.0f;

            Quaternion<float> actual = Quaternion<float>.Lerp(a, b, t);
            // Note that in Quaternion<float> world, Q == -Q. In the case of Quaternion<float>s dot product is zero,
            // one of the Quaternion<float> will be flipped to compute the shortest distance. When t = 1, we
            // expect the result to be the same as Quaternion<float> b but flipped.
            Assert.True(actual == a, $"Quaternion<float>.Lerp did not return the expected value: expected {a} actual {actual}");
        }

        // A test for Conjugate(Quaternion<float>)
        [Fact]
        public void QuaternionConjugateTest1()
        {
            Quaternion<float> a = new Quaternion<float>(1, 2, 3, 4);

            Quaternion<float> expected = new Quaternion<float>(-1, -2, -3, 4);
            Quaternion<float> actual;

            actual = Quaternion<float>.Conjugate(a);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Conjugate did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Normalize (Quaternion<float>)
        [Fact]
        public void QuaternionNormalizeTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);

            Quaternion<float> expected = new Quaternion<float>(0.182574168f, 0.365148336f, 0.5477225f, 0.7302967f);
            Quaternion<float> actual;

            actual = Quaternion<float>.Normalize(a);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Normalize did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Normalize (Quaternion<float>)
        // Normalize zero length Quaternion<float>
        [Fact]
        public void QuaternionNormalizeTest1()
        {
            Quaternion<float> a = new Quaternion<float>(0.0f, 0.0f, -0.0f, 0.0f);

            Quaternion<float> actual = Quaternion<float>.Normalize(a);
            Assert.True(float.IsNaN(actual.X) && float.IsNaN(actual.Y) && float.IsNaN(actual.Z) && float.IsNaN(actual.W)
                , $"Quaternion<float>.Normalize did not return the expected value: expected {new Quaternion<float>(float.NaN, float.NaN, float.NaN, float.NaN)} actual {actual}");
        }

        // A test for Concatenate(Quaternion<float>, Quaternion<float>)
        [Fact]
        public void QuaternionConcatenateTest1()
        {
            Quaternion<float> b = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion<float> a = new Quaternion<float>(5.0f, 6.0f, 7.0f, 8.0f);

            Quaternion<float> expected = new Quaternion<float>(24.0f, 48.0f, 48.0f, -6.0f);
            Quaternion<float> actual;

            actual = Quaternion<float>.Concatenate(a, b);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Concatenate did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for operator - (Quaternion<float>, Quaternion<float>)
        [Fact]
        public void QuaternionSubtractionTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 6.0f, 7.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(5.0f, 2.0f, 3.0f, 8.0f);

            Quaternion<float> expected = new Quaternion<float>(-4.0f, 4.0f, 4.0f, -4.0f);
            Quaternion<float> actual;

            actual = a - b;

            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.operator - did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for operator * (Quaternion<float>, float)
        [Fact]
        public void QuaternionMultiplyTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            float factor = 0.5f;

            Quaternion<float> expected = new Quaternion<float>(0.5f, 1.0f, 1.5f, 2.0f);
            Quaternion<float> actual;

            actual = a * factor;

            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.operator * did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for operator * (Quaternion<float>, Quaternion<float>)
        [Fact]
        public void QuaternionMultiplyTest1()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(5.0f, 6.0f, 7.0f, 8.0f);

            Quaternion<float> expected = new Quaternion<float>(24.0f, 48.0f, 48.0f, -6.0f);
            Quaternion<float> actual;

            actual = a * b;

            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.operator * did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for operator / (Quaternion<float>, Quaternion<float>)
        [Fact]
        public void QuaternionDivisionTest1()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(5.0f, 6.0f, 7.0f, 8.0f);

            Quaternion<float> expected = new Quaternion<float>(-0.045977015f, -0.09195402f, -7.450581E-9f, 0.402298868f);
            Quaternion<float> actual;

            actual = a / b;

            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.operator / did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for operator + (Quaternion<float>, Quaternion<float>)
        [Fact]
        public void QuaternionAdditionTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(5.0f, 6.0f, 7.0f, 8.0f);

            Quaternion<float> expected = new Quaternion<float>(6.0f, 8.0f, 10.0f, 12.0f);
            Quaternion<float> actual;

            actual = a + b;

            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.operator + did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Quaternion<float> (float, float, float, float)
        [Fact]
        public void QuaternionConstructorTest()
        {
            float x = 1.0f;
            float y = 2.0f;
            float z = 3.0f;
            float w = 4.0f;

            Quaternion<float> target = new Quaternion<float>(x, y, z, w);

            Assert.True(MathHelper.Equal(target.X, x) && MathHelper.Equal(target.Y, y) && MathHelper.Equal(target.Z, z) && MathHelper.Equal(target.W, w),
                "Quaternion<float>.constructor (x,y,z,w) did not return the expected value.");
        }

        // A test for Quaternion<float> (Vector3D<float>f, float)
        [Fact]
        public void QuaternionConstructorTest1()
        {
            Vector3D<float> v = new Vector3D<float>(1.0f, 2.0f, 3.0f);
            float w = 4.0f;

            Quaternion<float> target = new Quaternion<float>(v, w);
            Assert.True(MathHelper.Equal(target.X, v.X) && MathHelper.Equal(target.Y, v.Y) && MathHelper.Equal(target.Z, v.Z) && MathHelper.Equal(target.W, w),
                "Quaternion<float>.constructor (Vector3D<float>f,w) did not return the expected value.");
        }

        // A test for CreateFromAxisAngle (Vector3D<float>f, float)
        [Fact]
        public void QuaternionCreateFromAxisAngleTest()
        {
            Vector3D<float> axis = Vector3D.Normalize(new Vector3D<float>(1.0f, 2.0f, 3.0f));
            float angle = MathHelper.ToRadians(30.0f);

            Quaternion<float> expected = new Quaternion<float>(0.0691723f, 0.1383446f, 0.207516879f, 0.9659258f);
            Quaternion<float> actual;

            actual = Quaternion<float>.CreateFromAxisAngle(axis, angle);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.CreateFromAxisAngle did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for CreateFromAxisAngle (Vector3D<float>f, float)
        // CreateFromAxisAngle of zero vector
        [Fact]
        public void QuaternionCreateFromAxisAngleTest1()
        {
            Vector3D<float> axis = new Vector3D<float>();
            float angle = MathHelper.ToRadians(-30.0f);

            float cos = (float)System.Math.Cos(angle / 2.0f);
            Quaternion<float> actual = Quaternion<float>.CreateFromAxisAngle(axis, angle);

            Assert.True(actual.X == 0.0f && actual.Y == 0.0f && actual.Z == 0.0f && MathHelper.Equal(cos, actual.W)
                , "Quaternion<float>.CreateFromAxisAngle did not return the expected value.");
        }

        // A test for CreateFromAxisAngle (Vector3D<float>f, float)
        // CreateFromAxisAngle of angle = 30 && 750
        [Fact]
        public void QuaternionCreateFromAxisAngleTest2()
        {
            Vector3D<float> axis = new Vector3D<float>(1, 0, 0);
            float angle1 = MathHelper.ToRadians(30.0f);
            float angle2 = MathHelper.ToRadians(750.0f);

            Quaternion<float> actual1 = Quaternion<float>.CreateFromAxisAngle(axis, angle1);
            Quaternion<float> actual2 = Quaternion<float>.CreateFromAxisAngle(axis, angle2);
            Assert.True(MathHelper.Equal(actual1, actual2), $"Quaternion<float>.CreateFromAxisAngle did not return the expected value: actual1 {actual1} actual2 {actual2}");
        }

        // A test for CreateFromAxisAngle (Vector3D<float>f, float)
        // CreateFromAxisAngle of angle = 30 && 390
        [Fact]
        public void QuaternionCreateFromAxisAngleTest3()
        {
            Vector3D<float> axis = new Vector3D<float>(1, 0, 0);
            float angle1 = MathHelper.ToRadians(30.0f);
            float angle2 = MathHelper.ToRadians(390.0f);

            Quaternion<float> actual1 = Quaternion<float>.CreateFromAxisAngle(axis, angle1);
            Quaternion<float> actual2 = Quaternion<float>.CreateFromAxisAngle(axis, angle2);
            actual1.X = -actual1.X;
            actual1.W = -actual1.W;

            Assert.True(MathHelper.Equal(actual1, actual2), $"Quaternion<float>.CreateFromAxisAngle did not return the expected value: actual1 {actual1} actual2 {actual2}");
        }

        [Fact]
        public void QuaternionCreateFromYawPitchRollTest1()
        {
            float yawAngle = MathHelper.ToRadians(30.0f);
            float pitchAngle = MathHelper.ToRadians(40.0f);
            float rollAngle = MathHelper.ToRadians(50.0f);

            Quaternion<float> yaw = Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitY, yawAngle);
            Quaternion<float> pitch = Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitX, pitchAngle);
            Quaternion<float> roll = Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitZ, rollAngle);

            Quaternion<float> expected = yaw * pitch * roll;
            Quaternion<float> actual = Quaternion<float>.CreateFromYawPitchRoll(yawAngle, pitchAngle, rollAngle);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Quaternion<float>CreateFromYawPitchRollTest1 did not return the expected value: expected {expected} actual {actual}");
        }

        // Covers more numeric rigions
        [Fact]
        public void QuaternionCreateFromYawPitchRollTest2()
        {
            const float step = 35.0f;

            for (float yawAngle = -720.0f; yawAngle <= 720.0f; yawAngle += step)
            {
                for (float pitchAngle = -720.0f; pitchAngle <= 720.0f; pitchAngle += step)
                {
                    for (float rollAngle = -720.0f; rollAngle <= 720.0f; rollAngle += step)
                    {
                        float yawRad = MathHelper.ToRadians(yawAngle);
                        float pitchRad = MathHelper.ToRadians(pitchAngle);
                        float rollRad = MathHelper.ToRadians(rollAngle);

                        Quaternion<float> yaw = Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitY, yawRad);
                        Quaternion<float> pitch = Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitX, pitchRad);
                        Quaternion<float> roll = Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitZ, rollRad);

                        Quaternion<float> expected = yaw * pitch * roll;
                        Quaternion<float> actual = Quaternion<float>.CreateFromYawPitchRoll(yawRad, pitchRad, rollRad);
                        Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Quaternion<float>CreateFromYawPitchRollTest2 Yaw:{yawAngle} Pitch:{pitchAngle} Roll:{rollAngle} did not return the expected value: expected {expected} actual {actual}");
                    }
                }
            }
        }

        // A test for Slerp (Quaternion<float>, Quaternion<float>, float)
        [Fact]
        public void QuaternionSlerpTest()
        {
            Vector3D<float> axis = Vector3D.Normalize(new Vector3D<float>(1.0f, 2.0f, 3.0f));
            Quaternion<float> a = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(10.0f));
            Quaternion<float> b = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(30.0f));

            float t = 0.5f;

            Quaternion<float> expected = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(20.0f));
            Quaternion<float> actual;

            actual = Quaternion<float>.Slerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Slerp did not return the expected value: expected {expected} actual {actual}");

            // Case a and b are same.
            expected = a;
            actual = Quaternion<float>.Slerp(a, a, t);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Slerp did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Slerp (Quaternion<float>, Quaternion<float>, float)
        // Slerp test where t = 0
        [Fact]
        public void QuaternionSlerpTest1()
        {
            Vector3D<float> axis = Vector3D.Normalize(new Vector3D<float>(1.0f, 2.0f, 3.0f));
            Quaternion<float> a = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(10.0f));
            Quaternion<float> b = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(30.0f));

            float t = 0.0f;

            Quaternion<float> expected = new Quaternion<float>(a.X, a.Y, a.Z, a.W);
            Quaternion<float> actual = Quaternion<float>.Slerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Slerp did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Slerp (Quaternion<float>, Quaternion<float>, float)
        // Slerp test where t = 1
        [Fact]
        public void QuaternionSlerpTest2()
        {
            Vector3D<float> axis = Vector3D.Normalize(new Vector3D<float>(1.0f, 2.0f, 3.0f));
            Quaternion<float> a = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(10.0f));
            Quaternion<float> b = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(30.0f));

            float t = 1.0f;

            Quaternion<float> expected = new Quaternion<float>(b.X, b.Y, b.Z, b.W);
            Quaternion<float> actual = Quaternion<float>.Slerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Slerp did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Slerp (Quaternion<float>, Quaternion<float>, float)
        // Slerp test where dot product is < 0
        [Fact]
        public void QuaternionSlerpTest3()
        {
            Vector3D<float> axis = Vector3D.Normalize(new Vector3D<float>(1.0f, 2.0f, 3.0f));
            Quaternion<float> a = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(10.0f));
            Quaternion<float> b = -a;

            float t = 1.0f;

            Quaternion<float> expected = a;
            Quaternion<float> actual = Quaternion<float>.Slerp(a, b, t);
            // Note that in Quaternion<float> world, Q == -Q. In the case of Quaternion<float>s dot product is zero,
            // one of the Quaternion<float> will be flipped to compute the shortest distance. When t = 1, we
            // expect the result to be the same as Quaternion<float> b but flipped.
            Assert.True(actual == expected, $"Quaternion<float>.Slerp did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Slerp (Quaternion<float>, Quaternion<float>, float)
        // Slerp test where the Quaternion<float> is flipped
        [Fact]
        public void QuaternionSlerpTest4()
        {
            Vector3D<float> axis = Vector3D.Normalize(new Vector3D<float>(1.0f, 2.0f, 3.0f));
            Quaternion<float> a = Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(10.0f));
            Quaternion<float> b = -Quaternion<float>.CreateFromAxisAngle(axis, MathHelper.ToRadians(30.0f));

            float t = 0.0f;

            Quaternion<float> expected = new Quaternion<float>(a.X, a.Y, a.Z, a.W);
            Quaternion<float> actual = Quaternion<float>.Slerp(a, b, t);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Slerp did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for operator - (Quaternion<float>)
        [Fact]
        public void QuaternionUnaryNegationTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);

            Quaternion<float> expected = new Quaternion<float>(-1.0f, -2.0f, -3.0f, -4.0f);
            Quaternion<float> actual;

            actual = -a;

            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.operator - did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Inverse (Quaternion<float>)
        [Fact]
        public void QuaternionInverseTest()
        {
            Quaternion<float> a = new Quaternion<float>(5.0f, 6.0f, 7.0f, 8.0f);

            Quaternion<float> expected = new Quaternion<float>(-0.0287356321f, -0.03448276f, -0.0402298868f, 0.04597701f);
            Quaternion<float> actual;

            actual = Quaternion<float>.Inverse(a);
            Assert.Equal(expected, actual);
        }

        // A test for Inverse (Quaternion<float>)
        // Invert zero length Quaternion<float>
        [Fact]
        public void QuaternionInverseTest1()
        {
            Quaternion<float> a = new Quaternion<float>();
            Quaternion<float> actual = Quaternion<float>.Inverse(a);

            Assert.True(float.IsNaN(actual.X) && float.IsNaN(actual.Y) && float.IsNaN(actual.Z) && float.IsNaN(actual.W)
                , $"Quaternion<float>.Inverse - did not return the expected value: expected {new Quaternion<float>(float.NaN, float.NaN, float.NaN, float.NaN)} actual {actual}");
        }

        // A test for ToString ()
        [Fact]
        public void QuaternionToStringTest()
        {
            Quaternion<float> target = new Quaternion<float>(-1.0f, 2.2f, 3.3f, -4.4f);

            string expected = string.Format(CultureInfo.CurrentCulture
                , "{{X:{0} Y:{1} Z:{2} W:{3}}}"
                , -1.0f, 2.2f, 3.3f, -4.4f);

            string actual = target.ToString();
            Assert.Equal(expected, actual);
        }

        // A test for Add (Quaternion<float>, Quaternion<float>)
        [Fact]
        public void QuaternionAddTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(5.0f, 6.0f, 7.0f, 8.0f);

            Quaternion<float> expected = new Quaternion<float>(6.0f, 8.0f, 10.0f, 12.0f);
            Quaternion<float> actual;

            actual = Quaternion<float>.Add(a, b);
            Assert.Equal(expected, actual);
        }

        // A test for Divide (Quaternion<float>, Quaternion<float>)
        [Fact]
        public void QuaternionDivideTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(5.0f, 6.0f, 7.0f, 8.0f);

            Quaternion<float> expected = new Quaternion<float>(-0.045977015f, -0.09195402f, -7.450581E-9f, 0.402298868f);
            Quaternion<float> actual;

            actual = Quaternion<float>.Divide(a, b);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Divide did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Equals (object)
        [Fact]
        public void QuaternionEqualsTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);

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
            obj = new Vector4D<float>();
            expected = false;
            actual = a.Equals(obj);
            Assert.Equal(expected, actual);

            // case 3: compare against null.
            obj = null!;
            expected = false;
            actual = a.Equals(obj);
            Assert.Equal(expected, actual);
        }

        // A test for GetHashCode ()
        [Fact]
        public void QuaternionGetHashCodeTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);

            int expected = unchecked(a.X.GetHashCode() + a.Y.GetHashCode() + a.Z.GetHashCode() + a.W.GetHashCode());
            int actual = a.GetHashCode();
            Assert.Equal(expected, actual);
        }

        // A test for Multiply (Quaternion<float>, float)
        [Fact]
        public void QuaternionMultiplyTest2()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            float factor = 0.5f;

            Quaternion<float> expected = new Quaternion<float>(0.5f, 1.0f, 1.5f, 2.0f);
            Quaternion<float> actual;

            actual = Quaternion<float>.Multiply(a, factor);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Multiply did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Multiply (Quaternion<float>, Quaternion<float>)
        [Fact]
        public void QuaternionMultiplyTest3()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(5.0f, 6.0f, 7.0f, 8.0f);

            Quaternion<float> expected = new Quaternion<float>(24.0f, 48.0f, 48.0f, -6.0f);
            Quaternion<float> actual;

            actual = Quaternion<float>.Multiply(a, b);
            Assert.True(MathHelper.Equal(expected, actual), $"Quaternion<float>.Multiply did not return the expected value: expected {expected} actual {actual}");
        }

        // A test for Negate (Quaternion<float>)
        [Fact]
        public void QuaternionNegateTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);

            Quaternion<float> expected = new Quaternion<float>(-1.0f, -2.0f, -3.0f, -4.0f);
            Quaternion<float> actual;

            actual = Quaternion<float>.Negate(a);
            Assert.Equal(expected, actual);
        }

        // A test for Subtract (Quaternion<float>, Quaternion<float>)
        [Fact]
        public void QuaternionSubtractTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 6.0f, 7.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(5.0f, 2.0f, 3.0f, 8.0f);

            Quaternion<float> expected = new Quaternion<float>(-4.0f, 4.0f, 4.0f, -4.0f);
            Quaternion<float> actual;

            actual = Quaternion<float>.Subtract(a, b);
            Assert.Equal(expected, actual);
        }

        // A test for operator != (Quaternion<float>, Quaternion<float>)
        [Fact]
        public void QuaternionInequalityTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);

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

        // A test for operator == (Quaternion<float>, Quaternion<float>)
        [Fact]
        public void QuaternionEqualityTest()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);

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

        // A test for CreateFromRotationMatrix (Matrix4X4<float>)
        // Convert Identity matrix test
        [Fact]
        public void QuaternionFromRotationMatrixTest1()
        {
            Matrix4X4<float> matrix = Matrix4X4<float>.Identity;

            Quaternion<float> expected = new Quaternion<float>(0.0f, 0.0f, 0.0f, 1.0f);
            Quaternion<float> actual = Quaternion<float>.CreateFromRotationMatrix(matrix);
            Assert.True(MathHelper.Equal(expected, actual),
                $"Quaternion<float>.CreateFromRotationMatrix did not return the expected value: expected {expected} actual {actual}");

            // make sure convert back to matrix is same as we passed matrix.
            Matrix4X4<float> m2 = Matrix4X4.CreateFromQuaternion<float>(actual);
            Assert.True(MathHelper.Equal(matrix, m2),
                $"Quaternion<float>.CreateFromQuaternion did not return the expected value: matrix {matrix} m2 {m2}");
        }

        // A test for CreateFromRotationMatrix (Matrix4X4<float>)
        // Convert X axis rotation matrix
        [Fact]
        public void QuaternionFromRotationMatrixTest2()
        {
            for (float angle = 0.0f; angle < 720.0f; angle += 10.0f)
            {
                Matrix4X4<float> matrix = Matrix4X4.CreateRotationX<float>(angle);

                Quaternion<float> expected = Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitX, angle);
                Quaternion<float> actual = Quaternion<float>.CreateFromRotationMatrix(matrix);
                Assert.True(MathHelper.EqualRotation(expected, actual),
                    $"Quaternion<float>.CreateFromRotationMatrix angle:{angle} did not return the expected value: expected {expected} actual {actual}");

                // make sure convert back to matrix is same as we passed matrix.
                Matrix4X4<float> m2 = Matrix4X4.CreateFromQuaternion<float>(actual);
                Assert.True(MathHelper.Equal(matrix, m2),
                    $"Quaternion<float>.CreateFromQuaternion angle:{angle} did not return the expected value: matrix {matrix} m2 {m2}");
            }
        }

        // A test for CreateFromRotationMatrix (Matrix4X4<float>)
        // Convert Y axis rotation matrix
        [Fact]
        public void QuaternionFromRotationMatrixTest3()
        {
            for (float angle = 0.0f; angle < 720.0f; angle += 10.0f)
            {
                Matrix4X4<float> matrix = Matrix4X4.CreateRotationY<float>(angle);

                Quaternion<float> expected = Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitY, angle);
                Quaternion<float> actual = Quaternion<float>.CreateFromRotationMatrix(matrix);
                Assert.True(MathHelper.EqualRotation(expected, actual),
                    $"Quaternion<float>.CreateFromRotationMatrix angle:{angle} did not return the expected value: expected {expected} actual {actual}");

                // make sure convert back to matrix is same as we passed matrix.
                Matrix4X4<float> m2 = Matrix4X4.CreateFromQuaternion<float>(actual);
                Assert.True(MathHelper.Equal(matrix, m2),
                    $"Quaternion<float>.CreateFromQuaternion angle:{angle} did not return the expected value: matrix {matrix} m2 {m2}");
            }
        }

        // A test for CreateFromRotationMatrix (Matrix4X4<float>)
        // Convert Z axis rotation matrix
        [Fact]
        public void QuaternionFromRotationMatrixTest4()
        {
            for (float angle = 0.0f; angle < 720.0f; angle += 10.0f)
            {
                Matrix4X4<float> matrix = Matrix4X4.CreateRotationZ<float>(angle);

                Quaternion<float> expected = Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitZ, angle);
                Quaternion<float> actual = Quaternion<float>.CreateFromRotationMatrix(matrix);
                Assert.True(MathHelper.EqualRotation(expected, actual),
                    $"Quaternion<float>.CreateFromRotationMatrix angle:{angle} did not return the expected value: expected {expected} actual {actual}");

                // make sure convert back to matrix is same as we passed matrix.
                Matrix4X4<float> m2 = Matrix4X4.CreateFromQuaternion<float>(actual);
                Assert.True(MathHelper.Equal(matrix, m2),
                    $"Quaternion<float>.CreateFromQuaternion angle:{angle} did not return the expected value: matrix {matrix} m2 {m2}");
            }
        }

        // A test for CreateFromRotationMatrix (Matrix4X4<float>)
        // Convert XYZ axis rotation matrix
        [Fact]
        public void QuaternionFromRotationMatrixTest5()
        {
            for (float angle = 0.0f; angle < 720.0f; angle += 10.0f)
            {
                Matrix4X4<float> matrix = Matrix4X4.CreateRotationX<float>(angle) * Matrix4X4.CreateRotationY<float>(angle) * Matrix4X4.CreateRotationZ<float>(angle);

                Quaternion<float> expected =
                    Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitZ, angle) *
                    Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitY, angle) *
                    Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitX, angle);

                Quaternion<float> actual = Quaternion<float>.CreateFromRotationMatrix(matrix);
                Assert.True(MathHelper.EqualRotation(expected, actual),
                    $"Quaternion<float>.CreateFromRotationMatrix angle:{angle} did not return the expected value: expected {expected} actual {actual}");

                // make sure convert back to matrix is same as we passed matrix.
                Matrix4X4<float> m2 = Matrix4X4.CreateFromQuaternion<float>(actual);
                Assert.True(MathHelper.Equal(matrix, m2),
                    $"Quaternion<float>.CreateFromQuaternion angle:{angle} did not return the expected value: matrix {matrix} m2 {m2}");
            }
        }

        // A test for CreateFromRotationMatrix (Matrix4X4<float>)
        // X axis is most large axis case
        [Fact]
        public void QuaternionFromRotationMatrixWithScaledMatrixTest1()
        {
            float angle = MathHelper.ToRadians(180.0f);
            Matrix4X4<float> matrix = Matrix4X4.CreateRotationY<float>(angle) * Matrix4X4.CreateRotationZ<float>(angle);

            Quaternion<float> expected = Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitZ, angle) * Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitY, angle);
            Quaternion<float> actual = Quaternion<float>.CreateFromRotationMatrix(matrix);
            Assert.True(MathHelper.EqualRotation(expected, actual),
                $"Quaternion<float>.CreateFromRotationMatrix did not return the expected value: expected {expected} actual {actual}");

            // make sure convert back to matrix is same as we passed matrix.
            Matrix4X4<float> m2 = Matrix4X4.CreateFromQuaternion<float>(actual);
            Assert.True(MathHelper.Equal(matrix, m2),
                $"Quaternion<float>.CreateFromQuaternion did not return the expected value: matrix {matrix} m2 {m2}");
        }

        // A test for CreateFromRotationMatrix (Matrix4X4<float>)
        // Y axis is most large axis case
        [Fact]
        public void QuaternionFromRotationMatrixWithScaledMatrixTest2()
        {
            float angle = MathHelper.ToRadians(180.0f);
            Matrix4X4<float> matrix = Matrix4X4.CreateRotationX<float>(angle) * Matrix4X4.CreateRotationZ<float>(angle);

            Quaternion<float> expected = Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitZ, angle) * Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitX, angle);
            Quaternion<float> actual = Quaternion<float>.CreateFromRotationMatrix(matrix);
            Assert.True(MathHelper.EqualRotation(expected, actual),
                $"Quaternion<float>.CreateFromRotationMatrix did not return the expected value: expected {expected} actual {actual}");

            // make sure convert back to matrix is same as we passed matrix.
            Matrix4X4<float> m2 = Matrix4X4.CreateFromQuaternion<float>(actual);
            Assert.True(MathHelper.Equal(matrix, m2),
                $"Quaternion<float>.CreateFromQuaternion did not return the expected value: matrix {matrix} m2 {m2}");
        }

        // A test for CreateFromRotationMatrix (Matrix4X4<float>)
        // Z axis is most large axis case
        [Fact]
        public void QuaternionFromRotationMatrixWithScaledMatrixTest3()
        {
            float angle = MathHelper.ToRadians(180.0f);
            Matrix4X4<float> matrix = Matrix4X4.CreateRotationX<float>(angle) * Matrix4X4.CreateRotationY<float>(angle);

            Quaternion<float> expected = Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitY, angle) * Quaternion<float>.CreateFromAxisAngle(Vector3D<float>.UnitX, angle);
            Quaternion<float> actual = Quaternion<float>.CreateFromRotationMatrix(matrix);
            Assert.True(MathHelper.EqualRotation(expected, actual),
                $"Quaternion<float>.CreateFromRotationMatrix did not return the expected value: expected {expected} actual {actual}");

            // make sure convert back to matrix is same as we passed matrix.
            Matrix4X4<float> m2 = Matrix4X4.CreateFromQuaternion<float>(actual);
            Assert.True(MathHelper.Equal(matrix, m2),
                $"Quaternion<float>.CreateFromQuaternion did not return the expected value: matrix {matrix} m2 {m2}");
        }

        // A test for Equals (Quaternion<float>)
        [Fact]
        public void QuaternionEqualsTest1()
        {
            Quaternion<float> a = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion<float> b = new Quaternion<float>(1.0f, 2.0f, 3.0f, 4.0f);

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

        // A test for Identity
        [Fact]
        public void QuaternionIdentityTest()
        {
            Quaternion<float> val = new Quaternion<float>(0, 0, 0, 1);
            Assert.Equal(val, Quaternion<float>.Identity);
        }

        // A test for IsIdentity
        [Fact]
        public void QuaternionIsIdentityTest()
        {
            Assert.True(Quaternion<float>.Identity.IsIdentity);
            Assert.True(new Quaternion<float>(0, 0, 0, 1).IsIdentity);
            Assert.False(new Quaternion<float>(1, 0, 0, 1).IsIdentity);
            Assert.False(new Quaternion<float>(0, 1, 0, 1).IsIdentity);
            Assert.False(new Quaternion<float>(0, 0, 1, 1).IsIdentity);
            Assert.False(new Quaternion<float>(0, 0, 0, 0).IsIdentity);
        }

        // A test for Quaternion<float> comparison involving NaN values
        [Fact]
        public void QuaternionEqualsNanTest()
        {
            Quaternion<float> a = new Quaternion<float>(float.NaN, 0, 0, 0);
            Quaternion<float> b = new Quaternion<float>(0, float.NaN, 0, 0);
            Quaternion<float> c = new Quaternion<float>(0, 0, float.NaN, 0);
            Quaternion<float> d = new Quaternion<float>(0, 0, 0, float.NaN);

            Assert.False(a == new Quaternion<float>(0, 0, 0, 0));
            Assert.False(b == new Quaternion<float>(0, 0, 0, 0));
            Assert.False(c == new Quaternion<float>(0, 0, 0, 0));
            Assert.False(d == new Quaternion<float>(0, 0, 0, 0));

            Assert.True(a != new Quaternion<float>(0, 0, 0, 0));
            Assert.True(b != new Quaternion<float>(0, 0, 0, 0));
            Assert.True(c != new Quaternion<float>(0, 0, 0, 0));
            Assert.True(d != new Quaternion<float>(0, 0, 0, 0));

            Assert.False(a.Equals(new Quaternion<float>(0, 0, 0, 0)));
            Assert.False(b.Equals(new Quaternion<float>(0, 0, 0, 0)));
            Assert.False(c.Equals(new Quaternion<float>(0, 0, 0, 0)));
            Assert.False(d.Equals(new Quaternion<float>(0, 0, 0, 0)));

            Assert.False(a.IsIdentity);
            Assert.False(b.IsIdentity);
            Assert.False(c.IsIdentity);
            Assert.False(d.IsIdentity);

            // Counterintuitive result - IEEE rules for NaN comparison are weird!
            Assert.False(a.Equals(a));
            Assert.False(b.Equals(b));
            Assert.False(c.Equals(c));
            Assert.False(d.Equals(d));
        }

        // A test to make sure these types are blittable directly into GPU buffer memory layouts
        [Fact]
        public unsafe void QuaternionSizeofTest()
        {
            Assert.Equal(16, sizeof(Quaternion<float>));
            Assert.Equal(32, sizeof(Quaternion_2x));
            Assert.Equal(20, sizeof(QuaternionPlusFloat));
            Assert.Equal(40, sizeof(QuaternionPlusFloat_2x));
        }

        [StructLayout(LayoutKind.Sequential)]
        struct Quaternion_2x
        {
            private Quaternion<float> _a;
            private Quaternion<float> _b;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct QuaternionPlusFloat
        {
            private Quaternion<float> _v;
            private float _f;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct QuaternionPlusFloat_2x
        {
            private QuaternionPlusFloat _a;
            private QuaternionPlusFloat _b;
        }

        // A test to make sure the fields are laid out how we expect
        [Fact]
        public unsafe void QuaternionFieldOffsetTest()
        {
            Quaternion<float> quat = new Quaternion<float>();

            float* basePtr = &quat.X; // Take address of first element
            Quaternion<float>* quatPtr = &quat; // Take address of whole Quaternion<float>

            Assert.Equal(new IntPtr(basePtr), new IntPtr(quatPtr));

            Assert.Equal(new IntPtr(basePtr + 0), new IntPtr(&quat.X));
            Assert.Equal(new IntPtr(basePtr + 1), new IntPtr(&quat.Y));
            Assert.Equal(new IntPtr(basePtr + 2), new IntPtr(&quat.Z));
            Assert.Equal(new IntPtr(basePtr + 3), new IntPtr(&quat.W));
        }
    }
}
