# Summary
A new API for generic maths in Silk.NET.Maths 3.X, leveraging modern .NET features such as `INumber<T>` and vectorization.

This API aims to replace the existing implementation of Silk.NET.Maths.

# Contributors
- Maxine H (@uwx)
- Andrew Davis (@Curin)
- John Gietzen (@otac0n)

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
- Any static or extension method defined here must be provided in a non-generic class with the same name as the generic type it operates on.

# Vector Types

The main types defined for this proposal are the vector types, `VectorND<T>` where `N` defines the dimensionality of the vector between 2 and 4.

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
- A LengthSquared extension property which returns the dot product of the vector with itself.
- A Length extension property which returns the magnitued of the vector when the type `T` defines `IRootFunctions<T>`.
- A Dot static method which takes another vector and returns the dot product with our original vector. 
- For 3D Vectors, a Cross static method which takes another vector and returns the cross product with our original vector. 
- `+`, `-`, `*`, `/`, and `%` operators defined between two vectors of the same type which returns a vector which has had each operation applied component-wise.
- `+`, `-`, `*`, `/`, and `%` operators defined between a vector and a scalar value that matches the generic type which returns a vector which has had each operation applied component-wise with the scalar value. Both vector first and scalar first should be implemented.
- A `-` unary operator which returns the negated vector.
- A `+` unary operator which returns the vector.
- Overrides ToString to show component values.
- CopyTo functions which copy to an array or span, with or without a starting index
- Explicit cast and checked cast operators to all builtin type parameter variants of the vector types of the same dimensionality. (e.g. from `Vector2D<T>` to `Vector2D<float>`)
- Explicit cast and checked cast to and from matching System.Numerics vector type
- Explicit cast cast to lower dimensional matching vector with matching generic type
- Static Unit Vectors for each component
- A Static Zero Vector with zero for all components
- A Static One Vector with one for all components
- A static AllBitsSet Vector with all bits set for all components
- A deconstruct method for detupling
- An implicit conversion from a value tuple of the same size.
- Define static CreateChecked, CreateSaturating, and CreateTruncating which converts other vector types to this type
  - Try variants of these methods should also be defined which out the resulting vector and return a bool representing success or failure of the operation.
- Define Transform static methods which take a Matrix of higher dimensionality assuming 1 in for the final missing component and 0 for the rest (Vector 2 can use `Matrix2Xn`, `Matrix3Xn`, and `Matrix4Xn`) and return a vector containing the output (type should match the outer type e.g. `Vector2D.Transform(Matrix4X4)` returns `Vector2D`)
- Define `VectorND<T> * MatrixNXM` operators where N is the same for both Vector and Matrix, but M is any number
  - These operators should function like Transform, but without needed assumptions
- Define TransformNormal static methods which take a Matrix of higher dimensionality assuming 0 in for all missing components (Vector 2 can use `Matrix2Xn`, `Matrix3Xn`, and `Matrix4Xn`) and return a vector containing the output (type should match the outer type e.g. `Vector2D.Transform(Matrix4X4)` returns `Vector2D`)
- For types implementing `IBinaryNumber<T>`
    - `BitwiseAnd`, `BitwiseOr`, and `BitwiseXor` static methods defined between two vectors which returns a vector which has had these operators applied on a component-wise basis.
    - `BitwiseAnd`, `BitwiseOr`, and `BitwiseXor` static methods operators defined between a vectors and a scalar value that matches the generic type which returns a vector which has had these operators applied on a component-wise basis with the scalar.
    - `BitwiseNot` static method defined which negates the bits of the vector components. (BitwiseComplement?)
- A Normalize extension method which divides all components by the length of the vector, when `T` implements `IRootFunctions<T>`
- A Reflect static method which takes a normal vector and reflects the vector over the normal
- The following static Vector properties which have the given value for all components
  - PositiveInfinity
  - NegativeInfinity
  - NaN
  - Epsilon
  - NegativeZero
  - Pi
  - Tau
  - E
