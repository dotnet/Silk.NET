// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IDiaStackWalker2"/> struct.</summary>
public static unsafe partial class IDiaStackWalker2Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDiaStackWalker2"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDiaStackWalker2).GUID, Is.EqualTo(IID_IDiaStackWalker2));
    }

    /// <summary>Validates that the <see cref = "IDiaStackWalker2"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDiaStackWalker2>(), Is.EqualTo(sizeof(IDiaStackWalker2)));
    }

    /// <summary>Validates that the <see cref = "IDiaStackWalker2"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDiaStackWalker2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDiaStackWalker2"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDiaStackWalker2), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDiaStackWalker2), Is.EqualTo(4));
        }
    }
}
