namespace GenerateMatrixMath
{
    partial class Templates
    {
        private static Dictionary<Type, string> NameCache = new();

        private static string Encode(object value) => value switch
        {
            Type type => NameCache.TryGetValue(type, out var name) ? name : NameCache[type] = type.ToCSharpString(),
            _ => value?.ToString() ?? "",
        };

        public static string Name(dynamic model)
        {
            using var writer = new StringWriter();
            Name(model, writer, null);
            return writer.ToString();
        }

        public static void Name(dynamic model, TextWriter writer, string? indentation) => RenderName(model, writer);

        public static void Ordinal(int num, TextWriter writer, string? indentation) => writer.Write(Ordinal(num));

        public static string Ordinal(int num)
        {
            if (num <= 0) return num.ToString();

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }

            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }
        }

    }
}
