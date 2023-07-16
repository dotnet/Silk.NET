// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IHWEventHandler"/> struct.</summary>
public static unsafe partial class IHWEventHandlerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHWEventHandler"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHWEventHandler).GUID, Is.EqualTo(IID_IHWEventHandler));
    }

    /// <summary>Validates that the <see cref = "IHWEventHandler"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHWEventHandler>(), Is.EqualTo(sizeof(IHWEventHandler)));
    }

    /// <summary>Validates that the <see cref = "IHWEventHandler"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHWEventHandler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHWEventHandler"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHWEventHandler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHWEventHandler), Is.EqualTo(4));
        }
    }
}