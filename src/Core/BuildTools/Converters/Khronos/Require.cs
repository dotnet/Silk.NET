using System;
using System.Xml.Linq;

namespace Vk.Generator
{
    public static class Require
    {
        public static void NotNull<T>(T obj) where T : class
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Object should not have been null.");
            }
        }

        public static void NotNullOrEmpty(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidOperationException("Value should not have been null or empty.");
            }
        }

        internal static void Equal<T>(T expected, T actual) where T : IEquatable<T>
        {
            if (!expected.Equals(actual))
            {
                throw new InvalidOperationException($"Requirement not met. Expected: {expected}, Actual: {actual}");
            }
        }
    }
}
