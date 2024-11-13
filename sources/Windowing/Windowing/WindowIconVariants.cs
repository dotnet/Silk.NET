using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

/// <summary>
/// One or more <see cref="WindowIcon" />s representing multiple variants (e.g. for size/DPI differences) of the same
/// window icon.
/// </summary>
public ref struct WindowIconVariants
#if NET9_0_OR_GREATER
    : IEnumerable
#endif
{
    /// <summary>
    /// The maximum number of variants.
    /// </summary>
    public const int MaxVariants = 16;

    private int _count;
    private WindowIcon _e0;
    private WindowIcon _e1;
    private WindowIcon _e2;
    private WindowIcon _e3;
    private WindowIcon _e4;
    private WindowIcon _e5;
    private WindowIcon _e6;
    private WindowIcon _e7;
    private WindowIcon _e8;
    private WindowIcon _e9;
    private WindowIcon _e10;
    private WindowIcon _e11;
    private WindowIcon _e12;
    private WindowIcon _e13;
    private WindowIcon _e14;
    private WindowIcon _e15;

    /// <summary>
    /// Gets or sets the window icon variant at the given index.
    /// </summary>
    [UnscopedRef]
    public ref WindowIcon this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            // csharpier-ignore-start
            // ReSharper disable EnforceIfStatementBraces - for readability/editability
            // ReSharper disable ConvertIfStatementToSwitchStatement - false positive
            if (index == 0) return ref _e0;
            if (index == 1) return ref _e1;
            if (index == 2) return ref _e2;
            if (index == 3) return ref _e3;
            if (index == 4) return ref _e4;
            if (index == 5) return ref _e5;
            if (index == 6) return ref _e6;
            if (index == 7) return ref _e7;
            if (index == 8) return ref _e8;
            if (index == 9) return ref _e9;
            if (index == 10) return ref _e10;
            if (index == 11) return ref _e11;
            if (index == 12) return ref _e12;
            if (index == 13) return ref _e13;
            if (index == 14) return ref _e14;
            if (index == 15) return ref _e15;
            throw new ArgumentOutOfRangeException(nameof(index));
            // ReSharper restore ConvertIfStatementToSwitchStatement
            // ReSharper restore EnforceIfStatementBraces
            // csharpier-ignore-end
        }
    }

    /// <summary>
    /// Creates a window icon with just one variant.
    /// </summary>
    public WindowIconVariants(WindowIcon icon)
    {
        _e0 = icon;
        _count = 1;
    }

    /// <summary>
    /// Gets the number of variants within this window icon.
    /// </summary>
    public int Count => _count;

    /// <summary>
    /// Adds a variant.
    /// </summary>
    /// <param name="icon">The variant to add.</param>
    public void Add(WindowIcon icon)
    {
        if (_count == MaxVariants)
        {
            throw new InvalidOperationException(
                "The maximum number of variants have been reached."
            );
        }

        this[_count++] = icon;
    }

    /// <summary>
    /// Removes the variant at the given index.
    /// </summary>
    /// <param name="i">The index to remove at. All elements thereafter will be shifted left by one.</param>
    public void RemoveAt(int i)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(i, _count);
        for (var j = i; j < _count - 1; j++)
        {
            this[j] = this[j + 1];
        }

        _count--;
    }

    /// <summary>
    /// Converts a <see cref="WindowIcon" /> into a <see cref="WindowIconVariants" /> with one variant.
    /// </summary>
    /// <param name="icon">The icon.</param>
    /// <returns>The single-variant <see cref="WindowIconVariants" /> incorporating <paramref name="icon" /></returns>
    public static implicit operator WindowIconVariants(WindowIcon icon) => new(icon);

    /// <summary>
    /// Enumerates the variants contained within this <see cref="WindowIconVariants" />.
    /// </summary>
    /// <returns>An enumerator.</returns>
    public Enumerator GetEnumerator() => new(this);

#if NET9_0_OR_GREATER
    // Will return byte[,] elements, this is only implemented to make collection/initializer expressions to light up.
    // Not implementing the generic interface to further discourage use.
    // Ref structs can only implement interfaces as of C# 13/.NET 9
    IEnumerator IEnumerable.GetEnumerator()
    {
        // Dear god this is terrible, it's a good thing noone will ever use it.
        var array = new byte[_count][,];
        for (var i = 0; i < _count; i++)
        {
            var icon = this[i];
            array[i] = new byte[icon.Width, icon.Height];
            for (var x = 0; x < icon.Width; x++)
            {
                for (var y = 0; y < icon.Height; y++)
                {
                    array[i][x, y] = icon.Data[(y * icon.Width) + x];
                }
            }
        }

        return array.GetEnumerator();
    }
#endif

    /// <summary>
    /// An enumerator over <see cref="WindowIcon" />s contained in <see cref="WindowIconVariants" />. This can only be
    /// created using <see cref="GetEnumerator" />.
    /// </summary>
    public ref struct Enumerator
    {
        private WindowIconVariants _variants;
        private int _current;

        internal Enumerator(WindowIconVariants variants) => _variants = variants;

        /// <summary>
        /// The output from <see cref="MoveNext" /> if that returned <c>true</c>.
        /// </summary>
        // --------------------------vvvvvvvvvvvvv---------- protect against default(WindowIconVariants.Enumerator)
        public WindowIcon Current => _current == 0 ? default : _variants[_current - 1];

        /// <summary>
        /// Retrieves the next variant. This must be called before reading the first element (and every subsequent
        /// element).
        /// </summary>
        public bool MoveNext()
        {
            if (_current >= _variants.Count)
            {
                return false;
            }

            _current++;
            return true;
        }

        /// <summary>
        /// Resets the enumerator back to its initial state. Note that <see cref="MoveNext" /> must be called before
        /// retrieving an element again.
        /// </summary>
        public void Reset() => _current = 0;
    }
}
