// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IHTMLDivElement"/> struct.</summary>
public static unsafe partial class IHTMLDivElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHTMLDivElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHTMLDivElement).GUID, Is.EqualTo(IID_IHTMLDivElement));
    }

    /// <summary>Validates that the <see cref = "IHTMLDivElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHTMLDivElement>(), Is.EqualTo(sizeof(IHTMLDivElement)));
    }

    /// <summary>Validates that the <see cref = "IHTMLDivElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHTMLDivElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHTMLDivElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHTMLDivElement), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHTMLDivElement), Is.EqualTo(4));
        }
    }
}