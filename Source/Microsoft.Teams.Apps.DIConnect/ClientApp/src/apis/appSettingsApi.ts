// <copyright file="appSettingsApi.ts" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

import axios from './axiosJWTDecorator';
import { getBaseUrl } from '../configVariables';

let baseAxiosUrl = getBaseUrl() + '/api';

/**
* Method to get application configuration values.
*/
export const getAppId = async (): Promise<any> => {
    let url = baseAxiosUrl + "/settings";
    return await axios.get(url);
}