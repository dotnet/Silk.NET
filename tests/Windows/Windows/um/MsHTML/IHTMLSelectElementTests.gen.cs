// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IHTMLSelectElement"/> struct.</summary>
public static unsafe partial class IHTMLSelectElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHTMLSelectElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHTMLSelectElement).GUID, Is.EqualTo(IID_IHTMLSelectElement));
    }

    /// <summary>Validates that the <see cref = "IHTMLSelectElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHTMLSelectElement>(), Is.EqualTo(sizeof(IHTMLSelectElement)));
    }

    /// <summary>Validates that the <see cref = "IHTMLSelectElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHTMLSelectElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHTMLSelectElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHTMLSelectElement), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHTMLSelectElement), Is.EqualTo(4));
        }
    }
}