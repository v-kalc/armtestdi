// <copyright file="appSettingsApi.ts" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>



export const getAppId = async () => {
    let appid = "bc7c2e05-ebbc-42a8-b813-90c30b0dfd69";
    let httpStatusCode = "200";

    return Promise.resolve({
        data: appid,
        status: httpStatusCode
    });
}