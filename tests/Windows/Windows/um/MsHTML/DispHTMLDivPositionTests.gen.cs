// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DispHTMLDivPosition"/> struct.</summary>
public static unsafe partial class DispHTMLDivPositionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DispHTMLDivPosition"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispHTMLDivPosition).GUID, Is.EqualTo(IID_DispHTMLDivPosition));
    }

    /// <summary>Validates that the <see cref = "DispHTMLDivPosition"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispHTMLDivPosition>(), Is.EqualTo(sizeof(DispHTMLDivPosition)));
    }

    /// <summary>Validates that the <see cref = "DispHTMLDivPosition"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispHTMLDivPosition).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DispHTMLDivPosition"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispHTMLDivPosition), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispHTMLDivPosition), Is.EqualTo(4));
        }
    }
}