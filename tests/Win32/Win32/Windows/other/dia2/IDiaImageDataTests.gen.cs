// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IDiaImageData"/> struct.</summary>
public static unsafe partial class IDiaImageDataTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDiaImageData"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDiaImageData).GUID, Is.EqualTo(IID_IDiaImageData));
    }

    /// <summary>Validates that the <see cref = "IDiaImageData"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDiaImageData>(), Is.EqualTo(sizeof(IDiaImageData)));
    }

    /// <summary>Validates that the <see cref = "IDiaImageData"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDiaImageData).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDiaImageData"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDiaImageData), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDiaImageData), Is.EqualTo(4));
        }
    }
}
