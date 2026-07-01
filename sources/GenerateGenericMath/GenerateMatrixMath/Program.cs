namespace GenerateMatrixMath
{
    using System.Numerics;
    using GenerateMatrixMath.Model;
    using static GenerateMatrixMath.Model.ArgumentMultiplicity;

    internal class Program
    {
        static void Main()
        {
            var casts = new[]
            {
                typeof(Half),
                typeof(float),
                typeof(double),
                typeof(decimal),
                typeof(byte),
                typeof(short),
                typeof(int),
                typeof(long),
                typeof(sbyte),
                typeof(ushort),
                typeof(uint),
                typeof(ulong),
            };

            var numericsTypes = new[]
            {
                typeof(Vector2),
                typeof(Vector3),
                typeof(Vector4),
                typeof(Matrix3x2),
                typeof(Matrix4x4),
            };

            var intrinsics = new[]
            {
                typeof(float),
                typeof(double),
                typeof(byte),
                typeof(short),
                typeof(int),
                typeof(long),
                typeof(sbyte),
                typeof(ushort),
                typeof(uint),
                typeof(ulong),
            };

            var outputPaths = new[] {
                @"C:\Users\otac0n\Projects\Silk.NET\sources\Maths\Maths\",
            };

            var dims = new HashSet<Dimension>();
            for (var r = 1; r < 4; r++)
            {
                for (var c = 1; c < 4; c++)
                {
                    dims.Add((r + 1, c + 1));
                }
            }

            dims.Add((5, 4));

            var compatible =
                from left in dims
                from right in dims
                where left.Columns == right.Rows
                let o = (left.Rows, right.Columns)
                where dims.Contains(o)
                select (left, right);
            var multiplicationFunctions =
                (from m in compatible
                 from kvp in m.left == m.right ? new[] { (key: m.left, value: m) } : [(key: m.left, value: m), (key: m.right, value: m)]
                 select kvp).ToLookup(m => m.key, m => m.value);
            var multiplicationOperators = compatible.ToLookup(m => new[] { m.left, m.right }.Max());

            var matrixModels =
                (from d in dims
                    select new Matrix(d, dims, casts, numericsTypes, multiplicationFunctions[d], multiplicationOperators[d])).ToList();

            var extensions = new Extension[]
            {
                // INumber<>
                new(typeof(INumber<>), nameof(INumber<>.Sign), [Memberwise]),
                new(typeof(INumber<>), nameof(INumber<>.Max), [Memberwise, Memberwise]),
                new(typeof(INumber<>), nameof(INumber<>.Max), [Memberwise, One]),
                new(typeof(INumber<>), nameof(INumber<>.MaxNumber), [Memberwise, Memberwise]),
                new(typeof(INumber<>), nameof(INumber<>.MaxNumber), [Memberwise, One]),
                new(typeof(INumber<>), nameof(INumber<>.Min), [Memberwise, Memberwise]),
                new(typeof(INumber<>), nameof(INumber<>.Min), [Memberwise, One]),
                new(typeof(INumber<>), nameof(INumber<>.MinNumber), [Memberwise, Memberwise]),
                new(typeof(INumber<>), nameof(INumber<>.MinNumber), [Memberwise, One]),
                new(typeof(INumber<>), nameof(INumber<>.Clamp), [Memberwise, Memberwise, Memberwise]),
                new(typeof(INumber<>), nameof(INumber<>.Clamp), [Memberwise, One, One]),
                new(typeof(INumber<>), nameof(INumber<>.CopySign), [Memberwise, Memberwise]),
                new(typeof(INumber<>), nameof(INumber<>.CopySign), [Memberwise, One]),

                // INumberBase<>
                new(typeof(INumberBase<>), nameof(INumberBase<>.Abs), [Memberwise]),
                new(typeof(INumberBase<>), nameof(INumberBase<>.MaxMagnitude), [Memberwise, Memberwise]),
                new(typeof(INumberBase<>), nameof(INumberBase<>.MaxMagnitudeNumber), [Memberwise, Memberwise]),
                new(typeof(INumberBase<>), nameof(INumberBase<>.MinMagnitude), [Memberwise, Memberwise]),
                new(typeof(INumberBase<>), nameof(INumberBase<>.MinMagnitudeNumber), [Memberwise, Memberwise]),
                new(typeof(INumberBase<>), nameof(INumberBase<>.MultiplyAddEstimate), [Memberwise, Memberwise, Memberwise]),
                new(typeof(INumberBase<>), nameof(INumberBase<>.MultiplyAddEstimate), [Memberwise, Memberwise, One]),
                new(typeof(INumberBase<>), nameof(INumberBase<>.MultiplyAddEstimate), [Memberwise, One, Memberwise]),
                new(typeof(INumberBase<>), nameof(INumberBase<>.MultiplyAddEstimate), [Memberwise, One, One]),

                // IBinaryNumber<>
                //new(typeof(IBinaryNumber<>), nameof(IBinaryNumber<>.Log2), [Memberwise]),

                // IBinaryInteger<>
                //new(typeof(IBinaryInteger<>), nameof(IBinaryInteger<>.DivRem), [Memberwise, Memberwise]), // Manual, returns a tuple.
                new(typeof(IBinaryInteger<>), nameof(IBinaryInteger<>.PopCount), [Memberwise]),
                new(typeof(IBinaryInteger<>), nameof(IBinaryInteger<>.TrailingZeroCount), [Memberwise]),

                // IFloatingPoint<>
                new(typeof(IFloatingPoint<>), nameof(IFloatingPoint<>.Ceiling), [Memberwise]),
                new(typeof(IFloatingPoint<>), nameof(IFloatingPoint<>.Floor), [Memberwise]),
                new(typeof(IFloatingPoint<>), nameof(IFloatingPoint<>.Round), [Memberwise]),
                new(typeof(IFloatingPoint<>), nameof(IFloatingPoint<>.Round), [Memberwise, One]), // BOTH: int digits & MidpointRounding mode
                new(typeof(IFloatingPoint<>), nameof(IFloatingPoint<>.Round), [Memberwise, One, One]),
                new(typeof(IFloatingPoint<>), nameof(IFloatingPoint<>.Truncate), [Memberwise]),

                // IFloatingPointIeee754<>
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.Atan2), [Memberwise, Memberwise]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.Atan2Pi), [Memberwise, Memberwise]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.Lerp), [Memberwise, Memberwise, One]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.BitDecrement), [Memberwise]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.BitIncrement), [Memberwise]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.FusedMultiplyAdd), [Memberwise, Memberwise, Memberwise]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.FusedMultiplyAdd), [Memberwise, Memberwise, One]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.FusedMultiplyAdd), [Memberwise, One, Memberwise]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.FusedMultiplyAdd), [Memberwise, One, One]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.Ieee754Remainder), [Memberwise, Memberwise]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.Ieee754Remainder), [Memberwise, One]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.ILogB), [Memberwise]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.ReciprocalEstimate), [Memberwise]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.ReciprocalSqrtEstimate), [Memberwise]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.ScaleB), [Memberwise, Memberwise]),
                new(typeof(IFloatingPointIeee754<>), nameof(IFloatingPointIeee754<>.ScaleB), [Memberwise, One]),

                // IPowerFunctions<>
                new(typeof(IPowerFunctions<>), nameof(IPowerFunctions<>.Pow), [Memberwise, Memberwise]),
                new(typeof(IPowerFunctions<>), nameof(IPowerFunctions<>.Pow), [Memberwise, One]),

                // IRootFunctions<>
                new(typeof(IRootFunctions<>), nameof(IRootFunctions<>.Cbrt), [Memberwise]),
                new(typeof(IRootFunctions<>), nameof(IRootFunctions<>.Sqrt), [Memberwise]),
                new(typeof(IRootFunctions<>), nameof(IRootFunctions<>.RootN), [Memberwise, One]),
                new(typeof(IRootFunctions<>), nameof(IRootFunctions<>.RootN), [Memberwise, Memberwise]),
                new(typeof(IRootFunctions<>), nameof(IRootFunctions<>.Hypot), [Memberwise, Memberwise]),
                new(typeof(IRootFunctions<>), nameof(IRootFunctions<>.Hypot), [Memberwise, One]),

                // ILogarithmicFunctions<>,
                new(typeof(ILogarithmicFunctions<>), nameof(ILogarithmicFunctions<>.Log), [Memberwise]),
                new(typeof(ILogarithmicFunctions<>), nameof(ILogarithmicFunctions<>.Log), [Memberwise, Memberwise]),
                new(typeof(ILogarithmicFunctions<>), nameof(ILogarithmicFunctions<>.Log), [Memberwise, One]),
                new(typeof(ILogarithmicFunctions<>), nameof(ILogarithmicFunctions<>.LogP1), [Memberwise]),
                new(typeof(ILogarithmicFunctions<>), nameof(ILogarithmicFunctions<>.Log2), [Memberwise]),
                new(typeof(ILogarithmicFunctions<>), nameof(ILogarithmicFunctions<>.Log2P1), [Memberwise]),
                new(typeof(ILogarithmicFunctions<>), nameof(ILogarithmicFunctions<>.Log10), [Memberwise]),
                new(typeof(ILogarithmicFunctions<>), nameof(ILogarithmicFunctions<>.Log10P1), [Memberwise]),

                // IExponentialFunctions<>
                new(typeof(IExponentialFunctions<>), nameof(IExponentialFunctions<>.Exp), [Memberwise]),
                new(typeof(IExponentialFunctions<>), nameof(IExponentialFunctions<>.ExpM1), [Memberwise]),
                new(typeof(IExponentialFunctions<>), nameof(IExponentialFunctions<>.Exp2), [Memberwise]),
                new(typeof(IExponentialFunctions<>), nameof(IExponentialFunctions<>.Exp2M1), [Memberwise]),
                new(typeof(IExponentialFunctions<>), nameof(IExponentialFunctions<>.Exp10), [Memberwise]),
                new(typeof(IExponentialFunctions<>), nameof(IExponentialFunctions<>.Exp10M1), [Memberwise]),

                //ITrigonometricFunctions<>
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.Acos), [Memberwise]),
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.AcosPi), [Memberwise]),
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.Asin), [Memberwise]),
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.AsinPi), [Memberwise]),
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.Atan), [Memberwise]),
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.AtanPi), [Memberwise]),
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.Cos), [Memberwise]),
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.CosPi), [Memberwise]),
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.Sin), [Memberwise]),
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.SinPi), [Memberwise]),
                //new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.SinCos), [Memberwise]), // Manual, returns a tuple.
                //new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.SinCosPi), [Memberwise]), // Manual, returns a tuple.
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.Tan), [Memberwise]),
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.TanPi), [Memberwise]),
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.DegreesToRadians), [Memberwise]),
                new(typeof(ITrigonometricFunctions<>), nameof(ITrigonometricFunctions<>.RadiansToDegrees), [Memberwise]),

                //IHyperbolicFunctions<>
                new(typeof(IHyperbolicFunctions<>), nameof(IHyperbolicFunctions<>.Acosh), [Memberwise]),
                new(typeof(IHyperbolicFunctions<>), nameof(IHyperbolicFunctions<>.Asinh), [Memberwise]),
                new(typeof(IHyperbolicFunctions<>), nameof(IHyperbolicFunctions<>.Atanh), [Memberwise]),
                new(typeof(IHyperbolicFunctions<>), nameof(IHyperbolicFunctions<>.Cosh), [Memberwise]),
                new(typeof(IHyperbolicFunctions<>), nameof(IHyperbolicFunctions<>.Sinh), [Memberwise]),
                new(typeof(IHyperbolicFunctions<>), nameof(IHyperbolicFunctions<>.Tanh), [Memberwise]),
            };

            var properties = from i in typeof(INumberBase<>).Assembly.GetTypes()
                             where i.IsInterface && i.IsGenericTypeDefinition
                             where i != typeof(INumberBase<>)
                             where i.Namespace == typeof(INumberBase<>).Namespace
                             let a = i.GetGenericArguments()
                             where a.Length == 1
                             let t = a[0]
                             from p in i.GetProperties()
                             where p.PropertyType == t
                             select new ExtensionProperty(i, p.Name);

            var sizes = Enumerable.Range(2, 3);
            var vectorModels =
                (from d in sizes
                    select new Model.Vector(d, sizes, dims, casts, numericsTypes, intrinsics, extensions, properties)).ToList();

            foreach (var outputPath in outputPaths)
            {
                Directory.CreateDirectory(outputPath);

                foreach (var model in matrixModels)
                {
                    var name = Templates.Name(new { Name = "Matrix", model.Size });

                    {
                        var path = Path.Combine(outputPath, $"{name}.gen.cs");
                        using var writer = new StreamWriter(path);
                        Templates.RenderMatrix(model, writer);
                        Console.WriteLine($"Wrote {Path.GetFileName(path)}");
                    }

                    {
                        var path = Path.Combine(outputPath, $"{name}.Ops.gen.cs");
                        using var writer = new StreamWriter(path);
                        Templates.RenderMatrixExt(model, writer);
                        Console.WriteLine($"Wrote {Path.GetFileName(path)}");
                    }
                }

                foreach (var model in vectorModels)
                {
                    var name = Templates.Name(new { Name = "Vector", model.Size });

                    {
                        var path = Path.Combine(outputPath, $"{name}.gen.cs");
                        using var writer = new StreamWriter(path);
                        Templates.RenderVector(model, writer);
                        Console.WriteLine($"Wrote {Path.GetFileName(path)}");
                    }

                    {
                        var path = Path.Combine(outputPath, $"{name}.Ops.gen.cs");
                        using var writer = new StreamWriter(path);
                        Templates.RenderVectorExt(model, writer);
                        Console.WriteLine($"Wrote {Path.GetFileName(path)}");
                    }
                }
            }
        }
    }
}
