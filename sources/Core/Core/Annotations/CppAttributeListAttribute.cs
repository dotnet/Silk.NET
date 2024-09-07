using System.Diagnostics;

namespace Silk.NET.Core;

/// <summary>Denotes the parsed C++ attributes on the original signature as a <c>^</c> separated string.</summary>
[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
[Conditional("DEBUG")]
public sealed class CppAttributeListAttribute : Attribute
{
    /// <summary>Initializes a new instance of the <see cref="CppAttributeListAttribute" /> class.</summary>
    /// <param name="attributeList"><c>^</c> separated string of C++ attributes.</param>
    public CppAttributeListAttribute(string attributeList) => AttributeList = attributeList;

    /// <summary><c>^</c> separated string of attributes.</summary>
    public string AttributeList { get; }
}
