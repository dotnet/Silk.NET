// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DispSVGAElement"/> struct.</summary>
public static unsafe partial class DispSVGAElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DispSVGAElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispSVGAElement).GUID, Is.EqualTo(IID_DispSVGAElement));
    }

    /// <summary>Validates that the <see cref = "DispSVGAElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispSVGAElement>(), Is.EqualTo(sizeof(DispSVGAElement)));
    }

    /// <summary>Validates that the <see cref = "DispSVGAElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispSVGAElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DispSVGAElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispSVGAElement), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispSVGAElement), Is.EqualTo(4));
        }
    }
}