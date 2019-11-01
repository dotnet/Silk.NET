using System;
using System.Collections.Generic;

namespace Vk.Generator
{
    public static class Util
    {
        private static readonly Dictionary<string, int> s_typeSizes = new Dictionary<string, int>
        {
            { "byte", 1 },
            { "uint", 4 },
            { "ulong", 4 },
            { "int", 4 },
            { "float", 4 },
        };

        private static readonly HashSet<string> s_keywords = new HashSet<string>
        {
            "object",
            "event",
        };

        public static int GetTypeSize(TypeSpec type)
        {
            if (type.PointerIndirection != 0 || !s_typeSizes.TryGetValue(type.Name, out int size))
            {
                throw new InvalidOperationException();
            }

            return size;
        }

        public static string NormalizeFieldName(string name)
        {
            if (s_keywords.Contains(name))
            {
                return "@" + name;
            }

            return name;
        }
        public static void SpaceSeparatedList<T>(CsCodeWriter cw, IList<T> list, Action<T> action)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                action(item);
                if (i != list.Count - 1)
                {
                    cw.WriteLine();
                }
            }
        }
    }
}