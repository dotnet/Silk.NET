// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum RENDEZVOUS_SESSION_STATE
{
    RSS_UNKNOWN = 0,
    RSS_READY = (RSS_UNKNOWN + 1),
    RSS_INVITATION = (RSS_READY + 1),
    RSS_ACCEPTED = (RSS_INVITATION + 1),
    RSS_CONNECTED = (RSS_ACCEPTED + 1),
    RSS_CANCELLED = (RSS_CONNECTED + 1),
    RSS_DECLINED = (RSS_CANCELLED + 1),
    RSS_TERMINATED = (RSS_DECLINED + 1),
}
