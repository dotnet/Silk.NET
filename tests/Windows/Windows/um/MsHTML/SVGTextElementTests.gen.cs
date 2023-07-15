// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SVGTextElement"/> struct.</summary>
public static unsafe partial class SVGTextElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SVGTextElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SVGTextElement).GUID, Is.EqualTo(IID_SVGTextElement));
    }

    /// <summary>Validates that the <see cref = "SVGTextElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SVGTextElement>(), Is.EqualTo(sizeof(SVGTextElement)));
    }

    /// <summary>Validates that the <see cref = "SVGTextElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SVGTextElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SVGTextElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SVGTextElement), Is.EqualTo(1));
    }
}