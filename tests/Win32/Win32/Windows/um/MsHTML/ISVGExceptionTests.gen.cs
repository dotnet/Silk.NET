// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ISVGException"/> struct.</summary>
public static unsafe partial class ISVGExceptionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISVGException"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISVGException).GUID, Is.EqualTo(IID_ISVGException));
    }

    /// <summary>Validates that the <see cref = "ISVGException"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISVGException>(), Is.EqualTo(sizeof(ISVGException)));
    }

    /// <summary>Validates that the <see cref = "ISVGException"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISVGException).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISVGException"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISVGException), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISVGException), Is.EqualTo(4));
        }
    }
}
