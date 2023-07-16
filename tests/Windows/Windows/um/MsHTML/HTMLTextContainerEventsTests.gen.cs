// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTMLTextContainerEvents"/> struct.</summary>
public static unsafe partial class HTMLTextContainerEventsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLTextContainerEvents"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLTextContainerEvents).GUID, Is.EqualTo(IID_HTMLTextContainerEvents));
    }

    /// <summary>Validates that the <see cref = "HTMLTextContainerEvents"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLTextContainerEvents>(), Is.EqualTo(sizeof(HTMLTextContainerEvents)));
    }

    /// <summary>Validates that the <see cref = "HTMLTextContainerEvents"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLTextContainerEvents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLTextContainerEvents"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(HTMLTextContainerEvents), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(HTMLTextContainerEvents), Is.EqualTo(4));
        }
    }
}