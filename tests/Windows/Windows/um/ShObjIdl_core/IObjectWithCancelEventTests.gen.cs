// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IObjectWithCancelEvent"/> struct.</summary>
public static unsafe partial class IObjectWithCancelEventTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IObjectWithCancelEvent"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IObjectWithCancelEvent).GUID, Is.EqualTo(IID_IObjectWithCancelEvent));
    }

    /// <summary>Validates that the <see cref = "IObjectWithCancelEvent"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IObjectWithCancelEvent>(), Is.EqualTo(sizeof(IObjectWithCancelEvent)));
    }

    /// <summary>Validates that the <see cref = "IObjectWithCancelEvent"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IObjectWithCancelEvent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IObjectWithCancelEvent"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IObjectWithCancelEvent), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IObjectWithCancelEvent), Is.EqualTo(4));
        }
    }
}