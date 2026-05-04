// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix3X3{T}"/>
    /// </summary>
    public static partial class Matrix3X3
    {
        private const float BillboardEpsilon = 1e-4f;
        private const float DecomposeEpsilon = 0.0001f;

        /*
        private struct CanonicalBasis<T>
            where T : INumberBase<T>
        {
            public Vector3D<T> Row0;
            public Vector3D<T> Row1;
            public Vector3D<T> Row2;
        };

        private struct VectorBasis<T>
            where T : INumberBase<T>
        {
#pragma warning disable 649
            public unsafe Vector3D<T>* Element0;
            public unsafe Vector3D<T>* Element1;
            public unsafe Vector3D<T>* Element2;
#pragma warning restore 649
        }
        */

        /// <summary>Creates a spherical billboard that rotates around a specified object position.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="cameraUpVector">The up vector of the camera.</param>
        /// <param name="cameraForwardVector">The forward vector of the camera.</param>
        /// <returns>The created billboard matrix</returns>
        public static Matrix3X3<T> CreateBillboard<T>(Vector3D<T> objectPosition, Vector3D<T> cameraPosition, Vector3D<T> cameraUpVector, Vector3D<T> cameraForwardVector)
            where T : INumber<T>, IRootFunctions<T>
        {
            Vector3D<T> zaxis = objectPosition - cameraPosition;
            var norm = zaxis.LengthSquared;

            if (!(norm >= T.CreateTruncating(BillboardEpsilon)))
            {
                zaxis = -cameraForwardVector;
            }
            else
            {
                zaxis = Vector3D.Multiply(zaxis, T.One / T.Sqrt(norm));
            }

            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(cameraUpVector, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            return new(xaxis, yaxis, zaxis);
        }

        /// <summary>Creates a matrix that rotates around an arbitrary vector.</summary>
        /// <param name="axis">The axis to rotate around.</param>
        /// <param name="angle">The angle to rotate around the given axis, in radians.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3X3<T> CreateFromAxisAngle<T>(Vector3D<T> axis, T angle)
            where T : ITrigonometricFunctions<T>
        {
            // a: angle
            // x, y, z: unit vector for axis.
            //
            // Rotation matrix M can compute by using below equation.
            //
            //        T               T
            //  M = uu + (cos a)( I-uu ) + (sin a)S
            //
            // Where:
            //
            //  u = ( x, y, z )
            //
            //      [  0 -z  y ]
            //  S = [  z  0 -x ]
            //      [ -y  x  0 ]
            //
            //      [ 1 0 0 ]
            //  I = [ 0 1 0 ]
            //      [ 0 0 1 ]
            //
            //
            //     [  xx+cosa*(1-xx)   yx-cosa*yx-sina*z zx-cosa*xz+sina*y ]
            // M = [ xy-cosa*yx+sina*z    yy+cosa(1-yy)  yz-cosa*yz-sina*x ]
            //     [ zx-cosa*zx-sina*y zy-cosa*zy+sina*x   zz+cosa*(1-zz)  ]
            //
            T x = axis.X, y = axis.Y, z = axis.Z;
            T sa = T.Sin(angle), ca = T.Cos(angle);
            T xx = x * x, yy = y * y, zz = z * z;
            T xy = x * y, xz = x * z, yz = y * z;

            Matrix3X3<T> result = Matrix3X3<T>.Identity;

            result.M11 = xx + (ca * (T.One - xx));
            result.M12 = xy - (ca * xy) + (sa * z);
            result.M13 = xz - (ca * xz) - (sa * y);

            result.M21 = xy - (ca * xy) - (sa * z);
            result.M22 = yy + (ca * (T.One - yy));
            result.M23 = yz - (ca * yz) + (sa * x);

            result.M31 = xz - (ca * xz) + (sa * y);
            result.M32 = yz - (ca * yz) - (sa * x);
            result.M33 = zz + (ca * (T.One - zz));

            return result;
        }

        /// <summary>Creates a rotation matrix from the given Quaternion rotation value.</summary>
        /// <param name="quaternion">The source Quaternion.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3X3<T> CreateFromQuaternion<T>(Quaternion<T> quaternion)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            Matrix3X3<T> result = Matrix3X3<T>.Identity;

            T xx = quaternion.X * quaternion.X;
            T yy = quaternion.Y * quaternion.Y;
            T zz = quaternion.Z * quaternion.Z;

            T xy = quaternion.X * quaternion.Y;
            T wz = quaternion.Z * quaternion.W;
            T xz = quaternion.Z * quaternion.X;
            T wy = quaternion.Y * quaternion.W;
            T yz = quaternion.Y * quaternion.Z;
            T wx = quaternion.X * quaternion.W;

            result.M11 = T.One - (T.CreateTruncating(2) * (yy + zz));
            result.M12 = T.CreateTruncating(2) * (xy + wz);
            result.M13 = T.CreateTruncating(2) * (xz - wy);

            result.M21 = T.CreateTruncating(2) * (xy - wz);
            result.M22 = T.One - (T.CreateTruncating(2) * (zz + xx));
            result.M23 = T.CreateTruncating(2) * (yz + wx);

            result.M31 = T.CreateTruncating(2) * (xz + wy);
            result.M32 = T.CreateTruncating(2) * (yz - wx);
            result.M33 = T.One - (T.CreateTruncating(2) * (yy + xx));

            return result;
        }


        /// <summary>Creates a rotation matrix from the specified yaw, pitch, and roll.</summary>
        /// <param name="yaw">Angle of rotation, in radians, around the Y-axis.</param>
        /// <param name="pitch">Angle of rotation, in radians, around the X-axis.</param>
        /// <param name="roll">Angle of rotation, in radians, around the Z-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3X3<T> CreateFromYawPitchRoll<T>(T yaw, T pitch, T roll)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            var q = Quaternion<T>.CreateFromYawPitchRoll(yaw, pitch, roll);
            return CreateFromQuaternion(q);
        }

        /// <summary>Creates a matrix for rotating points around the X-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the X-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3X3<T> CreateRotationX<T>(T radians)
            where T : ITrigonometricFunctions<T>
        {
            Matrix3X3<T> result = Matrix3X3<T>.Identity;

            T c = T.Cos(radians);
            T s = T.Sin(radians);

            // [  1  0  0  0 ]
            // [  0  c  s  0 ]
            // [  0 -s  c  0 ]
            // [  0  0  0  1 ]

            result.M22 = c;
            result.M23 = s;
            result.M32 = -s;
            result.M33 = c;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Y-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Y-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3X3<T> CreateRotationY<T>(T radians)
            where T : ITrigonometricFunctions<T>
        {
            Matrix3X3<T> result = Matrix3X3<T>.Identity;

            T c = T.Cos(radians);
            T s = T.Sin(radians);

            // [  c  0 -s  0 ]
            // [  0  1  0  0 ]
            // [  s  0  c  0 ]
            // [  0  0  0  1 ]
            result.M11 = c;
            result.M13 = -s;
            result.M31 = s;
            result.M33 = c;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Z-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Z-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3X3<T> CreateRotationZ<T>(T radians)
            where T : ITrigonometricFunctions<T>
        {
            Matrix3X3<T> result = Matrix3X3<T>.Identity;

            T c = T.Cos(radians);
            T s = T.Sin(radians);

            // [  c  s  0  0 ]
            // [ -s  c  0  0 ]
            // [  0  0  1  0 ]
            // [  0  0  0  1 ]
            result.M11 = c;
            result.M12 = s;
            result.M21 = -s;
            result.M22 = c;

            return result;
        }

        /// <summary>Creates a scaling matrix.</summary>
        /// <param name="xScale">Value to scale by on the X-axis.</param>
        /// <param name="yScale">Value to scale by on the Y-axis.</param>
        /// <param name="zScale">Value to scale by on the Z-axis.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix3X3<T> CreateScale<T>(T xScale, T yScale, T zScale)
            where T : INumberBase<T>
        {
            Matrix3X3<T> result = Matrix3X3<T>.Identity;
            result.M11 = xScale;
            result.M22 = yScale;
            result.M33 = zScale;
            return result;
        }

        /// <summary>Creates a scaling matrix.</summary>
        /// <param name="scales">The vector containing the amount to scale by on each axis.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix3X3<T> CreateScale<T>(Vector3D<T> scales)
            where T : INumberBase<T>
        {
            Matrix3X3<T> result = Matrix3X3<T>.Identity;
            result.M11 = scales.X;
            result.M22 = scales.Y;
            result.M33 = scales.Z;
            return result;
        }

        /// <summary>Creates a uniform scaling matrix that scales equally on each axis.</summary>
        /// <param name="scale">The uniform scaling factor.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix3X3<T> CreateScale<T>(T scale)
            where T : INumberBase<T>
        {
            Matrix3X3<T> result = Matrix3X3<T>.Identity;

            result.M11 = scale;
            result.M22 = scale;
            result.M33 = scale;

            return result;
        }

        /*
        /// <summary>Attempts to extract the scale, translation, and rotation components from the given scale/rotation/translation matrix.
        /// If successful, the out parameters will contained the extracted values.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <param name="scale">The scaling component of the transformation matrix.</param>
        /// <param name="rotation">The rotation component of the transformation matrix.</param>
        /// <returns><c>true</c> if the source matrix was successfully decomposed; <c>false</c> otherwise.</returns>
        public static bool Decompose<T>(Matrix3X3<T> matrix, out Vector3D<T> scale, out Silk.NET.Maths.Legacy.Quaternion<T> rotation)
            where T : INumberBase<T>
        {
            bool result = true;

            unsafe
            {
                fixed (Vector3D<T>* scaleBase = &scale)
                {
                    T* pfScales = (T*) scaleBase;
                    T det;

                    VectorBasis<T> vectorBasis;
                    Vector3D<T>** pVectorBasis = (Vector3D<T>**) &vectorBasis;

                    Matrix3X3<T> matTemp = Matrix3X3<T>.Identity;
                    CanonicalBasis<T> canonicalBasis = default;
                    Vector3D<T>* pCanonicalBasis = &canonicalBasis.Row0;

                    canonicalBasis.Row0 = new Vector3D<T>(T.One, T.Zero, T.Zero);
                    canonicalBasis.Row1 = new Vector3D<T>(T.Zero, T.One, T.Zero);
                    canonicalBasis.Row2 = new Vector3D<T>(T.Zero, T.Zero, T.One);

                    pVectorBasis[0] = &matTemp.Row1;
                    pVectorBasis[1] = &matTemp.Row2;
                    pVectorBasis[2] = &matTemp.Row3;

                    *pVectorBasis[0] = new Vector3D<T>(matrix.M11, matrix.M12, matrix.M13);
                    *pVectorBasis[1] = new Vector3D<T>(matrix.M21, matrix.M22, matrix.M23);
                    *pVectorBasis[2] = new Vector3D<T>(matrix.M31, matrix.M32, matrix.M33);

                    scale.X = pVectorBasis[0]->Length;
                    scale.Y = pVectorBasis[1]->Length;
                    scale.Z = pVectorBasis[2]->Length;

                    uint a, b, c;
                    #region Ranking
                    T x = pfScales[0], y = pfScales[1], z = pfScales[2];
                    if (!(x >= y))
                    {
                        if (!(y >= z))
                        {
                            a = 2;
                            b = 1;
                            c = 0;
                        }
                        else
                        {
                            a = 1;

                            if (!(x >= z))
                            {
                                b = 2;
                                c = 0;
                            }
                            else
                            {
                                b = 0;
                                c = 2;
                            }
                        }
                    }
                    else
                    {
                        if (!(x >= z))
                        {
                            a = 2;
                            b = 0;
                            c = 1;
                        }
                        else
                        {
                            a = 0;

                            if (!(y >= z))
                            {
                                b = 2;
                                c = 1;
                            }
                            else
                            {
                                b = 1;
                                c = 2;
                            }
                        }
                    }
                    #endregion

                    if (!(pfScales[a] >= T.CreateTruncating(DecomposeEpsilon)))
                    {
                        *(pVectorBasis[a]) = pCanonicalBasis[a];
                    }

                    *pVectorBasis[a] = Vector3D.Normalize(*pVectorBasis[a]);

                    if (!(pfScales[b] >= T.CreateTruncating(DecomposeEpsilon)))
                    {
                        uint cc;
                        T fAbsX, fAbsY, fAbsZ;

                        fAbsX = T.Abs(pVectorBasis[a]->X);
                        fAbsY = T.Abs(pVectorBasis[a]->Y);
                        fAbsZ = T.Abs(pVectorBasis[a]->Z);

                        #region Ranking
                        if (!(fAbsX >= fAbsY))
                        {
                            if (!(fAbsY >= fAbsZ))
                            {
                                cc = 0;
                            }
                            else
                            {
                                if (!(fAbsX >= fAbsZ))
                                {
                                    cc = 0;
                                }
                                else
                                {
                                    cc = 2;
                                }
                            }
                        }
                        else
                        {
                            if (!(fAbsX >= fAbsZ))
                            {
                                cc = 1;
                            }
                            else
                            {
                                if (!(fAbsY >= fAbsZ))
                                {
                                    cc = 1;
                                }
                                else
                                {
                                    cc = 2;
                                }
                            }
                        }
                        #endregion

                        *pVectorBasis[b] = Vector3D.Cross(*pVectorBasis[a], *(pCanonicalBasis + cc));
                    }

                    *pVectorBasis[b] = Vector3D.Normalize(*pVectorBasis[b]);

                    if (!(pfScales[c] >= T.CreateTruncating(DecomposeEpsilon)))
                    {
                        *pVectorBasis[c] = Vector3D.Cross(*pVectorBasis[a], *pVectorBasis[b]);
                    }

                    *pVectorBasis[c] = Vector3D.Normalize(*pVectorBasis[c]);

                    det = matTemp.GetDeterminant();

                    // use Kramer's rule to check for handedness of coordinate system
                    if (!(det >= T.Zero))
                    {
                        // switch coordinate system by negating the scale and inverting the basis vector on the x-axis
                        pfScales[a] = -pfScales[a];
                        *pVectorBasis[a] = -(*pVectorBasis[a]);

                        det = -det;
                    }

                    det = det - T.One;
                    det = det * det;

                    if (!(T.CreateTruncating(DecomposeEpsilon) >= det))
                    {
                        // Non-SRT matrix encountered
                        rotation = Legacy.Quaternion<T>.Identity;
                        result = false;
                    }
                    else
                    {
                        // generate the quaternion from the matrix
                        rotation = Legacy.Quaternion<T>.CreateFromRotationMatrix(matTemp);
                    }
                }
            }

            return result;
        }
        */

        /// <summary>Transforms the given matrix by applying the given Quaternion rotation.</summary>
        /// <param name="value">The source matrix to transform.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed matrix.</returns>
        public static Matrix3X3<T> Transform<T>(Matrix3X3<T> value, Quaternion<T> rotation)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            // Compute rotation matrix.
            T x2 = rotation.X + rotation.X;
            T y2 = rotation.Y + rotation.Y;
            T z2 = rotation.Z + rotation.Z;

            T wx2 = rotation.W * x2;
            T wy2 = rotation.W * y2;
            T wz2 = rotation.W * z2;
            T xx2 = rotation.X * x2;
            T xy2 = rotation.X * y2;
            T xz2 = rotation.X * z2;
            T yy2 = rotation.Y * y2;
            T yz2 = rotation.Y * z2;
            T zz2 = rotation.Z * z2;

            T q11 = T.One - yy2 - zz2;
            T q21 = xy2 - wz2;
            T q31 = xz2 + wy2;

            T q12 = xy2 + wz2;
            T q22 = T.One - xx2 - zz2;
            T q32 = yz2 - wx2;

            T q13 = xz2 - wy2;
            T q23 = yz2 + wx2;
            T q33 = T.One - xx2 - yy2;

            var q1 = new Vector3D<T>(q11, q12, q13);
            var q2 = new Vector3D<T>(q21, q22, q23);
            var q3 = new Vector3D<T>(q31, q32, q33);

            return new((value.M11 * q1) + (value.M12 * q2) + (value.M13 * q3), (value.M21 * q1) + (value.M22 * q2) + (value.M23 * q3), (value.M31 * q1) + (value.M32 * q2) + (value.M33 * q3));
        }

        /// <summary>Transposes the rows and columns of a matrix.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <returns>The transposed matrix.</returns>
        public static Matrix3X3<T> Transpose<T>(Matrix3X3<T> matrix)
            where T : INumberBase<T>
        {
            return new(matrix.Column1, matrix.Column2, matrix.Column3);
        }
    }
}
