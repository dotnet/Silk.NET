// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "INameSpaceTreeControlEvents"/> struct.</summary>
public static unsafe partial class INameSpaceTreeControlEventsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "INameSpaceTreeControlEvents"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(INameSpaceTreeControlEvents).GUID, Is.EqualTo(IID_INameSpaceTreeControlEvents));
    }

    /// <summary>Validates that the <see cref = "INameSpaceTreeControlEvents"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INameSpaceTreeControlEvents>(), Is.EqualTo(sizeof(INameSpaceTreeControlEvents)));
    }

    /// <summary>Validates that the <see cref = "INameSpaceTreeControlEvents"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INameSpaceTreeControlEvents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "INameSpaceTreeControlEvents"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(INameSpaceTreeControlEvents), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(INameSpaceTreeControlEvents), Is.EqualTo(4));
        }
    }
}