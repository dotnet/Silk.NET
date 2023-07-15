// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IQueueCommand"/> struct.</summary>
public static unsafe partial class IQueueCommandTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IQueueCommand"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IQueueCommand).GUID, Is.EqualTo(IID_IQueueCommand));
    }

    /// <summary>Validates that the <see cref = "IQueueCommand"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IQueueCommand>(), Is.EqualTo(sizeof(IQueueCommand)));
    }

    /// <summary>Validates that the <see cref = "IQueueCommand"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IQueueCommand).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IQueueCommand"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IQueueCommand), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IQueueCommand), Is.EqualTo(4));
        }
    }
}