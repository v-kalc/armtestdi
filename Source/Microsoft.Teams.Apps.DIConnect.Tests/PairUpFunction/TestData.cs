// <copyright file="TestData.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.DIConnect.Tests.PairUpFunction
{
    using Microsoft.Extensions.Options;
    using Microsoft.Teams.Apps.DIConnect.Common.Repositories;
    using Microsoft.Teams.Apps.DIConnect.Common.Services.MessageQueues;
   
    /// <summary>
    /// Class for test data.
    /// </summary>
    public static class TestData
    {
        public static readonly IOptions<MessageQueueOptions> messageQueueOptions = Options.Create(new MessageQueueOptions()
        {
            ServiceBusConnection = ""
        });

        public static readonly IOptions<RepositoryOptions> repositoryOptions = Options.Create(new RepositoryOptions()
        {
            StorageAccountConnectionString = "",
            EnsureTableExists = false
        });
    }
}