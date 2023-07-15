// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IHTMLHRElement"/> struct.</summary>
public static unsafe partial class IHTMLHRElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHTMLHRElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHTMLHRElement).GUID, Is.EqualTo(IID_IHTMLHRElement));
    }

    /// <summary>Validates that the <see cref = "IHTMLHRElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHTMLHRElement>(), Is.EqualTo(sizeof(IHTMLHRElement)));
    }

    /// <summary>Validates that the <see cref = "IHTMLHRElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHTMLHRElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHTMLHRElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHTMLHRElement), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHTMLHRElement), Is.EqualTo(4));
        }
    }
}