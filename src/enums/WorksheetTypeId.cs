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
    /// Filing worksheet Type
    /// </summary>
    public enum WorksheetTypeId
    {
        /// <summary>
        /// The original filing for a period
        /// </summary>
        Original = 0,

        /// <summary>
        /// Represents an amended filing for a period
        /// </summary>
        Amended = 1,

        /// <summary>
        /// Represents a test filing
        /// </summary>
        Test = 2,

    }
}
