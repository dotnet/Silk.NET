namespace GenerateMatrixMath.Model
{
    using System.Collections.Immutable;

    public record class Vector(int Size, IEnumerable<int> Sizes, HashSet<Dimension> AllSizes, Type[] Casts, Type[] NumericsTypes, Type[] Intrinsics, IEnumerable<Extension> Extensions, IEnumerable<ExtensionProperty> ExtensionProperties)
    {
        public static readonly ImmutableList<string> VectorFieldNames = ["X", "Y", "Z", "W"];
    }
}
