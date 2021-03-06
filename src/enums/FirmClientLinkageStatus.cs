using System;

/*
 * AvaTax API Client Library
 *
 * (c) 2004-2019 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author Genevieve Conty
 * @author Greg Hester
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Account Linkage status
    /// </summary>
    public enum FirmClientLinkageStatus
    {
        /// <summary>
        /// Requested
        /// </summary>
        Requested = 1,

        /// <summary>
        /// Approved
        /// </summary>
        Approved = 2,

        /// <summary>
        /// Rejected
        /// </summary>
        Rejected = 3,

        /// <summary>
        /// Revoked
        /// </summary>
        Revoked = 4,

    }
}
