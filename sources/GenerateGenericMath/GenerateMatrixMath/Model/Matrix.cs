namespace GenerateMatrixMath.Model
{
    public record class Matrix(Dimension Size, HashSet<Dimension> AllSizes, Type[] Casts, Type[] NumericsTypes, IEnumerable<(Dimension Left, Dimension Right)> MultiplyFunctions, IEnumerable<(Dimension Left, Dimension Right)> MultiplyOperators)
    {
    }
}
