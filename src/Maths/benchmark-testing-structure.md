Each individual operation should eventually receive one or preferably multiple benchmarks and tests per `T`.

First up: `Scalar`

Each operation should receive a test in the form of:

(replace `[T]` with the actual type, and `Operation` with the actual method)
```cs
[Theory]
[InlineData(....)]
[InlineData(....)]
public void Operation[T]([T] expected, [T] a, [T] b)
{
    var actual = Scalar.Operation(a, b);
    Assert.Equal(expected, actual);
}
```

and a benchmark in the form of:
(only include the System* benchmarks and decimal type where applicable)
```cs
[GenericTypeArguments(typeof(byte))]
[GenericTypeArguments(typeof(sbyte))]
[GenericTypeArguments(typeof(ushort))]
[GenericTypeArguments(typeof(uint))]
[GenericTypeArguments(typeof(int))]
[GenericTypeArguments(typeof(ulong))]
[GenericTypeArguments(typeof(long))]
[GenericTypeArguments(typeof(Half))]
[GenericTypeArguments(typeof(float))]
[GenericTypeArguments(typeof(double))]
[GenericTypeArguments(typeof(decimal))]
public class ScalarOperation<T>
    where T : unmanaged
{
    [Params(....)]
    public T A { get; set; }

    [Params(....)]
    public T B { get; set; }

    [Benchmark]
    [BenchmarkCategory("Silk")]
    public T Silk()
    {
        return Scalar.Operation(A, B);
    }

    private float AF;
    private float BF;

    private double AD;
    private double BD;

    [GlobalSetup]
    public void Setup()
    {
        AF = Scalar.As<T, float>(A);
        BF = Scalar.As<T, float>(B);

        AD = Scalar.As<T, double>(A);
        BD = Scalar.As<T, double>(B);
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("System", "Single")]
    public float SystemF()
    {
        return MathF.Operation(AF, BF);
    }

    [Benchmark]
    [BenchmarkCategory("System", "Double")]
    public float SystemD()
    {
        return Math.Operation(AD, BD);
    }
}