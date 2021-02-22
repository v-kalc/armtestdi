// <copyright file="SendPairUpNotificationFunctionTest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.DIConnect.Tests.PairUpFunction
{
    using Moq;
    using System;
    using Microsoft.Extensions.Localization;
    using Microsoft.Extensions.Logging;
    using Microsoft.Teams.Apps.DIConnect.Common.Repositories.UserData;
    using Microsoft.Teams.Apps.DIConnect.Common.Resources;
    using Microsoft.Teams.Apps.DIConnect.Common.Services;
    using Microsoft.Teams.Apps.DIConnect.Common.Services.Teams;
    using Microsoft.Teams.Apps.DIConnect.Send.Func;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.Extensions.Caching.Memory;
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// Class to test send pair up notification function.
    /// </summary>
    [TestClass]
    public class SendPairUpNotificationFunctionTest
    {
        Mock<UserDataRepository> userDataRepository;
        Mock<IMessageService> messageService;
        Mock<IAppSettingsService> appSettingsService;
        Mock<IStringLocalizer<Strings>> localizer;
        Mock<IMemoryCache> memoryCache;
        Mock<IHostingEnvironment> hostingEnvironment;

        SendPairUpNotificationFunction sendPairUpNotificationFunction;

        [TestInitialize]
        public void SendPairUpNotificationFunctionTestSetup()
        {
            localizer = new Mock<IStringLocalizer<Strings>>();
            var userDataLogger = new Mock<ILogger<UserDataRepository>>().Object;
            userDataRepository = new Mock<UserDataRepository>(userDataLogger, TestData.repositoryOptions);
            messageService = new Mock<IMessageService>();
            appSettingsService = new Mock<IAppSettingsService>();
            memoryCache = new Mock<IMemoryCache>();
            hostingEnvironment = new Mock<IHostingEnvironment>();

            sendPairUpNotificationFunction = new SendPairUpNotificationFunction(
                messageService.Object,
                userDataRepository.Object,
                appSettingsService.Object,
                hostingEnvironment.Object,
                memoryCache.Object,
                localizer.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SendPairUpNotificationFunction_ThrowsMessageServiceArgumentNullException()
        {
            new SendPairUpNotificationFunction(
                null,
                userDataRepository.Object,
                appSettingsService.Object,
                hostingEnvironment.Object,
                memoryCache.Object,
                localizer.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SendPairUpNotificationFunction_ThrowsUserDataRepositoryArgumentNullException()
        {
            new SendPairUpNotificationFunction(
                messageService.Object,
                null,
                appSettingsService.Object,
                hostingEnvironment.Object,
                memoryCache.Object,
                localizer.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SendPairUpNotificationFunction_ThrowsSettingServiceArgumentNullException()
        {
            new SendPairUpNotificationFunction(
                messageService.Object,
                userDataRepository.Object,
                null,
                hostingEnvironment.Object,
                memoryCache.Object,
                localizer.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SendPairUpNotificationFunction_ThrowsLocalizerArgumentNullException()
        {
            new SendPairUpNotificationFunction(
                messageService.Object,
                userDataRepository.Object,
                appSettingsService.Object,
                null,
                memoryCache.Object,
                localizer.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SendPairUpNotificationFunction_ThrowsMemoryCacheArgumentNullException()
        {
            new SendPairUpNotificationFunction(
                messageService.Object,
                userDataRepository.Object,
                appSettingsService.Object,
                hostingEnvironment.Object,
                null,
                localizer.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SendPairUpNotificationFunction_ThrowsHostingEnvirornmentArgumentNullException()
        {
            new SendPairUpNotificationFunction(
                messageService.Object,
                userDataRepository.Object,
                appSettingsService.Object,
                hostingEnvironment.Object,
                memoryCache.Object,
                null);
        }
    }
}