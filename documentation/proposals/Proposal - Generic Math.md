# Summary
A new API for generic maths in Silk.NET.Maths 3.X, leveraging modern .NET features such as `INumber<T>` and vectorization.

This API aims to replace the existing implementation of Silk.NET.Maths.

# Contributors
- Maxine H (@uwx)
- Andrew Davis (@Curin)

# Current Status
- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [x] Approved
- [ ] Implemented

# Design Decisions
- This proposal should replace the 2.X implementation of `Silk.Net.Maths`, matching `System.Numerics` where possible, with concessions for design oversights in that api.
- This proposal assumes no knowledge of the 2.x Math library.
- Text herein marked **INFORMATIVE** does not form a normative part of this proposal, and is for background only.
- Within this proposal, the key words **must**, **required**, **shall**, **should**, **recommended**, **may**, **could**, and **optional** are to be interpreted as described in [RFC 2119 - Key words for use in RFCs to Indicate Requirement Levels](https://www.ietf.org/rfc/rfc2119.txt). The additional key word **optionally** is an alternate form of **optional**, for use where grammatically appropriate. These key words are highlighted in the proposal for clarity.
- If any of the APIs contained herein are later deemed mathematically invalid in the context of their exposing primitive (e.g. a specific operation being inappropriate for a specific sized matrix), the Silk.NET team reserves the right to remove them at their own accord.

# **INFORMATIVE** Integer and Floating Point Types
While investigating the use of generic math we came to the conclusion that making types which supports both integer and floating point types would not be optimal. This was discussed at length on the discord [here](https://discord.com/channels/521092042781229087/587346162802229298/1167705816812498974). Ultimately it was decided to provide both an integer and floating point variant for each vector type and every type built from them. These types are generic where `Vector2I<T>` will be a 2D vector which takes any binary integer type for `T`. Similarly `Vector2F<T>` will be a 2D vector which takes any floating point type for `T`. By extension we get types like `BoxI<T>` and `RectangleF<T>`. The integer types are granted the bitwise operators `&`, `~`, `|`, and `^`. Floating point types will include some operations that require certain functions unavailable to integer types like `Length` which requires `Sqrt`.

# I types versus F Types
Each type in this proposal, aside from `Quaternion`, ends in I or F, defining whether it is an integer type or floating point type. Integer types **must** use a generic type argument `T` with the constraint of `IBinaryInteger<T>`. On the other hand, floating point types **must** use a generic type argument `T` with the constraint of `IFloatingPointIeee754<T>`.

# Vector Types

The main types defined for this proposal are two sets of vector types, `VectorNI<T>` and `VectorNF<T>` where `N` defines the dimensionality of the vector between 2 and 4.

For each vector struct, the following requirements **must** fulfill the following requirements:
- Implements IEquatable with itself as the generic parameter
- Implements IReadonlyList with the components as the list elements
- Implements ISpanFormattable
- Implements ISpanParsable
- Implements IUtf8SpanFormattable
- Implements IUtf8SpanParsable
- Implements IParsable
- Implemetns IFormattable
- The relevant number of properties to represent the mathematical vector's components (X and Y for Vector2) and relevant unit vectors
- Constructors which take either a single parameter and uses it for every component, a parameter for each component, or a ReadOnlySpan of values which has the same number of elements as our vector has components.
- Constructors for 3 dimensions and up **must** include lower dimension variants that use the lower dimensions for their specific components (vector2 -> X,Y).
- A ref indexer that takes a int index and returns the corresponding component value (0 -> x, 1 -> y, etc.)
- An AsSpan function which returns this vector as a Span of the generic type
- A LengthSquared property which returns the dot product of the vector with itself.
- A Dot function which takes another vector and returns the dot product with our original vector. 
  - A static implementation of this function **must** be available as well.
- For 3D Vectors, a Cross function which takes another vector and returns the cross product with our original vector. 
  - A static implementation of this function **must** be available as well.
- `+`, `-`, `*`, `/`, and `%` operators defined between two vectors of the same type which returns a vector which has had each operation applied component-wise.
- `+`, `-`, `*`, `/`, and `%` operators defined between a vector and a scalar value that matches the generic type which returns a vector which has had each operation applied component-wise with the scalar value. Both vector first and scalar first should be implemented.
- A `-` unary operator which returns the negated vector.
- A `+` unary operator which returns the vector.
- Overrides ToString to show component values.
- Max and Min functions, which takes another vector and returns a new vector which component-wise has the Max or Min value, respectively.
  - A Static implementation of this function **must** be available as well.
- Max and Min functions, which takes a scalar value which matches the generic type and returns a new vector which component-wise has the Max or Min value with the scalar value, respectively.
  - A Static implementation of this function **must** be available as well.
- A Clamp function which takes a Max vector and a Min vector and returns a vector which has its components bounded between the Min and Max vectors.
  - A Static implementation of this function **must** be available as well.
- A Clamp function which takes a Max scalar and a Min scalar, both which match the generic type, and returns a vector which has its components bounded between the Min and Max scalars.
  - A Static implementation of this function **must** be available as well.
- An Abs function which returns a vector where each component is the absolute value of the original
  - A Static implementation of this function **must** be available as well.
- CopyTo functions which copy to an array or span, with or without a starting index
- Explicit cast and checked cast operators to all standard variants of the F and I vector types of the same dimensionality
- Explicit cast and checked cast to and from matching System.Numerics vector type
- Explicit cast cast to lower dimensional matching vector with matching generic type
- A CopySign function which takes a vector and copies the signs component-wise to our vector
  - A Static implementation of this function **must** be available but it should return a new vector without affecting the original
- A Copy sign function which takes a scalar which matches the generic type, and copies the scalars sign onto each component of the vector
  - A Static implementation of this function **must** be available but it should return a new vector without affecting the original
- A Sign function which returns a vector where each component is only the sign segment of the original vector
  - A Static implementation of this function **must** be available
- Static Unit Vectors for each component
- A Static Zero Vector with zero for all components
- A Static One Vector with one for all components
- A static AllBitsSet Vector with all bits set for all components
- Define static CreateChecked, CreateSaturating, and CreateTruncating which converts other vector types to this type
  - Try variants of these methods should also be defined which out the resulting vector and return a bool representing success or failure of the operation.
- Define Transform functions which take a Matrix of higher dimensionality assuming 1 in for the final missing component and 0 for the rest (Vector 2 can use Matrix2xn, Matrix3xn, and matrix4xn) and return a vector containing the output (type should match the outer type e.g. Vector2.Transform(Matrix4x4) returns Vector2)
  - A Static implementation of these functions **must** be available
- Define VectorN\<T\> `*` MatrixNxM operators where N is the same for both Vector and Matrix, but M is any number
  - These operators should function like Transform, but without needed assumptions
- Define TransformNormal functions which take a Matrix of higher dimensionality assuming 0 in for all missing components (Vector 2 can use Matrix2xn, Matrix3xn, and matrix4xn) and return a vector containing the output (type should match the outer type e.g. Vector2.Transform(Matrix4x4) returns Vector2)
  - A Static implementation of these functions **must** be available

For I types, the following additional requirements **must** be fulfilled:
- the bitwise `&`, `|`, and `^` operators defined between two vectors which returns a vector which has had these operators applied on a component-wise basis.
- the bitwise `&`, `|`, and `^` operators defined between a vectors and a scalar value that matches the generic type which returns a vector which has had these operators applied on a component-wise basis with the scalar.
- the unary bitwise `~` operator defined which negates the bits of the vector components.
- Define the following static functions for these types to match IBinaryInteger (Vector replaced with type, e.g. `Vector2I<T>`) which returns a new vector with these operations applied component-wise, unless otherwise specified:
  - Log2(Vector x)
  - DivRem(Vector left, Vector right)
    - Returns tuple of 2 Vectors (Vector Quotient, Vector Remainder)
  - PopCount(Vector x)
    - returns The number of set bits in the vector

For F types, the following additional requirements **must** be fulfilled:
- A Length property which returns the square root of LengthSquared.
- A Normalize function which divides all components by the length of the vector
  - A static implementation of this function **must** be available but it should return a normalized vector without affecting the original vector
- A static Lerp function which takes Two vectors to interpolate between and a vector representing the t value for each component, and returns a vector which components are linearly interpolated between the original two vectors based on the respective t values.
  - A clamped version of this function **must** also be available which clamps the t-values between 0 and 1
- A static Lerp function which takes Two vectors and a scalar value which matches the generic type, and returns a vector which is linearly interpolated between the two vectors using the scalar as the t value.
  - A clamped version of this function **must** also be available which clamps the t-values between 0 and 1
- A Reflect Function which takes a normal vector and reflects the vector over the normal
  - A Static implemenation of this function **must** be available as well, but should return the reflected vector without affecting the original vector.
- The following static Vector properties which have the given value for all components
  - PositiveInfinity
  - NegativeInfinity
  - NaN
  - Epsilon
  - NegativeZero
  - Pi
  - Tau
  - E
- Define the following static functions for these types to match IBinaryFloatingPointIeee754 (Vector replaced with type, e.g. `Vector2F<T>`) which returns a new vector with these operations applied component-wise, unless otherwise specified:
  - Sqrt(Vector x)
  - Acosh(Vector x)
  - Asinh(Vector x)
  - Atanh(Vector x)
  - Cosh(Vector x)
  - Sinh(Vector x)
  - Tanh(Vector x)
  - Acos(Vector x)
  - AcosPi(Vector x)
  - Asin(Vector x)
  - AsinPi(Vector x)
  - Atan(Vector x)
  - AtanPi(Vector x)
  - Cos(Vector x)
  - CosPi(Vector x)
  - Sin(Vector x)
  - SinPi(Vector x)
  - Tan(Vector x)
  - TanPi(Vector x)
  - DegreesToRadians(Vector degrees)
  - RadiansToDegrees(Vector radians)
  - SinCos(Vector x)
    - Returns a tuple of 2 Vectors (Sin, Cos)
  - SinCosPi(Vector x)
    - Returns a tuple of 2 Vectors (SinPi, CosPi)
  - Log(Vector x)
  - Log(Vector x, Vector newBase)
  - Log(Vector x, TScalar newBase)
  - LogP1(Vector x)
  - Log2(Vector x)
  - Log2P1(Vector x)
  - Log10(Vector x)
  - Log10P1(Vector x)
  - Exp(Vector x)
  - ExpM1(Vector x)
  - Exp2(Vector x)
  - Exp2M1(Vector x)
  - Exp10(Vector x)
  - Exp10M1(Vector x)
  - Pow(Vector x, Vector y)
  - Pow(Vector x, TScalar y)
  - Cbrt(Vector x)
  - Hypot(Vector x, Vector y)
  - Hypot(Vector x, TScalar y)
  - RootN(Vector x, int n)
  - Round(Vector x)
  - Round(Vector x, int digits)
  - Round(Vector x, MidpointRounding mode)
  - Round(Vector x, int digits, MidpointRounding mode)
  - Truncate(Vector x)
  - Atan2(Vector x, Vector y)
  - Atan2Pi(Vector x, Vector y)
  - Atan2(Vector x, TScalar y)
  - Atan2Pi(Vector x, TScalar y)
  - BitDecrement(Vector x)
  - BitIncrement(Vector x)
  - FusedMultiplyAdd(Vector left, Vector right, Vector addend)
  - FusedMultiplyAdd(Vector left, Vector right, TScalar addend)
  - FusedMultiplyAdd(Vector left, TScalar right, Vector addend)
  - FusedMultiplyAdd(Vector left, TScalar right, TScalar addend)
  - ReciprocalEstimate(Vector x)
  - ReciprocalSqrtEstimate(Vector x)
  - ILogB(Vector x)
    - Returns VectorNI\<T\>, where N matches the dimensionality of the vector
    - **INFORMATIVE** This may require multiple methods depending on implementation
  - ScaleB(Vector x, VectorNI\<int\> n)
  - ScaleB(Vector x, int n)
  - RoundToInt(Vector x)
    - Returns `VectorNI`, where N matches the dimensionality of the vector
    - **INFORMATIVE** This may require multiple methods depending on implementation
  - FloorToInt(Vector x)
    - Returns `VectorNI`, where N matches the dimensionality of the vector
    - **INFORMATIVE** This may require multiple methods depending on implementation
  - CeilingToInt(Vector x)
    - Returns `VectorNI`, where N matches the dimensionality of the vector
    - **INFORMATIVE** This may require multiple methods depending on implementation
  - ToVector64(Vector x)
    - Returns `System.Runtime.Intrinsics.Vector64<TScalar>`
  - ToVector128(Vector x)
    - Returns `System.Runtime.Intrinsics.Vector128<TScalar>`
  - ToVector256(Vector x)
    - Returns `System.Runtime.Intrinsics.Vector256<TScalar>`
  - ToVector512(Vector x)
    - Returns `System.Runtime.Intrinsics.Vector512<TScalar>`

# Matrix Types

This proposal includes the following matrix types:
- Matrix2x2F
- Matrix2x2I
- Matrix2x3F
- Matrix2x3I
- Matrix2x4F
- Matrix2x4I
- Matrix3x2F
- Matrix3x2I
- Matrix3x3F
- Matrix3x3I
- Matrix3x4F
- Matrix3x4I
- Matrix4x2F
- Matrix4x2I
- Matrix4x3F
- Matrix4x3I
- Matrix4x4F
- Matrix4x4I
- Matrix5x4F
- Matrix5x4I

Integer Variants do not require any functions which interact with Quaternions

Matrix structs **must** fulfill the following requirements:
- Fulfills `IEquatable<T>` where `T` is the same matrix class
- Stored in row major format
- F matricies work with F vectors, and I Matricies work with I vectors
- Both row vectors and individual values (M11, etc.) accessible via properties
- A ref indexer that takes row and column indicies and outputs the value
- Add, subtract, and multiply operators defined with Matricies of the same size
- Multiply operators defined with compatible matricies, if the output matrix type already exists (AxB * BxC = AxC)
- Negate Operator defined
- Implicit conversion to and from the System.Numerics matrix type, if available
- Invert function for square matricies
- GetDeterminant function for square matricies and Matrix3x2, Matrix4x3, and Matrix 5x4
- Transpose function
- static lerp function
- static identity property
- For Matrix3x2, Matrix3x3, Matrix4x3, and Matrix4x4 include the following static functions
  - CreateBillboardRH
  - CreateBillboardLH
  - CreateRotation
    - 3x3, 4x3, and 4x4 Matricies get X, Y, and Z variants for this function instead
  - CreateTranslation
  - CreateScale
  - Decompose (separate out any transformations)
- For Matrix3x2 include a CreateSkew static function
- For Matrix3x3, Matrix4x3, and Matrix4x4 include the following static functions
  - CreateFromAxisAngle
  - CreateFromQuaternion
  - Transform
    - from a Quaternion
  - CreateFromYawPitchRoll
- For Matrix4x3 and Matrix4x4 include the following static functions
  - CreateConstrainedBillboardLH
  - CreateConstrainedBillboardRH
  - CreateLookAtLH
  - CreateLookToLH
  - CreateOrthographicLH
  - CreateOrthographicOffCenterLH
  - CreatePerspectiveLH
  - CreatePerspectiveFieldOfViewLH
  - CreatePerspectiveOffCenterLH
  - CreateLookAtRH
  - CreateLookToRH
  - CreateOrthographicRH
  - CreateOrthographicOffCenterRH
  - CreatePerspectiveRH
  - CreatePerspectiveFieldOfViewRH
  - CreatePerspectiveOffCenterRH
  - CreateReflection
  - CreateWorld
  - CreateViewport

# Quaternion

A Quaternion struct **must** be defined and match the following requirements:
- A generic struct with a type parameter `T` which is constrained by `IBinaryFloatingPointIeee754<T>` representing the scalar type
- Implements IEquatable with itself
- Contain 4 scalar properties (X, Y, Z, W)
- Define a Constructor taking 4 scalar values matching the properties
- Define a Constructor taking a Vector3F\<T\> and a Scalar, with the vector 3 mapping to X, Y, Z and the Scalar to the W
- Define a Constructor taking a Vector4F\<T\>
- A Vector3F\<T\> Axis property mapping to (X, Y, Z)
- A T Angle property mapping to 2 * Acos(W)
- A ref Indexer which takes an int and returns the components in order
- An AsSpan function which returns this quaternion as a Span of the generic type
- An IsIdentity property which returns if this Quaternion matches an Identity Quaternion
- Define `+`, `-`, `*`, and `/` between two Quaternions
- Define `*` with `T` multiplying each component by the scalar value returning a new quaternion
- Define unary `~`
- A Dot function which takes another Quaternion and returns its the dotproduct between them
  - A static implementation of this function **must** be available
- A LengthSquared property which returns the dot product of the quaternion with itself
- A Length property which returns the Square Root of LengthSquared
- An Invert function inverts the Quaternion
  - a static Inverse function **must** be available but it returns the inverse rather than affecting the original
- A Normalize function which normalizes the Quaternion
  - A static implemenation of this function must be available but returns the normalized Quaternion rather than affecting the original
- A Concatenate function which takes another Quaternion and concatenates it with this quaternion
  - A static implementation of this function **must** be available but it returns a new Quaternion rather than affecting the originals
- A Conjugate function which returns the conjugate of this quaternion
  - A static implementation of this function **must** be available
- A static CreateFromAxisAngle function which takes in a Vector3F\<T\> and an angle and returns a Quaternion representing that rotation
- A static CreateFromRotationMatrix function which takes either a Matrix3x3 or Matrix4x4 and returns a Quaternion representing that rotation
- A static CreateFromYawPitchRoll which takes either each components separately or in a Vector3F\<T\> and outputs a Quaternion representing that rotation
- A static Lerp function which takes 2 Quaternions and a Scalar matching the generic type which linearly interpolates between the 2 Quaternions with scalar used as the amount to lerp
- A static SLerp function which takes 2 Quaternions and a Scalar matching the generic type which Spherical linearly interpolates between the 2 Quaternions with scalar used as the amount to lerp
- A static Zero Quaternion Property
- A static Identity Quaternion Property

# Geometric Types

The following Geometric Types are defined:
- BoxF
- BoxI
- CircleF
- CircleI
- PlaneF
- PlaneI
- Ray2F
- Ray2I
- Ray3F
- Ray3I
- RectangleF
- RectangleI
- SphereF
- SphereI

Each type **must** include the following:
- Intersect functions with both another instance of the type and a point
- GetDistanceToNearest(Point,Edge,etc) functions **must** be available for a given point
- For all but the rays and planes, GetInflated function that takes a point and returns the scaled object that is closest to the original and contains the given point
- Include Scale and Translation transformation functions
- For Box and Rectangle the following Vector properties **must** be defined
  - Min
  - Max
  - Center
  - Size
- For Planes and Rays, Normalize functions
- For Planes include the following static functions
  - CreateFromVerticies
  - CreateFromPointNormal
  - Dot
    - with a Vector4
  - DotCoordinate and DotNormal
    - with a Vector3
  - Transform
    - With a Matrix4x4 or Quaternion, if relevant

# Meeting Notes 

## 19/11/2023

[Video](https://www.youtube.com/live/yXNDZDE3AHE?feature=shared&t=9444)

- We agree with the addition to add scalar operations over vectors (i.e. Vector4\<T\> * T does X*T, Y*T, ...)
- Add an analyser for encouraging the most correct and most efficient type instead of using sub-optimal types. 
- Ensure we've documented that.
- Vector * Matrix?
    - assuming row major, not allowing matrix * vector (only vector * matrix)
    - does it make sense to just do it the way game engines do it and the way 2.0 does it?
    - possibly technically invalid mathematically, even if common programmatically.
    - easy to hit corner case that not all users may understand.
- Ensuring we have no upcasting and downcasting operators that could have unexpected behaviour.
- System.Numerics is strictly right hand, which is the same as XNA and somewhat default for OpenGL users. This differs with DirectX that is typically left hand.
    - Happy with having explicit LH and RH functions.
- Missing matrix APIs that were added in .NET 8 to System.Numerics
    - CreateLookTo (additional to CreateLookAt)
    - CreateViewport
    - CreateBillboardLH
    - CreateConstrainedBillboardLH
    - CreateBillboardRH
    - CreateConstrainedBillboardRH
- Investigate newer less-hated alternatives to quaternions for future (see Freya Holmer talks)
- Possibly have a general Transform struct in the future?
- Rectangles and boxes are obscured with regards to internal layout, bindings to have interchange types that implicitly cast to the mathematical constructs that are represented by the Box/Rectangle types.
- Investigate in the future if we can either add an Origin property for compatibility or an analyser for users to know that Min is the new Origin.
- Approved notwithstanding the missing APIs.
