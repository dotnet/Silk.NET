// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IDiaSectionContrib"/> struct.</summary>
public static unsafe partial class IDiaSectionContribTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDiaSectionContrib"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDiaSectionContrib).GUID, Is.EqualTo(IID_IDiaSectionContrib));
    }

    /// <summary>Validates that the <see cref = "IDiaSectionContrib"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDiaSectionContrib>(), Is.EqualTo(sizeof(IDiaSectionContrib)));
    }

    /// <summary>Validates that the <see cref = "IDiaSectionContrib"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDiaSectionContrib).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDiaSectionContrib"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDiaSectionContrib), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDiaSectionContrib), Is.EqualTo(4));
        }
    }
}
