// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IHTMLIPrintCollection"/> struct.</summary>
public static unsafe partial class IHTMLIPrintCollectionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHTMLIPrintCollection"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHTMLIPrintCollection).GUID, Is.EqualTo(IID_IHTMLIPrintCollection));
    }

    /// <summary>Validates that the <see cref = "IHTMLIPrintCollection"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHTMLIPrintCollection>(), Is.EqualTo(sizeof(IHTMLIPrintCollection)));
    }

    /// <summary>Validates that the <see cref = "IHTMLIPrintCollection"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHTMLIPrintCollection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHTMLIPrintCollection"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHTMLIPrintCollection), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHTMLIPrintCollection), Is.EqualTo(4));
        }
    }
}