- Define the following static methods for these types which calls the specified function and returns a new vector with the specified multiplicity:
  - `INumber<>.Sign`, (Memberwise)
    - Returns `VectorND<int>`, where N matches the dimensionality of the vector
  - `INumber<>.Max`, (Memberwise, Memberwise)
  - `INumber<>.Max`, (Memberwise, Scalar)
  - `INumber<>.MaxNumber`, (Memberwise, Memberwise)
  - `INumber<>.MaxNumber`, (Memberwise, Scalar)
  - `INumber<>.Min`, (Memberwise, Memberwise)
  - `INumber<>.Min`, (Memberwise, Scalar)
  - `INumber<>.MinNumber`, (Memberwise, Memberwise)
  - `INumber<>.MinNumber`, (Memberwise, Scalar)
  - `INumber<>.Clamp`, (Memberwise, Memberwise, Memberwise)
  - `INumber<>.Clamp`, (Memberwise, Scalar, Scalar)
  - `INumber<>.CopySign`, (Memberwise, Memberwise)
  - `INumber<>.CopySign`, (Memberwise, Scalar)
  - `INumberBase<>.Abs`, (Memberwise)
  - `INumberBase<>.MaxMagnitude`, (Memberwise, Memberwise)
  - `INumberBase<>.MaxMagnitudeNumber`, (Memberwise, Memberwise)
  - `INumberBase<>.MinMagnitude`, (Memberwise, Memberwise)
  - `INumberBase<>.MinMagnitudeNumber`, (Memberwise, Memberwise)
  - `INumberBase<>.MultiplyAddEstimate`, (Memberwise, Memberwise, Memberwise)
  - `INumberBase<>.MultiplyAddEstimate`, (Memberwise, Memberwise, Scalar)
  - `INumberBase<>.MultiplyAddEstimate`, (Memberwise, Scalar, Memberwise)
  - `INumberBase<>.MultiplyAddEstimate`, (Memberwise, Scalar, Scalar)
  - `IBinaryNumber<>.Log2`, (Memberwise)
  - `IBinaryInteger<>.DivRem`, (Memberwise)
    - Returns tuple of 2 Vectors (Vector Quotient, Vector Remainder)
  - `IBinaryInteger<>.PopCount`, (Memberwise)
  - `IBinaryInteger<>.TrailingZeroCount`, (Memberwise)
  - `IFloatingPoint<>.Ceiling`, (Memberwise)
  - `IFloatingPoint<>.Floor`, (Memberwise)
  - `IFloatingPoint<>.Round`, (Memberwise)
  - `IFloatingPoint<>.Round`, (Memberwise, Scalar) *`int digits`
  - `IFloatingPoint<>.Round`, (Memberwise, Scalar) *`MidpointRounding mode`
  - `IFloatingPoint<>.Round`, (Memberwise, Scalar, Scalar) *`int digits, MidpointRounding mode`
  - `IFloatingPoint<>.Truncate`, (Memberwise)
  - `IFloatingPointIeee754<>.Atan2`, (Memberwise, Memberwise)
  - `IFloatingPointIeee754<>.Atan2Pi`, (Memberwise, Memberwise)
  - `IFloatingPointIeee754<>.Lerp`, (Memberwise, Memberwise, Memberwise)
  - `IFloatingPointIeee754<>.Lerp`, (Memberwise, Memberwise, Scalar)
  - `IFloatingPointIeee754<>.BitDecrement`, (Memberwise)
  - `IFloatingPointIeee754<>.BitIncrement`, (Memberwise)
  - `IFloatingPointIeee754<>.FusedMultiplyAdd`, (Memberwise, Memberwise, Memberwise)
  - `IFloatingPointIeee754<>.FusedMultiplyAdd`, (Memberwise, Memberwise, Scalar)
  - `IFloatingPointIeee754<>.FusedMultiplyAdd`, (Memberwise, Scalar, Memberwise)
  - `IFloatingPointIeee754<>.FusedMultiplyAdd`, (Memberwise, Scalar, Scalar)
  - `IFloatingPointIeee754<>.Ieee754Remainder`, (Memberwise, Memberwise)
  - `IFloatingPointIeee754<>.Ieee754Remainder`, (Memberwise, Scalar)
  - `IFloatingPointIeee754<>.ILogB`, (Memberwise)
    - Returns `VectorND<int>`, where N matches the dimensionality of the vector
    - **INFORMATIVE** This may require multiple methods depending on implementation
  - `IFloatingPointIeee754<>.ReciprocalEstimate`, (Memberwise)
  - `IFloatingPointIeee754<>.ReciprocalSqrtEstimate`, (Memberwise)
  - `IFloatingPointIeee754<>.ScaleB`, (Memberwise, Memberwise)
  - `IFloatingPointIeee754<>.ScaleB`, (Memberwise, Scalar)
  - `IPowerFunctions<>.Pow`, (Memberwise, Memberwise)
  - `IPowerFunctions<>.Pow`, (Memberwise, Scalar)
  - `IRootFunctions<>.Cbrt`, (Memberwise)
  - `IRootFunctions<>.Sqrt`, (Memberwise)
  - `IRootFunctions<>.RootN`, (Memberwise, Memberwise)
  - `IRootFunctions<>.RootN`, (Memberwise, Scalar)
  - `IRootFunctions<>.Hypot`, (Memberwise, Memberwise)
  - `IRootFunctions<>.Hypot`, (Memberwise, Scalar)
  - `ILogarithmicFunctions<>.Log`, (Memberwise)
  - `ILogarithmicFunctions<>.Log`, (Memberwise, Memberwise)
  - `ILogarithmicFunctions<>.Log`, (Memberwise, Scalar)
  - `ILogarithmicFunctions<>.LogP1`, (Memberwise)
  - ~~`ILogarithmicFunctions<>.Log2`, (Memberwise)~~
    - Provided via `IBinaryNumber<>`, which is present on all builtin types that implement `ILogarithmicFunctions<>`
  - `ILogarithmicFunctions<>.Log2P1`, (Memberwise)
  - `ILogarithmicFunctions<>.Log10`, (Memberwise)
  - `ILogarithmicFunctions<>.Log10P1`, (Memberwise)
  - `IExponentialFunctions<>.Exp`, (Memberwise)
  - `IExponentialFunctions<>.ExpM1`, (Memberwise)
  - `IExponentialFunctions<>.Exp2`, (Memberwise)
  - `IExponentialFunctions<>.Exp2M1`, (Memberwise)
  - `IExponentialFunctions<>.Exp10`, (Memberwise)
  - `IExponentialFunctions<>.Exp10M1`, (Memberwise)
  - `ITrigonometricFunctions<>.Acos`, (Memberwise)
  - `ITrigonometricFunctions<>.AcosPi`, (Memberwise)
  - `ITrigonometricFunctions<>.Asin`, (Memberwise)
  - `ITrigonometricFunctions<>.AsinPi`, (Memberwise)
  - `ITrigonometricFunctions<>.Atan`, (Memberwise)
  - `ITrigonometricFunctions<>.AtanPi`, (Memberwise)
  - `ITrigonometricFunctions<>.Cos`, (Memberwise)
  - `ITrigonometricFunctions<>.CosPi`, (Memberwise)
  - `ITrigonometricFunctions<>.Sin`, (Memberwise)
  - `ITrigonometricFunctions<>.SinPi`, (Memberwise)
  - `ITrigonometricFunctions<>.SinCos`, (Memberwise)
    - Returns a tuple of 2 Vectors (Sin, Cos)
  - `ITrigonometricFunctions<>.SinCosPi`, (Memberwise)
    - Returns a tuple of 2 Vectors (Sin, Cos)
  - `ITrigonometricFunctions<>.Tan`, (Memberwise)
  - `ITrigonometricFunctions<>.TanPi`, (Memberwise)
  - `ITrigonometricFunctions<>.DegreesToRadians`, (Memberwise)
  - `ITrigonometricFunctions<>.RadiansToDegrees`, (Memberwise)
  - `IHyperbolicFunctions<>.Acosh`, (Memberwise)
  - `IHyperbolicFunctions<>.Asinh`, (Memberwise)
  - `IHyperbolicFunctions<>.Atanh`, (Memberwise)
  - `IHyperbolicFunctions<>.Cosh`, (Memberwise)
  - `IHyperbolicFunctions<>.Sinh`, (Memberwise)
  - `IHyperbolicFunctions<>.Tanh`, (Memberwise)
  - ScaleB(Vector x, VectorND\<int\> n)
  - ScaleB(Vector x, int n)
  - RoundToInt(Vector x)
    - Returns `VectorND<int>`, where N matches the dimensionality of the vector
    - **INFORMATIVE** This may require multiple methods depending on implementation
  - FloorToInt(Vector x)
    - Returns `VectorND<int>`, where N matches the dimensionality of the vector
    - **INFORMATIVE** This may require multiple methods depending on implementation
  - CeilingToInt(Vector x)
    - Returns `VectorND<int>`, where N matches the dimensionality of the vector
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
- `Matrix2X2<T>`
- `Matrix2X3<T>`
- `Matrix2X4<T>`
- `Matrix3X2<T>`
- `Matrix3X3<T>`
- `Matrix3X4<T>`
- `Matrix4X2<T>`
- `Matrix4X3<T>`
- `Matrix4X4<T>`
- `Matrix5X4<T>`

