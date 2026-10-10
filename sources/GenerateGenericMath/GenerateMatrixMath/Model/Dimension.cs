namespace GenerateMatrixMath.Model
{
    public record class Dimension(int Rows, int Columns) : IComparable<Dimension>
    {
        public int CompareTo(Dimension? other)
        {
            if (other is null)
            {
                return 1;
            }

            int comp;
            var aMax = Math.Max(this.Rows, this.Columns);
            var bMax = Math.Max(other.Rows, other.Columns);

            comp = aMax.CompareTo(bMax);
            if (comp != 0)
            {
                return comp;
            }

            var aMin = Math.Min(this.Rows, this.Columns);
            var bMin = Math.Min(other.Rows, other.Columns);

            comp = aMin.CompareTo(bMin);
            return comp;
        }

        public static implicit operator Dimension((int rows, int columns) value) => new(value.rows, value.columns);

        public override string ToString() => $"{this.Rows}x{this.Columns}";
    }
}
