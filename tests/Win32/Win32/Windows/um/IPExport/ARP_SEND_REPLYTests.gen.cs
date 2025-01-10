// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ARP_SEND_REPLY"/> struct.</summary>
public static unsafe partial class ARP_SEND_REPLYTests
{
    /// <summary>Validates that the <see cref = "ARP_SEND_REPLY"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ARP_SEND_REPLY>(), Is.EqualTo(sizeof(ARP_SEND_REPLY)));
    }

    /// <summary>Validates that the <see cref = "ARP_SEND_REPLY"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ARP_SEND_REPLY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ARP_SEND_REPLY"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ARP_SEND_REPLY), Is.EqualTo(8));
    }
}