Matrix structs **must** fulfill the following requirements:
- Fulfills `IEquatable<T>` where `T` is the same matrix class
- Stored in row major format
- Both row vectors and individual values (M11, etc.) accessible via properties
- A ref indexer that takes row and column indicies and outputs the value
- Add, subtract, and multiply operators defined with Matricies of the same size
- Multiply operators defined with compatible matricies, if the output matrix type already exists (AxB * BxC = AxC)
- Negate Operator defined
- Implicit conversion to and from the System.Numerics matrix type, if available
- Invert extension method for square matricies
- GetDeterminant extension method for square matricies and Matrix3X2, Matrix4X3, and Matrix5X4
- Transpose extension method
- Lerp static method
- static identity property for square matrices
- For Matrix3X2, Matrix3X3, Matrix4X3, and Matrix4X4 include the following static functions
  - CreateBillboardRH
  - CreateBillboardLH
  - CreateRotation
    - 3x3, 4x3, and 4x4 Matricies get X, Y, and Z variants for this function instead
  - CreateTranslation
  - CreateScale
  - Decompose (separate out any transformations)
- For Matrix3X2 include a CreateSkew static function
- For Matrix3X3, Matrix4X3, and Matrix4X4 include the following static functions
  - CreateFromAxisAngle
  - CreateFromQuaternion
  - Transform
    - from a Quaternion
  - CreateFromYawPitchRoll
