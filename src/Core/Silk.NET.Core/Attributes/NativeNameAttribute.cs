// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class NativeNameAttribute : Attribute
    {
        public NativeNameAttribute(string category, string name)
        {
            Category = category;
            Name = name;
        }

        public string Category { get; }
        public string Name { get; }
    }
}
