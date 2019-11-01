using System;

namespace Vk.Generator
{
    public class TypeSpec
    {
        public string Name { get; }
        public int PointerIndirection { get; }
        public int ArrayDimensions { get; }

        public TypeSpec(string name) : this(name, 0, 0) { }
        public TypeSpec(string name, int pointerIndirection) : this(name, pointerIndirection, 0) { }
        public TypeSpec(string name, int pointerIndirection, int arrayDimensions)
        {
            Name = name;
            PointerIndirection = pointerIndirection;
            ArrayDimensions = arrayDimensions;
        }

        public TypeSpec MapTypeSpec(TypeNameMappings tnm)
        {
            return new TypeSpec(tnm.GetMappedName(Name), PointerIndirection, ArrayDimensions);
        }

        public override string ToString()
        {
            return GetFullTypeName();
        }

        private string GetFullTypeName()
        {
            return $"{Name}{new string('*', PointerIndirection)}{GetArrayPortion()}";
        }

        private string GetArrayPortion()
        {
            if (ArrayDimensions == 0)
            {
                return string.Empty;
            }
            else if (ArrayDimensions == 1)
            {
                return "[]";
            }
            else
            {
                return $"[{new string(',', ArrayDimensions - 1)}]";
            }
        }
    }
}
