// <copyright file="ApprovalStatus.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.DIConnect.Common.Repositories.EmployeeResourceGroup
{
    /// <summary>
    /// Enum values for the group approval status.
    /// </summary>
    public enum ApprovalStatus
    {
        /// <summary>
        /// Notification is sent for approval.
        /// All new notification to enable ERG searchable are created with this status.
        /// </summary>
        PendingForApproval,

        /// <summary>
        /// ERG group is approved by admin team member to make it searchable.
        /// </summary>
        Approved,

        /// <summary>
        /// Approval is rejected by admin team member to make ERG group searchable .
        /// </summary>
        Rejected,
    }
}