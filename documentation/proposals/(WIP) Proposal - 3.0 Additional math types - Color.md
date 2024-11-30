# Summary
Proposal API for additional math types to bring it up to feature parity with other popular math libraries i.e. `SlimDX`, `SharpDX`, or `Stride3D`. Leveraging modern .NET features such as `INumber<T>` and vectorization.

This proposal is regarding color type structs.

# Contributors
- Daniel Keenan (dfkeenan)

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- This proposal should compliment/augment the proposed 3.0 implementation of `Silk.Net.Maths`, matching `System.Numerics` where possible, with concessions for design oversights in that api.
- This proposal assumes no knowledge of the 2.x Math library.
- Text herein marked **INFORMATIVE** does not form a normative part of this proposal, and is for background only.
- Within this proposal, the key words **must**, **required**, **shall**, **should**, **recommended**, **may**, **could**, and **optional** are to be interpreted as described in [RFC 2119 - Key words for use in RFCs to Indicate Requirement Levels](https://www.ietf.org/rfc/rfc2119.txt). The additional key word **optionally** is an alternate form of **optional**, for use where grammatically appropriate. These key words are highlighted in the proposal for clarity.

# **INFORMATIVE** Integer and Floating Point Types
While investigating the use of generic math it was decided to provide both an integer and floating point variant for each vector type and every type built from them. See [Generic Math](Proposal%20-%20Generic%20Math.md) proposal for more details.

# I types versus F Types
Where it is appropriate for a type in this proposal to have both integer and floating point variants they will have a name that ends in I or F, defining whether it is an integer type or floating point type. Integer types **must** use a generic type argument `T` with the constraint of `IBinaryInteger<T>`. On the other hand, floating point types **must** use a generic type argument `T` with the constraint of `IFloatingPointIeee754<T>`.

# Proposed API

### Color

```csharp
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public partial struct Color : IEquatable<Color>
    {
        public byte R;
        public byte G;
        public byte B;
        public byte A;

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct.
        /// </summary>
        /// <param name = "value">The value that will be assigned to all components.</param>
        public Color(byte value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct.
        /// </summary>
        /// <param name = "value">The value that will be assigned to all components.</param>
        public Color(float value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct.
        /// </summary>
        /// <param name = "red">The red component of the color.</param>
        /// <param name = "green">The green component of the color.</param>
        /// <param name = "blue">The blue component of the color.</param>
        /// <param name = "alpha">The alpha component of the color.</param>
        public Color(byte red, byte green, byte blue, byte alpha)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct.  Alpha is set to 255.
        /// </summary>
        /// <param name = "red">The red component of the color.</param>
        /// <param name = "green">The green component of the color.</param>
        /// <param name = "blue">The blue component of the color.</param>
        public Color(byte red, byte green, byte blue)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct.
        /// </summary>
        /// <param name = "red">The red component of the color.</param>
        /// <param name = "green">The green component of the color.</param>
        /// <param name = "blue">The blue component of the color.</param>
        /// <param name = "alpha">The alpha component of the color.</param>
        public Color(float red, float green, float blue, float alpha)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct.  Alpha is set to 255.
        /// </summary>
        /// <param name = "red">The red component of the color.</param>
        /// <param name = "green">The green component of the color.</param>
        /// <param name = "blue">The blue component of the color.</param>
        public Color(float red, float green, float blue)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct.
        /// </summary>
        /// <param name = "value">The red, green, blue, and alpha components of the color.</param>
        public Color(Vector4F<TScalar> value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct.
        /// </summary>
        /// <param name = "value">The red, green, and blue components of the color.</param>
        /// <param name = "alpha">The alpha component of the color.</param>
        public Color(Vector3F<TScalar> value, float alpha)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct. Alpha is set to 255.
        /// </summary>
        /// <param name = "value">The red, green, and blue components of the color.</param>
        public Color(Vector3F<TScalar> value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct.
        /// </summary>
        /// <param name = "rgba">A packed integer containing all four color components in RGBA order.</param>
        public Color(uint rgba)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct.
        /// </summary>
        /// <param name = "rgba">A packed integer containing all four color components in RGBA order.</param>
        public Color(int rgba)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct.
        /// </summary>
        /// <param name = "values">The values to assign to the red, green, and blue, alpha components of the color. This must be an array with four elements.</param>
        /// <exception cref = "ArgumentNullException">Thrown when <paramref name = "values"/> is <c>null</c>.</exception>
        /// <exception cref = "ArgumentOutOfRangeException">Thrown when <paramref name = "values"/> contains more or less than four elements.</exception>
        public Color(float[] values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color"/> struct.
        /// </summary>
        /// <param name = "values">The values to assign to the red, green, blue, or alpha components of the color. This must be an array with four elements.</param>
        /// <exception cref = "ArgumentNullException">Thrown when <paramref name = "values"/> is <c>null</c>.</exception>
        /// <exception cref = "ArgumentOutOfRangeException">Thrown when <paramref name = "values"/> contains more or less than four elements.</exception>
        public Color(byte[] values)
        {
        }

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <value>The value of the red, green, blue, or alpha component, depending on the index.</value>
        /// <param name = "index">The index of the component to access. Use 0 for the red(R) component, 1 for the green(G) component, 2 for the blue(B) component, and 3 for the alpha(A) component.</param>
        /// <returns>The value of the component at the specified index.</returns>
        /// <exception cref = "System.ArgumentOutOfRangeException">Thrown when the <paramref name = "index"/> is out of the range [0, 3].</exception>
        public byte this[int index] { get; set; }

        /// <summary>
        /// Converts the color into a packed integer.
        /// </summary>
        /// <returns>A packed integer containing all four color components.</returns>
        public int ToBgra() 
            => default;

        /// <summary>
        /// Converts the color into a packed integer.
        /// </summary>
        /// <returns>A packed integer containing all four color components.</returns>
        public int ToRgba() 
            => default;

        /// <summary>
        /// Converts the color into a packed integer.
        /// </summary>
        /// <returns>A packed integer containing all four color components.</returns>
        public int ToArgb() 
            => default;

        /// <summary>
        /// Converts the color into a packed integer.
        /// </summary>
        /// <returns>A packed integer containing all four color components.</returns>
        public int ToAbgr() 
            => default;

        /// <summary>
        /// Converts the color into a three component vector.
        /// </summary>
        /// <returns>A three component vector containing the red, green, and blue components of the color.</returns>
        public Vector3F<TScalar> ToVector3<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Converts the color into a three component color.
        /// </summary>
        /// <returns>A three component color containing the red, green, and blue components of the color.</returns>
        public Color3<TScalar> ToColor3<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Converts the color into a four component vector.
        /// </summary>
        /// <returns>A four component vector containing all four color components.</returns>
        public Vector4F<TScalar> ToVector4<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Creates an array containing the elements of the color.
        /// </summary>
        /// <returns>A four-element array containing the components of the color in RGBA order.</returns>
        public byte[] ToArray() 
            => default;

        /// <summary>
        /// Gets the brightness.
        /// </summary>
        /// <returns>The Hue-Saturation-Brightness (HSB) saturation for this <see cref = "Color"/></returns>
        public float GetBrightness() 
            => default;

        /// <summary>
        /// Gets the hue.
        /// </summary>
        /// <returns>The Hue-Saturation-Brightness (HSB) saturation for this <see cref = "Color"/></returns>
        public float GetHue() 
            => default;

        /// <summary>
        /// Gets the saturation.
        /// </summary>
        /// <returns>The Hue-Saturation-Brightness (HSB) saturation for this <see cref = "Color"/></returns>
        public float GetSaturation() 
            => default;

        /// <summary>
        /// Adds two colors.
        /// </summary>
        /// <param name = "left">The first color to add.</param>
        /// <param name = "right">The second color to add.</param>
        /// <param name = "result">When the method completes, completes the sum of the two colors.</param>
        public static void Add(ref readonly Color left, ref readonly Color right, out Color result)
        {
        }

        /// <summary>
        /// Adds two colors.
        /// </summary>
        /// <param name = "left">The first color to add.</param>
        /// <param name = "right">The second color to add.</param>
        /// <returns>The sum of the two colors.</returns>
        public static Color Add(Color left, Color right) 
            => default;

        /// <summary>
        /// Subtracts two colors.
        /// </summary>
        /// <param name = "left">The first color to subtract.</param>
        /// <param name = "right">The second color to subtract.</param>
        /// <param name = "result">WHen the method completes, contains the difference of the two colors.</param>
        public static void Subtract(ref readonly Color left, ref readonly Color right, out Color result)
        {
        }

        /// <summary>
        /// Subtracts two colors.
        /// </summary>
        /// <param name = "left">The first color to subtract.</param>
        /// <param name = "right">The second color to subtract</param>
        /// <returns>The difference of the two colors.</returns>
        public static Color Subtract(Color left, Color right) 
            => default;

        /// <summary>
        /// Modulates two colors.
        /// </summary>
        /// <param name = "left">The first color to modulate.</param>
        /// <param name = "right">The second color to modulate.</param>
        /// <param name = "result">When the method completes, contains the modulated color.</param>
        public static void Modulate(ref readonly Color left, ref readonly Color right, out Color result)
        {
        }

        /// <summary>
        /// Modulates two colors.
        /// </summary>
        /// <param name = "left">The first color to modulate.</param>
        /// <param name = "right">The second color to modulate.</param>
        /// <returns>The modulated color.</returns>
        public static Color Modulate(Color left, Color right) 
            => default;

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "value">The color to scale.</param>
        /// <param name = "scale">The amount by which to scale.</param>
        /// <param name = "result">When the method completes, contains the scaled color.</param>
        public static void Scale(ref readonly Color value, float scale, out Color result)
        {
        }

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "value">The color to scale.</param>
        /// <param name = "scale">The amount by which to scale.</param>
        /// <returns>The scaled color.</returns>
        public static Color Scale(Color value, float scale) 
            => default;

        /// <summary>
        /// Negates a color.
        /// </summary>
        /// <param name = "value">The color to negate.</param>
        /// <param name = "result">When the method completes, contains the negated color.</param>
        public static void Negate(ref readonly Color value, out Color result)
        {
        }

        /// <summary>
        /// Negates a color.
        /// </summary>
        /// <param name = "value">The color to negate.</param>
        /// <returns>The negated color.</returns>
        public static Color Negate(Color value) 
            => default;

        /// <summary>
        /// Restricts a value to be within a specified range.
        /// </summary>
        /// <param name = "value">The value to clamp.</param>
        /// <param name = "min">The minimum value.</param>
        /// <param name = "max">The maximum value.</param>
        /// <param name = "result">When the method completes, contains the clamped value.</param>
        public static void Clamp(ref readonly Color value, ref readonly Color min, ref readonly Color max, out Color result)
        {
        }

        /// <summary>
        /// Converts the color from a packed BGRA integer.
        /// </summary>
        /// <param name = "color">A packed integer containing all four color components in BGRA order</param>
        /// <returns>A color.</returns>
        public static Color FromBgra(int color) 
            => default;

        /// <summary>
        /// Converts the color from a packed BGRA integer.
        /// </summary>
        /// <param name = "color">A packed integer containing all four color components in BGRA order</param>
        /// <returns>A color.</returns>
        public static Color FromBgra(uint color) 
            => default;

        /// <summary>
        /// Converts the color from a packed ABGR integer.
        /// </summary>
        /// <param name = "color">A packed integer containing all four color components in ABGR order</param>
        /// <returns>A color.</returns>
        public static Color FromAbgr(int color) 
            => default;

        /// <summary>
        /// Converts the color from a packed ABGR integer.
        /// </summary>
        /// <param name = "color">A packed integer containing all four color components in ABGR order</param>
        /// <returns>A color.</returns>
        public static Color FromAbgr(uint color) 
            => default;

        /// <summary>
        /// Converts the color from a packed RGBA integer.
        /// </summary>
        /// <param name = "color">A packed integer containing all four color components in RGBA order</param>
        /// <returns>A color.</returns>
        public static Color FromRgba(int color) 
            => default;

        /// <summary>
        /// Converts the color from a packed RGBA integer.
        /// </summary>
        /// <param name = "color">A packed integer containing all four color components in RGBA order</param>
        /// <returns>A color.</returns>
        public static Color FromRgba(uint color) 
            => default;

        /// <summary>
        /// Restricts a value to be within a specified range.
        /// </summary>
        /// <param name = "value">The value to clamp.</param>
        /// <param name = "min">The minimum value.</param>
        /// <param name = "max">The maximum value.</param>
        /// <returns>The clamped value.</returns>
        public static Color Clamp(Color value, Color min, Color max) 
            => default;

        /// <summary>
        /// Performs a linear interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <param name = "result">When the method completes, contains the linear interpolation of the two colors.</param>
        /// <remarks>
        /// Passing <paramref name = "amount"/> a value of 0 will cause <paramref name = "start"/> to be returned; a value of 1 will cause <paramref name = "end"/> to be returned. 
        /// </remarks>
        public static void Lerp(ref readonly Color start, ref readonly Color end, float amount, out Color result)
        {
        }

        /// <summary>
        /// Performs a linear interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <returns>The linear interpolation of the two colors.</returns>
        /// <remarks>
        /// Passing <paramref name = "amount"/> a value of 0 will cause <paramref name = "start"/> to be returned; a value of 1 will cause <paramref name = "end"/> to be returned. 
        /// </remarks>
        public static Color Lerp(Color start, Color end, float amount) 
            => default;

        /// <summary>
        /// Performs a cubic interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <param name = "result">When the method completes, contains the cubic interpolation of the two colors.</param>
        public static void SmoothStep(ref readonly Color start, ref readonly Color end, float amount, out Color result)
        {
        }

        /// <summary>
        /// Performs a cubic interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <returns>The cubic interpolation of the two colors.</returns>
        public static Color SmoothStep(Color start, Color end, float amount) 
            => default;

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <param name = "result">When the method completes, contains an new color composed of the largest components of the source colors.</param>
        public static void Max(ref readonly Color left, ref readonly Color right, out Color result)
        {
        }

        /// <summary>
        /// Returns a color containing the largest components of the specified colorss.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <returns>A color containing the largest components of the source colors.</returns>
        public static Color Max(Color left, Color right) 
            => default;

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <param name = "result">When the method completes, contains an new color composed of the smallest components of the source colors.</param>
        public static void Min(ref readonly Color left, ref readonly Color right, out Color result)
        {
        }

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <returns>A color containing the smallest components of the source colors.</returns>
        public static Color Min(Color left, Color right) 
            => default;

        /// <summary>
        /// Adjusts the contrast of a color.
        /// </summary>
        /// <param name = "value">The color whose contrast is to be adjusted.</param>
        /// <param name = "contrast">The amount by which to adjust the contrast.</param>
        /// <param name = "result">When the method completes, contains the adjusted color.</param>
        public static void AdjustContrast(ref readonly Color value, float contrast, out Color result)
        {
        }

        /// <summary>
        /// Adjusts the contrast of a color.
        /// </summary>
        /// <param name = "value">The color whose contrast is to be adjusted.</param>
        /// <param name = "contrast">The amount by which to adjust the contrast.</param>
        /// <returns>The adjusted color.</returns>
        public static Color AdjustContrast(Color value, float contrast) 
            => default;

        /// <summary>
        /// Adjusts the saturation of a color.
        /// </summary>
        /// <param name = "value">The color whose saturation is to be adjusted.</param>
        /// <param name = "saturation">The amount by which to adjust the saturation.</param>
        /// <param name = "result">When the method completes, contains the adjusted color.</param>
        public static void AdjustSaturation(ref readonly Color value, float saturation, out Color result)
        {
        }

        /// <summary>
        /// Adjusts the saturation of a color.
        /// </summary>
        /// <param name = "value">The color whose saturation is to be adjusted.</param>
        /// <param name = "saturation">The amount by which to adjust the saturation.</param>
        /// <returns>The adjusted color.</returns>
        public static Color AdjustSaturation(Color value, float saturation) 
            => default;

        /// <summary>
        /// Adds two colors.
        /// </summary>
        /// <param name = "left">The first color to add.</param>
        /// <param name = "right">The second color to add.</param>
        /// <returns>The sum of the two colors.</returns>
        public static Color operator +(Color left, Color right) 
            => default;

        /// <summary>
        /// Assert a color (return it unchanged).
        /// </summary>
        /// <param name = "value">The color to assert (unchanged).</param>
        /// <returns>The asserted (unchanged) color.</returns>
        public static Color operator +(Color value) 
            => default;

        /// <summary>
        /// Subtracts two colors.
        /// </summary>
        /// <param name = "left">The first color to subtract.</param>
        /// <param name = "right">The second color to subtract.</param>
        /// <returns>The difference of the two colors.</returns>
        public static Color operator -(Color left, Color right) 
            => default;

        /// <summary>
        /// Negates a color.
        /// </summary>
        /// <param name = "value">The color to negate.</param>
        /// <returns>A negated color.</returns>
        public static Color operator -(Color value) 
            => default;

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "scale">The factor by which to scale the color.</param>
        /// <param name = "value">The color to scale.</param>
        /// <returns>The scaled color.</returns>
        public static Color operator *(float scale, Color value) 
            => default;

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "value">The factor by which to scale the color.</param>
        /// <param name = "scale">The color to scale.</param>
        /// <returns>The scaled color.</returns>
        public static Color operator *(Color value, float scale) 
            => default;

        /// <summary>
        /// Modulates two colors.
        /// </summary>
        /// <param name = "left">The first color to modulate.</param>
        /// <param name = "right">The second color to modulate.</param>
        /// <returns>The modulated color.</returns>
        public static Color operator *(Color left, Color right) 
            => default;

        /// <summary>
        /// Tests for equality between two objects.
        /// </summary>
        /// <param name = "left">The first value to compare.</param>
        /// <param name = "right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name = "left"/> has the same value as <paramref name = "right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator ==(Color left, Color right) 
            => default;

        /// <summary>
        /// Tests for inequality between two objects.
        /// </summary>
        /// <param name = "left">The first value to compare.</param>
        /// <param name = "right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name = "left"/> has a different value than <paramref name = "right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator !=(Color left, Color right) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Color"/> to <see cref = "Color3"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color3<TScalar>(Color value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Color"/> to <see cref = "Vector3"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Vector3F<TScalar>(Color value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Color"/> to <see cref = "Vector4"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Vector4F<TScalar>(Color value) 
            => default;

        /// <summary>
        /// Convert this instance to a <see cref = "Color4"/>
        /// </summary>
        /// <returns>The result of the conversion.</returns>
        public Color4<TScalar> ToColor4<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Performs an implicit conversion from <see cref = "Color"/> to <see cref = "Color4"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Color4<TScalar>(Color value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Vector3"/> to <see cref = "Color"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color(Vector3F<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Color3"/> to <see cref = "Color"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color(Color3<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Vector4"/> to <see cref = "Color"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color(Vector4F<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Color4"/> to <see cref = "Color"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color(Color4<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "int "/> to <see cref = "Color"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator int (Color value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "int "/> to <see cref = "Color"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator Color(int value) 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public override string ToString() 
            => default;

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode() 
            => default;

        /// <summary>
        /// Determines whether the specified <see cref = "Color"/> is equal to this instance.
        /// </summary>
        /// <param name = "other">The <see cref = "Color"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref = "Color"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(Color other) 
            => default;

        /// <summary>
        /// Determines whether the specified <see cref = "object "/> is equal to this instance.
        /// </summary>
        /// <param name = "value">The <see cref = "object "/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref = "object "/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object value) 
            => default;

    }
```
### ColorBGRA

```csharp
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public partial struct ColorBGRA : IEquatable<ColorBGRA>, IFormattable
    {
        public byte B;
        public byte G;
        public byte R;
        public byte A;

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorBGRA"/> struct.
        /// </summary>
        /// <param name = "value">The value that will be assigned to all components.</param>
        public ColorBGRA(byte value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorBGRA"/> struct.
        /// </summary>
        /// <param name = "value">The value that will be assigned to all components.</param>
        public ColorBGRA(float value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorBGRA"/> struct.
        /// </summary>
        /// <param name = "red">The red component of the color.</param>
        /// <param name = "green">The green component of the color.</param>
        /// <param name = "blue">The blue component of the color.</param>
        /// <param name = "alpha">The alpha component of the color.</param>
        public ColorBGRA(byte red, byte green, byte blue, byte alpha)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorBGRA"/> struct.
        /// </summary>
        /// <param name = "red">The red component of the color.</param>
        /// <param name = "green">The green component of the color.</param>
        /// <param name = "blue">The blue component of the color.</param>
        /// <param name = "alpha">The alpha component of the color.</param>
        public ColorBGRA(float red, float green, float blue, float alpha)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorBGRA"/> struct.
        /// </summary>
        /// <param name = "value">The red, green, blue, and alpha components of the color.</param>
        public ColorBGRA(Vector4F<TScalar> value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorBGRA"/> struct.
        /// </summary>
        /// <param name = "value">The red, green, and blue components of the color.</param>
        /// <param name = "alpha">The alpha component of the color.</param>
        public ColorBGRA(Vector3F<TScalar> value, float alpha)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorBGRA"/> struct.
        /// </summary>
        /// <param name = "bgra">A packed integer containing all four color components in BGRA order.</param>
        public ColorBGRA(uint bgra)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorBGRA"/> struct.
        /// </summary>
        /// <param name = "bgra">A packed integer containing all four color components in BGRA.</param>
        public ColorBGRA(int bgra)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorBGRA"/> struct.
        /// </summary>
        /// <param name = "values">The values to assign to the red, green, and blue, alpha components of the color. This must be an array with four elements.</param>
        /// <exception cref = "ArgumentNullException">Thrown when <paramref name = "values"/> is <c>null</c>.</exception>
        /// <exception cref = "ArgumentOutOfRangeException">Thrown when <paramref name = "values"/> contains more or less than four elements.</exception>
        public ColorBGRA(float[] values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorBGRA"/> struct.
        /// </summary>
        /// <param name = "values">The values to assign to the red, green, and blue, alpha components of the color. This must be an array with four elements.</param>
        /// <exception cref = "ArgumentNullException">Thrown when <paramref name = "values"/> is <c>null</c>.</exception>
        /// <exception cref = "ArgumentOutOfRangeException">Thrown when <paramref name = "values"/> contains more or less than four elements.</exception>
        public ColorBGRA(byte[] values)
        {
        }

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <value>The value of the alpha, red, green, or blue component, depending on the index.</value>
        /// <param name = "index">The index of the component to access. Use 0 for the alpha component, 1 for the red component, 2 for the green component, and 3 for the blue component.</param>
        /// <returns>The value of the component at the specified index.</returns>
        /// <exception cref = "System.ArgumentOutOfRangeException">Thrown when the <paramref name = "index"/> is out of the range [0, 3].</exception>
        public byte this[int index] { get; set; }

        /// <summary>
        /// Converts the color into a packed integer.
        /// </summary>
        /// <returns>A packed integer containing all four color components.</returns>
        public int ToBgra() 
            => default;

        /// <summary>
        /// Converts the color into a packed integer.
        /// </summary>
        /// <returns>A packed integer containing all four color components.</returns>
        public int ToRgba() 
            => default;

        /// <summary>
        /// Converts the color into a three component vector.
        /// </summary>
        /// <returns>A three component vector containing the red, green, and blue components of the color.</returns>
        public Vector3F<TScalar> ToVector3<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Converts the color into a three component color.
        /// </summary>
        /// <returns>A three component color containing the red, green, and blue components of the color.</returns>
        public Color3<TScalar> ToColor3<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Converts the color into a four component vector.
        /// </summary>
        /// <returns>A four component vector containing all four color components.</returns>
        public Vector4F<TScalar> ToVector4<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Creates an array containing the elements of the color.
        /// </summary>
        /// <returns>A four-element array containing the components of the color in BGRA order.</returns>
        public byte[] ToArray() 
            => default;

        /// <summary>
        /// Gets the brightness.
        /// </summary>
        /// <returns>The Hue-Saturation-Brightness (HSB) saturation for this <see cref = "Color"/></returns>
        public float GetBrightness() 
            => default;

        /// <summary>
        /// Gets the hue.
        /// </summary>
        /// <returns>The Hue-Saturation-Brightness (HSB) saturation for this <see cref = "Color"/></returns>
        public float GetHue() 
            => default;

        /// <summary>
        /// Gets the saturation.
        /// </summary>
        /// <returns>The Hue-Saturation-Brightness (HSB) saturation for this <see cref = "Color"/></returns>
        public float GetSaturation() 
            => default;

        /// <summary>
        /// Converts the color from a packed BGRA integer.
        /// </summary>
        /// <param name = "color">A packed integer containing all four color components in BGRA order</param>
        /// <returns>A color.</returns>
        public static ColorBGRA FromBgra(int color) 
            => default;

        /// <summary>
        /// Converts the color from a packed BGRA integer.
        /// </summary>
        /// <param name = "color">A packed integer containing all four color components in BGRA order</param>
        /// <returns>A color.</returns>
        public static ColorBGRA FromBgra(uint color) 
            => default;

        /// <summary>
        /// Converts the color from a packed RGBA integer.
        /// </summary>
        /// <param name = "color">A packed integer containing all four color components in RGBA order</param>
        /// <returns>A color.</returns>
        public static ColorBGRA FromRgba(int color) 
            => default;

        /// <summary>
        /// Converts the color from a packed RGBA integer.
        /// </summary>
        /// <param name = "color">A packed integer containing all four color components in RGBA order</param>
        /// <returns>A color.</returns>
        public static ColorBGRA FromRgba(uint color) 
            => default;

        /// <summary>
        /// Adds two colors.
        /// </summary>
        /// <param name = "left">The first color to add.</param>
        /// <param name = "right">The second color to add.</param>
        /// <param name = "result">When the method completes, completes the sum of the two colors.</param>
        public static void Add(ref readonly ColorBGRA left, ref readonly ColorBGRA right, out ColorBGRA result)
        {
        }

        /// <summary>
        /// Adds two colors.
        /// </summary>
        /// <param name = "left">The first color to add.</param>
        /// <param name = "right">The second color to add.</param>
        /// <returns>The sum of the two colors.</returns>
        public static ColorBGRA Add(ColorBGRA left, ColorBGRA right) 
            => default;

        /// <summary>
        /// Subtracts two colors.
        /// </summary>
        /// <param name = "left">The first color to subtract.</param>
        /// <param name = "right">The second color to subtract.</param>
        /// <param name = "result">WHen the method completes, contains the difference of the two colors.</param>
        public static void Subtract(ref readonly ColorBGRA left, ref readonly ColorBGRA right, out ColorBGRA result)
        {
        }

        /// <summary>
        /// Subtracts two colors.
        /// </summary>
        /// <param name = "left">The first color to subtract.</param>
        /// <param name = "right">The second color to subtract</param>
        /// <returns>The difference of the two colors.</returns>
        public static ColorBGRA Subtract(ColorBGRA left, ColorBGRA right) 
            => default;

        /// <summary>
        /// Modulates two colors.
        /// </summary>
        /// <param name = "left">The first color to modulate.</param>
        /// <param name = "right">The second color to modulate.</param>
        /// <param name = "result">When the method completes, contains the modulated color.</param>
        public static void Modulate(ref readonly ColorBGRA left, ref readonly ColorBGRA right, out ColorBGRA result)
        {
        }

        /// <summary>
        /// Modulates two colors.
        /// </summary>
        /// <param name = "left">The first color to modulate.</param>
        /// <param name = "right">The second color to modulate.</param>
        /// <returns>The modulated color.</returns>
        public static ColorBGRA Modulate(ColorBGRA left, ColorBGRA right) 
            => default;

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "value">The color to scale.</param>
        /// <param name = "scale">The amount by which to scale.</param>
        /// <param name = "result">When the method completes, contains the scaled color.</param>
        public static void Scale(ref readonly ColorBGRA value, float scale, out ColorBGRA result)
        {
        }

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "value">The color to scale.</param>
        /// <param name = "scale">The amount by which to scale.</param>
        /// <returns>The scaled color.</returns>
        public static ColorBGRA Scale(ColorBGRA value, float scale) 
            => default;

        /// <summary>
        /// Negates a color.
        /// </summary>
        /// <param name = "value">The color to negate.</param>
        /// <param name = "result">When the method completes, contains the negated color.</param>
        public static void Negate(ref readonly ColorBGRA value, out ColorBGRA result)
        {
        }

        /// <summary>
        /// Negates a color.
        /// </summary>
        /// <param name = "value">The color to negate.</param>
        /// <returns>The negated color.</returns>
        public static ColorBGRA Negate(ColorBGRA value) 
            => default;

        /// <summary>
        /// Restricts a value to be within a specified range.
        /// </summary>
        /// <param name = "value">The value to clamp.</param>
        /// <param name = "min">The minimum value.</param>
        /// <param name = "max">The maximum value.</param>
        /// <param name = "result">When the method completes, contains the clamped value.</param>
        public static void Clamp(ref readonly ColorBGRA value, ref readonly ColorBGRA min, ref readonly ColorBGRA max, out ColorBGRA result)
        {
        }

        /// <summary>
        /// Restricts a value to be within a specified range.
        /// </summary>
        /// <param name = "value">The value to clamp.</param>
        /// <param name = "min">The minimum value.</param>
        /// <param name = "max">The maximum value.</param>
        /// <returns>The clamped value.</returns>
        public static ColorBGRA Clamp(ColorBGRA value, ColorBGRA min, ColorBGRA max) 
            => default;

        /// <summary>
        /// Performs a linear interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <param name = "result">When the method completes, contains the linear interpolation of the two colors.</param>
        /// <remarks>
        /// Passing <paramref name = "amount"/> a value of 0 will cause <paramref name = "start"/> to be returned; a value of 1 will cause <paramref name = "end"/> to be returned. 
        /// </remarks>
        public static void Lerp(ref readonly ColorBGRA start, ref readonly ColorBGRA end, float amount, out ColorBGRA result)
        {
        }

        /// <summary>
        /// Performs a linear interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <returns>The linear interpolation of the two colors.</returns>
        /// <remarks>
        /// Passing <paramref name = "amount"/> a value of 0 will cause <paramref name = "start"/> to be returned; a value of 1 will cause <paramref name = "end"/> to be returned. 
        /// </remarks>
        public static ColorBGRA Lerp(ColorBGRA start, ColorBGRA end, float amount) 
            => default;

        /// <summary>
        /// Performs a cubic interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <param name = "result">When the method completes, contains the cubic interpolation of the two colors.</param>
        public static void SmoothStep(ref readonly ColorBGRA start, ref readonly ColorBGRA end, float amount, out ColorBGRA result)
        {
        }

        /// <summary>
        /// Performs a cubic interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <returns>The cubic interpolation of the two colors.</returns>
        public static ColorBGRA SmoothStep(ColorBGRA start, ColorBGRA end, float amount) 
            => default;

        /// <summary>
        /// Returns a color containing the smallest components of the specified colorss.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <param name = "result">When the method completes, contains an new color composed of the largest components of the source colorss.</param>
        public static void Max(ref readonly ColorBGRA left, ref readonly ColorBGRA right, out ColorBGRA result)
        {
        }

        /// <summary>
        /// Returns a color containing the largest components of the specified colorss.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <returns>A color containing the largest components of the source colors.</returns>
        public static ColorBGRA Max(ColorBGRA left, ColorBGRA right) 
            => default;

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <param name = "result">When the method completes, contains an new color composed of the smallest components of the source colors.</param>
        public static void Min(ref readonly ColorBGRA left, ref readonly ColorBGRA right, out ColorBGRA result)
        {
        }

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <returns>A color containing the smallest components of the source colors.</returns>
        public static ColorBGRA Min(ColorBGRA left, ColorBGRA right) 
            => default;

        /// <summary>
        /// Adjusts the contrast of a color.
        /// </summary>
        /// <param name = "value">The color whose contrast is to be adjusted.</param>
        /// <param name = "contrast">The amount by which to adjust the contrast.</param>
        /// <param name = "result">When the method completes, contains the adjusted color.</param>
        public static void AdjustContrast(ref readonly ColorBGRA value, float contrast, out ColorBGRA result)
        {
        }

        /// <summary>
        /// Adjusts the contrast of a color.
        /// </summary>
        /// <param name = "value">The color whose contrast is to be adjusted.</param>
        /// <param name = "contrast">The amount by which to adjust the contrast.</param>
        /// <returns>The adjusted color.</returns>
        public static ColorBGRA AdjustContrast(ColorBGRA value, float contrast) 
            => default;

        /// <summary>
        /// Adjusts the saturation of a color.
        /// </summary>
        /// <param name = "value">The color whose saturation is to be adjusted.</param>
        /// <param name = "saturation">The amount by which to adjust the saturation.</param>
        /// <param name = "result">When the method completes, contains the adjusted color.</param>
        public static void AdjustSaturation(ref readonly ColorBGRA value, float saturation, out ColorBGRA result)
        {
        }

        /// <summary>
        /// Adjusts the saturation of a color.
        /// </summary>
        /// <param name = "value">The color whose saturation is to be adjusted.</param>
        /// <param name = "saturation">The amount by which to adjust the saturation.</param>
        /// <returns>The adjusted color.</returns>
        public static ColorBGRA AdjustSaturation(ColorBGRA value, float saturation) 
            => default;

        /// <summary>
        /// Adds two colors.
        /// </summary>
        /// <param name = "left">The first color to add.</param>
        /// <param name = "right">The second color to add.</param>
        /// <returns>The sum of the two colors.</returns>
        public static ColorBGRA operator +(ColorBGRA left, ColorBGRA right) 
            => default;

        /// <summary>
        /// Assert a color (return it unchanged).
        /// </summary>
        /// <param name = "value">The color to assert (unchange).</param>
        /// <returns>The asserted (unchanged) color.</returns>
        public static ColorBGRA operator +(ColorBGRA value) 
            => default;

        /// <summary>
        /// Subtracts two colors.
        /// </summary>
        /// <param name = "left">The first color to subtract.</param>
        /// <param name = "right">The second color to subtract.</param>
        /// <returns>The difference of the two colors.</returns>
        public static ColorBGRA operator -(ColorBGRA left, ColorBGRA right) 
            => default;

        /// <summary>
        /// Negates a color.
        /// </summary>
        /// <param name = "value">The color to negate.</param>
        /// <returns>A negated color.</returns>
        public static ColorBGRA operator -(ColorBGRA value) 
            => default;

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "scale">The factor by which to scale the color.</param>
        /// <param name = "value">The color to scale.</param>
        /// <returns>The scaled color.</returns>
        public static ColorBGRA operator *(float scale, ColorBGRA value) 
            => default;

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "value">The factor by which to scale the color.</param>
        /// <param name = "scale">The color to scale.</param>
        /// <returns>The scaled color.</returns>
        public static ColorBGRA operator *(ColorBGRA value, float scale) 
            => default;

        /// <summary>
        /// Modulates two colors.
        /// </summary>
        /// <param name = "left">The first color to modulate.</param>
        /// <param name = "right">The second color to modulate.</param>
        /// <returns>The modulated color.</returns>
        public static ColorBGRA operator *(ColorBGRA left, ColorBGRA right) 
            => default;

        /// <summary>
        /// Tests for equality between two objects.
        /// </summary>
        /// <param name = "left">The first value to compare.</param>
        /// <param name = "right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name = "left"/> has the same value as <paramref name = "right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator ==(ColorBGRA left, ColorBGRA right) 
            => default;

        /// <summary>
        /// Tests for inequality between two objects.
        /// </summary>
        /// <param name = "left">The first value to compare.</param>
        /// <param name = "right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name = "left"/> has a different value than <paramref name = "right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator !=(ColorBGRA left, ColorBGRA right) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "ColorBGRA"/> to <see cref = "Color3"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color3<TScalar>(ColorBGRA value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "ColorBGRA"/> to <see cref = "Vector3"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Vector3F<TScalar>(ColorBGRA value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "ColorBGRA"/> to <see cref = "Vector4"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Vector4F<TScalar>(ColorBGRA value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "ColorBGRA"/> to <see cref = "Color4"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color4<TScalar>(ColorBGRA value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Vector3"/> to <see cref = "ColorBGRA"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator ColorBGRA(Vector3F<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Color3"/> to <see cref = "ColorBGRA"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator ColorBGRA(Color3<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Vector4"/> to <see cref = "ColorBGRA"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator ColorBGRA(Vector4F<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Color4"/> to <see cref = "ColorBGRA"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator ColorBGRA(Color4<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an implicit conversion from <see cref = "Color"/> to <see cref = "ColorBGRA"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator ColorBGRA(Color value) 
            => default;

        /// <summary>
        /// Performs an implicit conversion from <see cref = "ColorBGRA"/> to <see cref = "Color"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Color(ColorBGRA value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "ColorBGRA"/> to <see cref = "int "/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator int (ColorBGRA value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "int "/> to <see cref = "ColorBGRA"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator ColorBGRA(int value) 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public override string ToString() 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <param name = "format">The format to apply to each channel (byte).</param>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public string ToString(string format) 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <param name = "formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public string ToString(IFormatProvider formatProvider) 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <param name = "format">The format to apply to each channel (byte).</param>
        /// <param name = "formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public string ToString(string format, IFormatProvider formatProvider) 
            => default;

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode() 
            => default;

        /// <summary>
        /// Determines whether the specified <see cref = "ColorBGRA"/> is equal to this instance.
        /// </summary>
        /// <param name = "other">The <see cref = "ColorBGRA"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref = "ColorBGRA"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(ColorBGRA other) 
            => default;

        /// <summary>
        /// Determines whether the specified <see cref = "object "/> is equal to this instance.
        /// </summary>
        /// <param name = "value">The <see cref = "object "/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref = "object "/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object value) 
            => default;

        /// <summary>
        /// Deconstructs the vector's components into named variables.
        /// </summary>
        /// <param name = "r">The R component</param>
        /// <param name = "g">The G component</param>
        /// <param name = "b">The B component</param>
        /// <param name = "a">The A component</param>
        public void Deconstruct(out byte r, out byte g, out byte b, out byte a)
        {
        }

    }
```
### ColorHSV

```csharp
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct ColorHSV : IEquatable<ColorHSV>, IFormattable
    {
        public float H;
        public float S;
        public float V;
        public float A;

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorHSV"/> struct.
        /// </summary>
        /// <param name = "h">The h.</param>
        /// <param name = "s">The s.</param>
        /// <param name = "v">The v.</param>
        /// <param name = "a">A.</param>
        public ColorHSV(float h, float s, float v, float a)
        {
        }

        /// <summary>
        /// Converts the color into a three component vector.
        /// </summary>
        /// <returns>A three component vector containing the red, green, and blue components of the color.</returns>
        public Color4<TScalar> ToColor<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <inheritdoc/>
        public bool Equals(ColorHSV other) 
            => default;

        /// <inheritdoc/>
        public override bool Equals(object obj) 
            => default;

        /// <inheritdoc/>
        public override int GetHashCode() 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public override string ToString() 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <param name = "format">The format.</param>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public string ToString(string format) 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <param name = "formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public string ToString(IFormatProvider formatProvider) 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <param name = "format">The format.</param>
        /// <param name = "formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public string ToString(string format, IFormatProvider formatProvider) 
            => default;

        /// <summary>
        /// Deconstructs the vector's components into named variables.
        /// </summary>
        /// <param name = "h">The H component</param>
        /// <param name = "s">The S component</param>
        /// <param name = "v">The V component</param>
        /// <param name = "a">The A component</param>
        public void Deconstruct(out float h, out float s, out float v, out float a)
        {
        }

    }
```
### Color3
```csharp
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Color3<TScalar> : IEquatable<Color3<TScalar>>, IFormattable where TScalar : IFloatingPointIeee754<TScalar>
    {
        public TScalar R;
        public TScalar G;
        public TScalar B;

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color3"/> struct.
        /// </summary>
        /// <param name = "value">The value that will be assigned to all components.</param>
        public Color3(TScalar value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color3"/> struct.
        /// </summary>
        /// <param name = "red">The red component of the color.</param>
        /// <param name = "green">The green component of the color.</param>
        /// <param name = "blue">The blue component of the color.</param>
        public Color3(TScalar red, TScalar green, TScalar blue)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color3"/> struct.
        /// </summary>
        /// <param name = "value">The red, green, and blue components of the color.</param>
        public Color3(Vector3F<TScalar> value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color3"/> struct.
        /// </summary>
        /// <param name = "rgb">A packed integer containing all three color components.
        /// The alpha component is ignored.</param>
        public Color3(int rgb)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color3"/> struct.
        /// </summary>
        /// <param name = "rgb">A packed unsigned integer containing all three color components.
        /// The alpha component is ignored.</param>
        public Color3(uint rgb)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color3"/> struct.
        /// </summary>
        /// <param name = "values">The values to assign to the red, green, and blue components of the color. This must be an array with three elements.</param>
        /// <exception cref = "ArgumentNullException">Thrown when <paramref name = "values"/> is <c>null</c>.</exception>
        /// <exception cref = "ArgumentOutOfRangeException">Thrown when <paramref name = "values"/> contains more or less than four elements.</exception>
        public Color3(TScalar[] values)
        {
        }

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <value>The value of the red, green, or blue component, depending on the index.</value>
        /// <param name = "index">The index of the component to access. Use 0 for the red component, 1 for the green component, and 2 for the blue component.</param>
        /// <returns>The value of the component at the specified index.</returns>
        /// <exception cref = "System.ArgumentOutOfRangeException">Thrown when the <paramref name = "index"/> is out of the range [0, 2].</exception>
        public TScalar this[int index] { get; set; }

        /// <summary>
        /// Converts the color into a packed integer.
        /// </summary>
        /// <returns>A packed integer containing all three color components.
        /// The alpha channel is set to 255.</returns>
        public int ToRgb() 
            => default;

        /// <summary>
        /// Raises the exponent for each components.
        /// </summary>
        /// <param name = "exponent">The exponent.</param>
        public void Pow(TScalar exponent)
        {
        }

        /// <summary>
        /// Converts the color into a three component vector.
        /// </summary>
        /// <returns>A three component vector containing the red, green, and blue components of the color.</returns>
        public Vector3F<TScalar> ToVector3<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Creates an array containing the elements of the color.
        /// </summary>
        /// <returns>A three-element array containing the components of the color.</returns>
        public TScalar[] ToArray() 
            => default;

        /// <summary>
        /// Converts this color from linear space to sRGB space.
        /// </summary>
        /// <returns>A color3 in sRGB space.</returns>
        public Color3<TScalar> ToSRgb<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Converts this color from sRGB space to linear space.
        /// </summary>
        /// <returns>Color3.</returns>
        public Color3<TScalar> ToLinear<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Adds two colors.
        /// </summary>
        /// <param name = "left">The first color to add.</param>
        /// <param name = "right">The second color to add.</param>
        /// <returns>The sum of the two colors.</returns>
        public static Color3<TScalar> operator +(Color3<TScalar> left, Color3<TScalar> right) 
            => default;

        /// <summary>
        /// Assert a color (return it unchanged).
        /// </summary>
        /// <param name = "value">The color to assert (unchange).</param>
        /// <returns>The asserted (unchanged) color.</returns>
        public static Color3<TScalar> operator +(Color3<TScalar> value) 
            => default;

        /// <summary>
        /// Subtracts two colors.
        /// </summary>
        /// <param name = "left">The first color to subtract.</param>
        /// <param name = "right">The second color to subtract.</param>
        /// <returns>The difference of the two colors.</returns>
        public static Color3<TScalar> operator -(Color3<TScalar> left, Color3<TScalar> right) 
            => default;

        /// <summary>
        /// Negates a color.
        /// </summary>
        /// <param name = "value">The color to negate.</param>
        /// <returns>A negated color.</returns>
        public static Color3<TScalar> operator -(Color3<TScalar> value) 
            => default;

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "scale">The factor by which to scale the color.</param>
        /// <param name = "value">The color to scale.</param>
        /// <returns>The scaled color.</returns>
        public static Color3<TScalar> operator *(TScalar scale, Color3<TScalar> value) 
            => default;

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "value">The factor by which to scale the color.</param>
        /// <param name = "scale">The color to scale.</param>
        /// <returns>The scaled color.</returns>
        public static Color3<TScalar> operator *(Color3<TScalar> value, TScalar scale) 
            => default;

        /// <summary>
        /// Modulates two colors.
        /// </summary>
        /// <param name = "left">The first color to modulate.</param>
        /// <param name = "right">The second color to modulate.</param>
        /// <returns>The modulated color.</returns>
        public static Color3<TScalar> operator *(Color3<TScalar> left, Color3<TScalar> right) 
            => default;

        /// <summary>
        /// Tests for equality between two objects.
        /// </summary>
        /// <param name = "left">The first value to compare.</param>
        /// <param name = "right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name = "left"/> has the same value as <paramref name = "right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator ==(Color3<TScalar> left, Color3<TScalar> right) 
            => default;

        /// <summary>
        /// Tests for inequality between two objects.
        /// </summary>
        /// <param name = "left">The first value to compare.</param>
        /// <param name = "right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name = "left"/> has a different value than <paramref name = "right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator !=(Color3<TScalar> left, Color3<TScalar> right) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Color3"/> to <see cref = "Color4"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color4<TScalar>(Color3<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Color3"/> to <see cref = "Stride.Core.Mathematics.Vector3"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Vector3F<TScalar>(Color3<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Stride.Core.Mathematics.Vector3"/> to <see cref = "Color3"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color3<TScalar>(Vector3F<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "int "/> to <see cref = "Color3"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color3<TScalar>(int value) 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public override string ToString() 
            => default;

        /// <summary>
        /// Convert this color to an equivalent <see cref = "Color4"/> with an opaque alpha.
        /// </summary>
        /// <returns>An equivalent <see cref = "Color4"/> with an opaque alpha.</returns>
        public Color4<TScalar> ToColor4<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <param name = "format">The format.</param>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public string ToString(string format) 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <param name = "formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public string ToString(IFormatProvider formatProvider) 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <param name = "format">The format.</param>
        /// <param name = "formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public string ToString(string format, IFormatProvider formatProvider) 
            => default;

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode() 
            => default;

        /// <summary>
        /// Determines whether the specified <see cref = "Color3"/> is equal to this instance.
        /// </summary>
        /// <param name = "other">The <see cref = "Color3"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref = "Color3"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals<TScalar>(Color3<TScalar> other)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Determines whether the specified <see cref = "object "/> is equal to this instance.
        /// </summary>
        /// <param name = "value">The <see cref = "object "/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref = "object "/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object value) 
            => default;

        /// <summary>
        /// Deconstructs the vector's components into named variables.
        /// </summary>
        /// <param name = "r">The R component</param>
        /// <param name = "g">The G component</param>
        /// <param name = "b">The B component</param>
        public void Deconstruct(out TScalar r, out TScalar g, out TScalar b)
        {
        }

    }
```
```csharp
    public static class Color3
    {
        /// <summary>
        /// Adds two colors.
        /// </summary>
        /// <param name = "left">The first color to add.</param>
        /// <param name = "right">The second color to add.</param>
        /// <param name = "result">When the method completes, completes the sum of the two colors.</param>
        public static void Add<TScalar>(ref readonly Color3<TScalar> left, ref readonly Color3<TScalar> right, out Color3<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Adds two colors.
        /// </summary>
        /// <param name = "left">The first color to add.</param>
        /// <param name = "right">The second color to add.</param>
        /// <returns>The sum of the two colors.</returns>
        public static Color3<TScalar> Add<TScalar>(Color3<TScalar> left, Color3<TScalar> right)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Subtracts two colors.
        /// </summary>
        /// <param name = "left">The first color to subtract.</param>
        /// <param name = "right">The second color to subtract.</param>
        /// <param name = "result">WHen the method completes, contains the difference of the two colors.</param>
        public static void Subtract<TScalar>(ref readonly Color3<TScalar> left, ref readonly Color3<TScalar> right, out Color3<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Subtracts two colors.
        /// </summary>
        /// <param name = "left">The first color to subtract.</param>
        /// <param name = "right">The second color to subtract</param>
        /// <returns>The difference of the two colors.</returns>
        public static Color3<TScalar> Subtract<TScalar>(Color3<TScalar> left, Color3<TScalar> right)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Modulates two colors.
        /// </summary>
        /// <param name = "left">The first color to modulate.</param>
        /// <param name = "right">The second color to modulate.</param>
        /// <param name = "result">When the method completes, contains the modulated color.</param>
        public static void Modulate<TScalar>(ref readonly Color3<TScalar> left, ref readonly Color3<TScalar> right, out Color3<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Modulates two colors.
        /// </summary>
        /// <param name = "left">The first color to modulate.</param>
        /// <param name = "right">The second color to modulate.</param>
        /// <returns>The modulated color.</returns>
        public static Color3<TScalar> Modulate<TScalar>(Color3<TScalar> left, Color3<TScalar> right)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "value">The color to scale.</param>
        /// <param name = "scale">The amount by which to scale.</param>
        /// <param name = "result">When the method completes, contains the scaled color.</param>
        public static void Scale<TScalar>(ref readonly Color3<TScalar> value, TScalar scale, out Color3<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "value">The color to scale.</param>
        /// <param name = "scale">The amount by which to scale.</param>
        /// <returns>The scaled color.</returns>
        public static Color3<TScalar> Scale<TScalar>(Color3<TScalar> value, TScalar scale)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Negates a color.
        /// </summary>
        /// <param name = "value">The color to negate.</param>
        /// <param name = "result">When the method completes, contains the negated color.</param>
        public static void Negate<TScalar>(ref readonly Color3<TScalar> value, out Color3<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Negates a color.
        /// </summary>
        /// <param name = "value">The color to negate.</param>
        /// <returns>The negated color.</returns>
        public static Color3<TScalar> Negate<TScalar>(Color3<TScalar> value)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Restricts a value to be within a specified range.
        /// </summary>
        /// <param name = "value">The value to clamp.</param>
        /// <param name = "min">The minimum value.</param>
        /// <param name = "max">The maximum value.</param>
        /// <param name = "result">When the method completes, contains the clamped value.</param>
        public static void Clamp<TScalar>(ref readonly Color3<TScalar> value, ref readonly Color3<TScalar> min, ref readonly Color3<TScalar> max, out Color3<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Restricts a value to be within a specified range.
        /// </summary>
        /// <param name = "value">The value to clamp.</param>
        /// <param name = "min">The minimum value.</param>
        /// <param name = "max">The maximum value.</param>
        /// <returns>The clamped value.</returns>
        public static Color3<TScalar> Clamp<TScalar>(Color3<TScalar> value, Color3<TScalar> min, Color3<TScalar> max)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Performs a linear interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <param name = "result">When the method completes, contains the linear interpolation of the two colors.</param>
        /// <remarks>
        /// This method performs the linear interpolation based on the following formula.
        /// <code>start + (end - start) * amount</code>
        /// Passing <paramref name = "amount"/> a value of 0 will cause <paramref name = "start"/> to be returned; a value of 1 will cause <paramref name = "end"/> to be returned. 
        /// </remarks>
        public static void Lerp<TScalar>(ref readonly Color3<TScalar> start, ref readonly Color3<TScalar> end, TScalar amount, out Color3<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Performs a linear interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <returns>The linear interpolation of the two colors.</returns>
        /// <remarks>
        /// This method performs the linear interpolation based on the following formula.
        /// <code>start + (end - start) * amount</code>
        /// Passing <paramref name = "amount"/> a value of 0 will cause <paramref name = "start"/> to be returned; a value of 1 will cause <paramref name = "end"/> to be returned. 
        /// </remarks>
        public static Color3<TScalar> Lerp<TScalar>(Color3<TScalar> start, Color3<TScalar> end, TScalar amount)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Performs a cubic interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <param name = "result">When the method completes, contains the cubic interpolation of the two colors.</param>
        public static void SmoothStep<TScalar>(ref readonly Color3<TScalar> start, ref readonly Color3<TScalar> end, TScalar amount, out Color3<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Performs a cubic interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <returns>The cubic interpolation of the two colors.</returns>
        public static Color3<TScalar> SmoothStep<TScalar>(Color3<TScalar> start, Color3<TScalar> end, TScalar amount)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Returns a color containing the smallest components of the specified colorss.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <param name = "result">When the method completes, contains an new color composed of the largest components of the source colorss.</param>
        public static void Max<TScalar>(ref readonly Color3<TScalar> left, ref readonly Color3<TScalar> right, out Color3<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Returns a color containing the largest components of the specified colorss.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <returns>A color containing the largest components of the source colors.</returns>
        public static Color3<TScalar> Max<TScalar>(Color3<TScalar> left, Color3<TScalar> right)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <param name = "result">When the method completes, contains an new color composed of the smallest components of the source colors.</param>
        public static void Min<TScalar>(ref readonly Color3<TScalar> left, ref readonly Color3<TScalar> right, out Color3<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <returns>A color containing the smallest components of the source colors.</returns>
        public static Color3<TScalar> Min<TScalar>(Color3<TScalar> left, Color3<TScalar> right)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Adjusts the contrast of a color.
        /// </summary>
        /// <param name = "value">The color whose contrast is to be adjusted.</param>
        /// <param name = "contrast">The amount by which to adjust the contrast.</param>
        /// <param name = "result">When the method completes, contains the adjusted color.</param>
        public static void AdjustContrast<TScalar>(ref readonly Color3<TScalar> value, TScalar contrast, out Color3<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Adjusts the contrast of a color.
        /// </summary>
        /// <param name = "value">The color whose contrast is to be adjusted.</param>
        /// <param name = "contrast">The amount by which to adjust the contrast.</param>
        /// <returns>The adjusted color.</returns>
        public static Color3<TScalar> AdjustContrast<TScalar>(Color3<TScalar> value, TScalar contrast)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Adjusts the saturation of a color.
        /// </summary>
        /// <param name = "value">The color whose saturation is to be adjusted.</param>
        /// <param name = "saturation">The amount by which to adjust the saturation.</param>
        /// <param name = "result">When the method completes, contains the adjusted color.</param>
        public static void AdjustSaturation<TScalar>(ref readonly Color3<TScalar> value, TScalar saturation, out Color3<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Adjusts the saturation of a color.
        /// </summary>
        /// <param name = "value">The color whose saturation is to be adjusted.</param>
        /// <param name = "saturation">The amount by which to adjust the saturation.</param>
        /// <returns>The adjusted color.</returns>
        public static Color3<TScalar> AdjustSaturation<TScalar>(Color3<TScalar> value, TScalar saturation)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

    }
```
### Color4
```csharp
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Color4<TScalar> : IEquatable<Color4<TScalar>>, IFormattable where TScalar : IFloatingPointIeee754<TScalar>
    {
        /// <summary>
        /// The Black color (0, 0, 0, 1).
        /// </summary>
        public static readonly Color4<TScalar> Black = new Color4<TScalar>(0.0f, 0.0f, 0.0f, 1.0f);
        /// <summary>
        /// The White color (1, 1, 1, 1).
        /// </summary>
        public static readonly Color4<TScalar> White = new Color4<TScalar>(1.0f, 1.0f, 1.0f, 1.0f);
        public TScalar R;
        public TScalar G;
        public TScalar B;
        public TScalar A;

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color4"/> struct.
        /// </summary>
        /// <param name = "value">The value that will be assigned to all components.</param>
        public Color4(TScalar value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color4"/> struct.
        /// </summary>
        /// <param name = "red">The red component of the color.</param>
        /// <param name = "green">The green component of the color.</param>
        /// <param name = "blue">The blue component of the color.</param>
        /// <param name = "alpha">The alpha component of the color.</param>
        public Color4(TScalar red, TScalar green, TScalar blue, TScalar alpha = 1f)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color4"/> struct.
        /// </summary>
        /// <param name = "value">The red, green, blue, and alpha components of the color.</param>
        public Color4(Vector4F<TScalar> value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color4"/> struct.
        /// </summary>
        /// <param name = "value">The red, green, and blue components of the color.</param>
        /// <param name = "alpha">The alpha component of the color.</param>
        public Color4(Vector3F<TScalar> value, TScalar alpha = 1f)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color4"/> struct.
        /// </summary>
        /// <param name = "rgba">A packed integer containing all four color components in RGBA order.</param>
        public Color4(uint rgba)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color4"/> struct.
        /// </summary>
        /// <param name = "rgba">A packed integer containing all four color components in RGBA order.</param>
        public Color4(int rgba)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color4"/> struct.
        /// </summary>
        /// <param name = "values">The values to assign to the red, green, blue, and alpha components of the color. This must be an array with four elements.</param>
        /// <exception cref = "ArgumentNullException">Thrown when <paramref name = "values"/> is <c>null</c>.</exception>
        /// <exception cref = "ArgumentOutOfRangeException">Thrown when <paramref name = "values"/> contains more or less than four elements.</exception>
        public Color4(TScalar[] values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color4"/> struct.
        /// </summary>
        /// <param name = "color"><see cref = "Color3"/> used to initialize the color.</param>
        public Color4(Color3<TScalar> color)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color4"/> struct.
        /// </summary>
        /// <param name = "color"><see cref = "Color"/> used to initialize the color.</param>
        public Color4(Color color)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color4"/> struct.
        /// </summary>
        /// <param name = "color"><see cref = "Color"/> used to initialize the color.</param>
        public Color4(ColorBGRA color)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Color4"/> struct.
        /// </summary>
        /// <param name = "color"><see cref = "Color3"/> used to initialize the color.</param>
        /// <param name = "alpha">The alpha component of the color.</param>
        public Color4(Color3<TScalar> color, TScalar alpha = 1f)
        {
        }

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <value>The value of the red, green, blue, and alpha components, depending on the index.</value>
        /// <param name = "index">The index of the component to access. Use 0 for the alpha component, 1 for the red component, 2 for the green component, and 3 for the blue component.</param>
        /// <returns>The value of the component at the specified index.</returns>
        /// <exception cref = "System.ArgumentOutOfRangeException">Thrown when the <paramref name = "index"/> is out of the range [0, 3].</exception>
        public TScalar this[int index] { get; set; }

        /// <summary>
        /// Converts the color into a packed integer.
        /// </summary>
        /// <returns>A packed integer containing all four color components.</returns>
        public int ToBgra() 
            => default;

        /// <summary>
        /// Converts the color into a packed integer.
        /// </summary>
        public void ToBgra(out byte r, out byte g, out byte b, out byte a)
        {
        }

        /// <summary>
        /// Converts the color into a packed integer.
        /// </summary>
        /// <returns>A packed integer containing all four color components.</returns>
        public int ToRgba() 
            => default;

        /// <summary>
        /// Converts the color into a three component vector.
        /// </summary>
        /// <returns>A three component vector containing the red, green, and blue components of the color.</returns>
        public Vector3F<TScalar> ToVector3<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Converts the color into a four component vector.
        /// </summary>
        /// <returns>A four component vector containing all four color components.</returns>
        public Vector4F<TScalar> ToVector4<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Creates an array containing the elements of the color.
        /// </summary>
        /// <returns>A four-element array containing the components of the color.</returns>
        public TScalar[] ToArray() 
            => default;

        /// <summary>
        /// Converts this color from linear space to sRGB space.
        /// </summary>
        /// <returns>A color3 in sRGB space.</returns>
        public Color4<TScalar> ToSRgb<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Converts this color from sRGB space to linear space.
        /// </summary>
        /// <returns>A color4 in linear space.</returns>
        public Color4<TScalar> ToLinear<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Adds two colors.
        /// </summary>
        /// <param name = "left">The first color to add.</param>
        /// <param name = "right">The second color to add.</param>
        /// <returns>The sum of the two colors.</returns>
        public static Color4<TScalar> operator +(Color4<TScalar> left, Color4<TScalar> right) 
            => default;

        /// <summary>
        /// Assert a color (return it unchanged).
        /// </summary>
        /// <param name = "value">The color to assert (unchanged).</param>
        /// <returns>The asserted (unchanged) color.</returns>
        public static Color4<TScalar> operator +(Color4<TScalar> value) 
            => default;

        /// <summary>
        /// Subtracts two colors.
        /// </summary>
        /// <param name = "left">The first color to subtract.</param>
        /// <param name = "right">The second color to subtract.</param>
        /// <returns>The difference of the two colors.</returns>
        public static Color4<TScalar> operator -(Color4<TScalar> left, Color4<TScalar> right) 
            => default;

        /// <summary>
        /// Negates a color.
        /// </summary>
        /// <param name = "value">The color to negate.</param>
        /// <returns>A negated color.</returns>
        public static Color4<TScalar> operator -(Color4<TScalar> value) 
            => default;

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "scale">The factor by which to scale the color.</param>
        /// <param name = "value">The color to scale.</param>
        /// <returns>The scaled color.</returns>
        public static Color4<TScalar> operator *(TScalar scale, Color4<TScalar> value) 
            => default;

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "value">The factor by which to scale the color.</param>
        /// <param name = "scale">The color to scale.</param>
        /// <returns>The scaled color.</returns>
        public static Color4<TScalar> operator *(Color4<TScalar> value, TScalar scale) 
            => default;

        /// <summary>
        /// Modulates two colors.
        /// </summary>
        /// <param name = "left">The first color to modulate.</param>
        /// <param name = "right">The second color to modulate.</param>
        /// <returns>The modulated color.</returns>
        public static Color4<TScalar> operator *(Color4<TScalar> left, Color4<TScalar> right) 
            => default;

        /// <summary>
        /// Tests for equality between two objects.
        /// </summary>
        /// <param name = "left">The first value to compare.</param>
        /// <param name = "right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name = "left"/> has the same value as <paramref name = "right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator ==(Color4<TScalar> left, Color4<TScalar> right) 
            => default;

        /// <summary>
        /// Tests for inequality between two objects.
        /// </summary>
        /// <param name = "left">The first value to compare.</param>
        /// <param name = "right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name = "left"/> has a different value than <paramref name = "right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator !=(Color4<TScalar> left, Color4<TScalar> right) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Color4"/> to <see cref = "Color3"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color3<TScalar>(Color4<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Color4"/> to <see cref = "Vector3"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Vector3F<TScalar>(Color4<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an implicit conversion from <see cref = "Color4"/> to <see cref = "Vector4"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Vector4F<TScalar>(Color4<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Vector3"/> to <see cref = "Color4"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color4<TScalar>(Vector3F<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Vector4"/> to <see cref = "Color4"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color4<TScalar>(Vector4F<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Vector3"/> to <see cref = "Color4"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Color4<TScalar>(ColorBGRA value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Vector4"/> to <see cref = "Color4"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator ColorBGRA(Color4<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "Color4"/> to <see cref = "int "/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator int (Color4<TScalar> value) 
            => default;

        /// <summary>
        /// Performs an explicit conversion from <see cref = "int "/> to <see cref = "Color4"/>.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator Color4<TScalar>(int value) 
            => default;

        /// <summary>
        /// Converts this color to an equivalent <see cref = "Color3"/>, discarding the alpha channel.
        /// </summary>
        /// <returns>An equivalent <see cref = "Color3"/>, discarding the alpha channel.</returns>
        public Color3<TScalar> ToColor3<TScalar>()
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public override string ToString() 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <param name = "format">The format to apply to each channel (float).</param>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public string ToString(string format) 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <param name = "formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public string ToString(IFormatProvider formatProvider) 
            => default;

        /// <summary>
        /// Returns a <see cref = "string "/> that represents this instance.
        /// </summary>
        /// <param name = "format">The format to apply to each channel (float).</param>
        /// <param name = "formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref = "string "/> that represents this instance.
        /// </returns>
        public string ToString(string format, IFormatProvider formatProvider) 
            => default;

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode() 
            => default;

        /// <summary>
        /// Determines whether the specified <see cref = "Color4"/> is equal to this instance.
        /// </summary>
        /// <param name = "other">The <see cref = "Color4"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref = "Color4"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals<TScalar>(Color4<TScalar> other)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Determines whether the specified <see cref = "object "/> is equal to this instance.
        /// </summary>
        /// <param name = "value">The <see cref = "object "/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref = "object "/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object value) 
            => default;

        /// <summary>
        /// Deconstructs the vector's components into named variables.
        /// </summary>
        /// <param name = "r">The R component</param>
        /// <param name = "g">The G component</param>
        /// <param name = "b">The B component</param>
        /// <param name = "a">The A component</param>
        public void Deconstruct(out TScalar r, out TScalar g, out TScalar b, out TScalar a)
        {
        }

    }
```
```csharp
    public static class Color4
    {
        /// <summary>
        /// Adds two colors.
        /// </summary>
        /// <param name = "left">The first color to add.</param>
        /// <param name = "right">The second color to add.</param>
        /// <param name = "result">When the method completes, completes the sum of the two colors.</param>
        public static void Add<TScalar>(ref readonly Color4<TScalar> left, ref readonly Color4<TScalar> right, out Color4<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Adds two colors.
        /// </summary>
        /// <param name = "left">The first color to add.</param>
        /// <param name = "right">The second color to add.</param>
        /// <returns>The sum of the two colors.</returns>
        public static Color4<TScalar> Add<TScalar>(Color4<TScalar> left, Color4<TScalar> right)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Subtracts two colors.
        /// </summary>
        /// <param name = "left">The first color to subtract.</param>
        /// <param name = "right">The second color to subtract.</param>
        /// <param name = "result">WHen the method completes, contains the difference of the two colors.</param>
        public static void Subtract<TScalar>(ref readonly Color4<TScalar> left, ref readonly Color4<TScalar> right, out Color4<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Subtracts two colors.
        /// </summary>
        /// <param name = "left">The first color to subtract.</param>
        /// <param name = "right">The second color to subtract</param>
        /// <returns>The difference of the two colors.</returns>
        public static Color4<TScalar> Subtract<TScalar>(Color4<TScalar> left, Color4<TScalar> right)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Modulates two colors.
        /// </summary>
        /// <param name = "left">The first color to modulate.</param>
        /// <param name = "right">The second color to modulate.</param>
        /// <param name = "result">When the method completes, contains the modulated color.</param>
        public static void Modulate<TScalar>(ref readonly Color4<TScalar> left, ref readonly Color4<TScalar> right, out Color4<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Modulates two colors.
        /// </summary>
        /// <param name = "left">The first color to modulate.</param>
        /// <param name = "right">The second color to modulate.</param>
        /// <returns>The modulated color.</returns>
        public static Color4<TScalar> Modulate<TScalar>(Color4<TScalar> left, Color4<TScalar> right)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "value">The color to scale.</param>
        /// <param name = "scale">The amount by which to scale.</param>
        /// <param name = "result">When the method completes, contains the scaled color.</param>
        public static void Scale<TScalar>(ref readonly Color4<TScalar> value, TScalar scale, out Color4<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Scales a color.
        /// </summary>
        /// <param name = "value">The color to scale.</param>
        /// <param name = "scale">The amount by which to scale.</param>
        /// <returns>The scaled color.</returns>
        public static Color4<TScalar> Scale<TScalar>(Color4<TScalar> value, TScalar scale)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Negates a color.
        /// </summary>
        /// <param name = "value">The color to negate.</param>
        /// <param name = "result">When the method completes, contains the negated color.</param>
        public static void Negate<TScalar>(ref readonly Color4<TScalar> value, out Color4<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Negates a color.
        /// </summary>
        /// <param name = "value">The color to negate.</param>
        /// <returns>The negated color.</returns>
        public static Color4<TScalar> Negate<TScalar>(Color4<TScalar> value)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Restricts a value to be within a specified range.
        /// </summary>
        /// <param name = "value">The value to clamp.</param>
        /// <param name = "min">The minimum value.</param>
        /// <param name = "max">The maximum value.</param>
        /// <param name = "result">When the method completes, contains the clamped value.</param>
        public static void Clamp<TScalar>(ref readonly Color4<TScalar> value, ref readonly Color4<TScalar> min, ref readonly Color4<TScalar> max, out Color4<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Restricts a value to be within a specified range.
        /// </summary>
        /// <param name = "value">The value to clamp.</param>
        /// <param name = "min">The minimum value.</param>
        /// <param name = "max">The maximum value.</param>
        /// <returns>The clamped value.</returns>
        public static Color4<TScalar> Clamp<TScalar>(Color4<TScalar> value, Color4<TScalar> min, Color4<TScalar> max)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Performs a linear interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <param name = "result">When the method completes, contains the linear interpolation of the two colors.</param>
        /// <remarks>
        /// Passing <paramref name = "amount"/> a value of 0 will cause <paramref name = "start"/> to be returned; a value of 1 will cause <paramref name = "end"/> to be returned. 
        /// </remarks>
        public static void Lerp<TScalar>(ref readonly Color4<TScalar> start, ref readonly Color4<TScalar> end, TScalar amount, out Color4<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Performs a linear interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <returns>The linear interpolation of the two colors.</returns>
        /// <remarks>
        /// Passing <paramref name = "amount"/> a value of 0 will cause <paramref name = "start"/> to be returned; a value of 1 will cause <paramref name = "end"/> to be returned. 
        /// </remarks>
        public static Color4<TScalar> Lerp<TScalar>(Color4<TScalar> start, Color4<TScalar> end, TScalar amount)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Performs a cubic interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <param name = "result">When the method completes, contains the cubic interpolation of the two colors.</param>
        public static void SmoothStep<TScalar>(ref readonly Color4<TScalar> start, ref readonly Color4<TScalar> end, TScalar amount, out Color4<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Performs a cubic interpolation between two colors.
        /// </summary>
        /// <param name = "start">Start color.</param>
        /// <param name = "end">End color.</param>
        /// <param name = "amount">Value between 0 and 1 indicating the weight of <paramref name = "end"/>.</param>
        /// <returns>The cubic interpolation of the two colors.</returns>
        public static Color4<TScalar> SmoothStep<TScalar>(Color4<TScalar> start, Color4<TScalar> end, TScalar amount)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <param name = "result">When the method completes, contains an new color composed of the largest components of the source colors.</param>
        public static void Max<TScalar>(ref readonly Color4<TScalar> left, ref readonly Color4<TScalar> right, out Color4<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Returns a color containing the largest components of the specified colors.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <returns>A color containing the largest components of the source colors.</returns>
        public static Color4<TScalar> Max<TScalar>(Color4<TScalar> left, Color4<TScalar> right)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <param name = "result">When the method completes, contains an new color composed of the smallest components of the source colors.</param>
        public static void Min<TScalar>(ref readonly Color4<TScalar> left, ref readonly Color4<TScalar> right, out Color4<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Returns a color containing the smallest components of the specified colors.
        /// </summary>
        /// <param name = "left">The first source color.</param>
        /// <param name = "right">The second source color.</param>
        /// <returns>A color containing the smallest components of the source colors.</returns>
        public static Color4<TScalar> Min<TScalar>(Color4<TScalar> left, Color4<TScalar> right)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Adjusts the contrast of a color.
        /// </summary>
        /// <param name = "value">The color whose contrast is to be adjusted.</param>
        /// <param name = "contrast">The amount by which to adjust the contrast.</param>
        /// <param name = "result">When the method completes, contains the adjusted color.</param>
        public static void AdjustContrast<TScalar>(ref readonly Color4<TScalar> value, TScalar contrast, out Color4<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Adjusts the contrast of a color.
        /// </summary>
        /// <param name = "value">The color whose contrast is to be adjusted.</param>
        /// <param name = "contrast">The amount by which to adjust the contrast.</param>
        /// <returns>The adjusted color.</returns>
        public static Color4<TScalar> AdjustContrast<TScalar>(Color4<TScalar> value, TScalar contrast)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Adjusts the saturation of a color.
        /// </summary>
        /// <param name = "value">The color whose saturation is to be adjusted.</param>
        /// <param name = "saturation">The amount by which to adjust the saturation.</param>
        /// <param name = "result">When the method completes, contains the adjusted color.</param>
        public static void AdjustSaturation<TScalar>(ref readonly Color4<TScalar> value, TScalar saturation, out Color4<TScalar> result)
            where TScalar : IFloatingPointIeee754<TScalar>
        {
        }

        /// <summary>
        /// Adjusts the saturation of a color.
        /// </summary>
        /// <param name = "value">The color whose saturation is to be adjusted.</param>
        /// <param name = "saturation">The amount by which to adjust the saturation.</param>
        /// <returns>The adjusted color.</returns>
        public static Color4<TScalar> AdjustSaturation<TScalar>(Color4<TScalar> value, TScalar saturation)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

        /// <summary>
        /// Premultiplies the color components by the alpha value.
        /// </summary>
        /// <param name = "value">The color to premultiply.</param>
        /// <returns>A color with premultiplied alpha.</returns>
        public static Color4<TScalar> PremultiplyAlpha<TScalar>(Color4<TScalar> value)
            where TScalar : IFloatingPointIeee754<TScalar> 
            => default;

    }
```


# Meeting Agenda/Notes
## TBD
* Started with an initial rough cut by copying the API of Stride color types. IF we want to move forward with these we can just copy and attribute.