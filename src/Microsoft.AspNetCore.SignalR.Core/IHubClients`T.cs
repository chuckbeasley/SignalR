﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.AspNetCore.SignalR
{
    public interface IHubClients<T>
    {
        T All { get; }

        T AllExcept(IReadOnlyList<string> excludedIds);

        T Client(string connectionId);

        T Clients(IReadOnlyList<string> connectionIds);

        T Group(string groupName);

        T Groups(IReadOnlyList<string> groupNames);

        T GroupExcept(string groupName, IReadOnlyList<string> excludeIds);

        T User(string userId);
    }
}

