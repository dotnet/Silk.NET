// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DispDOMCloseEvent"/> struct.</summary>
public static unsafe partial class DispDOMCloseEventTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DispDOMCloseEvent"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispDOMCloseEvent).GUID, Is.EqualTo(IID_DispDOMCloseEvent));
    }

    /// <summary>Validates that the <see cref = "DispDOMCloseEvent"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispDOMCloseEvent>(), Is.EqualTo(sizeof(DispDOMCloseEvent)));
    }

    /// <summary>Validates that the <see cref = "DispDOMCloseEvent"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispDOMCloseEvent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DispDOMCloseEvent"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispDOMCloseEvent), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispDOMCloseEvent), Is.EqualTo(4));
        }
    }
}
