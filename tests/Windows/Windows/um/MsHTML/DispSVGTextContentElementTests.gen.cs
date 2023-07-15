// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DispSVGTextContentElement"/> struct.</summary>
public static unsafe partial class DispSVGTextContentElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DispSVGTextContentElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispSVGTextContentElement).GUID, Is.EqualTo(IID_DispSVGTextContentElement));
    }

    /// <summary>Validates that the <see cref = "DispSVGTextContentElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispSVGTextContentElement>(), Is.EqualTo(sizeof(DispSVGTextContentElement)));
    }

    /// <summary>Validates that the <see cref = "DispSVGTextContentElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispSVGTextContentElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DispSVGTextContentElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispSVGTextContentElement), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispSVGTextContentElement), Is.EqualTo(4));
        }
    }
}