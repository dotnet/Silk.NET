// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch
{
    public readonly struct EntryPoint
    {
        public readonly string Name;
        public readonly int Slot;
        public readonly CallingConvention CallingConvention;
        public readonly TypeSyntax[] LoadTypes;

        public EntryPoint(string name, int slot, CallingConvention callingConvention, TypeSyntax[] loadTypes)
        {
            Name = name;
            Slot = slot;
            CallingConvention = callingConvention;
            LoadTypes = loadTypes;
        }
    }
}