- For Matrix4X3 and Matrix4X4 include the following static functions
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
- Define a Constructor taking a `Vector3D<T>` and a Scalar, with the vector 3 mapping to X, Y, Z and the Scalar to the W
- Define a Constructor taking a `Vector4D<T>`
- A `Vector3D<T>` Axis property mapping to (X, Y, Z)
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
- A static CreateFromAxisAngle function which takes in a `Vector3D<T>` and an angle and returns a Quaternion representing that rotation
- A static CreateFromRotationMatrix function which takes either a Matrix3X3 or Matrix4X4 and returns a Quaternion representing that rotation
- A static CreateFromYawPitchRoll which takes either each components separately or in a `Vector3D<T>` and outputs a Quaternion representing that rotation
- A static Lerp function which takes 2 Quaternions and a Scalar matching the generic type which linearly interpolates between the 2 Quaternions with scalar used as the amount to lerp
- A static SLerp function which takes 2 Quaternions and a Scalar matching the generic type which Spherical linearly interpolates between the 2 Quaternions with scalar used as the amount to lerp
- A static Zero Quaternion Property
- A static Identity Quaternion Property

# Geometric Types

The following Geometric Types are defined:
- Box
- Circle
- Plane
- Ray2
- Ray3
- Rectangle
- Sphere

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
    - With a Matrix4X4 or Quaternion, if relevant

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

## 14/09/2025

[Video](https://youtu.be/s5MVZ3BMbac?t=327)

- It's weird having instance invocations (extension methods) and static methods.
    - Should we follow System.Numerics where possible?
    - Should we use this for things that would otherwise be an infix operator only?
    - We will remove instance extension methods and add them back later if we still want them.
    - We visited Length/LengthSquared as properties instead of .NET
- Approved notwithstanding instance extension method and Atan2(Memberwise, Scalar) removal
