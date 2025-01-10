// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG"/> struct.</summary>
public static unsafe partial class CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIGTests
{
    /// <summary>Validates that the <see cref = "CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG>(),
            Is.EqualTo(sizeof(CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG))
        );
    }

    /// <summary>Validates that the <see cref = "CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG), Is.EqualTo(8));
        }
    }
}
