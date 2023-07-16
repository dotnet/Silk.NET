// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SVGScriptElement"/> struct.</summary>
public static unsafe partial class SVGScriptElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SVGScriptElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SVGScriptElement).GUID, Is.EqualTo(IID_SVGScriptElement));
    }

    /// <summary>Validates that the <see cref = "SVGScriptElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SVGScriptElement>(), Is.EqualTo(sizeof(SVGScriptElement)));
    }

    /// <summary>Validates that the <see cref = "SVGScriptElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SVGScriptElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SVGScriptElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SVGScriptElement), Is.EqualTo(1));
    }
}