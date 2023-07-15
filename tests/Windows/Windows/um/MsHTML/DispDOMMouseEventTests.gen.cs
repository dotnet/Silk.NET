// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DispDOMMouseEvent"/> struct.</summary>
public static unsafe partial class DispDOMMouseEventTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DispDOMMouseEvent"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispDOMMouseEvent).GUID, Is.EqualTo(IID_DispDOMMouseEvent));
    }

    /// <summary>Validates that the <see cref = "DispDOMMouseEvent"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispDOMMouseEvent>(), Is.EqualTo(sizeof(DispDOMMouseEvent)));
    }

    /// <summary>Validates that the <see cref = "DispDOMMouseEvent"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispDOMMouseEvent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DispDOMMouseEvent"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispDOMMouseEvent), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispDOMMouseEvent), Is.EqualTo(4));
        }
    }
}